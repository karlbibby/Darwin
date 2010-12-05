namespace Darwin.WindowsForm
{
    partial class PhylumSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhylumSetup));
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhylumId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhylumName = new System.Windows.Forms.TextBox();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgPhylums = new System.Windows.Forms.DataGridView();
            this.txtKingdomId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tmrClearMsg = new System.Windows.Forms.Timer(this.components);
            this.lblParentInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhylums)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Id";
            // 
            // txtPhylumId
            // 
            this.txtPhylumId.Location = new System.Drawing.Point(419, 12);
            this.txtPhylumId.Name = "txtPhylumId";
            this.txtPhylumId.ReadOnly = true;
            this.txtPhylumId.Size = new System.Drawing.Size(100, 20);
            this.txtPhylumId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phylum Name";
            // 
            // txtPhylumName
            // 
            this.txtPhylumName.Location = new System.Drawing.Point(419, 38);
            this.txtPhylumName.Name = "txtPhylumName";
            this.txtPhylumName.Size = new System.Drawing.Size(242, 20);
            this.txtPhylumName.TabIndex = 13;
            // 
            // btnClasses
            // 
            this.btnClasses.Enabled = false;
            this.btnClasses.Location = new System.Drawing.Point(419, 128);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(320, 23);
            this.btnClasses.TabIndex = 12;
            this.btnClasses.Text = "Edit Classes";
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(513, 99);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(226, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgPhylums
            // 
            this.dgPhylums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhylums.Location = new System.Drawing.Point(12, 12);
            this.dgPhylums.Name = "dgPhylums";
            this.dgPhylums.Size = new System.Drawing.Size(397, 428);
            this.dgPhylums.TabIndex = 9;
            this.dgPhylums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhylums_CellClick);
            this.dgPhylums.SelectionChanged += new System.EventHandler(this.dgPhylums_SelectionChanged);
            // 
            // txtKingdomId
            // 
            this.txtKingdomId.Location = new System.Drawing.Point(12, 446);
            this.txtKingdomId.Name = "txtKingdomId";
            this.txtKingdomId.ReadOnly = true;
            this.txtKingdomId.Size = new System.Drawing.Size(100, 20);
            this.txtKingdomId.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kingdom Id";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(416, 169);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 20;
            // 
            // tmrClearMsg
            // 
            this.tmrClearMsg.Tick += new System.EventHandler(this.tmrClearMsg_Tick);
            // 
            // lblParentInfo
            // 
            this.lblParentInfo.AutoSize = true;
            this.lblParentInfo.Location = new System.Drawing.Point(416, 186);
            this.lblParentInfo.Name = "lblParentInfo";
            this.lblParentInfo.Size = new System.Drawing.Size(66, 13);
            this.lblParentInfo.TabIndex = 21;
            this.lblParentInfo.Text = "lblParentInfo";
            // 
            // PhylumSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.lblParentInfo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKingdomId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhylumId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhylumName);
            this.Controls.Add(this.btnClasses);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgPhylums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PhylumSetup";
            this.Text = "Phylum Setup";
            this.Load += new System.EventHandler(this.PhylumSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhylums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhylumId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhylumName;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgPhylums;
        private System.Windows.Forms.TextBox txtKingdomId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer tmrClearMsg;
        private System.Windows.Forms.Label lblParentInfo;
    }
}