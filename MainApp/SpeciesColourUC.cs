using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Darwin.Enum;

namespace Darwin.WindowsForm
{
    public partial class SpeciesColourUC : UserControl
    {
        public SpeciesColourUC()
        {
            InitializeComponent();
        }

        public SpeciesColour GetSelectedColour()
        {
            if (rbNone.Checked) return SpeciesColour.None;
            if (rbRed.Checked) return SpeciesColour.Red;
            if (rbGreen.Checked) return SpeciesColour.Green;
            if (rbWhite.Checked) return SpeciesColour.White;
            if (rbYellow.Checked) return SpeciesColour.Yellow;
            if (rbBlue.Checked) return SpeciesColour.Blue;
            return SpeciesColour.None; ;
        }
        public void SetSelectedColour(int? InputColour)
        {

            switch (InputColour)
            {
                case 0:
                    rbNone.Checked = true;
                    break;
                case 1:
                    rbBlue.Checked = true;
                    break;
                case 2:
                    rbYellow.Checked = true;
                    break;
                case 4:
                    rbRed.Checked = true;
                    break;
                case 8:
                    rbWhite.Checked = true;
                    break;
                case 16:
                    rbGreen.Checked = true;
                    break;
                default:
                    break;
            }
        }


    }
}
