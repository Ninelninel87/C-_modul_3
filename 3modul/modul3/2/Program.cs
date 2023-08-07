using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую!Введите количество карт: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int value;
            int sum =0;
            


            for (int i = 1; i <= a; i++)

            {
              Console.Write($"Введите номинал {i}й карты(для J,Q,K,T введите 10): ");
               
                value = int.Parse(Console.ReadLine());
              
                switch (value)
                {
                    case 2:
                        sum = sum + 2; break;
                    case 3:
                        sum = sum + 3; break;
                    case 4:
                        sum = sum + 4; break;
                    case 5:
                        sum = sum + 5; break;
                    case 6:
                        sum = sum + 6; break;
                    case 7:
                        sum = sum + 7; break;
                    case 8:
                        sum = sum + 8; break;
                    case 9:
                        sum = sum + 9; break;
                    case 10:
                        sum = sum + 10; break;
                    default:
                        sum = sum + 10; break;
                }


            }
            Console.WriteLine($"Сумма карт: {sum}");
        }
    }
}
