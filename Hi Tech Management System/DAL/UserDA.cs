using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Hi_Tech_Management_System.BLL;
using Hi_Tech_Management_System.Validation;
using Hi_Tech_Management_System.GUI;

namespace Hi_Tech_Management_System.DAL
{
    class UserDA
    {
        private static string filePath = Application.StartupPath + @"\Userinfo.txt";
        private static string filePathtemp = Application.StartupPath + @"\Userinfotemp.txt";
        private static string backup = Application.StartupPath + @"\Userinfobackup.txt";
        private static string EmployeePath = Application.StartupPath + @"\EmployeeInfo.txt";
        public static bool loginValidation(string username, string password)
        {
            bool userIsValid = false;
            bool isValidDigit = Validation.Validation.ValidDigit((password), 5);

            if (!isValidDigit)
            {
                userIsValid = false;
                MessageBox.Show("Wrong data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Password has to be 5-digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (File.Exists(filePath))
            {
                StreamReader sReader = new StreamReader(filePath, true);
                string line = sReader.ReadLine();
                try
                {
                    while (sReader.Peek() != 1)
                    {
                        string[] field = line.Split(',');
                        if (field[0] == username && field[1] == password && Validation.Validation.ValidDigit((password), 5))
                        {
                            userIsValid = true;
                            break;
                        }

                        line = sReader.ReadLine();
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK,
                                                       MessageBoxIcon.Exclamation);
                }
                sReader.Close();
            }

            return userIsValid;
        }

        public static void SaveUser(User user)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(user.UserName + "," + user.Password);
            sWriter.Close();
            MessageBox.Show("User is created successfuly.....", "Confirmation",
            MessageBoxButtons.OK);
        }
        public static Employee SearchUser(int username, string password)
        {


            if (File.Exists(EmployeePath))
            {


                StreamReader sReader = new StreamReader(EmployeePath);


                bool found = false;

                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');

                    if (fields[0] == username.ToString())
                    {

                        if (Convert.ToString(fields[6]) == "MIS Manager")
                        {

                            MessageBox.Show("Login Successful! Welcome MIS Manager!", "MIS Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            found = true;
                            MISManagerForm M1 = new MISManagerForm();
                            M1.ShowDialog();
                            break;

                        }
                        if (Convert.ToString(fields[6]) == "Sales Manager")
                        {

                            MessageBox.Show("Login Successful.... Welcome Sales Manager!", "Sales Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            SalesManagerForm S1 = new SalesManagerForm();
                            S1.ShowDialog();
                            break;

                        }
                        if (Convert.ToString(fields[6]) == "Inventory Controller")
                        {
                            MessageBox.Show("Login Successful.... Welcome to inventory Controller!", "Inventory Controller", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            found = true;
                            InventoryCollectorForm I1 = new InventoryCollectorForm();
                            I1.ShowDialog();
                            break;
                        }
                        if (Convert.ToString(fields[6]) == "Order Clerk")
                        {
                            MessageBox.Show("Login Successful.... Welcome to Order Clerk!", "Order Clerks", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            found = true;
                            OrdersClerkForm O1 = new OrdersClerkForm();
                            O1.ShowDialog();
                            break;
                        }

                    }

                    line = sReader.ReadLine();

                }
                sReader.Close();

                if (!found)
                {
                    MessageBox.Show("Check the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {
                MessageBox.Show("file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

    }
}

