namespace Darwin.WindowsForm
{
    partial class SpeciesColourUC
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
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.BackColor = System.Drawing.Color.SteelBlue;
            this.rbBlue.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBlue.Location = new System.Drawing.Point(0, -1);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(41, 17);
            this.rbBlue.TabIndex = 0;
            this.rbBlue.Text = "          ";
            this.rbBlue.UseVisualStyleBackColor = false;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.BackColor = System.Drawing.Color.Green;
            this.rbGreen.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbGreen.Location = new System.Drawing.Point(169, -1);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(41, 17);
            this.rbGreen.TabIndex = 1;
            this.rbGreen.Text = "          ";
            this.rbGreen.UseVisualStyleBackColor = false;
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.BackColor = System.Drawing.Color.White;
            this.rbWhite.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbWhite.Location = new System.Drawing.Point(126, -1);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(41, 17);
            this.rbWhite.TabIndex = 2;
            this.rbWhite.Text = "          ";
            this.rbWhite.UseVisualStyleBackColor = false;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.BackColor = System.Drawing.Color.Red;
            this.rbRed.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRed.Location = new System.Drawing.Point(84, -1);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(41, 17);
            this.rbRed.TabIndex = 3;
            this.rbRed.Text = "          ";
            this.rbRed.UseVisualStyleBackColor = false;
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.BackColor = System.Drawing.Color.Yellow;
            this.rbYellow.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbYellow.Location = new System.Drawing.Point(42, -1);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(41, 17);
            this.rbYellow.TabIndex = 4;
            this.rbYellow.Text = "          ";
            this.rbYellow.UseVisualStyleBackColor = false;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(212, -1);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(44, 17);
            this.rbNone.TabIndex = 5;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "           ";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // SpeciesColourUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbYellow);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.rbWhite);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbBlue);
            this.Name = "SpeciesColourUC";
            this.Size = new System.Drawing.Size(260, 17);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbNone;
    }
}
