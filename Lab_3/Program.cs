using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int userNum, newNum; // declaring varables 
            

            Console.WriteLine("Hello!! Please enter your name");// entering a name and storing it in Username
            string Username = Console.ReadLine();

            do
            {
                Console.WriteLine("Hello {0} Enter a integer between 1 and 100", Username);
                userNum = int.Parse(Console.ReadLine());

                newNum = userNum % 2; // mod function to make number odd or even

                if (newNum == 0) // if number is even the block off code bellow will run
                {

                    if (userNum <= 25 && userNum >= 2)
                    {
                        Console.WriteLine("{0}: Even and less than 25", Username);
                    }

                    else if (userNum > 26 && userNum < 60)
                    {

                        Console.WriteLine("{0}: Even", Username);
                    }

                    else if (userNum > 60)
                    {
                        Console.WriteLine("{0}: Even", Username);

                    }



                }

                else if (newNum == 1) // if number is odd the block off code bellow will run

                {
                    Console.WriteLine("{0}: Your Number is {1} and odd",Username, userNum);

                    if (userNum > 60)
                    {
                        Console.WriteLine("Odd");
                    }

                    
                }


                Console.WriteLine("\nWould you like to run the program agian y/n?"); //asking user to rerun code

            }

            while (Console.ReadLine() == "y"); // loop to restart and end program
                {
                Console.WriteLine("Goodbye");
                }

        }
    }
}
