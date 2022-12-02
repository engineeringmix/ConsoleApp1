using System;
using System.Configuration;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation test = new Validation();
            Console.WriteLine("Enter your Email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter your Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your Phone:");
            string Phone = Console.ReadLine();

            test.ValidateEmail(Email);
            test.ValidateName(Name);
            test.ValidateNumber(Phone);

            Console.ReadKey();
        }
    }
    class Validation
    {
        //validation for email
        public void ValidateEmail(string email)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(email))
                isValid = false;
            else
            {
                try
                {
                    MailAddress m = new MailAddress(email);
                    isValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isValid = false;
                }
            }
            Console.WriteLine("the mail id is " + isValid + " " +email);
        }
        public void ValidateName(string nameInput)
        {
            //validation for Name
            bool isValid = true;
            if (string.IsNullOrEmpty(nameInput))
                isValid = false;
            else
            {
                isValid = Regex.IsMatch(nameInput, @"^[a-zA-Z]+$");
                foreach (char c in nameInput)
                {
                    if (!Char.IsLetter(c))
                        isValid = false;
                }
            }
            Console.WriteLine("the name is "+isValid + " " + nameInput);
        }
        public void ValidateNumber(string phone)
        {
            //validation for Number
            bool isValid = true;

            foreach (char c in phone)
            {
                if (!Char.IsDigit(c))
                    isValid = false;
            }
            Console.WriteLine("the number is "+ isValid + " " + phone);
        }
    }
}
