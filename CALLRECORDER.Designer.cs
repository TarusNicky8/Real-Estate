﻿namespace ACCOUNTMANAGEMENT
{
    partial class CALLRECORDER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CALLRECORDER));
            this.lblcustid = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbcalltype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCallId = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtModelNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtitemno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOtherDetail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProblemFound = new System.Windows.Forms.TextBox();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCallStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpVisitTime = new System.Windows.Forms.DateTimePicker();
            this.cmbWarantyStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCallOf = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtConcernPerson = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCharges = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMobileNo1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRepairDetail = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtApproExpences = new System.Windows.Forms.TextBox();
            this.lblEmployeeid = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtAgainstBillNo = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcustid.Location = new System.Drawing.Point(2, 103);
            this.lblcustid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(13, 13);
            this.lblcustid.TabIndex = 276;
            this.lblcustid.Text = "0";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(133, 101);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(279, 21);
            this.cmbCustomer.TabIndex = 274;
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // cmbcalltype
            // 
            this.cmbcalltype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcalltype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcalltype.FormattingEnabled = true;
            this.cmbcalltype.Items.AddRange(new object[] {
            "ONSITE SERVICE",
            "OFFICE REPAIR",
            "ENQUIRY"});
            this.cmbcalltype.Location = new System.Drawing.Point(975, 30);
            this.cmbcalltype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbcalltype.Name = "cmbcalltype";
            this.cmbcalltype.Size = new System.Drawing.Size(173, 21);
            this.cmbcalltype.TabIndex = 337;
            this.cmbcalltype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbcalltype_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(874, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 336;
            this.label3.Text = "Call Type";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(21, 28);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 17);
            this.label17.TabIndex = 335;
            this.label17.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(134, 29);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(82, 20);
            this.dtpDate.TabIndex = 334;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(419, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 368;
            this.label16.Text = "Call Id";
            // 
            // txtCallId
            // 
            this.txtCallId.Location = new System.Drawing.Point(519, 29);
            this.txtCallId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCallId.Name = "txtCallId";
            this.txtCallId.Size = new System.Drawing.Size(74, 20);
            this.txtCallId.TabIndex = 367;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(20, 210);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 376;
            this.label21.Text = "Model No";
            // 
            // txtModelNo
            // 
            this.txtModelNo.Location = new System.Drawing.Point(133, 207);
            this.txtModelNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelNo.Name = "txtModelNo";
            this.txtModelNo.Size = new System.Drawing.Size(279, 20);
            this.txtModelNo.TabIndex = 375;
            this.txtModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModelNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(873, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 374;
            this.label1.Text = "Serial No";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(976, 173);
            this.txtSerialNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(173, 20);
            this.txtSerialNo.TabIndex = 373;
            this.txtSerialNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerialNo_KeyDown);
            // 
            // cmbItemName
            // 
            this.cmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(519, 170);
            this.cmbItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(340, 21);
            this.cmbItemName.TabIndex = 372;
            this.cmbItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbItemName_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 371;
            this.label6.Text = "Item No";
            // 
            // txtitemno
            // 
            this.txtitemno.Location = new System.Drawing.Point(133, 167);
            this.txtitemno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtitemno.Name = "txtitemno";
            this.txtitemno.Size = new System.Drawing.Size(100, 20);
            this.txtitemno.TabIndex = 370;
            this.txtitemno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtitemno_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(421, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 369;
            this.label2.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(421, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 378;
            this.label4.Text = "Other Detail ";
            // 
            // txtOtherDetail
            // 
            this.txtOtherDetail.Location = new System.Drawing.Point(519, 209);
            this.txtOtherDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOtherDetail.Name = "txtOtherDetail";
            this.txtOtherDetail.Size = new System.Drawing.Size(340, 20);
            this.txtOtherDetail.TabIndex = 377;
            this.txtOtherDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOtherDetail_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(873, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 380;
            this.label5.Text = "Problem ";
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(976, 207);
            this.txtProblem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(173, 20);
            this.txtProblem.TabIndex = 379;
            this.txtProblem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProblem_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(20, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 382;
            this.label7.Text = "Transfered to ";
            // 
            // txtProblemFound
            // 
            this.txtProblemFound.Location = new System.Drawing.Point(521, 290);
            this.txtProblemFound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProblemFound.Name = "txtProblemFound";
            this.txtProblemFound.Size = new System.Drawing.Size(338, 20);
            this.txtProblemFound.TabIndex = 381;
            this.txtProblemFound.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProblemFound_KeyDown);
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(133, 251);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(279, 21);
            this.cmbEmployeeName.TabIndex = 383;
            this.cmbEmployeeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployeeName_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(421, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 385;
            this.label8.Text = "Visit Date";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.CustomFormat = "dd/MM/yyyy ";
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVisitDate.Location = new System.Drawing.Point(521, 252);
            this.dtpVisitDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(107, 20);
            this.dtpVisitDate.TabIndex = 384;
            this.dtpVisitDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpVisitDate_KeyDown);
            // 
            // cmbCallStatus
            // 
            this.cmbCallStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCallStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCallStatus.FormattingEnabled = true;
            this.cmbCallStatus.Items.AddRange(new object[] {
            "Pending",
            "Clear",
            "Cancelled"});
            this.cmbCallStatus.Location = new System.Drawing.Point(133, 291);
            this.cmbCallStatus.Name = "cmbCallStatus";
            this.cmbCallStatus.Size = new System.Drawing.Size(169, 21);
            this.cmbCallStatus.TabIndex = 387;
            this.cmbCallStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCallStatus_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(17, 291);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 386;
            this.label9.Text = "Call Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(416, 293);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 388;
            this.label10.Text = " Problem Found";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(876, 357);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 390;
            this.label11.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(975, 357);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(174, 20);
            this.txtRemarks.TabIndex = 389;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemarks_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(873, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 392;
            this.label12.Text = "Mobile No";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(976, 104);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(173, 20);
            this.txtMobileNo.TabIndex = 391;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(421, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 394;
            this.label13.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(521, 102);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(338, 20);
            this.txtAddress.TabIndex = 393;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(873, 247);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 396;
            this.label14.Text = "Visit Time";
            // 
            // dtpVisitTime
            // 
            this.dtpVisitTime.CustomFormat = "dd/MM/yyyy ";
            this.dtpVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVisitTime.Location = new System.Drawing.Point(976, 247);
            this.dtpVisitTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpVisitTime.Name = "dtpVisitTime";
            this.dtpVisitTime.Size = new System.Drawing.Size(107, 20);
            this.dtpVisitTime.TabIndex = 395;
            this.dtpVisitTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpVisitTime_KeyDown);
            // 
            // cmbWarantyStatus
            // 
            this.cmbWarantyStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWarantyStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWarantyStatus.FormattingEnabled = true;
            this.cmbWarantyStatus.Items.AddRange(new object[] {
            "In Waranty",
            "Out Waranty"});
            this.cmbWarantyStatus.Location = new System.Drawing.Point(134, 70);
            this.cmbWarantyStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWarantyStatus.Name = "cmbWarantyStatus";
            this.cmbWarantyStatus.Size = new System.Drawing.Size(181, 21);
            this.cmbWarantyStatus.TabIndex = 398;
            this.cmbWarantyStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbWarantyStatus_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(21, 74);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 397;
            this.label15.Text = "Waranty Status";
            // 
            // cmbCallOf
            // 
            this.cmbCallOf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCallOf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCallOf.FormattingEnabled = true;
            this.cmbCallOf.Items.AddRange(new object[] {
            "iT World",
            "Siddhi Wireless Broadband",
            "Other"});
            this.cmbCallOf.Location = new System.Drawing.Point(521, 71);
            this.cmbCallOf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCallOf.Name = "cmbCallOf";
            this.cmbCallOf.Size = new System.Drawing.Size(338, 21);
            this.cmbCallOf.TabIndex = 400;
            this.cmbCallOf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCallOf_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(421, 71);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 17);
            this.label18.TabIndex = 399;
            this.label18.Text = "Call Of";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(421, 138);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 17);
            this.label19.TabIndex = 402;
            this.label19.Text = "Site ";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(519, 136);
            this.txtSite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(338, 20);
            this.txtSite.TabIndex = 401;
            this.txtSite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSite_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(20, 135);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 17);
            this.label20.TabIndex = 404;
            this.label20.Text = "Concern Person";
            // 
            // txtConcernPerson
            // 
            this.txtConcernPerson.Location = new System.Drawing.Point(133, 135);
            this.txtConcernPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConcernPerson.Name = "txtConcernPerson";
            this.txtConcernPerson.Size = new System.Drawing.Size(279, 20);
            this.txtConcernPerson.TabIndex = 403;
            this.txtConcernPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConcernPerson_KeyDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(873, 295);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 17);
            this.label22.TabIndex = 406;
            this.label22.Text = "Charges";
            // 
            // txtCharges
            // 
            this.txtCharges.Location = new System.Drawing.Point(975, 290);
            this.txtCharges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCharges.Name = "txtCharges";
            this.txtCharges.Size = new System.Drawing.Size(173, 20);
            this.txtCharges.TabIndex = 405;
            this.txtCharges.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCharges_KeyDown);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnDelete);
            this.GroupBox3.Controls.Add(this.btnUpdate);
            this.GroupBox3.Controls.Add(this.btnNew);
            this.GroupBox3.Controls.Add(this.btnSave);
            this.GroupBox3.Controls.Add(this.btnClose);
            this.GroupBox3.Location = new System.Drawing.Point(134, 415);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(441, 62);
            this.GroupBox3.TabIndex = 407;
            this.GroupBox3.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(263, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(179, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(8, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(94, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(350, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(20, 101);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 17);
            this.label23.TabIndex = 408;
            this.label23.Text = "Customer Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(873, 139);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 17);
            this.label24.TabIndex = 410;
            this.label24.Text = "Mobile No";
            // 
            // txtMobileNo1
            // 
            this.txtMobileNo1.Location = new System.Drawing.Point(976, 138);
            this.txtMobileNo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobileNo1.Name = "txtMobileNo1";
            this.txtMobileNo1.Size = new System.Drawing.Size(173, 20);
            this.txtMobileNo1.TabIndex = 409;
            this.txtMobileNo1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobileNo1_KeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(416, 357);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 17);
            this.label25.TabIndex = 412;
            this.label25.Text = "Repair Detail";
            // 
            // txtRepairDetail
            // 
            this.txtRepairDetail.Location = new System.Drawing.Point(521, 353);
            this.txtRepairDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepairDetail.Name = "txtRepairDetail";
            this.txtRepairDetail.Size = new System.Drawing.Size(279, 20);
            this.txtRepairDetail.TabIndex = 411;
            this.txtRepairDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRepairDetail_KeyDown);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(1155, 14);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 13);
            this.label26.TabIndex = 414;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1165, 14);
            this.lblpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 13);
            this.lblpath.TabIndex = 413;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(14, 360);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 17);
            this.label27.TabIndex = 416;
            this.label27.Text = "Appro. Expences";
            // 
            // txtApproExpences
            // 
            this.txtApproExpences.Location = new System.Drawing.Point(129, 357);
            this.txtApproExpences.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApproExpences.Name = "txtApproExpences";
            this.txtApproExpences.Size = new System.Drawing.Size(173, 20);
            this.txtApproExpences.TabIndex = 415;
            this.txtApproExpences.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApproExpences_KeyDown);
            // 
            // lblEmployeeid
            // 
            this.lblEmployeeid.AutoSize = true;
            this.lblEmployeeid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployeeid.Location = new System.Drawing.Point(2, 252);
            this.lblEmployeeid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeid.Name = "lblEmployeeid";
            this.lblEmployeeid.Size = new System.Drawing.Size(13, 13);
            this.lblEmployeeid.TabIndex = 417;
            this.lblEmployeeid.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(15, 327);
            this.label29.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 17);
            this.label29.TabIndex = 419;
            this.label29.Text = "Against Bill No";
            // 
            // txtAgainstBillNo
            // 
            this.txtAgainstBillNo.Location = new System.Drawing.Point(133, 324);
            this.txtAgainstBillNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAgainstBillNo.Name = "txtAgainstBillNo";
            this.txtAgainstBillNo.Size = new System.Drawing.Size(169, 20);
            this.txtAgainstBillNo.TabIndex = 418;
            this.txtAgainstBillNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAgainstBillNo_KeyDown);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(416, 327);
            this.label30.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 17);
            this.label30.TabIndex = 421;
            this.label30.Text = "Bill Amount";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(521, 322);
            this.txtBillAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(173, 20);
            this.txtBillAmount.TabIndex = 420;
            this.txtBillAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillAmount_KeyDown);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(876, 327);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 7, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 17);
            this.label28.TabIndex = 423;
            this.label28.Text = "Paid Amount";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(975, 324);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(173, 20);
            this.txtPaidAmount.TabIndex = 422;
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // CALLRECORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 492);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtAgainstBillNo);
            this.Controls.Add(this.lblEmployeeid);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtApproExpences);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtRepairDetail);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtMobileNo1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtCharges);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtConcernPerson);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.cmbCallOf);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbWarantyStatus);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpVisitTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbCallStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpVisitDate);
            this.Controls.Add(this.cmbEmployeeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProblemFound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOtherDetail);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtModelNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtitemno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCallId);
            this.Controls.Add(this.cmbcalltype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.cmbCustomer);
            this.Name = "CALLRECORDER";
            this.Text = "CALLRECORDER";
            this.Load += new System.EventHandler(this.CALLRECORDER_Load);
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbcalltype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCallId;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtModelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtitemno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOtherDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProblemFound;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.ComboBox cmbCallStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.DateTimePicker dtpVisitTime;
        private System.Windows.Forms.ComboBox cmbWarantyStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCallOf;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtConcernPerson;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCharges;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMobileNo1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtRepairDetail;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtApproExpences;
        private System.Windows.Forms.Label lblEmployeeid;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtAgainstBillNo;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtPaidAmount;
    }
}