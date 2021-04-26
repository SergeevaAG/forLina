
namespace Konditerka
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projekt2DataSet = new Konditerka.projekt2DataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Konditerka.projekt2DataSetTableAdapters.userTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Konditerka.projekt2DataSetTableAdapters.orderTableAdapter();
            this.numberorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsiblemanagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofcompletionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workexamplesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.phaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberorderDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.ordernameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.responsiblemanagerDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.dateofcompletionDataGridViewTextBoxColumn,
            this.workexamplesDataGridViewImageColumn,
            this.phaseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // projekt2DataSet
            // 
            this.projekt2DataSet.DataSetName = "projekt2DataSet";
            this.projekt2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.projekt2DataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчет: заказы";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.projekt2DataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
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
            // phaseDataGridViewTextBoxColumn
            // 
            this.phaseDataGridViewTextBoxColumn.DataPropertyName = "phase";
            this.phaseDataGridViewTextBoxColumn.HeaderText = "phase";
            this.phaseDataGridViewTextBoxColumn.Name = "phaseDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Отчет: заказы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projekt2DataSet projekt2DataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private projekt2DataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn phaseDataGridViewTextBoxColumn;
    }
}