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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInitialAmount = new System.Windows.Forms.Label();
            this.txtInitialAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblMonthQtd = new System.Windows.Forms.Label();
            this.txtMonthQtd = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installmentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpOptions = new System.Windows.Forms.GroupBox();
            this.rdCompoundOption = new System.Windows.Forms.RadioButton();
            this.rdSimpleOption = new System.Windows.Forms.RadioButton();
            this.rdInterestRate = new System.Windows.Forms.RadioButton();
            this.pnTargetRadios = new System.Windows.Forms.Panel();
            this.rdTotalAmount = new System.Windows.Forms.RadioButton();
            this.rdMonthQtd = new System.Windows.Forms.RadioButton();
            this.rdInstallmentAmount = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInstallmentAmount = new System.Windows.Forms.Label();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpOptions.SuspendLayout();
            this.pnTargetRadios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInitialAmount
            // 
            resources.ApplyResources(this.lblInitialAmount, "lblInitialAmount");
            this.lblInitialAmount.Name = "lblInitialAmount";
            // 
            // txtInitialAmount
            // 
            resources.ApplyResources(this.txtInitialAmount, "txtInitialAmount");
            this.txtInitialAmount.Name = "txtInitialAmount";
            this.txtInitialAmount.Leave += new System.EventHandler(this.txtCalcField_Leave);
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.installmentAmount,
            this.totalAmount,
            this.riseAmount});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // month
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.month.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.month, "month");
            this.month.Name = "month";
            this.month.ReadOnly = true;
            // 
            // installmentAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.installmentAmount.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.installmentAmount, "installmentAmount");
            this.installmentAmount.Name = "installmentAmount";
            this.installmentAmount.ReadOnly = true;
            // 
            // totalAmount
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.totalAmount.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.totalAmount, "totalAmount");
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // riseAmount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.riseAmount.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.riseAmount, "riseAmount");
            this.riseAmount.Name = "riseAmount";
            this.riseAmount.ReadOnly = true;
            // 
            // gpOptions
            // 
            resources.ApplyResources(this.gpOptions, "gpOptions");
            this.gpOptions.Controls.Add(this.rdCompoundOption);
            this.gpOptions.Controls.Add(this.rdSimpleOption);
            this.gpOptions.Name = "gpOptions";
            this.gpOptions.TabStop = false;
            // 
            // rdCompoundOption
            // 
            resources.ApplyResources(this.rdCompoundOption, "rdCompoundOption");
            this.rdCompoundOption.Name = "rdCompoundOption";
            this.rdCompoundOption.TabStop = true;
            this.rdCompoundOption.UseVisualStyleBackColor = true;
            this.rdCompoundOption.Click += new System.EventHandler(this.rdTargetService_Click);
            // 
            // rdSimpleOption
            // 
            resources.ApplyResources(this.rdSimpleOption, "rdSimpleOption");
            this.rdSimpleOption.Name = "rdSimpleOption";
            this.rdSimpleOption.TabStop = true;
            this.rdSimpleOption.UseVisualStyleBackColor = true;
            this.rdSimpleOption.Click += new System.EventHandler(this.rdTargetService_Click);
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
            resources.ApplyResources(this.pnTargetRadios, "pnTargetRadios");
            this.pnTargetRadios.Controls.Add(this.radioButton1);
            this.pnTargetRadios.Controls.Add(this.rdTotalAmount);
            this.pnTargetRadios.Controls.Add(this.rdMonthQtd);
            this.pnTargetRadios.Controls.Add(this.rdInterestRate);
            this.pnTargetRadios.Controls.Add(this.rdInstallmentAmount);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInstallmentAmount);
            this.panel1.Controls.Add(this.lblInstallmentAmount);
            this.panel1.Controls.Add(this.lblInitialAmount);
            this.panel1.Controls.Add(this.pnTargetRadios);
            this.panel1.Controls.Add(this.txtInitialAmount);
            this.panel1.Controls.Add(this.txtInterestRate);
            this.panel1.Controls.Add(this.lblInterestRate);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.lblMonthQtd);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.txtMonthQtd);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // IRCalcForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpOptions);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IRCalcForm";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpOptions.ResumeLayout(false);
            this.gpOptions.PerformLayout();
            this.pnTargetRadios.ResumeLayout(false);
            this.pnTargetRadios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInitialAmount;
        private System.Windows.Forms.TextBox txtInitialAmount;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdCompoundOption;
        private System.Windows.Forms.RadioButton rdSimpleOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn installmentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn riseAmount;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private System.Windows.Forms.Label lblInstallmentAmount;
        private System.Windows.Forms.RadioButton radioButton1;

    }
}

