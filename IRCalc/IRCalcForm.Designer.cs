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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IRCalcForm));
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdTotalAmount = new System.Windows.Forms.RadioButton();
            this.rdMonthQtd = new System.Windows.Forms.RadioButton();
            this.rdInstallmentAmount = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.lblInstallmentAmount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpOptions.SuspendLayout();
            this.pnTargetRadios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInitialAmount
            // 
            this.lblInitialAmount.AutoSize = true;
            this.lblInitialAmount.Location = new System.Drawing.Point(35, 15);
            this.lblInitialAmount.Name = "lblInitialAmount";
            this.lblInitialAmount.Size = new System.Drawing.Size(70, 13);
            this.lblInitialAmount.TabIndex = 0;
            this.lblInitialAmount.Text = "Initial Amount";
            // 
            // txtInitialAmount
            // 
            this.txtInitialAmount.Location = new System.Drawing.Point(132, 12);
            this.txtInitialAmount.Name = "txtInitialAmount";
            this.txtInitialAmount.Size = new System.Drawing.Size(100, 20);
            this.txtInitialAmount.TabIndex = 1;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(132, 64);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 3;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(35, 67);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(68, 13);
            this.lblInterestRate.TabIndex = 3;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // lblMonthQtd
            // 
            this.lblMonthQtd.AutoSize = true;
            this.lblMonthQtd.Location = new System.Drawing.Point(35, 41);
            this.lblMonthQtd.Name = "lblMonthQtd";
            this.lblMonthQtd.Size = new System.Drawing.Size(57, 13);
            this.lblMonthQtd.TabIndex = 4;
            this.lblMonthQtd.Text = "Month Qtd";
            // 
            // txtMonthQtd
            // 
            this.txtMonthQtd.Location = new System.Drawing.Point(132, 38);
            this.txtMonthQtd.Name = "txtMonthQtd";
            this.txtMonthQtd.Size = new System.Drawing.Size(100, 20);
            this.txtMonthQtd.TabIndex = 2;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(132, 93);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 4;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(35, 96);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.installmentAmount,
            this.totalAmount,
            this.riseAmount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 286);
            this.dataGridView1.TabIndex = 14;
            // 
            // month
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = null;
            this.month.DefaultCellStyle = dataGridViewCellStyle1;
            this.month.HeaderText = "Month";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Width = 68;
            // 
            // installmentAmount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.installmentAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.installmentAmount.HeaderText = "Installment Amount";
            this.installmentAmount.Name = "installmentAmount";
            this.installmentAmount.ReadOnly = true;
            // 
            // totalAmount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalAmount.HeaderText = "Total Amount";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // riseAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.riseAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.riseAmount.HeaderText = "Rise Amount";
            this.riseAmount.Name = "riseAmount";
            this.riseAmount.ReadOnly = true;
            // 
            // gpOptions
            // 
            this.gpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpOptions.Controls.Add(this.rdCompoundOption);
            this.gpOptions.Controls.Add(this.rdSimpleOption);
            this.gpOptions.Location = new System.Drawing.Point(263, 30);
            this.gpOptions.Name = "gpOptions";
            this.gpOptions.Size = new System.Drawing.Size(172, 124);
            this.gpOptions.TabIndex = 11;
            this.gpOptions.TabStop = false;
            // 
            // rdCompoundOption
            // 
            this.rdCompoundOption.AutoSize = true;
            this.rdCompoundOption.Location = new System.Drawing.Point(27, 74);
            this.rdCompoundOption.Name = "rdCompoundOption";
            this.rdCompoundOption.Size = new System.Drawing.Size(140, 17);
            this.rdCompoundOption.TabIndex = 13;
            this.rdCompoundOption.TabStop = true;
            this.rdCompoundOption.Text = "Compound Interest Rate";
            this.rdCompoundOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdCompoundOption.UseVisualStyleBackColor = true;
            this.rdCompoundOption.Click += new System.EventHandler(this.rdTargetService_Click);
            // 
            // rdSimpleOption
            // 
            this.rdSimpleOption.AutoSize = true;
            this.rdSimpleOption.Location = new System.Drawing.Point(27, 47);
            this.rdSimpleOption.Name = "rdSimpleOption";
            this.rdSimpleOption.Size = new System.Drawing.Size(123, 17);
            this.rdSimpleOption.TabIndex = 12;
            this.rdSimpleOption.TabStop = true;
            this.rdSimpleOption.Text = "Simple  Interest Rate";
            this.rdSimpleOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdSimpleOption.UseVisualStyleBackColor = true;
            this.rdSimpleOption.Click += new System.EventHandler(this.rdTargetService_Click);
            // 
            // rdInterestRate
            // 
            this.rdInterestRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdInterestRate.AutoSize = true;
            this.rdInterestRate.Location = new System.Drawing.Point(3, 30);
            this.rdInterestRate.Name = "rdInterestRate";
            this.rdInterestRate.Size = new System.Drawing.Size(14, 13);
            this.rdInterestRate.TabIndex = 7;
            this.rdInterestRate.TabStop = true;
            this.rdInterestRate.UseVisualStyleBackColor = true;
            // 
            // pnTargetRadios
            // 
            this.pnTargetRadios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTargetRadios.Controls.Add(this.radioButton1);
            this.pnTargetRadios.Controls.Add(this.rdTotalAmount);
            this.pnTargetRadios.Controls.Add(this.rdMonthQtd);
            this.pnTargetRadios.Controls.Add(this.rdInterestRate);
            this.pnTargetRadios.Controls.Add(this.rdInstallmentAmount);
            this.pnTargetRadios.Location = new System.Drawing.Point(11, 12);
            this.pnTargetRadios.Name = "pnTargetRadios";
            this.pnTargetRadios.Size = new System.Drawing.Size(18, 127);
            this.pnTargetRadios.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton1.Location = new System.Drawing.Point(3, 110);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdTotalAmount
            // 
            this.rdTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdTotalAmount.AutoSize = true;
            this.rdTotalAmount.Location = new System.Drawing.Point(3, 85);
            this.rdTotalAmount.Name = "rdTotalAmount";
            this.rdTotalAmount.Size = new System.Drawing.Size(14, 13);
            this.rdTotalAmount.TabIndex = 9;
            this.rdTotalAmount.TabStop = true;
            this.rdTotalAmount.UseVisualStyleBackColor = true;
            // 
            // rdMonthQtd
            // 
            this.rdMonthQtd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdMonthQtd.AutoSize = true;
            this.rdMonthQtd.Location = new System.Drawing.Point(3, 57);
            this.rdMonthQtd.Name = "rdMonthQtd";
            this.rdMonthQtd.Size = new System.Drawing.Size(14, 13);
            this.rdMonthQtd.TabIndex = 8;
            this.rdMonthQtd.TabStop = true;
            this.rdMonthQtd.UseVisualStyleBackColor = true;
            // 
            // rdInstallmentAmount
            // 
            this.rdInstallmentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdInstallmentAmount.AutoSize = true;
            this.rdInstallmentAmount.Location = new System.Drawing.Point(3, 3);
            this.rdInstallmentAmount.Name = "rdInstallmentAmount";
            this.rdInstallmentAmount.Size = new System.Drawing.Size(14, 13);
            this.rdInstallmentAmount.TabIndex = 6;
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
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 148);
            this.panel1.TabIndex = 0;
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Location = new System.Drawing.Point(132, 119);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.Size = new System.Drawing.Size(100, 20);
            this.txtInstallmentAmount.TabIndex = 5;
            // 
            // lblInstallmentAmount
            // 
            this.lblInstallmentAmount.AutoSize = true;
            this.lblInstallmentAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInstallmentAmount.Location = new System.Drawing.Point(35, 122);
            this.lblInstallmentAmount.Name = "lblInstallmentAmount";
            this.lblInstallmentAmount.Size = new System.Drawing.Size(96, 13);
            this.lblInstallmentAmount.TabIndex = 12;
            this.lblInstallmentAmount.Text = "Installment Amount";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.toolsToolStripMenuItem.Text = "&Language";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.customizeToolStripMenuItem.Text = "&English";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.optionsToolStripMenuItem.Text = "&Portuguese";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalculate.Location = new System.Drawing.Point(263, 160);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(172, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // IRCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 497);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpOptions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "IRCalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IRCalc";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpOptions.ResumeLayout(false);
            this.gpOptions.PerformLayout();
            this.pnTargetRadios.ResumeLayout(false);
            this.pnTargetRadios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private System.Windows.Forms.Label lblInstallmentAmount;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn installmentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn riseAmount;
        private System.Windows.Forms.Button btnCalculate;

    }
}

