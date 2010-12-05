using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Darwin.Objects;
using Darwin.DataAccess;
using Darwin.Enum;
using System.IO;

namespace Darwin.WindowsForm
{
    public partial class SearchResults : Form
    {
        private int? _Kingdom, _Phylum, _Class, _Order, _Family, _Genus;
        private int _Status;
        private string _Name, _AnyText;
        private MonthEumFlags _Seasons;
        private SpeciesEnumFlags _Flags;
        private DistributionFlags _DistFlags;
        private SpeciesColour _SpeciesColour;
        private SearchType _searchtype;
        private bool _inYVP = false;
        public SearchResults(SearchType _SearchType, object _kingdom, object _phylum, object _class, object _order, object _family, object _genus, string _name, string _anytext, MonthEumFlags _monthEumFlags, SpeciesEnumFlags _speciesEnumFlags, DistributionFlags _distFlags, SpeciesColour _speciesColour, bool inYVP = false, int _status = -1)
        {
            //_Kingdom = _kingdom;
            if (_kingdom != null) { _Kingdom = int.Parse(_kingdom.ToString()); } else { _Kingdom = null; };
            if (_phylum != null) { _Phylum = int.Parse(_phylum.ToString()); } else { _Phylum = null; };
            if (_class != null) { _Class = int.Parse(_class.ToString()); } else { _Class = null; };
            if (_order != null) { _Order = int.Parse(_order.ToString()); } else { _Order = null; };
            if (_family != null) { _Family = int.Parse(_family.ToString()); } else { _Family = null; };
            if (_genus != null) { _Genus = int.Parse(_genus.ToString()); } else { _Genus = null; };
            _Name = _name;
            _AnyText = _anytext;
            _Seasons = _monthEumFlags;
            _Flags = _speciesEnumFlags;
            _DistFlags = _distFlags;
            _SpeciesColour = _speciesColour;
            _inYVP = inYVP;
            _Status = _status;
            _searchtype = _SearchType;
            InitializeComponent();
        }
        public SearchResults(object _kingdom, object _phylum, object _class, object _order, object _family, object _genus, string _name, string _anytext, MonthEumFlags _monthEumFlags, SpeciesEnumFlags _speciesEnumFlags, DistributionFlags _distFlags, SpeciesColour _speciesColour, bool inYVP = false, int _status = -1) :
                        this (SearchType.Normal, _kingdom, _phylum, _class, _order, _family, _genus, _name, _anytext, _monthEumFlags, _speciesEnumFlags, _distFlags, _speciesColour, false, -1)
        {
        }

        private IEnumerable<SearchResultCollection> searchresults;
        IEnumerable<Species> MatchingSpecies;
        private int lastsort = -1;


        private void SearchResults_Load(object sender, EventArgs e)
        {
            if (SystemInformation.PrimaryMonitorSize.Height == 768)
            {
                this.Scale(new SizeF(0.7f, 0.7f));
            }
            MatchingSpecies = SpeciesDataAccess.GetAllSpecies();

            if (_Status != -1)
            {
                MatchingSpecies = SearchDataAccess.FilterByStatus(MatchingSpecies, _Status);
            }
            
            #region Filter Tree
            if (_Genus != null)
            {
                MatchingSpecies = SearchDataAccess.FilterByGenus(MatchingSpecies, _Genus);
            }
            else
            {
                if (_Family != null)
                {
                    MatchingSpecies = SearchDataAccess.FilterByFamily(MatchingSpecies, _Family);

                }
                else
                {
                    if (_Order != null)
                    {
                        MatchingSpecies = SearchDataAccess.FilterByOrder(MatchingSpecies, _Order);

                    }
                    else
                    {
                        if (_Class != null)
                        {
                            MatchingSpecies = SearchDataAccess.FilterByClass(MatchingSpecies, _Class);
                        }
                        else
                        {
                            if (_Phylum != null)
                            {
                                MatchingSpecies = SearchDataAccess.FilterByPhylum(MatchingSpecies, _Phylum);

                            }
                            else
                            {
                                if (_Kingdom != null)
                                {
                                    MatchingSpecies = SearchDataAccess.FilterByKingDom(MatchingSpecies, _Kingdom);

                                }
                            }
                        }

                    }
                }
            }
            #endregion

            if (_inYVP)
            {
                MatchingSpecies = SearchDataAccess.FilterByInYarrowVallyPark(MatchingSpecies, _inYVP);
            }

            if (_Name != null && _Name != "")
            {
                MatchingSpecies = SearchDataAccess.FilterByName(MatchingSpecies, _Name);
            }
            int f = _Flags.GetHashCode();
            if (f > 0)
            {
                MatchingSpecies = SearchDataAccess.FilterByFlag(MatchingSpecies, _Flags);
            }

            int m = _Seasons.GetHashCode();
            if (m > 0)
            {
                MatchingSpecies = SearchDataAccess.FilterBySeason(MatchingSpecies, _Seasons);
            }

            int dist = _DistFlags.GetHashCode();
            if (dist > 0)
            {
                MatchingSpecies = SearchDataAccess.FilterByDistribution(MatchingSpecies, _DistFlags);

            }

            if (_SpeciesColour > 0)
            {

                MatchingSpecies = SearchDataAccess.FilterByColour(MatchingSpecies, _SpeciesColour);

            }

            if (_AnyText != null && _AnyText != "")
            {
                MatchingSpecies = SearchDataAccess.FilterByText(MatchingSpecies, _AnyText);
            }

            switch (_searchtype)
            {
                case SearchType.Normal:
                    break;
                case SearchType.BlankLocation:
                    MatchingSpecies = SearchDataAccess.FilterToNoLocation(MatchingSpecies);

                    break;
                case SearchType.BlankSeason:
                    MatchingSpecies = SearchDataAccess.FilterToNoSeason(MatchingSpecies);

                    break;
                case SearchType.BlankColour:
                    MatchingSpecies = SearchDataAccess.FilterToNoColour(MatchingSpecies);

                    break;
                case SearchType.BlankStatus:
                    MatchingSpecies = SearchDataAccess.FilterToNoStatus(MatchingSpecies);
                    break;
                default:
                    break;
            }

            searchresults = SearchDataAccess.ConvertToSearchResultCollection(MatchingSpecies);
            if (f > 0)
            {
                searchresults = searchresults.OrderByDescending(x => x.Flag);
            }
            else
            {
                searchresults = searchresults.OrderBy(x => x.Name);
            }
            dataGridView1.DataSource = searchresults.ToList();


            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[3].Width = 350;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            SetColours();
        
        }

