namespace WebAPP.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantily { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }

    }
}