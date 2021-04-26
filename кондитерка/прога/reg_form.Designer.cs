namespace Konditerka
{
    partial class reg_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_form));
            this.btnRegistr = new System.Windows.Forms.Button();
            this.btnVyhod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labMessage = new System.Windows.Forms.Label();
            this.textFio = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textParol = new System.Windows.Forms.TextBox();
            this.textReParol = new System.Windows.Forms.TextBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.textKostil = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistr
            // 
            this.btnRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btnRegistr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistr.Location = new System.Drawing.Point(260, 479);
            this.btnRegistr.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistr.Name = "btnRegistr";
            this.btnRegistr.Size = new System.Drawing.Size(268, 59);
            this.btnRegistr.TabIndex = 0;
            this.btnRegistr.TabStop = false;
            this.btnRegistr.Text = "Зарегистрироваться";
            this.btnRegistr.UseMnemonic = false;
            this.btnRegistr.UseVisualStyleBackColor = true;
            this.btnRegistr.Click += new System.EventHandler(this.btnRegistr_Click);
            // 
            // btnVyhod
            // 
            this.btnVyhod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVyhod.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVyhod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btnVyhod.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVyhod.Location = new System.Drawing.Point(260, 557);
            this.btnVyhod.Margin = new System.Windows.Forms.Padding(4);
            this.btnVyhod.Name = "btnVyhod";
            this.btnVyhod.Size = new System.Drawing.Size(268, 59);
            this.btnVyhod.TabIndex = 1;
            this.btnVyhod.Text = "Назад";
            this.btnVyhod.UseVisualStyleBackColor = true;
            this.btnVyhod.Click += new System.EventHandler(this.btnVyhod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(100, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(100, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(100, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(100, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Повтор пароля:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(100, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Фотография:";
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Location = new System.Drawing.Point(96, 455);
            this.labMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(0, 20);
            this.labMessage.TabIndex = 8;
            // 
            // textFio
            // 
            this.textFio.Location = new System.Drawing.Point(260, 92);
            this.textFio.Margin = new System.Windows.Forms.Padding(4);
            this.textFio.Name = "textFio";
            this.textFio.Size = new System.Drawing.Size(426, 28);
            this.textFio.TabIndex = 9;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(260, 138);
            this.textLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(426, 28);
            this.textLogin.TabIndex = 10;
            // 
            // textParol
            // 
            this.textParol.Location = new System.Drawing.Point(260, 180);
            this.textParol.Margin = new System.Windows.Forms.Padding(4);
            this.textParol.Name = "textParol";
            this.textParol.Size = new System.Drawing.Size(426, 28);
            this.textParol.TabIndex = 11;
            this.textParol.UseSystemPasswordChar = true;
            // 
            // textReParol
            // 
            this.textReParol.Location = new System.Drawing.Point(260, 222);
            this.textReParol.Margin = new System.Windows.Forms.Padding(4);
            this.textReParol.Name = "textReParol";
            this.textReParol.Size = new System.Drawing.Size(426, 28);
            this.textReParol.TabIndex = 12;
            this.textReParol.UseSystemPasswordChar = true;
            // 
            // picPhoto
            // 
            this.picPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPhoto.InitialImage")));
            this.picPhoto.Location = new System.Drawing.Point(260, 264);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(151, 169);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 13;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            // 
            // textKostil
            // 
            this.textKostil.Location = new System.Drawing.Point(20, 641);
            this.textKostil.Margin = new System.Windows.Forms.Padding(4);
            this.textKostil.Name = "textKostil";
            this.textKostil.Size = new System.Drawing.Size(148, 28);
            this.textKostil.TabIndex = 14;
            this.textKostil.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(720, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reg_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1126, 693);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textKostil);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.textReParol);
            this.Controls.Add(this.textParol);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textFio);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVyhod);
            this.Controls.Add(this.btnRegistr);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reg_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.reg_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVyhod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.TextBox textFio;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textParol;
        private System.Windows.Forms.TextBox textReParol;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TextBox textKostil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistr;
    }
}