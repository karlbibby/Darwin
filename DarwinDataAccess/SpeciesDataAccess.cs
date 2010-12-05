using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;
using Darwin.Enum;

namespace Darwin.DataAccess
{

    public class SpeciesDataAccess
    {
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();

        public static Species GetSpeciesById(int id)
        {
            IQueryable<Species> SpeciesQuery =
                               from p in DataAccessLayer.Species
                               where p.SpeciesId == id
                               select p;
            return SpeciesQuery.ToList()[0];
        }

        public static int SaveSpecies(Species SelectedSpecies)
        {
            return DataAccessLayer.SaveChanges();
        }
        public static Species AddNewSpecies()
        {
            int _speciesid = DataAccessLayer.Species.NextId(f => f.SpeciesId);
            DataAccessLayer.Species.AddObject(new Species()
            {
                SpeciesId = _speciesid
            });
            DataAccessLayer.SaveChanges();

            return GetSpeciesById(_speciesid);
        }

        public static int DeleteSpecies(Species SelectedSpecies)
        {
            int cnt = 0;

            try
            {
                IEnumerable<SimilarSpecy> s1 = from s in DataAccessLayer.SimilarSpecies
                                               where s.SpeciesId1 == SelectedSpecies.SpeciesId
                                               select s;
                foreach (SimilarSpecy item in s1)
                {
                    DataAccessLayer.DeleteObject(item);
                    cnt += DataAccessLayer.SaveChanges();
                }
                IEnumerable<SimilarSpecy> s2 = from s in DataAccessLayer.SimilarSpecies
                                               where s.SpeciesId2 == SelectedSpecies.SpeciesId
                                               select s;
       
                foreach (SimilarSpecy item in s2)
                {
                    DataAccessLayer.DeleteObject(item);
                    cnt += DataAccessLayer.SaveChanges();
                } 
                IEnumerable<MapRef> m = from s in DataAccessLayer.MapRefs
                                               where s.SpeciesId == SelectedSpecies.SpeciesId
                                               select s;

                foreach (MapRef item in m)
                {
                    DataAccessLayer.DeleteObject(item);
                    cnt += DataAccessLayer.SaveChanges();
                }
            }
            catch { }
            try
            {
                DataAccessLayer.DeleteObject(SelectedSpecies);
                cnt += DataAccessLayer.SaveChanges(System.Data.Objects.SaveOptions.None);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedSpecies);
                return -1;
            }
            DataAccessLayer.Refresh(System.Data.Objects.RefreshMode.StoreWins, SelectedSpecies);
            return cnt;
        }

        public static void DeleteSimilarSpecies(int similarspeciesid)
        {
            int simid = similarspeciesid;
            var sim = from x in DataAccessLayer.SimilarSpecies
                      where x.SimilarId == simid
                      select x;
            SimilarSpecy simspec = sim.ToList()[0];
            DataAccessLayer.SimilarSpecies.DeleteObject(simspec);
            DataAccessLayer.SaveChanges();

        }
        public static IList<SimilarSpecies> GetSimilarSpecies(int SpeciesId)
        {
            IEnumerable<SimilarSpecies> x1 = (from y in DataAccessLayer.SimilarSpecies
                                             where y.SpeciesId1 == SpeciesId
                                              select new SimilarSpecies { SimilarId = y.SimilarId, SpeciesName = y.SpeciesToId2.SpeciesName + " (" + y.SpeciesToId2.SpeciesLatin + ")" }
        ).Union(
            from y in DataAccessLayer.SimilarSpecies
                                             where y.SpeciesId2 == SpeciesId
            select new SimilarSpecies { SimilarId = y.SimilarId, SpeciesName = y.SpeciesToId1.SpeciesName + " (" + y.SpeciesToId1.SpeciesLatin + ")" }
            );

            IList<SimilarSpecies> xx = x1.ToList();

            for (int i = 0; i < x1.Count(); i++)
            {
                if (xx[i].SpeciesName == null)
                {
                    xx[i].SpeciesName = "No Name";
                }
            }
            return xx;
        }

        public static int GetSpeciesIdFromSimilarSpecies(Species CurrentSpecies, int SimilarId)
        {
            int speciesid = 0;

            var sp = from x in DataAccessLayer.SimilarSpecies
                     where x.SimilarId == SimilarId
                     select x;
            if (sp.ToList()[0].SpeciesToId1.SpeciesId == CurrentSpecies.SpeciesId)
            {
                speciesid = Int32.Parse(sp.ToList()[0].SpeciesId2.ToString());
            }
            else
            {
                speciesid = Int32.Parse(sp.ToList()[0].SpeciesId1.ToString());
            }
            return speciesid;
        }
        public static bool CheckSpeciesExists(int SpeciesId)
        {
            var testid = from x in DataAccessLayer.Species
                         where x.SpeciesId == SpeciesId
                         select x.SpeciesId;
            if (testid.Count() == 0)
            {
                return false;
            }

            return true;
        }
        public static int SaveSimilarSpecies(int CurrentSpecisId, int SimilarSpeciesId)
        {
            SimilarSpecy newspec = new SimilarSpecy()
            {
                SimilarId = DataAccessLayer.SimilarSpecies.NextId(f => f.SimilarId),
                SpeciesId1 = CurrentSpecisId,
                SpeciesId2 = SimilarSpeciesId

            };
            DataAccessLayer.SimilarSpecies.AddObject(newspec);
            return DataAccessLayer.SaveChanges();
        }

