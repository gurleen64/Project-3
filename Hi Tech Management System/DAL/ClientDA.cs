using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Hi_Tech_Management_System.BLL;
using System.Windows.Forms;

namespace Hi_Tech_Management_System.DAL
{
    class ClientDA
    {
        private static string ClientPath = Application.StartupPath + @"\ClientInfo.txt";
        private static string ClientPathTemp = Application.StartupPath + @"\ClientInfoTemp.txt";
        public static void SaveclientInfo(Client clientinfo)
        {
            StreamWriter sWriter = new StreamWriter(ClientPath, true);
            sWriter.WriteLine(clientinfo.ClientID + "," + clientinfo.FirstName + "," + clientinfo.LastName + "," + clientinfo.PhoneNumber1 + "," +
                              clientinfo.FaxNumber + "," + clientinfo.Email + "," + clientinfo.Street + "," + clientinfo.City + "," + clientinfo.PostalCode + "," + clientinfo.CreditLimit + "," + clientinfo.UniORcllg);

            sWriter.Close();
            MessageBox.Show("Client information  is saved successfuly.....", "Confirmation",
                MessageBoxButtons.OK);
        }
        public static List<Client> ClientDisplay()
        {
            List<Client> list = new List<Client>();
            StreamReader Reader = new StreamReader(ClientPath);
            string line = Reader.ReadLine();
            while (line != null)
            {
                Client client = new Client();
                string[] fields = line.Split(',');
                client.ClientID = fields[0];
                client.FirstName = fields[1];
                client.LastName = fields[2];
                client.PhoneNumber1 = fields[3];
                client.FaxNumber = fields[4];
                client.Email = fields[5];
                client.Street = fields[6];
                client.City = fields[7];
                client.PostalCode = fields[8];
                client.CreditLimit = fields[9];
                //client.UniORcllg = fields[10];
                list.Add(client);
                line = Reader.ReadLine();
            }
            Reader.Close();

            return list;

        }
        public static bool Updateclient(Client client)
        {
            bool success = true;
            if (File.Exists(ClientPath))
            {

                StreamReader sReader = new StreamReader(ClientPath);
                StreamWriter sWriter = new StreamWriter(ClientPathTemp);

                string line = sReader.ReadLine();
                while (line != null)
                {

                    string[] fields = line.Split(',');
                    if (fields[0] != Convert.ToString(client.ClientID))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                            "," + fields[5] + "," + fields[6] + "," + fields[7] + "," +
                            fields[8] + "," + fields[9] + "," + fields[10]);
                    }

                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.WriteLine(client.ClientID + "," + client.FirstName + "," + client.LastName + "," + client.PhoneNumber1 + "," + client.FaxNumber + "," + client.Email + "," + client.Street + "," + client.City + "," + client.PostalCode + "," + client.CreditLimit + "," + client.UniORcllg);

                sWriter.Close();
                File.Delete(ClientPath);
                File.Move(ClientPathTemp, ClientPath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter Employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;

        }
        public static void Deleteclient(int ClientId)
        {
            if (File.Exists(ClientPath))
            {
                StreamReader sReader = new StreamReader(ClientPath);
                StreamWriter sWriter = new StreamWriter(ClientPathTemp);

                string line = sReader.ReadLine();
                if (line == null)
                {
                    MessageBox.Show("The File does not contain any data.Please enter client data.");
                }
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[0] != Convert.ToString(ClientId))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," +
                            fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," +
                            fields[9] + "," + fields[10]);
                    }
                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.Close();

                File.Delete(ClientPath);
                File.Move(ClientPathTemp, ClientPath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter Employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
