using System;

namespace Application
{
    class MainClass
    {
         static void Main(string[] args)
        {

            ushort n = 1; 
            
             Console.WriteLine("Введите число: ");
             n= ushort.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine($"четное");
            else Console.WriteLine($"нечетное");

            


        }
    }
}
