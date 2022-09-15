using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Modelos
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }


    }
}
