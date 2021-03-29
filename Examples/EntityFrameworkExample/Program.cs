using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {

           var customerContext = new CustomerContext();
           var shoppingContext = new ShoppingContext();

         //GetData(customerContext);

        MultiTableInsert(shoppingContext);
         //DeleteData(customerContext);

        }

        public static void InsertData(CustomerContext customerContext)
        {
           
            var customer1 = new Customer();
            customer1.Name = "jahin";
            customer1.Address = "Dhaka";
            var customer2 = new Customer
            {
                Name = "Hasan",
                Address = "Mymenshing"
            };
            var customer3 = new Customer
            {
                Name = "Taher",
                Address = "Nandiel"

            };

            customerContext.Customers.AddRange(customer1, customer2, customer3);
            customerContext.SaveChanges();
        }

        public static void GetData(CustomerContext customerContext)
        {
            var customers = customerContext.Customers.Where(x=>x.Address=="Dhaka").ToList();
            foreach(var customer in customers)
            {
                Console.Write(customer.Name+" ");
                Console.WriteLine(customer.Address);
            }  


        }

        public static void EditData(CustomerContext customerContext)
        {
            var customer = customerContext.Customers.Where(x => x.Id <= 1 ).FirstOrDefault();
            customer.Address = "Bogura";
            customer.Name = "Taraq";
            customerContext.SaveChanges();


        }
        public static void DeleteData(CustomerContext customerContext)
        {
               var customer = customerContext.Customers.Where(x => x.Id <= 1).FirstOrDefault();
               customerContext.Customers.Remove(customer);
               customerContext.SaveChanges();



        }

        public static void MultiTableInsert(ShoppingContext shoppingContext)
        {
            var category = new Category
            {
                Name = "Electronics"
            };
            var product = new Product
            {
                Name = "Camera ",
                Price = 2000,
                Images = new List<ProductImage>
                {
                    new ProductImage{Url = "www.google.com/camer1.png"},
                    new ProductImage{Url = "www.google.com/camer2.png"},
                }

            };
            shoppingContext.category.Add(category);
            shoppingContext.Products.Add(product);
            shoppingContext.SaveChanges();

        
        }




    }
}
