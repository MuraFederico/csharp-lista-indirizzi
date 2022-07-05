using System;
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
            Name = name.Trim();
            Surname = surname.Trim();
            Street = street.Trim();
            City = city.Trim();
            Province = province.Trim();
            ZIP = zIP;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public int ZIP { get; set; }

        public string ToString()
        {
            return $"------Address------\n" +
                    $"Name:\t\t{this.Name}\n" +
                    $"Surname:\t{this.Surname}\n" +
                    $"Street:\t\t{this.Street}\n" +
                    $"City:\t\t{this.City}\n" +
                    $"Province:\t{this.Province}\n" +
                    $"ZIP:\t\t{this.ZIP}\n" +
                    "-------------------\n";

        }

    }
}
