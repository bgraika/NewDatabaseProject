using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace YelpDatabaseProject
{
    class SQLInserter
    {
        public SQLInserter()
        {
        }

        public List<List<Dictionary<string, string>>> JSON_to_Dict_Business(string infile)
        {
            Dictionary<string, string> business = new Dictionary<string, string>();
            Dictionary<string, string> categories = new Dictionary<string, string>();
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            Dictionary<string, string> ambience = new Dictionary<string, string>();
            Dictionary<string, string> goodFor = new Dictionary<string, string>();
            Dictionary<string, string> parking = new Dictionary<string, string>();
            Dictionary<string, string> music = new Dictionary<string, string>();
            List<Dictionary<string, string>> businessList = new List<Dictionary<string, string>>();
            List<Dictionary<string, string>> categoriesList = new List<Dictionary<string, string>>();
            List<Dictionary<string, string>> attributesList = new List<Dictionary<string, string>>();
            List<List<Dictionary<string, string>>> dictLists = new List<List<Dictionary<string, string>>>();
            Dictionary<string, string> busTemp = new Dictionary<string, string>();
            Dictionary<string, string> atTemp = new Dictionary<string, string>();
            Dictionary<string, string> catTemp = new Dictionary<string, string>();
            int objectCounter = 0;
            int tableNum = 0;
            int skip = 0;

            string[] fileText = File.ReadAllLines(infile);
            foreach (string line in fileText)
            {
                skip = 0;
                string[] words = line.Split('=');
                if (words[0] == "{")
                {
                    objectCounter++;
                }
                if (words.Length > 1)
                {
                    if (words[1] == " {")
                    {
                        objectCounter++;
                        skip = 1;
                    }
                    else if (words[1] == " [") //only for categories case
                    {
                        objectCounter = 8;
                        skip = 1;
                    }
                    else if (words[1] == " ]")
                    {
                        //place words[0] into dict as key with a value as "NULL"
                        categories.Add(words[0], "NULL");
                        skip = 1;
                        objectCounter = 1;
                    }

                }
                if (words[0] == "}")
                {
                    objectCounter--;
                    //starting new table so add dictionaries to list
                    //and clear dictionaries
                    if (objectCounter == 0)
                    {
                        tableNum++;

                        //transfer some dictionary items into attributes
                        foreach (var item in goodFor)
                        {
                            attributes.Add(item.Key, item.Value);
                        }
                        foreach (var item2 in ambience)
                        {
                            attributes.Add(item2.Key, item2.Value);
                        }
                        foreach (var item3 in parking)
                        {
                            attributes.Add(item3.Key, item3.Value);
                        }

                        //add dictionaries to lists
                        busTemp = business.ToDictionary(k => k.Key, k => k.Value);
                        atTemp = attributes.ToDictionary(k => k.Key, k => k.Value);
                        catTemp = categories.ToDictionary(k => k.Key, k => k.Value);
                        businessList.Add(busTemp);
                        attributesList.Add(atTemp);
                        categoriesList.Add(catTemp);

                        //clear old dictionaries to be used on new table
                        business.Clear();
                        attributes.Clear();
                        categories.Clear();
                        ambience.Clear();
                        goodFor.Clear();
                        parking.Clear();
                        music.Clear();
                    }
                }
                if (words[0] == "]")
                {
                    objectCounter = 1;
                }
                if ((words).Length > 1 && skip == 0)
                {
                    words[1] = words[1].Remove(words[1].Length - 1); //remove the ;
                    switch (objectCounter) //add to right dictionary
                    {
                        case 1: business.Add(words[0], words[1]); break;
                        case 8: categories.Add(words[0], words[1]); break;
                        case 2: attributes.Add(words[0], words[1]); break;
                        case 3: goodFor.Add(words[0], words[1]); break;
                        case 4: ambience.Add(words[0], words[1]); break;
                        case 5: parking.Add(words[0], words[1]); break;
                        case 6: music.Add(words[0], words[1]); break;
                        default: break;
                    }
                }
            } //end of for each line

            dictLists.Add(businessList);
            dictLists.Add(attributesList);
            dictLists.Add(categoriesList);

            return dictLists;
        } //end of JSON_to_Dict

        public string isDBNull(Dictionary<string, string> dict, string key)
        {
            if (dict.ContainsKey(key) == true)
            {
                return dict[key];
            }
            return "NULL";
        }

        public void Dict_to_SQL_Business(List<List<Dictionary<string, string>>> dicts, MySqlConnection conn)
        {
            string stmta = "INSERT INTO attributes(business_id, delivery, take_out, drive_thru, dessert, late_night, lunch, dinner, brunch, breakfast, caters, noise_level, reservations, romantic, intimate, classy, hipster, divey, touristy, trendy, upscale, casual, garage, street, validated, lot, valet, tv, outdoor_seating, attire, alcohol, waiter_service, accepts_CC, good_for_kids, good_for_groups, price_range)";
            stmta = stmta + " VALUES (@business_id, @delivery, @take_out, @drive_thru, @dessert, @late_night, @lunch, @dinner, @brunch, @breakfast, @caters, @noise_level, @reservations, @romantic, @intimate, @classy, @hipster, @divey, @touristy, @trendy, @upscale, @casual, @garage, @street, @validated, @lot, @valet, @tv, @outdoor_seating, @attire, @alcohol, @waiter_service, @accepts_CC, @good_for_kids, @good_for_groups, @price_range)";
            string[] attArray = { "business_id ", "Delivery ", "Take-out ", "Drive-thru ", "dessert ", "latenight ", "lunch ", "dinner ", "brunch ", "breakfast ", "Caters ", "Noise Level ", "Takes Reservations ", "Romantic ", "intimate ", "classy ", "hipster ", "divey ", "touristy ", "trendy ", "upscale ", "casual ", "garage ", "street ", "validated ", "lot ", "valet ", "Has TV ", "Outdoor ", "Attire ", "Alcohol ", "Waiter Service ", "Accepts Credit Cards ", "Good For Kids ", "Good For Groups ", "Price Range " };
            string[] attNArray = { "@business_id", "@delivery", "@take_out", "@drive_thru", "@dessert", "@late_night", "@lunch", "@dinner", "@brunch", "@breakfast", "@caters", "@noise_level", "@reservations", "@romantic", "@intimate", "@classy", "@hipster", "@divey", "@touristy", "@trendy", "@upscale", "@casual", "@garage", "@street", "@validated", "@lot", "@valet", "@tv", "@outdoor_seating", "@attire", "@alcohol", "@waiter_service", "@accepts_CC", "@good_for_kids", "@good_for_groups", "@price_range" };
            string stmtb = "INSERT INTO business(id, address, open, city, name, longitude, state, stars, latitude, review_count) VALUES(@id, @address, @open, @city, @name, @longitude, @state, @stars, @latitude, @review_count)";
            string stmtc = "INSERT INTO categories(business_id, category) VALUES (@business_id, @category)";
            List<string> categoryList = new List<string>(); //will place all categories into here
            List<string> categoryListTemp = new List<string>(); //will place all categories into here
            List<List<string>> allCats = new List<List<string>>();
            //// *** set up command to insert into business table ***
            MySqlCommand cmdb = new MySqlCommand(stmtb, conn);
            cmdb.Parameters.Add("@id", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@address", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@open", MySqlDbType.VarChar, 10);
            cmdb.Parameters.Add("@city", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@review_count", MySqlDbType.Int32);
            cmdb.Parameters.Add("@name", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@longitude", MySqlDbType.Double);
            cmdb.Parameters.Add("@state", MySqlDbType.VarChar, 3);
            cmdb.Parameters.Add("@stars", MySqlDbType.Double);
            cmdb.Parameters.Add("@latitude", MySqlDbType.Double);

            //place values into business table
            for (int i = 0; i < dicts[0].Count; i++)
            {
                cmdb.Parameters["@id"].Value = dicts[0][i]["business_id "].ToString();
                cmdb.Parameters["@address"].Value = dicts[0][i]["full_address "].ToString();
                cmdb.Parameters["@open"].Value = dicts[0][i]["open "].ToString();
                cmdb.Parameters["@city"].Value = dicts[0][i]["city "].ToString();
                cmdb.Parameters["@review_count"].Value = Convert.ToInt32(dicts[0][i]["review_count "].ToString());
                cmdb.Parameters["@name"].Value = dicts[0][i]["name "].ToString();
                cmdb.Parameters["@longitude"].Value = Convert.ToDouble(dicts[0][i]["longitude "].ToString());
                cmdb.Parameters["@state"].Value = dicts[0][i]["state "].ToString();
                cmdb.Parameters["@stars"].Value = Convert.ToDouble(dicts[0][i]["stars "].ToString());
                cmdb.Parameters["@latitude"].Value = Convert.ToDouble(dicts[0][i]["latitude "].ToString());

                cmdb.ExecuteNonQuery(); //execute the insert command            
            }

            // **** Set up commands to insert into attributes table ****
            MySqlCommand cmda = new MySqlCommand(stmta, conn);
            cmda.Parameters.Add("@business_id", MySqlDbType.VarChar, 60);
            cmda.Parameters.Add("@delivery", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@take_out", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@drive_thru", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@dessert", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@late_night", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@lunch", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@dinner", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@brunch", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@breakfast", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@caters", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@noise_level", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@reservations", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@romantic", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@intimate", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@classy", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@hipster", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@divey", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@touristy", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@trendy", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@upscale", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@casual", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@garage", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@street", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@validated", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@lot", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@valet", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@tv", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@outdoor_seating", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@attire", MySqlDbType.VarChar, 30);
            cmda.Parameters.Add("@alcohol", MySqlDbType.VarChar, 30);
            cmda.Parameters.Add("@waiter_service", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@accepts_CC", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@good_for_kids", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@good_for_groups", MySqlDbType.VarChar, 10);
            cmda.Parameters.Add("@price_range", MySqlDbType.VarChar, 10);

            //loop to set the paramaters of the attribute table
            for (int j = 0; j < dicts[1].Count; j++)
            {
                for (int k = 0; k < attNArray.Length; k++)
                {
                    if (k == 0)
                    {
                        cmda.Parameters[attNArray[k]].Value = dicts[0][j]["business_id "].ToString();
                    }
                    else if (k == attNArray.Length - 1)//account for price range which is int
                    {
                        if (isDBNull(dicts[1][j], attArray[k]).ToString() != "NULL")
                        {
                            cmda.Parameters[attNArray[k]].Value = Convert.ToInt32((isDBNull(dicts[1][j], attArray[k]).ToString()));
                        }
                        else
                        {
                            cmda.Parameters[attNArray[k]].Value = null;
                        }
                    }
                    else
                    {
                        cmda.Parameters[attNArray[k]].Value = isDBNull(dicts[1][j], attArray[k]);
                    }
                }
                cmda.ExecuteNonQuery(); //execute the insert command 
            } //eo attribute table inserts

            // **** Set up commands to insert into categories table ****
            MySqlCommand cmdc = new MySqlCommand(stmtc, conn);
            cmdc.Parameters.Add("@business_id", MySqlDbType.VarChar, 60);
            cmdc.Parameters.Add("@category", MySqlDbType.VarChar, 60);

            for (int c = 0; c < dicts[2].Count; c++) //place all categories into a list
            {
                foreach (string key in dicts[2][c].Keys)
                {
                    categoryList.Add(key);
                    if (dicts[2][c][key] != "NULL")
                    {
                        categoryList.Add(dicts[2][c][key]);
                    }
                }
                categoryListTemp = categoryList.ToList();                
                allCats.Add(categoryListTemp);
                categoryList.Clear();
            }

            for(int d = 0; d < allCats.Count; d++)
            {
                foreach(string val in allCats[d])
                {
                    cmdc.Parameters["@business_id"].Value = dicts[0][d]["business_id "].ToString();
                    cmdc.Parameters["@category"].Value = val;
                    cmdc.ExecuteNonQuery(); //execute the insert command 
                }
            }
        } //end of Dict_to_SQL_Business

        public List<Dictionary<string, string>> JSON_to_Dict_Review(string infile)
        {
            Dictionary<string, string> review = new Dictionary<string, string>();
            List<Dictionary<string, string>> reviewList = new List<Dictionary<string, string>>();
            Dictionary<string, string> reviewTemp = new Dictionary<string, string>();
            int objectCounter = 0;
            int skip = 0;
            string[] attNames = { "votes ", "funny ", "useful ", "cool ", "user_id ", "review_id ", "stars ", "date ", "text ", "type ", "business_id " };
            string[] fileText = File.ReadAllLines(infile);
            int linenum = 0;

            foreach (string line in fileText)
            {
                if (linenum > 40000)
                {
                    break;
                }
                skip = 0;
                string[] words = line.Split('=');
                if (words[0] == "{")
                {
                    objectCounter++;
                }
                if (words.Length > 1)
                {
                    if (words[1] == " {")
                    {
                        objectCounter++;
                        skip = 1;
                    }
                }
                if (words[0] == "}")
                {
                    objectCounter--;
                    //starting new table so add dictionaries to list
                    //and clear dictionaries
                    if (objectCounter == 0)
                    {
                        //add dictionaries to lists
                        reviewTemp = review.ToDictionary(k => k.Key, k => k.Value);
                        reviewList.Add(reviewTemp);

                        //clear old dictionaries to be used on new table
                        review.Clear();
                    }
                }
                if ((words).Length > 1 && (words).Length < 3 && skip == 0 && attNames.Contains(words[0]))
                {
                    if (words[1].Length > 1000) //cut some of text if its too long
                    {
                        words[1] = words[1].Remove(words[1].Length - (words[1].Length - 1001));
                    }
                    words[1] = words[1].Remove(words[1].Length - 1); //remove the ;
                    review.Add(words[0], words[1]);
                }
                linenum++;
            } //end of for each line
            return reviewList;
        } //end of JSON_to_Dict_review

        public void Dict_to_SQL_Review(List<Dictionary<string, string>> revdicts, MySqlConnection conn)
        {
            string stmtr = "INSERT INTO review(business_id, user_id, cool, type, funny, text, review_id, stars, date, useful) VALUES(@business_id, @user_id, @cool, @type, @funny, @text, @review_id, @stars, @date, @useful)";

            //// *** set up command to insert into business table ***
            MySqlCommand cmdb = new MySqlCommand(stmtr, conn);
            cmdb.Parameters.Add("@business_id", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@user_id", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@cool", MySqlDbType.Int32);
            cmdb.Parameters.Add("@type", MySqlDbType.VarChar, 20);
            cmdb.Parameters.Add("@funny", MySqlDbType.Int32);
            cmdb.Parameters.Add("@text", MySqlDbType.VarChar, 1000);
            cmdb.Parameters.Add("@review_id", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@stars", MySqlDbType.Int32);
            cmdb.Parameters.Add("@date", MySqlDbType.DateTime);
            cmdb.Parameters.Add("@useful", MySqlDbType.Int32);

            //place values into business table
            for (int i = 0; i < revdicts.Count; i++)
            {
                if (i == 941)
                {

                }
                cmdb.Parameters["@business_id"].Value = revdicts[i]["business_id "].ToString();
                cmdb.Parameters["@user_id"].Value = revdicts[i]["user_id "].ToString();
                cmdb.Parameters["@cool"].Value = Convert.ToInt32(revdicts[i]["cool "].ToString());
                cmdb.Parameters["@type"].Value = revdicts[i]["type "].ToString();
                cmdb.Parameters["@funny"].Value = Convert.ToInt32(revdicts[i]["funny "].ToString());
                cmdb.Parameters["@text"].Value = isDBNull(revdicts[i], "text ");
                cmdb.Parameters["@review_id"].Value = revdicts[i]["review_id "].ToString();
                cmdb.Parameters["@stars"].Value = Convert.ToInt32(revdicts[i]["stars "].ToString());
                cmdb.Parameters["@date"].Value = Convert.ToDateTime(revdicts[i]["date "].ToString());
                cmdb.Parameters["@useful"].Value = Convert.ToInt32(revdicts[i]["useful "].ToString());

                cmdb.ExecuteNonQuery(); //execute the insert command            
            }
        }// end of dict_to_sql_review

        public List<Dictionary<string, string>> JSON_to_Dict_User(string infile)
        {
            Dictionary<string, string> user = new Dictionary<string, string>();
            List<Dictionary<string, string>> userList = new List<Dictionary<string, string>>();
            Dictionary<string, string> userTemp = new Dictionary<string, string>();
            int objectCounter = 0;
            int skip = 0;
            string[] attNames = { "votes ", "funny ", "useful ", "cool ", "user_id ", "review_id ", "stars ", "date ", "text ", "type ", "business_id " };
            string[] fileText = File.ReadAllLines(infile);

            foreach (string line in fileText)
            {
                skip = 0;
                string[] words = line.Split('=');
                if (words[0] == "{")
                {
                    objectCounter++;
                }
                if (words.Length > 1)
                {
                    if (words[1] == " {")
                    {
                        objectCounter++;
                        skip = 1;
                    }
                }
                if (words[0] == "}")
                {
                    objectCounter--;
                    //starting new table so add dictionaries to list
                    //and clear dictionaries
                    if (objectCounter == 0)
                    {
                        //add dictionaries to lists
                        userTemp = user.ToDictionary(k => k.Key, k => k.Value);
                        userList.Add(userTemp);

                        //clear old dictionaries to be used on new table
                        user.Clear();
                    }
                }
                if ((words).Length > 1 && (words).Length < 3 && skip == 0)
                {
                    words[1] = words[1].Remove(words[1].Length - 1); //remove the ;
                    user.Add(words[0], words[1]);
                }
            } //end of for each line
            return userList;
        } //end of JSON_to_Dict_User

        public void Dict_to_SQL_User(List<Dictionary<string, string>> userdicts, MySqlConnection conn)
        {
            string stmtu = "INSERT INTO user(yelping_since, funny, useful, cool, review_count, name, user_id, fans, average_stars, type) VALUES(@yelping_since, @funny, @useful, @cool, @review_count, @name, @user_id, @fans, @average_stars, @type)";

            //// *** set up command to insert into business table ***
            MySqlCommand cmdb = new MySqlCommand(stmtu, conn);
            cmdb.Parameters.Add("@yelping_since", MySqlDbType.DateTime);
            cmdb.Parameters.Add("@funny", MySqlDbType.Int32);
            cmdb.Parameters.Add("@useful", MySqlDbType.Int32);
            cmdb.Parameters.Add("@cool", MySqlDbType.Int32);
            cmdb.Parameters.Add("@review_count", MySqlDbType.Int32);
            cmdb.Parameters.Add("@name", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@user_id", MySqlDbType.VarChar, 60);
            cmdb.Parameters.Add("@fans", MySqlDbType.Int32);
            cmdb.Parameters.Add("@average_stars", MySqlDbType.Double);
            cmdb.Parameters.Add("@type", MySqlDbType.VarChar, 30);

            //place values into business table
            for (int i = 0; i < userdicts.Count; i++)
            {
                cmdb.Parameters["@user_id"].Value = userdicts[i]["user_id "].ToString();
                cmdb.Parameters["@yelping_since"].Value = Convert.ToDateTime(userdicts[i]["yelping_since "].ToString());
                cmdb.Parameters["@review_count"].Value = Convert.ToInt32(userdicts[i]["review_count "].ToString());
                cmdb.Parameters["@name"].Value = userdicts[i]["name "].ToString();
                cmdb.Parameters["@funny"].Value = Convert.ToInt32(userdicts[i]["funny "].ToString());
                cmdb.Parameters["@useful"].Value = Convert.ToInt32(userdicts[i]["useful "].ToString());
                cmdb.Parameters["@cool"].Value = Convert.ToInt32(userdicts[i]["cool "].ToString());
                cmdb.Parameters["@fans"].Value = Convert.ToInt32(userdicts[i]["fans "].ToString());
                cmdb.Parameters["@average_stars"].Value = Convert.ToDouble(userdicts[i]["average_stars "].ToString());
                cmdb.Parameters["@type"].Value = userdicts[i]["type "].ToString();

                cmdb.ExecuteNonQuery(); //execute the insert command            
            }
        }// end of dict_to_sql_user
    }
}
