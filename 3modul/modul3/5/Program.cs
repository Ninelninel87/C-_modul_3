using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Игра Угадай число!");

            
            Random rand = new Random();
           
            int count = 0;
            


            Console.WriteLine("Введите максимальное значение");
            int maxNumber = int.Parse(Console.ReadLine());

            int iiNumber = rand.Next(1,maxNumber+1);


            do
            {
                Console.WriteLine("Введите число: ");
                count++;

                string userNumber = Console.ReadLine();

                if (string.IsNullOrEmpty(userNumber))
                {
                    Console.WriteLine($"Было загадано число {iiNumber}");
                    break;
                }
                if (Convert.ToInt32(userNumber) < iiNumber)
                {
                    Console.WriteLine("Веденное число меньше загаданного.Попробуйте еще раз. ");
                }
                else if (Convert.ToInt32(userNumber) > iiNumber)
                {
                    Console.WriteLine("Веденное число больше загаданного.Попробуйте еще раз. ");
                }
                else
                {
                    Console.WriteLine($"Поздравляем!Число угадано за {count} попыток");
                    Console.ReadKey();
                    break;
                }
            }
            while (true);
            
           
        }
    }
}
