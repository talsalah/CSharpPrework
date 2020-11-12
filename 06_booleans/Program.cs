using System;

namespace _06_booleans
{
    class Program
    {
        static void Main(string[] args)
        {
          double value = 101d / 2d;
            //1
            if (value == 50d)
            {
                //2
                Console.WriteLine(true);
                
            }
            else
            {
                Console.WriteLine(false);
            }
        

            //3
            Console.WriteLine("Since I'm not in the if block, I'll always display.");
        }
    }
}
