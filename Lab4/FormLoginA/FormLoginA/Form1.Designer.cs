namespace FormLoginA
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
            this.labelLog = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLog.ForeColor = System.Drawing.Color.White;
            this.labelLog.Location = new System.Drawing.Point(100, 19);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(161, 26);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "ZALOGUJ SIĘ:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelUser.Location = new System.Drawing.Point(42, 77);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(83, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "UŻYTKOWNIK:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(131, 74);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(188, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPass.Location = new System.Drawing.Point(78, 103);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(47, 13);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "HASŁO:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(131, 100);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(188, 20);
            this.textBoxPass.TabIndex = 2;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.White;
            this.buttonGo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGo.FlatAppearance.BorderSize = 2;
            this.buttonGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGo.Location = new System.Drawing.Point(45, 166);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(274, 35);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "WEJDŹ";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.BackColor = System.Drawing.Color.Transparent;
            this.labelComment.ForeColor = System.Drawing.Color.Orange;
            this.labelComment.Location = new System.Drawing.Point(128, 135);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(0, 13);
            this.labelComment.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(365, 224);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelComment;
    }
}

