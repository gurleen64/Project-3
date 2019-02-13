using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Management_System.DAL;

namespace Hi_Tech_Management_System.BLL
{
    class User
    {
        string userName;
        string password;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public bool LoginValidate(string username, string password)
        {
            return (UserDA.loginValidation(username, password));
        }
        public void saveUser(User user)
        {
            UserDA.SaveUser(user);
        }

        public void searchUser(int username, string password)
        {
            UserDA.SearchUser(username, password);
        }

    }
}
