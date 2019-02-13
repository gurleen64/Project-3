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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User use = new User();
            bool validLogin = use.LoginValidate(userNametxt.Text, passwordtxt.Text);
            
            //if (validLogin == true )
            {
                MISManagerForm MI = new MISManagerForm();
                InventoryCollectorForm IV = new InventoryCollectorForm();
                OrdersClerkForm OC = new OrdersClerkForm();
                if (userNametxt.Text == "125")
                {                   
                    MI.ShowDialog();
                }
                else if (userNametxt.Text == "124")
                {
                    IV.ShowDialog();
                }
                else if (userNametxt.Text == "126" )
                {
                    OC.ShowDialog();
                }
                else if (userNametxt.Text == "129")
                {
                    OC.ShowDialog();
                }
                else { MessageBox.Show("You are not authorized user."); }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte res;
            res = Convert.ToByte(MessageBox.Show("Do you want to Quit?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation));
            if (res == 6) { this.Close(); }
        }
    }
    }

