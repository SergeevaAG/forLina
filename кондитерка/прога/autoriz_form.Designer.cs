namespace Konditerka
{
    partial class autoriz_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autoriz_form));
            this.btnVhod = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnVyhod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textParol = new System.Windows.Forms.TextBox();
            this.labMess = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVhod
            // 
            this.btnVhod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnVhod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVhod.Location = new System.Drawing.Point(436, 405);
            this.btnVhod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVhod.Name = "btnVhod";
            this.btnVhod.Size = new System.Drawing.Size(309, 52);
            this.btnVhod.TabIndex = 0;
            this.btnVhod.Text = "Войти";
            this.btnVhod.UseVisualStyleBackColor = true;
            this.btnVhod.Click += new System.EventHandler(this.btnVhod_Click);
            // 
            // btnReg
            // 
            this.btnReg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnReg.Location = new System.Drawing.Point(436, 465);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(309, 52);
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnVyhod
            // 
            this.btnVyhod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnVyhod.Location = new System.Drawing.Point(436, 526);
            this.btnVyhod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVyhod.Name = "btnVyhod";
            this.btnVyhod.Size = new System.Drawing.Size(309, 52);
            this.btnVyhod.TabIndex = 2;
            this.btnVyhod.Text = "Выйти";
            this.btnVyhod.UseVisualStyleBackColor = true;
            this.btnVyhod.Click += new System.EventHandler(this.btnVyhod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(526, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вход в систему";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(453, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(453, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(555, 211);
            this.textLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(148, 28);
            this.textLogin.TabIndex = 6;
            // 
            // textParol
            // 
            this.textParol.Location = new System.Drawing.Point(555, 282);
            this.textParol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textParol.Name = "textParol";
            this.textParol.Size = new System.Drawing.Size(148, 28);
            this.textParol.TabIndex = 7;
            this.textParol.UseSystemPasswordChar = true;
            this.textParol.TextChanged += new System.EventHandler(this.textParol_TextChanged);
            // 
            // labMess
            // 
            this.labMess.AutoSize = true;
            this.labMess.Location = new System.Drawing.Point(458, 351);
            this.labMess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMess.Name = "labMess";
            this.labMess.Size = new System.Drawing.Size(0, 20);
            this.labMess.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(812, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(13, 641);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(59, 39);
            this.btnStat.TabIndex = 10;
            this.btnStat.Text = "ОС";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autoriz_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1368, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labMess);
            this.Controls.Add(this.textParol);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVyhod);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnVhod);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "autoriz_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.autoriz_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVhod;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnVyhod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textParol;
        private System.Windows.Forms.Label labMess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Button button1;
    }
}

