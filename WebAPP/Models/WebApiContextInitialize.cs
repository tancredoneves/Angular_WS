using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPP.Models
{
    public class WebApiContextInitialize:DropCreateDatabaseAlways<WebAPPContext>
    {
        /// <summary>
        /// reescrever o metodo Seed
        /// criar dados na primeira vez que é inicializado o banco
        /// adiciona uma lista livro, uma orden e uma lista de Detalhes
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(WebAPPContext context)
        {
                
            var books = new List<Book>
            {
                new Book() { Nome="aaaaaa", Author="nomeAuthor", Price=99.90m},
                new Book() { Nome="bbbbbb", Author="nomeAuthor", Price=99.90m},
                new Book() { Nome="cccccc", Author="nomeAuthor", Price=99.90m},
                new Book() { Nome="dddddd", Author="nomeAuthor", Price=99.90m},
                new Book() { Nome="eeeeee", Author="nomeAuthor", Price=99.90m}
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var order = new Order() { Curtomer = "Tancredo", OrderDate = new DateTime(2014, 7, 10)};
            var details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[0], Quantily = 1, Order = order},
                new OrderDetail() {Book = books[1], Quantily = 2, Order = order},
                new OrderDetail() {Book = books[1], Quantily = 3, Order = order}
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();
            order = new Order() { Curtomer = "Fernando", OrderDate = new DateTime(2014, 9, 18) };
            details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[1], Quantily = 1, Order = order},
                new OrderDetail() {Book = books[1], Quantily = 1, Order = order},
                new OrderDetail() {Book = books[3], Quantily = 12, Order = order},
                new OrderDetail() {Book = books[4], Quantily = 3, Order = order}     
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();
            order = new Order() { Curtomer = "Araujo", OrderDate = new DateTime(2014, 12, 25) };
            details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[2], Quantily = 1, Order = order},
                new OrderDetail() {Book = books[4], Quantily = 1, Order = order},
                new OrderDetail() {Book = books[3], Quantily = 1, Order = order},
                new OrderDetail() {Book = books[1], Quantily = 3, Order = order}
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}