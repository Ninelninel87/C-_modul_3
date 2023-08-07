using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int userNumber;
            int i = 1;
            int minValue = int.MaxValue;
            do
            {
                Console.WriteLine($"Введите {i}-e число: ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                i++;
                if (userNumber<minValue)
                {
                    minValue = userNumber;
                }
            } while (i <= n);

            Console.WriteLine($"Минимальное число : {minValue} ");
        }
    }
}