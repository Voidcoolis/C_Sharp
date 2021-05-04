using System;

namespace Palindrome
    // A Palindrome number is a no. that is the same aftere reverse.
    //Bsp : 121, 3434, 11, 48984 usw.
{
    public class SameNumbersInReverse
    {
        public static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("The Number is a Palindrome! ");
            else
                Console.WriteLine("The Number is not a Palindrome !");
        }
    }
}
