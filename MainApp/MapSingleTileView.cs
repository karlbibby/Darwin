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
    public partial class MapSingleTileView : Form
    {
        private Image _TileNumber;
        private int _SpeciesId = 0;
        private int _Easting = 0;
        private int _Northing = 0;
        public MapSingleTileView(Image tilenumber, int speciesid, int easting, int northing)
        {
            _TileNumber = tilenumber;
            _SpeciesId = speciesid;
            _Easting = easting * 100;
            _Northing = northing * 100;
            InitializeComponent();
        }

        private void MapSingleTileView_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
  ControlStyles.UserPaint |
  ControlStyles.AllPaintingInWmPaint,
  true);
        }

        private Point ulCorner = new Point();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMapRef();
            Redraw();
        }

        private void SaveMapRef()
        {
            int MapX = _Easting + ulCorner.X;
            int MapY = _Northing - ulCorner.Y;
            string Notes = cmNotes.Text;
            if (_NewPoint)
            {
                SpeciesDataAccess.AddMapReference(_SpeciesId, MapX, MapY, Notes);
                    
            }
            else
            {
                SpeciesDataAccess.SaveMapReference(_CurrentMapPoint, Notes);
            } 
            
            MessageBox.Show("Point saved at \n" + MapX.ToString() + " " + MapY.ToString());
        }

        private void Redraw()
        {
            Image i = global::DarwinResources.Properties.Resources.GreenMapPin;
            panel1.CreateGraphics().DrawImage(_TileNumber, new Point(0, 0));

            IList<MapRef> refs = SpeciesDataAccess.GetAllMapReferences(_SpeciesId);

            if (refs.Count() > 0)
            {
                foreach (MapRef item in refs)
                {
                    panel1.CreateGraphics().DrawImage(i, new Point(int.Parse((item.MapX - _Easting - 29).ToString()), int.Parse((_Northing - item.MapY - 54).ToString())));
                }

            }
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SpeciesDataAccess.DeleteMapReference(_CurrentMapPoint) + " map points deleted");
            Redraw();
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ulCorner.X = ((MouseEventArgs)e).X;
            ulCorner.Y = ((MouseEventArgs)e).Y;
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Redraw();
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmNotes.Text = "";
            _NewPoint = true;
            SaveMapRef();
            Redraw();
        }

        int checkVariance = 0;

        bool _NewPoint = true;
        int _CurrentMapPoint = 0;
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            cmNotes.Text = "";

            int checkX = ulCorner.X + _Easting;
            int checkY = _Northing - ulCorner.Y - 30;

            checkVariance = 17;
            int resultpoint = CheckForPoint(checkX, checkY);
            if (resultpoint > 0)
            {
                notesToolStripMenuItem.Text = "Notes";
                cmDelete.Enabled = true;
               
                _NewPoint = false;
                _CurrentMapPoint = resultpoint;
                LoadNotes();
            }
            else
            {
                notesToolStripMenuItem.Text = "New Point";
                cmDelete.Enabled = false;
                _NewPoint = true;
            }

        }
        private int CheckForPoint(int X, int Y)
        {
            return SpeciesDataAccess.GetMapReference(_SpeciesId, X, Y, checkVariance);
        }

        private void LoadNotes()
        {
            cmNotes.Text = SpeciesDataAccess.GetMapReferenceById(_CurrentMapPoint).Notes;
        }
    }
}
