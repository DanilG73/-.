using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp444
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи");
            int p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                    {
                        Console.Write("Введите значение X");
                        double x = double.Parse(Console.ReadLine());
                      
                        if (x>=4 && x <= 6)
                        {
                            Console.WriteLine($"y={x}");
                           
                        }
                        else if(x>6)
                        {
                            Console.WriteLine($" y={3 * x + 4 * Math.Pow(x, 2)}");
                            
                        }

                    }

                    break;
                
                     case 2:
                    {
                        Console.WriteLine("введиет 4-значное число- ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int a = (x / 1000);
                        int b = (x % 1000 / 100);
                        int c = (x % 100 / 10);
                        int d = (x % 10);

                        if (a > b)
                        {
                            Console.WriteLine($"Первая цифра больше второй {a > b}");

                        }
                        else
                        {
                            Console.WriteLine($"Вторая цифра больше первой {b > a}");
                        }

                        Console.ReadKey();
                    }

                    break;

                case 3:
                    {
                        int count = 20;
                        Console.Write("введите\n x=");
                        for (int i = 0; i < 0)
                        {
                         
                                
                        }
   


                    }

                    break;




            }
            Console.ReadKey();

        
        }
    }
}
