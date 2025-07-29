using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order()
        {
            _customer = new Customer();
            _products = new List<Product>();
        }

        public void SetCustomerName(string name)
        {
            _customer.SetCustomerName(name);
        }

        public void SetCustomerAddress(string street, string city, string state, string country)
        {
            Address address = new Address(street, city, state, country);
            _customer.SetAddress(address);
        }

        public void AddProduct(string name, string id, float price, int quantity)
        {
            Product product = new Product(name, id, price, quantity);
            _products.Add(product);
        }

        public int GetShippingCost()
        {
            int shippingcost = 0;
            bool country = _customer.LiveInUs();
            if (country == true)
            {
                shippingcost = 5;
            }
            else
            {
                shippingcost = 35;
            }
            return shippingcost;
        }

        public float GetTotalPrice()
        {
            float totalPrice = 0;
            foreach (Product product in _products)
            {
                totalPrice += product.GetTotalCost();
            }
            return totalPrice + GetShippingCost();
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in _products)
            {
                string productName = product.GetProductName();
                string productId = product.GetProductId();
                packingLabel += $"{productId} - {productName}\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            string name = _customer.GetCustomerName();
            Address address = _customer.GetAddress();

            string shippingLabel = $"{name} \n{address.GetAddress()}";
            return shippingLabel;
        }
    }
}