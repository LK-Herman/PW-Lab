namespace wizytowka
{
    partial class FormShow2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShow2));
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdres1 = new System.Windows.Forms.Label();
            this.labelAdres2 = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 32.25F);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(343, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(259, 59);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Jan Kowalski";
            // 
            // labelAdres1
            // 
            this.labelAdres1.AutoSize = true;
            this.labelAdres1.BackColor = System.Drawing.Color.Transparent;
            this.labelAdres1.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.labelAdres1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAdres1.Location = new System.Drawing.Point(347, 155);
            this.labelAdres1.Name = "labelAdres1";
            this.labelAdres1.Size = new System.Drawing.Size(139, 30);
            this.labelAdres1.TabIndex = 1;
            this.labelAdres1.Text = "Kościuszki 59";
            // 
            // labelAdres2
            // 
            this.labelAdres2.AutoSize = true;
            this.labelAdres2.BackColor = System.Drawing.Color.Transparent;
            this.labelAdres2.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.labelAdres2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAdres2.Location = new System.Drawing.Point(347, 188);
            this.labelAdres2.Name = "labelAdres2";
            this.labelAdres2.Size = new System.Drawing.Size(184, 30);
            this.labelAdres2.TabIndex = 1;
            this.labelAdres2.Text = "02-264 Warszawa";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.BackColor = System.Drawing.Color.Transparent;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.labelTel.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTel.Location = new System.Drawing.Point(347, 221);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(178, 30);
            this.labelTel.TabIndex = 1;
            this.labelTel.Text = "+48 507 666 888";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.labelEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelEmail.Location = new System.Drawing.Point(347, 254);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(294, 30);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "janek.kowalski@wizytowka.pl";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormShow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(807, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelAdres2);
            this.Controls.Add(this.labelAdres1);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormShow2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WIZYTÓWKA";
            this.Load += new System.EventHandler(this.FormShow2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.q_quit);
            
            this.labelName.MouseLeave += new System.EventHandler(this.labelName_MouseLeave);
            this.labelName.MouseHover += new System.EventHandler(this.labelName_MouseHover);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdres1;
        private System.Windows.Forms.Label labelAdres2;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}