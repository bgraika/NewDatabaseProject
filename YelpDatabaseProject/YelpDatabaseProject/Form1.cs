using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YelpDatabaseProject
{
    public partial class Form1 : Form
    {
        MySQL_connection mydb;
        JSON json;
        SQLInserter sqlIns;
        List<List<Dictionary<string, string>>> businessDicts;
        List<Dictionary<string, string>> reviewDicts;
        List<Dictionary<string, string>> userDicts;
        public Form1()
        {
            InitializeComponent();
            mydb = new MySQL_connection();
            sqlIns = new SQLInserter();
            businessDicts = new List<List<Dictionary<string, string>>>();
            reviewDicts = new List<Dictionary<string, string>>();
            userDicts = new List<Dictionary<string, string>>();
            string[] ex = new string[] { "hours", "neighborhoods", "friends", "compliments", "elite" };

            json = new JSON(ex);
            //json.Convert("yelp_business.json", "Test2.txt");
             //json.Convert("yelp_review.json", "Text3.txt");
            //json.Convert("yelp_user.json", "Text4.txt");
            //businessDicts = sqlIns.JSON_to_Dict_Business("Test2.txt"); //change business table to dictionaries
            //reviewDicts = sqlIns.JSON_to_Dict_Review("Text3.txt");
            //userDicts = sqlIns.JSON_to_Dict_User("Text4.txt");
            if (mydb.OpenConnection() == true)
            {
            }

            //sqlIns.Dict_to_SQL_Business(businessDicts, mydb.connect);
            //sqlIns.Dict_to_SQL_Review(reviewDicts,mydb.connect);
            //sqlIns.Dict_to_SQL_User(userDicts, mydb.connect);

            //****** set up business category checklist ******
            //must make a list of strings that just holds category because all
            //we're looking for is category
            List<string> categoryC = new List<string>();
            categoryC.Add("category");
            string qStr = "SELECT distinct category FROM categories ORDER BY category;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, categoryC);
            //copy query results to the dropdown
            for (int i = 0; i < qResult[0].Count(); i++)
            {
                busDemCheckedListBox.Items.Add(qResult[0][i]);
                checkedListBox1.Items.Add(qResult[0][i]);
            }
        }

        //on dropdown all states in the database will appear
        private void state_dropDown_DropDown(object sender, EventArgs e)
        {
            //must make a list of strings that just holds state because all
            //we're looking for is state
            List<string> stateColumn = new List<string>();
            stateColumn.Add("state");

            string qStr = "SELECT distinct state FROM business ORDER BY state;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, stateColumn);

            state_dropDown.Items.Clear();
            //copy query results to the dropdown
            for (int i = 0; i < qResult[0].Count(); i++)
            {
                state_dropDown.Items.Add(qResult[0][i]);
            }
        }

        //when a state is selected, display the cities in the city listbox
        private void state_dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //add city to the columns to look for
            List<string> cityColumn = new List<string>();
            cityColumn.Add("city");
            string stateName;

            string selected_state = state_dropDown.SelectedItem.ToString(); //the selected state

            //populate_demographics
            string[] sel_state = selected_state.Split(' ');
            stateName = convert_state_name(sel_state[1]);
            populate_demographics("state", stateName, "blank", stateName, population_listbox, avg_income_listbox, median_age_listbox, listBoxU18, listBox18, listBox25, listBox45, listBox65);

            //begin populating the city listbox
            string qStr = "SELECT distinct city FROM business WHERE state= '"+ selected_state + "' ORDER BY city;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, cityColumn);
            city_listbox.Items.Clear();//delete old items in the listbox
            //copy query results to the listbox
            for (int i = 0; i < qResult[0].Count(); i++)
            {
                city_listbox.Items.Add(qResult[0][i]);
            }
        }

        //when a city is selected display the zipcodes within that city in the zipcode listbox
        private void city_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //add zipcode to the columns to look for
            List<string> cityColumn = new List<string>();
            cityColumn.Add("zipcode");
            string cityName;

            string selected_city = city_listbox.SelectedItem.ToString(); //the selected city
            string selected_state = state_dropDown.SelectedItem.ToString(); //the selected state

            //populate_demographics
            string[] sel_state = selected_state.Split(' ');
            string[] sel_city = selected_city.Split(' ');
            //combine city names if they have spaces
            cityName = sel_city[1];
            for(int i = 2; i < sel_city.Count(); i++)
            {
                cityName += " " + sel_city[i];
            }
            string stateName = convert_state_name(sel_state[1]);
            populate_demographics("city", stateName, cityName, cityName, population_Clistbox, avg_income_Clistbox, median_age_Clistbox, listBoxCU18, listBoxC18, listBoxC25, listBoxC45, listBoxC65);

            string qStr = "SELECT zipcode FROM CensusData WHERE city= '" + cityName + "' ORDER BY zipcode;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, cityColumn);

            zipcode_listbox.Items.Clear(); //delete old items
            //copy query results to the listbox
            if (qResult.Count > 0)
            {
                for (int i = 0; i < qResult[0].Count(); i++)
                {
                    zipcode_listbox.Items.Add(qResult[0][i]);
                }
            }
        }

        //display collection of results when a zipcode is selected
        private void zipcode_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_zipcode = zipcode_listbox.SelectedItem.ToString(); //the selected city
            //populate zipcode demographics
            populate_demographics("zipcode", "blank", "blank", selected_zipcode, population_Zlistbox, avg_income_Zlistbox, median_age_Zlistbox, listBoxZU18, listBoxZ18, listBoxZ25, listBoxZ45, listBoxZ65);

        }//eo zipcode select

        private void populate_demographics(string type, string state, string city, string value, ListBox popBox, ListBox incomeBox, ListBox medAge, ListBox U18, ListBox A18, ListBox A25, ListBox A45, ListBox A65)
        {
            //add following items to the columns to look for
            List<string> statsColumns = new List<string>();
            string qStr = "blank";
            statsColumns.Add("population"); //   0   //indexes of list
            statsColumns.Add("avg_income"); //   1
            statsColumns.Add("under18years"); // 2
            statsColumns.Add("18_to_24years");// 3
            statsColumns.Add("25_to_44years");// 4
            statsColumns.Add("45_to_64years");// 5
            statsColumns.Add("65_and_over");//   6
            statsColumns.Add("median_age"); //   7

            if (type == "state")
            {
                qStr = @"SELECT SUM(population) as population,AVG(avg_income) as avg_income, AVG(under18years) as under18years,
                AVG(18_to_24years) as 18_to_24years,AVG(25_to_44years) as 25_to_44years, AVG(45_to_64years) as 45_to_64years,
                AVG(65_and_over) as 65_and_over,AVG(median_age) as median_age FROM CensusData WHERE " + type + "= '" + value + "';";
            }
            else if(type == "city")
            {
                qStr = @"SELECT SUM(population) as population,AVG(avg_income) as avg_income, AVG(under18years) as under18years,
                AVG(18_to_24years) as 18_to_24years,AVG(25_to_44years) as 25_to_44years, AVG(45_to_64years) as 45_to_64years,
                AVG(65_and_over) as 65_and_over,AVG(median_age) as median_age FROM CensusData WHERE " + type + "= '" + value + "' AND state= '" + state + "';";
            }
            else if(type == "zipcode")
            {
                qStr = @"SELECT population,avg_income,under18years,18_to_24years,25_to_44years,
                45_to_64years,65_and_over,median_age FROM CensusData WHERE " + type + "= '" + value + "';";
            }

            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, statsColumns);

            //delete old items in listboxes
            popBox.Items.Clear();
            incomeBox.Items.Clear();
            medAge.Items.Clear();
            U18.Items.Clear();
            A18.Items.Clear();
            A25.Items.Clear();
            A45.Items.Clear();
            A65.Items.Clear();
            //copy query results to the listbox
            for (int j = 0; j < qResult.Count(); j++)
            {
                for (int i = 0; i < qResult[j].Count(); i++)
                {
                    switch (j)
                    {
                        case 0: //population
                            popBox.Items.Add(qResult[j][i]);
                            break;
                        case 1: //avg_income
                            incomeBox.Items.Add(qResult[j][i]);
                            break;
                        case 2: //under 18 years
                            U18.Items.Add(qResult[j][i]);
                            break;
                        case 3: //18 to 24                 
                            A18.Items.Add(qResult[j][i]);
                            break;
                        case 4: //25 to 44
                            A25.Items.Add(qResult[j][i]);
                            break;
                        case 5: //45 to 64
                            A45.Items.Add(qResult[j][i]);
                            break;
                        case 6: //65 and over
                            A65.Items.Add(qResult[j][i]);
                            break;
                        case 7: //median age
                            medAge.Items.Add(qResult[j][i]);
                            break;
                    }//switch

                }//for2
            }//for1
        }//eo pop_demographics

        //function that converts state name initials to a full state name
        private string convert_state_name(string state)
        {
            switch(state)
            {
                case "IL":
                    return "Illinois";
                case "NC":
                    return "North Carolina";
                case "NV":
                    return "Nevada";
                case "PA":
                    return "Pennsylvania";
                case "WI":
                    return "Wisconsin";
                default:
                    return "blank";
            }
        }

        //only allow 5 items to be checked in busDemCheckedListBox
        private void busDemCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(busDemCheckedListBox.CheckedItems.Count >= 5 && e.CurrentValue != CheckState.Checked)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        //populates business summary when clicked
        private void updateBusCatButton_Click(object sender, EventArgs e)
        {
            //state business summary
            string selected_state = state_dropDown.SelectedItem.ToString(); //the selected state
            ListBox[,] listboxes = get_busSumlistBoxes("state");
            populate_busSummary("state", selected_state, listboxes);
        }
        //function that populates a business summary
        private void populate_busSummary(string type, string value, ListBox[,] listBoxes)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            string qryStr = "";
            //add business_id to the columns to look for
            List<string> bidColumn = new List<string>();
            List<string> catColumn = new List<string>();
            bidColumn.Add("id1");
            bidColumn.Add("stars");
            bidColumn.Add("review_count");

            //make a qry for each category that has been selected
            foreach (string item in busDemCheckedListBox.CheckedItems)
            {
                //first get the business_ids associated with the selected cateogry and region
                if(type == "state")
                {
                    qryStr = "select COUNT(id) as id1, AVG(stars) as stars, AVG(review_count) as review_count from business, categories Where category = '";
                    qryStr += item + "'" + " AND id = business_id AND state = '" + value + "' GROUP BY category;";
                }
                //run the query to find business_ids of the selected category
                List<List<string>> qResult = mydb.SQLSELECTExec(qryStr, bidColumn);
                
                //update the category label
                switch(i)
                {
                    case 0:
                        demCatLabel1.Text = item;
                        break;
                    case 1:
                        demCatLabel2.Text = item;
                        break;
                    case 2:
                        demCatLabel3.Text = item;
                        break;
                    case 3:
                        demCatLabel4.Text = item;
                        break;
                    case 4:
                        demCatLabel5.Text = item;
                        break;
                }
                listBoxes[i, 0].Items.Clear();
                listBoxes[i, 1].Items.Clear();
                listBoxes[i, 2].Items.Clear();
                //update the category business info
                listBoxes[i, 0].Items.Add(qResult[0][0]);
                listBoxes[i, 1].Items.Add(qResult[1][0]);
                listBoxes[i, 2].Items.Add(qResult[2][0]);

                i++;
            }


        }

        //function that puts the needed listboxes for business summary into array form
        private ListBox[,] get_busSumlistBoxes(string type)
        {
            ListBox[,] listboxes = new ListBox[5,3];
            
            if(type == "state")
            {   
                //column 1
                listboxes[0, 0] = Cat1_numB_listBox;
                listboxes[0, 1] = Cat1_Rate_listBox;
                listboxes[0, 2] = Cat1_AvgRev_listBox;

                //column 2
                listboxes[1, 0] = Cat2_numB_listBox;
                listboxes[1, 1] = Cat2_Rate_listBox;
                listboxes[1, 2] = Cat2_AvgRev_listBox;

                //column 3
                listboxes[2, 0] = Cat3_numB_listBox;
                listboxes[2, 1] = Cat3_Rate_listBox;
                listboxes[2, 2] = Cat3_AvgRev_listBox;

                //column 4
                listboxes[3, 0] = Cat4_numB_listBox;
                listboxes[3, 1] = Cat4_Rate_listBox;
                listboxes[3, 2] = Cat4_AvgRev_listBox;

                //column 5
                listboxes[4, 0] = Cat5_numB_listBox;
                listboxes[4, 1] = Cat5_Rate_listBox;
                listboxes[4, 2] = Cat5_AvgRev_listBox;
            }
            return listboxes;
        }
        // finds attributes for each given category that is checked
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            //add business_id to the columns to look for
            List<string> bidColumn = new List<string>();
            bidColumn.Add("business_id");
            List<string> attColumn = new List<string>();
            attColumn.Add("delivery");
            attColumn.Add("take_out");
            attColumn.Add("drive_thru");
            attColumn.Add("dessert");
            attColumn.Add("late_night");
            attColumn.Add("lunch");
            attColumn.Add("dinner");
            attColumn.Add("brunch");
            attColumn.Add("breakfast");
            attColumn.Add("caters");
            attColumn.Add("noise_level");
            attColumn.Add("reservations");
            attColumn.Add("romantic");
            attColumn.Add("intimate");
            attColumn.Add("classy");
            attColumn.Add("hipster");
            attColumn.Add("divey");
            attColumn.Add("touristy");
            attColumn.Add("trendy");
            attColumn.Add("upscale");
            attColumn.Add("casual");
            attColumn.Add("garage");
            attColumn.Add("street");
            attColumn.Add("validated");
            attColumn.Add("lot");
            attColumn.Add("valet");
            attColumn.Add("tv");
            attColumn.Add("outdoor_seating");
            attColumn.Add("waiter_service");
            attColumn.Add("accepts_CC");
            attColumn.Add("good_for_kids");
            attColumn.Add("good_for_groups");

            //make the qry by finding all categories that have been selected
            string qryStr = "select distinct business_id from categories Where category = '";
            foreach (string item in checkedListBox1.SelectedItems)
            {
                //if the last item is found
                if (i == checkedListBox1.SelectedItems.Count - 1)
                {
                    qryStr += item + "'" + ";";
                }
                else
                {
                    qryStr += item + "'" + " OR category = '";
                }
                i++;
            }
            //run the query to find business_ids of selected categories
            List<List<string>> qResult = mydb.SQLSELECTExec(qryStr, bidColumn);

            //get all attributes that have the same business ids as those selected
            string qryStr2 = "Select distinct * From attributes Where business_id = '";
            foreach (string busId in qResult[0])
            {
                if (j == qResult[0].Count - 1)
                {
                    qryStr2 += busId + "'" + ";";
                }
                else
                {
                    qryStr2 += busId + "'" + " OR business_id = '";
                }
                j++;
            }
            List<List<string>> qResult2 = mydb.SQLSELECTExec(qryStr2, attColumn);

            //check if attributes were found and if so add them to tree view
            foreach (string item1 in attColumn)
            {
                if (qResult2[k].Contains(" True"))
                {
                    //TreeNode node = treeView1.Nodes.IndexOfKey(item1)
                    if(!treeView1.Nodes.ContainsKey(item1))
                    {
                        treeView1.Nodes.Add(item1);
                    }
                }
                k++;
            }
        }//end of check box

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }//eo form1
}//eo namespace
