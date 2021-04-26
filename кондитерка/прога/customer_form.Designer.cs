namespace Konditerka
{
    partial class customer_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_form));
            this.btnVyhod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbError = new System.Windows.Forms.Label();
            this.btnZak = new System.Windows.Forms.Button();
            this.btnRas = new System.Windows.Forms.Button();
            this.lbSumm = new System.Windows.Forms.Label();
            this.picExample = new System.Windows.Forms.PictureBox();
            this.textDescrip = new System.Windows.Forms.TextBox();
            this.textIzd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSet = new Konditerka.projekt2DataSet();
            this.orderTableAdapter = new Konditerka.projekt2DataSetTableAdapters.orderTableAdapter();
            this.textKostil = new System.Windows.Forms.TextBox();
            this.lbOS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVyhod
            // 
            this.btnVyhod.Location = new System.Drawing.Point(728, 706);
            this.btnVyhod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVyhod.Name = "btnVyhod";
            this.btnVyhod.Size = new System.Drawing.Size(168, 48);
            this.btnVyhod.TabIndex = 3;
            this.btnVyhod.Text = "Назад";
            this.btnVyhod.UseVisualStyleBackColor = true;
            this.btnVyhod.Click += new System.EventHandler(this.btnVyhod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(161, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1210, 588);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btDelete);
            this.tabPage1.Controls.Add(this.btUpdate);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1202, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заказы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1069, 119);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(112, 51);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(1069, 19);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(112, 80);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Применить\r\nизменения";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1059, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbError);
            this.tabPage2.Controls.Add(this.btnZak);
            this.tabPage2.Controls.Add(this.btnRas);
            this.tabPage2.Controls.Add(this.lbSumm);
            this.tabPage2.Controls.Add(this.picExample);
            this.tabPage2.Controls.Add(this.textDescrip);
            this.tabPage2.Controls.Add(this.textIzd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1202, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Создать заказ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(534, 444);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 20);
            this.lbError.TabIndex = 10;
            // 
            // btnZak
            // 
            this.btnZak.Location = new System.Drawing.Point(538, 482);
            this.btnZak.Name = "btnZak";
            this.btnZak.Size = new System.Drawing.Size(198, 34);
            this.btnZak.TabIndex = 9;
            this.btnZak.Text = "Оформить заказ";
            this.btnZak.UseVisualStyleBackColor = true;
            this.btnZak.Click += new System.EventHandler(this.btnZak_Click);
            // 
            // btnRas
            // 
            this.btnRas.Location = new System.Drawing.Point(657, 102);
            this.btnRas.Name = "btnRas";
            this.btnRas.Size = new System.Drawing.Size(198, 34);
            this.btnRas.TabIndex = 8;
            this.btnRas.Text = "Расчитать стоимость";
            this.btnRas.UseVisualStyleBackColor = true;
            this.btnRas.Click += new System.EventHandler(this.btnRas_Click);
            // 
            // lbSumm
            // 
            this.lbSumm.AutoSize = true;
            this.lbSumm.Location = new System.Drawing.Point(716, 54);
            this.lbSumm.Name = "lbSumm";
            this.lbSumm.Size = new System.Drawing.Size(0, 20);
            this.lbSumm.TabIndex = 7;
            // 
            // picExample
            // 
            this.picExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picExample.Location = new System.Drawing.Point(304, 259);
            this.picExample.Name = "picExample";
            this.picExample.Size = new System.Drawing.Size(176, 177);
            this.picExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExample.TabIndex = 6;
            this.picExample.TabStop = false;
            this.picExample.Click += new System.EventHandler(this.picExample_Click);
            // 
            // textDescrip
            // 
            this.textDescrip.Location = new System.Drawing.Point(304, 85);
            this.textDescrip.Multiline = true;
            this.textDescrip.Name = "textDescrip";
            this.textDescrip.Size = new System.Drawing.Size(310, 143);
            this.textDescrip.TabIndex = 5;
            // 
            // textIzd
            // 
            this.textIzd.Location = new System.Drawing.Point(304, 46);
            this.textIzd.Name = "textIzd";
            this.textIzd.Size = new System.Drawing.Size(176, 28);
            this.textIzd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Пример работ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Стоимость заказа:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(667, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(281, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование изделия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(281, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Описание заказа:";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.projekt2DataSet;
            // 
            // projekt2DataSet
            // 
            this.projekt2DataSet.DataSetName = "projekt2DataSet";
            this.projekt2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // textKostil
            // 
            this.textKostil.Location = new System.Drawing.Point(407, 84);
            this.textKostil.Name = "textKostil";
            this.textKostil.Size = new System.Drawing.Size(100, 28);
            this.textKostil.TabIndex = 7;
            this.textKostil.Visible = false;
            // 
            // lbOS
            // 
            this.lbOS.AutoSize = true;
            this.lbOS.Location = new System.Drawing.Point(582, 2);
            this.lbOS.Name = "lbOS";
            this.lbOS.Size = new System.Drawing.Size(0, 20);
            this.lbOS.TabIndex = 8;
            this.lbOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1400, 791);
            this.Controls.Add(this.lbOS);
            this.Controls.Add(this.textKostil);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVyhod);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "customer_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказчик";
            this.Load += new System.EventHandler(this.customer_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVyhod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private projekt2DataSet projekt2DataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private projekt2DataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btnZak;
        private System.Windows.Forms.Button btnRas;
        private System.Windows.Forms.Label lbSumm;
        private System.Windows.Forms.PictureBox picExample;
        private System.Windows.Forms.TextBox textDescrip;
        private System.Windows.Forms.TextBox textIzd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKostil;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbOS;
    }
}