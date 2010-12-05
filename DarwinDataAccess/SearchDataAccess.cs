using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.DataAccess;
using Darwin.Enum;
using Darwin.Objects;

namespace Darwin.DataAccess
{

    public class SearchDataAccess
    { 
        private static DataStoreEntities DataAccessLayer = new DataStoreEntities();
        private static SpeciesEnumFlags ConvertToFlags(int? CurrentFlags)
        {
            SpeciesEnumFlags returnval = new SpeciesEnumFlags();

            SetFlag(CurrentFlags, returnval, SpeciesEnumFlags.Diurnal, out returnval, out CurrentFlags);
            SetFlag(CurrentFlags, returnval, SpeciesEnumFlags.Nocturnal, out returnval, out CurrentFlags);
            SetFlag(CurrentFlags, returnval, SpeciesEnumFlags.Irritant, out returnval, out CurrentFlags);
            SetFlag(CurrentFlags, returnval, SpeciesEnumFlags.Stinging, out returnval, out CurrentFlags);
            SetFlag(CurrentFlags, returnval, SpeciesEnumFlags.Biting, out returnval, out CurrentFlags);
            SetFlag(CurrentFlags, returnval, SpeciesEnumFlags.Medicinal, out returnval, out CurrentFlags);
            SetFlag(CurrentFlags, returnval, SpeciesEnumFlags.Ediable, out returnval, out CurrentFlags);
            SetFlag(CurrentFlags, returnval, SpeciesEnumFlags.Poisonous, out returnval, out CurrentFlags);


            return returnval;
        }

