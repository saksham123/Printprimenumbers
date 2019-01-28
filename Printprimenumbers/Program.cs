using System;

namespace Printprimenumbers
{
    class Program
    {
        public static void printPrimeNumbers()
        {
            {
                int x, y; // we have created two integers x,y.
                Console.WriteLine("Please enter a number to check if it is a prime number or not");//take input from the user
                x = Int32.Parse(Console.ReadLine()); //insert that value to variable x by using ReadLine() function

                for (y = 2; y < x; y++) //check wether x is greater than 2 
                {
                    if (x % y == 0) //check if x has any factors
                    {
                        Console.WriteLine("{0} is not a prime number", x);
                        break;
                    }
                }
            

                if (x == 1 || x<0)
                {
                    Console.WriteLine("{0} is not a prime number", x);//display output
                  
                }           
                if (y == x) //if x is 2
                {
                    Console.WriteLine("{0} is a prime number", x);
                }
            }
        }
       static void Main(string[] args)
            {
                try
                {
                    printPrimeNumbers();//call method "printprimeNumbers()"
            }
                catch (Exception)//if user enters alphabets or symbols 
            {
                Console.Write("Please enter only integers");//display
                }
                Console.ReadLine();//to hold output
            }
        } } 
    

     
