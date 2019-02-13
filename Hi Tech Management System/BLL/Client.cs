using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Management_System.DAL;

namespace Hi_Tech_Management_System.BLL
{
    class Client : Person
    {
        private string clientID;
        private string street;
        private string postalCode;
        private string uniORcllg;
        private string creditLimit;
        private string city;

        public string ClientID { get => clientID; set => clientID = value; }
        public string Street { get => street; set => street = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string UniORcllg { get => uniORcllg; set => uniORcllg = value; }
        public string CreditLimit { get => creditLimit; set => creditLimit = value; }
        public string City { get => city; set => city = value; }

        public Client() : base()
        {
            clientID = "";
            street = "";
            city = "";
            uniORcllg = "";
            creditLimit = "";
        }
        public Client(string clientId, string firstName, string lastName, string phoneNumber, string faxNumber, string email, string street, string uniORcllg, string city, string postalCode, string creditLimit) : base(firstName, lastName, phoneNumber, faxNumber, email)
        {
            this.clientID = ClientID;
            this.street = street;
            this.uniORcllg = uniORcllg;
            this.City = city;
            this.postalCode = postalCode;
            this.creditLimit = creditLimit;
        }
        public void saveClientInfo(Client clientinfo)
        {
            ClientDA.SaveclientInfo(clientinfo);
        }
        public List<Client> Display()
        {
            return ClientDA.ClientDisplay();
        }
        public bool Update(Client client)
        {
            return (ClientDA.Updateclient(client));
        }
        public void Delete(int clientID)
        {
            ClientDA.Deleteclient(clientID);
        }

    }
}

