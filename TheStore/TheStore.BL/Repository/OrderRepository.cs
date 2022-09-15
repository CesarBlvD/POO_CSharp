using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheStore.BL.Modelos;

namespace TheStore.BL.Repository
{
    public class OrderRepository
    {

        private List<Order> Orders = new List<Order>();
        private ProductRepository productRepository = new ProductRepository();
        private List<OrderDetail> orderItems = new List<OrderDetail>();
        #region Metodos

        public bool Save(Order newOrder)
        {
            Orders.Add(newOrder);
            foreach(var orderDetails in newOrder.OrderItems)
            {
                orderItems.Add(orderDetails);
            }
            return true;
        }
        public List<Order> GetAll()
        {
            foreach(var order in Orders)
            {
                order.OrderItems = GetOrderItemsById(order.Id);
            }
            return Orders;
        }
        public Order GetById(int id)
        {
            var order = Orders.FirstOrDefault(x => x.Id == id);
            order.OrderItems = GetOrderItemsById(order.Id);
            return order;
        }

        private List<OrderDetail> GetOrderItemsById(int id)
        {
            var orderDetails1 = new OrderDetail
            {
                Id = 1,
                Product = productRepository.GetById(1),
                PurchasePrice = 23.2m,
                Quantity = 2
            };
            var orderDetails2 = new OrderDetail
            {
                Id = 2,
                Product = productRepository.GetById(2),
                PurchasePrice = 105.2m,
                Quantity = 1
            };

            var orderDetailList = new List<OrderDetail>();
            orderDetailList.Add(orderDetails1);
            orderDetailList.Add(orderDetails2);
            return orderDetailList;
        }
        public bool Delete(int id)
        {
            var order = Orders.FirstOrDefault(x => x.Id == id);
            if(order!=null)
            {
                Orders.Remove(order);
                return true;
            }
            return false;
        }

        #endregion Metodos
    }
}
