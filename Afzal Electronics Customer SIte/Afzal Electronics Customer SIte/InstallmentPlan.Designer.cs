namespace Afzal_Electronics_Customer_SIte
{
    partial class InstallmentPlan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgwSelectedProduct = new System.Windows.Forms.DataGridView();
            this.cbInstallments = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmPlan = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAppOrRej = new System.Windows.Forms.Label();
            this.btnPayInstallment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelectedProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installment Plan";
            // 
            // dgwSelectedProduct
            // 
            this.dgwSelectedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelectedProduct.Location = new System.Drawing.Point(114, 249);
            this.dgwSelectedProduct.Name = "dgwSelectedProduct";
            this.dgwSelectedProduct.RowHeadersWidth = 51;
            this.dgwSelectedProduct.RowTemplate.Height = 24;
            this.dgwSelectedProduct.Size = new System.Drawing.Size(1068, 103);
            this.dgwSelectedProduct.TabIndex = 1;
            // 
            // cbInstallments
            // 
            this.cbInstallments.FormattingEnabled = true;
            this.cbInstallments.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbInstallments.Location = new System.Drawing.Point(633, 404);
            this.cbInstallments.Name = "cbInstallments";
            this.cbInstallments.Size = new System.Drawing.Size(165, 24);
            this.cbInstallments.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "No of Installments:";
            // 
            // btnConfirmPlan
            // 
            this.btnConfirmPlan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConfirmPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPlan.Location = new System.Drawing.Point(268, 490);
            this.btnConfirmPlan.Name = "btnConfirmPlan";
            this.btnConfirmPlan.Size = new System.Drawing.Size(252, 42);
            this.btnConfirmPlan.TabIndex = 10;
            this.btnConfirmPlan.Text = "Confirm Installment Plan";
            this.btnConfirmPlan.UseVisualStyleBackColor = false;
            this.btnConfirmPlan.Click += new System.EventHandler(this.btnConfirmPlan_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Gold;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(632, 490);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(209, 42);
            this.btnGoBack.TabIndex = 11;
            this.btnGoBack.Text = "Go Back to Purchase";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnPayInstallment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Do you want to pay installment?";
            // 
            // lblAppOrRej
            // 
            this.lblAppOrRej.AutoSize = true;
            this.lblAppOrRej.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAppOrRej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppOrRej.Location = new System.Drawing.Point(320, 598);
            this.lblAppOrRej.Name = "lblAppOrRej";
            this.lblAppOrRej.Size = new System.Drawing.Size(0, 25);
            this.lblAppOrRej.TabIndex = 13;
            // 
            // btnPayInstallment
            // 
            this.btnPayInstallment.BackColor = System.Drawing.Color.Gold;
            this.btnPayInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayInstallment.Location = new System.Drawing.Point(633, 589);
            this.btnPayInstallment.Name = "btnPayInstallment";
            this.btnPayInstallment.Size = new System.Drawing.Size(178, 34);
            this.btnPayInstallment.TabIndex = 15;
            this.btnPayInstallment.Text = "Pay Installment";
            this.btnPayInstallment.UseVisualStyleBackColor = false;
            this.btnPayInstallment.Click += new System.EventHandler(this.btnPayInstallment_Click_1);
            // 
            // InstallmentPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Afzal_Electronics_Customer_SIte.Properties.Resources.Customer_Site_Background_transformed__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1630, 896);
            this.Controls.Add(this.btnPayInstallment);
            this.Controls.Add(this.lblAppOrRej);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnConfirmPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbInstallments);
            this.Controls.Add(this.dgwSelectedProduct);
            this.Controls.Add(this.label1);
            this.Name = "InstallmentPlan";
            this.Text = "InstallmentPlan";
            this.Load += new System.EventHandler(this.InstallmentPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelectedProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwSelectedProduct;
        private System.Windows.Forms.ComboBox cbInstallments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmPlan;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAppOrRej;
        private System.Windows.Forms.Button btnPayInstallment;
    }
}