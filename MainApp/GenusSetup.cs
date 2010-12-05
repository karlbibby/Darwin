using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Darwin.DataAccess;

namespace Darwin.WindowsForm
{
    public partial class GenusSetup : Form
    {
        private int _FamilyId;
        public GenusSetup(int OrderId)
        {
            _FamilyId = OrderId;
            InitializeComponent();

        }
        private int _lastselectedrowindex;
        private Genus SelectedGenus;

        private void GenusSetup_Load(object sender, EventArgs e)
        {
            txtFamilyId.Text = _FamilyId.ToString();
            LoadData();
            try
            {
                int id = int.Parse(dgGenus.Rows[0].Cells[0].Value.ToString());
                SelectGenus(id);
            }
            catch { }
        }

        private void LoadData()
        {
            dgGenus.DataSource = GenusDataAccess.GetGenusByFamily(_FamilyId);

            dgGenus.Columns[0].Width = 40;
            dgGenus.Columns[1].Width = 300;

            try
            {
                Family f = FamilyDataAccess.GetFamilyById(_FamilyId);
                string FamilyName = f.FamilyName;
                string OrderName = f.Order.OrderName;
                string ClassName = f.Order.Class.ClassName;
                string PhylumName = f.Order.Class.Phylum.PhylumName;
                string KingdomName = f.Order.Class.Phylum.Kingdom.KingdomName;

                this.Text = "Genus Setup - " + KingdomName + " - " + PhylumName + " - " + ClassName + " - " + OrderName + " - " + FamilyName;
                lblParentInfo.Text = KingdomName + "\n" + PhylumName + "\n" + ClassName + "\n" + OrderName + "\n" + FamilyName;
            }
            catch { }
        }

        private void SelectGenus(int id)
        {
            try
            {
                SelectedGenus = GenusDataAccess.GetGenusById(id);
                txtGenusName.Text = SelectedGenus.GenusName;
                txtGenusId.Text = SelectedGenus.GenusId.ToString();
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedGenus.GenusName = txtGenusName.Text;
            int rowsAffected = GenusDataAccess.SaveGenus(SelectedGenus);
            lblMessage.Text = rowsAffected.ToString() + " changes made to the table";
            tmrClearMsg.Start();

            LoadData();

            int id = int.Parse(dgGenus.Rows[0].Cells[0].Value.ToString());
            SelectGenus(id);
            foreach (DataGridViewRow item in dgGenus.Rows)
            {
                item.Selected = false;

            }
            dgGenus.CurrentCell = dgGenus.Rows[_lastselectedrowindex].Cells[0];
            dgGenus.Rows[_lastselectedrowindex].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GenusDataAccess.DeleteGenus(SelectedGenus) == false)
            {
                MessageBox.Show("Cannot delete, child nodes still exist", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SelectedGenus = null;
            LoadData();
            try
            {
                dgGenus.CurrentCell = dgGenus.Rows[0].Cells[0];
                dgGenus.Rows[0].Selected = true;
            }
            catch
            {
                txtGenusId.Text = "";
                txtGenusName.Text = "";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            int changes = GenusDataAccess.AddNewGenus(_FamilyId);
            lblMessage.Text = changes.ToString() + " changes made to the table";
            tmrClearMsg.Start();
            LoadData();
            dgGenus.CurrentCell = dgGenus.Rows[dgGenus.Rows.Count - 1].Cells[0];
            dgGenus.Rows[0].Selected = true;
            txtGenusName.Focus();
        }

        private void btnGenus_Click(object sender, EventArgs e)
        {
            GenusSetup g = new GenusSetup(SelectedGenus.GenusId);
            g.Show();
        }

        private void tmrClearMsg_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void dgGenus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgGenus.Rows[e.RowIndex].Cells[0].Value.ToString());
                _lastselectedrowindex = dgGenus.Rows[e.RowIndex].Index;
                SelectGenus(id);
            }
        }

        private void dgGenus_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(dgGenus.SelectedRows[0].Cells[0].Value.ToString());
                _lastselectedrowindex = dgGenus.SelectedRows[0].Index;
                SelectGenus(id);
            }
            catch { }
        }





















    }
}
