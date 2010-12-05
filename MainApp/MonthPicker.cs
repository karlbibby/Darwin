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
    public partial class MonthPicker : UserControl
    {
        public MonthPicker()
        {
            InitializeComponent();
        }

        public MonthEumFlags MonthPickerInformation;

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            checkAll();
        }
        private void checkAll()
        {
            if (cbAll.Checked)
            {
                checkWinter();
                checkSummer();
                checkSpring();
                checkSummer();

                cbSpring.Checked = true;
                cbSummer.Checked = true;
                cbAutumn.Checked = true;
                cbWinter.Checked = true;
            }
        }

        private void cbSpring_CheckedChanged(object sender, EventArgs e)
        {
            checkSpring();
        }

        private void checkSpring()
        {
            if (cbSpring.Checked)
            {
                cbMar.Checked = true;
                cbApr.Checked = true;
                cbMay.Checked = true;
            }
            ProcessChange(cbSpring, MonthEumFlags.Spring);
        }

        private void cbSummer_CheckedChanged(object sender, EventArgs e)
        {
            checkSummer();
        }

        private void checkSummer()
        {
            if (cbSummer.Checked)
            {
                cbJun.Checked = true;
                cbJul.Checked = true;
                cbAug.Checked = true;
            }
            ProcessChange(cbSummer, MonthEumFlags.Summer);
        }

        private void cbAutumn_CheckedChanged(object sender, EventArgs e)
        {
            checkAutumn();
        }

        private void checkAutumn()
        {
            if (cbAutumn.Checked)
            {
                cbSep.Checked = true;
                cbOct.Checked = true;
                cbNov.Checked = true;
            }
            ProcessChange(cbAutumn, MonthEumFlags.Autumn);
        }

        private void cbWinter_CheckedChanged(object sender, EventArgs e)
        {
            checkWinter();
        }

        private void checkWinter()
        {
            if (cbWinter.Checked)
            {
                cbDec.Checked = true;
                cbJan.Checked = true;
                cbFeb.Checked = true;
            }
            ProcessChange(cbWinter, MonthEumFlags.Winter);
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
            MonthPickerInformation = new MonthEumFlags();

        }
        private void ProcessChange(CheckBox c, MonthEumFlags f)
        {
            if (c.Checked)
            {
                MonthPickerInformation |= f;
            }
            else
            {
                MonthPickerInformation ^= f;
            }
        }

        private void cbJan_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbJan, MonthEumFlags.January);
        }

        private void cbFeb_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbFeb, MonthEumFlags.Feburary);
        }

        private void cbMar_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbMar, MonthEumFlags.March);
        }

        private void cbApr_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbApr, MonthEumFlags.April);
        }

        private void cbMay_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbMay, MonthEumFlags.May);
        }

        private void cbJun_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbJun, MonthEumFlags.June);
        }

        private void cbJul_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbJul, MonthEumFlags.July);
        }

        private void cbAug_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbAug, MonthEumFlags.August);
        }

        private void cbSep_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbSep, MonthEumFlags.September);
        }

        private void cbOct_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbOct, MonthEumFlags.October);
        }

        private void cbNov_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbNov, MonthEumFlags.November);
        }

        private void cbDec_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChange(cbDec, MonthEumFlags.December);
        }

        public MonthEumFlags GetMonthsInformation()
        {
            return MonthPickerInformation;
        }

        internal void LoadData(int? CurrentFlags)
        {

            SetFlag(cbWinter, CurrentFlags, 32768, out CurrentFlags);
            SetFlag(cbAutumn, CurrentFlags, 16384, out CurrentFlags);
            SetFlag(cbSummer, CurrentFlags, 8192, out CurrentFlags);
            SetFlag(cbSpring, CurrentFlags, 4096, out CurrentFlags);

            SetFlag(cbDec, CurrentFlags, 2048, out CurrentFlags);
            SetFlag(cbNov, CurrentFlags, 1024, out CurrentFlags);
            SetFlag(cbOct, CurrentFlags, 512, out CurrentFlags);
            SetFlag(cbSep, CurrentFlags, 256, out CurrentFlags);

            SetFlag(cbAug, CurrentFlags, 128, out CurrentFlags);
            SetFlag(cbJul, CurrentFlags, 64, out CurrentFlags);
            SetFlag(cbJun, CurrentFlags, 32, out CurrentFlags);
            SetFlag(cbMay, CurrentFlags, 16, out CurrentFlags);

            SetFlag(cbApr, CurrentFlags, 8, out CurrentFlags);
            SetFlag(cbMar, CurrentFlags, 4, out CurrentFlags);
            SetFlag(cbFeb, CurrentFlags, 2, out CurrentFlags);
            SetFlag(cbJan, CurrentFlags, 1, out CurrentFlags);

    
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
