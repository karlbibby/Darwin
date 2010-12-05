namespace Darwin.WindowsForm
{
    partial class SpeciesFlags
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
            this.cbNocturnal = new Darwin.Objects.SeasonCheckbox();
            this.cbDiurnal = new Darwin.Objects.SeasonCheckbox();
            this.cbEdiable = new Darwin.Objects.SeasonCheckbox();
            this.cbMedicinal = new Darwin.Objects.SeasonCheckbox();
            this.cbBiting = new Darwin.Objects.SeasonCheckbox();
            this.cbStinging = new Darwin.Objects.SeasonCheckbox();
            this.cbIrritant = new Darwin.Objects.SeasonCheckbox();
            this.cbPoisonous = new Darwin.Objects.SeasonCheckbox();
            this.SuspendLayout();
            // 
            // cbNocturnal
            // 
            this.cbNocturnal.AutoSize = true;
            this.cbNocturnal.Location = new System.Drawing.Point(225, 3);
            this.cbNocturnal.Name = "cbNocturnal";
            this.cbNocturnal.SeasonFlag = Darwin.Enum.SpeciesEnumFlags.Nocturnal;
            this.cbNocturnal.Size = new System.Drawing.Size(72, 17);
            this.cbNocturnal.TabIndex = 8;
            this.cbNocturnal.Text = "Nocturnal";
            this.cbNocturnal.UseVisualStyleBackColor = true;
            this.cbNocturnal.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbDiurnal
            // 
            this.cbDiurnal.AutoSize = true;
            this.cbDiurnal.Location = new System.Drawing.Point(225, 26);
            this.cbDiurnal.Name = "cbDiurnal";
            this.cbDiurnal.SeasonFlag = Darwin.Enum.SpeciesEnumFlags.Diurnal;
            this.cbDiurnal.Size = new System.Drawing.Size(59, 17);
            this.cbDiurnal.TabIndex = 7;
            this.cbDiurnal.Text = "Diurnal";
            this.cbDiurnal.UseVisualStyleBackColor = true;
            this.cbDiurnal.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbEdiable
            // 
            this.cbEdiable.AutoSize = true;
            this.cbEdiable.Location = new System.Drawing.Point(84, 3);
            this.cbEdiable.Name = "cbEdiable";
            this.cbEdiable.SeasonFlag = Darwin.Enum.SpeciesEnumFlags.Ediable;
            this.cbEdiable.Size = new System.Drawing.Size(55, 17);
            this.cbEdiable.TabIndex = 6;
            this.cbEdiable.Text = "Edible";
            this.cbEdiable.UseVisualStyleBackColor = true;
            this.cbEdiable.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbMedicinal
            // 
            this.cbMedicinal.AutoSize = true;
            this.cbMedicinal.Location = new System.Drawing.Point(151, 3);
            this.cbMedicinal.Name = "cbMedicinal";
            this.cbMedicinal.SeasonFlag = Darwin.Enum.SpeciesEnumFlags.Medicinal;
            this.cbMedicinal.Size = new System.Drawing.Size(71, 17);
            this.cbMedicinal.TabIndex = 5;
            this.cbMedicinal.Text = "Medicinal";
            this.cbMedicinal.UseVisualStyleBackColor = true;
            this.cbMedicinal.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbBiting
            // 
            this.cbBiting.AutoSize = true;
            this.cbBiting.Location = new System.Drawing.Point(3, 26);
            this.cbBiting.Name = "cbBiting";
            this.cbBiting.SeasonFlag = Darwin.Enum.SpeciesEnumFlags.Biting;
            this.cbBiting.Size = new System.Drawing.Size(52, 17);
            this.cbBiting.TabIndex = 4;
            this.cbBiting.Text = "Biting";
            this.cbBiting.UseVisualStyleBackColor = true;
            this.cbBiting.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbStinging
            // 
            this.cbStinging.AutoSize = true;
            this.cbStinging.Location = new System.Drawing.Point(84, 26);
            this.cbStinging.Name = "cbStinging";
            this.cbStinging.SeasonFlag = Darwin.Enum.SpeciesEnumFlags.Stinging;
            this.cbStinging.Size = new System.Drawing.Size(64, 17);
            this.cbStinging.TabIndex = 3;
            this.cbStinging.Text = "Stinging";
            this.cbStinging.UseVisualStyleBackColor = true;
            this.cbStinging.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbIrritant
            // 
            this.cbIrritant.AutoSize = true;
            this.cbIrritant.Location = new System.Drawing.Point(151, 26);
            this.cbIrritant.Name = "cbIrritant";
            this.cbIrritant.SeasonFlag = Darwin.Enum.SpeciesEnumFlags.Irritant;
            this.cbIrritant.Size = new System.Drawing.Size(55, 17);
            this.cbIrritant.TabIndex = 2;
            this.cbIrritant.Text = "Irritant";
            this.cbIrritant.UseVisualStyleBackColor = true;
            this.cbIrritant.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbPoisonous
            // 
            this.cbPoisonous.AutoSize = true;
            this.cbPoisonous.Location = new System.Drawing.Point(3, 3);
            this.cbPoisonous.Name = "cbPoisonous";
            this.cbPoisonous.SeasonFlag = Darwin.Enum.SpeciesEnumFlags.Poisonous;
            this.cbPoisonous.Size = new System.Drawing.Size(75, 17);
            this.cbPoisonous.TabIndex = 0;
            this.cbPoisonous.Text = "Poisonous";
            this.cbPoisonous.UseVisualStyleBackColor = true;
            this.cbPoisonous.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // SpeciesFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbNocturnal);
            this.Controls.Add(this.cbDiurnal);
            this.Controls.Add(this.cbEdiable);
            this.Controls.Add(this.cbMedicinal);
            this.Controls.Add(this.cbBiting);
            this.Controls.Add(this.cbStinging);
            this.Controls.Add(this.cbIrritant);
            this.Controls.Add(this.cbPoisonous);
            this.Name = "SpeciesFlags";
            this.Size = new System.Drawing.Size(294, 45);
            this.Load += new System.EventHandler(this.SpeciesFlags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Objects.SeasonCheckbox cbNocturnal;
        private Objects.SeasonCheckbox cbDiurnal;
        private Objects.SeasonCheckbox cbPoisonous;
        private Objects.SeasonCheckbox cbIrritant;
        private Objects.SeasonCheckbox cbStinging;
        private Objects.SeasonCheckbox cbBiting;
        private Objects.SeasonCheckbox cbMedicinal;
        private Objects.SeasonCheckbox cbEdiable;

    }
}
