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
    public partial class SalesManagerForm : Form
    {
        Client client = new Client();
        
        List<int> test = new List<int>();
        public void ClearAllControls()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                Clientlist.Items.Clear();
            }
            Clientidtxt.Focus();
        }
        public SalesManagerForm()
        {
            InitializeComponent();
        }

        private void SalesManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte res;
            res = Convert.ToByte(MessageBox.Show("Do you want to Quit?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation));
            if (res == 6) { this.Close(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            int output = 0;

            if (Clientidtxt.Text == "" || !int.TryParse(Clientidtxt.Text, out output))
            {
                MessageBox.Show("Client ID not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (Clientidtxt.Text.Length > 4 || Clientidtxt.Text.Length < 4)
            {
                MessageBox.Show("client ID must be 4 digits", "Error", MessageBoxButtons.OK);
            }

            
           
            client.ClientID = Clientidtxt.Text;
            client.FirstName = ClientfNametxt.Text;
            client.LastName = Clientlnametxt.Text;
            client.PhoneNumber1 = ClientphoneNotxt.Text;
            client.FaxNumber = ClientFaxtxt.Text;
            client.Email = Clientemailtxt.Text;
            client.Street = Streettxt.Text;
            client.City = Citytxt.Text;
            client.PostalCode = PostalCodetxt.Text;
            client.CreditLimit = creditLimittxt.Text;
            client.UniORcllg = CllgorUnitxt.Text;
            client.saveClientInfo(client);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var items = new ListViewItem();
            items = Clientlist.FocusedItem;
            string y = Convert.ToString(items.SubItems[0].Text);
            Client client = new Client();
            client.Delete(Convert.ToInt32(y));
            Clientlist.Items.Clear();
            foreach (Client item in client.Display())
            {
                string[] x =
                {
                   Convert.ToString(item.ClientID),item.FirstName,item.LastName
                    ,item.PhoneNumber1,item.FaxNumber,item.Email,item.Street,item.City,
                    item.PostalCode,item.CreditLimit,item.UniORcllg
                };
                var listViewItem = new ListViewItem(x);
                Clientlist.Items.Add(listViewItem);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ClientID = Clientidtxt.Text;
            client.FirstName = ClientfNametxt.Text;
            client.LastName = Clientlnametxt.Text;
            client.PhoneNumber1 = ClientphoneNotxt.Text;
            client.FaxNumber = Clientemailtxt.Text;
            client.Email = Clientemailtxt.Text;
            client.Street = Streettxt.Text;
            client.City = Citytxt.Text;
            client.PostalCode = PostalCodetxt.Text;
            client.CreditLimit = creditLimittxt.Text;
            client.UniORcllg = CllgorUnitxt.Text;
            bool opt = client.Update(client);
            MessageBox.Show("Update OK");
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            Clientlist.Items.Clear();
            Client client = new Client();

            foreach (Client item in client.Display())
            {
                string[] x =
                {
                   item.ClientID,item.FirstName,item.LastName
                    ,item.PhoneNumber1,item.FaxNumber,item.Email,item.Street,item.City,item.PostalCode,item.CreditLimit,item.UniORcllg
                };
                var listViewItem = new ListViewItem(x);
                Clientlist.Items.Add(listViewItem);
            }
        }

        private void Cleartxt_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            Clientidtxt.Text = "";
            ClientfNametxt.Text = "";
            Clientlnametxt.Text = "";
            ClientphoneNotxt.Text = "";
            ClientFaxtxt.Text = "";
            Clientemailtxt.Text = "";
            Streettxt.Text = "";
            Citytxt.Text = "";
            PostalCodetxt.Text = "";
            creditLimittxt.Text = "";
            CllgorUnitxt.Text = "";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            Client client = new Client();
            foreach (Client item in client.Display())
            {
                if (comboSearch.Text == "ClientID")
                {

                    if (item.ClientID == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }
                if (comboSearch.Text == "FirstName")
                {
                    if (item.FirstName == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }
                if (comboSearch.Text == "LastName")
                {
                    if (item.LastName == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }
                if (comboSearch.Text == "PhoneNo")
                {
                    if (item.LastName == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }
                if (comboSearch.Text == "FaxNo")
                {
                    if (item.LastName == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }

                if (comboSearch.Text == "Email")
                {
                    if (item.LastName == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }

                if (comboSearch.Text == "Street")
                {
                    if (item.Street == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }
                if (comboSearch.Text == "City")
                {
                    if (item.City == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }
                if (comboSearch.Text == "Postal Code")
                {
                    if (item.PostalCode == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }
                if (comboSearch.Text == "Credit Limit")
                {
                    if (item.CreditLimit == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }

                if (comboSearch.Text == "University or college")
                {
                    if (item.UniORcllg == Searchtxtbox.Text)
                    {
                        found = true;
                        client = item;
                    }
                }
            }
            if (found)
            {
                MessageBox.Show(client.ClientID + "," + client.FirstName + "," +
                    client.LastName + "," + client.Street + "," +
                    client.PhoneNumber1 + "," + client.PostalCode
                      + "," + client.FaxNumber + "," + client.Email + "," + client.CreditLimit +
                     "," + client.UniORcllg);
            }

            else { MessageBox.Show("The element: " + Searchtxtbox.Text + " wasn't found."); }
        }

        private void Clientemailtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

