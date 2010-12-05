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
    public partial class FamilySetup : Form
    {
        private int _OrderId;
        public FamilySetup(int OrderId)
        {
            _OrderId = OrderId;
            InitializeComponent();

        }
        private int _lastselectedrowindex;
        private Family SelectedFamily;

        private void FamilySetup_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = _OrderId.ToString();
            LoadData();
            try
            {
                int id = int.Parse(dgFamilys.Rows[0].Cells[0].Value.ToString());
                SelectFamily(id);
            }
            catch { }
        }

        private void LoadData()
        {
           
            dgFamilys.DataSource = FamilyDataAccess.GetFamiliesByOrder(_OrderId);
            dgFamilys.Columns[0].Width = 40;
            dgFamilys.Columns[1].Width = 300;

            try
            {
                Order o = OrderDataAccess.GetOrderById(_OrderId);
                string OrderName = o.OrderName;
                string ClassName = o.Class.ClassName;
                string PhylumName = o.Class.Phylum.PhylumName;
                string KingdomName = o.Class.Phylum.Kingdom.KingdomName;
                this.Text = "Family Setup - " + KingdomName + " - " + PhylumName + " - " + ClassName + " - " + OrderName;
                lblParentInfo.Text = KingdomName + "\n" + PhylumName + "\n" + ClassName + "\n" + OrderName;
            }
            catch { }
        }

        private void SelectFamily(int id)
        {
            try
            {
                SelectedFamily = FamilyDataAccess.GetFamilyById(id);
                txtFamilyName.Text = SelectedFamily.FamilyName;
                txtFamilyId.Text = SelectedFamily.FamilyId.ToString();
                if (SelectedFamily.Notes != null)
                {
                    txtNotes.Text = SelectedFamily.Notes.ToString();
                }
                else
                {
                    txtNotes.Text = "";
                }
                btnGenus.Enabled = true;
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedFamily.Notes = txtNotes.Text;
            SelectedFamily.FamilyName = txtFamilyName.Text;
            int rowsAffected = FamilyDataAccess.SaveFamily(SelectedFamily);
            lblMessage.Text = rowsAffected.ToString() + " changes made to the table";
            tmrClearMsg.Start();

            LoadData();

            int id = int.Parse(dgFamilys.Rows[0].Cells[0].Value.ToString());
            SelectFamily(id);
            foreach (DataGridViewRow item in dgFamilys.Rows)
            {
                item.Selected = false;

            }
            dgFamilys.CurrentCell = dgFamilys.Rows[_lastselectedrowindex].Cells[0];
            dgFamilys.Rows[_lastselectedrowindex].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FamilyDataAccess.DeleteFamily(SelectedFamily) == false)
            {
                MessageBox.Show("Cannot delete, child nodes still exist", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SelectedFamily = null;
            LoadData();
            try
            {
                dgFamilys.CurrentCell = dgFamilys.Rows[0].Cells[0];
                dgFamilys.Rows[0].Selected = true;
            }
            catch
            {
                btnGenus.Enabled = false;
                txtFamilyId.Text = "";
                txtFamilyName.Text = "";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            int changes = FamilyDataAccess.AddNewFamily(_OrderId);
            lblMessage.Text = changes.ToString() + " changes made to the table";
            tmrClearMsg.Start();
            LoadData();
            dgFamilys.CurrentCell = dgFamilys.Rows[dgFamilys.Rows.Count - 1].Cells[0];
            dgFamilys.Rows[0].Selected = true;
            txtFamilyName.Focus();
        }

        private void btnGenus_Click(object sender, EventArgs e)
        {
            GenusSetup g = new GenusSetup(SelectedFamily.FamilyId);
            g.Show();
        }

        private void tmrClearMsg_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void dgFamilys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgFamilys.Rows[e.RowIndex].Cells[0].Value.ToString());
                _lastselectedrowindex = dgFamilys.Rows[e.RowIndex].Index;
                SelectFamily(id);
            }
        }

        private void dgFamilys_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(dgFamilys.SelectedRows[0].Cells[0].Value.ToString());
                _lastselectedrowindex = dgFamilys.SelectedRows[0].Index;
                SelectFamily(id);
            }
            catch { }
        }


  

 





   

        






    }
}
