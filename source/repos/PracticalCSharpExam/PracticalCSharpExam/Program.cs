using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCSharpExam
{
    internal class Program
    {
        List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            Program program = new Program();
            try
            {
                while (true)
                {
                    program.menu();
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            program.AddProduct();
                            break;
                        case 2:
                            program.GetAllProducts();
                            break;
                        case 3:
                            program.DeleteProductById();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please select an appropriate option!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error! An error occurred." + ex.Message);
            }
            Console.ReadLine();
        }


        // menu 
        public void menu()
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by id");
            Console.WriteLine("4. Exit");
            Console.Write("Your choice is : ");
        }

        //Add product records
        public void AddProduct()
        {
            Console.Write("\nEnter Product ID :");
            int id = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (var item in products)
            {
                if (item.ProductId.Equals(id))
                {
                    Console.WriteLine("Already exists product id = {0}", id);
                    count = 1;
                    break;
                }

            }

            if (count == 0)
            {
                Console.Write("Enter product Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Product Price : ");
                double price = double.Parse(Console.ReadLine());
                products.Add(new Product() { ProductId = id, ProductName = name, ProductPrice = price });
                Console.WriteLine("Add success !");
            }

        }


        // Display product records

        public void GetAllProducts()
        {
            Console.WriteLine(string.Format("{0,-10} {1,-10} {2}", "ProductID", "Name", "Price"));
            Console.WriteLine("---------------------------------------------------");
            if (products.Count > 0)
            {
                foreach (var item in products)
                {
                    Console.WriteLine(
                        string.Format("{0,-10} {1,-10} ${2}", item.ProductId, item.ProductName, item.ProductPrice)
                        );
                }
            }
            else
            {
                Console.WriteLine("There haven't any products yet!");
            }

        }

        //Delete product by Id
        public void DeleteProductById()
        {
            Console.Write("Enter Product ID to Delete : ");
            int id = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            foreach (var item in products)
            {
                if (item.ProductId.Equals(id))
                {
                    products.Remove(
                        products.Find(
                            p => { return p.ProductId == id; }
                            )
                        );
                    Console.WriteLine("Delete sucess !");
                    count = 1;
                    break;
                }
                else
                {
                    count = 0;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Not Found ProductId : {0}", id);
            }
        }
    }
}
