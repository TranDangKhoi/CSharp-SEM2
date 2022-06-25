using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCSharpExam
{
    internal class Product
    {
        private int id;
        private string? name;
        private double price;

        public Product()
        {
        }

        public Product(int id, string? name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}
