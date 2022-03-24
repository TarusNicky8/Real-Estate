namespace ACCOUNTMANAGEMENT
{
    partial class CallRecorderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallRecorderReport));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.lblpath = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.CALLID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROBLEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VISITDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VISITTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALLSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROBLEMFOUND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1032, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 283;
            // 
            // dgvinstallment
            // 
            this.dgvinstallment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CALLID,
            this.ACCOUNTNAME,
            this.ADDRESS,
            this.PHONE,
            this.ITEMNAME,
            this.PROBLEM,
            this.EMPLOYEENAME,
            this.VISITDATE,
            this.VISITTIME,
            this.CALLSTATUS,
            this.PROBLEMFOUND});
            this.dgvinstallment.Location = new System.Drawing.Point(8, 124);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.Size = new System.Drawing.Size(1248, 393);
            this.dgvinstallment.TabIndex = 281;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1042, 31);
            this.lblpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 13);
            this.lblpath.TabIndex = 280;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnView);
            this.GroupBox1.Controls.Add(this.btnReset);
            this.GroupBox1.Controls.Add(this.btnExportExcel);
            this.GroupBox1.Location = new System.Drawing.Point(597, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(334, 90);
            this.GroupBox1.TabIndex = 285;
            this.GroupBox1.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(12, 27);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 39);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "&View Report";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(121, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 39);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "&Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(212, 27);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(104, 39);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "&Export Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dtpDateTo);
            this.GroupBox2.Controls.Add(this.dtpDateFrom);
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(30, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(349, 90);
            this.GroupBox2.TabIndex = 284;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search By Check IN Date :";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(142, 42);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(120, 20);
            this.dtpDateTo.TabIndex = 244;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(6, 42);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(120, 20);
            this.dtpDateFrom.TabIndex = 244;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(267, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(143, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(26, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "To :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(10, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "From :";
            // 
            // CALLID
            // 
            this.CALLID.HeaderText = "CALLID";
            this.CALLID.Name = "CALLID";
            // 
            // ACCOUNTNAME
            // 
            this.ACCOUNTNAME.HeaderText = "CUSTOMER NAME";
            this.ACCOUNTNAME.Name = "ACCOUNTNAME";
            // 
            // ADDRESS
            // 
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            // 
            // PHONE
            // 
            this.PHONE.HeaderText = "PHONE NO";
            this.PHONE.Name = "PHONE";
            // 
            // ITEMNAME
            // 
            this.ITEMNAME.HeaderText = "ITEM NAME";
            this.ITEMNAME.Name = "ITEMNAME";
            // 
            // PROBLEM
            // 
            this.PROBLEM.HeaderText = "PROBLEM";
            this.PROBLEM.Name = "PROBLEM";
            // 
            // EMPLOYEENAME
            // 
            this.EMPLOYEENAME.HeaderText = "EMPLOYEE NAME";
            this.EMPLOYEENAME.Name = "EMPLOYEENAME";
            // 
            // VISITDATE
            // 
            this.VISITDATE.HeaderText = "VISIT DATE";
            this.VISITDATE.Name = "VISITDATE";
            // 
            // VISITTIME
            // 
            this.VISITTIME.HeaderText = "VISIT TIME";
            this.VISITTIME.Name = "VISITTIME";
            // 
            // CALLSTATUS
            // 
            this.CALLSTATUS.HeaderText = "STATUS";
            this.CALLSTATUS.Name = "CALLSTATUS";
            // 
            // PROBLEMFOUND
            // 
            this.PROBLEMFOUND.HeaderText = "DIGNOSYS BY ENGINEER";
            this.PROBLEMFOUND.Name = "PROBLEMFOUND";
            // 
            // CallRecorderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 532);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.lblpath);
            this.Name = "CallRecorderReport";
            this.Text = "CallRecorderReport";
            this.Load += new System.EventHandler(this.CallRecorderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvinstallment;
        public System.Windows.Forms.Label lblpath;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnView;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnExportExcel;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALLID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VISITDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VISITTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALLSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEMFOUND;
    }
}