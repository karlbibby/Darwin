using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;

namespace Darwin.DataAccess
{

    public class PhylumDataAccess
    { 
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();
        public static IEnumerable<PhylumDataGrid> GetAllPhylums()
        {
            IEnumerable<PhylumDataGrid> datagrid = from s in DataAccessLayer.Phyla
                                                   orderby s.PhylumName
                                                   select new PhylumDataGrid() { PhylumId = s.PhylumId, PhylumName = s.PhylumName }
                    ;
            return datagrid;
        }

        public static IEnumerable<PhylumDataGrid> GetPhylumsByKingdom(int KingdomId)
        {
            IEnumerable<PhylumDataGrid> datagrid = from s in DataAccessLayer.Phyla
                                                   where s.KingdomId == KingdomId
                                                   orderby s.PhylumName
                                                   select new PhylumDataGrid() { PhylumId = s.PhylumId, PhylumName = s.PhylumName }
                    ;
            return datagrid;
        }

        public static Phylum GetPhylumById(int id)
        {
            IQueryable<Phylum> PhylumQuery =
                               from p in DataAccessLayer.Phyla
                               where p.PhylumId == id
                               select p;
            return PhylumQuery.ToList()[0];
        }

        public static int SavePhylum(Phylum SelectedPhylum)
        {
            return DataAccessLayer.SaveChanges();
        }
        public static int AddNewPhylum(int KingdomId)
        {
            DataAccessLayer.Phyla.AddObject(new Phylum()
            {
                PhylumId = DataAccessLayer.Phyla.NextId(f => f.PhylumId),
                KingdomId = KingdomId,
                PhylumName = ""
            });

            int changes = DataAccessLayer.SaveChanges();
            return changes;
        }

        public static bool DeletePhylum(Phylum SelectedPhylum)
        {
            try
            {
                DataAccessLayer.DeleteObject(SelectedPhylum);
                DataAccessLayer.SaveChanges(System.Data.Objects.SaveOptions.None);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedPhylum);
                return false;
            }
            DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedPhylum);
            return true;
        }
    }

    
    public class PhylumDataGrid
    {
        public int PhylumId { get; set; }
        public string PhylumName { get; set; }
    }

}
