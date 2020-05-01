using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TinyCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsFromFile;                                                           // Read Csv file's contents to a string array.

            try
            {
                productsFromFile = File.ReadAllLines("Products.csv");
            } catch (Exception) { 
                return;
            }
            
            if (productsFromFile.Length == 0)
            {
                return;
            }

            // productsFromFile(lines comma) -> productsArray
            var productsArray = new Product[productsFromFile.Length];                            // Create an Array of Products.

            for (var i = 0; i < productsFromFile.Length; i++)                                    // Loop through the array with the file's content.
            {                                                                            
                var values = productsFromFile[i].Split(';');                                     // Split with ';' each line and create Product class Objects.
                var isDuplicate = false;

                foreach (var p in productsArray)
                {
                    if (p != null && p.ProductId.Equals(values[0]))
                    {
                        isDuplicate = true;
                    }
                }

                if (!isDuplicate)
                {
                    var product = new Product()
                    {
                        ProductId = values[0],
                        Name = values[1],
                        Description = values[2],
                        Price = GetRandomNumber(),
                    };
                    productsArray[i] = product;
                }
                
            }
            
            foreach(var p in productsArray)
            {
                Console.WriteLine($"{p.ProductId} {p.Name} {p.Price}");
            }
        }

        public static decimal GetRandomNumber()                                          // Method to generate random price;
        {
            var random = new Random();
            var randomNumber = (decimal)Math.Round(random.NextDouble() * 100, 2);

            return randomNumber;
        }
    }
}
