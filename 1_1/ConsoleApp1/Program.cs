using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите имя кота");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите вес кота");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    // создаем объект класса, занося в поля класса значения через конструктор
                    Cat cat = new Cat(name, weight);
                    // вызываем функцию класса  
                    cat.Meow();
                }
                catch(FormatException)
                {
                    Console.WriteLine("Данные введены неверно, попробуйте еще раз");
                }
            }

          

        }
    }
}