        private static MonthEumFlags ConvertToSeasions(int? CurrentSeasaons)
        {
            MonthEumFlags returnval = new MonthEumFlags();
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.Winter, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.Autumn, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.Summer, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.Spring, out returnval, out CurrentSeasaons);

            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.December, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.November, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.October, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.September, out returnval, out CurrentSeasaons);

            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.August, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.July, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.June, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.May, out returnval, out CurrentSeasaons);

            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.April, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.March, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.Feburary, out returnval, out CurrentSeasaons);
            SetFlag(CurrentSeasaons, returnval, MonthEumFlags.January, out returnval, out CurrentSeasaons);

            return returnval;

        }

        private static DistributionFlags ConvertToDistribution(int? CurrentDitribution)
        {
            DistributionFlags returnval = new DistributionFlags();


            SetFlag(CurrentDitribution, returnval, DistributionFlags.C, out returnval, out CurrentDitribution);

            SetFlag(CurrentDitribution, returnval, DistributionFlags.SE, out returnval, out CurrentDitribution);
            SetFlag(CurrentDitribution, returnval, DistributionFlags.SW, out returnval, out CurrentDitribution);
            SetFlag(CurrentDitribution, returnval, DistributionFlags.NE, out returnval, out CurrentDitribution);
            SetFlag(CurrentDitribution, returnval, DistributionFlags.NW, out returnval, out CurrentDitribution);

            SetFlag(CurrentDitribution, returnval, DistributionFlags.W, out returnval, out CurrentDitribution);
            SetFlag(CurrentDitribution, returnval, DistributionFlags.S, out returnval, out CurrentDitribution);
            SetFlag(CurrentDitribution, returnval, DistributionFlags.E, out returnval, out CurrentDitribution);
            SetFlag(CurrentDitribution, returnval, DistributionFlags.N, out returnval, out CurrentDitribution);

            SetFlag(CurrentDitribution, returnval, DistributionFlags.Ireland, out returnval, out CurrentDitribution);
            SetFlag(CurrentDitribution, returnval, DistributionFlags.Scotland, out returnval, out CurrentDitribution);


            return returnval;

        }

        private static void SetFlag(int? Input, SpeciesEnumFlags Flagset, SpeciesEnumFlags FlagToSet, out SpeciesEnumFlags ValueOut, out int? Value)
        {
            int takeoff = 0;
            ValueOut = Flagset;

            if ((Input - FlagToSet.GetHashCode()) >= 0)
            {
                ValueOut ^= FlagToSet;
                takeoff = FlagToSet.GetHashCode();
            }
            else
            {
                //ValueOut ^= FlagToSet;
            }
            Value = Input - takeoff;
        }

        private static void SetFlag(int? Input, MonthEumFlags Flagset, MonthEumFlags FlagToSet, out MonthEumFlags ValueOut, out int? Value)
        { 
            int takeoff = 0;
            ValueOut = Flagset;

            if ((Input - FlagToSet.GetHashCode()) >= 0)
            {
                ValueOut ^= FlagToSet;
                takeoff = FlagToSet.GetHashCode();
            }
            else
            {
                //ValueOut ^= FlagToSet;
            }
            Value = Input - takeoff;
        }
        private static void SetFlag(int? Input, DistributionFlags Flagset, DistributionFlags FlagToSet, out DistributionFlags ValueOut, out int? Value)
        {
            int takeoff = 0;
            ValueOut = Flagset;

            if ((Input - FlagToSet.GetHashCode()) >= 0)
            {
                ValueOut ^= FlagToSet;
                takeoff = FlagToSet.GetHashCode();
            }
            else
            {
                //ValueOut ^= FlagToSet;
            }
            Value = Input - takeoff;
        }


        public static IEnumerable<Species> FilterByStatus(IEnumerable<Species> MatchingSpecies, int _Status)
        {
            return MatchingSpecies.Where(i => i.SpeciesStatus == _Status);
        }

        public static IEnumerable<Species> FilterByInYarrowVallyPark(IEnumerable<Species> MatchingSpecies, bool _inYVP)
        {
            return MatchingSpecies.Where(i => SpeciesDataAccess.HasMapReferences(i.SpeciesId));
        }

        public static IEnumerable<Species> FilterByName(IEnumerable<Species> MatchingSpecies, string _Name)
        {
            return MatchingSpecies.Where(i => (i.SpeciesName + "|" + i.SpeciesLatin).ToLower().Contains(_Name.ToLower()));
        }

        public static IEnumerable<Species> FilterByFlag(IEnumerable<Species> MatchingSpecies, Enum.SpeciesEnumFlags _Flags)
        {
            return MatchingSpecies.Where(i => (Convert.ToInt32(ConvertToFlags(i.Flags) & _Flags) > 0)); 
        }

        public static IEnumerable<Species> FilterBySeason(IEnumerable<Species> MatchingSpecies, MonthEumFlags _Seasons)
        {
            return MatchingSpecies.Where(i => (Convert.ToInt32(ConvertToSeasions(i.Seasons) & _Seasons) > 0));
        }

        public static IEnumerable<Species> FilterByDistribution(IEnumerable<Species> MatchingSpecies, DistributionFlags _DistFlags)
        {
            return MatchingSpecies.Where(i => (Convert.ToInt32(ConvertToDistribution(i.DistributionFlags) & _DistFlags) > 0));
        }

        public static IEnumerable<Species> FilterByColour(IEnumerable<Species> MatchingSpecies, SpeciesColour _SpeciesColour)
        {
            return MatchingSpecies.Where(i => i.Colour == _SpeciesColour.GetHashCode());
        }

        public static IEnumerable<Species> FilterByText(IEnumerable<Species> MatchingSpecies, string _AnyText)
        {
           return MatchingSpecies.Where(i => (i.SpeciesName + "|" + i.SpeciesLatin + "|" + i.Description + "|" + i.Habitat + "|" + i.Distribution + "|" + i.Food + "|" + i.Breeding + "|" + i.Status).ToLower().Contains(_AnyText.ToLower()));
        }

        public static IEnumerable<SearchResultCollection> ConvertToSearchResultCollection(IEnumerable<Species> MatchingSpecies)
        {
            IEnumerable<SearchResultCollection> searchresults = from x in MatchingSpecies
                                                                orderby x.SpeciesId
                            select new SearchResultCollection() { 
                                SpeciesId = x.SpeciesId, 
                                Name = x.SpeciesName + " (" + x.SpeciesLatin + ")", 
                                Order = OrderDataAccess.GetOrderById(x.OrderId).OrderName, 
                                Family = FamilyDataAccess.GetFamilyById(x.FamilyId).FamilyName, 
                                Flag = Int32.Parse(x.Flags.GetValueOrDefault().ToString()), 
                                Colour = x.Colour };
            try
            {
                string s = searchresults.ToList()[0].Family;
            }
            catch (Exception ex)
            {
            }
            return searchresults;
        }

        public static IEnumerable<Species> FilterByGenus(IEnumerable<Species> MatchingSpecies, int? _Genus)
        {
            return MatchingSpecies.Where(i => i.GenusId == _Genus);
        }

        public static IEnumerable<Species> FilterByFamily(IEnumerable<Species> MatchingSpecies, int? _Family)
        {
            return MatchingSpecies.Where(i => i.FamilyId == _Family);
        }

        public static IEnumerable<Species> FilterByOrder(IEnumerable<Species> MatchingSpecies, int? _Order)
        {
            return MatchingSpecies.Where(i => i.OrderId == _Order);
        }

        public static IEnumerable<Species> FilterByClass(IEnumerable<Species> MatchingSpecies, int? _Class)
        {
            return MatchingSpecies.Where(i => i.ClassId == _Class);
        }

        public static IEnumerable<Species> FilterByPhylum(IEnumerable<Species> MatchingSpecies, int? _Phylum)
        {
            return MatchingSpecies.Where(i => i.PhylumId == _Phylum);
        }

        public static IEnumerable<Species> FilterByKingDom(IEnumerable<Species> MatchingSpecies, int? _Kingdom)
        {
            return MatchingSpecies.Where(i => i.KingdomId == _Kingdom);
        }

        public static IEnumerable<Species> FilterToNoColour(IEnumerable<Species> MatchingSpecies)
        {
            return MatchingSpecies.Where(i => i.Colour.GetHashCode() == 0);

        }

        public static IEnumerable<Species> FilterToNoLocation(IEnumerable<Species> MatchingSpecies)
        {
            return MatchingSpecies.Where(i => i.DistributionFlags.GetHashCode() == 0);
        }

        public static IEnumerable<Species> FilterToNoSeason(IEnumerable<Species> MatchingSpecies)
        {
            return MatchingSpecies.Where(i => i.Seasons.GetHashCode() == 0);
        }

        public static IEnumerable<Species> FilterToNoStatus(IEnumerable<Species> MatchingSpecies)
        {
            return MatchingSpecies.Where(i => i.SpeciesStatus == null);
        }
    }

}
