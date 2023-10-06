namespace Palindrome2
{
    internal class Program
    {
        //یافتن اعداد آینه ای با استفاده از String Reverse
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
            static bool IsPalindrome(int num)
        {
            string original = Convert.ToString(num);
            string reversed = Reverse(original);

             string Reverse(string text)
            {
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            return original==reversed;
        }
    }
}