using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Modelos
{
    public class Order
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public int CustomerId { get; set; }
        public int ShipAddressId { get; set; }
        public List<OrderDetail> OrderItems { get; set; }



    }
}
