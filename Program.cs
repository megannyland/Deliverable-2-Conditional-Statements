using System;

namespace Deliverable_2_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for user input
            Console.WriteLine("What grade do you expect to get in ISM4300?");
            //try catch block will validate user input, if input is bad the catch will handle the error
            try
            {
                //This variable will gather user input
                string input = Console.ReadLine();
                /* This variable will be used to store sales after the input variable is parsed to interger"*/
                int grade = int.Parse(input);
                if ((grade > 97) && (grade<101))
                {
                    Console.WriteLine("You will have an A+!");
                }
                if ((grade > 91) && (grade < 98))
                {
                    Console.WriteLine("You will have an A!");
                }
                if ((grade > 89) && (grade < 92))
                {
                    Console.WriteLine("You will have an A-!");
                }
                if ((grade > 87) && (grade < 90))
                {
                    Console.WriteLine("You will have a B+!");
                }
                if ((grade > 81) && (grade < 88))
                {
                    Console.WriteLine("You will have a B!");
                }
                if ((grade > 79) && (grade < 82))
                {
                    Console.WriteLine("You will have a B-!");
                }
                if ((grade > 77) && (grade < 80))
                {
                    Console.WriteLine("You will have a C+!");
                }
                if ((grade > 71) && (grade < 78))
                {
                    Console.WriteLine("You will have a C!");
                }
                if ((grade > 69) && (grade < 72))
                {
                    Console.WriteLine("You will have a C-!");
                }
                if ((grade > 67) && (grade < 70))
                {
                    Console.WriteLine("You will have a D+!");
                }
                if ((grade > 61) && (grade < 68))
                {
                    Console.WriteLine("You will have a D!");
                }
                if ((grade > 59) && (grade < 62))
                {
                    Console.WriteLine("You will have a D-!");
                }
                if ((grade > 0) && (grade < 60))
                {
                    Console.WriteLine("You will have an F!");
                }
            }
            catch
            {
                Console.WriteLine("Please type the 1-100 integer value of your expected grade.");
            }
        }
    }
}
