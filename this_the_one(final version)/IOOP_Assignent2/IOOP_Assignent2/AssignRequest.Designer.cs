namespace IOOP_Assignent2
{
    partial class AssignRequest
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
            this.tbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbworker = new System.Windows.Forms.ComboBox();
            this.lbRequestID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbServiceID = new System.Windows.Forms.TextBox();
            this.tbdate = new System.Windows.Forms.DateTimePicker();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbWorkerID = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStatus
            // 
            this.tbStatus.FormattingEnabled = true;
            this.tbStatus.Items.AddRange(new object[] {
            "Work In Progress",
            "Complete"});
            this.tbStatus.Location = new System.Drawing.Point(532, 311);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(160, 24);
            this.tbStatus.TabIndex = 40;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(411, 316);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(44, 16);
            this.lbStatus.TabIndex = 39;
            this.lbStatus.Text = "Status";
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(532, 226);
            this.tbprice.Margin = new System.Windows.Forms.Padding(4);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(160, 22);
            this.tbprice.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Total Price";
            // 
            // Cbworker
            // 
            this.Cbworker.FormattingEnabled = true;
            this.Cbworker.Location = new System.Drawing.Point(160, 307);
            this.Cbworker.Margin = new System.Windows.Forms.Padding(4);
            this.Cbworker.Name = "Cbworker";
            this.Cbworker.Size = new System.Drawing.Size(160, 24);
            this.Cbworker.TabIndex = 36;
            // 
            // lbRequestID
            // 
            this.lbRequestID.AutoSize = true;
            this.lbRequestID.BackColor = System.Drawing.SystemColors.Window;
            this.lbRequestID.Location = new System.Drawing.Point(156, 85);
            this.lbRequestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRequestID.Name = "lbRequestID";
            this.lbRequestID.Size = new System.Drawing.Size(0, 16);
            this.lbRequestID.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "RequestID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(468, 376);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 52);
            this.button3.TabIndex = 33;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 52);
            this.button1.TabIndex = 32;
            this.button1.Text = "Assign  Request";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbServiceID
            // 
            this.tbServiceID.Location = new System.Drawing.Point(160, 226);
            this.tbServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.tbServiceID.Name = "tbServiceID";
            this.tbServiceID.Size = new System.Drawing.Size(160, 22);
            this.tbServiceID.TabIndex = 31;
            // 
            // tbdate
            // 
            this.tbdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbdate.Location = new System.Drawing.Point(532, 78);
            this.tbdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(238, 22);
            this.tbdate.TabIndex = 30;
            this.tbdate.Value = new System.DateTime(2023, 11, 12, 15, 42, 47, 0);
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(160, 148);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(160, 22);
            this.tbCustomerID.TabIndex = 29;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(532, 143);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(160, 22);
            this.tbQuantity.TabIndex = 28;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(407, 146);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(89, 16);
            this.lbQuantity.TabIndex = 27;
            this.lbQuantity.Text = "Total Quantity";
            // 
            // lbWorkerID
            // 
            this.lbWorkerID.AutoSize = true;
            this.lbWorkerID.Location = new System.Drawing.Point(32, 311);
            this.lbWorkerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWorkerID.Name = "lbWorkerID";
            this.lbWorkerID.Size = new System.Drawing.Size(64, 16);
            this.lbWorkerID.TabIndex = 26;
            this.lbWorkerID.Text = "WorkerID";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(407, 85);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 16);
            this.lbDate.TabIndex = 25;
            this.lbDate.Text = "Date";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(31, 152);
            this.lbCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(77, 16);
            this.lbCustomerID.TabIndex = 24;
            this.lbCustomerID.Text = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "ServiceID";
            // 
            // AssignRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbworker);
            this.Controls.Add(this.lbRequestID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbServiceID);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbWorkerID);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.label1);
            this.Name = "AssignRequest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AssignRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbworker;
        private System.Windows.Forms.Label lbRequestID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbServiceID;
        private System.Windows.Forms.DateTimePicker tbdate;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbWorkerID;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label label1;
    }
}