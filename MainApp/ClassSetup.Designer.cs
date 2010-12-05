namespace Darwin.WindowsForm
{
    partial class ClassSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassSetup));
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgClasss = new System.Windows.Forms.DataGridView();
            this.txtPhylumId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tmrClearMsg = new System.Windows.Forms.Timer(this.components);
            this.lblParentInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasss)).BeginInit();
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
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(419, 12);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.ReadOnly = true;
            this.txtClassId.Size = new System.Drawing.Size(100, 20);
            this.txtClassId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order Name";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(419, 38);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(250, 20);
            this.txtClassName.TabIndex = 13;
            // 
            // btnOrders
            // 
            this.btnOrders.Enabled = false;
            this.btnOrders.Location = new System.Drawing.Point(419, 128);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(320, 23);
            this.btnOrders.TabIndex = 12;
            this.btnOrders.Text = "Edit Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnClasses_Click);
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
            // dgClasss
            // 
            this.dgClasss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClasss.Location = new System.Drawing.Point(12, 12);
            this.dgClasss.Name = "dgClasss";
            this.dgClasss.Size = new System.Drawing.Size(397, 428);
            this.dgClasss.TabIndex = 9;
            this.dgClasss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClasss_CellClick);
            this.dgClasss.SelectionChanged += new System.EventHandler(this.dgClasss_SelectionChanged);
            // 
            // txtPhylumId
            // 
            this.txtPhylumId.Location = new System.Drawing.Point(12, 446);
            this.txtPhylumId.Name = "txtPhylumId";
            this.txtPhylumId.ReadOnly = true;
            this.txtPhylumId.Size = new System.Drawing.Size(100, 20);
            this.txtPhylumId.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phylum Id";
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
            this.lblParentInfo.Location = new System.Drawing.Point(419, 201);
            this.lblParentInfo.Name = "lblParentInfo";
            this.lblParentInfo.Size = new System.Drawing.Size(35, 13);
            this.lblParentInfo.TabIndex = 21;
            this.lblParentInfo.Text = "label4";
            // 
            // ClassSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.lblParentInfo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhylumId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgClasss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClassSetup";
            this.Text = "Class Setup";
            this.Load += new System.EventHandler(this.ClassSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClasss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgClasss;
        private System.Windows.Forms.TextBox txtPhylumId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer tmrClearMsg;
        private System.Windows.Forms.Label lblParentInfo;
    }
}