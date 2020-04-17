namespace DipPlusProj
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.rbSnC = new System.Windows.Forms.RadioButton();
            this.rbS = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectaccbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSnC
            // 
            this.rbSnC.AutoSize = true;
            this.rbSnC.Location = new System.Drawing.Point(12, 26);
            this.rbSnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSnC.Name = "rbSnC";
            this.rbSnC.Size = new System.Drawing.Size(164, 17);
            this.rbSnC.TabIndex = 0;
            this.rbSnC.TabStop = true;
            this.rbSnC.Text = "Savings and Current Account";
            this.rbSnC.UseVisualStyleBackColor = true;
            // 
            // rbS
            // 
            this.rbS.AutoSize = true;
            this.rbS.Location = new System.Drawing.Point(12, 48);
            this.rbS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(106, 17);
            this.rbS.TabIndex = 1;
            this.rbS.TabStop = true;
            this.rbS.Text = "Savings Account";
            this.rbS.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(12, 70);
            this.rbC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(102, 17);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "Current Account";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.rbS);
            this.groupBox1.Controls.Add(this.rbSnC);
            this.groupBox1.Location = new System.Drawing.Point(109, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Type";
            // 
            // selectaccbtn
            // 
            this.selectaccbtn.Location = new System.Drawing.Point(238, 250);
            this.selectaccbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectaccbtn.Name = "selectaccbtn";
            this.selectaccbtn.Size = new System.Drawing.Size(95, 32);
            this.selectaccbtn.TabIndex = 4;
            this.selectaccbtn.Text = "Select";
            this.selectaccbtn.UseVisualStyleBackColor = true;
            this.selectaccbtn.Click += new System.EventHandler(this.selectaccbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(69, 250);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(95, 32);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.selectaccbtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Select Account Type";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSnC;
        private System.Windows.Forms.RadioButton rbS;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectaccbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}