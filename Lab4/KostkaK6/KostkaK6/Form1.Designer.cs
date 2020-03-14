namespace KostkaK6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxK6 = new System.Windows.Forms.PictureBox();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMemo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxDices = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxK6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(90, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "KOSTKA DO GRY";
            // 
            // pictureBoxK6
            // 
            this.pictureBoxK6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxK6.ErrorImage = null;
            this.pictureBoxK6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxK6.Image")));
            this.pictureBoxK6.Location = new System.Drawing.Point(96, 107);
            this.pictureBoxK6.Name = "pictureBoxK6";
            this.pictureBoxK6.Size = new System.Drawing.Size(134, 123);
            this.pictureBoxK6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxK6.TabIndex = 1;
            this.pictureBoxK6.TabStop = false;
            this.pictureBoxK6.Click += new System.EventHandler(this.copyScoreToClip);
            // 
            // buttonRoll
            // 
            this.buttonRoll.FlatAppearance.BorderSize = 0;
            this.buttonRoll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonRoll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoll.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRoll.Location = new System.Drawing.Point(0, 279);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(525, 41);
            this.buttonRoll.TabIndex = 2;
            this.buttonRoll.Text = "RZUĆ KOSTKĄ !";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.RollTheDice);
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Segoe Script", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.Location = new System.Drawing.Point(298, 105);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(135, 123);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "5";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 90);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(525, 106);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(8, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "R - rzuć kostką";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(337, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "ESCAPE - wyjdź z gry";
            // 
            // labelMemo
            // 
            this.labelMemo.AutoSize = true;
            this.labelMemo.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMemo.Location = new System.Drawing.Point(12, 236);
            this.labelMemo.Name = "labelMemo";
            this.labelMemo.Size = new System.Drawing.Size(221, 27);
            this.labelMemo.TabIndex = 8;
            this.labelMemo.Text = "ZAPAMIĘTANE RZUTY: ";
            this.labelMemo.Click += new System.EventHandler(this.Memo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(138, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "C - wyczyść zapamiętane";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.label6.Location = new System.Drawing.Point(98, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "wciśnij K lub kliknij na kostkę aby skopiować wynik do schowka";
            // 
            // pictureBoxDices
            // 
            this.pictureBoxDices.BackColor = System.Drawing.Color.Black;
            this.pictureBoxDices.ErrorImage = null;
            this.pictureBoxDices.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDices.Image")));
            this.pictureBoxDices.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxDices.Name = "pictureBoxDices";
            this.pictureBoxDices.Size = new System.Drawing.Size(79, 72);
            this.pictureBoxDices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDices.TabIndex = 9;
            this.pictureBoxDices.TabStop = false;
            this.pictureBoxDices.Click += new System.EventHandler(this.copyScoreToClip);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(525, 372);
            this.Controls.Add(this.pictureBoxDices);
            this.Controls.Add(this.labelMemo);
            this.Controls.Add(this.pictureBoxK6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rzut kostką";
            this.Load += new System.EventHandler(this.RollTheDice);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyMenu);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxK6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxK6;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMemo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxDices;
    }
}

