using System.Collections.Generic;

namespace Система_Управления_Складом.Classes
{
    public class Warehouse
    {
        private readonly List<Product> products = new List<Product>();

        public IReadOnlyList<Product> Products => products;

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        /// <summary>
        /// Удаляет товар со склада по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс товара в списке.</param>
        /// <returns>
        /// <c>true</c>, если товар был успешно удалён;
        /// <c>false</c>, если указанный индекс находится за пределами списка.
        /// </returns>
        public bool RemoveProduct(int index)
        {
            if (index < 0 || index >= products.Count) return false;

            products.RemoveAt(index);
            return true;
        }
    }
}