        private void SetColours()
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[5].Value == null)
                {
                    item.Cells[0].Style.BackColor = Color.LightGray;
                }
                else
                {
                    switch (Int32.Parse(item.Cells[5].Value.ToString()))
                    {
                        case 0:
                            item.Cells[0].Style.BackColor = Color.LightGray;

                            break;
                        case 1:
                            item.Cells[0].Style.BackColor = Color.LightBlue;
                            break;
                        case 2:
                            item.Cells[0].Style.BackColor = Color.Yellow;
                            break;
                        case 4:
                            item.Cells[0].Style.BackColor = Color.LightCoral;
                            break;
                        case 8:
                            item.Cells[0].Style.BackColor = Color.White;
                            break;
                        case 16:
                            item.Cells[0].Style.BackColor = Color.LightGreen;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private string GetFamily(int? family)
        {
            if (family == null)
            {
                return "";
            }
            else
            {
                return FamilyDataAccess.GetFamilyById((int)family).FamilyName;
            }
        }

        private string GetOrder(int? order)
        {
            if (order == null)
            {
                return "";
            }
            else
            {

                return OrderDataAccess.GetOrderById((int)order).OrderName;
            }
        }

     
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                SpeciesData d = new SpeciesData(int.Parse(dataGridView1[0, e.RowIndex].Value.ToString()));
                d.StartPosition = FormStartPosition.CenterScreen;
                d.Show(this);
            }
            else
            {

                SortResults(e);
            }
        }

        private void SortResults(DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (lastsort == e.ColumnIndex)
                    {
                        lastsort = -1;
                        searchresults = searchresults.OrderByDescending(i => i.SpeciesId);
                    }
                    else
                    {
                        searchresults = searchresults.OrderBy(i => i.SpeciesId);
                        lastsort = e.ColumnIndex;

                    }
                    break;
                case 1:
                    if (lastsort == e.ColumnIndex)
                    {
                        lastsort = -1;
                        searchresults = searchresults.OrderByDescending(i => i.Name);
                    }
                    else
                    {
                        searchresults = searchresults.OrderBy(i => i.Name);
                        lastsort = e.ColumnIndex;
                    }
                    break;
                case 2:
                    if (lastsort == e.ColumnIndex)
                    {
                        lastsort = -1;
                        searchresults = searchresults.OrderByDescending(i => i.Order);
                    }
                    else
                    {
                        searchresults = searchresults.OrderBy(i => i.Order);
                        lastsort = e.ColumnIndex;
                    }
                    break;
                case 3:
                    if (lastsort == e.ColumnIndex)
                    {
                        lastsort = -1;
                        searchresults = searchresults.OrderByDescending(i => i.Family);
                    }
                    else
                    {
                        searchresults = searchresults.OrderBy(i => i.Family);
                        lastsort = e.ColumnIndex;
                    }
                    break;
                default:
                    searchresults = searchresults.OrderBy(i => i.SpeciesId);
                    break;
            }
            dataGridView1.DataSource = searchresults.ToList();
            SetColours();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

            }
            else
            {

                SortResults(e);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                MessageBox.Show(saveFileDialog1.FileName);
                // Create the CSV file to which grid data will be exported.
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);
                // First we will write the headers.
                DataTable dt = DataTableConverter.ToDataTable<Species>(MatchingSpecies);
                
                int iColCount = dt.Columns.Count;
                for (int i = 0; i < iColCount; i++)
                {
                    sw.Write("\"");
                    sw.Write(dt.Columns[i]);
                    if (i < iColCount - 1)
                    {
                        sw.Write("\"");

                        sw.Write(",");
                    }
                    else
                    {
                        sw.Write("\"");

                    }
                }
                sw.Write(sw.NewLine);
                // Now write all the rows.
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < iColCount; i++)
                    {
                        sw.Write("\"");
                        if (!Convert.IsDBNull(dr[i]))
                        {
                            sw.Write(dr[i].ToString());
                        }
                        if (i < iColCount - 1)
                        {
                            sw.Write("\"");
                            sw.Write(",");

                        }
                        else
                        {
                            sw.Write("\"");
                        }

                    }
                    sw.Write(sw.NewLine);
                }
                sw.Close();

            }
        }

    }
}
