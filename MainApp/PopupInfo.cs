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
    public partial class PopupInfo : Form
    {
        int _id = 0;
        TreeOfLiveType _type = new TreeOfLiveType();
        public PopupInfo(int id, TreeOfLiveType type)
        {
            _id = id;
            _type = type;
            InitializeComponent();
        }

        private void PopupInfo_Load(object sender, EventArgs e)
        {
            switch (_type)
            {
                case TreeOfLiveType.Species:
                    break;
                case TreeOfLiveType.Kingdom:
                    break;
                case TreeOfLiveType.Phylum:
                    break;
                case TreeOfLiveType.Class:
                    break;
                case TreeOfLiveType.Order:
                    LoadOrderInfo();
                    break;
                case TreeOfLiveType.Genus:
                    break;
                case TreeOfLiveType.Family:
                    LoadFamilyInfo();

                    break;
                default:
                    break;
            }
        }
        private void LoadOrderInfo()
        {
            try
            {
                Order o = OrderDataAccess.GetOrderById(_id);
                this.Text = o.OrderName;
                txtInfo.Text = o.Notes;

            }
            catch { txtInfo.Text = "No Notes"; }
        }
        private void LoadFamilyInfo()
        {
            try
            {
                Family o = FamilyDataAccess.GetFamilyById(_id);
                this.Text = o.FamilyName;
                txtInfo.Text = o.Notes;

            }
            catch { txtInfo.Text = "No Notes"; }
        }
    }
}
