using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Shop

        // создаем приватное поле и словарь
    {
        private Dictionary<Product, int> products;
        private double profit = 0;

        // создаем свойство для поля profit

        public double Profit
        {
            get { return profit; }
            set { profit = value; }
        }
            

        // создаем конструктор для иницилизации словаря

        public Shop()
        {
            products = new Dictionary<Product, int>();
        }

        // функция для добавлении продукта в словарь

        public void AddProduct(Product product, int count)
        {
            products.Add(product, count);
        }

        // функция для удаления продукта в словаре

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }


        // функция для создания объекта класса Product

        public void CreateProduct(string name, decimal price, int count)
        {
            Product product = FindByName(name);


            if (!(product == null))
            {
                products[product] += count;
            }
            else
            {
                product = new Product(name, price);
                if ((product.Name != "") && (product.Price != -1))
                {
                    products.Add(product, count);
                }
                else
                {
                    MessageBox.Show("Данные введены неверно");
                }
              
            }
        }

        // функция для продажи

        public void Sell(Product product,int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] - count < 0)
                {
                    MessageBox.Show("Введенное количество для продажи неверно");
                }
                else if (products[product] - count == 0)
                {
                    products.Remove(product);
                }
                else
                {
                    products[product] -= count;
                }
            }
            else
            {
                Console.WriteLine("Товар не найден");
            }
        }

        // функция для поиска объекта в словаре

        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        // функция для обновления таблицы

        public void GridRefresh(DataGridView datagridview)
        {
            datagridview.Rows.Clear();
            foreach ((Product product,int count) in products)
            {
                datagridview.Rows.Add(product.Name, product.Price, count);

            }
        }
    }
}
