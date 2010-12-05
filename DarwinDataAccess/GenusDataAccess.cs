using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;

namespace Darwin.DataAccess
{

    public class GenusDataAccess
    { 
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();

        public static IEnumerable<GenusDataGrid> GetAllGenu()
        {
            IEnumerable<GenusDataGrid> datagrid = from s in DataAccessLayer.Genuss
                                                   orderby s.GenusName
                                                   select new GenusDataGrid() { GenusId = s.GenusId, GenusName = s.GenusName }
                    ;
            return datagrid;
        }

        public static IEnumerable<GenusDataGrid> GetGenusByFamily(int FamilyId)
        {
            IEnumerable<GenusDataGrid> datagrid = from s in DataAccessLayer.Genuss
                                                   where s.FamilyId == FamilyId
                                                   orderby s.GenusName
                                                   select new GenusDataGrid() { GenusId = s.GenusId, GenusName = s.GenusName }
                    ;
            return datagrid;
        }

        public static Genus GetGenusById(int id)
        {
            IQueryable<Genus> GenusQuery =
                               from p in DataAccessLayer.Genuss
                               where p.GenusId == id
                               select p;
            return GenusQuery.ToList()[0];
        }

        public static int SaveGenus(Genus SelectedGenus)
        {
            return DataAccessLayer.SaveChanges();
        }
        public static int AddNewGenus(int FamilyId)
        {
            DataAccessLayer.Genuss.AddObject(new Genus()
            {
                GenusId = DataAccessLayer.Genuss.NextId(f => f.GenusId),
                FamilyId = FamilyId,
                GenusName = ""
            });

            int changes = DataAccessLayer.SaveChanges();
            return changes;
        }

        public static bool DeleteGenus(Genus SelectedGenus)
        {
            try
            {
                DataAccessLayer.DeleteObject(SelectedGenus);
                DataAccessLayer.SaveChanges(System.Data.Objects.SaveOptions.None);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedGenus);
                return false;
            }
            DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedGenus);
            return true;
        }
        public static IEnumerable<GenusDataGrid> GetUnsedGenus()
        {
            IEnumerable<GenusDataGrid> g = from x in DataAccessLayer.Genuss
                                     where x.Species.Count() == 0
                                     orderby x.GenusName
                                     select new GenusDataGrid { GenusId = x.GenusId, GenusName = x.GenusName};
            return g;
        }
    }

    
    public class GenusDataGrid
    {
        public int GenusId { get; set; }
        public string GenusName { get; set; }
    }

}
