namespace Darwin.WindowsForm
{
    partial class OrderSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSetup));
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.btnFamily = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tmrClearMsg = new System.Windows.Forms.Timer(this.components);
            this.lblParentInfo = new System.Windows.Forms.Label();
            this.txtNumberinOrder = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 212);
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
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(419, 12);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(100, 20);
            this.txtOrderId.TabIndex = 15;
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
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(419, 38);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(250, 20);
            this.txtOrderName.TabIndex = 13;
            // 
            // btnFamily
            // 
            this.btnFamily.Enabled = false;
            this.btnFamily.Location = new System.Drawing.Point(419, 241);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Size = new System.Drawing.Size(320, 23);
            this.btnFamily.TabIndex = 12;
            this.btnFamily.Text = "Edit Families";
            this.btnFamily.UseVisualStyleBackColor = true;
            this.btnFamily.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(513, 212);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(226, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgOrders
            // 
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(12, 15);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(397, 428);
            this.dgOrders.TabIndex = 9;
            this.dgOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellClick);
            this.dgOrders.SelectionChanged += new System.EventHandler(this.dgOrders_SelectionChanged);
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(12, 446);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.ReadOnly = true;
            this.txtClassId.Size = new System.Drawing.Size(100, 20);
            this.txtClassId.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Class Id";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(426, 271);
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
            this.lblParentInfo.Location = new System.Drawing.Point(426, 296);
            this.lblParentInfo.Name = "lblParentInfo";
            this.lblParentInfo.Size = new System.Drawing.Size(35, 13);
            this.lblParentInfo.TabIndex = 21;
            this.lblParentInfo.Text = "label4";
            // 
            // txtNumberinOrder
            // 
            this.txtNumberinOrder.Location = new System.Drawing.Point(666, 446);
            this.txtNumberinOrder.Name = "txtNumberinOrder";
            this.txtNumberinOrder.Size = new System.Drawing.Size(73, 20);
            this.txtNumberinOrder.TabIndex = 23;
            this.txtNumberinOrder.Visible = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(419, 64);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(250, 113);
            this.txtNotes.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Notes";
            // 
            // OrderSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtNumberinOrder);
            this.Controls.Add(this.lblParentInfo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderName);
            this.Controls.Add(this.btnFamily);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrderSetup";
            this.Text = "Order Setup";
            this.Load += new System.EventHandler(this.OrderSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.Button btnFamily;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer tmrClearMsg;
        private System.Windows.Forms.Label lblParentInfo;
        private System.Windows.Forms.TextBox txtNumberinOrder;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
    }
}