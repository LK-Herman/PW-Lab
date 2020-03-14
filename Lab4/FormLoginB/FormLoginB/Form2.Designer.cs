namespace FormLoginB
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
            System.Windows.Forms.Button buttonClose;
            this.labelWitaj = new System.Windows.Forms.Label();
            this.labelUserL = new System.Windows.Forms.Label();
            buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWitaj
            // 
            this.labelWitaj.AutoSize = true;
            this.labelWitaj.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWitaj.ForeColor = System.Drawing.Color.White;
            this.labelWitaj.Location = new System.Drawing.Point(144, 20);
            this.labelWitaj.Name = "labelWitaj";
            this.labelWitaj.Size = new System.Drawing.Size(164, 65);
            this.labelWitaj.TabIndex = 0;
            this.labelWitaj.Text = "WITAJ";
            this.labelWitaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserL
            // 
            this.labelUserL.AutoSize = true;
            this.labelUserL.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.labelUserL.Location = new System.Drawing.Point(146, 94);
            this.labelUserL.Name = "labelUserL";
            this.labelUserL.Size = new System.Drawing.Size(161, 65);
            this.labelUserL.TabIndex = 1;
            this.labelUserL.Text = "label2";
            this.labelUserL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonClose.ForeColor = System.Drawing.Color.White;
            buttonClose.Location = new System.Drawing.Point(63, 208);
            buttonClose.Margin = new System.Windows.Forms.Padding(0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(327, 48);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "EXIT";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(458, 280);
            this.Controls.Add(buttonClose);
            this.Controls.Add(this.labelUserL);
            this.Controls.Add(this.labelWitaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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