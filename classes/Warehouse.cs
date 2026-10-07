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

        public bool RemoveProduct(int index)
        {
            if (index < 0 || index >= products.Count) return false;

            products.RemoveAt(index);
            return true;
        }
    }
}
