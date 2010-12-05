using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Darwin.DataAccess;

namespace Darwin.WindowsForm
{
    public partial class MapView : Form
    {
        private int _SpeciesId = 0;
        public MapView(int speciesid)
        {
            _SpeciesId = speciesid;
            InitializeComponent();
        }

        private void MapView_Load(object sender, EventArgs e)
        {
        }
        
        private void panel1__DoubleClick(object sender, EventArgs e)
        {

            Image i = global::DarwinResources.Properties.Resources._01;
            int easting = 0, northing = 0;
            switch (square)
            {
                case 1:
                    i = global::DarwinResources.Properties.Resources._01;
                    break;
                case 2:
                    i = global::DarwinResources.Properties.Resources._02;
                    break;
                case 3:
                    i = global::DarwinResources.Properties.Resources._03;
                    break;
                case 4:
                    i = global::DarwinResources.Properties.Resources._04;
                    break;
                case 5:
                    i = global::DarwinResources.Properties.Resources._05;
                    break;
                case 6:
                    i = global::DarwinResources.Properties.Resources._06;
                    break;
                case 7:
                    i = global::DarwinResources.Properties.Resources._07;
                    break;
                case 8:
                    i = global::DarwinResources.Properties.Resources._08;
                    break;
                case 9:
                    i = global::DarwinResources.Properties.Resources._09;
                    break;
                case 10:
                    i = global::DarwinResources.Properties.Resources._10;
                    break;
                case 11:
                    i = global::DarwinResources.Properties.Resources._11;
                    break;
                case 12:
                    i = global::DarwinResources.Properties.Resources._12;
                    break;
                case 13:
                    i = global::DarwinResources.Properties.Resources._13;
                    break;
                case 14:
                    i = global::DarwinResources.Properties.Resources._14;
                    break;
                case 15:
                    i = global::DarwinResources.Properties.Resources._15;
                    break;
                case 16:
                    i = global::DarwinResources.Properties.Resources._16;
                    break;
                case 17:
                    i = global::DarwinResources.Properties.Resources._17;
                    break;
                case 18:
                    i = global::DarwinResources.Properties.Resources._18;
                    break;
                case 19:
                    i = global::DarwinResources.Properties.Resources._19;
                    break;
                case 20:
                    i = global::DarwinResources.Properties.Resources._20;
                    break;
                case 21:
                    i = global::DarwinResources.Properties.Resources._21;
                    break;
                case 22:
                    i = global::DarwinResources.Properties.Resources._22;
                    break;
                case 23:
                    i = global::DarwinResources.Properties.Resources._23;
                    break;
                case 24:
                    i = global::DarwinResources.Properties.Resources._24;
                    break;
                case 25:
                    i = global::DarwinResources.Properties.Resources._25;
                    break;
                case 26:
                    i = global::DarwinResources.Properties.Resources._26;
                    break;
                case 27:
                    i = global::DarwinResources.Properties.Resources._27;
                    break;
                case 28:
                    i = global::DarwinResources.Properties.Resources._28;
                    break;
                case 29:
                    i = global::DarwinResources.Properties.Resources._29;
                    break;
                case 30:
                    i = global::DarwinResources.Properties.Resources._30;
                    break;
                case 31:
                    i = global::DarwinResources.Properties.Resources._31;
                    break;
                case 32:
                    i = global::DarwinResources.Properties.Resources._32;
                    break;
                case 33:
                    i = global::DarwinResources.Properties.Resources._33;
                    break;
                case 34:
                    i = global::DarwinResources.Properties.Resources._34;
                    break;
                case 35:
                    i = global::DarwinResources.Properties.Resources._35;
                    break;
                case 36:
                    i = global::DarwinResources.Properties.Resources._36;
                    break;

                default:
                    i = global::DarwinResources.Properties.Resources._01;
                    break;
            }
            switch (square % 6)
            {
                case 1:
                    easting = 3560;
                    break;
                case 2:
                    easting = 3570;
                    break;
                case 3:
                    easting = 3580;
                    break;
                case 4:
                    easting = 3590;
                    break;
                case 5:
                    easting = 3600;
                    break;
                case 0:
                    easting = 3610;
                    break;
                default:
                    easting = 0;
                    break;
            }
            int second = 0;
            int tens = 0;
            northing = 4190;
            for (int io = 0; io < 37; io++)
            {
                if (io == square) break;
                second++;
                northing = 4190 - tens;

                if ((second % 6) == 0)
                {
                    tens += 10;
                }

            }

            MapSingleTileView s = new MapSingleTileView(i, _SpeciesId, easting, northing);
            s.StartPosition = FormStartPosition.CenterScreen;
            s.Show(this);
        }


        Point ulCorner = new Point(0, 0);
        int square = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ulCorner.X = ((MouseEventArgs)e).X - 30;

            ulCorner.Y = ((MouseEventArgs)e).Y - 54;

            square = CalculateSquare(e.X, e.Y);
        }

        private int CalculateSquare(int X, int Y)
        {
            int row = 6, col = 6;
            int square = 0;

            if (X < 825) row = 5;
            if (X < 660) row = 4;
            if (X < 495) row = 3;
            if (X < 330) row = 2;
            if (X < 165) row = 1;

            if (Y < 825) col = 5;
            if (Y < 660) col = 4;
            if (Y < 495) col = 3;
            if (Y < 330) col = 2;
            if (Y < 165) col = 1;

            square = row + ((col - 1) * 6);
            return square;
        }

        private void DrawMap()
        {
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._01, 0, 0, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._02, 165, 0, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._03, 330, 0, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._04, 495, 0, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._05, 660, 0, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._06, 825, 0, 165, 165);

            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._07, 0, 165, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._08, 165, 165, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._09, 330, 165, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._10, 495, 165, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._11, 660, 165, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._12, 825, 165, 165, 165);

            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._13, 0, 330, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._14, 165, 330, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._15, 330, 330, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._16, 495, 330, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._17, 660, 330, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._18, 825, 330, 165, 165);

            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._19, 0, 495, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._20, 165, 495, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._21, 330, 495, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._22, 495, 495, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._23, 660, 495, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._24, 825, 495, 165, 165);

            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._25, 0, 660, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._26, 165, 660, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._27, 330, 660, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._28, 495, 660, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._29, 660, 660, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._30, 825, 660, 165, 165);

            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._31, 0, 825, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._32, 165, 825, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._33, 330, 825, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._34, 495, 825, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._35, 660, 825, 165, 165);
            panel1.CreateGraphics().DrawImage(global::DarwinResources.Properties.Resources._36, 825, 825, 165, 165);

            DrawPins();

        }

        private void DrawPins()
        {

            Image i = global::DarwinResources.Properties.Resources.spot;

            IEnumerable<TranslatedMapRef> x = SpeciesDataAccess.GetTranslatedMapReferences(_SpeciesId, 982);
            foreach (var item in x)
            {
                Point p = new Point(Int32.Parse(item.MapTranslatedX.ToString()) + 2, 984 - Int32.Parse(item.MapTranslatedY.ToString()) + 2);
                panel1.CreateGraphics().DrawImage(i, p);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawMap();
        }


    }
}
