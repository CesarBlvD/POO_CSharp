using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        #region Metodos

        public bool Save(OrderDetail newOrder)
        {
            return true;
        }
        public List<OrderDetail> GetAll()
        {
            return new List<OrderDetail>();
        }
        public bool Delete(int id)
        {
            return true;
        }


        #endregion Metodos
    }
}
