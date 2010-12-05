namespace Darwin.WindowsForm
{
    partial class FamilySetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilySetup));
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFamilyId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.btnGenus = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgFamilys = new System.Windows.Forms.DataGridView();
            this.tmrClearMsg = new System.Windows.Forms.Timer(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblParentInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilys)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Order Id";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(12, 446);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(100, 20);
            this.txtOrderId.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 212);
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
            // txtFamilyId
            // 
            this.txtFamilyId.Location = new System.Drawing.Point(419, 12);
            this.txtFamilyId.Name = "txtFamilyId";
            this.txtFamilyId.Size = new System.Drawing.Size(100, 20);
            this.txtFamilyId.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Family Name";
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(419, 38);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(247, 20);
            this.txtFamilyName.TabIndex = 24;
            // 
            // btnGenus
            // 
            this.btnGenus.Location = new System.Drawing.Point(419, 241);
            this.btnGenus.Name = "btnGenus";
            this.btnGenus.Size = new System.Drawing.Size(320, 23);
            this.btnGenus.TabIndex = 23;
            this.btnGenus.Text = "Edit Genus";
            this.btnGenus.UseVisualStyleBackColor = true;
            this.btnGenus.Click += new System.EventHandler(this.btnGenus_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(513, 212);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(226, 23);
            this.btnAddNew.TabIndex = 22;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgFamilys
            // 
            this.dgFamilys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFamilys.Location = new System.Drawing.Point(12, 12);
            this.dgFamilys.Name = "dgFamilys";
            this.dgFamilys.Size = new System.Drawing.Size(397, 428);
            this.dgFamilys.TabIndex = 20;
            this.dgFamilys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFamilys_CellClick);
            this.dgFamilys.SelectionChanged += new System.EventHandler(this.dgFamilys_SelectionChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(419, 271);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 31;
            // 
            // lblParentInfo
            // 
            this.lblParentInfo.AutoSize = true;
            this.lblParentInfo.Location = new System.Drawing.Point(422, 323);
            this.lblParentInfo.Name = "lblParentInfo";
            this.lblParentInfo.Size = new System.Drawing.Size(35, 13);
            this.lblParentInfo.TabIndex = 32;
            this.lblParentInfo.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(419, 64);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(250, 113);
            this.txtNotes.TabIndex = 33;
            // 
            // FamilySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblParentInfo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFamilyId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFamilyName);
            this.Controls.Add(this.btnGenus);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgFamilys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FamilySetup";
            this.Text = "Family Setup";
            this.Load += new System.EventHandler(this.FamilySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFamilyId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.Button btnGenus;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgFamilys;
        private System.Windows.Forms.Timer tmrClearMsg;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblParentInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
    }
}