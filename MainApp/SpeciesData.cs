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
using Darwin.WebReference;

namespace Darwin.WindowsForm
{
    public partial class SpeciesData : Form
    {
        private bool _IsNew = true;
        private int _speciesId = 0;

        public SpeciesData(int speciesid)
        {
            _IsNew = false;

            _speciesId = speciesid;
            InitializeComponent();

        }
        public SpeciesData()
        {
            _IsNew = true;
            InitializeComponent();
        }


        private Species CurrentSpecies;

        private void SpeciesData_Load(object sender, EventArgs e)
        {
            if (SystemInformation.PrimaryMonitorSize.Height == 768)
            {
                this.Scale(new SizeF(0.7f, 0.7f));
                foreach (System.Windows.Forms.Control cntrl in this.Controls)
                {
                    cntrl.Font = new Font("Arial", 7);
                }
            }
            FillStatus();

            if (!_IsNew)
            {
                SetEditMode(true);

            }

            if (_speciesId == 0)
            {
                FillKingdom();
                cbKingdom_SelectedIndexChanged(this, new EventArgs());

                CreateNewSpecies();
                _speciesId = CurrentSpecies.SpeciesId;
            }
            else
            {
                LoadSpecies();
            }

            txtSpeciesId.Text = CurrentSpecies.SpeciesId.ToString();

        }

        private void FillStatus()
        {
            cbStatus.DataSource = StatusDataAccess.GetAllStatus();
            cbStatus.ValueMember = "StatusId";
            cbStatus.DisplayMember = "StatusText";
            cbStatus.SelectedIndex = -1;
        }

        private void SetEditMode(bool readonlymode)
        {
            txtLatin.ReadOnly = readonlymode;
            txtName.ReadOnly = readonlymode;
            txtStatus.ReadOnly = readonlymode;

            rtBehaviour.ReadOnly = readonlymode;
            rtBreeding.ReadOnly = readonlymode;
            rtDescription.ReadOnly = readonlymode;
            rtDistribution.ReadOnly = readonlymode;
            rtFood.ReadOnly = readonlymode;
            rtHabitat.ReadOnly = readonlymode;

            cbClass.Enabled = !readonlymode;
            cbPhylum.Enabled = !readonlymode;
            cbOrder.Enabled = !readonlymode;
            cbGenus.Enabled = !readonlymode;
            cbFamily.Enabled = !readonlymode;
            cbKingdom.Enabled = !readonlymode;

            cbStatus.Enabled = !readonlymode;

            btnSave.Enabled = !readonlymode;
            btnAddImage.Enabled = !readonlymode;
            btnDeleteImage.Enabled = !readonlymode;
            btnDelete.Enabled = !readonlymode;
            btnSaveAndClose.Enabled = !readonlymode;
            monthPicker1.Enabled = !readonlymode;
            speciesFlags1.Enabled = !readonlymode;
            distributionPicker1.Enabled = !readonlymode;
            speciesColourUC1.Enabled = !readonlymode;
            txtSimilarAdd.Visible = !readonlymode;
            btnSimilarAdd.Visible = !readonlymode;

            if (readonlymode)
            {
                lSimilarSpecies.ContextMenuStrip = null;

            }
            else
            {
                lSimilarSpecies.ContextMenuStrip = cmSimilarSpecies;
            }
        }

        private void FillKingdom()
        {
            FillKingdom(null);
        }
        private void FillKingdom(int? select)
        {
            cbKingdom.DisplayMember = "KingdomName";
            cbKingdom.ValueMember = "KingdomId";
            cbKingdom.DataSource = KingdomDataAccess.GetAllKingdoms();

            if (select != null)
            {
                cbKingdom.SelectedValue = CurrentSpecies.KingdomId;
            }

        }

