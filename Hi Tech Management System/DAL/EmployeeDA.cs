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
    class EmployeeDA
    {
        private static string EmployeePath = Application.StartupPath + @"\EmployeeInfo.txt";
        private static string EmployeePathTemp = Application.StartupPath + @"\EmployeeInfoTemp.txt";


        public static void SaveEmployeeInfo(Employee emp)
        {
            StreamWriter sWriter = new StreamWriter(EmployeePath, true);
            sWriter.WriteLine(emp.EmpId + "," + emp.FirstName + "," + emp.LastName + "," + emp.PhoneNumber1 + "," +
                              emp.FaxNumber + "," + emp.Email + "," + emp.JobTitle);
            sWriter.Close();
            MessageBox.Show("Employee data  is saved successfuly.....", "Confirmation",
                MessageBoxButtons.OK);
        }
        public static List<Employee> EmployeeDisplay()
        {
            List<Employee> list = new List<Employee>();
            StreamReader Reader = new StreamReader(EmployeePath);
            string line = Reader.ReadLine();
            while (line != null)
            {
                Employee emp = new Employee();
                string[] fields = line.Split(',');
                emp.EmpId = fields[0];
                emp.FirstName = fields[1];
                emp.LastName = fields[2];
                emp.Email = fields[3];
                emp.PhoneNumber1 = fields[4];
                emp.FaxNumber = fields[5];
                emp.JobTitle = fields[6];
                list.Add(emp);
                line = Reader.ReadLine();
            }
            Reader.Close();

            return list;

        }
        public static bool UpdateEmployee(Employee emp)
        {
            bool success = true;
            if (File.Exists(EmployeePath))
            {

                StreamReader sReader = new StreamReader(EmployeePath);
                StreamWriter sWriter = new StreamWriter(EmployeePathTemp);

                string line = sReader.ReadLine();
                while (line != null)
                {

                    string[] fields = line.Split(',');
                    if (fields[0] != Convert.ToString(emp.EmpId))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                    }

                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.WriteLine(emp.EmpId + "," + emp.FirstName + "," + emp.LastName + "," + emp.PhoneNumber1 + "," + emp.FaxNumber + "," + emp.Email + "," + emp.JobTitle);

                sWriter.Close();
                File.Delete(EmployeePath);
                File.Move(EmployeePathTemp, EmployeePath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter Employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;

        }
        public static void DeleteEmployee(int empId)
        {
            if (File.Exists(EmployeePath))
            {
                StreamReader sReader = new StreamReader(EmployeePath);
                StreamWriter sWriter = new StreamWriter(EmployeePathTemp);

                string line = sReader.ReadLine();
                if (line == null)
                {
                    MessageBox.Show("The File does not contain any data.Please enter Employee data.");
                }
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[0] != Convert.ToString(empId))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                    }
                    line = sReader.ReadLine();
                }


                sReader.Close();

                sWriter.Close();

                File.Delete(EmployeePath);
                File.Move(EmployeePathTemp, EmployeePath);

            }
            else
            {
                MessageBox.Show("File not found!Please enter Employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void EmployeeList(ComboBox myCombobox)
        {
            StreamReader Sread = new StreamReader(EmployeePath);
            

            string line = Sread.ReadLine();

            while (line != null)
            {
                string[] input = line.Split(',');

                                
                line = Sread.ReadLine();

            }

            Sread.Close();
        }
    }
}


