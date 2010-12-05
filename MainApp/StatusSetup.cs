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
    public partial class StatusSetup : Form
    {
        public StatusSetup()
        {
            InitializeComponent();
        }

        private void StatusSetup_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            dgStatus.DataSource = StatusDataAccess.GetAllStatus();
            dgStatus.Columns[0].Width = 40;
            dgStatus.Columns[1].Width = 300;
            dgStatus.Columns[2].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedStatus.StatusText = txtStatusName.Text;


            int rowsAffected = StatusDataAccess.SaveStatus(SelectedStatus); ;
            lblMessage.Text = rowsAffected.ToString() + " changes made to the table";
            tmrClearMsg.Start();

            LoadData();

            int id = int.Parse(dgStatus.Rows[0].Cells[0].Value.ToString());
            SelectStatus(id);
            foreach (DataGridViewRow item in dgStatus.Rows)
            {
                item.Selected = false;

            }
            dgStatus.CurrentCell = dgStatus.Rows[_lastselectedrowindex].Cells[0];
            dgStatus.Rows[_lastselectedrowindex].Selected = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int changes = StatusDataAccess.AddNewStatus();
            lblMessage.Text = changes.ToString() + " changes made to the table";
            tmrClearMsg.Start();
            LoadData();
            dgStatus.CurrentCell = dgStatus.Rows[dgStatus.Rows.Count - 1].Cells[0];
            dgStatus.Rows[0].Selected = true;
            txtStatusName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StatusDataAccess.DeleteStatus(SelectedStatus) == false)
            {
                MessageBox.Show("Cannot delete, child nodes still exist", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            SelectedStatus = null;
            LoadData();
            try
            {
                dgStatus.CurrentCell = dgStatus.Rows[0].Cells[0];
                dgStatus.Rows[0].Selected = true;
            }
            catch
            {
                txtStatusId.Text = "";
                txtStatusName.Text = "";
            }
        }

        int _lastselectedrowindex = 0;
        SpeciesStatu SelectedStatus;
        private void dgStatus_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgStatus.SelectedRows[0].Cells[0].Value.ToString());
                _lastselectedrowindex = dgStatus.SelectedRows[0].Index;
                SelectStatus(id);
            }
            catch { }


        }

        private void SelectStatus(int id)
        {
            try
            {
                SelectedStatus = StatusDataAccess.GetStatusById(id);
                txtStatusName.Text = SelectedStatus.StatusText;
                txtStatusId.Text = SelectedStatus.StatusId.ToString();
            }
            catch { }
        }

        private void dgStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgStatus.Rows[e.RowIndex].Cells[0].Value.ToString());
                _lastselectedrowindex = dgStatus.Rows[e.RowIndex].Index;
                SelectStatus(id);
            }
        }

        private void tmrClearMsg_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }
    }
}