        private void LoadSpecies()
        {

            this.cbKingdom.SelectedIndexChanged -= new System.EventHandler(this.cbKingdom_SelectedIndexChanged);
            this.cbFamily.SelectedIndexChanged -= new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            this.cbOrder.SelectedIndexChanged -= new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            this.cbClass.SelectedIndexChanged -= new System.EventHandler(this.cbClass_SelectedIndexChanged);
            this.cbPhylum.SelectedIndexChanged -= new System.EventHandler(this.cbPhylum_SelectedIndexChanged);

            CurrentSpecies = SpeciesDataAccess.GetSpeciesById(_speciesId);
            try
            {
                pOrder = new PopupInfo((int)CurrentSpecies.OrderId, Enum.TreeOfLiveType.Order);
            }
            catch { }
            try
            {
                pFamily = new PopupInfo((int)CurrentSpecies.FamilyId, Enum.TreeOfLiveType.Family);
            }
            catch { }
            pOrderVis = false;
            pFamilyVis = false;
            if (CurrentSpecies.SpeciesStatu == null)
            {
                cbStatus.SelectedIndex = -1;
            }
            else
            {
                cbStatus.SelectedValue = CurrentSpecies.SpeciesStatu.StatusId;
            }
            
            txtName.Text = CurrentSpecies.SpeciesName;
            txtLatin.Text = CurrentSpecies.SpeciesLatin;
            txtSpeciesId.Text = CurrentSpecies.SpeciesId.ToString();
            rtBehaviour.Text = CurrentSpecies.Behaviour;
            rtBreeding.Text = CurrentSpecies.Breeding;
            rtDescription.Text = CurrentSpecies.Description;
            rtDistribution.Text = CurrentSpecies.Distribution;
            rtFood.Text = CurrentSpecies.Food;
            rtHabitat.Text = CurrentSpecies.Habitat;
            txtStatus.Text = CurrentSpecies.Status;

            FillKingdom(CurrentSpecies.KingdomId);
            cbKingdom_SelectedIndexChanged(this, new EventArgs());

            //kpcofg
            if (CurrentSpecies.PhylumId != null)
            {
                FillPhylum(CurrentSpecies.PhylumId);
                cbPhylum_SelectedIndexChanged(this, new EventArgs());
                if (CurrentSpecies.ClassId != null)
                {
                    FillClass(CurrentSpecies.ClassId);
                    cbClass_SelectedIndexChanged(this, new EventArgs());
                    if (CurrentSpecies.OrderId != null)
                    {
                        FillOrder(CurrentSpecies.OrderId);
                        cbOrder_SelectedIndexChanged(this, new EventArgs());
                        if (CurrentSpecies.FamilyId != null)
                        {
                            FillFamily(CurrentSpecies.FamilyId);
                            cbFamily_SelectedIndexChanged(this, new EventArgs());
                            if (CurrentSpecies.GenusId != null)
                            {
                                FillGenus(CurrentSpecies.GenusId);
                            }
                        }
                    }
                }
            }

            speciesFlags1.LoadData(CurrentSpecies.Flags);
            monthPicker1.LoadData(CurrentSpecies.Seasons);
            distributionPicker1.LoadData(CurrentSpecies.DistributionFlags);

            speciesColourUC1.SetSelectedColour(CurrentSpecies.Colour);

            this.cbKingdom.SelectedIndexChanged += new System.EventHandler(this.cbKingdom_SelectedIndexChanged);
            this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            this.cbPhylum.SelectedIndexChanged += new System.EventHandler(this.cbPhylum_SelectedIndexChanged);

            if (SpeciesDataAccess.HasMapReferences(CurrentSpecies.SpeciesId)) btnMap.Text += "\n\n(Seen in YVP)";

            LoadImage();
            LoadSimilarSpecies();
            SetCustomURL();
        }

        private void SetCustomURL()
        {
            try
            {
                if (CurrentSpecies.Class.ClassName.ToLower().Contains("bird"))
                {
                    customurl = DarwinWeblink.GetURL(Enum.LinkType.Bird, CurrentSpecies.SpeciesName);
                    btnCustomURL.Text = "RSPB";
                    btnCustomURL.Visible = true;
                }
            }
            catch { }
        }

