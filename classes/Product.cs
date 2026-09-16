using System;

namespace Система_Управления_Складом
{
    abstract class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"| Товар: {Name} | Вид: {Type} | Цена: {Price} руб. | В наличии: {Quantity} шт. | Сумма: {Price * Quantity} руб. |");
        }
    }
}
