namespace Hi_Tech_Management_System.GUI
{
    partial class InventoryCollectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryCollectorForm));
            this.Books = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.combo_Search = new System.Windows.Forms.ComboBox();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InventoryList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button7 = new System.Windows.Forms.Button();
            this.SearchInventoryBtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.DelInventoryBtn = new System.Windows.Forms.Button();
            this.UpdateInventoryBtn = new System.Windows.Forms.Button();
            this.ListInventoryBtn = new System.Windows.Forms.Button();
            this.SaveInventoryBtn = new System.Windows.Forms.Button();
            this.labelBooks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.authorlnametxt = new System.Windows.Forms.TextBox();
            this.authorfnametxt = new System.Windows.Forms.TextBox();
            this.authoridtxt = new System.Windows.Forms.TextBox();
            this.UnitPricetxt = new System.Windows.Forms.TextBox();
            this.bookTitletxt = new System.Windows.Forms.TextBox();
            this.bookISBNtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SoftwareList = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.Software = new System.Windows.Forms.GroupBox();
            this.SoftwareNametxt = new System.Windows.Forms.TextBox();
            this.unitpricetext = new System.Windows.Forms.TextBox();
            this.softwareIdtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.texttosearchsoftwares = new System.Windows.Forms.TextBox();
            this.combosoftwares = new System.Windows.Forms.ComboBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.searchsoftwarebtn = new System.Windows.Forms.Button();
            this.textclear = new System.Windows.Forms.Button();
            this.deletesoftwares = new System.Windows.Forms.Button();
            this.listsoftware = new System.Windows.Forms.Button();
            this.updatesoftwarebtn = new System.Windows.Forms.Button();
            this.saveSoftwareBtn = new System.Windows.Forms.Button();
            this.Books.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Software.SuspendLayout();
            this.SuspendLayout();
            // 
            // Books
            // 
            this.Books.Controls.Add(this.tabPage1);
            this.Books.Controls.Add(this.tabPage2);
            this.Books.Location = new System.Drawing.Point(4, 2);
            this.Books.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Books.Name = "Books";
            this.Books.SelectedIndex = 0;
            this.Books.Size = new System.Drawing.Size(1178, 688);
            this.Books.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.combo_Search);
            this.tabPage1.Controls.Add(this.Searchtxt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.InventoryList);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.SearchInventoryBtn);
            this.tabPage1.Controls.Add(this.Clearbtn);
            this.tabPage1.Controls.Add(this.DelInventoryBtn);
            this.tabPage1.Controls.Add(this.UpdateInventoryBtn);
            this.tabPage1.Controls.Add(this.ListInventoryBtn);
            this.tabPage1.Controls.Add(this.SaveInventoryBtn);
            this.tabPage1.Controls.Add(this.labelBooks);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1170, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // combo_Search
            // 
            this.combo_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Search.FormattingEnabled = true;
            this.combo_Search.Items.AddRange(new object[] {
            "Book ISBN",
            "Book Title"});
            this.combo_Search.Location = new System.Drawing.Point(868, 360);
            this.combo_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_Search.Name = "combo_Search";
            this.combo_Search.Size = new System.Drawing.Size(180, 28);
            this.combo_Search.TabIndex = 12;
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(304, 368);
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(148, 26);
            this.Searchtxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Enter Text To Search";
            // 
            // InventoryList
            // 
            this.InventoryList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InventoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.InventoryList.GridLines = true;
            this.InventoryList.Location = new System.Drawing.Point(36, 435);
            this.InventoryList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.Size = new System.Drawing.Size(1012, 147);
            this.InventoryList.TabIndex = 9;
            this.InventoryList.UseCompatibleStateImageBehavior = false;
            this.InventoryList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book ISBN";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Book Title";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Author ID";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Author First Name";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Author Last Name";
            this.columnHeader6.Width = 139;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Published Date";
            this.columnHeader7.Width = 311;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(938, 594);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 35);
            this.button7.TabIndex = 8;
            this.button7.Text = "E&xit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // SearchInventoryBtn
            // 
            this.SearchInventoryBtn.Location = new System.Drawing.Point(729, 360);
            this.SearchInventoryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchInventoryBtn.Name = "SearchInventoryBtn";
            this.SearchInventoryBtn.Size = new System.Drawing.Size(112, 35);
            this.SearchInventoryBtn.TabIndex = 7;
            this.SearchInventoryBtn.Text = "&Search";
            this.SearchInventoryBtn.UseVisualStyleBackColor = true;
            this.SearchInventoryBtn.Click += new System.EventHandler(this.SearchInventoryBtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(624, 277);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(112, 35);
            this.Clearbtn.TabIndex = 6;
            this.Clearbtn.Text = "&Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // DelInventoryBtn
            // 
            this.DelInventoryBtn.Location = new System.Drawing.Point(474, 277);
            this.DelInventoryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DelInventoryBtn.Name = "DelInventoryBtn";
            this.DelInventoryBtn.Size = new System.Drawing.Size(112, 35);
            this.DelInventoryBtn.TabIndex = 5;
            this.DelInventoryBtn.Text = "&Delete";
            this.DelInventoryBtn.UseVisualStyleBackColor = true;
            this.DelInventoryBtn.Click += new System.EventHandler(this.DelInventoryBtn_Click);
            // 
            // UpdateInventoryBtn
            // 
            this.UpdateInventoryBtn.Location = new System.Drawing.Point(342, 277);
            this.UpdateInventoryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateInventoryBtn.Name = "UpdateInventoryBtn";
            this.UpdateInventoryBtn.Size = new System.Drawing.Size(112, 35);
            this.UpdateInventoryBtn.TabIndex = 4;
            this.UpdateInventoryBtn.Text = "&Update";
            this.UpdateInventoryBtn.UseVisualStyleBackColor = true;
            this.UpdateInventoryBtn.Click += new System.EventHandler(this.UpdateInventoryBtn_Click);
            // 
            // ListInventoryBtn
            // 
            this.ListInventoryBtn.Location = new System.Drawing.Point(196, 277);
            this.ListInventoryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListInventoryBtn.Name = "ListInventoryBtn";
            this.ListInventoryBtn.Size = new System.Drawing.Size(112, 35);
            this.ListInventoryBtn.TabIndex = 3;
            this.ListInventoryBtn.Text = "&List";
            this.ListInventoryBtn.UseVisualStyleBackColor = true;
            this.ListInventoryBtn.Click += new System.EventHandler(this.ListInventoryBtn_Click);
            // 
            // SaveInventoryBtn
            // 
            this.SaveInventoryBtn.Location = new System.Drawing.Point(48, 277);
            this.SaveInventoryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveInventoryBtn.Name = "SaveInventoryBtn";
            this.SaveInventoryBtn.Size = new System.Drawing.Size(112, 35);
            this.SaveInventoryBtn.TabIndex = 2;
            this.SaveInventoryBtn.Text = "&Save";
            this.SaveInventoryBtn.UseVisualStyleBackColor = true;
            this.SaveInventoryBtn.Click += new System.EventHandler(this.SaveInventoryBtn_Click);
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooks.Location = new System.Drawing.Point(468, 18);
            this.labelBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(86, 29);
            this.labelBooks.TabIndex = 1;
            this.labelBooks.Text = "Books";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.authorlnametxt);
            this.groupBox1.Controls.Add(this.authorfnametxt);
            this.groupBox1.Controls.Add(this.authoridtxt);
            this.groupBox1.Controls.Add(this.UnitPricetxt);
            this.groupBox1.Controls.Add(this.bookTitletxt);
            this.groupBox1.Controls.Add(this.bookISBNtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1041, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // authorlnametxt
            // 
            this.authorlnametxt.Location = new System.Drawing.Point(564, 132);
            this.authorlnametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authorlnametxt.Name = "authorlnametxt";
            this.authorlnametxt.Size = new System.Drawing.Size(148, 35);
            this.authorlnametxt.TabIndex = 13;
            // 
            // authorfnametxt
            // 
            this.authorfnametxt.Location = new System.Drawing.Point(564, 76);
            this.authorfnametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authorfnametxt.Name = "authorfnametxt";
            this.authorfnametxt.Size = new System.Drawing.Size(148, 35);
            this.authorfnametxt.TabIndex = 12;
            // 
            // authoridtxt
            // 
            this.authoridtxt.Location = new System.Drawing.Point(564, 28);
            this.authoridtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authoridtxt.Name = "authoridtxt";
            this.authoridtxt.Size = new System.Drawing.Size(148, 35);
            this.authoridtxt.TabIndex = 11;
            this.authoridtxt.TextChanged += new System.EventHandler(this.authoridtxt_TextChanged);
            // 
            // UnitPricetxt
            // 
            this.UnitPricetxt.Location = new System.Drawing.Point(210, 132);
            this.UnitPricetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UnitPricetxt.Name = "UnitPricetxt";
            this.UnitPricetxt.Size = new System.Drawing.Size(148, 35);
            this.UnitPricetxt.TabIndex = 9;
            // 
            // bookTitletxt
            // 
            this.bookTitletxt.Location = new System.Drawing.Point(210, 83);
            this.bookTitletxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookTitletxt.Name = "bookTitletxt";
            this.bookTitletxt.Size = new System.Drawing.Size(148, 35);
            this.bookTitletxt.TabIndex = 8;
            // 
            // bookISBNtxt
            // 
            this.bookISBNtxt.Location = new System.Drawing.Point(210, 34);
            this.bookISBNtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookISBNtxt.Name = "bookISBNtxt";
            this.bookISBNtxt.Size = new System.Drawing.Size(148, 35);
            this.bookISBNtxt.TabIndex = 7;
            this.bookISBNtxt.TextChanged += new System.EventHandler(this.bookISBNtxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Author ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Author First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ISBN";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.SoftwareList);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.Software);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.texttosearchsoftwares);
            this.tabPage2.Controls.Add(this.combosoftwares);
            this.tabPage2.Controls.Add(this.ExitBtn);
            this.tabPage2.Controls.Add(this.searchsoftwarebtn);
            this.tabPage2.Controls.Add(this.textclear);
            this.tabPage2.Controls.Add(this.deletesoftwares);
            this.tabPage2.Controls.Add(this.listsoftware);
            this.tabPage2.Controls.Add(this.updatesoftwarebtn);
            this.tabPage2.Controls.Add(this.saveSoftwareBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1170, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Softwares";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SoftwareList
            // 
            this.SoftwareList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SoftwareList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.SoftwareList.GridLines = true;
            this.SoftwareList.Location = new System.Drawing.Point(90, 369);
            this.SoftwareList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoftwareList.Name = "SoftwareList";
            this.SoftwareList.Size = new System.Drawing.Size(523, 193);
            this.SoftwareList.TabIndex = 18;
            this.SoftwareList.UseCompatibleStateImageBehavior = false;
            this.SoftwareList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Software ID";
            this.columnHeader8.Width = 113;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Software Name";
            this.columnHeader9.Width = 113;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Unit Price";
            this.columnHeader10.Width = 112;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(501, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 33);
            this.label13.TabIndex = 17;
            this.label13.Text = "Software";
            // 
            // Software
            // 
            this.Software.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Software.Controls.Add(this.SoftwareNametxt);
            this.Software.Controls.Add(this.unitpricetext);
            this.Software.Controls.Add(this.softwareIdtxt);
            this.Software.Controls.Add(this.label11);
            this.Software.Controls.Add(this.label10);
            this.Software.Controls.Add(this.label9);
            this.Software.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Software.Location = new System.Drawing.Point(40, 77);
            this.Software.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Software.Name = "Software";
            this.Software.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Software.Size = new System.Drawing.Size(422, 166);
            this.Software.TabIndex = 16;
            this.Software.TabStop = false;
            this.Software.Text = "Software";
            // 
            // SoftwareNametxt
            // 
            this.SoftwareNametxt.Location = new System.Drawing.Point(218, 69);
            this.SoftwareNametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoftwareNametxt.Name = "SoftwareNametxt";
            this.SoftwareNametxt.Size = new System.Drawing.Size(148, 28);
            this.SoftwareNametxt.TabIndex = 5;
            // 
            // unitpricetext
            // 
            this.unitpricetext.Location = new System.Drawing.Point(218, 115);
            this.unitpricetext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unitpricetext.Name = "unitpricetext";
            this.unitpricetext.Size = new System.Drawing.Size(148, 28);
            this.unitpricetext.TabIndex = 4;
            this.unitpricetext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // softwareIdtxt
            // 
            this.softwareIdtxt.Location = new System.Drawing.Point(218, 29);
            this.softwareIdtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.softwareIdtxt.Name = "softwareIdtxt";
            this.softwareIdtxt.Size = new System.Drawing.Size(148, 28);
            this.softwareIdtxt.TabIndex = 3;
            this.softwareIdtxt.TextChanged += new System.EventHandler(this.SoftwareIdtxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "Unit Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Software Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Software Id";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 300);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Enter Text To Search";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // texttosearchsoftwares
            // 
            this.texttosearchsoftwares.Location = new System.Drawing.Point(216, 294);
            this.texttosearchsoftwares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.texttosearchsoftwares.Name = "texttosearchsoftwares";
            this.texttosearchsoftwares.Size = new System.Drawing.Size(148, 26);
            this.texttosearchsoftwares.TabIndex = 14;
            this.texttosearchsoftwares.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // combosoftwares
            // 
            this.combosoftwares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosoftwares.FormattingEnabled = true;
            this.combosoftwares.Items.AddRange(new object[] {
            "Software Id",
            "Software Name"});
            this.combosoftwares.Location = new System.Drawing.Point(876, 265);
            this.combosoftwares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combosoftwares.Name = "combosoftwares";
            this.combosoftwares.Size = new System.Drawing.Size(180, 28);
            this.combosoftwares.TabIndex = 13;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(963, 578);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(112, 35);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // searchsoftwarebtn
            // 
            this.searchsoftwarebtn.Location = new System.Drawing.Point(740, 262);
            this.searchsoftwarebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchsoftwarebtn.Name = "searchsoftwarebtn";
            this.searchsoftwarebtn.Size = new System.Drawing.Size(112, 35);
            this.searchsoftwarebtn.TabIndex = 11;
            this.searchsoftwarebtn.Text = "&Search";
            this.searchsoftwarebtn.UseVisualStyleBackColor = true;
            this.searchsoftwarebtn.Click += new System.EventHandler(this.searchsoftwarebtn_Click);
            // 
            // textclear
            // 
            this.textclear.Location = new System.Drawing.Point(572, 262);
            this.textclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textclear.Name = "textclear";
            this.textclear.Size = new System.Drawing.Size(112, 35);
            this.textclear.TabIndex = 10;
            this.textclear.Text = "&Clear";
            this.textclear.UseVisualStyleBackColor = true;
            this.textclear.Click += new System.EventHandler(this.textclear_Click);
            // 
            // deletesoftwares
            // 
            this.deletesoftwares.Location = new System.Drawing.Point(740, 180);
            this.deletesoftwares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletesoftwares.Name = "deletesoftwares";
            this.deletesoftwares.Size = new System.Drawing.Size(112, 35);
            this.deletesoftwares.TabIndex = 9;
            this.deletesoftwares.Text = "&Delete";
            this.deletesoftwares.UseVisualStyleBackColor = true;
            this.deletesoftwares.Click += new System.EventHandler(this.deletesoftwares_Click);
            // 
            // listsoftware
            // 
            this.listsoftware.Location = new System.Drawing.Point(572, 180);
            this.listsoftware.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listsoftware.Name = "listsoftware";
            this.listsoftware.Size = new System.Drawing.Size(112, 35);
            this.listsoftware.TabIndex = 8;
            this.listsoftware.Text = "&List";
            this.listsoftware.UseVisualStyleBackColor = true;
            this.listsoftware.Click += new System.EventHandler(this.listsoftware_Click);
            // 
            // updatesoftwarebtn
            // 
            this.updatesoftwarebtn.Location = new System.Drawing.Point(740, 103);
            this.updatesoftwarebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updatesoftwarebtn.Name = "updatesoftwarebtn";
            this.updatesoftwarebtn.Size = new System.Drawing.Size(112, 35);
            this.updatesoftwarebtn.TabIndex = 7;
            this.updatesoftwarebtn.Text = "&Update";
            this.updatesoftwarebtn.UseVisualStyleBackColor = true;
            this.updatesoftwarebtn.Click += new System.EventHandler(this.updatesoftwarebtn_Click);
            // 
            // saveSoftwareBtn
            // 
            this.saveSoftwareBtn.Location = new System.Drawing.Point(572, 103);
            this.saveSoftwareBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveSoftwareBtn.Name = "saveSoftwareBtn";
            this.saveSoftwareBtn.Size = new System.Drawing.Size(112, 35);
            this.saveSoftwareBtn.TabIndex = 6;
            this.saveSoftwareBtn.Text = "&Save";
            this.saveSoftwareBtn.UseVisualStyleBackColor = true;
            this.saveSoftwareBtn.Click += new System.EventHandler(this.saveSoftwareBtn_Click);
            // 
            // InventoryCollectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Books);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventoryCollectorForm";
            this.Text = "InventoryControllerForm";
            this.Books.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Software.ResumeLayout(false);
            this.Software.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Books;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox authorlnametxt;
        private System.Windows.Forms.TextBox authorfnametxt;
        private System.Windows.Forms.TextBox authoridtxt;
        private System.Windows.Forms.TextBox UnitPricetxt;
        private System.Windows.Forms.TextBox bookTitletxt;
        private System.Windows.Forms.TextBox bookISBNtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Search;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView InventoryList;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button SearchInventoryBtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button DelInventoryBtn;
        private System.Windows.Forms.Button UpdateInventoryBtn;
        private System.Windows.Forms.Button ListInventoryBtn;
        private System.Windows.Forms.Button SaveInventoryBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox Software;
        private System.Windows.Forms.TextBox SoftwareNametxt;
        private System.Windows.Forms.TextBox unitpricetext;
        private System.Windows.Forms.TextBox softwareIdtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox texttosearchsoftwares;
        private System.Windows.Forms.ComboBox combosoftwares;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button searchsoftwarebtn;
        private System.Windows.Forms.Button textclear;
        private System.Windows.Forms.Button deletesoftwares;
        private System.Windows.Forms.Button listsoftware;
        private System.Windows.Forms.Button updatesoftwarebtn;
        private System.Windows.Forms.Button saveSoftwareBtn;
        private System.Windows.Forms.ListView SoftwareList;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}