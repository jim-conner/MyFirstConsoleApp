using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            //get data from a user
            Console.WriteLine("Please type in your name...");
            name = Console.ReadLine();
            //Console.ReadLine() --> if you just run app with that
            //app will just wait for user input and won't prompt user

            Console.WriteLine($"Hiya, {name}");
            //string interpolation in c# ^^

            Console.WriteLine("Hiya," + name);
            //string concatenation ^

            //string formatting
            Console.WriteLine(string.Format("Hiya, {0}, {1}, {2}", name));

            name = "Jimbo";
            //name = 7; this will not work bc static types

            //csharp has a lot of specificity about numbers
            //32 bit signed(can go + or -) numbers
            int favoriteNumber = 9;

            //64 bit signed numbers
            long realBigNumero = 9123151141141;

            //16 bit signed numbers
            short smolNumero = 32_000;

            //decimal types
            double accountBal = 0.57d;
            decimal accountBal2 = 0.57M;

            //var  is a shorthand for the real type
            //Type reference
            var myStuff = 5 * 5;
            //myStuff = ""; won't work

            bool isLearning = true;
            // becomes -> var isLearning = true;

            var today = new DateTime(2021, 7, 13);

            today = DateTime.Today;

            //arrays are not bueno in csharp
            //var students = new string[5];

            // --------lists are more common instead ------
            var students = new List<string>();
            //      read as      ^^ list of string

            students.Add("Hunter");
            students.Add("Rob");
            students.Add("Jimbo");

            students.Remove("Jimbo");

            //for loop in csharp
            for (var i=0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
            //we can do the same thing with foreach -- foreach more common
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            //CONTROL FLOW if/then, ternary (not technically supposed to control flow)
            //... switch, foreach, for, etc
            //if blocks in ccsharp same as js but no triple equality
            //csharp one equal = for set and two == for equality

            //if statement
            if (name == "Jim")
            {
                Console.WriteLine("Hey it's me!");
            }
            else
            {
                Console.WriteLine("Pas moi");
            }

            //ternary - idea is to change indv value not control flow
            //you're executing one line of code'
            var greeting = name == "Jim" ? "It's you." : "It's not you";

            //anonymous types
            var jimbo = new { Name = "Jimbo", IsTeacher = false };

            //doesn't work, anonymous types don't allow for modification (immutable)
            //jimbo.Name = "Steve";

            //objects break the rules sometimes bc of being a ref type
            object animalType = "Doggo";
            animalType = 45;
            animalType = new string[5];

            //boxing moves values to the heap
            //boxing is bad - be aware that it's possible to break our strict rules
        }
    }
}
