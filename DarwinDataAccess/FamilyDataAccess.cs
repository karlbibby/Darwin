using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;

namespace Darwin.DataAccess
{

    public class FamilyDataAccess
    {
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();

        public static IEnumerable<FamilyDataGrid> GetAllFamilies()
        {
            IEnumerable<FamilyDataGrid> datagrid = from s in DataAccessLayer.Families
                                                   orderby s.FamilyName
                                                   select new FamilyDataGrid() { FamilyId = s.FamilyId, FamilyName = s.FamilyName }
                    ;
            return datagrid;
        }

        public static IEnumerable<FamilyDataGrid> GetFamiliesByOrder(int OrderId)
        {
            IEnumerable<FamilyDataGrid> datagrid = from s in DataAccessLayer.Families
                                                   where s.OrderId == OrderId
                                                   orderby s.FamilyName
                                                   select new FamilyDataGrid() { FamilyId = s.FamilyId, FamilyName = s.FamilyName }
                    ;
            return datagrid;
        }

        public static Family GetFamilyById(int? id)
        {
            if (id != null)
            {
                IQueryable<Family> FamilyQuery =
                                   from p in DataAccessLayer.Families
                                   where p.FamilyId == id
                                   select p;

                return FamilyQuery.ToList()[0];
            }

            else
            {
                Family f = new Family();
                f.FamilyName = "";
                return f;
            }
        }

        public static int SaveFamily(Family SelectedFamily)
        {
            return DataAccessLayer.SaveChanges();
        }
        public static int AddNewFamily(int OrderId)
        {
            DataAccessLayer.Families.AddObject(new Family()
            {
                FamilyId = DataAccessLayer.Families.NextId(f => f.FamilyId),
                OrderId = OrderId,
                FamilyName = ""
            });

            int changes = DataAccessLayer.SaveChanges();
            return changes;
        }

        public static bool DeleteFamily(Family SelectedFamily)
        {
            try
            {
                DataAccessLayer.DeleteObject(SelectedFamily);
                DataAccessLayer.SaveChanges(System.Data.Objects.SaveOptions.None);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedFamily);
                return false;
            }
            DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedFamily);
            return true;
        }

        public static IEnumerable<FamilyDataGrid> GetUnusedFamily()
        {
            IEnumerable<FamilyDataGrid> g = from x in DataAccessLayer.Families
                                           where x.Species.Count() == 0
                                           orderby x.FamilyName
                                            select new FamilyDataGrid { FamilyId = x.FamilyId, FamilyName = x.FamilyName };
            return g;
        }
    }


    public class FamilyDataGrid
    {
        public int FamilyId { get; set; }
        public string FamilyName { get; set; }
    }

}
