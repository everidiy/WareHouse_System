using System;

namespace Система_Управления_Складом
{
    /// <summary>
    /// Представляет класс для отображения меню и сообщений системы управления складом.
    /// </summary>
    public class WarehouseView
    {
        /// <summary>
        /// Отображает главное меню системы управления складом.
        /// </summary>
        public void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ\n");
            Console.WriteLine("Выберите нужный вам пункт: ");
            Console.WriteLine("1) Просмотреть товары на складе ");
            Console.WriteLine("2) Поставка товара ");
            Console.WriteLine("3) Отгрузка товара ");
            Console.WriteLine("\n0) Выход из системы \n");
        }

        /// <summary>
        /// Отображает меню выбора типа поставляемого товара.
        /// </summary>
        public void ShowSupplyMenu()
        {
            Console.Clear();

            Console.WriteLine("СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ\n");
            Console.WriteLine("Выберите нужную вам поставку:");
            Console.WriteLine("1) Ноутбуки");
            Console.WriteLine("2) Телефоны");
            Console.WriteLine("3) Наушники");
            Console.WriteLine("\n4) Назад\n");
        }

        /// <summary>
        /// Выводит сообщение и ожидает нажатия пользователем любой клавиши.
        /// </summary>
        public void TextMessage()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
