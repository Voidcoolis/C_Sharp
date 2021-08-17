using System;

namespace ASCIIValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My lord please write something : ");

            string str = Console.ReadLine();
         
            foreach (var value in str)
            {
                Console.WriteLine((int)value);
            }


            //Console.WriteLine("My lord please write something again: ");
            
            //Convert.ToChar(Console.ReadLine());
            
        }
    }
}
