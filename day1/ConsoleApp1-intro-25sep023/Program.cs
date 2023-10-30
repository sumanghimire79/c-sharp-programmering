using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_intro_25sep023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //exercise1
            //1a
            //Assign a message to a variable and then print that message.
            string message = "this is a message";
            Console.WriteLine(message);
            Console.WriteLine(Environment.NewLine);

            //1b
            //Assign a message to a variable, and print that message.
            //Then change the value of the variable to a new message, and print the new message.
            string anotherMessage = "this is an another message";
            Console.WriteLine(anotherMessage);
            anotherMessage = "this is my an another new message";
            Console.WriteLine(anotherMessage);
            Console.WriteLine(Environment.NewLine);

            //exercise2
            //2a
            //Use a variable to represent a person's name, and print a message to that person. 
            //Your message should just be something simple, such as "Greetings name, are you ready for an adventure?"
            string name = "Suman";
            Console.WriteLine($"Greetings {name}, are you ready for an adventure?");
            Console.WriteLine(Environment.NewLine);

            //2b
            //Use a variable to represent a person's name, and then print that person's name in
            //lowercase and uppercase
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(Environment.NewLine);

            //2c
            //Find a cool quote you like. Print the quote and the name of its author.
            //The output has to include quotation marks!
            String quote = "Beauty lies in the eyes of the beholder";
            string author = "Shakespeare";
            Console.WriteLine($"{quote} \" {author} \" ");
            Console.WriteLine(Environment.NewLine);

            //2d
            //Repeat 2 - c, but this time represent the famous person's name using a variable called famous_person.
            //Then compose your message, and represent it with a new variable called message. Print your message!
            string famous_person = "Karl Marks";
            quote = "All hitherto existing societies are the socities of class struggle";
            Console.WriteLine($"{quote}:\"{famous_person}\"");
            Console.WriteLine(Environment.NewLine);

            //2e
            //Use a variable to represent a person's name, but include some whitespace in the beginning and the end of the name.
            //Print the name once with the whitespace, then three more times stripping the left, right, and total whitespace.
            Console.Write("Tim examples:");
            string famous_name = " Chanda ";
            Console.WriteLine(famous_name);
            Console.WriteLine(famous_name.TrimStart());
            Console.WriteLine(famous_name.TrimEnd());
            Console.WriteLine(famous_name.Trim());
            Console.WriteLine(Environment.NewLine);

            //exercise3
            //3a
            //Write addition, subtraction, multiplication, and division that each result in the number 26.
            //Print four lines to show the results.
            Console.Write("Same result for all operations: -->");
            int p= 2;
            Console.WriteLine(p+24);
            Console.WriteLine(p *13);
            Console.WriteLine(28-p);
            Console.WriteLine(52/p);
            Console.WriteLine(Environment.NewLine);

            //3b
            //Use a variable to represent your favourite number.
            //Then, using that variable, create a message that reveals your favourite number - print it!
            int favourite_number = 7;
            Console.Write("please enter your favourite number -->");
            string number = Console.ReadLine();
          
            Console.WriteLine($"you have entered : {number}");
            if (favourite_number == int.Parse(number))
            {
                Console.WriteLine($" correct ! {number} is your favourite number");
            }
            else { Console.WriteLine($" Try again ! {number} is not your favourite number"); }
            Console.WriteLine(Environment.NewLine);

            //3c
            //One kilometer is approximately 0.62 miles.
            //Use a variable to represent your daily travel distance in kilometers.
            //Write code to print your daily travel distance in miles.
            Console.Write("please enter your daily walk kilometer -->");
            string dailyDistanceKM = Console.ReadLine();
            double distanceMiles = 18.55;
            Console.WriteLine($"I travel around {dailyDistanceKM} km every day whic is equals to {distanceMiles * 0.62} miles");
            
            Console.ReadLine();
        }
    }
}
