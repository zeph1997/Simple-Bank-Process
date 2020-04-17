namespace DipPlusProj
{
    partial class Transfer
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
            this.JustDoIt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.finalbal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JustDoIt
            // 
            this.JustDoIt.Location = new System.Drawing.Point(257, 248);
            this.JustDoIt.Name = "JustDoIt";
            this.JustDoIt.Size = new System.Drawing.Size(74, 27);
            this.JustDoIt.TabIndex = 0;
            this.JustDoIt.Text = "Transfer";
            this.JustDoIt.UseVisualStyleBackColor = true;
            this.JustDoIt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "To";
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(194, 113);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(74, 20);
            this.txtto.TabIndex = 5;
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(130, 178);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(74, 20);
            this.txtamt.TabIndex = 6;
            // 
            // finalbal
            // 
            this.finalbal.Location = new System.Drawing.Point(174, 217);
            this.finalbal.Name = "finalbal";
            this.finalbal.Size = new System.Drawing.Size(74, 20);
            this.finalbal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Your Balance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Your Account";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Location = new System.Drawing.Point(59, 113);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(0, 13);
            this.lblfrom.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 48);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transfer";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 280);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finalbal);
            this.Controls.Add(this.txtamt);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JustDoIt);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JustDoIt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.TextBox finalbal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label label5;
    }
}