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
    public partial class OrdersClerkForm : Form
    {
        public OrdersClerkForm()
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
                Orderlist.Items.Clear();
            }
            OrderIDtxt.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte res;
            res = Convert.ToByte(MessageBox.Show("Do you want to Quit?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation));
            if (res == 6) { this.Close(); }
        }

        private void UpdateOrdersBtn_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.OrderId = OrderIDtxt.Text;
            order.ClientID = ClientIDCombo.Text;
            order.OrderDate = OrderDatetxt.Text;
            order.ShippedDate = shippedDatetxt.Text;
            order.BookISBN = ISBNCombo1.Text;
            order.BookTitle = TitleCombo2.Text;
            order.SoftwareId = SoftwareIDCombo.Text;
            order.SoftwareName = SoftwareNAmeCombo.Text;
            bool opt = order.Updateorder(order);
            MessageBox.Show("Update OK");
        }

        private void Cleartxt_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            OrderIDtxt.Text = "";
            ClientIDCombo.Text = "";
            OrderDatetxt.Text = "";
            shippedDatetxt.Text = "";
            ISBNCombo1.Text = "";
            TitleCombo2.Text = "";
            SoftwareIDCombo.Text = "";
            SoftwareNAmeCombo.Text = "";
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            var items = new ListViewItem();
            items = Orderlist.FocusedItem;
            string y = Convert.ToString(items.SubItems[0].Text);
            Orders order = new Orders();
            order.Deleteorder(y);
            Orderlist.Items.Clear();
            foreach (Orders item in order.Display())
            {
                string[] x =
                {
                    item.OrderId,item.ClientID,item.OrderDate,item.ShippedDate
                    ,item.BookISBN,item.BookTitle,Convert.ToString(item.SoftwareId),item.SoftwareName
                };
                var listViewItem = new ListViewItem(x);
                Orderlist.Items.Add(listViewItem);
            }
        }

        private void Listbtn_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();

            foreach (Orders item in order.Display())
            {
                string[] x =
                {
                    item.OrderId,item.ClientID,item.OrderDate,item.ShippedDate,item.BookISBN
                    ,item.BookTitle,Convert.ToString(item.SoftwareId),item.SoftwareName
                };
                var listViewItem = new ListViewItem(x);
                Orderlist.Items.Add(listViewItem);
            }
        }

        private void SearchOrderBtn_Click(object sender, EventArgs e)
        {
            bool found = false;
            Orders order = new Orders();

            foreach (Orders item in order.Display())
            {
                if (combo_SearchOrders.Text == "Order Id")
                {
                    if (item.OrderId == Searchtxt.Text)
                    {
                        found = true;
                        order = item;
                    }
                }
                if (combo_SearchOrders.Text == "Client Id")
                {
                    if (item.ClientID == Searchtxt.Text)
                    {
                        found = true;
                        order = item;
                    }
                }
                
                if (found)
                {
                    ISBNCombo1.Text = item.BookISBN;
                    TitleCombo2.Text = item.BookTitle;
                    SoftwareIDCombo.Text = item.SoftwareId;
                    SoftwareNAmeCombo.Text = item.SoftwareName;
                    OrderIDtxt.Text = item.OrderId;
                    ClientIDCombo.Text = item.ClientID;
                    OrderDatetxt.Text = item.OrderDate;
                    shippedDatetxt.Text = item.ShippedDate;
                }

                else { MessageBox.Show("The element: " + Searchtxt.Text + " wasn't found."); }
            }


        }

        private void Orderlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = new ListViewItem();
            item = Orderlist.FocusedItem;
            Orders order = new Orders();
            foreach (Orders test in order.Display())
            {
                if (test.OrderId == item.SubItems[0].Text)
                {
                    OrderIDtxt.Text = test.OrderId;
                    ClientIDCombo.Text = test.ClientID;
                    OrderDatetxt.Text = test.OrderDate;
                    shippedDatetxt.Text = test.ShippedDate;
                    ISBNCombo1.Text = test.BookISBN;
                    TitleCombo2.Text = test.BookTitle;
                    SoftwareIDCombo.Text = Convert.ToString(test.SoftwareId);
                    SoftwareNAmeCombo.Text = test.SoftwareName;
                }
            }
        }

        private void CreateOrdersBtn_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.OrderId = OrderIDtxt.Text;
            order.ClientID = ClientIDCombo.Text;
            order.OrderDate = OrderDatetxt.Text;
            order.ShippedDate = shippedDatetxt.Text;
            order.BookISBN = ISBNCombo1.Text;
            order.BookTitle = TitleCombo2.Text;
            order.SoftwareId = (SoftwareIDCombo.Text);
            order.SoftwareName = SoftwareNAmeCombo.Text;
            order.CreateOrder(order);
        }

        private void OrdersClerkForm_Load(object sender, EventArgs e)
        {
            DateTime myDateToday = DateTime.Today;
            OrderDatetxt.Text = myDateToday.Date.ToShortDateString();
            DateTime fivedaysafter = myDateToday.AddDays(5);
            shippedDatetxt.Text = fivedaysafter.Date.ToShortDateString();
            Product product = new Product();
            foreach (Product item in product.Displaybooks())
            {
                ISBNCombo1.Items.Add(item.BookISBN);
                TitleCombo2.Items.Add(item.BookTitle);

            }
            foreach (Product item in product.Displaysoftwares())
            {
                SoftwareIDCombo.Items.Add(item.SoftwareId);
                SoftwareNAmeCombo.Items.Add(item.SoftwareName);

            }

            Client test = new Client();
            foreach (Client client in test.Display())
            {
                ClientIDCombo.Items.Add(client.ClientID);

            }
        }

        private void SoftwareNAmeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_SearchOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

