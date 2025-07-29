using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        public Address()
        {
            _street = "Empty";
            _city = "Empty";
            _state = "Empty";
            _country = "Empty";
        }

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        public string GetAddress()
        {
            string fullAddress = $"{_street}, {_city}, {_state}, {_country}";
            return fullAddress;
        }

        public bool LiveInUs()
        {
            bool us;
            if (_country == "United States" || _country == "USA")
            {
                us = true;
            }
            else
            {
                us = false;
            }
            return us;
        }
    }
}