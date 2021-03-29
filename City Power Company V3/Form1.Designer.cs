namespace City_Power_Company_V3
{
    partial class ElectricityBill
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
            this.rdBtnResidential = new System.Windows.Forms.RadioButton();
            this.rdBtnCommercial = new System.Windows.Forms.RadioButton();
            this.rdBtnIndustrial = new System.Windows.Forms.RadioButton();
            this.lblPeakKwh = new System.Windows.Forms.Label();
            this.txtPeakKwh = new System.Windows.Forms.TextBox();
            this.lblOffPeakKwh = new System.Windows.Forms.Label();
            this.txtOffPeakKwh = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCustomerType = new System.Windows.Forms.GroupBox();
            this.grpCustomerDetail = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblKwh = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lstData = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIndustrialAmount = new System.Windows.Forms.Label();
            this.lblIndustrialCharge = new System.Windows.Forms.Label();
            this.lblCommercialAmount = new System.Windows.Forms.Label();
            this.lblResidentialAmount = new System.Windows.Forms.Label();
            this.lblResidentialCharge = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblCustomerTotal = new System.Windows.Forms.Label();
            this.lblCommercialCharge = new System.Windows.Forms.Label();
            this.grpCustomerType.SuspendLayout();
            this.grpCustomerDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBtnResidential
            // 
            this.rdBtnResidential.BackColor = System.Drawing.Color.Khaki;
            this.rdBtnResidential.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnResidential.Location = new System.Drawing.Point(6, 21);
            this.rdBtnResidential.Name = "rdBtnResidential";
            this.rdBtnResidential.Size = new System.Drawing.Size(127, 31);
            this.rdBtnResidential.TabIndex = 0;
            this.rdBtnResidential.TabStop = true;
            this.rdBtnResidential.Text = "Residential";
            this.rdBtnResidential.UseVisualStyleBackColor = false;
            // 
            // rdBtnCommercial
            // 
            this.rdBtnCommercial.BackColor = System.Drawing.Color.Khaki;
            this.rdBtnCommercial.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnCommercial.Location = new System.Drawing.Point(6, 58);
            this.rdBtnCommercial.Name = "rdBtnCommercial";
            this.rdBtnCommercial.Size = new System.Drawing.Size(127, 31);
            this.rdBtnCommercial.TabIndex = 1;
            this.rdBtnCommercial.TabStop = true;
            this.rdBtnCommercial.Text = "Commercial";
            this.rdBtnCommercial.UseVisualStyleBackColor = false;
            // 
            // rdBtnIndustrial
            // 
            this.rdBtnIndustrial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdBtnIndustrial.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnIndustrial.Location = new System.Drawing.Point(6, 95);
            this.rdBtnIndustrial.Name = "rdBtnIndustrial";
            this.rdBtnIndustrial.Size = new System.Drawing.Size(127, 31);
            this.rdBtnIndustrial.TabIndex = 2;
            this.rdBtnIndustrial.TabStop = true;
            this.rdBtnIndustrial.Text = "Industrial";
            this.rdBtnIndustrial.UseVisualStyleBackColor = false;
            // 
            // lblPeakKwh
            // 
            this.lblPeakKwh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPeakKwh.Font = new System.Drawing.Font("Consolas", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakKwh.Location = new System.Drawing.Point(6, 129);
            this.lblPeakKwh.Name = "lblPeakKwh";
            this.lblPeakKwh.Size = new System.Drawing.Size(129, 25);
            this.lblPeakKwh.TabIndex = 5;
            this.lblPeakKwh.Text = "Peak Kwh Used";
            this.lblPeakKwh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPeakKwh
            // 
            this.txtPeakKwh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPeakKwh.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakKwh.HideSelection = false;
            this.txtPeakKwh.Location = new System.Drawing.Point(141, 129);
            this.txtPeakKwh.Name = "txtPeakKwh";
            this.txtPeakKwh.Size = new System.Drawing.Size(72, 27);
            this.txtPeakKwh.TabIndex = 6;
            // 
            // lblOffPeakKwh
            // 
            this.lblOffPeakKwh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblOffPeakKwh.Font = new System.Drawing.Font("Consolas", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeakKwh.Location = new System.Drawing.Point(6, 159);
            this.lblOffPeakKwh.Name = "lblOffPeakKwh";
            this.lblOffPeakKwh.Size = new System.Drawing.Size(129, 23);
            this.lblOffPeakKwh.TabIndex = 7;
            this.lblOffPeakKwh.Text = "Off-Peak Kwh Used";
            this.lblOffPeakKwh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOffPeakKwh
            // 
            this.txtOffPeakKwh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtOffPeakKwh.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPeakKwh.HideSelection = false;
            this.txtOffPeakKwh.Location = new System.Drawing.Point(141, 159);
            this.txtOffPeakKwh.Name = "txtOffPeakKwh";
            this.txtOffPeakKwh.Size = new System.Drawing.Size(72, 27);
            this.txtOffPeakKwh.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Khaki;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalculate.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(32, 243);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 31);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Khaki;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(407, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 31);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Khaki;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(647, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 29);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpCustomerType
            // 
            this.grpCustomerType.Controls.Add(this.rdBtnResidential);
            this.grpCustomerType.Controls.Add(this.rdBtnCommercial);
            this.grpCustomerType.Controls.Add(this.rdBtnIndustrial);
            this.grpCustomerType.Controls.Add(this.lblPeakKwh);
            this.grpCustomerType.Controls.Add(this.lblOffPeakKwh);
            this.grpCustomerType.Controls.Add(this.txtPeakKwh);
            this.grpCustomerType.Controls.Add(this.txtOffPeakKwh);
            this.grpCustomerType.Location = new System.Drawing.Point(32, 21);
            this.grpCustomerType.Name = "grpCustomerType";
            this.grpCustomerType.Size = new System.Drawing.Size(220, 199);
            this.grpCustomerType.TabIndex = 14;
            this.grpCustomerType.TabStop = false;
            this.grpCustomerType.Text = "Customer Type";
            // 
            // grpCustomerDetail
            // 
            this.grpCustomerDetail.Controls.Add(this.lblAmount);
            this.grpCustomerDetail.Controls.Add(this.txtKwh);
            this.grpCustomerDetail.Controls.Add(this.txtAccountName);
            this.grpCustomerDetail.Controls.Add(this.txtAccountNo);
            this.grpCustomerDetail.Controls.Add(this.lblCharge);
            this.grpCustomerDetail.Controls.Add(this.lblKwh);
            this.grpCustomerDetail.Controls.Add(this.lblAccountName);
            this.grpCustomerDetail.Controls.Add(this.lblAccountNo);
            this.grpCustomerDetail.Location = new System.Drawing.Point(280, 33);
            this.grpCustomerDetail.Name = "grpCustomerDetail";
            this.grpCustomerDetail.Size = new System.Drawing.Size(253, 174);
            this.grpCustomerDetail.TabIndex = 15;
            this.grpCustomerDetail.TabStop = false;
            this.grpCustomerDetail.Text = "Customer Deatails";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmount.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(127, 133);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(121, 23);
            this.lblAmount.TabIndex = 7;
            // 
            // txtKwh
            // 
            this.txtKwh.Location = new System.Drawing.Point(127, 96);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(121, 22);
            this.txtKwh.TabIndex = 6;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(127, 59);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(121, 22);
            this.txtAccountName.TabIndex = 5;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(127, 21);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(121, 22);
            this.txtAccountNo.TabIndex = 4;
            // 
            // lblCharge
            // 
            this.lblCharge.BackColor = System.Drawing.Color.Khaki;
            this.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCharge.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(6, 133);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(112, 23);
            this.lblCharge.TabIndex = 3;
            this.lblCharge.Text = "Charge";
            // 
            // lblKwh
            // 
            this.lblKwh.BackColor = System.Drawing.Color.Khaki;
            this.lblKwh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKwh.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKwh.Location = new System.Drawing.Point(6, 95);
            this.lblKwh.Name = "lblKwh";
            this.lblKwh.Size = new System.Drawing.Size(112, 23);
            this.lblKwh.TabIndex = 2;
            this.lblKwh.Text = "Kwh used";
            // 
            // lblAccountName
            // 
            this.lblAccountName.BackColor = System.Drawing.Color.Khaki;
            this.lblAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountName.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(6, 58);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(112, 23);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Account Name";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.BackColor = System.Drawing.Color.Khaki;
            this.lblAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountNo.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.Location = new System.Drawing.Point(6, 21);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(112, 23);
            this.lblAccountNo.TabIndex = 0;
            this.lblAccountNo.Text = "Account No";
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 16;
            this.lstData.Location = new System.Drawing.Point(549, 33);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(239, 276);
            this.lstData.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Khaki;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(227, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 31);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIndustrialAmount
            // 
            this.lblIndustrialAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblIndustrialAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIndustrialAmount.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustrialAmount.Location = new System.Drawing.Point(665, 379);
            this.lblIndustrialAmount.Name = "lblIndustrialAmount";
            this.lblIndustrialAmount.Size = new System.Drawing.Size(79, 23);
            this.lblIndustrialAmount.TabIndex = 33;
            // 
            // lblIndustrialCharge
            // 
            this.lblIndustrialCharge.BackColor = System.Drawing.Color.Khaki;
            this.lblIndustrialCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIndustrialCharge.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustrialCharge.Location = new System.Drawing.Point(516, 379);
            this.lblIndustrialCharge.Name = "lblIndustrialCharge";
            this.lblIndustrialCharge.Size = new System.Drawing.Size(131, 23);
            this.lblIndustrialCharge.TabIndex = 32;
            this.lblIndustrialCharge.Text = "Industrial";
            // 
            // lblCommercialAmount
            // 
            this.lblCommercialAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblCommercialAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommercialAmount.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommercialAmount.Location = new System.Drawing.Point(417, 379);
            this.lblCommercialAmount.Name = "lblCommercialAmount";
            this.lblCommercialAmount.Size = new System.Drawing.Size(79, 23);
            this.lblCommercialAmount.TabIndex = 31;
            // 
            // lblResidentialAmount
            // 
            this.lblResidentialAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblResidentialAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResidentialAmount.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentialAmount.Location = new System.Drawing.Point(178, 379);
            this.lblResidentialAmount.Name = "lblResidentialAmount";
            this.lblResidentialAmount.Size = new System.Drawing.Size(79, 23);
            this.lblResidentialAmount.TabIndex = 30;
            // 
            // lblResidentialCharge
            // 
            this.lblResidentialCharge.BackColor = System.Drawing.Color.Khaki;
            this.lblResidentialCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResidentialCharge.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentialCharge.Location = new System.Drawing.Point(32, 379);
            this.lblResidentialCharge.Name = "lblResidentialCharge";
            this.lblResidentialCharge.Size = new System.Drawing.Size(131, 23);
            this.lblResidentialCharge.TabIndex = 29;
            this.lblResidentialCharge.Text = "Residential";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(417, 325);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(79, 23);
            this.lblTotalAmount.TabIndex = 28;
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.BackColor = System.Drawing.Color.Khaki;
            this.lblTotalCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCharge.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharge.Location = new System.Drawing.Point(275, 325);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(112, 23);
            this.lblTotalCharge.TabIndex = 27;
            this.lblTotalCharge.Text = "Total Charge";
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.SystemColors.Window;
            this.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNo.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(178, 325);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(79, 23);
            this.lblNo.TabIndex = 26;
            // 
            // lblCustomerTotal
            // 
            this.lblCustomerTotal.BackColor = System.Drawing.Color.Khaki;
            this.lblCustomerTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerTotal.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTotal.Location = new System.Drawing.Point(32, 325);
            this.lblCustomerTotal.Name = "lblCustomerTotal";
            this.lblCustomerTotal.Size = new System.Drawing.Size(131, 23);
            this.lblCustomerTotal.TabIndex = 25;
            this.lblCustomerTotal.Text = "Total Customers";
            // 
            // lblCommercialCharge
            // 
            this.lblCommercialCharge.BackColor = System.Drawing.Color.Khaki;
            this.lblCommercialCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommercialCharge.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommercialCharge.Location = new System.Drawing.Point(275, 379);
            this.lblCommercialCharge.Name = "lblCommercialCharge";
            this.lblCommercialCharge.Size = new System.Drawing.Size(131, 23);
            this.lblCommercialCharge.TabIndex = 34;
            this.lblCommercialCharge.Text = "Commercial";
            // 
            // ElectricityBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCommercialCharge);
            this.Controls.Add(this.lblIndustrialAmount);
            this.Controls.Add(this.lblIndustrialCharge);
            this.Controls.Add(this.lblCommercialAmount);
            this.Controls.Add(this.lblResidentialAmount);
            this.Controls.Add(this.lblResidentialCharge);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblCustomerTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.grpCustomerDetail);
            this.Controls.Add(this.grpCustomerType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "ElectricityBill";
            this.Text = "Electricity Bill";
            this.grpCustomerType.ResumeLayout(false);
            this.grpCustomerType.PerformLayout();
            this.grpCustomerDetail.ResumeLayout(false);
            this.grpCustomerDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnResidential;
        private System.Windows.Forms.RadioButton rdBtnCommercial;
        private System.Windows.Forms.RadioButton rdBtnIndustrial;
        private System.Windows.Forms.Label lblPeakKwh;
        private System.Windows.Forms.TextBox txtPeakKwh;
        private System.Windows.Forms.Label lblOffPeakKwh;
        private System.Windows.Forms.TextBox txtOffPeakKwh;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpCustomerType;
        private System.Windows.Forms.GroupBox grpCustomerDetail;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblKwh;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIndustrialAmount;
        private System.Windows.Forms.Label lblIndustrialCharge;
        private System.Windows.Forms.Label lblCommercialAmount;
        private System.Windows.Forms.Label lblResidentialAmount;
        private System.Windows.Forms.Label lblResidentialCharge;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblCustomerTotal;
        private System.Windows.Forms.Label lblCommercialCharge;
    }
}

