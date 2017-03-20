using System.Linq;

namespace WebAPP.Models
{
    public interface IRepository
    {
        IQueryable<Order> GetAllOrdersWithDetails();
        Order GetOrder(int id);
        IQueryable<Order> GettAllOrders();
    }
}