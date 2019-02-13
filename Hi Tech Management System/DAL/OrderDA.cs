using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Hi_Tech_Management_System.BLL;

namespace Hi_Tech_Management_System.DAL
{
    class OrderDA
    {

        private static string OrderPath = Application.StartupPath + @"\Orders.txt";
        private static string OrderPathTemp = Application.StartupPath + @"\OrdersTemp.txt";
        private static string ClientPath = Application.StartupPath + @"\ClientInfo.txt";
        private static string BooksPath = Application.StartupPath + @"\InventoryBooks.txt";
        private static string softwarePath = Application.StartupPath + @"\InventorySoftwares.txt";


        public static void SaveOrders(Orders order)
        {
            StreamWriter sWriter = new StreamWriter(OrderPath, true);
            sWriter.WriteLine(order.OrderId + "," + order.ClientID + "," + order.OrderDate + "," + order.ShippedDate +
                              "," + order.BookISBN + "," + order.BookTitle + "," + order.SoftwareId + "," + order.SoftwareName);
            sWriter.Close();
            MessageBox.Show("Order is created successfuly.....", "Confirmation",
                MessageBoxButtons.OK);
        }
        public static bool Updateorders(Orders order)
        {
            bool success = true;
            if (File.Exists(OrderPath))
            {

                StreamReader sReader = new StreamReader(OrderPath);
                StreamWriter sWriter = new StreamWriter(OrderPathTemp);

                string line = sReader.ReadLine();
                while (line != null)
                {

                    string[] fields = line.Split(',');
                    if (fields[0] != order.OrderId)
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," +
                            fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7]);
                    }

                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.WriteLine(order.OrderId + "," + order.ClientID + "," + order.OrderDate + "," + order.ShippedDate + "," + order.BookISBN + "," + order.BookTitle + "," + order.SoftwareId + "," + order.SoftwareName);

                sWriter.Close();
                File.Delete(OrderPath);
                File.Move(OrderPathTemp, OrderPath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter order data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;

        }

        public static void DeleteOrders(string OrderId)
        {
            try
            {
                StreamReader sReader = new StreamReader(OrderPath, true);
                StreamWriter sWriter = new StreamWriter(OrderPathTemp, true);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] newline = line.Split(',');
                    if (newline[0] != OrderId)
                    {
                        sWriter.WriteLine(newline[0] + "," + newline[1] + "," + newline[2] + "," + newline[3] + "," + newline[4] + "," + newline[5] + "," + newline[6]
                            + "," + newline[7]);
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
                sWriter.Close();
                File.Delete(OrderPath);
                File.Move(OrderPathTemp, OrderPath);
            }
            catch (NullReferenceException excp)
            {
                MessageBox.Show(excp.Message);
            }
        }

        public static List<Orders> OrderDisplay()
        {
            List<Orders> list = new List<Orders>();
            StreamReader Reader = new StreamReader(OrderPath);
            string line = Reader.ReadLine();
            while (line != null)
            {
                Orders order = new Orders();
                string[] fields = line.Split(',');
                order.OrderId = fields[0];
                order.ClientID = fields[1];
                order.OrderDate = fields[2];
                order.ShippedDate = fields[3];
                order.BookTitle = fields[4];
                order.BookISBN = fields[5];
                order.SoftwareId = fields[6];
                order.SoftwareName = fields[7];
                list.Add(order);
                line = Reader.ReadLine();

            }
            Reader.Close();

            return list;

        }

    }
}

