using System;

namespace ConsoleApp5
{
    class FactorialNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Please enter the number and we'll give you it's factorial. ");// A factorial is a number multiplied by every individual number that comes before it.
            int factorialNumb = int.Parse(Console.ReadLine());//Gets user number which is received as a string, and convert that into an int.
            int factorialStart = factorialNumb; //Copies factorialNumb's value (The user's chosen number) into a nother number, this is needed for the loop to work correctly.
            for (int i = factorialNumb - 1; i > 1; i--){//Starts at the user's number - 1
                factorialStart *= i; //Multiplies the total of the factorial by whichever iteration it's on and adds that total to the factorial.
             }
            Console.WriteLine("The factorial of your number is \n{0}",factorialStart);
        }
    }
}
