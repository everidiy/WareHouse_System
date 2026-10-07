using System.Collections.Generic;
using Система_Управления_Складом.Classes;

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
            Warehouse warehouse = new Warehouse();
            WarehouseView view = new WarehouseView();
            WarehouseControls controls = new WarehouseControls(warehouse, view);

            controls.RunProgram();
        }
    }
}
