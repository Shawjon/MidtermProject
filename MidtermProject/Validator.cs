using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Validator
    {
        public static string ValidateChoice()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Return.ToLower() == "r" || Return.ToLower() == "p" || Return.ToLower() == "s" || Return.ToLower() == "rock" || Return.ToLower() == "paper" || Return.ToLower() == "scissors")
                {
                    return Return;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not valid, try again:");
                    Return = ValidateChoice();
                }

            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                Return = ValidateChoice();
            }
            return Return;

        }
        public static string ValidateDifficulty()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Return.ToLower() == "e" || Return.ToLower() == "r" || Return.ToLower() == "easy" || Return.ToLower() == "random")
                {
                    return Return;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not valid, try again:");
                    Return = ValidateDifficulty();
                }

            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                Return = ValidateDifficulty();
            }
            return Return;

        }
        public static double ValidateDouble()
        {
            double temp;
            if (!double.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("That is not a valid input, try again");
                ValidateDouble();
            }
            return temp;
        }
        public static int ValidateInt()
        {
            string test = Console.ReadLine();
            int temp;
            try
            {
                int Return = Int32.Parse(test);
                return Return;

            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                temp = ValidateInt();
            }
            return temp;

        }
        public static int ValidateScore()
        {
            string test = Console.ReadLine();
            int temp;
            try
            {
                int Return = Int32.Parse(test);
                if (Return <= 100 && Return >= 0)
                {
                    return Return;
                }
                else
                {
                    Console.Write("That is not between 0 and 100, please try again: ");
                    temp = ValidateScore();
                }


            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                temp = ValidateInt();
            }
            return temp;

        }

        public static decimal ValidateCash()
        {
            string test = Console.ReadLine();
            decimal temp;
            try
            {
                decimal Return = decimal.Parse(test);
                if (Return <1)
                {
                    Console.Write("Oops, there is no such thing as negative money. Please try again: ");
                    temp = ValidateCash();
                }
                return Return;
            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                temp = ValidateCash();
            }
            return temp;
        }

        public static string ValidateString()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Regex.IsMatch(Return, @"^[A-z]{0,29}$"))
                {
                    return Return;
                }
                else
                {
                    Console.Write("Sorry, that is not a valid entry, try again: ");
                    Return = ValidateString();
                }

            }
            catch (FormatException)
            {
                Console.Write("That is not valid entry, try again: ");
                Return = ValidateString();
            }
            return Return;

        }
        public static string ValidateCreditCardNumber()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Regex.IsMatch(Return, @"^(\d{4}[-. ]?){4}|\d{4}[-. ]?\d{6}[-. ]?\d{5}$"))
                {
                    string last4 = Return.Substring(Return.Length - 4);
                    Return = last4;
                    return Return;
                }
                else
                {
                    Console.Write("Sorry, that is not a valid entry, try again: ");
                    Return = ValidateCreditCardNumber(); 
                }
            }
            catch (FormatException)
            {
                Console.Write("That is not valid entry, try again: ");
                Return = ValidateCreditCardNumber();
            }
            return Return ;
        }
        public static string ValidateCVV()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Regex.IsMatch(Return, @"^\d\d\d$"))
                {
                    return Return;
                }
                else
                {
                    Console.Write("Sorry, that is not a valid entry, try again: ");
                    Return = ValidateCVV();
                }
            }
            catch (FormatException)
            {
                Console.Write("That is not valid entry, try again: ");
                Return = ValidateCVV();
            }
            return Return;
        }
        public static string ValidateRoutingAccountNumber()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Regex.IsMatch(Return, @"^\d\d\d\d\d\d\d\d\d$"))
                {
                    string last4 = Return.Substring(Return.Length - 4);
                    Return = last4;
                    return Return;
                    
                }
                else
                {
                    Console.Write("Sorry, that is not a valid entry, try again: ");
                    Return = ValidateRoutingAccountNumber();
                }
            }
            catch (FormatException)
            {
                Console.Write("That is not valid entry, try again: ");
                Return = ValidateRoutingAccountNumber();
            }
            return Return;
        }
        public static string ValidateExpiration()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Regex.IsMatch(Return, @"^(0[1-9]|1[0-2])[/\\ - .](\d\d)$"))
                {
                    return Return;
                }
                else
                {
                    Console.Write("Sorry, that is not a valid entry, try again: ");
                    Return = ValidateExpiration();
                }
            }
            catch (FormatException)
            {
                Console.Write("That is not valid entry, try again: ");
                Return = ValidateExpiration();
            }
            return Return;
        }
        public static string ValidateProgram()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Regex.IsMatch(Return, @"^[A-z,#,-,+]{0,29}$"))
                {
                    return Return;
                }
                else
                {
                    Console.Write("Sorry, that is not a valid entry, try again: ");
                    Return = ValidateProgram();
                }

            }
            catch (FormatException)
            {
                Console.Write("That is not valid entry, try again: ");
                Return = ValidateString();
            }
            return Return;

        }
    }
}

