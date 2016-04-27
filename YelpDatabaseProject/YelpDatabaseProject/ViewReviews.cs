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
    public partial class ViewReviews : Form
    {
        string query = "";
        MySQL_connection mydb;
        public ViewReviews(string q)
        {
            this.query = q;
            InitializeComponent();
        }

        private void ViewReviews_Load(object sender, EventArgs e)
        {
            mydb = new MySQL_connection();
            mydb.OpenConnection();
            List<List<string>> res = mydb.SQLSELECTExec(query, new List<string>() { "date", "stars", "text", "user_id", "useful" });

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            //place the given information into the dataGridView Search result table
            for (int j = 0; j < res.Count(); j++)// At 1 so it doesn't include id
            {
                //since each row in qResults contains all of one type of data ie names or cities
                //we have to add a new row each time we go through i
                for (int i = 0; i < res[j].Count(); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[j].Value = res[j][i];
                }
            }
        }
    }
}
