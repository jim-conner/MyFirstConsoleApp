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
            //Console.ReadLine();
            //if you just run app with ^^ line 13
            //app will just wait for user input
            //and won't run line 18 to prompt user

            Console.WriteLine("Please type in your name...");
            name = Console.ReadLine();

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
            //if blocks in ccsharp same as js but no triple equality
            //csharp one equal for set and two for equality
        }
    }
}
