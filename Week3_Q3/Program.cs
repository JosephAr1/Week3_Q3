using System;

namespace Week3_Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[] { 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine();
            Console.WriteLine("Arrays in Proper order Order:");
            
            foreach (int item in num)
            {             
                Console.Write(item);            
            }
            {
                Console.WriteLine();
                Console.WriteLine("Arrays in Reverse Order:");
                
            }           
            Array.Reverse(num);
            foreach(int value in num)
            {
                Console.Write(value);
            }
                
        }
    }
}
