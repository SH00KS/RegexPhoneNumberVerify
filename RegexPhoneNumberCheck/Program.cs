using System;
using System.Text.RegularExpressions;

namespace RegexPhoneNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var RegexPhoneNumberCheck = @"(((\+?44\s?\d{4}|[(]?0\d{4}[)]?)\s?\d{3}\s?\d{3})|((\+?44\s?\d{3}|[(]?0\d{3}[)]?)\s?\d{3}\s?\d{4})|((\+?44\s?\d{2}|[(]?0\d{2}[)]?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?";
            var phoneNumber = "";

            Console.WriteLine("Please enter a valid phone number.");
            phoneNumber = Console.ReadLine();
            var phoneNumberSimplified = phoneNumber.Replace(" ", "").Replace("-", "");
        
            Console.WriteLine("You have entered - " + phoneNumber);
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            if (Regex.Match(phoneNumberSimplified, RegexPhoneNumberCheck).Success && phoneNumberSimplified.Length < 20 && phoneNumberSimplified.Length > 8)
            {
                Console.WriteLine("You have entered a valid phone number.");
                Console.ReadLine();
            } else {

                if (phoneNumber.Length > 20) { 
                    Console.WriteLine("Oops, too many numbers!");
                } else
                {
                    Console.WriteLine("Sorry, you have entered an invalid phone number.");
                }
                Console.ReadLine();
            }
               
        }
    }
}
