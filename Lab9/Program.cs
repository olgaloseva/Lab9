using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        //Метод моделирует работу простого калькулятора
        static void Main(string[] args)
        {
            double  rez = 0;
            int a = 0, b = 0, num = 0;

            Console.WriteLine("*********************");
            Console.WriteLine("К А Л Ь К У Л Я Т О Р");
            Console.WriteLine("*********************");
            Console.WriteLine();

            Console.Write("Введите первое целое число: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
           

            Console.Write("Введите второе целое число: ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }

            
            Console.Write("Выберите действие (1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление): ");
            num = Convert.ToInt32(Console.ReadLine());
            rez = 0;

            if (num == 1)
            {
                rez = a + b;
                Console.WriteLine("Результат: {0}", rez);
            }
            else if (num == 2)
                {
                    rez = a - b;
                    Console.WriteLine("Результат: {0}", rez);
                }
                else if (num == 3)
                {
                    rez = a * b;
                    Console.WriteLine("Результат: {0}", rez);
                }
                else if (num == 4)
                {
                    try
                    {
                        rez = a / b;  
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка! {0}", ex.Message);
                        Console.ReadKey();
                        return;
                    }
                rez = ((double)a) / b;
                Console.WriteLine("Результат: {0:f3}", rez);
                }
                else
                {
                    Console.WriteLine("Ошибка. Действия с таким номером не существует");
                }
        

            Console.ReadKey();
        }
    }
}
