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
    public partial class ClassSetup : Form
    {
        private int _phylumId;
        public ClassSetup(int PhylumId)
        {
            _phylumId = PhylumId;
            InitializeComponent();

        }
        private int _lastselectedrowindex;
        
        private Class SelectedClass;

        private void ClassSetup_Load(object sender, EventArgs e)
        {
            txtPhylumId.Text = _phylumId.ToString();
            LoadData();
            try
            {
                int id = int.Parse(dgClasss.Rows[0].Cells[0].Value.ToString());
                SelectClass(id);
            }
            catch { }
        }

        private void LoadData()
        {
         
            dgClasss.DataSource = ClassDataAccess.GetClasssByPhylum(_phylumId);
            dgClasss.Columns[0].Width = 40;
            dgClasss.Columns[1].Width = 300;

            try
            {
                Phylum p = PhylumDataAccess.GetPhylumById(_phylumId);
                string PhylumName = p.PhylumName;
                string KingdomName = p.Kingdom.KingdomName;

                this.Text = "Class Setup - " + KingdomName + " - " + PhylumName;
                lblParentInfo.Text = KingdomName + "\n" + PhylumName;
            }
            catch { }
        }

        private void SelectClass(int id)
        {
            try
            {
                SelectedClass = ClassDataAccess.GetClassById(id);
                txtClassName.Text = SelectedClass.ClassName;
                txtClassId.Text = SelectedClass.ClassId.ToString();
                btnOrders.Enabled = true;
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedClass.ClassName = txtClassName.Text;
            int rowsAffected = ClassDataAccess.SaveClass(SelectedClass);
            lblMessage.Text = rowsAffected.ToString() + " changes made to the table";
            tmrClearMsg.Start();

            LoadData();

            int id = int.Parse(dgClasss.Rows[0].Cells[0].Value.ToString());
            SelectClass(id);
            foreach (DataGridViewRow item in dgClasss.Rows)
            {
                item.Selected = false;

            }
            dgClasss.CurrentCell = dgClasss.Rows[_lastselectedrowindex].Cells[0];
            dgClasss.Rows[_lastselectedrowindex].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ClassDataAccess.DeleteClass(SelectedClass) == false)
            {
                MessageBox.Show("Cannot delete, child nodes still exist", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SelectedClass = null;
            LoadData();
            try
            {
                dgClasss.CurrentCell = dgClasss.Rows[0].Cells[0];
                dgClasss.Rows[0].Selected = true;
            }
            catch
            {
                btnOrders.Enabled = false;
                txtClassId.Text = "";
                txtClassName.Text = "";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            int changes = ClassDataAccess.AddNewClass(_phylumId);
            lblMessage.Text = changes.ToString() + " changes made to the table";
            tmrClearMsg.Start();
            LoadData();
            dgClasss.CurrentCell = dgClasss.Rows[dgClasss.Rows.Count - 1].Cells[0];
            dgClasss.Rows[0].Selected = true;
            txtClassName.Focus();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            OrderSetup c = new OrderSetup(SelectedClass.ClassId);
            c.Show();
        }

        private void tmrClearMsg_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void dgClasss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgClasss.Rows[e.RowIndex].Cells[0].Value.ToString());
                _lastselectedrowindex = dgClasss.Rows[e.RowIndex].Index;
                SelectClass(id);
            }
        }

        private void dgClasss_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(dgClasss.SelectedRows[0].Cells[0].Value.ToString());
                _lastselectedrowindex = dgClasss.SelectedRows[0].Index;
                SelectClass(id);
            }
            catch { }
        }

      

 


        


    }
}
