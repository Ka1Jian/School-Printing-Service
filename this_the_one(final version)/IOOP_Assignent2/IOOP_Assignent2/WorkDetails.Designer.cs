namespace IOOP_Assignent2
{
    partial class WorkDetails
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
            this.tbStatus.Location = new System.Drawing.Point(531, 281);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(239, 24);
            this.tbStatus.TabIndex = 76;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(406, 284);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(50, 16);
            this.lbStatus.TabIndex = 75;
            this.lbStatus.Text = "Status";
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(531, 199);
            this.tbprice.Margin = new System.Windows.Forms.Padding(4);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(239, 22);
            this.tbprice.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Total Price";
            // 
            // Cbworker
            // 
            this.Cbworker.FormattingEnabled = true;
            this.Cbworker.Location = new System.Drawing.Point(159, 279);
            this.Cbworker.Margin = new System.Windows.Forms.Padding(4);
            this.Cbworker.Name = "Cbworker";
            this.Cbworker.Size = new System.Drawing.Size(132, 24);
            this.Cbworker.TabIndex = 72;
            // 
            // lbRequestID
            // 
            this.lbRequestID.AutoSize = true;
            this.lbRequestID.BackColor = System.Drawing.SystemColors.Window;
            this.lbRequestID.Location = new System.Drawing.Point(155, 58);
            this.lbRequestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRequestID.Name = "lbRequestID";
            this.lbRequestID.Size = new System.Drawing.Size(0, 16);
            this.lbRequestID.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "RequestID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(487, 349);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 52);
            this.button3.TabIndex = 69;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(107, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 52);
            this.button1.TabIndex = 68;
            this.button1.Text = "Assign  Request";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbServiceID
            // 
            this.tbServiceID.Location = new System.Drawing.Point(159, 199);
            this.tbServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.tbServiceID.Name = "tbServiceID";
            this.tbServiceID.Size = new System.Drawing.Size(132, 22);
            this.tbServiceID.TabIndex = 67;
            // 
            // tbdate
            // 
            this.tbdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbdate.Location = new System.Drawing.Point(531, 50);
            this.tbdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(239, 22);
            this.tbdate.TabIndex = 66;
            this.tbdate.Value = new System.DateTime(2023, 11, 12, 15, 42, 47, 0);
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(159, 120);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(132, 22);
            this.tbCustomerID.TabIndex = 65;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(531, 113);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(239, 22);
            this.tbQuantity.TabIndex = 64;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(406, 119);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(103, 16);
            this.lbQuantity.TabIndex = 63;
            this.lbQuantity.Text = "Total Quantity";
            // 
            // lbWorkerID
            // 
            this.lbWorkerID.AutoSize = true;
            this.lbWorkerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorkerID.Location = new System.Drawing.Point(31, 284);
            this.lbWorkerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWorkerID.Name = "lbWorkerID";
            this.lbWorkerID.Size = new System.Drawing.Size(72, 16);
            this.lbWorkerID.TabIndex = 62;
            this.lbWorkerID.Text = "WorkerID";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(406, 58);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(40, 16);
            this.lbDate.TabIndex = 61;
            this.lbDate.Text = "Date";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerID.Location = new System.Drawing.Point(30, 125);
            this.lbCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(87, 16);
            this.lbCustomerID.TabIndex = 60;
            this.lbCustomerID.Text = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "ServiceID";
            // 
            // WorkDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.Name = "WorkDetails";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WorkDetails_Load);
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