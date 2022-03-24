namespace ACCOUNTMANAGEMENT
{
    partial class LEDGERAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LEDGERAM));
            this.label1 = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblpath = new System.Windows.Forms.Label();
            this.VOUCHERTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.VOUCHERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(956, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 274;
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcustid.Location = new System.Drawing.Point(19, 40);
            this.lblcustid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(13, 13);
            this.lblcustid.TabIndex = 273;
            this.lblcustid.Text = "0";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(144, 37);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(311, 21);
            this.cmbCustomer.TabIndex = 264;
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(966, 9);
            this.lblpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 13);
            this.lblpath.TabIndex = 271;
            // 
            // VOUCHERTYPE
            // 
            this.VOUCHERTYPE.HeaderText = "VOUCHER TYPE";
            this.VOUCHERTYPE.Name = "VOUCHERTYPE";
            this.VOUCHERTYPE.Width = 250;
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
            this.dgvinstallment.Location = new System.Drawing.Point(22, 87);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.Size = new System.Drawing.Size(915, 393);
            this.dgvinstallment.TabIndex = 272;
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
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(40, 40);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 270;
            this.lblCompanyName.Text = "Customer Name";
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(565, 19);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(83, 36);
            this.btn_new.TabIndex = 263;
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
            this.btn_close.Location = new System.Drawing.Point(771, 19);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 36);
            this.btn_close.TabIndex = 269;
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
            this.btnSearch.Location = new System.Drawing.Point(672, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 268;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LEDGERAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1059, 529);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "LEDGERAM";
            this.Text = "LEDGERAM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.ComboBox cmbCustomer;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERTYPE;
        private System.Windows.Forms.DataGridView dgvinstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAL;
        private System.Windows.Forms.Label lblCompanyName;
    }
}