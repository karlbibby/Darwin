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
    public partial class SpeciesFlags : UserControl
    {
        public SpeciesFlags()
        {
            InitializeComponent();
        }
        private SpeciesEnumFlags SpeciesFlagInformation;

        public SpeciesEnumFlags GetSpeciesInformation()
        {
            return SpeciesFlagInformation;
        }


        private void SpeciesFlags_Load(object sender, EventArgs e)
        {
            SpeciesFlagInformation = new SpeciesEnumFlags();

        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(((Darwin.Objects.SeasonCheckbox)sender));
        }

        private void ProcessChange(Darwin.Objects.SeasonCheckbox c)
        {
            if (c.Checked)
            {
                SpeciesFlagInformation |= (c).SeasonFlag;
            }
            else
            {
                SpeciesFlagInformation ^= (c).SeasonFlag;
            }
        }

        internal void LoadData(int? CurrentFlags)
        {
            SetFlag(cbDiurnal, CurrentFlags, 128, out CurrentFlags);
            SetFlag(cbNocturnal, CurrentFlags, 64, out CurrentFlags);
            SetFlag(cbIrritant, CurrentFlags, 32, out CurrentFlags);
            SetFlag(cbStinging, CurrentFlags, 16, out CurrentFlags);
            SetFlag(cbBiting, CurrentFlags, 8, out CurrentFlags);
            SetFlag(cbMedicinal, CurrentFlags, 4, out CurrentFlags);
            SetFlag(cbEdiable, CurrentFlags, 2, out CurrentFlags);
            SetFlag(cbPoisonous, CurrentFlags, 1, out CurrentFlags);
        }
        
        private void SetFlag(CheckBox c, int? Input, int FlagValue, out int? Value)
        {
            int takeoff = 0;
            if ((Input - FlagValue) >= 0)
            {
                c.Checked = true;
                takeoff = FlagValue;
            }
            else
            {
                c.Checked = false;
            }
            Value = Input - takeoff;
        }

        internal void UncheckAll()
        {
            cbIrritant.Checked = false;
            cbStinging.Checked = false;
            cbBiting.Checked = false;
            cbMedicinal.Checked = false;
            cbEdiable.Checked = false;
            cbPoisonous.Checked = false;
            cbDiurnal.Checked = false;
            cbNocturnal.Checked = false;
        }


    }
}
