using System;
using System.Text.RegularExpressions;

namespace Lab_7___Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for joining the Validating Program!");

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                //promting the user for their name, email, and phone number
                string userResponse = GetUserInput("Please enter your full name: Enter in this format please: First and Last");
                IsValidName(userResponse);

                Console.ForegroundColor = ConsoleColor.Red;
                userResponse = GetUserInput("What is your email? ");
                IsValidEmailAddress(userResponse);

                Console.ForegroundColor = ConsoleColor.Green;
                userResponse = GetUserInput("What is phone number? Please enter it in this format: xxx-xxx-xxxx ");
                IsValidPhoneNumber(userResponse);

            }
            while (Continue());
            Console.WriteLine("Thanks for playing!");
        }

        //Create a method where you check if their name is valid
        public static void IsValidName(string name)
        {
            bool validName = (Regex.IsMatch(name, @"(([A-Z])([a-z]+) ([A-Z])([a-z]+)){1,30}")); //must be alphabet letters

            if (validName == true)
            {
                Console.WriteLine("Great, that is a valid phone number!");
            }
            else
            {
                Console.WriteLine("Invalid! Please enter your name again.");
            }
        }
        //Create another method to see if their email is valid
        public static void IsValidEmailAddress(string emailAddress)
        {
            bool validEmail = (Regex.IsMatch(emailAddress, @"^\b[A-Z0-9.]{5,30}@[[A-Z0-9]{5,10}[A-Z]{2,3}\b)"));
            if (validEmail == true)
            {
                Console.WriteLine($"Awesome, that is a valid email address.");

            }
            else
            {
                Console.WriteLine("Invalid input, please check to see if the format of the email is correct.");
            }
        }
        //Create a last method to check if their phone number is valid
        public static void IsValidPhoneNumber(string phoneNumber)
        {
            bool validPhone = (Regex.IsMatch(phoneNumber, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")); //set it to a bool so I can ask t/f if this is valid

            if (validPhone == true)
            {
                Console.WriteLine("Awesome! Thanks for entering a valid phone number");
            }
            else
            {
                Console.WriteLine("Invalid, please try again. Please enter in this format please xxx-xxx-xxxx:");
            }
        }
        public static string GetUserInput(string message) //can use this to get any input, number, date, etc...
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to try again? Enter y/n: ");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "y" || userResponse == "yes")
            {
                return true;
            }
            else if (userResponse == "n" || userResponse == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Entry, please enter either y or n");
                return Continue();
            }

        }
    }
}

