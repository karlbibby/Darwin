using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;

namespace Darwin.DataAccess
{

    public class StatusDataAccess
    { 
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();
        public static IEnumerable<SpeciesStatu> GetAllStatus()
        {
            IEnumerable<SpeciesStatu> datagrid = from s in DataAccessLayer.SpeciesStatus
                                                   orderby s.StatusText
                                                   select s;
            return datagrid;
        }

        public static SpeciesStatu GetStatusById(int id)
        {
            IQueryable<SpeciesStatu> StatusQuery =
                               from p in DataAccessLayer.SpeciesStatus
                               where p.StatusId == id
                               select p;
            return StatusQuery.ToList()[0];
        }

        public static int SaveStatus(SpeciesStatu SpeciesStatus)
        {
            return DataAccessLayer.SaveChanges();
        }
        public static int AddNewStatus()
        {
            DataAccessLayer.SpeciesStatus.AddObject(new SpeciesStatu()
            {
                StatusId = DataAccessLayer.SpeciesStatus.NextId(f => f.StatusId),
            });

            int changes = DataAccessLayer.SaveChanges();
            return changes;
        }

        public static bool DeleteStatus(SpeciesStatu SelectedStatus)
        {
            try
            {
                DataAccessLayer.DeleteObject(SelectedStatus);
                DataAccessLayer.SaveChanges(System.Data.Objects.SaveOptions.None);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedStatus);
                return false;
            }
            DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedStatus);
            return true;
        }
    }

    

}
