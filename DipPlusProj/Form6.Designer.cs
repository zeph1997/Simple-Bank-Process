namespace DipPlusProj
{
    partial class Form6
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
            this.lblaccno = new System.Windows.Forms.Label();
            this.lblaccname = new System.Windows.Forms.Label();
            this.btnaction = new System.Windows.Forms.Button();
            this.lblBal = new System.Windows.Forms.Label();
            this.lbltextbal = new System.Windows.Forms.Label();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.dgTransaction = new System.Windows.Forms.DataGridView();
            this.numtransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWithdraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.lblaccountno = new System.Windows.Forms.Label();
            this.lblaccountname = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblaccno
            // 
            this.lblaccno.AutoSize = true;
            this.lblaccno.Location = new System.Drawing.Point(20, 18);
            this.lblaccno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblaccno.Name = "lblaccno";
            this.lblaccno.Size = new System.Drawing.Size(90, 13);
            this.lblaccno.TabIndex = 0;
            this.lblaccno.Text = "Account Number:";
            // 
            // lblaccname
            // 
            this.lblaccname.AutoSize = true;
            this.lblaccname.Location = new System.Drawing.Point(20, 40);
            this.lblaccname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblaccname.Name = "lblaccname";
            this.lblaccname.Size = new System.Drawing.Size(81, 13);
            this.lblaccname.TabIndex = 1;
            this.lblaccname.Text = "Account Name:";
            // 
            // btnaction
            // 
            this.btnaction.Location = new System.Drawing.Point(183, 176);
            this.btnaction.Name = "btnaction";
            this.btnaction.Size = new System.Drawing.Size(75, 23);
            this.btnaction.TabIndex = 3;
            this.btnaction.Text = "Transact";
            this.btnaction.UseVisualStyleBackColor = true;
            this.btnaction.Click += new System.EventHandler(this.btnaction_Click);
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Location = new System.Drawing.Point(113, 176);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(31, 13);
            this.lblBal.TabIndex = 4;
            this.lblBal.Text = "5000";
            // 
            // lbltextbal
            // 
            this.lbltextbal.AutoSize = true;
            this.lbltextbal.Location = new System.Drawing.Point(15, 176);
            this.lbltextbal.Name = "lbltextbal";
            this.lbltextbal.Size = new System.Drawing.Size(92, 13);
            this.lbltextbal.TabIndex = 5;
            this.lbltextbal.Text = "Account Balance:";
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(183, 141);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(70, 17);
            this.rbWithdraw.TabIndex = 6;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(183, 118);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(61, 17);
            this.rbDeposit.TabIndex = 7;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // dgTransaction
            // 
            this.dgTransaction.AllowUserToAddRows = false;
            this.dgTransaction.AllowUserToDeleteRows = false;
            this.dgTransaction.AllowUserToResizeColumns = false;
            this.dgTransaction.AllowUserToResizeRows = false;
            this.dgTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numtransaction,
            this.colDeposit,
            this.colWithdraw});
            this.dgTransaction.Location = new System.Drawing.Point(271, 18);
            this.dgTransaction.MultiSelect = false;
            this.dgTransaction.Name = "dgTransaction";
            this.dgTransaction.ReadOnly = true;
            this.dgTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgTransaction.Size = new System.Drawing.Size(237, 150);
            this.dgTransaction.TabIndex = 8;
            // 
            // numtransaction
            // 
            this.numtransaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numtransaction.Frozen = true;
            this.numtransaction.HeaderText = "No.";
            this.numtransaction.Name = "numtransaction";
            this.numtransaction.ReadOnly = true;
            this.numtransaction.Width = 49;
            // 
            // colDeposit
            // 
            this.colDeposit.Frozen = true;
            this.colDeposit.HeaderText = "Deposit";
            this.colDeposit.Name = "colDeposit";
            this.colDeposit.ReadOnly = true;
            this.colDeposit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDeposit.Width = 75;
            // 
            // colWithdraw
            // 
            this.colWithdraw.Frozen = true;
            this.colWithdraw.HeaderText = "Withdraw";
            this.colWithdraw.Name = "colWithdraw";
            this.colWithdraw.ReadOnly = true;
            this.colWithdraw.Width = 75;
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(94, 127);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(71, 20);
            this.txtamt.TabIndex = 9;
            // 
            // lblaccountno
            // 
            this.lblaccountno.AutoSize = true;
            this.lblaccountno.Location = new System.Drawing.Point(111, 18);
            this.lblaccountno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblaccountno.Name = "lblaccountno";
            this.lblaccountno.Size = new System.Drawing.Size(87, 13);
            this.lblaccountno.TabIndex = 10;
            this.lblaccountno.Text = "Account Number";
            // 
            // lblaccountname
            // 
            this.lblaccountname.AutoSize = true;
            this.lblaccountname.Location = new System.Drawing.Point(111, 40);
            this.lblaccountname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblaccountname.Name = "lblaccountname";
            this.lblaccountname.Size = new System.Drawing.Size(78, 13);
            this.lblaccountname.TabIndex = 11;
            this.lblaccountname.Text = "Account Name";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(412, 246);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 297);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblaccountname);
            this.Controls.Add(this.lblaccountno);
            this.Controls.Add(this.txtamt);
            this.Controls.Add(this.dgTransaction);
            this.Controls.Add(this.rbDeposit);
            this.Controls.Add(this.rbWithdraw);
            this.Controls.Add(this.lbltextbal);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.btnaction);
            this.Controls.Add(this.lblaccname);
            this.Controls.Add(this.lblaccno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form6";
            this.Text = "Deposit/Withdraw Cash";
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaccno;
        private System.Windows.Forms.Label lblaccname;
        private System.Windows.Forms.Button btnaction;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label lbltextbal;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.DataGridView dgTransaction;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWithdraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeposit;
        private System.Windows.Forms.Label lblaccountno;
        private System.Windows.Forms.Label lblaccountname;
        private System.Windows.Forms.Button btnback;
    }
}