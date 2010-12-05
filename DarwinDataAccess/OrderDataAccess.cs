using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;

namespace Darwin.DataAccess
{

    public class OrderDataAccess
    { 
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();

        public static IEnumerable<OrderDataGrid> GetAllOrders()
        {
            IEnumerable<OrderDataGrid> datagrid = from s in DataAccessLayer.Orders
                                                   orderby s.OrderName
                                                   select new OrderDataGrid() { OrderId = s.OrderId, OrderName = s.OrderName }
                    ;
            return datagrid;
        }

        public static IEnumerable<OrderDataGrid> GetOrdersByClass(int ClassId)
        {
            IEnumerable<OrderDataGrid> datagrid = from s in DataAccessLayer.Orders
                                                   where s.ClassId == ClassId
                                                   orderby s.OrderName
                                                   select new OrderDataGrid() { OrderId = s.OrderId, OrderName = s.OrderName }
                    ;
            return datagrid;
        }

        public static Order GetOrderById(int? id)
        {
            if (id != null)
            {
            IQueryable<Order> OrderQuery =
                               from p in DataAccessLayer.Orders
                               where p.OrderId == id
                               select p;

                return OrderQuery.ToList()[0];
            }
            else
            {
                Order o = new Order();
                o.OrderName = "";
                return o;
            }
        }

        public static int SaveOrder(Order SelectedOrder)
        {
            return DataAccessLayer.SaveChanges();
        }
        public static int AddNewOrder(int ClassId)
        {
            DataAccessLayer.Orders.AddObject(new Order()
            {
                OrderId = DataAccessLayer.Orders.NextId(f => f.OrderId),
                ClassId = ClassId,
                OrderName = ""
            });

            int changes = DataAccessLayer.SaveChanges();
            return changes;
        }

        public static bool DeleteOrder(Order SelectedOrder)
        {
            try
            {
                DataAccessLayer.DeleteObject(SelectedOrder);
                DataAccessLayer.SaveChanges(System.Data.Objects.SaveOptions.None);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedOrder);
                return false;
            }
            DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedOrder);
            return true;
        }

        public static IEnumerable<OrderDataGrid> GetUnusedOrder()
        {
            IEnumerable<OrderDataGrid> g = from x in DataAccessLayer.Orders
                                           where x.Species.Count() == 0
                                           orderby x.OrderName
                                           select new OrderDataGrid { OrderId = x.OrderId, OrderName = x.OrderName};
            return g;
        }
    }

    
    public class OrderDataGrid
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
    }

}
