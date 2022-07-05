﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Address
    {
        public Address(string name, string surname, string street, string city, string province, int zIP)
        {
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Province = province;
            ZIP = zIP;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public int ZIP { get; set; }

    }
}
