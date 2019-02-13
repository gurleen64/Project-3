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
    class InventoryControllerDA
    {
        private static string BooksPath = Application.StartupPath + @"\InventoryBooks.txt";
        private static string BooksPathTemp = Application.StartupPath + @"\InventoryBooksTemp.txt";
        private static string softwarePath = Application.StartupPath + @"\InventorySoftwares.txt";
        private static string softwareTemp = Application.StartupPath + @"\InventorySoftwaresTemp.txt";
        public static void SaveBooks(Product item)
        {
            StreamWriter sWriter = new StreamWriter(BooksPath, true);
            sWriter.WriteLine(item.BookISBN + "," + item.BookTitle + "," + item.UnitPrice + "," + item.AuthorId + "," + item.AuthorFName + "," + item.AuthorLName + "," + item.PublishedDate);
            sWriter.Close();
            MessageBox.Show("Items are saved successfuly.....", "Confirmation",
                MessageBoxButtons.OK);
        }
        public static void SaveSoftwares(Product item)
        {
            StreamWriter sWriter = new StreamWriter(softwarePath, true);
            sWriter.WriteLine(item.SoftwareId + "," + item.SoftwareName + "," + item.UnitPrice);
            sWriter.Close();
            MessageBox.Show("Items are saved successfuly.....", "Confirmation",
                MessageBoxButtons.OK);
        }
        public static List<Product> BooksDisplay()
        {
            List<Product> list = new List<Product>();
            StreamReader Reader = new StreamReader(BooksPath);
            string line = Reader.ReadLine();
            while (line != null)
            {
                Product myproducts = new Product();
                string[] fields = line.Split(',');
                myproducts.BookISBN = fields[0];
                myproducts.BookTitle = fields[1];
                myproducts.UnitPrice = fields[2];
                myproducts.AuthorId = fields[3];
                myproducts.AuthorFName = fields[4];
                myproducts.AuthorLName = fields[5];
                //myproducts.PublishedDate = fields[6];
                list.Add(myproducts);
                line = Reader.ReadLine();
            }
            Reader.Close();

            return list;

        }
        public static List<Product> SoftwareDisplay()
        {
            List<Product> list = new List<Product>();
            StreamReader Reader = new StreamReader(softwarePath);
            string line = Reader.ReadLine();
            while (line != null)
            {
                Product myproducts = new Product();
                string[] fields = line.Split(',');
                myproducts.SoftwareId = fields[0];
                myproducts.SoftwareName = fields[1];
                myproducts.UnitPrice = fields[2];
                list.Add(myproducts);
                line = Reader.ReadLine();
            }
            Reader.Close();

            return list;

        }
        public static bool UpdateBooks(Product myproducts)
        {
            bool success = true;
            if (File.Exists(BooksPath))
            {

                StreamReader sReader = new StreamReader(BooksPath);
                StreamWriter sWriter = new StreamWriter(BooksPathTemp);

                string line = sReader.ReadLine();
                while (line != null)
                {

                    string[] fields = line.Split(',');
                    if (fields[0] != Convert.ToString(myproducts.BookISBN))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                    }

                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.WriteLine(myproducts.BookISBN + "," + myproducts.BookTitle + "," + myproducts.UnitPrice + "," + myproducts.AuthorId + "," + myproducts.AuthorFName + "," + myproducts.AuthorLName + "," + myproducts.PublishedDate);

                sWriter.Close();
                File.Delete(BooksPath);
                File.Move(BooksPathTemp, BooksPath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter products information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;

        }
        public static bool UpdateSoftwares(Product myproducts)
        {
            bool success = true;
            if (File.Exists(softwarePath))
            {

                StreamReader sReader = new StreamReader(softwarePath);
                StreamWriter sWriter = new StreamWriter(softwareTemp);

                string line = sReader.ReadLine();
                while (line != null)
                {

                    string[] fields = line.Split(',');
                    if (fields[0] != Convert.ToString(myproducts.SoftwareId))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2]);
                    }

                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.WriteLine(myproducts.SoftwareId + "," + myproducts.SoftwareName + "," + myproducts.UnitPrice);

                sWriter.Close();
                File.Delete(softwarePath);
                File.Move(softwareTemp, softwarePath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter products information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;

        }
        public static void DeleteBooks(string bookISBN)
        {
            if (File.Exists(BooksPath))
            {
                StreamReader sReader = new StreamReader(BooksPath);
                StreamWriter sWriter = new StreamWriter(BooksPathTemp);

                string line = sReader.ReadLine();
                if (line == null)
                {
                    MessageBox.Show("The File does not contain any data.Please enter data.");
                }
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[0] != Convert.ToString(bookISBN))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                    }
                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.Close();

                File.Delete(BooksPath);
                File.Move(BooksPathTemp, BooksPath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Deletesoftwares(int softwareId)
        {
            if (File.Exists(softwarePath))
            {
                StreamReader sReader = new StreamReader(softwarePath);
                StreamWriter sWriter = new StreamWriter(softwareTemp);

                string line = sReader.ReadLine();
                if (line == null)
                {
                    MessageBox.Show("The File does not contain any data.Please enter data.");
                }
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[0] != Convert.ToString(softwareId))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2]);
                    }
                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.Close();

                File.Delete(softwarePath);
                File.Move(softwareTemp, softwarePath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

