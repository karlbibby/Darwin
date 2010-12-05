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
    public partial class PhylumSetup : Form
    {
        private int _kingdomId;
        public PhylumSetup(string Kingdom)
        {
            _kingdomId = int.Parse(Kingdom);
            InitializeComponent();

        }
        private int _lastselectedrowindex;
        private Phylum SelectedPhylum;

        private void PhylumSetup_Load(object sender, EventArgs e)
        {
            
            txtKingdomId.Text = _kingdomId.ToString();
            
            

            LoadData();
            try
            {
                int id = int.Parse(dgPhylums.Rows[0].Cells[0].Value.ToString());
                SelectPhylum(id);
            }
            catch { }
        }

        private void LoadData()
        {
            dgPhylums.DataSource = PhylumDataAccess.GetPhylumsByKingdom(_kingdomId);
            dgPhylums.Columns[0].Width = 40;
            dgPhylums.Columns[1].Width = 300;


            try
            {
                string KingdomName = KingdomDataAccess.GetKingdomById(_kingdomId).KingdomName;
                this.Text = "Phylum Setup - " + KingdomName;
                lblParentInfo.Text = KingdomName;
            }
            catch { }
        }

        private void SelectPhylum(int id)
        {
            try
            {

                SelectedPhylum = PhylumDataAccess.GetPhylumById(id);
                txtPhylumName.Text = SelectedPhylum.PhylumName;
                txtPhylumId.Text = SelectedPhylum.PhylumId.ToString();
                btnClasses.Enabled = true;
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedPhylum.PhylumName = txtPhylumName.Text;
            int rowsAffected = PhylumDataAccess.SavePhylum(SelectedPhylum);
            lblMessage.Text = rowsAffected.ToString() + " changes made to the table";
            tmrClearMsg.Start();

            LoadData();

            int id = int.Parse(dgPhylums.Rows[0].Cells[0].Value.ToString());
            SelectPhylum(id);
            foreach (DataGridViewRow item in dgPhylums.Rows)
            {
                item.Selected = false;

            }
            dgPhylums.CurrentCell = dgPhylums.Rows[_lastselectedrowindex].Cells[0];
            dgPhylums.Rows[_lastselectedrowindex].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PhylumDataAccess.DeletePhylum(SelectedPhylum) == false)
            {
                MessageBox.Show("Cannot delete, child nodes still exist", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SelectedPhylum = null;
            LoadData();
            try
            {
                dgPhylums.CurrentCell = dgPhylums.Rows[0].Cells[0];
                dgPhylums.Rows[0].Selected = true;
            }
            catch
            {
                btnClasses.Enabled = false;
                txtPhylumId.Text = "";
                txtPhylumName.Text = "";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            int changes = PhylumDataAccess.AddNewPhylum(_kingdomId);
            lblMessage.Text = changes.ToString() + " changes made to the table";
            tmrClearMsg.Start();
            LoadData();
            dgPhylums.CurrentCell = dgPhylums.Rows[dgPhylums.Rows.Count - 1].Cells[0];
            dgPhylums.Rows[0].Selected = true;
            txtPhylumName.Focus();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            ClassSetup c = new ClassSetup(SelectedPhylum.PhylumId);
            c.Show();
        }

        private void tmrClearMsg_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void dgPhylums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgPhylums.Rows[e.RowIndex].Cells[0].Value.ToString());
                _lastselectedrowindex = dgPhylums.Rows[e.RowIndex].Index;
                SelectPhylum(id);
            }
        }

        private void dgPhylums_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(dgPhylums.SelectedRows[0].Cells[0].Value.ToString());
                _lastselectedrowindex = dgPhylums.SelectedRows[0].Index;
                SelectPhylum(id);
            }
            catch { }
        }


    }
}
