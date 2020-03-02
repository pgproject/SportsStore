using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> _lineCollection = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            CartLine line = _lineCollection
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();
            if (line == null)
            {
                _lineCollection.Add(new CartLine { Product = product, Quanitty = quantity });
            }
            else line.Quanitty += quantity;
        }
        public void RemoveLine(Product product)
        {
            _lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);
        }
        public void Clear()
        {
            _lineCollection.Clear();
        }
        public IEnumerable<CartLine> Lines { get { return _lineCollection; } }
        public decimal ComputeTotalValue()
        {
            return _lineCollection.Sum(e => e.Product.Price * e.Quanitty);
        }


    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quanitty { get; set; }
    }
}
