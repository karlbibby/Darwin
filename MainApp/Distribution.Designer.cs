namespace Darwin.WindowsForm
{
    partial class DistributionPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbScotland = new System.Windows.Forms.CheckBox();
            this.cbNW = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbW = new System.Windows.Forms.CheckBox();
            this.cbE = new System.Windows.Forms.CheckBox();
            this.cbS = new System.Windows.Forms.CheckBox();
            this.cbN = new System.Windows.Forms.CheckBox();
            this.cbIreland = new System.Windows.Forms.CheckBox();
            this.cbNE = new System.Windows.Forms.CheckBox();
            this.cbSW = new System.Windows.Forms.CheckBox();
            this.cbSE = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cbClear = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbScotland
            // 
            this.cbScotland.AutoSize = true;
            this.cbScotland.Location = new System.Drawing.Point(3, 3);
            this.cbScotland.Name = "cbScotland";
            this.cbScotland.Size = new System.Drawing.Size(68, 17);
            this.cbScotland.TabIndex = 3;
            this.cbScotland.Text = "Scotland";
            this.cbScotland.UseVisualStyleBackColor = true;
            this.cbScotland.CheckedChanged += new System.EventHandler(this.cbScotland_CheckedChanged);
            // 
            // cbNW
            // 
            this.cbNW.AutoSize = true;
            this.cbNW.Location = new System.Drawing.Point(76, 3);
            this.cbNW.Name = "cbNW";
            this.cbNW.Size = new System.Drawing.Size(45, 17);
            this.cbNW.TabIndex = 4;
            this.cbNW.Text = "NW";
            this.cbNW.UseVisualStyleBackColor = true;
            this.cbNW.CheckedChanged += new System.EventHandler(this.cbNW_CheckedChanged);
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(127, 26);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(33, 17);
            this.cbC.TabIndex = 5;
            this.cbC.Text = "C";
            this.cbC.UseVisualStyleBackColor = true;
            this.cbC.CheckedChanged += new System.EventHandler(this.cbC_CheckedChanged);
            // 
            // cbW
            // 
            this.cbW.AutoSize = true;
            this.cbW.Location = new System.Drawing.Point(76, 26);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(37, 17);
            this.cbW.TabIndex = 6;
            this.cbW.Text = "W";
            this.cbW.UseVisualStyleBackColor = true;
            this.cbW.CheckedChanged += new System.EventHandler(this.cbW_CheckedChanged);
            // 
            // cbE
            // 
            this.cbE.AutoSize = true;
            this.cbE.Location = new System.Drawing.Point(162, 26);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(33, 17);
            this.cbE.TabIndex = 7;
            this.cbE.Text = "E";
            this.cbE.UseVisualStyleBackColor = true;
            this.cbE.CheckedChanged += new System.EventHandler(this.cbE_CheckedChanged);
            // 
            // cbS
            // 
            this.cbS.AutoSize = true;
            this.cbS.Location = new System.Drawing.Point(127, 49);
            this.cbS.Name = "cbS";
            this.cbS.Size = new System.Drawing.Size(33, 17);
            this.cbS.TabIndex = 8;
            this.cbS.Text = "S";
            this.cbS.UseVisualStyleBackColor = true;
            this.cbS.CheckedChanged += new System.EventHandler(this.cbS_CheckedChanged);
            // 
            // cbN
            // 
            this.cbN.AutoSize = true;
            this.cbN.Location = new System.Drawing.Point(127, 3);
            this.cbN.Name = "cbN";
            this.cbN.Size = new System.Drawing.Size(34, 17);
            this.cbN.TabIndex = 9;
            this.cbN.Text = "N";
            this.cbN.UseVisualStyleBackColor = true;
            this.cbN.CheckedChanged += new System.EventHandler(this.cbN_CheckedChanged);
            // 
            // cbIreland
            // 
            this.cbIreland.AutoSize = true;
            this.cbIreland.Location = new System.Drawing.Point(3, 26);
            this.cbIreland.Name = "cbIreland";
            this.cbIreland.Size = new System.Drawing.Size(58, 17);
            this.cbIreland.TabIndex = 10;
            this.cbIreland.Text = "Ireland";
            this.cbIreland.UseVisualStyleBackColor = true;
            this.cbIreland.CheckedChanged += new System.EventHandler(this.cbIreland_CheckedChanged);
            // 
            // cbNE
            // 
            this.cbNE.AutoSize = true;
            this.cbNE.Location = new System.Drawing.Point(162, 3);
            this.cbNE.Name = "cbNE";
            this.cbNE.Size = new System.Drawing.Size(41, 17);
            this.cbNE.TabIndex = 11;
            this.cbNE.Text = "NE";
            this.cbNE.UseVisualStyleBackColor = true;
            this.cbNE.CheckedChanged += new System.EventHandler(this.cbNE_CheckedChanged);
            // 
            // cbSW
            // 
            this.cbSW.AutoSize = true;
            this.cbSW.Location = new System.Drawing.Point(76, 49);
            this.cbSW.Name = "cbSW";
            this.cbSW.Size = new System.Drawing.Size(44, 17);
            this.cbSW.TabIndex = 12;
            this.cbSW.Text = "SW";
            this.cbSW.UseVisualStyleBackColor = true;
            this.cbSW.CheckedChanged += new System.EventHandler(this.cbSW_CheckedChanged);
            // 
            // cbSE
            // 
            this.cbSE.AutoSize = true;
            this.cbSE.Location = new System.Drawing.Point(162, 49);
            this.cbSE.Name = "cbSE";
            this.cbSE.Size = new System.Drawing.Size(40, 17);
            this.cbSE.TabIndex = 14;
            this.cbSE.Text = "SE";
            this.cbSE.UseVisualStyleBackColor = true;
            this.cbSE.CheckedChanged += new System.EventHandler(this.cbSE_CheckedChanged);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(209, 3);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(37, 17);
            this.cbAll.TabIndex = 15;
            this.cbAll.Text = "All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbClear
            // 
            this.cbClear.AutoSize = true;
            this.cbClear.Location = new System.Drawing.Point(209, 26);
            this.cbClear.Name = "cbClear";
            this.cbClear.Size = new System.Drawing.Size(52, 17);
            this.cbClear.TabIndex = 20;
            this.cbClear.Text = "None";
            this.cbClear.UseVisualStyleBackColor = true;
            this.cbClear.CheckedChanged += new System.EventHandler(this.cbClear_CheckedChanged);
            // 
            // MonthPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbClear);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.cbSE);
            this.Controls.Add(this.cbSW);
            this.Controls.Add(this.cbNE);
            this.Controls.Add(this.cbIreland);
            this.Controls.Add(this.cbN);
            this.Controls.Add(this.cbS);
            this.Controls.Add(this.cbE);
            this.Controls.Add(this.cbW);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.cbNW);
            this.Controls.Add(this.cbScotland);
            this.Name = "MonthPicker";
            this.Size = new System.Drawing.Size(265, 69);
            this.Load += new System.EventHandler(this.MonthPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbScotland;
        private System.Windows.Forms.CheckBox cbNW;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbW;
        private System.Windows.Forms.CheckBox cbE;
        private System.Windows.Forms.CheckBox cbS;
        private System.Windows.Forms.CheckBox cbN;
        private System.Windows.Forms.CheckBox cbIreland;
        private System.Windows.Forms.CheckBox cbNE;
        private System.Windows.Forms.CheckBox cbSW;
        private System.Windows.Forms.CheckBox cbSE;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.CheckBox cbClear;
    }
}
