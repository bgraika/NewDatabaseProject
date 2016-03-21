namespace YelpDatabaseProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.state_dropDown = new System.Windows.Forms.ComboBox();
            this.city_listbox = new System.Windows.Forms.ListBox();
            this.zipcode_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.population_listbox = new System.Windows.Forms.ListBox();
            this.avg_income_listbox = new System.Windows.Forms.ListBox();
            this.median_age_listbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxU18 = new System.Windows.Forms.ListBox();
            this.listBox18 = new System.Windows.Forms.ListBox();
            this.listBox25 = new System.Windows.Forms.ListBox();
            this.listBox45 = new System.Windows.Forms.ListBox();
            this.listBox65 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // state_dropDown
            // 
            this.state_dropDown.FormattingEnabled = true;
            this.state_dropDown.Location = new System.Drawing.Point(196, 168);
            this.state_dropDown.Name = "state_dropDown";
            this.state_dropDown.Size = new System.Drawing.Size(432, 39);
            this.state_dropDown.TabIndex = 0;
            this.state_dropDown.DropDown += new System.EventHandler(this.state_dropDown_DropDown);
            this.state_dropDown.SelectedIndexChanged += new System.EventHandler(this.state_dropDown_SelectedIndexChanged);
            // 
            // city_listbox
            // 
            this.city_listbox.FormattingEnabled = true;
            this.city_listbox.ItemHeight = 31;
            this.city_listbox.Location = new System.Drawing.Point(196, 236);
            this.city_listbox.Name = "city_listbox";
            this.city_listbox.Size = new System.Drawing.Size(432, 345);
            this.city_listbox.TabIndex = 1;
            this.city_listbox.SelectedIndexChanged += new System.EventHandler(this.city_listbox_SelectedIndexChanged);
            // 
            // zipcode_listbox
            // 
            this.zipcode_listbox.FormattingEnabled = true;
            this.zipcode_listbox.ItemHeight = 31;
            this.zipcode_listbox.Location = new System.Drawing.Point(196, 671);
            this.zipcode_listbox.Name = "zipcode_listbox";
            this.zipcode_listbox.Size = new System.Drawing.Size(432, 252);
            this.zipcode_listbox.TabIndex = 2;
            this.zipcode_listbox.SelectedIndexChanged += new System.EventHandler(this.zipcode_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(69, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(69, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(46, 704);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zipcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(272, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Location";
            // 
            // population_listbox
            // 
            this.population_listbox.FormattingEnabled = true;
            this.population_listbox.ItemHeight = 31;
            this.population_listbox.Location = new System.Drawing.Point(1029, 175);
            this.population_listbox.Name = "population_listbox";
            this.population_listbox.Size = new System.Drawing.Size(376, 66);
            this.population_listbox.TabIndex = 7;
            // 
            // avg_income_listbox
            // 
            this.avg_income_listbox.FormattingEnabled = true;
            this.avg_income_listbox.ItemHeight = 31;
            this.avg_income_listbox.Location = new System.Drawing.Point(1029, 300);
            this.avg_income_listbox.Name = "avg_income_listbox";
            this.avg_income_listbox.Size = new System.Drawing.Size(375, 66);
            this.avg_income_listbox.TabIndex = 8;
            // 
            // median_age_listbox
            // 
            this.median_age_listbox.FormattingEnabled = true;
            this.median_age_listbox.ItemHeight = 31;
            this.median_age_listbox.Location = new System.Drawing.Point(1040, 857);
            this.median_age_listbox.Name = "median_age_listbox";
            this.median_age_listbox.Size = new System.Drawing.Size(378, 66);
            this.median_age_listbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(839, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Population";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBoxU18, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox18, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox25, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBox45, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.listBox65, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(951, 438);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 362);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(5, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 57);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(230, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 57);
            this.label7.TabIndex = 1;
            this.label7.Text = "Percentage";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "under 18 years";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "18 to 24 years";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "25 to 44 years";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 32);
            this.label11.TabIndex = 5;
            this.label11.Text = "45 to 64 years";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 32);
            this.label12.TabIndex = 6;
            this.label12.Text = "65 and Over";
            // 
            // listBoxU18
            // 
            this.listBoxU18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxU18.FormattingEnabled = true;
            this.listBoxU18.ItemHeight = 31;
            this.listBoxU18.Location = new System.Drawing.Point(230, 64);
            this.listBoxU18.Name = "listBoxU18";
            this.listBoxU18.Size = new System.Drawing.Size(218, 51);
            this.listBoxU18.TabIndex = 7;
            // 
            // listBox18
            // 
            this.listBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox18.FormattingEnabled = true;
            this.listBox18.ItemHeight = 31;
            this.listBox18.Location = new System.Drawing.Point(230, 123);
            this.listBox18.Name = "listBox18";
            this.listBox18.Size = new System.Drawing.Size(218, 51);
            this.listBox18.TabIndex = 8;
            // 
            // listBox25
            // 
            this.listBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox25.FormattingEnabled = true;
            this.listBox25.ItemHeight = 31;
            this.listBox25.Location = new System.Drawing.Point(230, 182);
            this.listBox25.Name = "listBox25";
            this.listBox25.Size = new System.Drawing.Size(218, 51);
            this.listBox25.TabIndex = 9;
            // 
            // listBox45
            // 
            this.listBox45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox45.FormattingEnabled = true;
            this.listBox45.ItemHeight = 31;
            this.listBox45.Location = new System.Drawing.Point(230, 241);
            this.listBox45.Name = "listBox45";
            this.listBox45.Size = new System.Drawing.Size(218, 51);
            this.listBox45.TabIndex = 10;
            // 
            // listBox65
            // 
            this.listBox65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox65.FormattingEnabled = true;
            this.listBox65.ItemHeight = 31;
            this.listBox65.Location = new System.Drawing.Point(230, 300);
            this.listBox65.Name = "listBox65";
            this.listBox65.Size = new System.Drawing.Size(218, 57);
            this.listBox65.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(771, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 34);
            this.label13.TabIndex = 13;
            this.label13.Text = "Average Income";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(824, 868);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 34);
            this.label14.TabIndex = 14;
            this.label14.Text = "Median Age";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(951, 401);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 34);
            this.label15.TabIndex = 15;
            this.label15.Text = "Age Distribution";
            // 
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1448, 1008);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.median_age_listbox);
            this.Controls.Add(this.avg_income_listbox);
            this.Controls.Add(this.population_listbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zipcode_listbox);
            this.Controls.Add(this.city_listbox);
            this.Controls.Add(this.state_dropDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox state_dropDown;
        private System.Windows.Forms.ListBox city_listbox;
        private System.Windows.Forms.ListBox zipcode_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox population_listbox;
        private System.Windows.Forms.ListBox avg_income_listbox;
        private System.Windows.Forms.ListBox median_age_listbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxU18;
        private System.Windows.Forms.ListBox listBox18;
        private System.Windows.Forms.ListBox listBox25;
        private System.Windows.Forms.ListBox listBox45;
        private System.Windows.Forms.ListBox listBox65;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

