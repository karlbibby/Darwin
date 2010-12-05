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
    public partial class OrderSetup : Form
    {
        private int _ClassId;
        public OrderSetup(int ClassId)
        {
            _ClassId = ClassId;
            InitializeComponent();

        }
        private int _lastselectedrowindex;
        private Order SelectedOrder;

        private void OrderSetup_Load(object sender, EventArgs e)
        {
            txtClassId.Text = _ClassId.ToString();
            LoadData();
            try
            {
                int id = int.Parse(dgOrders.Rows[0].Cells[0].Value.ToString());
                SelectOrder(id);
            }
            catch { }
        }

        private void LoadData()
        {
            dgOrders.DataSource = OrderDataAccess.GetOrdersByClass(_ClassId);
            dgOrders.Columns[0].Width = 40;
            dgOrders.Columns[1].Width = 300;


            try
            {
                Class c = ClassDataAccess.GetClassById(_ClassId);
                string ClassName = c.ClassName;
                string PhylumName = c.Phylum.PhylumName;
                string KingdomName = c.Phylum.Kingdom.KingdomName;

                this.Text = "Order Setup - " + KingdomName + " - " + PhylumName + " - " + ClassName;
                lblParentInfo.Text = KingdomName + "\n" + PhylumName + "\n" + ClassName;
            }
            catch { }

        }

        private void SelectOrder(int id)
        {
            try
            {
                SelectedOrder = OrderDataAccess.GetOrderById(id);
                txtOrderName.Text = SelectedOrder.OrderName;
                txtOrderId.Text = SelectedOrder.OrderId.ToString();
                txtNumberinOrder.Text = SelectedOrder.NumberInOrder.ToString();
                txtNotes.Text = SelectedOrder.Notes;
                btnFamily.Enabled = true;
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedOrder.OrderName = txtOrderName.Text;
            SelectedOrder.Notes = txtNotes.Text;
            try
            {
                SelectedOrder.NumberInOrder = Int32.Parse(txtNumberinOrder.Text);
            }
            catch
            {
                SelectedOrder.NumberInOrder = 0;
            }
            int rowsAffected = OrderDataAccess.SaveOrder(SelectedOrder);
            lblMessage.Text = rowsAffected.ToString() + " changes made to the table";
            tmrClearMsg.Start();

            LoadData();

            int id = int.Parse(dgOrders.Rows[0].Cells[0].Value.ToString());
            SelectOrder(id);
            foreach (DataGridViewRow item in dgOrders.Rows)
            {
                item.Selected = false;

            }
            dgOrders.CurrentCell = dgOrders.Rows[_lastselectedrowindex].Cells[0];
            dgOrders.Rows[_lastselectedrowindex].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OrderDataAccess.DeleteOrder(SelectedOrder) == false)
            {
                MessageBox.Show("Cannot delete, child nodes still exist", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SelectedOrder = null;
            LoadData();
            try
            {
                dgOrders.CurrentCell = dgOrders.Rows[0].Cells[0];
                dgOrders.Rows[0].Selected = true;
            }
            catch
            {
                btnFamily.Enabled = false;
                txtOrderId.Text = "";
                txtOrderName.Text = "";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            int changes = OrderDataAccess.AddNewOrder(_ClassId);
            lblMessage.Text = changes.ToString() + " changes made to the table";
            tmrClearMsg.Start();
            LoadData();
            dgOrders.CurrentCell = dgOrders.Rows[dgOrders.Rows.Count - 1].Cells[0];
            dgOrders.Rows[0].Selected = true;
            txtOrderName.Focus();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            FamilySetup f = new FamilySetup(SelectedOrder.OrderId);
            f.Show();
        }

        private void tmrClearMsg_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void dgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
                _lastselectedrowindex = dgOrders.Rows[e.RowIndex].Index;
                SelectOrder(id);
            }
        }

        private void dgOrders_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(dgOrders.SelectedRows[0].Cells[0].Value.ToString());
                _lastselectedrowindex = dgOrders.SelectedRows[0].Index;
                SelectOrder(id);
            }
            catch { }
        }

    }
}