        public static IList<MapRef> GetAllMapReferences(int SpeciesId)
        {
            return (from y in DataAccessLayer.MapRefs
                    where y.SpeciesId == SpeciesId
                    select y).ToList();
        }
        public static bool HasMapReferences(int SpeciesId)
        {
            if (GetAllMapReferences(SpeciesId).Count()>0)
            {
                return true;
            }
            return false;
        }
        public static int SaveMapReference(int MapReference, string Notes)
        {
            MapRef m = new MapRef();

            var mapo = from x in DataAccessLayer.MapRefs
                       where x.MapId == MapReference
                       select x;
            m = mapo.ToList()[0];
            m.Notes = Notes;
            return DataAccessLayer.SaveChanges();

        }

        public static int AddMapReference(int SpeciesId, int MapX, int MapY, string Notes)
        {
            MapRef m = new MapRef();
            m.MapId = DataAccessLayer.MapRefs.NextId(f => f.MapId);
            m.SpeciesId = SpeciesId;
            m.MapX = MapX;
            m.MapY = MapY;
            m.Notes = Notes;

            DataAccessLayer.AddToMapRefs(m);
            return DataAccessLayer.SaveChanges();
        }
        public static int DeleteMapReference(int MapReference)
        {
            var delpt = from x in DataAccessLayer.MapRefs
                        where x.MapId == MapReference
                        select x;
            MapRef todel = delpt.ToList()[0];
            DataAccessLayer.DeleteObject(todel);
            return DataAccessLayer.SaveChanges();
        }

        public static int GetMapReference(int SpeciesId, int X, int Y, int checkVariance)
        {
            checkVariance -= 2;
            var ch = from x in DataAccessLayer.MapRefs
                     where x.SpeciesId == SpeciesId
                            && x.MapX < (X + checkVariance)
                            && x.MapX > (X - checkVariance)
                            && x.MapY < (Y + checkVariance)
                            && x.MapY > (Y - checkVariance)
                     select new { x.MapId };

            if (ch.Count() == 0) return -1;
            if (ch.Count() > 1) return GetMapReference(SpeciesId, X, Y, checkVariance);
            return ch.ToList()[0].MapId;
        }

        public static MapRef GetMapReferenceById(int _CurrentMapPoint)
        {
            IEnumerable<MapRef> mapref = from x in DataAccessLayer.MapRefs
                                         where x.MapId == _CurrentMapPoint
                                         select x;
            return mapref.ToList()[0];
        }

        public static IEnumerable<TranslatedMapRef> GetTranslatedMapReferences(int SpeciesId, int TranslationSize)
        {
            IEnumerable<TranslatedMapRef> x = from y in DataAccessLayer.MapRefs
                                              where y.SpeciesId == SpeciesId
                                              select new TranslatedMapRef
                                              {
                                                  MapId = y.MapId,
                                                  MapX = (int)y.MapX,
                                                  MapTranslatedX = (int)((((y.MapX - 356000) / 6) * TranslationSize) / 1000),
                                                  MapY = (int)y.MapY,
                                                  MapTranslatedY = (int)((((y.MapY - 413000) / 6) * TranslationSize) / 1000)
                                              };
            return x;
        }

        public static int CountSpecies(TreeOfLiveType type, int id)
        {
            int cnt = 0 ;
            switch (type)
            {
                case TreeOfLiveType.Species:
                    cnt = DataAccessLayer.Species.Count();
                    break;
                case TreeOfLiveType.Kingdom:
                    cnt = DataAccessLayer.Species.Where(i => i.KingdomId == id).Count();
                    break;
                case TreeOfLiveType.Family:
                    cnt = DataAccessLayer.Species.Where(i => i.FamilyId == id).Count();
                    break;
                case TreeOfLiveType.Phylum:
                    cnt = DataAccessLayer.Species.Where(i => i.PhylumId == id).Count();
                    break;
                case TreeOfLiveType.Class:
                    cnt = DataAccessLayer.Species.Where(i => i.ClassId == id).Count();
                    break;
                case TreeOfLiveType.Order:
                    cnt = DataAccessLayer.Species.Where(i => i.OrderId == id).Count();
                    break;
                case TreeOfLiveType.Genus:
                    cnt = DataAccessLayer.Species.Where(i => i.GenusId == id).Count();
                    break;
                default:
                    cnt = 0;
                    break;
            }

            return cnt;
        }

        public static IEnumerable<Species> GetAllSpecies()
        {
            return DataAccessLayer.Species;
        }

        public static IEnumerable<SpeciesData> GetSpeciesByGenus(int p)
        {
            IEnumerable<SpeciesData> s = from x in DataAccessLayer.Species
                                         where x.GenusId == p
                                         select new SpeciesData { SpeciesName = x.SpeciesName + " ("+x.SpeciesLatin+")" } ;
            return s;
        }
    }

    public class SimilarSpecies
    {
        public int SimilarId { get; set; }
        public string SpeciesName { get; set; }
    }
    public class SpeciesData
    {
        public string SpeciesName {get;set;}
    }
    public class TranslatedMapRef
    {
        public int MapId { get; set; }
        public int MapX { get; set; }
        public int MapY { get; set; }
        public int MapTranslatedX { get; set; }
        public int MapTranslatedY { get; set; }

    }

}
