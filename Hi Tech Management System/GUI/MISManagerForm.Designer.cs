namespace Hi_Tech_Management_System.GUI
{
    partial class MISManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MISManagerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.Empidtxt = new System.Windows.Forms.TextBox();
            this.PhoneNotxt = new System.Windows.Forms.TextBox();
            this.FaxNotxt = new System.Windows.Forms.TextBox();
            this.Empfnametxt = new System.Windows.Forms.TextBox();
            this.Emplnametxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JobTitleCombo = new System.Windows.Forms.ComboBox();
            this.Emplist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ListButton = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.textclear = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchordeleteEmptxt = new System.Windows.Forms.TextBox();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fax Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-Mail :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Job Title :";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(561, 182);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(148, 28);
            this.emailtxt.TabIndex = 7;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // Empidtxt
            // 
            this.Empidtxt.Location = new System.Drawing.Point(186, 89);
            this.Empidtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Empidtxt.Name = "Empidtxt";
            this.Empidtxt.Size = new System.Drawing.Size(148, 28);
            this.Empidtxt.TabIndex = 8;
            this.Empidtxt.TextChanged += new System.EventHandler(this.Empidtxt_TextChanged);
            // 
            // PhoneNotxt
            // 
            this.PhoneNotxt.Location = new System.Drawing.Point(561, 98);
            this.PhoneNotxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNotxt.Name = "PhoneNotxt";
            this.PhoneNotxt.Size = new System.Drawing.Size(148, 28);
            this.PhoneNotxt.TabIndex = 9;
            this.PhoneNotxt.TextChanged += new System.EventHandler(this.PhoneNotxt_TextChanged);
            // 
            // FaxNotxt
            // 
            this.FaxNotxt.Location = new System.Drawing.Point(561, 138);
            this.FaxNotxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FaxNotxt.Name = "FaxNotxt";
            this.FaxNotxt.Size = new System.Drawing.Size(148, 28);
            this.FaxNotxt.TabIndex = 10;
            // 
            // Empfnametxt
            // 
            this.Empfnametxt.Location = new System.Drawing.Point(186, 138);
            this.Empfnametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Empfnametxt.Name = "Empfnametxt";
            this.Empfnametxt.Size = new System.Drawing.Size(148, 28);
            this.Empfnametxt.TabIndex = 11;
            // 
            // Emplnametxt
            // 
            this.Emplnametxt.Location = new System.Drawing.Point(186, 182);
            this.Emplnametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Emplnametxt.Name = "Emplnametxt";
            this.Emplnametxt.Size = new System.Drawing.Size(148, 28);
            this.Emplnametxt.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JobTitleCombo);
            this.groupBox1.Controls.Add(this.PhoneNotxt);
            this.groupBox1.Controls.Add(this.Empidtxt);
            this.groupBox1.Controls.Add(this.Emplnametxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.FaxNotxt);
            this.groupBox1.Controls.Add(this.Empfnametxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(729, 314);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empolyee Information";
            // 
            // JobTitleCombo
            // 
            this.JobTitleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobTitleCombo.FormattingEnabled = true;
            this.JobTitleCombo.Location = new System.Drawing.Point(284, 254);
            this.JobTitleCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobTitleCombo.Name = "JobTitleCombo";
            this.JobTitleCombo.Size = new System.Drawing.Size(180, 30);
            this.JobTitleCombo.TabIndex = 13;
            this.JobTitleCombo.SelectedIndexChanged += new System.EventHandler(this.JobTitleCombo_SelectedIndexChanged);
            // 
            // Emplist
            // 
            this.Emplist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Emplist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.Emplist.GridLines = true;
            this.Emplist.Location = new System.Drawing.Point(56, 431);
            this.Emplist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Emplist.Name = "Emplist";
            this.Emplist.Size = new System.Drawing.Size(754, 189);
            this.Emplist.TabIndex = 14;
            this.Emplist.UseCompatibleStateImageBehavior = false;
            this.Emplist.View = System.Windows.Forms.View.Details;
            this.Emplist.SelectedIndexChanged += new System.EventHandler(this.Emplist_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee id";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone No";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fax No";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-mail";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Job Title";
            this.columnHeader7.Width = 79;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(814, 78);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 35);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(972, 78);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(814, 154);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(112, 35);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "&Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ListButton
            // 
            this.ListButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListButton.Location = new System.Drawing.Point(972, 154);
            this.ListButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(112, 35);
            this.ListButton.TabIndex = 18;
            this.ListButton.Text = "List";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(814, 237);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(112, 35);
            this.Exitbtn.TabIndex = 19;
            this.Exitbtn.Text = "E&xit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // textclear
            // 
            this.textclear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textclear.Location = new System.Drawing.Point(972, 237);
            this.textclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textclear.Name = "textclear";
            this.textclear.Size = new System.Drawing.Size(112, 35);
            this.textclear.TabIndex = 20;
            this.textclear.Text = "&Clear";
            this.textclear.UseVisualStyleBackColor = true;
            this.textclear.Click += new System.EventHandler(this.textclear_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(916, 457);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 35);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Enter text to search";
            // 
            // SearchordeleteEmptxt
            // 
            this.SearchordeleteEmptxt.Location = new System.Drawing.Point(274, 366);
            this.SearchordeleteEmptxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchordeleteEmptxt.Name = "SearchordeleteEmptxt";
            this.SearchordeleteEmptxt.Size = new System.Drawing.Size(148, 26);
            this.SearchordeleteEmptxt.TabIndex = 23;
            // 
            // comboSearch
            // 
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "EmpId",
            "FirstName",
            "LastName"});
            this.comboSearch.Location = new System.Drawing.Point(885, 517);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(180, 28);
            this.comboSearch.TabIndex = 24;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // MISManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.SearchordeleteEmptxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textclear);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Emplist);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MISManagerForm";
            this.Text = "MISManagerForm";
            this.Load += new System.EventHandler(this.MISManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox Empidtxt;
        private System.Windows.Forms.TextBox PhoneNotxt;
        private System.Windows.Forms.TextBox FaxNotxt;
        private System.Windows.Forms.TextBox Empfnametxt;
        private System.Windows.Forms.TextBox Emplnametxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox JobTitleCombo;
        private System.Windows.Forms.ListView Emplist;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button textclear;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SearchordeleteEmptxt;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}