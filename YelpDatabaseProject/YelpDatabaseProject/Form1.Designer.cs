﻿namespace YelpDatabaseProject
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("attribute1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("attribute2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("attribute3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("attribute4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("attribute5", new System.Windows.Forms.TreeNode[] {
            treeNode5});
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
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxU18 = new System.Windows.Forms.ListBox();
            this.listBox18 = new System.Windows.Forms.ListBox();
            this.listBox25 = new System.Windows.Forms.ListBox();
            this.listBox45 = new System.Windows.Forms.ListBox();
            this.listBox65 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // state_dropDown
            // 
            this.state_dropDown.FormattingEnabled = true;
            this.state_dropDown.Location = new System.Drawing.Point(253, 10);
            this.state_dropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.state_dropDown.Name = "state_dropDown";
            this.state_dropDown.Size = new System.Drawing.Size(431, 39);
            this.state_dropDown.TabIndex = 0;
            this.state_dropDown.DropDown += new System.EventHandler(this.state_dropDown_DropDown);
            this.state_dropDown.SelectedIndexChanged += new System.EventHandler(this.state_dropDown_SelectedIndexChanged);
            // 
            // city_listbox
            // 
            this.city_listbox.FormattingEnabled = true;
            this.city_listbox.ItemHeight = 31;
            this.city_listbox.Location = new System.Drawing.Point(253, 93);
            this.city_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.city_listbox.Name = "city_listbox";
            this.city_listbox.Size = new System.Drawing.Size(431, 345);
            this.city_listbox.TabIndex = 1;
            this.city_listbox.SelectedIndexChanged += new System.EventHandler(this.city_listbox_SelectedIndexChanged);
            // 
            // zipcode_listbox
            // 
            this.zipcode_listbox.FormattingEnabled = true;
            this.zipcode_listbox.ItemHeight = 31;
            this.zipcode_listbox.Location = new System.Drawing.Point(253, 618);
            this.zipcode_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zipcode_listbox.Name = "zipcode_listbox";
            this.zipcode_listbox.Size = new System.Drawing.Size(431, 252);
            this.zipcode_listbox.TabIndex = 2;
            this.zipcode_listbox.SelectedIndexChanged += new System.EventHandler(this.zipcode_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(37, 17);
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
            this.label2.Location = new System.Drawing.Point(37, 93);
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
            this.label3.Location = new System.Drawing.Point(37, 618);
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
            this.label4.Location = new System.Drawing.Point(744, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Location";
            // 
            // population_listbox
            // 
            this.population_listbox.FormattingEnabled = true;
            this.population_listbox.ItemHeight = 31;
            this.population_listbox.Location = new System.Drawing.Point(1061, 93);
            this.population_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.population_listbox.Name = "population_listbox";
            this.population_listbox.Size = new System.Drawing.Size(377, 66);
            this.population_listbox.TabIndex = 7;
            // 
            // avg_income_listbox
            // 
            this.avg_income_listbox.FormattingEnabled = true;
            this.avg_income_listbox.ItemHeight = 31;
            this.avg_income_listbox.Location = new System.Drawing.Point(1061, 236);
            this.avg_income_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avg_income_listbox.Name = "avg_income_listbox";
            this.avg_income_listbox.Size = new System.Drawing.Size(375, 66);
            this.avg_income_listbox.TabIndex = 8;
            // 
            // median_age_listbox
            // 
            this.median_age_listbox.FormattingEnabled = true;
            this.median_age_listbox.ItemHeight = 31;
            this.median_age_listbox.Location = new System.Drawing.Point(1059, 804);
            this.median_age_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.median_age_listbox.Name = "median_age_listbox";
            this.median_age_listbox.Size = new System.Drawing.Size(377, 66);
            this.median_age_listbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(744, 93);
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
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBoxU18, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox18, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox25, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBox45, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.listBox65, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(992, 389);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.listBoxU18.Location = new System.Drawing.Point(230, 63);
            this.listBoxU18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxU18.Name = "listBoxU18";
            this.listBoxU18.Size = new System.Drawing.Size(218, 53);
            this.listBoxU18.TabIndex = 7;
            // 
            // listBox18
            // 
            this.listBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox18.FormattingEnabled = true;
            this.listBox18.ItemHeight = 31;
            this.listBox18.Location = new System.Drawing.Point(230, 122);
            this.listBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox18.Name = "listBox18";
            this.listBox18.Size = new System.Drawing.Size(218, 53);
            this.listBox18.TabIndex = 8;
            // 
            // listBox25
            // 
            this.listBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox25.FormattingEnabled = true;
            this.listBox25.ItemHeight = 31;
            this.listBox25.Location = new System.Drawing.Point(230, 181);
            this.listBox25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox25.Name = "listBox25";
            this.listBox25.Size = new System.Drawing.Size(218, 53);
            this.listBox25.TabIndex = 9;
            // 
            // listBox45
            // 
            this.listBox45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox45.FormattingEnabled = true;
            this.listBox45.ItemHeight = 31;
            this.listBox45.Location = new System.Drawing.Point(230, 240);
            this.listBox45.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox45.Name = "listBox45";
            this.listBox45.Size = new System.Drawing.Size(218, 53);
            this.listBox45.TabIndex = 10;
            // 
            // listBox65
            // 
            this.listBox65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox65.FormattingEnabled = true;
            this.listBox65.ItemHeight = 31;
            this.listBox65.Location = new System.Drawing.Point(230, 299);
            this.listBox65.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox65.Name = "listBox65";
            this.listBox65.Size = new System.Drawing.Size(218, 59);
            this.listBox65.TabIndex = 11;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(744, 236);
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
            this.label14.Location = new System.Drawing.Point(744, 839);
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
            this.label15.Location = new System.Drawing.Point(744, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 34);
            this.label15.TabIndex = 15;
            this.label15.Text = "Age Distribution";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1488, 971);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.population_listbox);
            this.tabPage1.Controls.Add(this.avg_income_listbox);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.city_listbox);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.median_age_listbox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.state_dropDown);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.zipcode_listbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(1480, 927);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(1480, 927);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Business Categories";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(600, 17);
            this.label17.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(209, 32);
            this.label17.TabIndex = 4;
            this.label17.Text = "Select Attribute";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(608, 55);
            this.treeView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "attribute1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "attribute2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "attribute3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "attribute4";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Node6";
            treeNode6.Name = "Node5";
            treeNode6.Text = "attribute5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(751, 719);
            this.treeView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 696);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 17);
            this.label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(363, 32);
            this.label16.TabIndex = 1;
            this.label16.Text = "Select Business Categories";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Fast Food",
            "Restaurant",
            "Bar"});
            this.checkedListBox1.Location = new System.Drawing.Point(59, 55);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(345, 598);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1483, 968);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}

