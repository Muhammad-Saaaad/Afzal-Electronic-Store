namespace Afzal_Electronics_Customer_SIte
{
    partial class PayInstallment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwInstallments = new System.Windows.Forms.DataGridView();
            this.btnPayInstallment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaymentPrice = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInstallments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pay Installment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select To Pay";
            // 
            // dgwInstallments
            // 
            this.dgwInstallments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwInstallments.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwInstallments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwInstallments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwInstallments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwInstallments.Location = new System.Drawing.Point(12, 220);
            this.dgwInstallments.Name = "dgwInstallments";
            this.dgwInstallments.RowHeadersWidth = 51;
            this.dgwInstallments.RowTemplate.Height = 24;
            this.dgwInstallments.Size = new System.Drawing.Size(1262, 495);
            this.dgwInstallments.TabIndex = 11;
            // 
            // btnPayInstallment
            // 
            this.btnPayInstallment.BackColor = System.Drawing.Color.Gold;
            this.btnPayInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayInstallment.Location = new System.Drawing.Point(1379, 421);
            this.btnPayInstallment.Name = "btnPayInstallment";
            this.btnPayInstallment.Size = new System.Drawing.Size(203, 50);
            this.btnPayInstallment.TabIndex = 13;
            this.btnPayInstallment.Text = "Pay Installment";
            this.btnPayInstallment.UseVisualStyleBackColor = false;
            this.btnPayInstallment.Click += new System.EventHandler(this.btnPayInstallment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1373, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter payment Amount";
            // 
            // txtPaymentPrice
            // 
            this.txtPaymentPrice.Location = new System.Drawing.Point(1379, 342);
            this.txtPaymentPrice.Name = "txtPaymentPrice";
            this.txtPaymentPrice.Size = new System.Drawing.Size(220, 22);
            this.txtPaymentPrice.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1373, 524);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(317, 36);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Enter payment Amount";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gold;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1379, 583);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(203, 50);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh Page";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PayInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Afzal_Electronics_Customer_SIte.Properties.Resources.Customer_Site_Background_transformed__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1817, 878);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPaymentPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPayInstallment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwInstallments);
            this.Name = "PayInstallment";
            this.Text = "PayInstallment";
            this.Load += new System.EventHandler(this.PayInstallment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInstallments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwInstallments;
        private System.Windows.Forms.Button btnPayInstallment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaymentPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRefresh;
    }
}