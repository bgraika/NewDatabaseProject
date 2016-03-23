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
            businessDicts = sqlIns.JSON_to_Dict_Business("Test2.txt"); //change business table to dictionaries
            //reviewDicts = sqlIns.JSON_to_Dict_Review("Text3.txt");
            //userDicts = sqlIns.JSON_to_Dict_User("Text4.txt");
            if (mydb.OpenConnection() == true)
            {
            }

            sqlIns.Dict_to_SQL_Business(businessDicts, mydb.connect);
            //sqlIns.Dict_to_SQL_Review(reviewDicts,mydb.connect);
            //sqlIns.Dict_to_SQL_User(userDicts, mydb.connect);
        }

        //on dropdown all states in the database will appear
        private void state_dropDown_DropDown(object sender, EventArgs e)
        {
            //must make a list of strings that just holds state because all
            //we're looking for is state
            List<string> stateColumn = new List<string>();
            stateColumn.Add("state");

            string qStr = "SELECT distinct state FROM CensusData ORDER BY state;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, stateColumn);

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

            string selected_state = state_dropDown.SelectedItem.ToString(); //the selected state
            string qStr = "SELECT distinct city FROM CensusData WHERE state= '"+ selected_state + "' ORDER BY city;";
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

            string selected_city = city_listbox.SelectedItem.ToString(); //the selected state
            string qStr = "SELECT zipcode FROM CensusData WHERE city= '" + selected_city + "' ORDER BY zipcode;";
            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, cityColumn);

            zipcode_listbox.Items.Clear(); //delete old items
            //copy query results to the listbox
            for (int i = 0; i < qResult[0].Count(); i++)
            {
                zipcode_listbox.Items.Add(qResult[0][i]);
            }
        }

        //display collection of results when a zipcode is selected
        private void zipcode_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //add following items to the columns to look for
            List<string> statsColumns = new List<string>();
            statsColumns.Add("population"); //   0   //indexes of list
            statsColumns.Add("avg_income"); //   1
            statsColumns.Add("under18years"); // 2
            statsColumns.Add("18_to_24years");// 3
            statsColumns.Add("25_to_44years");// 4
            statsColumns.Add("45_to_64years");// 5
            statsColumns.Add("65_and_over");//   6
            statsColumns.Add("median_age"); //   7

            string selected_zip = zipcode_listbox.SelectedItem.ToString(); //the selected state
            string qStr = @"SELECT population,avg_income,under18years,18_to_24years,25_to_44years,
            45_to_64years,65_and_over,median_age FROM CensusData WHERE zipcode= 
            '"+ selected_zip + "';";

            List<List<string>> qResult = mydb.SQLSELECTExec(qStr, statsColumns);

            //delete old items in listboxes
            population_listbox.Items.Clear();
            avg_income_listbox.Items.Clear();
            median_age_listbox.Items.Clear();

            //copy query results to the listbox
            for (int j = 0; j < qResult.Count(); j++)
            {
                for (int i = 0; i < qResult[j].Count(); i++)
                {
                    switch (j)
                    {
                        case 0: //population
                            population_listbox.Items.Add(qResult[j][i]);
                            break;
                        case 1: //avg_income
                            avg_income_listbox.Items.Add(qResult[j][i]);
                            break;
                        case 2: //under 18 years
                            listBoxU18.Items.Add(qResult[j][i]);
                            break;
                        case 3: //18 to 24
                            listBox18.Items.Add(qResult[j][i]);
                            break;
                        case 4: //25 to 44
                            listBox25.Items.Add(qResult[j][i]);
                            break;
                        case 5: //45 to 64
                            listBox45.Items.Add(qResult[j][i]);
                            break;
                        case 6: //65 and over
                            listBox65.Items.Add(qResult[j][i]);
                            break;
                        case 7: //median age
                            median_age_listbox.Items.Add(qResult[j][i]);
                            break;
                    }//switch

                }//for2
            }//for1

        }//eo zipcode select

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }//eo form1
}//eo namespace
