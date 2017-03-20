﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP.Models
{
    public class Repository : IRepository
    {
        private WebAPPContext db;

        public Repository(WebAPPContext db)
        {
            this.db = db;
        }

        public IQueryable<Order> GettAllOrders()
        {
            return db.Orders;
        }

        public IQueryable<Order> GetAllOrdersWithDetails()
        {
            return db.Orders.Include("OrderDetails");
        }

        public Order GetOrder(int id)
        {
            return db.Orders.Include("OrderDetails.Book").
                FirstOrDefault(o => o.Id == id);
        }

    }
}