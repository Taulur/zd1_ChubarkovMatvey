using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{ class Product
    {
        // создаем приватные поля

        private decimal price;
        private string name;

        // создаем свойство для поля name

        public string Name
        {
            // возращение значения

            get
            {
                return name;
            }

            // присвоение значения

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
                    name = "";
            }

        }

        // создаем свойство для поля price

        public decimal Price
        {
            // возращение значения
            get
            {
                return price;
            }
            // присвоение значения
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    price = -1;
                }
            }
        }

        // конструктор класса для заполнения полей
        public Product(string Name, decimal Price)
        {
            name = Name;
            price = Price;
        }
    }
}
