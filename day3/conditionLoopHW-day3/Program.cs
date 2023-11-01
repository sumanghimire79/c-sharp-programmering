using System.Diagnostics;
using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace conditionLoopHW_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create region => Ctrl + K + S
            // Enable / disable region => Ctrl + M + M

            #region Exercise 1
            //Use a for loop to print each odd number from 1 to 20.
            for (int i = 1; i <= 20; i+=2)
            {
                //if (i % 2 != 0)
                //{
                //    Console.WriteLine(i);
                //}

                Console.WriteLine(i);
            }
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region Exercise 2
            /* Write code that accepts an input until the user guesses a magic word.
                Give them a reasonable amount of guesses until the loop ends by itself.
                Print a message and break the loop when their guess is correct.
             */

            // -------------------- Exercise 2 --------------------
            Console.Write("Guess my magic word: ");
            string magicWord = Console.ReadLine();
            for (int guesses = 0; guesses <= 3; guesses++)
            {
                if (magicWord == "friend")
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    Console.Write("Try again: ");
                    magicWord = Console.ReadLine();
                }
            }

            //or
            int numberOfTries = 3;
            string magicWord2 = "friend";
            string textInput = string.Empty;

            do
            {
                Console.WriteLine($" you have {numberOfTries} tries left.");
                Console.WriteLine("Input the magic word");
                textInput = Console.ReadLine();

                numberOfTries--;
            }
            while (numberOfTries > 0 && magicWord2 != textInput);

            if (magicWord2 == textInput)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("sorry. No more tries left");
            }

            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 3

            /* A movie theater charges different ticket prices depending on a peron's age.
            If a person is under the age of 3, the ticket is free; if they are between 3 and 12, the ticket is 10;
            and if they are over age 12, the ticket is 15.Write code in which you ask the users for an age, and then
            tell them the cost of a movie ticket.*/
            int age = 0;
            int tries = 3;
            do
            {
                Console.WriteLine(" please enter you age =>");
                 age = int.Parse(Console.ReadLine());

                if (age < 3)
                {
                    Console.WriteLine("free ticket");
                }
                else if (age <= 12)
                {
                    Console.WriteLine(" the ticket costs $10 ");
                }
                else
                {
                    Console.WriteLine(" The ticket costs $15");
                }
                tries--;
            } while (tries > 0);

            //switch (age)
            //{
            //    case < 3:
            //        Console.WriteLine("free");
            //        break;
            //    case <= 12:
            //        Console.WriteLine("10$");
            //        break;
            //    case > 12:
            //        Console.WriteLine("15$");
            //        break;
            //    default: Console.WriteLine("not allowed");
            //}
            #endregion
            Console.WriteLine(Environment.NewLine);
            #region Exerise 4
         

          
            //a.
            //Write a loop that prompts the user to enter a series of pizza toppings until they break the loop.
            //As they enter each topping, print a message saying you'll add that topping to their pizza.
            Console.WriteLine("Pizza (a)");
            string topping = string.Empty;
            Console.WriteLine("Add topping to pizza. Type 'done' when done");
            do
            {
                Console.WriteLine("Which topping ?");
                topping = Console.ReadLine();

                if (topping != "done")
                {
                    Console.WriteLine($"Thank you. Will add {topping} to pizza.");
                    Console.WriteLine(Environment.NewLine);
                }
            } while (topping != "done");
            Console.WriteLine(Environment.NewLine);

            //b.
            //Modify your pizza program to include a list of the toppings the user enters.
            //When the loop breaks, print a message confirming their order has been saved, along with a list of their desired toppings.
            Console.WriteLine("Pizza (b)");
            string toppingB = string.Empty;
            List<string> toppingsList = new List<string>();
            Console.WriteLine("Add topping to pizza. Type 'done' when done");
            do
            {
                Console.WriteLine("Which topping (b) ?");
                toppingB = Console.ReadLine();

                if (toppingB != "done")
                {
                    Console.WriteLine($"Thank you. Will add {toppingB} to pizza.");
                    toppingsList.Add(toppingB);
                    Console.WriteLine(Environment.NewLine);
                }
            } while (toppingB != "done");
            Console.WriteLine("Thank you for your pizza (b) order.");
            Console.WriteLine("You have chosen the following toppings:");
            foreach (string pizzatopping in toppingsList)
            {
                Console.WriteLine($"* {pizzatopping}");
            }
            Console.WriteLine(Environment.NewLine);


            //c.
            //Before adding a topping to the list of desired toppings, check whether the topping is already added.
            //Tell the user that that topping already exists in their order.
            Console.WriteLine("Pizza (c)");
            string toppingC = string.Empty;
            List<string> toppingsListC = new List<string>();
            Console.WriteLine("Add topping to pizza. Type 'done' when done");
            do
            {
                Console.WriteLine("Which topping (c) ?");
                toppingC = Console.ReadLine()!;

                if (toppingC != "done")
                {
                    if (toppingsListC.Contains(toppingC))
                    {
                        Console.WriteLine($"Toppings list already contains: {toppingC}");
                    }
                    else
                    {
                        Console.WriteLine($"Thank you. Will add {toppingC} to pizza.");
                        toppingsListC.Add(toppingC);
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            } while (toppingC != "done");

            Console.WriteLine("Thank you for your pizza (c) order.");
            Console.WriteLine("You have chosen the following toppings:");
            foreach (string pizzatopping in toppingsListC)
            {
                Console.WriteLine($"* {pizzatopping}");
            }
            Console.WriteLine(Environment.NewLine);
            #endregion
         
            Console.ReadKey();
        




    }
    }
}