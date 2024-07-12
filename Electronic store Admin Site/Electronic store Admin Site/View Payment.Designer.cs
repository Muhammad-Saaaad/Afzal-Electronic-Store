namespace Electronic_store_Admin_Site
{
    partial class View_Payment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbYears = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYear = new System.Windows.Forms.Button();
            this.cbMonths = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.btnPaymentMonthly = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnHandleProduct = new System.Windows.Forms.Button();
            this.btnSellingHistory = new System.Windows.Forms.Button();
            this.btnDefaulters = new System.Windows.Forms.Button();
            this.BtnConfirmInstallment = new System.Windows.Forms.Button();
            this.btnApprovePurchase = new System.Windows.Forms.Button();
            this.dgwViewPayment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Payment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.cbYears);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnYear);
            this.panel2.Controls.Add(this.cbMonths);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.btnPaymentMonthly);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1527, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 955);
            this.panel2.TabIndex = 1;
            // 
            // cbYears
            // 
            this.cbYears.FormattingEnabled = true;
            this.cbYears.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.cbYears.Location = new System.Drawing.Point(120, 366);
            this.cbYears.Name = "cbYears";
            this.cbYears.Size = new System.Drawing.Size(143, 24);
            this.cbYears.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select Year";
            // 
            // btnYear
            // 
            this.btnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.Location = new System.Drawing.Point(120, 422);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(181, 51);
            this.btnYear.TabIndex = 42;
            this.btnYear.Text = "View By Year";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // cbMonths
            // 
            this.cbMonths.FormattingEnabled = true;
            this.cbMonths.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonths.Location = new System.Drawing.Point(120, 156);
            this.cbMonths.Name = "cbMonths";
            this.cbMonths.Size = new System.Drawing.Size(143, 24);
            this.cbMonths.TabIndex = 41;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(120, 108);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(153, 29);
            this.label.TabIndex = 40;
            this.label.Text = "Select Month";
            // 
            // btnPaymentMonthly
            // 
            this.btnPaymentMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentMonthly.Location = new System.Drawing.Point(120, 212);
            this.btnPaymentMonthly.Name = "btnPaymentMonthly";
            this.btnPaymentMonthly.Size = new System.Drawing.Size(181, 51);
            this.btnPaymentMonthly.TabIndex = 39;
            this.btnPaymentMonthly.Text = "View By Month";
            this.btnPaymentMonthly.UseVisualStyleBackColor = true;
            this.btnPaymentMonthly.Click += new System.EventHandler(this.btnPaymentMonthly_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.btnViewProduct);
            this.panel3.Controls.Add(this.btnHandleProduct);
            this.panel3.Controls.Add(this.btnSellingHistory);
            this.panel3.Controls.Add(this.btnDefaulters);
            this.panel3.Controls.Add(this.BtnConfirmInstallment);
            this.panel3.Controls.Add(this.btnApprovePurchase);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 955);
            this.panel3.TabIndex = 1;
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProduct.Location = new System.Drawing.Point(12, 444);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(199, 51);
            this.btnViewProduct.TabIndex = 38;
            this.btnViewProduct.Text = "View Product";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnHandleProduct
            // 
            this.btnHandleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandleProduct.Location = new System.Drawing.Point(12, 360);
            this.btnHandleProduct.Name = "btnHandleProduct";
            this.btnHandleProduct.Size = new System.Drawing.Size(199, 51);
            this.btnHandleProduct.TabIndex = 37;
            this.btnHandleProduct.Text = "Handle Products";
            this.btnHandleProduct.UseVisualStyleBackColor = true;
            this.btnHandleProduct.Click += new System.EventHandler(this.btnHandleProduct_Click);
            // 
            // btnSellingHistory
            // 
            this.btnSellingHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellingHistory.Location = new System.Drawing.Point(12, 286);
            this.btnSellingHistory.Name = "btnSellingHistory";
            this.btnSellingHistory.Size = new System.Drawing.Size(199, 43);
            this.btnSellingHistory.TabIndex = 36;
            this.btnSellingHistory.Text = "Selling History";
            this.btnSellingHistory.UseVisualStyleBackColor = true;
            this.btnSellingHistory.Click += new System.EventHandler(this.btnSellingHistory_Click);
            // 
            // btnDefaulters
            // 
            this.btnDefaulters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaulters.Location = new System.Drawing.Point(12, 206);
            this.btnDefaulters.Name = "btnDefaulters";
            this.btnDefaulters.Size = new System.Drawing.Size(199, 40);
            this.btnDefaulters.TabIndex = 35;
            this.btnDefaulters.Text = "Defaulters";
            this.btnDefaulters.UseVisualStyleBackColor = true;
            this.btnDefaulters.Click += new System.EventHandler(this.btnDefaulters_Click);
            // 
            // BtnConfirmInstallment
            // 
            this.BtnConfirmInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmInstallment.Location = new System.Drawing.Point(12, 129);
            this.BtnConfirmInstallment.Name = "BtnConfirmInstallment";
            this.BtnConfirmInstallment.Size = new System.Drawing.Size(199, 43);
            this.BtnConfirmInstallment.TabIndex = 34;
            this.BtnConfirmInstallment.Text = "Confirm Installment";
            this.BtnConfirmInstallment.UseVisualStyleBackColor = true;
            this.BtnConfirmInstallment.Click += new System.EventHandler(this.BtnConfirmInstallment_Click);
            // 
            // btnApprovePurchase
            // 
            this.btnApprovePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprovePurchase.Location = new System.Drawing.Point(12, 38);
            this.btnApprovePurchase.Name = "btnApprovePurchase";
            this.btnApprovePurchase.Size = new System.Drawing.Size(199, 51);
            this.btnApprovePurchase.TabIndex = 33;
            this.btnApprovePurchase.Text = "Approve Plan";
            this.btnApprovePurchase.UseVisualStyleBackColor = true;
            this.btnApprovePurchase.Click += new System.EventHandler(this.btnApprovePurchase_Click);
            // 
            // dgwViewPayment
            // 
            this.dgwViewPayment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwViewPayment.Location = new System.Drawing.Point(230, 100);
            this.dgwViewPayment.Name = "dgwViewPayment";
            this.dgwViewPayment.RowHeadersWidth = 51;
            this.dgwViewPayment.RowTemplate.Height = 24;
            this.dgwViewPayment.Size = new System.Drawing.Size(1463, 952);
            this.dgwViewPayment.TabIndex = 2;
            // 
            // View_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dgwViewPayment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "View_Payment";
            this.Text = "View_Payment";
            this.Load += new System.EventHandler(this.View_Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwViewPayment;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnHandleProduct;
        private System.Windows.Forms.Button btnSellingHistory;
        private System.Windows.Forms.Button btnDefaulters;
        private System.Windows.Forms.Button BtnConfirmInstallment;
        private System.Windows.Forms.Button btnApprovePurchase;
        private System.Windows.Forms.Button btnPaymentMonthly;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbMonths;
        private System.Windows.Forms.ComboBox cbYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYear;
    }
}