namespace Konditerka
{
    partial class managZakup_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managZakup_form));
            this.btnVyhod = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.butUp = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.numberorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsiblemanagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofcompletionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workexamplesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new Konditerka.projekt2DataSetTableAdapters.ingredientTableAdapter();
            this.cake_decoratingTableAdapter = new Konditerka.projekt2DataSetTableAdapters.cake_decoratingTableAdapter();
            this.orderTableAdapter = new Konditerka.projekt2DataSetTableAdapters.orderTableAdapter();
            this.lbOS = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDecoratingBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVyhod
            // 
            this.btnVyhod.Location = new System.Drawing.Point(1170, 706);
            this.btnVyhod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVyhod.Name = "btnVyhod";
            this.btnVyhod.Size = new System.Drawing.Size(168, 48);
            this.btnVyhod.TabIndex = 3;
            this.btnVyhod.Text = "Выход";
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
            this.tabControl1.Size = new System.Drawing.Size(1416, 678);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbOS);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btDelete);
            this.tabPage1.Controls.Add(this.btUpdate);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1408, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ингредиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1120, 454);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1146, 98);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(112, 51);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(1146, 9);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(112, 80);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "Применить\r\nизменения";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1107, 635);
            this.dataGridView1.TabIndex = 0;
            // 
            // vendorcodeDataGridViewTextBoxColumn
            // 
            this.vendorcodeDataGridViewTextBoxColumn.DataPropertyName = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn.HeaderText = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn.Name = "vendorcodeDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewImageColumn
            // 
            this.unitDataGridViewImageColumn.DataPropertyName = "unit";
            this.unitDataGridViewImageColumn.HeaderText = "unit";
            this.unitDataGridViewImageColumn.Name = "unitDataGridViewImageColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // mainproviderDataGridViewTextBoxColumn
            // 
            this.mainproviderDataGridViewTextBoxColumn.DataPropertyName = "main_provider";
            this.mainproviderDataGridViewTextBoxColumn.HeaderText = "main_provider";
            this.mainproviderDataGridViewTextBoxColumn.Name = "mainproviderDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "picture";
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            // 
            // typeofingredientDataGridViewTextBoxColumn
            // 
            this.typeofingredientDataGridViewTextBoxColumn.DataPropertyName = "type_of_ingredient";
            this.typeofingredientDataGridViewTextBoxColumn.HeaderText = "type_of_ingredient";
            this.typeofingredientDataGridViewTextBoxColumn.Name = "typeofingredientDataGridViewTextBoxColumn";
            // 
            // purchasepriceDataGridViewTextBoxColumn
            // 
            this.purchasepriceDataGridViewTextBoxColumn.DataPropertyName = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.HeaderText = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.Name = "purchasepriceDataGridViewTextBoxColumn";
            // 
            // gOSTDataGridViewTextBoxColumn
            // 
            this.gOSTDataGridViewTextBoxColumn.DataPropertyName = "GOST";
            this.gOSTDataGridViewTextBoxColumn.HeaderText = "GOST";
            this.gOSTDataGridViewTextBoxColumn.Name = "gOSTDataGridViewTextBoxColumn";
            // 
            // packingDataGridViewTextBoxColumn
            // 
            this.packingDataGridViewTextBoxColumn.DataPropertyName = "packing";
            this.packingDataGridViewTextBoxColumn.HeaderText = "packing";
            this.packingDataGridViewTextBoxColumn.Name = "packingDataGridViewTextBoxColumn";
            // 
            // characteristicDataGridViewTextBoxColumn
            // 
            this.characteristicDataGridViewTextBoxColumn.DataPropertyName = "characteristic";
            this.characteristicDataGridViewTextBoxColumn.HeaderText = "characteristic";
            this.characteristicDataGridViewTextBoxColumn.Name = "characteristicDataGridViewTextBoxColumn";
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
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1312, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Украшения для тортов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1146, 98);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1146, 9);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 80);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Применить\r\nизменения";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView2
            // 
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
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(4, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1107, 635);
            this.dataGridView2.TabIndex = 0;
            // 
            // vendorcodeDataGridViewTextBoxColumn1
            // 
            this.vendorcodeDataGridViewTextBoxColumn1.DataPropertyName = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn1.HeaderText = "vendor_code";
            this.vendorcodeDataGridViewTextBoxColumn1.Name = "vendorcodeDataGridViewTextBoxColumn1";
            // 
            // productnameDataGridViewTextBoxColumn1
            // 
            this.productnameDataGridViewTextBoxColumn1.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn1.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn1.Name = "productnameDataGridViewTextBoxColumn1";
            // 
            // unitmeasuringDataGridViewTextBoxColumn
            // 
            this.unitmeasuringDataGridViewTextBoxColumn.DataPropertyName = "unit_measuring";
            this.unitmeasuringDataGridViewTextBoxColumn.HeaderText = "unit_measuring";
            this.unitmeasuringDataGridViewTextBoxColumn.Name = "unitmeasuringDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // primarysupplierDataGridViewTextBoxColumn
            // 
            this.primarysupplierDataGridViewTextBoxColumn.DataPropertyName = "primary_supplier";
            this.primarysupplierDataGridViewTextBoxColumn.HeaderText = "primary_supplier";
            this.primarysupplierDataGridViewTextBoxColumn.Name = "primarysupplierDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // typeofcakedecoratingDataGridViewTextBoxColumn
            // 
            this.typeofcakedecoratingDataGridViewTextBoxColumn.DataPropertyName = "type_of_cake_decorating";
            this.typeofcakedecoratingDataGridViewTextBoxColumn.HeaderText = "type_of_cake_decorating";
            this.typeofcakedecoratingDataGridViewTextBoxColumn.Name = "typeofcakedecoratingDataGridViewTextBoxColumn";
            // 
            // purchasepriceDataGridViewTextBoxColumn1
            // 
            this.purchasepriceDataGridViewTextBoxColumn1.DataPropertyName = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn1.HeaderText = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn1.Name = "purchasepriceDataGridViewTextBoxColumn1";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // cakeDecoratingBindingSource
            // 
            this.cakeDecoratingBindingSource.DataMember = "cake decorating";
            this.cakeDecoratingBindingSource.DataSource = this.projekt2DataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.butUp);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1312, 645);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // butUp
            // 
            this.butUp.Location = new System.Drawing.Point(1146, 9);
            this.butUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butUp.Name = "butUp";
            this.butUp.Size = new System.Drawing.Size(112, 80);
            this.butUp.TabIndex = 4;
            this.butUp.Text = "Применить\r\nизменения";
            this.butUp.UseVisualStyleBackColor = true;
            this.butUp.Click += new System.EventHandler(this.butUp_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberorderDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.ordernameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.responsiblemanagerDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.dateofcompletionDataGridViewTextBoxColumn,
            this.workexamplesDataGridViewImageColumn});
            this.dataGridView3.DataSource = this.orderBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1107, 639);
            this.dataGridView3.TabIndex = 0;
            // 
            // numberorderDataGridViewTextBoxColumn
            // 
            this.numberorderDataGridViewTextBoxColumn.DataPropertyName = "number_order";
            this.numberorderDataGridViewTextBoxColumn.HeaderText = "number_order";
            this.numberorderDataGridViewTextBoxColumn.Name = "numberorderDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // ordernameDataGridViewTextBoxColumn
            // 
            this.ordernameDataGridViewTextBoxColumn.DataPropertyName = "order_name";
            this.ordernameDataGridViewTextBoxColumn.HeaderText = "order_name";
            this.ordernameDataGridViewTextBoxColumn.Name = "ordernameDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // responsiblemanagerDataGridViewTextBoxColumn
            // 
            this.responsiblemanagerDataGridViewTextBoxColumn.DataPropertyName = "responsible_manager";
            this.responsiblemanagerDataGridViewTextBoxColumn.HeaderText = "responsible_manager";
            this.responsiblemanagerDataGridViewTextBoxColumn.Name = "responsiblemanagerDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // dateofcompletionDataGridViewTextBoxColumn
            // 
            this.dateofcompletionDataGridViewTextBoxColumn.DataPropertyName = "date_of_completion";
            this.dateofcompletionDataGridViewTextBoxColumn.HeaderText = "date_of_completion";
            this.dateofcompletionDataGridViewTextBoxColumn.Name = "dateofcompletionDataGridViewTextBoxColumn";
            // 
            // workexamplesDataGridViewImageColumn
            // 
            this.workexamplesDataGridViewImageColumn.DataPropertyName = "work_examples";
            this.workexamplesDataGridViewImageColumn.HeaderText = "work_examples";
            this.workexamplesDataGridViewImageColumn.Name = "workexamplesDataGridViewImageColumn";
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
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // lbOS
            // 
            this.lbOS.AutoSize = true;
            this.lbOS.Location = new System.Drawing.Point(1127, 186);
            this.lbOS.Name = "lbOS";
            this.lbOS.Size = new System.Drawing.Size(0, 20);
            this.lbOS.TabIndex = 5;
            this.lbOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managZakup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1442, 772);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVyhod);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "managZakup_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер по закупкам";
            this.Load += new System.EventHandler(this.managZakup_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeDecoratingBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVyhod;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
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
        private System.Windows.Forms.BindingSource orderBindingSource;
        private projekt2DataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsiblemanagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofcompletionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn workexamplesDataGridViewImageColumn;
        private System.Windows.Forms.Button butUp;
        private System.Windows.Forms.Label lbOS;
    }
}