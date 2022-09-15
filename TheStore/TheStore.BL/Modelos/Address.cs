using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Modelos
{
    public class Address
    {
        public int Id { get; set; }
        public string Linea1 { get; set; }
        public string Linea2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}