        string _CurrentImage = "";

        private void LoadImage(string filename = "nofileselected")
        {
            try
            {
                maximages = Directory.GetFiles(GetPicturePath() + @"\" + CurrentSpecies.SpeciesId.ToString()).Count();

                string picturepath = GetPicturePath();
                string[] d = Directory.GetFiles(picturepath + CurrentSpecies.SpeciesId.ToString() + @"\");
                string imagename = filename;
                try
                {
                    if (filename == "nofileselected")
                        imagename = d[currentimage].ToString();
                    try
                    {
                        if (maximages == 0)
                        {
                            SpeciesImage.Image = global::DarwinResources.Properties.Resources.noimage;

                        }
                        else
                        {
                            FileStream fs;
                            fs = new FileStream(imagename, FileMode.Open, FileAccess.Read);
                            SpeciesImage.Image = System.Drawing.Image.FromStream(fs);
                            fs.Close();

                        }
                        _CurrentImage = imagename;
                    }
                    catch
                    {
                    }
                }
                catch
                {
                    SpeciesImage.Image = global::DarwinResources.Properties.Resources.noimage;

                }
                UpdateImageCountLabel();
            }
            catch { }
        }

        private void UpdateImageCountLabel()
        {
            lblImageCount.Text = "Image " + (currentimage + 1).ToString() + " of " + maximages;


            if (currentimage > 0)
            {
                btnPrevImage.Enabled = true;
            }

            if ((currentimage + 1) < maximages && maximages > 0)
            {
                btnNextImage.Enabled = true;
            }
            if (maximages == 0)
            {
                lblImageCount.Text = "No Images";
                btnNextImage.Enabled = false;
                btnPrevImage.Enabled = false;
            }
        }

        private void CreateNewSpecies()
        {
            CurrentSpecies = SpeciesDataAccess.AddNewSpecies();
            _speciesId = CurrentSpecies.SpeciesId;

            try
            {
                Directory.CreateDirectory(GetPicturePath() + "\\" + CurrentSpecies.SpeciesId.ToString());
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            //MessageBox.Show(speciesFlags1.GetSpeciesInformation().ToString() + "\n" + monthPicker1.GetMonthsInformation().ToString());

            int monthsvalue = monthPicker1.GetMonthsInformation().GetHashCode();

            CurrentSpecies.Seasons = monthsvalue;
            CurrentSpecies.Behaviour = rtBehaviour.Text;
            CurrentSpecies.Breeding = rtBreeding.Text;
            CurrentSpecies.Description = rtDescription.Text;
            CurrentSpecies.Distribution = rtDistribution.Text;
            CurrentSpecies.Food = rtFood.Text;
            CurrentSpecies.Habitat = rtHabitat.Text;
            CurrentSpecies.Status = txtStatus.Text;
            CurrentSpecies.Colour = speciesColourUC1.GetSelectedColour().GetHashCode();
            if (cbStatus.SelectedIndex != -1)
            {
                CurrentSpecies.SpeciesStatus = Int32.Parse(cbStatus.SelectedValue.ToString());
            }
            int flagsvalue = speciesFlags1.GetSpeciesInformation().GetHashCode();

            CurrentSpecies.Flags = flagsvalue;

            int distflags = distributionPicker1.GetDistributionInformation().GetHashCode();

            CurrentSpecies.DistributionFlags = distflags;

            if (cbPhylum.SelectedValue != null) { CurrentSpecies.PhylumId = int.Parse(cbPhylum.SelectedValue.ToString()); } else { CurrentSpecies.PhylumId = null; };
            if (cbKingdom.SelectedValue != null) { CurrentSpecies.KingdomId = int.Parse(cbKingdom.SelectedValue.ToString()); } else { CurrentSpecies.KingdomId = null; };
            if (cbClass.SelectedValue != null) { CurrentSpecies.ClassId = int.Parse(cbClass.SelectedValue.ToString()); } else { CurrentSpecies.ClassId = null; };
            if (cbOrder.SelectedValue != null) { CurrentSpecies.OrderId = int.Parse(cbOrder.SelectedValue.ToString()); } else { CurrentSpecies.OrderId = null; };
            if (cbGenus.SelectedValue != null) { CurrentSpecies.GenusId = int.Parse(cbGenus.SelectedValue.ToString()); } else { CurrentSpecies.GenusId = null; };
            if (cbFamily.SelectedValue != null) { CurrentSpecies.FamilyId = int.Parse(cbFamily.SelectedValue.ToString()); } else { CurrentSpecies.FamilyId = null; };

            CurrentSpecies.SpeciesLatin = txtLatin.Text;
            CurrentSpecies.SpeciesName = txtName.Text;

            int rowsAffected = SpeciesDataAccess.SaveSpecies(CurrentSpecies);
            lblMessage.Text = rowsAffected.ToString() + " changes made to the table";
        }
        #region DDLs
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
            this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            this.cbPhylum.SelectedIndexChanged += new System.EventHandler(this.cbPhylum_SelectedIndexChanged);

            FillPhylum();



        }

        private void FillPhylum()
        {
            FillPhylum(null);
        }
        private void FillPhylum(int? select)
        {
            try
            {
                cbPhylum.DisplayMember = "PhylumName";
                cbPhylum.ValueMember = "PhylumId";
                cbPhylum.DataSource = PhylumDataAccess.GetPhylumsByKingdom((int)cbKingdom.SelectedValue);
                if (select != null) cbPhylum.SelectedValue = select;
            }
            catch { }
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
            this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);

            FillClass();
        }

        private void FillClass()
        {
            FillClass(null);
        }
        private void FillClass(int? select)
        {
            try
            {
                cbClass.DisplayMember = "ClassName";
                cbClass.ValueMember = "ClassId";
                cbClass.DataSource = ClassDataAccess.GetClasssByPhylum((int)cbPhylum.SelectedValue);
                if (select != null) cbClass.SelectedValue = select;
            }
            catch { }
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
            this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);

            FillOrder();
        }

