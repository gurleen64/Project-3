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
    public partial class InventoryCollectorForm : Form
    {
        public InventoryCollectorForm()
        {
            InitializeComponent();
        }
        public void ClearAllControls()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                SoftwareList.Items.Clear();
            }
            softwareIdtxt.Focus();
        }
        public void ClearAll()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                InventoryList.Items.Clear();
            }
            bookISBNtxt.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoftwareIdtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveSoftwareBtn_Click(object sender, EventArgs e)
        {
            Product item = new Product();

            int output = 0;

            if (softwareIdtxt.Text == "" || !int.TryParse(softwareIdtxt.Text, out output))
            {
                MessageBox.Show("software Id not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (softwareIdtxt.Text.Length > 4 || softwareIdtxt.Text.Length < 4)
            {
                MessageBox.Show("software ID must be 4 digits", "Error", MessageBoxButtons.OK);
            }
            item.SoftwareId = softwareIdtxt.Text;
            item.SoftwareName = SoftwareNametxt.Text;
            item.UnitPrice = unitpricetext.Text;
            item.saveSoftwares(item);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatesoftwarebtn_Click(object sender, EventArgs e)
        {

            Product myproduct = new Product();
            myproduct.SoftwareId = softwareIdtxt.Text;
            myproduct.SoftwareName = SoftwareNametxt.Text;
            myproduct.UnitPrice = unitpricetext.Text;
            bool opt = myproduct.UpdateSoftwares(myproduct);
            MessageBox.Show("Update OK");
        }

        private void listsoftware_Click(object sender, EventArgs e)
        {
            SoftwareList.Items.Clear();
            Product myproduct = new Product();
            foreach (Product item in myproduct.Displaysoftwares())
            {
                string[] x =
                {
                   item.SoftwareId,item.SoftwareName,item.UnitPrice };
                var listViewItem = new ListViewItem(x);
                SoftwareList.Items.Add(listViewItem);
            }
        }

        private void deletesoftwares_Click(object sender, EventArgs e)
        {
            var items = new ListViewItem();
            items = SoftwareList.FocusedItem;
            string y = Convert.ToString(items.SubItems[0].Text);
            Product myproduct = new Product();
            myproduct.Deletesoftware(Convert.ToInt32(y));
            SoftwareList.Items.Clear();
            foreach (Product item in myproduct.Displaysoftwares())
            {
                string[] x =
                {
                      Convert.ToString(item.SoftwareId),item.SoftwareName,item.UnitPrice
                };
                var listViewItem = new ListViewItem(x);
                SoftwareList.Items.Add(listViewItem);
            }
        }

        private void textclear_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            softwareIdtxt.Text = "";
            SoftwareNametxt.Text = "";
            UnitPricetxt.Text = "";
        }

        private void searchsoftwarebtn_Click(object sender, EventArgs e)
        {
            bool found = false;
            Product pro = new Product();
            foreach (Product item in pro.Displaysoftwares())
            {
                if (combo_Search.Text == "Software Id")
                {
                    if (item.SoftwareId == texttosearchsoftwares.Text)
                    {
                        found = true;
                        pro = item;
                    }
                }
                if (combo_Search.Text == "Software name")
                {
                    if (item.SoftwareName == texttosearchsoftwares.Text)
                    {
                        found = true;
                        pro = item;
                    }
                }

            }
            if (found)
            {
                softwareIdtxt.Text = pro.SoftwareId;
                SoftwareNametxt.Text = pro.SoftwareName;
                unitpricetext.Text = pro.UnitPrice;
            }

            else { MessageBox.Show("The element: " + texttosearchsoftwares.Text + " wasn't found."); }


        }

        private void SearchInventoryBtn_Click_1(object sender, EventArgs e)
        {

            bool found = false;
            Product myproduct = new Product();
            foreach (Product item in myproduct.Displaybooks())
            {
                if (combo_Search.Text == "BookISBN")
                {
                    if (item.BookISBN == Searchtxt.Text)
                    {
                        found = true;
                        myproduct = item;
                    }
                }
                if (combo_Search.Text == "BookTitle")
                {
                    if (item.BookTitle == Searchtxt.Text)
                    {
                        found = true;
                        myproduct = item;
                    }
                }
                if (combo_Search.Text == "UnitPrice")
                {
                    if (item.UnitPrice == Searchtxt.Text)
                    {
                        found = true;
                        myproduct = item;
                    }
                }
                if (combo_Search.Text == "AuthorID")
                {
                    if (item.AuthorId == Searchtxt.Text)
                    {
                        found = true;
                        myproduct = item;
                    }
                }
                if (combo_Search.Text == "AuthorFName")
                {
                    if (item.AuthorFName == Searchtxt.Text)
                    {
                        found = true;
                        myproduct = item;
                    }
                }
                if (combo_Search.Text == "AuthorLName")
                {
                    if (item.AuthorLName == Searchtxt.Text)
                    {
                        found = true;
                        myproduct = item;
                    }
                }
                if (combo_Search.Text == "PublishedDate")
                {
                    if (item.PublishedDate == Searchtxt.Text)
                    {
                        found = true;
                        myproduct = item;
                    }
                }
            }
            if (found)
            {
                MessageBox.Show(myproduct.BookISBN + "," + myproduct.BookTitle + "," + myproduct.UnitPrice + "," + myproduct.AuthorId + "," + myproduct.AuthorFName
                + "," + myproduct.AuthorLName + "," + myproduct.PublishedDate);
            }

            else { MessageBox.Show("The element: " + Searchtxt.Text + " wasn't found."); }
        }

    private void ExitBtn_Click(object sender, EventArgs e)
        {
            byte res;
            res = Convert.ToByte(MessageBox.Show("Do you want to Quit?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation));
            if (res == 6) { this.Close(); }
        }

        private void SaveInventoryBtn_Click(object sender, EventArgs e)
        {
            Product item = new Product();
            int output = 0;

            if (bookISBNtxt.Text == "" || !int.TryParse(bookISBNtxt.Text, out output))
            {
                MessageBox.Show("Book ISBN not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (authoridtxt.Text == "" || !int.TryParse(authoridtxt.Text, out output))
            {
                MessageBox.Show("Author ID is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (bookISBNtxt.Text.Length > 4 || bookISBNtxt.Text.Length < 4)
            {
                MessageBox.Show("BookISBN must be 4 digits", "Error", MessageBoxButtons.OK);
            }
            if (authoridtxt.Text.Length > 4 || authoridtxt.Text.Length < 4)
            {
                MessageBox.Show("Author ID must be 4 digits", "Error", MessageBoxButtons.OK);
            }

            item.BookISBN = bookISBNtxt.Text;
            item.BookTitle = bookTitletxt.Text;
            item.UnitPrice = UnitPricetxt.Text;
            item.AuthorId = authoridtxt.Text;
            item.AuthorFName = authorfnametxt.Text;
            item.AuthorLName = authorlnametxt.Text;
            item.savebooks(item);
        }

        private void bookISBNtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListInventoryBtn_Click(object sender, EventArgs e)
        {
            InventoryList.Items.Clear();
            Product myproduct = new Product();
            foreach (Product item in myproduct.Displaybooks())
            {
                string[] x =
                {
                    Convert.ToString(item.BookISBN),item.BookTitle,Convert.ToString(item.UnitPrice),Convert.ToString(item.AuthorId)
                    ,item.AuthorFName,item.AuthorLName,item.PublishedDate
                };
                var listViewItem = new ListViewItem(x);
                InventoryList.Items.Add(listViewItem);
            }
        }

        private void UpdateInventoryBtn_Click(object sender, EventArgs e)
        {
            Product myproduct = new Product();
            myproduct.BookISBN = bookISBNtxt.Text;
            myproduct.BookTitle = bookTitletxt.Text;
            myproduct.UnitPrice = UnitPricetxt.Text;
            myproduct.AuthorId = authoridtxt.Text;
            myproduct.AuthorFName = authorfnametxt.Text;
            myproduct.AuthorLName = authorlnametxt.Text;
            bool opt = myproduct.Updatebooks(myproduct);
            MessageBox.Show("Update OK");
        }

        private void DelInventoryBtn_Click(object sender, EventArgs e)
        {
            var items = new ListViewItem();
            items = InventoryList.FocusedItem;
            string y = items.SubItems[0].Text;
            Product myproduct = new Product();
            myproduct.Deletebooks(y);
            InventoryList.Items.Clear();
            foreach (Product item in myproduct.Displaybooks())
            {
                string[] x =
                {
                      item.BookISBN,item.BookTitle,item.UnitPrice,item.AuthorId
                    ,item.AuthorFName,item.AuthorLName,item.PublishedDate
                };
                var listViewItem = new ListViewItem(x);
                InventoryList.Items.Add(listViewItem);
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            bookISBNtxt.Text = "";
            bookTitletxt.Text = "";
            UnitPricetxt.Text = "";
            authoridtxt.Text = "";
            authorfnametxt.Text = "";
            authorlnametxt.Text = "";
            
        }

        private void SearchInventoryBtn_Click(object sender, EventArgs e)
        {

            bool found = false;
            Product pro = new Product();
            foreach (Product item in pro.Displaybooks())
            {
                if (combo_Search.Text == "Book ISBN")
                {
                    if (item.BookISBN == Searchtxt.Text)
                    {
                        found = true;
                        pro = item;
                    }
                }
                if (combo_Search.Text == "Book Title")
                {
                    if (item.BookTitle == Searchtxt.Text)
                    {
                        found = true;
                        pro = item;
                    }
                }
               
            }
            if (found)
            {
                bookISBNtxt.Text = pro.BookISBN;
                bookTitletxt.Text = pro.BookTitle;
                UnitPricetxt.Text = pro.UnitPrice;
                authoridtxt.Text = pro.AuthorId;
                authorfnametxt.Text = pro.AuthorFName;
                authorlnametxt.Text = pro.AuthorLName;
            }

            else { MessageBox.Show("The element: " + Searchtxt.Text + " wasn't found."); }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            byte res;
            res = Convert.ToByte(MessageBox.Show("Do you want to Quit?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation));
            if (res == 6) { this.Close(); }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void authoridtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void publishedDatetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

   
