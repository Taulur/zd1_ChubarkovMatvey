using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // класс котяра
     class Cat
    {
        // создаем поля приватные
        private string name;
        private double weight;

        // создаем свойство для веса
        public double Weight
        {
            // при вызове возращаем значения
            get
            {
                return weight;
            }
            // при изменении значения выполняем действие ниже
            set
            {
                if (value > 0) {
                    weight = value;
                }
                else
                {
                    Console.WriteLine($"{value} - такого веса быть не может!!!!");
                }
            }
        }

        // создаем свойство для имени
        public string Name
        {
            // при вызове возращаем значения
            get
            {
                return name;
            }
            // при изменении значения выполняем действие ниже
            set
            {
                bool OnlyLetters = true;

                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                    name = value;
                else
                    Console.WriteLine($"{value} - неправильное имя!!!");
            }
        }

        // конструктор для заполнения приватных полей класса
        public Cat(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        // функция которая выводит приватные поля
        public void Meow()
        {
            if (name == "" || weight == 0)
            {
                Console.WriteLine("У вас не получился кот(((");
            
            }
            else
            {
                Console.WriteLine($"{name}: МЯЯЯЯУ!!!");
                Console.WriteLine($"Вес мяукающего кота : {weight} ");
            }

            
        }

    }
}
