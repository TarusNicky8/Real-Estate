namespace ACCOUNTMANAGEMENT
{
    partial class Ledger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ledger));
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHERTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblcustid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlotSellId = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSurveyNo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPlotNo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(35, 43);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 208;
            this.lblCompanyName.Text = "Customer Name";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(961, 12);
            this.lblpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 13);
            this.lblpath.TabIndex = 241;
            // 
            // dgvinstallment
            // 
            this.dgvinstallment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATE,
            this.VOUCHERTYPE,
            this.VOUCHERNO,
            this.DEBIT,
            this.CREDIT,
            this.BAL});
            this.dgvinstallment.Location = new System.Drawing.Point(17, 105);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.Size = new System.Drawing.Size(915, 393);
            this.dgvinstallment.TabIndex = 245;
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            // 
            // VOUCHERTYPE
            // 
            this.VOUCHERTYPE.HeaderText = "VOUCHER TYPE";
            this.VOUCHERTYPE.Name = "VOUCHERTYPE";
            this.VOUCHERTYPE.Width = 250;
            // 
            // VOUCHERNO
            // 
            this.VOUCHERNO.HeaderText = "VOUCHER NO";
            this.VOUCHERNO.Name = "VOUCHERNO";
            // 
            // DEBIT
            // 
            this.DEBIT.HeaderText = "DEBIT";
            this.DEBIT.Name = "DEBIT";
            // 
            // CREDIT
            // 
            this.CREDIT.HeaderText = "CREDIT";
            this.CREDIT.Name = "CREDIT";
            // 
            // BAL
            // 
            this.BAL.HeaderText = "BALANCE";
            this.BAL.Name = "BAL";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(139, 40);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(311, 21);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.Leave += new System.EventHandler(this.cmbCustomer_Leave);
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcustid.Location = new System.Drawing.Point(14, 43);
            this.lblcustid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(13, 13);
            this.lblcustid.TabIndex = 248;
            this.lblcustid.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(951, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 249;
            // 
            // cmbPlotSellId
            // 
            this.cmbPlotSellId.FormattingEnabled = true;
            this.cmbPlotSellId.Location = new System.Drawing.Point(630, 75);
            this.cmbPlotSellId.Name = "cmbPlotSellId";
            this.cmbPlotSellId.Size = new System.Drawing.Size(124, 21);
            this.cmbPlotSellId.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(527, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 262;
            this.label13.Text = "Against Plot Sell Id";
            // 
            // cmbSurveyNo
            // 
            this.cmbSurveyNo.FormattingEnabled = true;
            this.cmbSurveyNo.Location = new System.Drawing.Point(379, 71);
            this.cmbSurveyNo.Name = "cmbSurveyNo";
            this.cmbSurveyNo.Size = new System.Drawing.Size(124, 21);
            this.cmbSurveyNo.TabIndex = 3;
            this.cmbSurveyNo.Leave += new System.EventHandler(this.cmbSurveyNo_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(276, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 260;
            this.label12.Text = "Against Survey No";
            // 
            // cmbPlotNo
            // 
            this.cmbPlotNo.FormattingEnabled = true;
            this.cmbPlotNo.Location = new System.Drawing.Point(138, 69);
            this.cmbPlotNo.Name = "cmbPlotNo";
            this.cmbPlotNo.Size = new System.Drawing.Size(124, 21);
            this.cmbPlotNo.TabIndex = 2;
            this.cmbPlotNo.Leave += new System.EventHandler(this.cmbPlotNo_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(28, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 258;
            this.label10.Text = "Against Plot No";
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(560, 22);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(83, 36);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "&New";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(766, 22);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 36);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "&Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(667, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(973, 486);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cmbPlotSellId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSurveyNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbPlotNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "Ledger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger";
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.DataGridView dgvinstallment;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblcustid;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlotSellId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSurveyNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbPlotNo;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAL;
    }
}