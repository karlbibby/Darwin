using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Darwin.Enum;
using Darwin.DataAccess;

namespace Darwin.WindowsForm
{
    public partial class SpecialSearch : Form
    {
        SearchType _t;
        public SpecialSearch(SearchType t)
        {
            _t = t;
            InitializeComponent();
        }

        private void SpecialSearch_Load(object sender, EventArgs e)
        {

            switch (_t)
            {
                case SearchType.Normal:
                    break;
                case SearchType.BlankLocation:
                    break;
                case SearchType.BlankSeason:
                    break;
                case SearchType.BlankColour:
                    break;
                case SearchType.BlankStatus:
                    break;
                case SearchType.UnusedGenus:
                    dataGridView1.DataSource = GenusDataAccess.GetUnsedGenus();
                    break;
                case SearchType.UnusedOrder:
                    dataGridView1.DataSource = OrderDataAccess.GetUnusedOrder();

                    break;
                case SearchType.UnusedFamily:
                    dataGridView1.DataSource = FamilyDataAccess.GetUnusedFamily();
                    break;
                default:
                    break;
            }
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 300;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string val = "";
            int ival = 0, fam = 0;
            if (e.RowIndex > -1)
            {
                
                switch (_t)
                {
                    case SearchType.Normal:
                        break;
                    case SearchType.BlankLocation:
                        break;
                    case SearchType.BlankSeason:
                        break;
                    case SearchType.BlankColour:
                        break;
                    case SearchType.BlankStatus:
                        break;
                    case SearchType.UnusedGenus:

                        val = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        ival = int.Parse(val);
                        fam = (int)GenusDataAccess.GetGenusById(ival).FamilyId;
                        GenusSetup g = new GenusSetup(fam);
                        g.Show(this);

                        break;
                    case SearchType.UnusedOrder:

                        val = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        ival = int.Parse(val);
                        fam = (int)OrderDataAccess.GetOrderById(ival).ClassId;
                        OrderSetup o = new OrderSetup(fam);
                        o.Show(this);

                        break;
                    case SearchType.UnusedFamily:

                        val = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        ival = int.Parse(val);
                        fam = (int)FamilyDataAccess.GetFamilyById(ival).OrderId;
                        FamilySetup f = new FamilySetup(fam);
                        f.Show(this);

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
