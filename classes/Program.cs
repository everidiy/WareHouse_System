using System;
using System.Collections.Generic;

namespace Система_Управления_Складом
{
    internal class Program
    {
        // Список всех товаров, находящихся на складе.
        static List<Product> warehouse = new List<Product>();

        /// <summary>
        /// Отображает главное меню системы управления складом
        /// и обрабатывает выбор пользователя.
        /// </summary>
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ\n");
                Console.WriteLine("Выберите нужный вам пункт: ");
                Console.WriteLine("1) Просмотреть товары на складе ");
                Console.WriteLine("2) Поставка товара ");
                Console.WriteLine("3) Отгрузка товара ");
                Console.WriteLine("\n0) Выход из системы \n");

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Console.Clear();
                        ShowAllProducts();
                        TextMessage();
                        break;
                    case "2":
                        Console.Clear();
                        AddProduct();
                        TextMessage();
                        break;
                    case "3":
                        Console.Clear();
                        RemoveProduct();
                        TextMessage();
                        break;
                    default:
                        Console.WriteLine("\nНеверно введено значение!");
                        TextMessage();
                        break;
                }
            }
        }

        /// <summary>
        /// Открывает меню поставки товаров и добавляет выбранный по номеру товар
        /// в список склада.
        /// </summary>
        public static void AddProduct()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ\n");
                Console.WriteLine("Выберите нужную вам поставку: ");
                Console.WriteLine("1) Ноутбуки ");
                Console.WriteLine("2) Телефоны ");
                Console.WriteLine("3) Наушники \n");
                Console.WriteLine("4) Назад \n");

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        warehouse.Add(new Laptop
                        {
                            Name = "ASUS TUF Gaming A19",
                            Type = "Ноутбук",
                            Price = 100000,
                            Quantity = 15,
                            ScreenSize = 17.9
                        });
                        Console.WriteLine($"\nПоставка ноутбуков была принята!");
                        TextMessage();
                        break;
                    case "2":
                        warehouse.Add(new Phone
                        {
                            Name = "IPhone 16 Pro",
                            Type = "Телефон",
                            Price = 165000,
                            Quantity = 9,
                            Memory = 256
                        });
                        Console.WriteLine($"\nПоставка телефонов была принята!");
                        TextMessage();
                        break;
                    case "3":
                        warehouse.Add(new Headphones
                        {
                            Name = "Huawei FreeBuds 5i",
                            Type = "Наушники",
                            Price = 4000,
                            Quantity = 21,
                            ConnectionType = "BlueTooth"
                        });
                        Console.WriteLine($"\nПоставка наушников была принята!");
                        TextMessage();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nНеверно введено значение!");
                        TextMessage();
                        break;
                }
            }
        }

        /// <summary>
        /// Открывает список товаров на складе и позволяет пользователю
        /// выбрать товар для его отгрузки, удалив из списка.
        /// </summary>
        public static void RemoveProduct()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ\n");
                Console.WriteLine("Выберите нужную вам отгрузку: \n");

                for (int i = 0; i < warehouse.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {warehouse[i].Name}");
                }
                Console.WriteLine("0) Назад \n");

                Console.Write("Введите номер товара: ");

                int index = Convert.ToInt32(Console.ReadLine());
                if (index == 0)
                {
                    exit = true;
                    return;
                } 
                else
                {
                    index -= 1;
                }

                if (index >= 0 && index < warehouse.Count) {
                    Console.WriteLine($"\nТовар {warehouse[index].Name} отгружен успешно!");
                    warehouse.RemoveAt(index);
                    TextMessage();
                    continue;
                }
                else
                {
                    Console.WriteLine("Такого товара нет на складе!");
                    TextMessage();
                    continue;
                }
            }
        }

        /// <summary>
        /// Выводит информацию обо всех товарах, находящихся на складе.
        /// Если склад пуст, сообщает об отсутствии товаров.
        /// </summary>
        public static void ShowAllProducts()
        {
            Console.WriteLine("СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ\n");

            if (warehouse.Count == 0) 
            {
                Console.WriteLine("Склад пуст!");
            } 
            else
            {
                Console.WriteLine("На складе имеется:");

                foreach (Product product in warehouse)
                {
                    product.ShowInfo();
                }
            }
        }

        /// <summary>
        /// Приостанавливает выполнение программы и ожидает,
        /// пока пользователь нажмёт любую клавишу.
        /// </summary>
        public static void TextMessage()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