        private void FillOrder()
        {
            FillOrder(null);
        }
        private void FillOrder(int? select)
        {
            try
            {
                cbOrder.DisplayMember = "OrderName";
                cbOrder.ValueMember = "OrderId";
                cbOrder.DataSource = OrderDataAccess.GetOrdersByClass((int)cbClass.SelectedValue);
                if (select != null) cbOrder.SelectedValue = select;
            }
            catch { }
        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbFamily.SelectedIndexChanged -= new System.EventHandler(this.cbFamily_SelectedIndexChanged);

            cbGenus.DataSource = null;
            cbFamily.DataSource = null;
            cbFamily.Items.Clear();
            cbFamily.SelectedIndex = -1;
            this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.cbFamily_SelectedIndexChanged);

            FillFamily();
        }

        private void FillFamily()
        {
            FillFamily(null);
        }
        private void FillFamily(int? select)
        {
            try
            {
                cbFamily.DisplayMember = "FamilyName";
                cbFamily.ValueMember = "FamilyId";
                cbFamily.DataSource = FamilyDataAccess.GetFamiliesByOrder((int)cbOrder.SelectedValue);
                if (select != null) cbFamily.SelectedValue = select;
            }
            catch { }
        }

        private void cbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGenus.DataSource = null;
            cbGenus.Items.Clear();
            cbGenus.SelectedIndex = -1;

