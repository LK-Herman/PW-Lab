namespace BMR
{
    partial class FormBMR
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBMR));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMasa = new System.Windows.Forms.Label();
            this.textBoxMasa = new System.Windows.Forms.TextBox();
            this.labelWzrost = new System.Windows.Forms.Label();
            this.textBoxWzrost = new System.Windows.Forms.TextBox();
            this.labelWiek = new System.Windows.Forms.Label();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWynik = new System.Windows.Forms.Label();
            this.labelBMR = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLicz = new System.Windows.Forms.Button();
            this.pictureBoxFit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Basal Metabolic Rate";
            // 
            // labelMasa
            // 
            this.labelMasa.AutoSize = true;
            this.labelMasa.Location = new System.Drawing.Point(50, 56);
            this.labelMasa.Name = "labelMasa";
            this.labelMasa.Size = new System.Drawing.Size(54, 13);
            this.labelMasa.TabIndex = 1;
            this.labelMasa.Text = "Masa (kg)";
            // 
            // textBoxMasa
            // 
            this.textBoxMasa.Location = new System.Drawing.Point(50, 72);
            this.textBoxMasa.Name = "textBoxMasa";
            this.textBoxMasa.Size = new System.Drawing.Size(73, 20);
            this.textBoxMasa.TabIndex = 2;
            // 
            // labelWzrost
            // 
            this.labelWzrost.AutoSize = true;
            this.labelWzrost.Location = new System.Drawing.Point(129, 56);
            this.labelWzrost.Name = "labelWzrost";
            this.labelWzrost.Size = new System.Drawing.Size(63, 13);
            this.labelWzrost.TabIndex = 3;
            this.labelWzrost.Text = "Wzrost (cm)";
            // 
            // textBoxWzrost
            // 
            this.textBoxWzrost.Location = new System.Drawing.Point(129, 72);
            this.textBoxWzrost.Name = "textBoxWzrost";
            this.textBoxWzrost.Size = new System.Drawing.Size(72, 20);
            this.textBoxWzrost.TabIndex = 4;
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(207, 56);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(58, 13);
            this.labelWiek.TabIndex = 5;
            this.labelWiek.Text = "Wiek (lata)";
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(207, 72);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(76, 20);
            this.textBoxWiek.TabIndex = 6;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.comboBoxSex.Location = new System.Drawing.Point(289, 71);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(76, 21);
            this.comboBoxSex.TabIndex = 7;
            this.comboBoxSex.Text = "Kobieta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Płeć";
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.Location = new System.Drawing.Point(177, 273);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(60, 18);
            this.labelWynik.TabIndex = 9;
            this.labelWynik.Text = "WYNIK:";
            this.labelWynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBMR
            // 
            this.labelBMR.AutoSize = true;
            this.labelBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBMR.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelBMR.Location = new System.Drawing.Point(163, 303);
            this.labelBMR.Name = "labelBMR";
            this.labelBMR.Size = new System.Drawing.Size(74, 31);
            this.labelBMR.TabIndex = 10;
            this.labelBMR.Text = "BMR";
            this.labelBMR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(50, 101);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(121, 29);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Wyczyść pola";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLicz
            // 
            this.buttonLicz.Location = new System.Drawing.Point(244, 101);
            this.buttonLicz.Name = "buttonLicz";
            this.buttonLicz.Size = new System.Drawing.Size(121, 29);
            this.buttonLicz.TabIndex = 11;
            this.buttonLicz.Text = "OBLICZ BMR";
            this.buttonLicz.UseVisualStyleBackColor = true;
            this.buttonLicz.Click += new System.EventHandler(this.buttonLicz_Click);
            // 
            // pictureBoxFit
            // 
            this.pictureBoxFit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFit.ErrorImage = null;
            this.pictureBoxFit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFit.Image")));
            this.pictureBoxFit.InitialImage = null;
            this.pictureBoxFit.Location = new System.Drawing.Point(95, 82);
            this.pictureBoxFit.Name = "pictureBoxFit";
            this.pictureBoxFit.Size = new System.Drawing.Size(236, 218);
            this.pictureBoxFit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFit.TabIndex = 12;
            this.pictureBoxFit.TabStop = false;
            // 
            // FormBMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 352);
            this.Controls.Add(this.buttonLicz);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelBMR);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.textBoxWzrost);
            this.Controls.Add(this.labelWzrost);
            this.Controls.Add(this.textBoxMasa);
            this.Controls.Add(this.labelMasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFit);
            this.Name = "FormBMR";
            this.Text = "BMR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMasa;
        private System.Windows.Forms.TextBox textBoxMasa;
        private System.Windows.Forms.Label labelWzrost;
        private System.Windows.Forms.TextBox textBoxWzrost;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Label labelBMR;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLicz;
        private System.Windows.Forms.PictureBox pictureBoxFit;
    }
}

