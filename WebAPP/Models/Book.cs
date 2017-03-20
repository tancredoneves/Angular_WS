using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Nome {get;set;}
        public string Author {get;set;}
        public decimal Price { get; set; }
       
    }
}