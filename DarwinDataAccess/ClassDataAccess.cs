using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;

namespace Darwin.DataAccess
{

    public class ClassDataAccess
    { 
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();

        public static IEnumerable<ClassDataGrid> GetAllClasss()
        {
            IEnumerable<ClassDataGrid> datagrid = from s in DataAccessLayer.Classes
                                                   orderby s.ClassName
                                                   select new ClassDataGrid() { ClassId = s.ClassId, ClassName = s.ClassName }
                    ;
            return datagrid;
        }

        public static IEnumerable<ClassDataGrid> GetClasssByPhylum(int PhylumId)
        {
            IEnumerable<ClassDataGrid> datagrid = from s in DataAccessLayer.Classes
                                                   where s.PhylumId == PhylumId
                                                   orderby s.ClassName
                                                   select new ClassDataGrid() { ClassId = s.ClassId, ClassName = s.ClassName }
                    ;
            return datagrid;
        }

        public static Class GetClassById(int id)
        {
            IQueryable<Class> ClassQuery =
                               from p in DataAccessLayer.Classes
                               where p.ClassId == id
                               select p;
            return ClassQuery.ToList()[0];
        }

        public static int SaveClass(Class SelectedClass)
        {
            return DataAccessLayer.SaveChanges();
        }
        public static int AddNewClass(int PhylumId)
        {
            DataAccessLayer.Classes.AddObject(new Class()
            {
                ClassId = DataAccessLayer.Classes.NextId(f => f.ClassId),
                PhylumId = PhylumId,
                ClassName = ""
            });

            int changes = DataAccessLayer.SaveChanges();
            return changes;
        }

        public static bool DeleteClass(Class SelectedClass)
        {
            try
            {
                DataAccessLayer.DeleteObject(SelectedClass);
                DataAccessLayer.SaveChanges(System.Data.Objects.SaveOptions.None);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedClass);
                return false;
            }
            DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedClass);
            return true;
        }
    }

    
    public class ClassDataGrid
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }

}
