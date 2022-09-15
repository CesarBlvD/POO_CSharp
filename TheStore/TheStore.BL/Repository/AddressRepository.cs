using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Modelos;

namespace TheStore.BL.Repository
{
    public class AddressRepository
    {
        private List<Address> Addresses = new List<Address>();

        public List<Address> GetAddressesByCustomerId(int customerId)
        {
            Addresses = new List<Address>
            {
                new Address
                {
                    Id= 1,
                    Linea1 = "Avenid del rio",
                    Linea2 = "porton rojo casa azul",
                    City = "Cancun",
                    State = "Yucatan",
                    Country = "Mexico",
                    PostalCode = "65544"
                },
                new Address
                {
                    Id= 2,
                    Linea1 = "Guamuchil",
                    Linea2 = "Cafe casa color rojo",
                    City = "Madrid",
                    State = "Caracas",
                    Country = "España",
                    PostalCode = "43827"
                }
            };
            return Addresses;
        }

        public bool InsertAddress(Address newAddress)
        {
            Addresses.Insert(Addresses.Count, newAddress);
            return true;
        }
    }
}
