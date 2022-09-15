using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheStore.BL.Modelos;

namespace TheStore.BL.Repository
{
    public class ProductRepository
    {
        private List<Product> ProductsData = new List<Product>();
        #region Metodos

        public bool Save(Product newProduct)
        {
            ProductsData.Insert(ProductsData.Count, newProduct);
            return true;
        }
        public List<Product> GetAll()
        {

            return ProductsData;
        }
        public Product GetById(int id)
        {
            return ProductsData.FirstOrDefault(x => x.Id == id);
        }
        public bool Delete(int id)
        {
            var product = GetById(id);
            if(product != null)
            {
                ProductsData.Remove(product);
                return true;
            }
            return false;
        }

        #endregion Metodos
    }
}
