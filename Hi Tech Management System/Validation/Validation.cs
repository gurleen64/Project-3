using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Hi_Tech_Management_System.BLL;
using Hi_Tech_Management_System.DAL;
using System.Net.Mail;

namespace Hi_Tech_Management_System.Validation
{
    class Validation
    {

        private static string message = "Entry Error";
        public static string Message
        {
            get { return message; }
            set { message = value; }
        }
        public static bool IsLetter(TextBox textBox)
        {
            if (Regex.IsMatch(textBox.Text ?? "", @"^[a-zA-Z\s]+$", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be letters only and not empty.", Message);
                textBox.Clear();
                textBox.Focus();
                return false;
            }

        }
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Message);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field and can not be left blank.", Message);
                textBox.Focus();
                return false;
            }
            else { return true; }
        }

        

        public static bool ValidID(TextBox textBox, List<Employee> emp)
        {
            bool valid = true;
            foreach (Employee item in emp)
            {
                if (item.EmpId == textBox.Text)
                {
                    MessageBox.Show(textBox.Tag + " has to be unique.", Message);
                    textBox.Focus();
                    valid = false;
                }
            }
            return valid;
        }
        public static bool ValidDigit(string value, int id)
        {
            Regex rg = new Regex(@"^(\w){5,7}$");

            return rg.IsMatch(value);
        }

    }
}
   
