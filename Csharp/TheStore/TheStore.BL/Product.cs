using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        #region Metodos

        public bool Save(Product newProduct)
        {
            return true;
        }
        public List<Product> GetAll()
        {
            return new List<Product>();
        }
        public Product GetById(int id)
        {
            return new Product();
        }
        public bool Delete(int id)
        {
            return true;
        }

        #endregion Metodos
    }
}
