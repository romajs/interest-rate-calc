namespace IRCalc
{
    partial class IRCalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IRCalcForm));
            this.lblInstallmentAmount = new System.Windows.Forms.Label();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblMonthQtd = new System.Windows.Forms.Label();
            this.txtMonthQtd = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpOptions = new System.Windows.Forms.GroupBox();
            this.rdInterestRate = new System.Windows.Forms.RadioButton();
            this.pnTargetRadios = new System.Windows.Forms.Panel();
            this.rdTotalAmount = new System.Windows.Forms.RadioButton();
            this.rdMonthQtd = new System.Windows.Forms.RadioButton();
            this.rdInstallmentAmount = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnTargetRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstallmentAmount
            // 
            resources.ApplyResources(this.lblInstallmentAmount, "lblInstallmentAmount");
            this.lblInstallmentAmount.Name = "lblInstallmentAmount";
            // 
            // txtInstallmentAmount
            // 
            resources.ApplyResources(this.txtInstallmentAmount, "txtInstallmentAmount");
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.Leave += new System.EventHandler(this.txtCalcField_Leave);
            // 
            // txtInterestRate
            // 
            resources.ApplyResources(this.txtInterestRate, "txtInterestRate");
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Leave += new System.EventHandler(this.txtCalcField_Leave);
            // 
            // lblInterestRate
            // 
            resources.ApplyResources(this.lblInterestRate, "lblInterestRate");
            this.lblInterestRate.Name = "lblInterestRate";
            // 
            // lblMonthQtd
            // 
            resources.ApplyResources(this.lblMonthQtd, "lblMonthQtd");
            this.lblMonthQtd.Name = "lblMonthQtd";
            // 
            // txtMonthQtd
            // 
            resources.ApplyResources(this.txtMonthQtd, "txtMonthQtd");
            this.txtMonthQtd.Name = "txtMonthQtd";
            this.txtMonthQtd.Leave += new System.EventHandler(this.txtCalcField_Leave);
            // 
            // txtTotalAmount
            // 
            resources.ApplyResources(this.txtTotalAmount, "txtTotalAmount");
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Leave += new System.EventHandler(this.txtCalcField_Leave);
            // 
            // lblTotalAmount
            // 
            resources.ApplyResources(this.lblTotalAmount, "lblTotalAmount");
            this.lblTotalAmount.Name = "lblTotalAmount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // gpOptions
            // 
            resources.ApplyResources(this.gpOptions, "gpOptions");
            this.gpOptions.Name = "gpOptions";
            this.gpOptions.TabStop = false;
            // 
            // rdInterestRate
            // 
            resources.ApplyResources(this.rdInterestRate, "rdInterestRate");
            this.rdInterestRate.Name = "rdInterestRate";
            this.rdInterestRate.TabStop = true;
            this.rdInterestRate.UseVisualStyleBackColor = true;
            // 
            // pnTargetRadios
            // 
            this.pnTargetRadios.Controls.Add(this.rdTotalAmount);
            this.pnTargetRadios.Controls.Add(this.rdMonthQtd);
            this.pnTargetRadios.Controls.Add(this.rdInterestRate);
            this.pnTargetRadios.Controls.Add(this.rdInstallmentAmount);
            resources.ApplyResources(this.pnTargetRadios, "pnTargetRadios");
            this.pnTargetRadios.Name = "pnTargetRadios";
            // 
            // rdTotalAmount
            // 
            resources.ApplyResources(this.rdTotalAmount, "rdTotalAmount");
            this.rdTotalAmount.Name = "rdTotalAmount";
            this.rdTotalAmount.TabStop = true;
            this.rdTotalAmount.UseVisualStyleBackColor = true;
            // 
            // rdMonthQtd
            // 
            resources.ApplyResources(this.rdMonthQtd, "rdMonthQtd");
            this.rdMonthQtd.Name = "rdMonthQtd";
            this.rdMonthQtd.TabStop = true;
            this.rdMonthQtd.UseVisualStyleBackColor = true;
            // 
            // rdInstallmentAmount
            // 
            resources.ApplyResources(this.rdInstallmentAmount, "rdInstallmentAmount");
            this.rdInstallmentAmount.Name = "rdInstallmentAmount";
            this.rdInstallmentAmount.TabStop = true;
            this.rdInstallmentAmount.UseVisualStyleBackColor = true;
            // 
            // IRCalcForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTargetRadios);
            this.Controls.Add(this.gpOptions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtMonthQtd);
            this.Controls.Add(this.lblMonthQtd);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtInstallmentAmount);
            this.Controls.Add(this.lblInstallmentAmount);
            this.Name = "IRCalcForm";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnTargetRadios.ResumeLayout(false);
            this.pnTargetRadios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstallmentAmount;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblMonthQtd;
        private System.Windows.Forms.TextBox txtMonthQtd;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpOptions;
        private System.Windows.Forms.RadioButton rdInterestRate;
        private System.Windows.Forms.Panel pnTargetRadios;
        private System.Windows.Forms.RadioButton rdTotalAmount;
        private System.Windows.Forms.RadioButton rdMonthQtd;
        private System.Windows.Forms.RadioButton rdInstallmentAmount;

    }
}

