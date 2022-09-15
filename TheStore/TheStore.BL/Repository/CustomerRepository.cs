using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheStore.BL.Modelos;

namespace TheStore.BL.Repository
{
    public class CustomerRepository
    {
        private List<Customer> CustomerData = new List<Customer>();
        private AddressRepository addressRepository = new AddressRepository();
        #region Metodos
        //Save
        public bool Save(Customer newCustomer)
        {
            if(newCustomer.Addresses.Count == 0)
            {
                throw new Exception("Address not found");
            }
            CustomerData.Insert(CustomerData.Count, newCustomer);
            foreach(var address in newCustomer.Addresses)
            {
                addressRepository.InsertAddress(address);
            }
            return true;
        }
        //Get All
        public List<Customer> GetAll()
        {
            foreach(var customer in CustomerData)
            {
                customer.Addresses = addressRepository.GetAddressesByCustomerId(customer.Id);
            }
            return CustomerData;
        }
        //Get By Id
        public Customer GetById(int id)
        {
            Customer customer = new Customer();
            customer = CustomerData.FirstOrDefault(x => x.Id == id);
            customer.Addresses = addressRepository.GetAddressesByCustomerId(id);

            return customer;
        }
        //Delete
        public bool Delete(int id)
        {
            Customer customer = GetById(id);
            if(customer != null)
            {
                CustomerData.Remove(customer);
                return true;
            }
            return false;
        }


        #endregion Metodos
    }
}
