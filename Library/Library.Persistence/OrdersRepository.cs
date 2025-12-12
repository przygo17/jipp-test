using System.Collections.Generic;
using Library.Domain;

namespace Library.Persistence
{
    public class OrdersRepository
    {
        private List<Order> _database = new List<Order>();

        public void Insert(Order order)
        {
            _database.Add(order);
        }

        public List<Order> GetAll()
        {
            return _database;
        }
    }
}