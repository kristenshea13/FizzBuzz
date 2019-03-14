using System;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //print number starting from 1 to 100. When a number is multiple of three,
            //print “Fizz” instead of a number on the console and if multiple of five then
            //print “Buzz” on the console. For numbers which are multiple of three as well
            //five, print “FizzBuzz” on the console.

            //use integers 1 to 100, increase by 1 every time
            for (int i = 1; i <= 100; i++)
            {
                //if i is divisible by 3 and divisible of 5 print FizzBuzz to console
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"FizzBuzz");
                }
                //if i is divisible by 3 only, print Fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"Fizz");
                }
                //if i is divisible by 5 only, print Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"Buzz");
                }

                //else statement is the catch all for all other integers that are not divisible by 3 or 5
                //to just print the number to the console
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }




}