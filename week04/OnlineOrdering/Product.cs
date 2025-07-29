using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Product
    {
        private string _productName;
        private string _productId;
        private float _price;
        private int _quantity;

        public Product(string name, string id, float price, int quantity)
        {
            _productName = name;
            _productId = id;
            _price = price;
            _quantity = quantity;
        }

        public float GetTotalCost()
        {
            return _price * _quantity;
        }

        public string GetProductName()
        {
            return _productName;
        }

        public string GetProductId()
        {
            return _productId;
        }
    }
}