namespace FormLoginA
{
    partial class Form2
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
            this.labelWitaj = new System.Windows.Forms.Label();
            this.labelUserL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWitaj
            // 
            this.labelWitaj.AutoSize = true;
            this.labelWitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWitaj.Location = new System.Drawing.Point(12, 9);
            this.labelWitaj.Name = "labelWitaj";
            this.labelWitaj.Size = new System.Drawing.Size(121, 39);
            this.labelWitaj.TabIndex = 0;
            this.labelWitaj.Text = "WITAJ";
            // 
            // labelUserL
            // 
            this.labelUserL.AutoSize = true;
            this.labelUserL.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelUserL.Location = new System.Drawing.Point(12, 66);
            this.labelUserL.Name = "labelUserL";
            this.labelUserL.Size = new System.Drawing.Size(210, 73);
            this.labelUserL.TabIndex = 1;
            this.labelUserL.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 158);
            this.Controls.Add(this.labelUserL);
            this.Controls.Add(this.labelWitaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Witaj";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWitaj;
        private System.Windows.Forms.Label labelUserL;
    }
}