            FillGenus();
        }

        private void FillGenus()
        {
            FillGenus(null);
        }
        private void FillGenus(int? select)
        {
            try
            {
                cbGenus.DisplayMember = "GenusName";
                cbGenus.ValueMember = "GenusId";
                cbGenus.DataSource = GenusDataAccess.GetGenusByFamily((int)cbFamily.SelectedValue);
                if (select != null) cbGenus.SelectedValue = select;

            }
            catch { }
        }
        #endregion
        private void SpeciesImage_DoubleClick(object sender, EventArgs e)
        {
            if (_CurrentImage.Length > 0)
            {
                OpenBrowser(_CurrentImage);
            }
            //openPicture.ShowDialog(this);
            //  MessageBox.Show(s);

        }

        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            SaveChanges();
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show(SpeciesDataAccess.DeleteSpecies(CurrentSpecies).ToString() + " Record Deleted");
                    try
                    {
                        this.Owner.Close();
                    }
                    catch { }
                }
                catch { MessageBox.Show("Cannot delete child records exist"); }
                this.Close();
            }

        }

        private void DeleteImageDirectory()
        {
            try
            {
                SpeciesImage.BackgroundImage = null;
                SpeciesImage.Image = null;
                SpeciesImage.InitialImage = null;
                SpeciesImage.ErrorImage = null;

                //SpeciesImage.BackgroundImage.Dispose();

                //SpeciesImage.Image.Dispose();
                //SpeciesImage.InitialImage.Dispose();
                //SpeciesImage.ErrorImage.Dispose();


                SpeciesImage.Dispose();
                Directory.Delete(GetPicturePath() + CurrentSpecies.SpeciesId.ToString(), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteImage()
        {

            try
            {
                currentimage = 0;
                SpeciesImage.Image.Dispose();
                //SpeciesImage.Image.
                File.Delete(_CurrentImage);
                LoadImage();
            }
            catch
            {
                try
                {

                    File.Delete(_CurrentImage);
                    LoadImage();

                }
                catch
                {
                    MessageBox.Show("Cannot delete file, it is currently locked.\nPlease close and re-open species and try again\n\n" + _CurrentImage.Replace(@"\\", @"\"));

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
        }

        private void openPicture_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                currentimage = 0;
                string picturepath = GetPicturePath();
                try
                {
                    Directory.CreateDirectory(GetPicturePath() + "\\" + CurrentSpecies.SpeciesId.ToString());
                }
                catch { }
                string imagename = GetDefaultImageName(picturepath, openPicture.SafeFileName);
                try
                {
                    File.Delete(imagename);
                }
                catch { }
                try
                {
                    File.Copy(openPicture.FileName, imagename);
                }
                catch { }
                LoadImage();
            }

        }

        private string GetDefaultImageName(string picturepath, string filename)
        {
            string imagename = picturepath + "\\" + CurrentSpecies.SpeciesId + "\\" + filename;

            return imagename;
        }

        private static string GetPicturePath()
        {
            string picturepath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Darwin\";

            return picturepath;
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            MapView m = new MapView(CurrentSpecies.SpeciesId);
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show(this);
        }

        private void lnkMainImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadImage();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            SpeciesImage_DoubleClick(sender, e);
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the image?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteImage();
            }
        }
        int currentimage = 0;
        int maximages = 0;
        private void btnNextImage_Click(object sender, EventArgs e)
        {
            try
            {
                maximages = Directory.GetFiles(GetPicturePath() + @"\" + CurrentSpecies.SpeciesId.ToString()).Count();
                if (currentimage < (maximages-1))
                {
                    currentimage++;
                }
                else
                {
                    currentimage = 0;
                }
            }
            catch { }
            LoadImage();

        }

        private void btnPrevImage_Click(object sender, EventArgs e)
        {
            if (currentimage > 0)
            {
                currentimage--;
            }
            else
            {
                maximages = Directory.GetFiles(GetPicturePath() + @"\" + CurrentSpecies.SpeciesId.ToString()).Count();
                currentimage = maximages-1;
            }
            LoadImage();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            if (pOrderVis)
            {
                pOrder.Hide();
                pOrderVis = false;
            }
            else
            {
                if (pOrder != null)
                {
                    pOrder.Show();
                }
                pOrderVis = true;
            }
            
        }

        private void LoadSimilarSpecies()
        {
            lSimilarSpecies.DataSource = SpeciesDataAccess.GetSimilarSpecies((int)CurrentSpecies.SpeciesId);
            lSimilarSpecies.DisplayMember = "SpeciesName";
            lSimilarSpecies.ValueMember = "SimilarId";
            lSimilarSpecies.SelectedIndex = -1;
            lSimilarSpecies.Refresh();
        }

        private void lSimilarSpecies_DoubleClick(object sender, EventArgs e)
        {

            int spId = SpeciesDataAccess.GetSpeciesIdFromSimilarSpecies(CurrentSpecies, Int32.Parse(lSimilarSpecies.SelectedValue.ToString()));

            SpeciesData newspecies = new SpeciesData(spId);
            newspecies.StartPosition = FormStartPosition.CenterScreen;
            newspecies.Show(this.Parent);
        }

        private void btnSimilarAdd_Click(object sender, EventArgs e)
        {
            SaveNewSimilarSpecies();
        }

        private bool SaveNewSimilarSpecies()
        {
            try
            {
                int SimilarSpeciesId = Int32.Parse(txtSimilarAdd.Text);
                if (SpeciesDataAccess.CheckSpeciesExists(SimilarSpeciesId))
                {
                    SpeciesDataAccess.SaveSimilarSpecies(CurrentSpecies.SpeciesId, SimilarSpeciesId);
                }
                else
                {
                    MessageBox.Show(txtSimilarAdd.Text + " is not a valid species id");
                }

                LoadSimilarSpecies();
                return true;
            }
            catch {
                MessageBox.Show("Invalid Id");
                return false; }

        }

        private void cmSimilarSpeciesDelete_Click(object sender, EventArgs e)
        {
            if (lSimilarSpecies.SelectedIndex < 0)
            {
                MessageBox.Show("No record selected");
            }
            else
            {
                if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    SpeciesDataAccess.DeleteSimilarSpecies(Int32.Parse(lSimilarSpecies.SelectedValue.ToString()));
                    LoadSimilarSpecies();
                }
            }
        }

        PopupInfo pFamily;
        PopupInfo pOrder;
        bool pFamilyVis = false;
        bool pOrderVis = false;

        private void btnFamilyDetails_Click(object sender, EventArgs e)
        {
            if (pFamilyVis)
            {
               pFamily.Hide();
               pFamilyVis = false;
            }
            else
            {
                if (pFamily != null)
                {
                    pFamily.Show();
                    pFamilyVis = true;
                }
            }
            
        }

        private void btnWiki_Click(object sender, EventArgs e)
        {
            List<string> s = WikipediaInterface.GetSearchResults(CurrentSpecies.SpeciesLatin);
            if (s.Count() == 0)
            {
                if (CurrentSpecies.SpeciesName.Length > 0)
                {
                    s = WikipediaInterface.GetSearchResults(CurrentSpecies.SpeciesName);
                }

                if (s.Count() == 0)
                {
                    if (CurrentSpecies.Genu != null)
                    {
                        s = WikipediaInterface.GetSearchResults(CurrentSpecies.Genu.GenusName);
                    }
                    if (s.Count() == 0)
                    {
                        s = WikipediaInterface.GetSearchResults(CurrentSpecies.Family.FamilyName);
                    }
                }


            }
            if (s.Count() > 0)
            {
                OpenBrowser("http://en.wikipedia.org/wiki/" + s[0].Replace(" ", "_"));
            }
            else
            {
                MessageBox.Show("Sorry couldn't find anything on Wikipedia :(");
            }
        }

        private static void OpenBrowser(string s)
        {
            Browser b = new Browser(s);
            b.StartPosition = FormStartPosition.CenterScreen;
            b.Show();
        }

        string customurl = "";

        private void btnCustomURL_Click(object sender, EventArgs e)
        {
            if (customurl.Length > 0)
            {
                OpenBrowser(customurl);
            }
        }


    }
}
