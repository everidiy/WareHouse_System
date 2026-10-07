using System;
using Система_Управления_Складом.Classes;

namespace Система_Управления_Складом
{
    public class WarehouseControls
    {
        private readonly Warehouse warehouse;
        private readonly WarehouseView warehouseView;

        public WarehouseControls(Warehouse warehouse, WarehouseView warehouseView)
        {
            this.warehouse = warehouse;
            this.warehouseView = warehouseView;
        }

        public void RunProgram()
        {
            bool exit = false;

            while (!exit)
            {
                warehouseView.ShowMenu();

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        Console.Clear();
                        ShowAllProducts();
                        warehouseView.TextMessage();
                        break;
                    case "2":
                        Console.Clear();
                        AddProduct();
                        warehouseView.TextMessage();
                        break;
                    case "3":
                        Console.Clear();
                        RemoveProduct();
                        warehouseView.TextMessage();
                        break;
                    default:
                        Console.WriteLine("\nНеверно введено значение!");
                        warehouseView.TextMessage();
                        break;
                }
            }
        }

        private void AddProduct()
        {
            bool exit = false;

            while (!exit)
            {
                warehouseView.ShowSupplyMenu();

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        warehouse.AddProduct(new Laptop
                        {
                            Name = "ASUS TUF Gaming A19",
                            Type = "Ноутбук",
                            Price = 100000,
                            Quantity = 15,
                            ScreenSize = 17.9
                        });
                        Console.WriteLine($"\nПоставка ноутбуков была принята!");
                        warehouseView.TextMessage();
                        break;
                    case "2":
                        warehouse.AddProduct(new Phone
                        {
                            Name = "IPhone 16 Pro",
                            Type = "Телефон",
                            Price = 165000,
                            Quantity = 9,
                            Memory = 256
                        });
                        Console.WriteLine($"\nПоставка телефонов была принята!");
                        warehouseView.TextMessage();
                        break;
                    case "3":
                        warehouse.AddProduct(new Headphones
                        {
                            Name = "Huawei FreeBuds 5i",
                            Type = "Наушники",
                            Price = 4000,
                            Quantity = 21,
                            ConnectionType = "BlueTooth"
                        });
                        Console.WriteLine($"\nПоставка наушников была принята!");
                        warehouseView.TextMessage();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nНеверно введено значение!");
                        warehouseView.TextMessage();
                        break;
                }
            }
        }

        private void RemoveProduct()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ\n");
                Console.WriteLine("Выберите нужную вам отгрузку: \n");

                if (warehouse.Products.Count == 0)
                {
                    Console.WriteLine("Склад пуст!");
                    return;
                }

                for (int i = 0; i < warehouse.Products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {warehouse.Products[i].Name}");
                }
                Console.WriteLine("\n0) Назад \n");

                Console.Write("Введите номер товара: ");

                if (!int.TryParse(Console.ReadLine(), out int index))
                {
                    Console.WriteLine("Введите число.");
                    continue;
                }

                if (index == 0)
                {
                    exit = true;
                    continue;
                }
                else
                {
                    index -= 1;
                }

                if (index >= 0 && index < warehouse.Products.Count)
                {
                    Console.WriteLine($"\nТовар {warehouse.Products[index].Name} отгружен успешно!");
                    warehouse.RemoveProduct(index);
                }
                else
                {
                    Console.WriteLine("Такого товара нет на складе!");
                }
                warehouseView.TextMessage();
            }
        }

        private void ShowAllProducts()
        {
            Console.Clear();

            Console.WriteLine("СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ\n");

            if (warehouse.Products.Count == 0)
            {
                Console.WriteLine("Склад пуст!");
            }
            else
            {
                Console.WriteLine("На складе имеется:\n");

                foreach (Product product in warehouse.Products)
                {
                    product.ShowInfo();
                }
            }
        }
    }
}
