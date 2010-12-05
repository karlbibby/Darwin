using System;

namespace Darwin.Enum
{
    [Flags]
    public enum MonthEumFlags
    {
        January = 0x1,
        Feburary = 0x2,
        March = 0x4,
        April = 0x8,
        May = 0x10,
        June = 0x20,
        July = 0x40,
        August = 0x80,
        September = 0x100,
        October = 0x200,
        November = 0x400,
        December = 0x800,
        Spring = 0x1000,
        Summer = 0x2000,
        Autumn = 0x4000,
        Winter = 0x8000
    }
    [Flags]
    public enum SpeciesEnumFlags
    {
        Poisonous = 0x1,
        Ediable = 0x2,
        Medicinal = 0x4,
        Biting = 0x8,
        Stinging = 0x10,
        Irritant = 0x20,
        Nocturnal = 0x40,
        Diurnal = 0x80
    }

    [Flags]
    public enum DistributionFlags
    {
        Scotland = 0x1,
        Ireland = 0x2,
        N = 0x4,
        E = 0x8,
        S = 0x10,
        W = 0x20,
        NW = 0x40,
        NE = 0x80,
        SW = 0x100,
        SE = 0x200,
        C = 0x400

    }
    [Flags]
    public enum SpeciesColour
    {
        None = 0x0,
        Blue  = 0x1,
        Yellow  = 0x2,
        Red = 0x4,
        White = 0x8,
        Green = 0x10
    }


}
