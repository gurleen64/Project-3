using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Management_System.DAL;

namespace Hi_Tech_Management_System.BLL
{
    class Employee:Person
    {
        private string empId;
        private string jobTitle;

        public string EmpId { get => empId; set => empId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public Employee() : base()
        {
            empId = "";
            jobTitle = "";
        }
        public Employee(string empId, string firstName, string lastName, string phoneNumber, string faxNumber, string email, string jobTitle) : base(firstName, lastName, phoneNumber, faxNumber, email)

        {
            this.empId = EmpId;
            this.jobTitle = JobTitle;
        }
        public void saveEmployee(Employee emp)
        {
            EmployeeDA.SaveEmployeeInfo(emp);
        }
        public List<Employee> Display()
        {
            return EmployeeDA.EmployeeDisplay();
        }
        public bool Update(Employee emp)
        {
            return (EmployeeDA.UpdateEmployee(emp));
        }
        public void Delete(int empID)
        {
            EmployeeDA.DeleteEmployee(empID);
        }

        public void SaveEmp(ComboBox tempCombo)
        {
            EmployeeDA.EmployeeList(tempCombo);
        }

    }
}
