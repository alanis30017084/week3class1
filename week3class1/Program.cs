/*Name: Alanis Correa Kriener
  Purpose: 'if' and 'case' exercises*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3class1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task - Pin Number
            /*
            Console.WriteLine("Please enter a four digit PIN number.");
            int pin = int.Parse(Console.ReadLine());

            if (pin >= 1000 && pin <= 9999)
            {
                Console.WriteLine("Please re-enter your PIN.");
                int pin2 = int.Parse(Console.ReadLine());

                if (pin == pin2)
                    Console.WriteLine("Your PIN has been set!");
                else
                    Console.WriteLine("Error! Your PIN numbers did not match. Your PIN was not set.");
            }
            else
                Console.WriteLine("This PIN is not within the right parameters.");
            Console.ReadLine();
            */


            // Task - Palindrome
            /*
            Console.WriteLine("Think of a three letter palindrome.");

            Console.Write("Enter the first letter: ");
            string letter1 = Console.ReadLine();
            Console.Write("Enter the second letter: ");
            string letter2 = Console.ReadLine();
            Console.Write("Enter the third letter: ");
            string letter3 = Console.ReadLine();

            if(letter2 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u")
            {
                if(letter1 == letter3)
                {
                    Console.WriteLine("Well done, your word is a Palindrome!");
                }
                else
                {
                    Console.WriteLine("This word is NOT a Palindrome!");
                }
            }
            else
            {
                Console.WriteLine("This is not an actual word!");
            }
            Console.ReadLine();
            */


            // Task - Favorite Bird
            /*
            Console.WriteLine("Guess my favorite bird!\n");
            Console.WriteLine("Enter your guess from chicken, pigeon or parrot.");
            string bird = Console.ReadLine().ToLower();

            switch (bird)
            {
                case "chicken":
                case "pigeon":
                    Console.WriteLine("Your guess was incorrect.");
                    break;
                case "parrot":
                    Console.WriteLine("Your guess was correct!");
                    break;
                default:
                    Console.WriteLine("That input is invalid. Please try again.");
                    break;
            }
            Console.ReadLine();
            */


            // Task - Price of fruit
            /*
            Console.WriteLine("Please enter your fruit variety to check price per kilogram.\nCurrent varieties: apples, bananas, kiwifruit, oranges");
            string fruit = Console.ReadLine().ToLower();
            
            switch (fruit)
            {
                case "apples":
                    Console.WriteLine("Apples: 1.25");
                    break;
                case "bananas":
                    Console.WriteLine("Bananas: 3.15");
                    break;
                case "kiwifruit":
                    Console.WriteLine("Kiwifruit: 4.65");
                    break;
                case "oranges":
                    Console.WriteLine("Oranges: 2.75");
                    break;
                default:
                    Console.WriteLine("Unknown fruit type. Please try again.");
                    break;
            }
            Console.ReadLine();
            */


            // Task - Calculator
            Console.WriteLine("******Calculator******\nPlease enter two numbers and an operator. The program will preform the operation on the selected numbers.");
            Console.Write("Please enter your first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Please enter your operator +, -, * or /:");
            string operat = (Console.ReadLine());

            switch (operat)
            {
                case "+":
                    double num3;
                    num3 = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {num3}");
                    break;
                case "-":
                    double num4;
                    num4 = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {num4}");
                    break;
                case "*":
                    double num5;
                    num5 = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {num5}");
                    break;
                case "/":
                    double num6;
                    num6 = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {num6}");
                    break;
                default:
                    Console.WriteLine("Sorry, that input was invalid.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
