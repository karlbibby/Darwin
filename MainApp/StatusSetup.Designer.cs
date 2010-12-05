namespace Darwin.WindowsForm
{
    partial class StatusSetup
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatusId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatusName = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgStatus = new System.Windows.Forms.DataGridView();
            this.tmrClearMsg = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(419, 158);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 18;
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
            this.label2.TabIndex = 17;
            this.label2.Text = "Id";
            // 
            // txtStatusId
            // 
            this.txtStatusId.Location = new System.Drawing.Point(419, 12);
            this.txtStatusId.Name = "txtStatusId";
            this.txtStatusId.ReadOnly = true;
            this.txtStatusId.Size = new System.Drawing.Size(100, 20);
            this.txtStatusId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Status";
            // 
            // txtStatusName
            // 
            this.txtStatusName.Location = new System.Drawing.Point(419, 38);
            this.txtStatusName.Name = "txtStatusName";
            this.txtStatusName.Size = new System.Drawing.Size(234, 20);
            this.txtStatusName.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(513, 99);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(225, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Add New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(319, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgStatus
            // 
            this.dgStatus.AllowUserToAddRows = false;
            this.dgStatus.AllowUserToDeleteRows = false;
            this.dgStatus.AllowUserToResizeRows = false;
            this.dgStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatus.Location = new System.Drawing.Point(12, 12);
            this.dgStatus.MultiSelect = false;
            this.dgStatus.Name = "dgStatus";
            this.dgStatus.ReadOnly = true;
            this.dgStatus.Size = new System.Drawing.Size(397, 451);
            this.dgStatus.TabIndex = 10;
            this.dgStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStatus_CellClick);
            this.dgStatus.SelectionChanged += new System.EventHandler(this.dgStatus_SelectionChanged);
            // 
            // tmrClearMsg
            // 
            this.tmrClearMsg.Interval = 1000;
            this.tmrClearMsg.Tick += new System.EventHandler(this.tmrClearMsg_Tick);
            // 
            // StatusSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 558);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatusName);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgStatus);
            this.Name = "StatusSetup";
            this.Text = "StatusSetup";
            this.Load += new System.EventHandler(this.StatusSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatusId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatusName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgStatus;
        private System.Windows.Forms.Timer tmrClearMsg;
    }
}