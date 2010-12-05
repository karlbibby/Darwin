using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darwin.Enum;


namespace Darwin.Objects
{
    public class SeasonCheckbox : System.Windows.Forms.CheckBox
    {
        public SpeciesEnumFlags SeasonFlag { get; set; }
    }
}
