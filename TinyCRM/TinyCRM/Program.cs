using System;

namespace TinyCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


/*
 * using System;

namespace String_length
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter text: ");
            Console.WriteLine(IsValidAfm("123456789"));
            Console.WriteLine(IsValidAfm("123"));
            Console.WriteLine(IsValidAfm("   123456789"));
            Console.WriteLine(IsAdult(18));

        }

        public static bool IsValidAfm(string afm)
        {
            if (String.IsNullOrWhiteSpace(afm))
            {
                Console.WriteLine("Afm is Empty.");
            }

            afm = afm.Trim();

            if (int.TryParse(afm, out int number) && afm.Length == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsAdult(int age)
        {
            if (age >= 18 && age <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
            // return age >= 18 && age <= 100;
        }

        public static bool IsValidEmail(string email)
        {
            if (!String.IsNullOrWhiteSpace(email))
            {
                email = email.Trim();

                if (email.Contains("@") &&
                    (email.EndsWith(".com") || email.EndsWith(".gr")))
                {
                    return true;
                }
            }

            return false;
        }
    } 
}

 * 
 * */
