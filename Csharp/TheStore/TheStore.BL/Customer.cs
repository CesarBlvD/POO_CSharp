using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        #region Metodos
        //Save
        public bool Save(Customer newCustomer)
        {

            return true;
        }
        //Get All
        public List<Customer> GetAll()
        {

            return new List<Customer>();
        }
        //Get By Id
        public Customer GetById(int id)
        {
            return new Customer();
        }
        //Delete
        public bool Delete(int id)
        {
            return true;
        }


        #endregion Metodos

    }
}
