using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Customer
    {
        private string _customerName;
        private Address _customerAddress;

        public Customer()
        {
            _customerName = "Miguelito";
            _customerAddress = new Address();
        }

        public Customer(string name, Address address)
        {
            _customerName = name;
            _customerAddress = address;
        }

        public void SetCustomerName(string name)
        {
            _customerName = name;
        }

        public void SetAddress(Address address)
        {
            _customerAddress = address;
        }

        public Address GetAddress()
        {
            return _customerAddress;
        }

        public string GetCustomerName()
        {
            return _customerName;
        }

        public bool LiveInUs()
        {
            return _customerAddress.LiveInUs();
        }
    }
}