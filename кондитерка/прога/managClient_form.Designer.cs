namespace Konditerka
{
    partial class managClient_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managClient_form));
            this.btnVyhod = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainproviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofingredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characteristicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSet = new Konditerka.projekt2DataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vendorcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitmeasuringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primarysupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.typeofcakedecoratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasepriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakeDecoratingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new Konditerka.projekt2DataSetTableAdapters.ingredientTableAdapter();
            this.cake_decoratingTableAdapter = new Konditerka.projekt2DataSetTableAdapters.cake_decoratingTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderTableAdapter = new Konditerka.projekt2DataSetTableAdapters.orderTableAdapter();
            this.lbOS = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDecoratingBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVyhod
            // 
            this.btnVyhod.Location = new System.Drawing.Point(1393, 689);
            this.btnVyhod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVyhod.Name = "btnVyhod";
            this.btnVyhod.Size = new System.Drawing.Size(168, 48);
            this.btnVyhod.TabIndex = 3;
            this.btnVyhod.Text = "Назад";
            this.btnVyhod.UseVisualStyleBackColor = true;
            this.btnVyhod.Click += new System.EventHandler(this.btnVyhod_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1353, 668);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1345, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ингредиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorcodeDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.unitDataGridViewImageColumn,
            this.numberDataGridViewTextBoxColumn,
            this.mainproviderDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn,
            this.typeofingredientDataGridViewTextBoxColumn,
            this.purchasepriceDataGridViewTextBoxColumn,
            this.gOSTDataGridViewTextBoxColumn,
            this.packingDataGridViewTextBoxColumn,
            this.characteristicDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ingredientBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1337, 625);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vendorcodeDataGridViewTextBoxColumn
            // 
            this.vendorcodeDataGridViewTextBoxColumn.DataPropertyName = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn.HeaderText = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn.Name = "vendorcodeDataGridViewTextBoxColumn";
            this.vendorcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewImageColumn
            // 
            this.unitDataGridViewImageColumn.DataPropertyName = "unit";
            this.unitDataGridViewImageColumn.HeaderText = "unit";
            this.unitDataGridViewImageColumn.Name = "unitDataGridViewImageColumn";
            this.unitDataGridViewImageColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mainproviderDataGridViewTextBoxColumn
            // 
            this.mainproviderDataGridViewTextBoxColumn.DataPropertyName = "main_provider";
            this.mainproviderDataGridViewTextBoxColumn.HeaderText = "main_provider";
            this.mainproviderDataGridViewTextBoxColumn.Name = "mainproviderDataGridViewTextBoxColumn";
            this.mainproviderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "picture";
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            this.pictureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeofingredientDataGridViewTextBoxColumn
            // 
            this.typeofingredientDataGridViewTextBoxColumn.DataPropertyName = "type_of_ingredient";
            this.typeofingredientDataGridViewTextBoxColumn.HeaderText = "type_of_ingredient";
            this.typeofingredientDataGridViewTextBoxColumn.Name = "typeofingredientDataGridViewTextBoxColumn";
            this.typeofingredientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasepriceDataGridViewTextBoxColumn
            // 
            this.purchasepriceDataGridViewTextBoxColumn.DataPropertyName = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.HeaderText = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.Name = "purchasepriceDataGridViewTextBoxColumn";
            this.purchasepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gOSTDataGridViewTextBoxColumn
            // 
            this.gOSTDataGridViewTextBoxColumn.DataPropertyName = "GOST";
            this.gOSTDataGridViewTextBoxColumn.HeaderText = "GOST";
            this.gOSTDataGridViewTextBoxColumn.Name = "gOSTDataGridViewTextBoxColumn";
            this.gOSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packingDataGridViewTextBoxColumn
            // 
            this.packingDataGridViewTextBoxColumn.DataPropertyName = "packing";
            this.packingDataGridViewTextBoxColumn.HeaderText = "packing";
            this.packingDataGridViewTextBoxColumn.Name = "packingDataGridViewTextBoxColumn";
            this.packingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // characteristicDataGridViewTextBoxColumn
            // 
            this.characteristicDataGridViewTextBoxColumn.DataPropertyName = "characteristic";
            this.characteristicDataGridViewTextBoxColumn.HeaderText = "characteristic";
            this.characteristicDataGridViewTextBoxColumn.Name = "characteristicDataGridViewTextBoxColumn";
            this.characteristicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "ingredient";
            this.ingredientBindingSource.DataSource = this.projekt2DataSet;
            // 
            // projekt2DataSet
            // 
            this.projekt2DataSet.DataSetName = "projekt2DataSet";
            this.projekt2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1345, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Украшения для тортов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorcodeDataGridViewTextBoxColumn1,
            this.productnameDataGridViewTextBoxColumn1,
            this.unitmeasuringDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.primarysupplierDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.typeofcakedecoratingDataGridViewTextBoxColumn,
            this.purchasepriceDataGridViewTextBoxColumn1,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cakeDecoratingBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1337, 625);
            this.dataGridView2.TabIndex = 0;
            // 
            // vendorcodeDataGridViewTextBoxColumn1
            // 
            this.vendorcodeDataGridViewTextBoxColumn1.DataPropertyName = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn1.HeaderText = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn1.Name = "vendorcodeDataGridViewTextBoxColumn1";
            this.vendorcodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn1
            // 
            this.productnameDataGridViewTextBoxColumn1.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn1.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn1.Name = "productnameDataGridViewTextBoxColumn1";
            this.productnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unitmeasuringDataGridViewTextBoxColumn
            // 
            this.unitmeasuringDataGridViewTextBoxColumn.DataPropertyName = "unit_measuring";
            this.unitmeasuringDataGridViewTextBoxColumn.HeaderText = "unit_measuring";
            this.unitmeasuringDataGridViewTextBoxColumn.Name = "unitmeasuringDataGridViewTextBoxColumn";
            this.unitmeasuringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primarysupplierDataGridViewTextBoxColumn
            // 
            this.primarysupplierDataGridViewTextBoxColumn.DataPropertyName = "primary_supplier";
            this.primarysupplierDataGridViewTextBoxColumn.HeaderText = "primary_supplier";
            this.primarysupplierDataGridViewTextBoxColumn.Name = "primarysupplierDataGridViewTextBoxColumn";
            this.primarysupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // typeofcakedecoratingDataGridViewTextBoxColumn
            // 
            this.typeofcakedecoratingDataGridViewTextBoxColumn.DataPropertyName = "type_of_cake_decorating";
            this.typeofcakedecoratingDataGridViewTextBoxColumn.HeaderText = "type_of_cake_decorating";
            this.typeofcakedecoratingDataGridViewTextBoxColumn.Name = "typeofcakedecoratingDataGridViewTextBoxColumn";
            this.typeofcakedecoratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasepriceDataGridViewTextBoxColumn1
            // 
            this.purchasepriceDataGridViewTextBoxColumn1.DataPropertyName = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn1.HeaderText = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn1.Name = "purchasepriceDataGridViewTextBoxColumn1";
            this.purchasepriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cakeDecoratingBindingSource
            // 
            this.cakeDecoratingBindingSource.DataMember = "cake decorating";
            this.cakeDecoratingBindingSource.DataSource = this.projekt2DataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1345, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1598, 97);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 51);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1598, 8);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 80);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Применить\r\nизменения";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1572, 629);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.projekt2DataSet;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // cake_decoratingTableAdapter
            // 
            this.cake_decoratingTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1379, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // lbOS
            // 
            this.lbOS.AutoSize = true;
            this.lbOS.Location = new System.Drawing.Point(1378, 295);
            this.lbOS.Name = "lbOS";
            this.lbOS.Size = new System.Drawing.Size(0, 20);
            this.lbOS.TabIndex = 7;
            this.lbOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managClient_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1652, 768);
            this.Controls.Add(this.lbOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVyhod);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "managClient_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер по работе с клиентами";
            this.Load += new System.EventHandler(this.managClient_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDecoratingBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVyhod;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private projekt2DataSet projekt2DataSet;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private projekt2DataSetTableAdapters.ingredientTableAdapter ingredientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn unitDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainproviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofingredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characteristicDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cakeDecoratingBindingSource;
        private projekt2DataSetTableAdapters.cake_decoratingTableAdapter cake_decoratingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitmeasuringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primarysupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofcakedecoratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasepriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private projekt2DataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Label lbOS;
    }
}