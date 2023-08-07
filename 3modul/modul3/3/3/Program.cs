using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i<=n-1)
            {
                n /= i;
                i++;
                if (n%i==0)
                {
                    Console.WriteLine($"Число {n} не является простым");
                }
                else
                {
                    Console.WriteLine($"Число {n} является простым");
                }
                break;
            }
            
                    }
                }
            }
        
