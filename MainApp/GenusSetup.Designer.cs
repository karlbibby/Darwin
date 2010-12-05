namespace Darwin.WindowsForm
{
    partial class GenusSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenusSetup));
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamilyId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenusId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenusName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgGenus = new System.Windows.Forms.DataGridView();
            this.tmrClearMsg = new System.Windows.Forms.Timer(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblParentInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenus)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Family Id";
            // 
            // txtFamilyId
            // 
            this.txtFamilyId.Location = new System.Drawing.Point(12, 446);
            this.txtFamilyId.Name = "txtFamilyId";
            this.txtFamilyId.Size = new System.Drawing.Size(100, 20);
            this.txtFamilyId.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 28;
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
            this.label2.TabIndex = 27;
            this.label2.Text = "Id";
            // 
            // txtGenusId
            // 
            this.txtGenusId.Location = new System.Drawing.Point(419, 12);
            this.txtGenusId.Name = "txtGenusId";
            this.txtGenusId.Size = new System.Drawing.Size(100, 20);
            this.txtGenusId.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Genus Name";
            // 
            // txtGenusName
            // 
            this.txtGenusName.Location = new System.Drawing.Point(419, 38);
            this.txtGenusName.Name = "txtGenusName";
            this.txtGenusName.Size = new System.Drawing.Size(245, 20);
            this.txtGenusName.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(513, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgGenus
            // 
            this.dgGenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGenus.Location = new System.Drawing.Point(12, 12);
            this.dgGenus.Name = "dgGenus";
            this.dgGenus.Size = new System.Drawing.Size(397, 428);
            this.dgGenus.TabIndex = 20;
            this.dgGenus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGenus_CellClick);
            this.dgGenus.SelectionChanged += new System.EventHandler(this.dgGenus_SelectionChanged);
            // 
            // tmrClearMsg
            // 
            this.tmrClearMsg.Interval = 1500;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(419, 148);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 31;
            // 
            // lblParentInfo
            // 
            this.lblParentInfo.AutoSize = true;
            this.lblParentInfo.Location = new System.Drawing.Point(419, 185);
            this.lblParentInfo.Name = "lblParentInfo";
            this.lblParentInfo.Size = new System.Drawing.Size(35, 13);
            this.lblParentInfo.TabIndex = 32;
            this.lblParentInfo.Text = "label4";
            // 
            // GenusSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.lblParentInfo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFamilyId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGenusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenusName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgGenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenusSetup";
            this.Text = "Genus Setup";
            this.Load += new System.EventHandler(this.GenusSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamilyId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenusId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenusName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgGenus;
        private System.Windows.Forms.Timer tmrClearMsg;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblParentInfo;
    }
}