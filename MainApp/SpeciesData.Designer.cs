namespace Darwin.WindowsForm
{
    partial class SpeciesData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeciesData));
            this.rtDescription = new System.Windows.Forms.TextBox();
            this.rtHabitat = new System.Windows.Forms.TextBox();
            this.rtDistribution = new System.Windows.Forms.TextBox();
            this.rtFood = new System.Windows.Forms.TextBox();
            this.rtBehaviour = new System.Windows.Forms.TextBox();
            this.rtBreeding = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.txtSpeciesId = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblGenus = new System.Windows.Forms.Label();
            this.cbGenus = new System.Windows.Forms.ComboBox();
            this.lblFamily = new System.Windows.Forms.Label();
            this.cbFamily = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblPhylum = new System.Windows.Forms.Label();
            this.cbPhylum = new System.Windows.Forms.ComboBox();
            this.lblKingdom = new System.Windows.Forms.Label();
            this.cbKingdom = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtLatin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.openPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.SpeciesImage = new System.Windows.Forms.PictureBox();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.lblImageCount = new System.Windows.Forms.Label();
            this.btnOrderDetail = new System.Windows.Forms.Button();
            this.btnSimilarAdd = new System.Windows.Forms.Button();
            this.txtSimilarAdd = new System.Windows.Forms.TextBox();
            this.lSimilarSpecies = new System.Windows.Forms.ListBox();
            this.cmSimilarSpecies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmSimilarSpeciesDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFamilyDetails = new System.Windows.Forms.Button();
            this.btnWiki = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnCustomURL = new System.Windows.Forms.Button();
            this.speciesColourUC1 = new Darwin.WindowsForm.SpeciesColourUC();
            this.distributionPicker1 = new Darwin.WindowsForm.DistributionPicker();
            this.monthPicker1 = new Darwin.WindowsForm.MonthPicker();
            this.speciesFlags1 = new Darwin.WindowsForm.SpeciesFlags();
            ((System.ComponentModel.ISupportInitialize)(this.SpeciesImage)).BeginInit();
            this.cmSimilarSpecies.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtDescription
            // 
            this.rtDescription.Location = new System.Drawing.Point(12, 112);
            this.rtDescription.Multiline = true;
            this.rtDescription.Name = "rtDescription";
            this.rtDescription.Size = new System.Drawing.Size(663, 259);
            this.rtDescription.TabIndex = 3;
            // 
            // rtHabitat
            // 
            this.rtHabitat.Location = new System.Drawing.Point(9, 390);
            this.rtHabitat.Multiline = true;
            this.rtHabitat.Name = "rtHabitat";
            this.rtHabitat.Size = new System.Drawing.Size(663, 45);
            this.rtHabitat.TabIndex = 4;
            // 
            // rtDistribution
            // 
            this.rtDistribution.Location = new System.Drawing.Point(696, 786);
            this.rtDistribution.Multiline = true;
            this.rtDistribution.Name = "rtDistribution";
            this.rtDistribution.Size = new System.Drawing.Size(139, 84);
            this.rtDistribution.TabIndex = 5;
            this.rtDistribution.Visible = false;
            // 
            // rtFood
            // 
            this.rtFood.Location = new System.Drawing.Point(12, 454);
            this.rtFood.Multiline = true;
            this.rtFood.Name = "rtFood";
            this.rtFood.Size = new System.Drawing.Size(663, 45);
            this.rtFood.TabIndex = 6;
            // 
            // rtBehaviour
            // 
            this.rtBehaviour.Location = new System.Drawing.Point(12, 518);
            this.rtBehaviour.Multiline = true;
            this.rtBehaviour.Name = "rtBehaviour";
            this.rtBehaviour.Size = new System.Drawing.Size(663, 101);
            this.rtBehaviour.TabIndex = 7;
            // 
            // rtBreeding
            // 
            this.rtBreeding.Location = new System.Drawing.Point(12, 638);
            this.rtBreeding.Multiline = true;
            this.rtBreeding.Name = "rtBreeding";
            this.rtBreeding.Size = new System.Drawing.Size(663, 45);
            this.rtBreeding.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Common Name : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(568, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Habitat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 770);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Distribution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Food/Diet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Behaviour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Breeding/Young";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 716);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Seasons/Dates";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 786);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 838);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Similar Species";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1120, 894);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(696, 888);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(171, 92);
            this.btnMap.TabIndex = 21;
            this.btnMap.Text = "Open Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // txtSpeciesId
            // 
            this.txtSpeciesId.Location = new System.Drawing.Point(1300, 860);
            this.txtSpeciesId.Name = "txtSpeciesId";
            this.txtSpeciesId.ReadOnly = true;
            this.txtSpeciesId.Size = new System.Drawing.Size(100, 20);
            this.txtSpeciesId.TabIndex = 22;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(1148, 867);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 23;
            // 
            // lblGenus
            // 
            this.lblGenus.AutoSize = true;
            this.lblGenus.Location = new System.Drawing.Point(788, 745);
            this.lblGenus.Name = "lblGenus";
            this.lblGenus.Size = new System.Drawing.Size(38, 13);
            this.lblGenus.TabIndex = 35;
            this.lblGenus.Text = "Genus";
            // 
            // cbGenus
            // 
            this.cbGenus.FormattingEnabled = true;
            this.cbGenus.Location = new System.Drawing.Point(850, 742);
            this.cbGenus.Name = "cbGenus";
            this.cbGenus.Size = new System.Drawing.Size(547, 21);
            this.cbGenus.TabIndex = 14;
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(787, 720);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(36, 13);
            this.lblFamily.TabIndex = 33;
            this.lblFamily.Text = "Family";
            // 
            // cbFamily
            // 
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Location = new System.Drawing.Point(850, 717);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(547, 21);
            this.cbFamily.TabIndex = 13;
            this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(787, 693);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(33, 13);
            this.lblOrder.TabIndex = 31;
            this.lblOrder.Text = "Order";
            // 
            // cbOrder
            // 
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(850, 690);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(547, 21);
            this.cbOrder.TabIndex = 12;
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(788, 668);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 29;
            this.lblClass.Text = "Class";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(850, 665);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(547, 21);
            this.cbClass.TabIndex = 11;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // lblPhylum
            // 
            this.lblPhylum.AutoSize = true;
            this.lblPhylum.Location = new System.Drawing.Point(787, 643);
            this.lblPhylum.Name = "lblPhylum";
            this.lblPhylum.Size = new System.Drawing.Size(41, 13);
            this.lblPhylum.TabIndex = 27;
            this.lblPhylum.Text = "Phylum";
            // 
            // cbPhylum
            // 
            this.cbPhylum.FormattingEnabled = true;
            this.cbPhylum.Location = new System.Drawing.Point(850, 640);
            this.cbPhylum.Name = "cbPhylum";
            this.cbPhylum.Size = new System.Drawing.Size(547, 21);
            this.cbPhylum.TabIndex = 10;
            this.cbPhylum.SelectedIndexChanged += new System.EventHandler(this.cbPhylum_SelectedIndexChanged);
            // 
            // lblKingdom
            // 
            this.lblKingdom.AutoSize = true;
            this.lblKingdom.Location = new System.Drawing.Point(787, 619);
            this.lblKingdom.Name = "lblKingdom";
            this.lblKingdom.Size = new System.Drawing.Size(48, 13);
            this.lblKingdom.TabIndex = 25;
            this.lblKingdom.Text = "Kingdom";
            // 
            // cbKingdom
            // 
            this.cbKingdom.FormattingEnabled = true;
            this.cbKingdom.Location = new System.Drawing.Point(850, 616);
            this.cbKingdom.Name = "cbKingdom";
            this.cbKingdom.Size = new System.Drawing.Size(547, 21);
            this.cbKingdom.TabIndex = 9;
            this.cbKingdom.SelectedIndexChanged += new System.EventHandler(this.cbKingdom_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(702, 795);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 20);
            this.txtStatus.TabIndex = 36;
            // 
            // txtLatin
            // 
            this.txtLatin.Location = new System.Drawing.Point(107, 39);
            this.txtLatin.Name = "txtLatin";
            this.txtLatin.Size = new System.Drawing.Size(568, 20);
            this.txtLatin.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Latin Name :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(982, 948);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete Species";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Location = new System.Drawing.Point(1117, 940);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(122, 40);
            this.btnSaveAndClose.TabIndex = 41;
            this.btnSaveAndClose.Text = "Save and Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1275, 940);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(885, 910);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(185, 32);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // openPicture
            // 
            this.openPicture.FileName = "*.jpg";
            this.openPicture.Filter = "Pictures|*.jpg";
            this.openPicture.FileOk += new System.ComponentModel.CancelEventHandler(this.openPicture_FileOk);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Location = new System.Drawing.Point(1374, 587);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(24, 23);
            this.btnDeleteImage.TabIndex = 45;
            this.btnDeleteImage.Text = "-";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(1344, 587);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(24, 23);
            this.btnAddImage.TabIndex = 46;
            this.btnAddImage.Text = "+";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // SpeciesImage
            // 
            this.SpeciesImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("SpeciesImage.InitialImage")));
            this.SpeciesImage.Location = new System.Drawing.Point(696, 13);
            this.SpeciesImage.Name = "SpeciesImage";
            this.SpeciesImage.Size = new System.Drawing.Size(701, 572);
            this.SpeciesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpeciesImage.TabIndex = 8;
            this.SpeciesImage.TabStop = false;
            this.SpeciesImage.DoubleClick += new System.EventHandler(this.SpeciesImage_DoubleClick);
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Enabled = false;
            this.btnPrevImage.Location = new System.Drawing.Point(696, 587);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(24, 23);
            this.btnPrevImage.TabIndex = 47;
            this.btnPrevImage.Text = "<";
            this.btnPrevImage.UseVisualStyleBackColor = true;
            this.btnPrevImage.Click += new System.EventHandler(this.btnPrevImage_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.Enabled = false;
            this.btnNextImage.Location = new System.Drawing.Point(726, 587);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(24, 23);
            this.btnNextImage.TabIndex = 48;
            this.btnNextImage.Text = ">";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // lblImageCount
            // 
            this.lblImageCount.AutoSize = true;
            this.lblImageCount.Location = new System.Drawing.Point(757, 596);
            this.lblImageCount.Name = "lblImageCount";
            this.lblImageCount.Size = new System.Drawing.Size(0, 13);
            this.lblImageCount.TabIndex = 49;
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDetail.Location = new System.Drawing.Point(762, 690);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(21, 18);
            this.btnOrderDetail.TabIndex = 51;
            this.btnOrderDetail.Text = "*";
            this.btnOrderDetail.UseVisualStyleBackColor = true;
            this.btnOrderDetail.Click += new System.EventHandler(this.btnOrderDetail_Click);
            // 
            // btnSimilarAdd
            // 
            this.btnSimilarAdd.Location = new System.Drawing.Point(163, 832);
            this.btnSimilarAdd.Name = "btnSimilarAdd";
            this.btnSimilarAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSimilarAdd.TabIndex = 53;
            this.btnSimilarAdd.Text = "Add";
            this.btnSimilarAdd.UseVisualStyleBackColor = true;
            this.btnSimilarAdd.Click += new System.EventHandler(this.btnSimilarAdd_Click);
            // 
            // txtSimilarAdd
            // 
            this.txtSimilarAdd.Location = new System.Drawing.Point(94, 834);
            this.txtSimilarAdd.Name = "txtSimilarAdd";
            this.txtSimilarAdd.Size = new System.Drawing.Size(63, 20);
            this.txtSimilarAdd.TabIndex = 54;
            // 
            // lSimilarSpecies
            // 
            this.lSimilarSpecies.BackColor = System.Drawing.SystemColors.Control;
            this.lSimilarSpecies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lSimilarSpecies.ColumnWidth = 330;
            this.lSimilarSpecies.DisplayMember = "SpeciesName";
            this.lSimilarSpecies.FormattingEnabled = true;
            this.lSimilarSpecies.Location = new System.Drawing.Point(12, 867);
            this.lSimilarSpecies.MultiColumn = true;
            this.lSimilarSpecies.Name = "lSimilarSpecies";
            this.lSimilarSpecies.Size = new System.Drawing.Size(660, 104);
            this.lSimilarSpecies.TabIndex = 55;
            this.lSimilarSpecies.ValueMember = "SpeciesId";
            this.lSimilarSpecies.DoubleClick += new System.EventHandler(this.lSimilarSpecies_DoubleClick);
            // 
            // cmSimilarSpecies
            // 
            this.cmSimilarSpecies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmSimilarSpeciesDelete});
            this.cmSimilarSpecies.Name = "cmSimilarSpecies";
            this.cmSimilarSpecies.Size = new System.Drawing.Size(108, 26);
            // 
            // cmSimilarSpeciesDelete
            // 
            this.cmSimilarSpeciesDelete.Name = "cmSimilarSpeciesDelete";
            this.cmSimilarSpeciesDelete.Size = new System.Drawing.Size(107, 22);
            this.cmSimilarSpeciesDelete.Text = "Delete";
            this.cmSimilarSpeciesDelete.Click += new System.EventHandler(this.cmSimilarSpeciesDelete_Click);
            // 
            // btnFamilyDetails
            // 
            this.btnFamilyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamilyDetails.Location = new System.Drawing.Point(762, 717);
            this.btnFamilyDetails.Name = "btnFamilyDetails";
            this.btnFamilyDetails.Size = new System.Drawing.Size(21, 18);
            this.btnFamilyDetails.TabIndex = 56;
            this.btnFamilyDetails.Text = "*";
            this.btnFamilyDetails.UseVisualStyleBackColor = true;
            this.btnFamilyDetails.Click += new System.EventHandler(this.btnFamilyDetails_Click);
            // 
            // btnWiki
            // 
            this.btnWiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiki.Font = new System.Drawing.Font("Pescadero", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWiki.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnWiki.Location = new System.Drawing.Point(12, 67);
            this.btnWiki.Name = "btnWiki";
            this.btnWiki.Size = new System.Drawing.Size(145, 26);
            this.btnWiki.TabIndex = 57;
            this.btnWiki.Text = "Wikipedia";
            this.btnWiki.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWiki.UseVisualStyleBackColor = true;
            this.btnWiki.Click += new System.EventHandler(this.btnWiki_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(52, 794);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(450, 21);
            this.cbStatus.TabIndex = 58;
            // 
            // btnCustomURL
            // 
            this.btnCustomURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomURL.Font = new System.Drawing.Font("Pescadero", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomURL.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCustomURL.Location = new System.Drawing.Point(163, 67);
            this.btnCustomURL.Name = "btnCustomURL";
            this.btnCustomURL.Size = new System.Drawing.Size(145, 26);
            this.btnCustomURL.TabIndex = 59;
            this.btnCustomURL.Text = "CustomURL";
            this.btnCustomURL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomURL.UseVisualStyleBackColor = true;
            this.btnCustomURL.Visible = false;
            this.btnCustomURL.Click += new System.EventHandler(this.btnCustomURL_Click);
            // 
            // speciesColourUC1
            // 
            this.speciesColourUC1.Location = new System.Drawing.Point(885, 867);
            this.speciesColourUC1.Name = "speciesColourUC1";
            this.speciesColourUC1.Size = new System.Drawing.Size(257, 21);
            this.speciesColourUC1.TabIndex = 50;
            // 
            // distributionPicker1
            // 
            this.distributionPicker1.Location = new System.Drawing.Point(816, 785);
            this.distributionPicker1.Name = "distributionPicker1";
            this.distributionPicker1.Size = new System.Drawing.Size(265, 69);
            this.distributionPicker1.TabIndex = 44;
            // 
            // monthPicker1
            // 
            this.monthPicker1.Location = new System.Drawing.Point(12, 732);
            this.monthPicker1.Name = "monthPicker1";
            this.monthPicker1.Size = new System.Drawing.Size(606, 51);
            this.monthPicker1.TabIndex = 16;
            // 
            // speciesFlags1
            // 
            this.speciesFlags1.Location = new System.Drawing.Point(1106, 786);
            this.speciesFlags1.Name = "speciesFlags1";
            this.speciesFlags1.Size = new System.Drawing.Size(291, 45);
            this.speciesFlags1.TabIndex = 19;
            // 
            // SpeciesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1409, 993);
            this.Controls.Add(this.btnCustomURL);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnWiki);
            this.Controls.Add(this.btnFamilyDetails);
            this.Controls.Add(this.lSimilarSpecies);
            this.Controls.Add(this.txtSimilarAdd);
            this.Controls.Add(this.btnSimilarAdd);
            this.Controls.Add(this.btnOrderDetail);
            this.Controls.Add(this.speciesColourUC1);
            this.Controls.Add(this.lblImageCount);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.distributionPicker1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtLatin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblGenus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.cbGenus);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.cbOrder);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lblPhylum);
            this.Controls.Add(this.cbPhylum);
            this.Controls.Add(this.lblKingdom);
            this.Controls.Add(this.cbKingdom);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSpeciesId);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.monthPicker1);
            this.Controls.Add(this.speciesFlags1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SpeciesImage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtDistribution);
            this.Controls.Add(this.rtDescription);
            this.Controls.Add(this.rtFood);
            this.Controls.Add(this.rtBreeding);
            this.Controls.Add(this.rtBehaviour);
            this.Controls.Add(this.rtHabitat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpeciesData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Species";
            this.Load += new System.EventHandler(this.SpeciesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpeciesImage)).EndInit();
            this.cmSimilarSpecies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rtDescription;
        private System.Windows.Forms.TextBox rtHabitat;
        private System.Windows.Forms.TextBox rtDistribution;
        private System.Windows.Forms.TextBox rtFood;
        private System.Windows.Forms.TextBox rtBehaviour;
        private System.Windows.Forms.TextBox rtBreeding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox SpeciesImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MonthPicker monthPicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private SpeciesFlags speciesFlags1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.TextBox txtSpeciesId;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblGenus;
        private System.Windows.Forms.ComboBox cbGenus;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.ComboBox cbFamily;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblPhylum;
        private System.Windows.Forms.ComboBox cbPhylum;
        private System.Windows.Forms.Label lblKingdom;
        private System.Windows.Forms.ComboBox cbKingdom;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtLatin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.OpenFileDialog openPicture;
        private DistributionPicker distributionPicker1;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Label lblImageCount;
        private SpeciesColourUC speciesColourUC1;
        private System.Windows.Forms.Button btnOrderDetail;
        private System.Windows.Forms.Button btnSimilarAdd;
        private System.Windows.Forms.TextBox txtSimilarAdd;
        private System.Windows.Forms.ListBox lSimilarSpecies;
        private System.Windows.Forms.ContextMenuStrip cmSimilarSpecies;
        private System.Windows.Forms.ToolStripMenuItem cmSimilarSpeciesDelete;
        private System.Windows.Forms.Button btnFamilyDetails;
        private System.Windows.Forms.Button btnWiki;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnCustomURL;
    }
}