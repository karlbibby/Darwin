using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;

namespace Darwin.DataAccess
{

    public class KingdomDataAccess
    { 
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();
        public static IEnumerable<KingdomDataGrid> GetAllKingdoms()
        {
            IEnumerable<KingdomDataGrid> datagrid = from s in DataAccessLayer.Kingdoms
                    orderby s.KingdomName
                    select new KingdomDataGrid() {KingdomId = s.KingdomId, KingdomName = s.KingdomName }
                    ;
            return datagrid;
        }
        public static Kingdom GetKingdomById(int id)
        {
            IQueryable<Kingdom> kingdomQuery =
                               from p in DataAccessLayer.Kingdoms
                               where p.KingdomId == id
                               select p;
            return kingdomQuery.ToList()[0];
        }

        public static int SaveKingdom(Kingdom SelectedKingdom)
        {
            return DataAccessLayer.SaveChanges();
        }
        public static int AddNewKingdom()
        {
            DataAccessLayer.Kingdoms.AddObject(new Kingdom()
            {
                KingdomId = DataAccessLayer.Kingdoms.NextId(f => f.KingdomId),
                KingdomName = ""
            });

            int changes = DataAccessLayer.SaveChanges();
            return changes;
        }

        public static bool DeleteKingdom(Kingdom SelectedKingdom)
        {
            try
            {
                DataAccessLayer.DeleteObject(SelectedKingdom);
                DataAccessLayer.SaveChanges(System.Data.Objects.SaveOptions.None);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedKingdom);
                return false;
            }
            DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedKingdom);
            return true;
        }
    }

    
    public class KingdomDataGrid
    {
        public int KingdomId { get; set; }
        public string KingdomName { get; set; }
    }

}
