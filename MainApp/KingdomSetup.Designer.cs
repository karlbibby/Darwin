namespace Darwin.WindowsForm
{
    partial class KingdomSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KingdomSetup));
            this.dgKingdom = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPhylums = new System.Windows.Forms.Button();
            this.txtKingdomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKingdomId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tmrClearMsg = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgKingdom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKingdom
            // 
            this.dgKingdom.AllowUserToAddRows = false;
            this.dgKingdom.AllowUserToDeleteRows = false;
            this.dgKingdom.AllowUserToResizeRows = false;
            this.dgKingdom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKingdom.Location = new System.Drawing.Point(13, 13);
            this.dgKingdom.MultiSelect = false;
            this.dgKingdom.Name = "dgKingdom";
            this.dgKingdom.ReadOnly = true;
            this.dgKingdom.Size = new System.Drawing.Size(397, 451);
            this.dgKingdom.TabIndex = 0;
            this.dgKingdom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKingdom_CellClick);
            this.dgKingdom.SelectionChanged += new System.EventHandler(this.dgKingdom_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(319, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(514, 100);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(225, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Add New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPhylums
            // 
            this.btnPhylums.Enabled = false;
            this.btnPhylums.Location = new System.Drawing.Point(420, 129);
            this.btnPhylums.Name = "btnPhylums";
            this.btnPhylums.Size = new System.Drawing.Size(319, 23);
            this.btnPhylums.TabIndex = 3;
            this.btnPhylums.Text = "Edit Phylums";
            this.btnPhylums.UseVisualStyleBackColor = true;
            this.btnPhylums.Click += new System.EventHandler(this.btnPhylums_Click);
            // 
            // txtKingdomName
            // 
            this.txtKingdomName.Location = new System.Drawing.Point(420, 39);
            this.txtKingdomName.Name = "txtKingdomName";
            this.txtKingdomName.Size = new System.Drawing.Size(234, 20);
            this.txtKingdomName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kingdom Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // txtKingdomId
            // 
            this.txtKingdomId.Location = new System.Drawing.Point(420, 13);
            this.txtKingdomId.Name = "txtKingdomId";
            this.txtKingdomId.ReadOnly = true;
            this.txtKingdomId.Size = new System.Drawing.Size(100, 20);
            this.txtKingdomId.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(420, 159);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // tmrClearMsg
            // 
            this.tmrClearMsg.Interval = 1500;
            this.tmrClearMsg.Tick += new System.EventHandler(this.tmrClearMsg_Tick);
            // 
            // KingdomSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKingdomId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKingdomName);
            this.Controls.Add(this.btnPhylums);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgKingdom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KingdomSetup";
            this.Text = "Kingdom Setup";
            this.Load += new System.EventHandler(this.SystemSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKingdom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKingdom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPhylums;
        private System.Windows.Forms.TextBox txtKingdomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKingdomId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer tmrClearMsg;
    }
}