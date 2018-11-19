using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    class Address
    {
        public Address(string streetAddress, string city, string state, string zip)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }
        public string StreetAddress;
        public string City;
        public string State;
        public string Zip;

        public override string ToString()
        {
            return $"{StreetAddress + City},{State + Zip}";
        }
    }
    class InternationalAddress : Address
    {
        public InternationalAddress(string streetAddress, string city, string state, string zip, string country) : base(streetAddress, city, state, zip)
        {
            Country = country;
        }
        public string Country;
        public override string ToString()
        {
            return base.ToString() + Country;
        }
    }
}
