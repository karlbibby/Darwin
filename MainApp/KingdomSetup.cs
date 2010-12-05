using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Darwin.DataAccess;

namespace Darwin.WindowsForm
{
    public partial class KingdomSetup : Form
    {
        public KingdomSetup()
        {
            InitializeComponent();
        }

        private int _lastselectedrowindex;
        private Kingdom SelectedKingdom;

        private void SystemSetup_Load(object sender, EventArgs e)
        {
            LoadData();
            try

            {
                int id = int.Parse(dgKingdom.Rows[0].Cells[0].Value.ToString());
                SelectKingdom(id);
            }
            catch { }
        }

        private void LoadData()
        { 
            dgKingdom.DataSource = KingdomDataAccess.GetAllKingdoms();
            dgKingdom.Columns[0].Width = 40;
            dgKingdom.Columns[1].Width = 300;
        }

        private void dgKingdom_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgKingdom.SelectedRows[0].Cells[0].Value.ToString());
                _lastselectedrowindex = dgKingdom.SelectedRows[0].Index;
                SelectKingdom(id);
            }
            catch { }
           
        
        }

        private void SelectKingdom(int id)
        {
            try
            {
                SelectedKingdom = KingdomDataAccess.GetKingdomById(id);
                txtKingdomName.Text = SelectedKingdom.KingdomName;
                txtKingdomId.Text = SelectedKingdom.KingdomId.ToString();
                btnPhylums.Enabled = true;
            }
            catch { }
        }

        

        private void dgKingdom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgKingdom.Rows[e.RowIndex].Cells[0].Value.ToString());
                _lastselectedrowindex = dgKingdom.Rows[e.RowIndex].Index;
                SelectKingdom(id);
            }
        }

        private void btnPhylums_Click(object sender, EventArgs e)
        {
            PhylumSetup p = new PhylumSetup(txtKingdomId.Text);
            p.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedKingdom.KingdomName = txtKingdomName.Text;
           

            int rowsAffected = KingdomDataAccess.SaveKingdom(SelectedKingdom); ;
            lblMessage.Text =  rowsAffected.ToString() + " changes made to the table";
            tmrClearMsg.Start();

            LoadData(); 
            
            int id = int.Parse(dgKingdom.Rows[0].Cells[0].Value.ToString());
            SelectKingdom(id);
            foreach (DataGridViewRow item in dgKingdom.Rows)
            {
                item.Selected = false;
              
            }
            dgKingdom.CurrentCell = dgKingdom.Rows[_lastselectedrowindex].Cells[0];
            dgKingdom.Rows[_lastselectedrowindex].Selected = true;
       
           
        }

        private void tmrClearMsg_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int changes = KingdomDataAccess.AddNewKingdom();
                lblMessage.Text = changes.ToString() + " changes made to the table";
                tmrClearMsg.Start();
                LoadData();
                dgKingdom.CurrentCell = dgKingdom.Rows[dgKingdom.Rows.Count-1].Cells[0];
                dgKingdom.Rows[0].Selected = true;
                txtKingdomName.Focus();
         
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (KingdomDataAccess.DeleteKingdom(SelectedKingdom) == false)
            {
                MessageBox.Show("Cannot delete, child nodes still exist", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            SelectedKingdom = null;
            LoadData();
            try
            {
                dgKingdom.CurrentCell = dgKingdom.Rows[0].Cells[0];
                dgKingdom.Rows[0].Selected = true;
            }
            catch
            {
                btnPhylums.Enabled = false;
                txtKingdomId.Text = "";
                txtKingdomName.Text = "";
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
