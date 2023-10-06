using System;

namespace اعداد_آینه_ای_و_اول
{
    internal class Program
    {
        //اعداد اول
        static void Main(string[] args)
        {
            Console.Write("Enter the start Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the end Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            Console.WriteLine("the prime numbers between "+ num1+" & "+num2 +" are:");
            for (num = num1; num <= num2; num++)
            {
                bool isPrime = IsPrime(num);
                if (isPrime)
                    Console.WriteLine(num);
            }

            Console.ReadLine();
        }

            static bool IsPrime(int number)
            {
                if (number < 2)
                    return false;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;    
            }

        



    }
}
