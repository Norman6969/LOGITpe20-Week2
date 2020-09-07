
using Microsoft.VisualBasic;
using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crate an app
             * 1. App asks the user's name and greets the user by it's name;
             * 2. App asks the user's age and calculates
             * what year the user was born;
             * 3. App displays the result to the user
              
             */
            Console.WriteLine("what is your name?");
            String Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello!" + Name);
            Console.WriteLine("How old are you ?");
            String UserInput;
            UserInput = Console.ReadLine();
            int Age;
            Age = Int32.Parse(UserInput);
            int Year = 2020 - Age;
            Console.WriteLine("You were born in " + Year + ".");

            

        }
    }
}
