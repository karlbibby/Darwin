using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Darwin.DataAccess;
using Darwin.Enum;

namespace Darwin.WindowsForm
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            AddKingdomToTree();
        }

        private void AddKingdomToTree()
        {
            IEnumerable<KingdomDataGrid> k = KingdomDataAccess.GetAllKingdoms();
            int ctr = 0;
            foreach (KingdomDataGrid item in k)
            {
                treeView1.Nodes.Add(item.KingdomId.ToString(), item.KingdomName + " [" + SpeciesDataAccess.CountSpecies(TreeOfLiveType.Kingdom, item.KingdomId) + "]");
                AddPhylumToTree(treeView1.Nodes[ctr], item.KingdomId, true);
                ctr++;
            }
        }

        private void AddPhylumToTree(TreeNode treeNode, int kindomid, bool loadnext = false)
        {
            IEnumerable<PhylumDataGrid> k = PhylumDataAccess.GetPhylumsByKingdom(kindomid);
            int ctr = 0;
            foreach (PhylumDataGrid item in k)
            {
                treeNode.Nodes.Add(item.PhylumId.ToString(), item.PhylumName + " [" + SpeciesDataAccess.CountSpecies(TreeOfLiveType.Phylum, item.PhylumId) + "]");
                if (loadnext) AddClassToTree(treeNode.Nodes[ctr], item.PhylumId);
                ctr++;
            }
        }
        private void AddClassToTree(TreeNode treeNode, int phylumid, bool loadnext = false)
        {
            int ctr = 0;
            IEnumerable<ClassDataGrid> k = ClassDataAccess.GetClasssByPhylum(phylumid);

            foreach (ClassDataGrid item in k)
            {
                treeNode.Nodes.Add(item.ClassId.ToString(), item.ClassName + " [" + SpeciesDataAccess.CountSpecies(TreeOfLiveType.Class, item.ClassId) + "]");
                if (loadnext) AddOrderToTree(treeNode.Nodes[ctr], item.ClassId);
                ctr++;
            }
        }

        private void AddOrderToTree(TreeNode treeNode, int classid, bool loadnext = false)
        {
            int ctr = 0;
            IEnumerable<OrderDataGrid> k = OrderDataAccess.GetOrdersByClass(classid);

            foreach (OrderDataGrid item in k)
            {
                treeNode.Nodes.Add(item.OrderId.ToString(), item.OrderName + " [" + SpeciesDataAccess.CountSpecies(TreeOfLiveType.Order, item.OrderId) + "]");
                if (loadnext) AddFamilyToTree(treeNode.Nodes[ctr], item.OrderId);
                ctr++;
            }
        }

        private void AddFamilyToTree(TreeNode treeNode, int orderid, bool loadnext = false)
        {
            int ctr = 0;
            IEnumerable<FamilyDataGrid> k = FamilyDataAccess.GetFamiliesByOrder(orderid);

            foreach (FamilyDataGrid item in k)
            {
                treeNode.Nodes.Add(item.FamilyId.ToString(), item.FamilyName + " [" + SpeciesDataAccess.CountSpecies(TreeOfLiveType.Family, item.FamilyId) + "]");
                if (loadnext) AddGenusToTree(treeNode.Nodes[ctr], item.FamilyId);
                ctr++;
            }
        }
        private void AddGenusToTree(TreeNode treeNode, int familyid)
        {
            IEnumerable<GenusDataGrid> k = GenusDataAccess.GetGenusByFamily(familyid);

            foreach (GenusDataGrid item in k)
            {
                treeNode.Nodes.Add(item.GenusId.ToString(), item.GenusName + " [" + SpeciesDataAccess.CountSpecies(TreeOfLiveType.Genus, item.GenusId) + "]");
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            switch (e.Node.Level)
            {
                case 0:
                    e.Node.Nodes.Clear();
                    AddPhylumToTree(e.Node, int.Parse(e.Node.Name), true);
                    break;
                case 1:
                    e.Node.Nodes.Clear();
                    AddClassToTree(e.Node, int.Parse(e.Node.Name), true);
                    break;
                case 2:
                    e.Node.Nodes.Clear();
                    AddOrderToTree(e.Node, int.Parse(e.Node.Name), true);
                    break;
                case 3:
                    e.Node.Nodes.Clear();
                    AddFamilyToTree(e.Node, int.Parse(e.Node.Name), true);
                    break;
                case 4:
                    e.Node.Nodes.Clear();
                    AddGenusToTree(e.Node, int.Parse(e.Node.Name));
                    break;
                default:
                    break;

            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SearchResults s;
            SpeciesEnumFlags senf = new SpeciesEnumFlags();
            DistributionFlags df = new DistributionFlags();
            MonthEumFlags mef = new MonthEumFlags();
            SpeciesColour sc = new SpeciesColour();

            switch (e.Node.Level)
            {
                case 0:
                    s = new SearchResults(int.Parse(e.Node.Name), null, null, null, null, null, "", "", mef, senf, df, sc);
                    break;
                case 1:
                    s = new SearchResults(null,int.Parse(e.Node.Name),  null, null, null, null, "", "", mef, senf, df, sc);
                    break;
                case 2:
                    s = new SearchResults(null, null,int.Parse(e.Node.Name),  null, null, null, "", "", mef, senf, df, sc);
                    break;
                case 3:
                    s = new SearchResults(null, null, null,int.Parse(e.Node.Name),  null, null, "", "", mef, senf, df, sc);
                    break;
                case 4:
                    s = new SearchResults(null, null, null, null,int.Parse(e.Node.Name),  null, "", "", mef, senf, df, sc);
                    break;
                case 5:
                    s = new SearchResults(null, null, null, null, null,int.Parse(e.Node.Name),  "", "", mef, senf, df, sc);
                    break;
                default:
                    s = new SearchResults(null, null, null, null, null, null, "", "", mef, senf, df, sc);
                    break;
            }
            s.StartPosition = FormStartPosition.CenterScreen;
            s.Show(this);
        }
    }
}
