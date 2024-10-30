namespace IOOP_Assignent2
{
    partial class View_Request
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
            this.btnCLose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._LOGINDATABASE__1_DataSet = new IOOP_Assignent2._LOGINDATABASE__1_DataSet();
            this.mainRequestTableAdapter = new IOOP_Assignent2._LOGINDATABASE__1_DataSetTableAdapters.MainRequestTableAdapter();
            this.mainRequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINDATABASE1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LOGINDATABASE__1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRequestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINDATABASE1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(496, 385);
            this.btnCLose.Margin = new System.Windows.Forms.Padding(4);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(180, 58);
            this.btnCLose.TabIndex = 3;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1191, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main_Requst";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.totalFeeDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.workerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mainRequestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalFeeDataGridViewTextBoxColumn
            // 
            this.totalFeeDataGridViewTextBoxColumn.DataPropertyName = "TotalFee";
            this.totalFeeDataGridViewTextBoxColumn.HeaderText = "TotalFee";
            this.totalFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalFeeDataGridViewTextBoxColumn.Name = "totalFeeDataGridViewTextBoxColumn";
            this.totalFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            this.workerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mainRequestBindingSource
            // 
            this.mainRequestBindingSource.DataMember = "MainRequest";
            this.mainRequestBindingSource.DataSource = this._LOGINDATABASE__1_DataSet;
            // 
            // _LOGINDATABASE__1_DataSet
            // 
            this._LOGINDATABASE__1_DataSet.DataSetName = "_LOGINDATABASE__1_DataSet";
            this._LOGINDATABASE__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainRequestTableAdapter
            // 
            this.mainRequestTableAdapter.ClearBeforeFill = true;
            // 
            // mainRequestBindingSource1
            // 
            this.mainRequestBindingSource1.DataMember = "MainRequest";
            this.mainRequestBindingSource1.DataSource = this._LOGINDATABASE__1_DataSet;
            // 
            // lOGINDATABASE1DataSetBindingSource
            // 
            this.lOGINDATABASE1DataSetBindingSource.DataSource = this._LOGINDATABASE__1_DataSet;
            this.lOGINDATABASE1DataSetBindingSource.Position = 0;
            // 
            // View_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 450);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.groupBox1);
            this.Name = "View_Request";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_Request_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LOGINDATABASE__1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRequestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINDATABASE1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.GroupBox groupBox1;
        private _LOGINDATABASE__1_DataSet _LOGINDATABASE__1_DataSet;
        private System.Windows.Forms.BindingSource mainRequestBindingSource;
        private _LOGINDATABASE__1_DataSetTableAdapters.MainRequestTableAdapter mainRequestTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mainRequestBindingSource1;
        private System.Windows.Forms.BindingSource lOGINDATABASE1DataSetBindingSource;
    }
}