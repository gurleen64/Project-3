using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Management_System.BLL;

namespace Hi_Tech_Management_System.GUI
{
    public partial class MISManagerForm : Form
    {
        Employee emp = new Employee();
        List<Employee> listEmp = new List<Employee>();

        List<int> test = new List<int>();
        

        public void ClearAllControls()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                Emplist.Items.Clear();
                Empidtxt.Focus();
            }
            
        }
        public MISManagerForm()
        {
            InitializeComponent();
        }

        private void Empidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            int output = 0;

            if (Empidtxt.Text == "" || !int.TryParse(Empidtxt.Text, out output))
            {
                MessageBox.Show("Employee ID not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (Empidtxt.Text.Length > 3 || Empidtxt.Text.Length < 3)
            {
                MessageBox.Show("client ID must be 3 digits", "Error", MessageBoxButtons.OK);
            }

           
           
            emp.EmpId = Empidtxt.Text;
            emp.FirstName = Empfnametxt.Text;
            emp.LastName = Emplnametxt.Text;
            emp.PhoneNumber1 = PhoneNotxt.Text;
            emp.FaxNumber = FaxNotxt.Text;
            emp.Email = emailtxt.Text;
            emp.JobTitle = JobTitleCombo.Text;
            emp.saveEmployee(emp);



        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            Emplist.Items.Clear();
            Employee emp = new Employee();

            foreach (Employee item in emp.Display())
            {
                string[] x =
                {
                    Convert.ToString(item.EmpId),item.FirstName,item.LastName,item.Email
                    ,item.PhoneNumber1,item.FaxNumber,item.JobTitle
                };
                var listViewItem = new ListViewItem(x);
                Emplist.Items.Add(listViewItem);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            Employee emp = new Employee();
            foreach (Employee item in emp.Display())
            {
                if (comboSearch.Text == "EmpId")
                {
                    if (item.EmpId == SearchordeleteEmptxt.Text)
                    {
                        found = true;
                        emp = item;
                    }
                }
                if (comboSearch.Text == "FirstName")
                {
                    if (item.FirstName == SearchordeleteEmptxt.Text)
                    {
                        found = true;
                        emp = item;
                    }
                }
                if (comboSearch.Text == "LastName")
                {
                    if (item.LastName == SearchordeleteEmptxt.Text)
                    {
                        found = true;
                        emp = item;
                    }
                }
                
            }
            if (found)
            {
                Empidtxt.Text = emp.EmpId;
                Empfnametxt.Text = emp.FirstName;
                Emplnametxt.Text = emp.LastName;
                PhoneNotxt.Text = emp.PhoneNumber1;
                FaxNotxt.Text = emp.FaxNumber;
                emailtxt.Text = emp.Email;
                JobTitleCombo.Text = emp.JobTitle;          
            }

            else { MessageBox.Show("The element: " + SearchordeleteEmptxt.Text + " wasn't found."); }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpId = Empidtxt.Text;
            emp.FirstName = Empfnametxt.Text;
            emp.LastName = Emplnametxt.Text;
            emp.PhoneNumber1 = PhoneNotxt.Text;
            emp.FaxNumber = FaxNotxt.Text;
            emp.Email = emailtxt.Text;
            emp.JobTitle = JobTitleCombo.Text;
            bool opt = emp.Update(emp);
            MessageBox.Show("Update OK");
         }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var items = new ListViewItem();
            items = Emplist.FocusedItem;
            Employee emp = new Employee();
            Empidtxt.Text = emp.EmpId;
            Empfnametxt.Text = emp.FirstName;
            Emplnametxt.Text = emp.LastName;
            PhoneNotxt.Text = emp.PhoneNumber1;
            FaxNotxt.Text = emp.FaxNumber;
            emailtxt.Text = emp.Email;
            JobTitleCombo.Text = emp.JobTitle;
            string y = Convert.ToString(items.SubItems[0].Text);
           
            emp.Delete(Convert.ToInt32(y));
            Emplist.Items.Clear();
            foreach (Employee item in emp.Display())
            {
                string[] x =
                {
                    Convert.ToString(item.EmpId),item.FirstName,item.LastName,item.Email
                    ,item.PhoneNumber1,item.FaxNumber,item.JobTitle
                };
                var listViewItem = new ListViewItem(x);
                Emplist.Items.Add(listViewItem);
            }
        }

        private void Emplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = new ListViewItem();
            item = Emplist.FocusedItem;
            Employee emp = new Employee();
            foreach (Employee test in emp.Display())
            {
                if (test.EmpId == item.SubItems[0].Text)
                {
                    Empidtxt.Text = test.EmpId;
                    Empfnametxt.Text = test.FirstName;
                    Emplnametxt.Text = test.LastName;
                    PhoneNotxt.Text = test.PhoneNumber1;
                    FaxNotxt.Text = test.FaxNumber;
                    emailtxt.Text = test.Email;
                    JobTitleCombo.Text = test.JobTitle;
                }
            }
        }

        private void textclear_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            Empidtxt.Text = "";
            Empfnametxt.Text = "";
            Emplnametxt.Text = "";
            PhoneNotxt.Text = "";
            FaxNotxt.Text = "";
            emailtxt.Text = "";
            JobTitleCombo.Text = "";
            Empidtxt.Focus();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {

            byte res;
            res = Convert.ToByte(MessageBox.Show("Do you want to Quit?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation));
            if (res == 6) { this.Close(); }
        }

        private void PhoneNotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MISManagerForm_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            listEmp = emp.Display();
            foreach (Employee anEmp in listEmp )
            {
                JobTitleCombo.Items.Add(anEmp.JobTitle);
            }
        }

        private void JobTitleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

