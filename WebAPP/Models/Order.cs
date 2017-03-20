using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP.Models
{
    public class Order
    {
        public int Id {get;set;}
        public string Curtomer {get;set;}
        public DateTime OrderDate {get;set;}
        public virtual ICollection<OrderDetail> OrderDetals { get; set; }

        public Order()
        {
           // OrderDetails = new List<OrderDetail>(); 
        }
    }
}