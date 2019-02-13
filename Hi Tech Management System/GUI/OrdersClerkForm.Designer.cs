namespace Hi_Tech_Management_System.GUI
{
    partial class OrdersClerkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersClerkForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ISBNCombo1 = new System.Windows.Forms.ComboBox();
            this.SoftwareIDCombo = new System.Windows.Forms.ComboBox();
            this.SoftwareNAmeCombo = new System.Windows.Forms.ComboBox();
            this.TitleCombo2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderIDtxt = new System.Windows.Forms.TextBox();
            this.OrderDatetxt = new System.Windows.Forms.TextBox();
            this.shippedDatetxt = new System.Windows.Forms.TextBox();
            this.CreateOrdersBtn = new System.Windows.Forms.Button();
            this.Listbtn = new System.Windows.Forms.Button();
            this.DeleteOrderBtn = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchOrderBtn = new System.Windows.Forms.Button();
            this.UpdateOrdersBtn = new System.Windows.Forms.Button();
            this.Cleartxt = new System.Windows.Forms.Button();
            this.combo_SearchOrders = new System.Windows.Forms.ComboBox();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Orderlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientIDCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ISBNCombo1);
            this.groupBox1.Controls.Add(this.SoftwareIDCombo);
            this.groupBox1.Controls.Add(this.SoftwareNAmeCombo);
            this.groupBox1.Controls.Add(this.TitleCombo2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(672, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "choose products";
            // 
            // ISBNCombo1
            // 
            this.ISBNCombo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNCombo1.FormattingEnabled = true;
            this.ISBNCombo1.Location = new System.Drawing.Point(138, 48);
            this.ISBNCombo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ISBNCombo1.Name = "ISBNCombo1";
            this.ISBNCombo1.Size = new System.Drawing.Size(180, 28);
            this.ISBNCombo1.TabIndex = 7;
            // 
            // SoftwareIDCombo
            // 
            this.SoftwareIDCombo.FormattingEnabled = true;
            this.SoftwareIDCombo.Location = new System.Drawing.Point(482, 42);
            this.SoftwareIDCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoftwareIDCombo.Name = "SoftwareIDCombo";
            this.SoftwareIDCombo.Size = new System.Drawing.Size(180, 30);
            this.SoftwareIDCombo.TabIndex = 6;
            // 
            // SoftwareNAmeCombo
            // 
            this.SoftwareNAmeCombo.FormattingEnabled = true;
            this.SoftwareNAmeCombo.Location = new System.Drawing.Point(482, 86);
            this.SoftwareNAmeCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoftwareNAmeCombo.Name = "SoftwareNAmeCombo";
            this.SoftwareNAmeCombo.Size = new System.Drawing.Size(180, 30);
            this.SoftwareNAmeCombo.TabIndex = 5;
            this.SoftwareNAmeCombo.SelectedIndexChanged += new System.EventHandler(this.SoftwareNAmeCombo_SelectedIndexChanged);
            // 
            // TitleCombo2
            // 
            this.TitleCombo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCombo2.FormattingEnabled = true;
            this.TitleCombo2.Location = new System.Drawing.Point(138, 91);
            this.TitleCombo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleCombo2.Name = "TitleCombo2";
            this.TitleCombo2.Size = new System.Drawing.Size(180, 28);
            this.TitleCombo2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Software Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Software ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ISBN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(744, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Order ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(742, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Client ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(742, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Order Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(740, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Shipped Date :";
            // 
            // OrderIDtxt
            // 
            this.OrderIDtxt.Location = new System.Drawing.Point(902, 58);
            this.OrderIDtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderIDtxt.Name = "OrderIDtxt";
            this.OrderIDtxt.Size = new System.Drawing.Size(148, 26);
            this.OrderIDtxt.TabIndex = 5;
            // 
            // OrderDatetxt
            // 
            this.OrderDatetxt.Location = new System.Drawing.Point(902, 145);
            this.OrderDatetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderDatetxt.Name = "OrderDatetxt";
            this.OrderDatetxt.Size = new System.Drawing.Size(148, 26);
            this.OrderDatetxt.TabIndex = 7;
            // 
            // shippedDatetxt
            // 
            this.shippedDatetxt.Location = new System.Drawing.Point(902, 189);
            this.shippedDatetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shippedDatetxt.Name = "shippedDatetxt";
            this.shippedDatetxt.Size = new System.Drawing.Size(148, 26);
            this.shippedDatetxt.TabIndex = 8;
            // 
            // CreateOrdersBtn
            // 
            this.CreateOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrdersBtn.Location = new System.Drawing.Point(44, 266);
            this.CreateOrdersBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateOrdersBtn.Name = "CreateOrdersBtn";
            this.CreateOrdersBtn.Size = new System.Drawing.Size(166, 80);
            this.CreateOrdersBtn.TabIndex = 9;
            this.CreateOrdersBtn.Text = "Create Order";
            this.CreateOrdersBtn.UseVisualStyleBackColor = true;
            this.CreateOrdersBtn.Click += new System.EventHandler(this.CreateOrdersBtn_Click);
            // 
            // Listbtn
            // 
            this.Listbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listbtn.Location = new System.Drawing.Point(288, 289);
            this.Listbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Listbtn.Name = "Listbtn";
            this.Listbtn.Size = new System.Drawing.Size(112, 35);
            this.Listbtn.TabIndex = 10;
            this.Listbtn.Text = "List ";
            this.Listbtn.UseVisualStyleBackColor = true;
            this.Listbtn.Click += new System.EventHandler(this.Listbtn_Click);
            // 
            // DeleteOrderBtn
            // 
            this.DeleteOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderBtn.Location = new System.Drawing.Point(810, 289);
            this.DeleteOrderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteOrderBtn.Name = "DeleteOrderBtn";
            this.DeleteOrderBtn.Size = new System.Drawing.Size(112, 35);
            this.DeleteOrderBtn.TabIndex = 11;
            this.DeleteOrderBtn.Text = "Delete";
            this.DeleteOrderBtn.UseVisualStyleBackColor = true;
            this.DeleteOrderBtn.Click += new System.EventHandler(this.DeleteOrderBtn_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(978, 742);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 35);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchOrderBtn
            // 
            this.SearchOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrderBtn.Location = new System.Drawing.Point(744, 383);
            this.SearchOrderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchOrderBtn.Name = "SearchOrderBtn";
            this.SearchOrderBtn.Size = new System.Drawing.Size(112, 35);
            this.SearchOrderBtn.TabIndex = 13;
            this.SearchOrderBtn.Text = "Search";
            this.SearchOrderBtn.UseVisualStyleBackColor = true;
            this.SearchOrderBtn.Click += new System.EventHandler(this.SearchOrderBtn_Click);
            // 
            // UpdateOrdersBtn
            // 
            this.UpdateOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateOrdersBtn.Location = new System.Drawing.Point(636, 289);
            this.UpdateOrdersBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateOrdersBtn.Name = "UpdateOrdersBtn";
            this.UpdateOrdersBtn.Size = new System.Drawing.Size(112, 35);
            this.UpdateOrdersBtn.TabIndex = 14;
            this.UpdateOrdersBtn.Text = "Update";
            this.UpdateOrdersBtn.UseVisualStyleBackColor = true;
            this.UpdateOrdersBtn.Click += new System.EventHandler(this.UpdateOrdersBtn_Click);
            // 
            // Cleartxt
            // 
            this.Cleartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cleartxt.Location = new System.Drawing.Point(465, 289);
            this.Cleartxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cleartxt.Name = "Cleartxt";
            this.Cleartxt.Size = new System.Drawing.Size(112, 35);
            this.Cleartxt.TabIndex = 15;
            this.Cleartxt.Text = "Clear";
            this.Cleartxt.UseVisualStyleBackColor = true;
            this.Cleartxt.Click += new System.EventHandler(this.Cleartxt_Click);
            // 
            // combo_SearchOrders
            // 
            this.combo_SearchOrders.FormattingEnabled = true;
            this.combo_SearchOrders.Items.AddRange(new object[] {
            "Client Id",
            "Order Id"});
            this.combo_SearchOrders.Location = new System.Drawing.Point(884, 383);
            this.combo_SearchOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_SearchOrders.Name = "combo_SearchOrders";
            this.combo_SearchOrders.Size = new System.Drawing.Size(180, 28);
            this.combo_SearchOrders.TabIndex = 16;
            this.combo_SearchOrders.SelectedIndexChanged += new System.EventHandler(this.combo_SearchOrders_SelectedIndexChanged);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(250, 394);
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(148, 26);
            this.Searchtxt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 398);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Enter text to search";
            // 
            // Orderlist
            // 
            this.Orderlist.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Orderlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.Orderlist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Orderlist.GridLines = true;
            this.Orderlist.Location = new System.Drawing.Point(69, 474);
            this.Orderlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Orderlist.Name = "Orderlist";
            this.Orderlist.Size = new System.Drawing.Size(820, 279);
            this.Orderlist.TabIndex = 19;
            this.Orderlist.UseCompatibleStateImageBehavior = false;
            this.Orderlist.View = System.Windows.Forms.View.Details;
            this.Orderlist.SelectedIndexChanged += new System.EventHandler(this.Orderlist_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client ID";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OrderDate";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ShippedDate";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Book ISBN";
            this.columnHeader5.Width = 69;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "BookTitle";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Software ID";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SoftwareName";
            this.columnHeader8.Width = 89;
            // 
            // ClientIDCombo
            // 
            this.ClientIDCombo.FormattingEnabled = true;
            this.ClientIDCombo.Location = new System.Drawing.Point(902, 103);
            this.ClientIDCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientIDCombo.Name = "ClientIDCombo";
            this.ClientIDCombo.Size = new System.Drawing.Size(148, 28);
            this.ClientIDCombo.TabIndex = 20;
            // 
            // OrdersClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1216, 795);
            this.Controls.Add(this.ClientIDCombo);
            this.Controls.Add(this.Orderlist);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.combo_SearchOrders);
            this.Controls.Add(this.Cleartxt);
            this.Controls.Add(this.UpdateOrdersBtn);
            this.Controls.Add(this.SearchOrderBtn);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteOrderBtn);
            this.Controls.Add(this.Listbtn);
            this.Controls.Add(this.CreateOrdersBtn);
            this.Controls.Add(this.shippedDatetxt);
            this.Controls.Add(this.OrderDatetxt);
            this.Controls.Add(this.OrderIDtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdersClerkForm";
            this.Text = "OrdersClerkForm";
            this.Load += new System.EventHandler(this.OrdersClerkForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ISBNCombo1;
        private System.Windows.Forms.ComboBox SoftwareIDCombo;
        private System.Windows.Forms.ComboBox SoftwareNAmeCombo;
        private System.Windows.Forms.ComboBox TitleCombo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OrderIDtxt;
        private System.Windows.Forms.TextBox OrderDatetxt;
        private System.Windows.Forms.TextBox shippedDatetxt;
        private System.Windows.Forms.Button CreateOrdersBtn;
        private System.Windows.Forms.Button Listbtn;
        private System.Windows.Forms.Button DeleteOrderBtn;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchOrderBtn;
        private System.Windows.Forms.Button UpdateOrdersBtn;
        private System.Windows.Forms.Button Cleartxt;
        private System.Windows.Forms.ComboBox combo_SearchOrders;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView Orderlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox ClientIDCombo;
    }
}