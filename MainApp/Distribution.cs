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
    public partial class DistributionPicker : UserControl
    {
        public DistributionPicker()
        {
            InitializeComponent();
        }

        public DistributionFlags DistributionPickerInformation;

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            checkAll();
        }
        private void checkAll()
        {
            if (cbAll.Checked)
            {
                cbScotland.Checked = true;
                cbIreland.Checked = true;
                cbN.Checked = true;
                cbS.Checked = true;
                cbE.Checked = true;
                cbW.Checked = true;
                cbC.Checked = true;
                cbNW.Checked = true;
                cbNE.Checked = true;
                cbSW.Checked = true;
                cbSE.Checked = true;

            }
        }



        private void cbClear_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    (item as CheckBox).Checked = false;
                }
            }
        }

        private void MonthPicker_Load(object sender, EventArgs e)
        {
            DistributionPickerInformation = new DistributionFlags();

        }
        private void ProcessChange(CheckBox c, DistributionFlags f)
        {
            if (c.Checked)
            {
                DistributionPickerInformation |= f;
            }
            else
            {
                DistributionPickerInformation ^= f;
            }
        }

        private void cbScotland_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbScotland, DistributionFlags.Scotland);
        }

        private void cbIreland_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbIreland, DistributionFlags.Ireland);
        }

        private void cbN_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbN, DistributionFlags.N);
        }

        private void cbS_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbS, DistributionFlags.S);
        }

        private void cbE_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbE, DistributionFlags.E);
        }

        private void cbW_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbW, DistributionFlags.W);
        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbC, DistributionFlags.C);
        }

        private void cbNW_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbNW, DistributionFlags.NW);
        }

        private void cbNE_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbNE, DistributionFlags.NE);
        }

        private void cbSW_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbSW, DistributionFlags.SW);
        }

        private void cbSE_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbSE, DistributionFlags.SE);
        }



        public DistributionFlags GetDistributionInformation()
        {
            return DistributionPickerInformation;
        }

        internal void LoadData(int? CurrentFlags)
        {
            SetFlag(cbC, CurrentFlags, 1024, out CurrentFlags);
            SetFlag(cbSE, CurrentFlags, 512, out CurrentFlags);
            SetFlag(cbSW, CurrentFlags, 256, out CurrentFlags);

            SetFlag(cbNE, CurrentFlags, 128, out CurrentFlags);
            SetFlag(cbNW, CurrentFlags, 64, out CurrentFlags);
            SetFlag(cbW, CurrentFlags, 32, out CurrentFlags);
            SetFlag(cbS, CurrentFlags, 16, out CurrentFlags);

            SetFlag(cbE, CurrentFlags, 8, out CurrentFlags);
            SetFlag(cbN, CurrentFlags, 4, out CurrentFlags);
            SetFlag(cbIreland, CurrentFlags, 2, out CurrentFlags);
            SetFlag(cbScotland, CurrentFlags, 1, out CurrentFlags);

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
            cbClear.Checked = true;
        }
    }
}
