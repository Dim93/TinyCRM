using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrm.Core.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public DateTime Created { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string VatNumber { get; set; }
        public decimal TotalGross { get; set; }
        public bool IsActive { get; set; }
        public List<Order> Orders {get; set;}


        public Customer()
        {
            Orders = new List<Order>();
        }

        public bool IsValidEmail(string Email)
        {
            if (!String.IsNullOrWhiteSpace(Email))
            {
                Email = Email.Trim();

                if (Email.Contains("@") &&
                    (Email.EndsWith(".com") || Email.EndsWith(".gr")))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsValidVatNumber(string vatNumber)
        {
            if (String.IsNullOrWhiteSpace(vatNumber))
            {
                Console.WriteLine("Afm is Empty.");
            }

            vatNumber = vatNumber.Trim();

            if (int.TryParse(vatNumber, out int number) && vatNumber.Length == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
        public List<Order> customerListOfOrders = new List<Order>();


    }
}
