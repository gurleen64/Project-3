using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Management_System.DAL;

namespace Hi_Tech_Management_System.BLL
{
    class Orders:Product
    {
        private string orderId;
        private string clientID;
        private string orderDate;
        private string shippedDate;

        public string OrderId { get => orderId; set => orderId = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string OrderDate { get => orderDate; set => orderDate = value; }
        public string ShippedDate { get => shippedDate; set => shippedDate = value; }
        public Orders() : base()
        {
            orderId = "";
            OrderDate = "";
            ShippedDate = "";
        }
        public Orders(string orderID, string clientId, string orderDate, string shippedDate, string bookISBN, string bookTitle, int softwareId, string softwareName) : base()

        {
            this.orderId = OrderId;
            this.orderDate = orderDate;
            this.clientID = clientId;
            this.shippedDate = shippedDate;
        }
        public void CreateOrder(Orders order)
        {
            OrderDA.SaveOrders(order);
        }

        public void Deleteorder(string OrderId)
        {
            OrderDA.DeleteOrders(OrderId);
        }

        public bool Updateorder(Orders order)
        {
            return (OrderDA.Updateorders(order));
        }
        public List<Orders> Display()
        {
            return OrderDA.OrderDisplay();
        }

    }
}

