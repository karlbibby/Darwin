using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Darwin.DataAccess;
using Darwin.Objects;


namespace Darwin.WindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
   
        private DataStoreEntities d;

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.Width = 650;

            string strVersion = "";


            try
            {
                System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                strVersion = ad.CurrentVersion.ToString();
            }
            catch { }

            

            this.Text += strVersion;
            try{
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Darwin\");
            }
            catch{};

            
            
            d = new DataStoreEntities();
            LoadData();

        
        }

        private void LoadData()
        {
            FillStatus();
            FillKingdom();
        }

        private void FillStatus()
        {
            cbStatus.DataSource = StatusDataAccess.GetAllStatus();
            cbStatus.DisplayMember = "StatusText";
            cbStatus.ValueMember = "StatusId";
            cbStatus.SelectedIndex = -1;
        }
  
        private void btnSystemSetup_Click(object sender, EventArgs e)
        {
            KingdomSetup s = new KingdomSetup();
            s.Show();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            d = null;
            d = new DataStoreEntities();
            txtAnySearch.Text = "";
            txtName.Text = "";
            cbKingdom.SelectedIndex = -1;
            monthPicker1.UncheckAll();
            speciesFlags1.UncheckAll();
            distributionPicker1.UncheckAll();
            speciesColourUC1.SetSelectedColour(0);
            cbYVP.Checked = false;
            LoadData();
        }






        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            SpeciesData d = new SpeciesData();
            d.StartPosition = FormStartPosition.CenterScreen;
            d.Show();
        }

        private DataStoreEntities DataAccessLayer;

        private void FillKingdom()
        {
            cbKingdom.SelectedIndex = -1;

            if (DataAccessLayer == null) DataAccessLayer = new DataStoreEntities();
            var lqKingdom = from k in DataAccessLayer.Kingdoms
                            orderby k.KingdomName.ToLower()
                            select k;
            //cbKingdom.Items.Add("");
            cbKingdom.DataSource = lqKingdom;
            cbKingdom.DisplayMember = "KingdomName";
            cbKingdom.ValueMember = "KingdomId";
            cbKingdom.SelectedIndex = -1;
        }

        private void cbKingdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbFamily.SelectedIndexChanged -= new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            this.cbOrder.SelectedIndexChanged -= new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            this.cbClass.SelectedIndexChanged -= new System.EventHandler(this.cbClass_SelectedIndexChanged);
            this.cbPhylum.SelectedIndexChanged -= new System.EventHandler(this.cbPhylum_SelectedIndexChanged);

            cbGenus.DataSource = null;
            cbFamily.DataSource = null;
            cbOrder.DataSource = null;
            cbClass.DataSource = null;
            cbPhylum.DataSource = null;

            cbPhylum.Items.Clear();
            cbPhylum.SelectedIndex = -1;
          

            try
            {
                if (DataAccessLayer == null) DataAccessLayer = new DataStoreEntities();

                var k = from s in DataAccessLayer.Phyla
                        orderby s.PhylumName
                        where s.KingdomId == (int)cbKingdom.SelectedValue
                        select new { s.PhylumId, s.PhylumName }
                     ;
                //cbPhylum.Items.Add("");
                cbPhylum.DisplayMember = "PhylumName";
                cbPhylum.ValueMember = "PhylumId";
                cbPhylum.DataSource = k;
                cbPhylum.SelectedIndex = -1;
            }
            catch { }

            this.cbPhylum.SelectedIndexChanged += new System.EventHandler(this.cbPhylum_SelectedIndexChanged);


        }

        private void cbPhylum_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cbFamily.SelectedIndexChanged -= new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            this.cbOrder.SelectedIndexChanged -= new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            this.cbClass.SelectedIndexChanged -= new System.EventHandler(this.cbClass_SelectedIndexChanged);
            cbGenus.DataSource = null;
            cbFamily.DataSource = null;
            cbOrder.DataSource = null;
            cbClass.DataSource = null;
            cbClass.Items.Clear();
            cbClass.SelectedIndex = -1;

            try
            {
                if (DataAccessLayer == null) DataAccessLayer = new DataStoreEntities();

                var k = from s in DataAccessLayer.Classes
                        orderby s.ClassName
                        where s.PhylumId == (int)cbPhylum.SelectedValue
                        select new { s.ClassId, s.ClassName }
                     ;
                cbClass.DisplayMember = "ClassName";
                cbClass.ValueMember = "ClassId";
                cbClass.DataSource = k;
                cbClass.SelectedIndex = -1;
            }
            catch { }
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);

        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbFamily.SelectedIndexChanged -= new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            this.cbOrder.SelectedIndexChanged -= new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            cbGenus.DataSource = null;
            cbFamily.DataSource = null;
            cbOrder.DataSource = null;
            cbOrder.Items.Clear();
            cbOrder.SelectedIndex = -1;

            try
            {
                if (DataAccessLayer == null) DataAccessLayer = new DataStoreEntities();

                var k = from s in DataAccessLayer.Orders
                        orderby s.OrderName
                        where s.ClassId == (int)cbClass.SelectedValue
                        select new { s.OrderId, s.OrderName }
                     ;
                cbOrder.DisplayMember = "OrderName";
                cbOrder.ValueMember = "OrderId";
                cbOrder.DataSource = k;
                cbOrder.SelectedIndex = -1;
            }
            catch { }

            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);

        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbFamily.SelectedIndexChanged -= new System.EventHandler(this.cbFamily_SelectedIndexChanged);

            cbGenus.DataSource = null;
            cbFamily.DataSource = null;
            cbFamily.Items.Clear();
            cbFamily.SelectedIndex = -1;

            try
            {
                if (DataAccessLayer == null) DataAccessLayer = new DataStoreEntities();

                var k = from s in DataAccessLayer.Families
                        orderby s.FamilyName
                        where s.OrderId == (int)cbOrder.SelectedValue
                        select new { s.FamilyId, s.FamilyName }
                     ;
                cbFamily.DisplayMember = "FamilyName";
                cbFamily.ValueMember = "FamilyId";
                cbFamily.DataSource = k;
                cbFamily.SelectedIndex = -1;

            }
            catch { }
            this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.cbFamily_SelectedIndexChanged);

        }

        private void cbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGenus.DataSource = null;
            cbGenus.Items.Clear();
            cbGenus.SelectedIndex = -1;

            try
            {
                if (DataAccessLayer == null) DataAccessLayer = new DataStoreEntities();

                var k = from s in DataAccessLayer.Genuss
                        orderby s.GenusName
                        where s.FamilyId == (int)cbFamily.SelectedValue
                        select new { s.GenusId, s.GenusName }
                     ;
                cbGenus.DisplayMember = "GenusName";
                cbGenus.ValueMember = "GenusId";
                cbGenus.DataSource = k;
                cbGenus.SelectedIndex = -1;

            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StartSearch();

        }

        private void StartSearch(Darwin.Enum.SearchType t = Enum.SearchType.Normal)
        {
            int statusin = -1;
            try
            {
                statusin = Int32.Parse(cbStatus.SelectedValue.ToString());
            }
            catch { }
            
            SearchResults s = new SearchResults(t, cbKingdom.SelectedValue, cbPhylum.SelectedValue, cbClass.SelectedValue, cbOrder.SelectedValue, cbFamily.SelectedValue, cbGenus.SelectedValue, txtName.Text, txtAnySearch.Text, monthPicker1.GetMonthsInformation(), speciesFlags1.GetSpeciesInformation(), distributionPicker1.GetDistributionInformation(), speciesColourUC1.GetSelectedColour(), cbYVP.Checked, statusin);
            s.StartPosition = FormStartPosition.CenterScreen;
            s.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Stats s = new Stats();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusSetup s = new StatusSetup();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                Darwin.Export.XMLExporter.ExportToMindMap(saveFileDialog1.FileName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (this.Width == 650)
            {
                this.Width = 880;
                lblbigsmall.Text = "<";
            }
            else
            {
                this.Width = 650;
                lblbigsmall.Text = ">";
            }
        }

        private void btnNoLocation_Click(object sender, EventArgs e)
        {
            StartSearch(Enum.SearchType.BlankLocation);
        }

        private void btnNoSeason_Click(object sender, EventArgs e)
        {
            StartSearch(Enum.SearchType.BlankSeason);

        }

        private void btnNoColour_Click(object sender, EventArgs e)
        {
            StartSearch(Enum.SearchType.BlankColour);

        }

        private void btnNoStatus_Click(object sender, EventArgs e)
        {
            StartSearch(Enum.SearchType.BlankStatus);
        }

        private void btnUnusedGenus_Click(object sender, EventArgs e)
        {
            OpenSpecialSearch(Enum.SearchType.UnusedGenus);
        }

        private void OpenSpecialSearch(Enum.SearchType t)
        {
            SpecialSearch s = new SpecialSearch(t);
            s.StartPosition = FormStartPosition.CenterParent;
            s.ShowDialog(this);
        }

        private void btnunusedfam_Click(object sender, EventArgs e)
        {
            OpenSpecialSearch(Enum.SearchType.UnusedFamily);

        }

        private void btnunsedorder_Click(object sender, EventArgs e)
        {
            OpenSpecialSearch(Enum.SearchType.UnusedOrder);

        }


      
    }
}
