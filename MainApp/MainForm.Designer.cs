namespace Darwin.WindowsForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.btnSystemSetup = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAnySearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
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
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kingdomBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnStats = new System.Windows.Forms.Button();
            this.cbYVP = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lmocation = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExportFreemind = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblbigsmall = new System.Windows.Forms.Label();
            this.btnNoLocation = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUnusedGenus = new System.Windows.Forms.Button();
            this.btnNoStatus = new System.Windows.Forms.Button();
            this.btnNoColour = new System.Windows.Forms.Button();
            this.btnNoSeason = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.speciesColourUC1 = new Darwin.WindowsForm.SpeciesColourUC();
            this.monthPicker1 = new Darwin.WindowsForm.MonthPicker();
            this.distributionPicker1 = new Darwin.WindowsForm.DistributionPicker();
            this.speciesFlags1 = new Darwin.WindowsForm.SpeciesFlags();
            this.btnunusedfam = new System.Windows.Forms.Button();
            this.btnunsedorder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Lmocation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDataEntry
            // 
            this.btnDataEntry.Location = new System.Drawing.Point(282, 613);
            this.btnDataEntry.Name = "btnDataEntry";
            this.btnDataEntry.Size = new System.Drawing.Size(330, 65);
            this.btnDataEntry.TabIndex = 0;
            this.btnDataEntry.Text = "Enter New Species";
            this.btnDataEntry.UseVisualStyleBackColor = true;
            this.btnDataEntry.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnSystemSetup
            // 
            this.btnSystemSetup.Location = new System.Drawing.Point(8, 19);
            this.btnSystemSetup.Name = "btnSystemSetup";
            this.btnSystemSetup.Size = new System.Drawing.Size(185, 23);
            this.btnSystemSetup.TabIndex = 1;
            this.btnSystemSetup.Text = "Kingdom";
            this.btnSystemSetup.UseVisualStyleBackColor = true;
            this.btnSystemSetup.Click += new System.EventHandler(this.btnSystemSetup_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(13, 513);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(600, 94);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAnySearch
            // 
            this.txtAnySearch.Location = new System.Drawing.Point(129, 7);
            this.txtAnySearch.Name = "txtAnySearch";
            this.txtAnySearch.Size = new System.Drawing.Size(483, 20);
            this.txtAnySearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Any Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Common/Latin Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 212);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(483, 20);
            this.txtName.TabIndex = 17;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(13, 613);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(263, 65);
            this.btnClearSearch.TabIndex = 18;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // lblGenus
            // 
            this.lblGenus.AutoSize = true;
            this.lblGenus.Location = new System.Drawing.Point(6, 142);
            this.lblGenus.Name = "lblGenus";
            this.lblGenus.Size = new System.Drawing.Size(38, 13);
            this.lblGenus.TabIndex = 47;
            this.lblGenus.Text = "Genus";
            // 
            // cbGenus
            // 
            this.cbGenus.FormattingEnabled = true;
            this.cbGenus.Location = new System.Drawing.Point(123, 139);
            this.cbGenus.Name = "cbGenus";
            this.cbGenus.Size = new System.Drawing.Size(465, 21);
            this.cbGenus.TabIndex = 41;
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(6, 117);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(36, 13);
            this.lblFamily.TabIndex = 46;
            this.lblFamily.Text = "Family";
            // 
            // cbFamily
            // 
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Location = new System.Drawing.Point(123, 114);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(465, 21);
            this.cbFamily.TabIndex = 40;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(6, 90);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(33, 13);
            this.lblOrder.TabIndex = 45;
            this.lblOrder.Text = "Order";
            // 
            // cbOrder
            // 
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(123, 87);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(465, 21);
            this.cbOrder.TabIndex = 39;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(6, 65);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 44;
            this.lblClass.Text = "Class";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(123, 62);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(465, 21);
            this.cbClass.TabIndex = 38;
            // 
            // lblPhylum
            // 
            this.lblPhylum.AutoSize = true;
            this.lblPhylum.Location = new System.Drawing.Point(6, 40);
            this.lblPhylum.Name = "lblPhylum";
            this.lblPhylum.Size = new System.Drawing.Size(41, 13);
            this.lblPhylum.TabIndex = 43;
            this.lblPhylum.Text = "Phylum";
            // 
            // cbPhylum
            // 
            this.cbPhylum.FormattingEnabled = true;
            this.cbPhylum.Location = new System.Drawing.Point(123, 37);
            this.cbPhylum.Name = "cbPhylum";
            this.cbPhylum.Size = new System.Drawing.Size(465, 21);
            this.cbPhylum.TabIndex = 37;
            // 
            // lblKingdom
            // 
            this.lblKingdom.AutoSize = true;
            this.lblKingdom.Location = new System.Drawing.Point(6, 16);
            this.lblKingdom.Name = "lblKingdom";
            this.lblKingdom.Size = new System.Drawing.Size(48, 13);
            this.lblKingdom.TabIndex = 42;
            this.lblKingdom.Text = "Kingdom";
            // 
            // cbKingdom
            // 
            this.cbKingdom.FormattingEnabled = true;
            this.cbKingdom.Location = new System.Drawing.Point(123, 13);
            this.cbKingdom.Name = "cbKingdom";
            this.cbKingdom.Size = new System.Drawing.Size(465, 21);
            this.cbKingdom.TabIndex = 36;
            this.cbKingdom.SelectedIndexChanged += new System.EventHandler(this.cbKingdom_SelectedIndexChanged);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // kingdomBindingNavigatorSaveItem
            // 
            this.kingdomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kingdomBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kingdomBindingNavigatorSaveItem.Image")));
            this.kingdomBindingNavigatorSaveItem.Name = "kingdomBindingNavigatorSaveItem";
            this.kingdomBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kingdomBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(677, 48);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(187, 23);
            this.btnStats.TabIndex = 52;
            this.btnStats.Text = "Stats Tree";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // cbYVP
            // 
            this.cbYVP.AutoSize = true;
            this.cbYVP.Location = new System.Drawing.Point(345, 485);
            this.cbYVP.Name = "cbYVP";
            this.cbYVP.Size = new System.Drawing.Size(126, 17);
            this.cbYVP.TabIndex = 53;
            this.cbYVP.Text = "Limit to Yarrow Valley";
            this.cbYVP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.speciesFlags1);
            this.groupBox1.Location = new System.Drawing.Point(13, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 109);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flags";
            // 
            // Lmocation
            // 
            this.Lmocation.Controls.Add(this.distributionPicker1);
            this.Lmocation.Location = new System.Drawing.Point(341, 349);
            this.Lmocation.Name = "Lmocation";
            this.Lmocation.Size = new System.Drawing.Size(272, 109);
            this.Lmocation.TabIndex = 56;
            this.Lmocation.TabStop = false;
            this.Lmocation.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthPicker1);
            this.groupBox2.Location = new System.Drawing.Point(13, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 68);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Season";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.speciesColourUC1);
            this.groupBox3.Location = new System.Drawing.Point(13, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 48);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(133, 248);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(483, 21);
            this.cbStatus.TabIndex = 59;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblKingdom);
            this.groupBox4.Controls.Add(this.cbKingdom);
            this.groupBox4.Controls.Add(this.cbPhylum);
            this.groupBox4.Controls.Add(this.lblPhylum);
            this.groupBox4.Controls.Add(this.cbClass);
            this.groupBox4.Controls.Add(this.lblClass);
            this.groupBox4.Controls.Add(this.cbOrder);
            this.groupBox4.Controls.Add(this.lblOrder);
            this.groupBox4.Controls.Add(this.cbFamily);
            this.groupBox4.Controls.Add(this.lblFamily);
            this.groupBox4.Controls.Add(this.lblGenus);
            this.groupBox4.Controls.Add(this.cbGenus);
            this.groupBox4.Location = new System.Drawing.Point(12, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(597, 166);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            // 
            // btnExportFreemind
            // 
            this.btnExportFreemind.Location = new System.Drawing.Point(677, 14);
            this.btnExportFreemind.Name = "btnExportFreemind";
            this.btnExportFreemind.Size = new System.Drawing.Size(187, 23);
            this.btnExportFreemind.TabIndex = 62;
            this.btnExportFreemind.Text = "Export Freemind XML";
            this.btnExportFreemind.UseVisualStyleBackColor = true;
            this.btnExportFreemind.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Darwin.mm";
            this.saveFileDialog1.Filter = "MindMap|*.mm";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // lblbigsmall
            // 
            this.lblbigsmall.AutoSize = true;
            this.lblbigsmall.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbigsmall.Location = new System.Drawing.Point(626, 349);
            this.lblbigsmall.Name = "lblbigsmall";
            this.lblbigsmall.Size = new System.Drawing.Size(26, 23);
            this.lblbigsmall.TabIndex = 64;
            this.lblbigsmall.Text = ">";
            this.lblbigsmall.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnNoLocation
            // 
            this.btnNoLocation.Location = new System.Drawing.Point(9, 24);
            this.btnNoLocation.Name = "btnNoLocation";
            this.btnNoLocation.Size = new System.Drawing.Size(185, 23);
            this.btnNoLocation.TabIndex = 65;
            this.btnNoLocation.Text = "No Location";
            this.btnNoLocation.UseVisualStyleBackColor = true;
            this.btnNoLocation.Click += new System.EventHandler(this.btnNoLocation_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnunsedorder);
            this.groupBox5.Controls.Add(this.btnunusedfam);
            this.groupBox5.Controls.Add(this.btnUnusedGenus);
            this.groupBox5.Controls.Add(this.btnNoStatus);
            this.groupBox5.Controls.Add(this.btnNoColour);
            this.groupBox5.Controls.Add(this.btnNoSeason);
            this.groupBox5.Controls.Add(this.btnNoLocation);
            this.groupBox5.Location = new System.Drawing.Point(677, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 232);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Special Search";
            // 
            // btnUnusedGenus
            // 
            this.btnUnusedGenus.Location = new System.Drawing.Point(9, 141);
            this.btnUnusedGenus.Name = "btnUnusedGenus";
            this.btnUnusedGenus.Size = new System.Drawing.Size(185, 23);
            this.btnUnusedGenus.TabIndex = 69;
            this.btnUnusedGenus.Text = "Unused Genus";
            this.btnUnusedGenus.UseVisualStyleBackColor = true;
            this.btnUnusedGenus.Click += new System.EventHandler(this.btnUnusedGenus_Click);
            // 
            // btnNoStatus
            // 
            this.btnNoStatus.Location = new System.Drawing.Point(8, 112);
            this.btnNoStatus.Name = "btnNoStatus";
            this.btnNoStatus.Size = new System.Drawing.Size(185, 23);
            this.btnNoStatus.TabIndex = 68;
            this.btnNoStatus.Text = "No Status";
            this.btnNoStatus.UseVisualStyleBackColor = true;
            this.btnNoStatus.Click += new System.EventHandler(this.btnNoStatus_Click);
            // 
            // btnNoColour
            // 
            this.btnNoColour.Location = new System.Drawing.Point(9, 82);
            this.btnNoColour.Name = "btnNoColour";
            this.btnNoColour.Size = new System.Drawing.Size(185, 23);
            this.btnNoColour.TabIndex = 67;
            this.btnNoColour.Text = "No Colour";
            this.btnNoColour.UseVisualStyleBackColor = true;
            this.btnNoColour.Click += new System.EventHandler(this.btnNoColour_Click);
            // 
            // btnNoSeason
            // 
            this.btnNoSeason.Location = new System.Drawing.Point(9, 53);
            this.btnNoSeason.Name = "btnNoSeason";
            this.btnNoSeason.Size = new System.Drawing.Size(185, 23);
            this.btnNoSeason.TabIndex = 66;
            this.btnNoSeason.Text = "No Season";
            this.btnNoSeason.UseVisualStyleBackColor = true;
            this.btnNoSeason.Click += new System.EventHandler(this.btnNoSeason_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSystemSetup);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(677, 358);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 85);
            this.groupBox6.TabIndex = 67;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Setup";
            // 
            // speciesColourUC1
            // 
            this.speciesColourUC1.Location = new System.Drawing.Point(6, 19);
            this.speciesColourUC1.Name = "speciesColourUC1";
            this.speciesColourUC1.Size = new System.Drawing.Size(260, 17);
            this.speciesColourUC1.TabIndex = 51;
            // 
            // monthPicker1
            // 
            this.monthPicker1.Location = new System.Drawing.Point(7, 19);
            this.monthPicker1.Name = "monthPicker1";
            this.monthPicker1.Size = new System.Drawing.Size(589, 47);
            this.monthPicker1.TabIndex = 48;
            // 
            // distributionPicker1
            // 
            this.distributionPicker1.Location = new System.Drawing.Point(6, 25);
            this.distributionPicker1.Name = "distributionPicker1";
            this.distributionPicker1.Size = new System.Drawing.Size(265, 69);
            this.distributionPicker1.TabIndex = 50;
            // 
            // speciesFlags1
            // 
            this.speciesFlags1.Location = new System.Drawing.Point(9, 32);
            this.speciesFlags1.Name = "speciesFlags1";
            this.speciesFlags1.Size = new System.Drawing.Size(298, 45);
            this.speciesFlags1.TabIndex = 49;
            // 
            // btnunusedfam
            // 
            this.btnunusedfam.Location = new System.Drawing.Point(9, 170);
            this.btnunusedfam.Name = "btnunusedfam";
            this.btnunusedfam.Size = new System.Drawing.Size(185, 23);
            this.btnunusedfam.TabIndex = 70;
            this.btnunusedfam.Text = "Unused Family";
            this.btnunusedfam.UseVisualStyleBackColor = true;
            this.btnunusedfam.Click += new System.EventHandler(this.btnunusedfam_Click);
            // 
            // btnunsedorder
            // 
            this.btnunsedorder.Location = new System.Drawing.Point(9, 199);
            this.btnunsedorder.Name = "btnunsedorder";
            this.btnunsedorder.Size = new System.Drawing.Size(185, 23);
            this.btnunsedorder.TabIndex = 71;
            this.btnunsedorder.Text = "Unused Order";
            this.btnunsedorder.UseVisualStyleBackColor = true;
            this.btnunsedorder.Click += new System.EventHandler(this.btnunsedorder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 689);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblbigsmall);
            this.Controls.Add(this.btnExportFreemind);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lmocation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbYVP);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnySearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDataEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Darwin ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.Lmocation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kingdomBindingNavigatorSaveItem;

        private System.Windows.Forms.Button btnDataEntry;
        private System.Windows.Forms.Button btnSystemSetup;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAnySearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClearSearch;
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
        private MonthPicker monthPicker1;
        private SpeciesFlags speciesFlags1;
        private DistributionPicker distributionPicker1;
        private SpeciesColourUC speciesColourUC1;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.CheckBox cbYVP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Lmocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExportFreemind;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblbigsmall;
        private System.Windows.Forms.Button btnNoLocation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnNoColour;
        private System.Windows.Forms.Button btnNoSeason;
        private System.Windows.Forms.Button btnNoStatus;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUnusedGenus;
        private System.Windows.Forms.Button btnunsedorder;
        private System.Windows.Forms.Button btnunusedfam;


    }
}

