using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Management_System.DAL;

namespace Hi_Tech_Management_System.BLL
{
    class Product
    {
        private string bookISBN;
        private string bookTitle;
        private string unitPrice;
        private string authorId;
        private string authorFName;
        private string authorLName;
        private string publishedDate;
        private string softwareId;
        private string softwareName;

        public string BookISBN { get => bookISBN; set => bookISBN = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string AuthorId { get => authorId; set => authorId = value; }
        public string AuthorFName { get => authorFName; set => authorFName = value; }
        public string AuthorLName { get => authorLName; set => authorLName = value; }
        public string PublishedDate { get => publishedDate; set => publishedDate = value; }
        public string SoftwareId { get => softwareId; set => softwareId = value; }
        public string SoftwareName { get => softwareName; set => softwareName = value; }
        public Product()
        {
            bookISBN = "";
            bookTitle = "";
            unitPrice = "";
            AuthorId = "";
            authorFName = "";
            authorLName = "";
            publishedDate = "";
            softwareId = "";
            softwareName = "";
        }
        public Product(string bookISBN, string bookTitle, string unitPrice, string authorId, string authorFName, string authorLName, string publishedDate, string softwareId, string softwareName)
        {
            this.bookISBN = BookISBN;
            this.bookTitle = BookTitle;
            this.unitPrice = unitPrice;
            this.authorId = authorId;
            this.authorFName = authorFName;
            this.AuthorLName = AuthorLName;
            this.publishedDate = publishedDate;
            this.SoftwareId = softwareId;
            this.SoftwareName = softwareName;
        }
        public void savebooks(Product item)
        {
            InventoryControllerDA.SaveBooks(item);
        }
        public void saveSoftwares(Product item)
        {
            InventoryControllerDA.SaveSoftwares(item);
        }
        public List<Product> Displaybooks()
        {
            return InventoryControllerDA.BooksDisplay();
        }
        public List<Product> Displaysoftwares()
        {
            return InventoryControllerDA.SoftwareDisplay();
        }
        public bool Updatebooks(Product myproducts)
        {
            return (InventoryControllerDA.UpdateBooks(myproducts));
        }
        public bool UpdateSoftwares(Product myproducts)
        {
            return (InventoryControllerDA.UpdateSoftwares(myproducts));
        }
        public void Deletebooks(string BookISBN)
        {
            InventoryControllerDA.DeleteBooks(BookISBN);
        }
        public void Deletesoftware(int softwareID)
        {
            InventoryControllerDA.Deletesoftwares(softwareID);
        }

    }
}

