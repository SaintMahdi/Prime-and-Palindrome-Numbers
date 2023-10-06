using System;

namespace Palindrome
{
    internal class Program
    {
        //یافتن اعداد آینه ای با استفاده از باقیمانده
        static void Main(string[] args)
        {
            Console.Write("Enter the start Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the end Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            Console.WriteLine("the palindrome numbers between " + num1 + " & " + num2 + " are:");
            for (num = num1; num <= num2; num++)
            {
                bool isPalindrome = IsPalindrome(num);
                if (isPalindrome)
                    Console.WriteLine(num);
            }
            Console.ReadKey();
        }
        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number = number / 10;
            }

            return originalNumber == reversedNumber;
        }
    }
    }  