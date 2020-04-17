namespace DipPlusProj
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.signbtn = new System.Windows.Forms.Button();
            this.backlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.mtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelpemail = new System.Windows.Forms.Label();
            this.pemail = new System.Windows.Forms.TextBox();
            this.Ncc = new System.Windows.Forms.RadioButton();
            this.Ndc = new System.Windows.Forms.RadioButton();
            this.cnorms = new System.Windows.Forms.GroupBox();
            this.platradio = new System.Windows.Forms.RadioButton();
            this.blackradio = new System.Windows.Forms.RadioButton();
            this.HNW = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cnorms.SuspendLayout();
            this.HNW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signbtn
            // 
            this.signbtn.Location = new System.Drawing.Point(258, 469);
            this.signbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signbtn.Name = "signbtn";
            this.signbtn.Size = new System.Drawing.Size(94, 37);
            this.signbtn.TabIndex = 0;
            this.signbtn.Text = "Sign up!";
            this.signbtn.UseVisualStyleBackColor = true;
            this.signbtn.Click += new System.EventHandler(this.signbtn_Click);
            // 
            // backlogin
            // 
            this.backlogin.Location = new System.Drawing.Point(28, 469);
            this.backlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backlogin.Name = "backlogin";
            this.backlogin.Size = new System.Drawing.Size(94, 37);
            this.backlogin.TabIndex = 1;
            this.backlogin.Text = "Back";
            this.backlogin.UseVisualStyleBackColor = true;
            this.backlogin.Click += new System.EventHandler(this.backlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re enter Password:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(161, 114);
            this.user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(103, 20);
            this.user.TabIndex = 5;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(160, 138);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(103, 20);
            this.pass.TabIndex = 6;
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(160, 162);
            this.pass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(103, 20);
            this.pass2.TabIndex = 7;
            // 
            // mtype
            // 
            this.mtype.FormattingEnabled = true;
            this.mtype.Items.AddRange(new object[] {
            "Under 18",
            "Normal",
            "High Net Worth"});
            this.mtype.Location = new System.Drawing.Point(161, 210);
            this.mtype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtype.Name = "mtype";
            this.mtype.Size = new System.Drawing.Size(102, 21);
            this.mtype.TabIndex = 8;
            this.mtype.SelectedIndexChanged += new System.EventHandler(this.mtype_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Membership Type:";
            // 
            // labelpemail
            // 
            this.labelpemail.AutoSize = true;
            this.labelpemail.Location = new System.Drawing.Point(51, 237);
            this.labelpemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpemail.Name = "labelpemail";
            this.labelpemail.Size = new System.Drawing.Size(104, 13);
            this.labelpemail.TabIndex = 10;
            this.labelpemail.Text = "Enter Parent\'s Email:";
            // 
            // pemail
            // 
            this.pemail.Location = new System.Drawing.Point(161, 235);
            this.pemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pemail.Name = "pemail";
            this.pemail.Size = new System.Drawing.Size(103, 20);
            this.pemail.TabIndex = 11;
            // 
            // Ncc
            // 
            this.Ncc.AutoSize = true;
            this.Ncc.Location = new System.Drawing.Point(34, 17);
            this.Ncc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ncc.Name = "Ncc";
            this.Ncc.Size = new System.Drawing.Size(77, 17);
            this.Ncc.TabIndex = 12;
            this.Ncc.TabStop = true;
            this.Ncc.Text = "Credit Card";
            this.Ncc.UseVisualStyleBackColor = true;
            // 
            // Ndc
            // 
            this.Ndc.AutoSize = true;
            this.Ndc.Location = new System.Drawing.Point(34, 39);
            this.Ndc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ndc.Name = "Ndc";
            this.Ndc.Size = new System.Drawing.Size(75, 17);
            this.Ndc.TabIndex = 13;
            this.Ndc.TabStop = true;
            this.Ndc.Text = "Debit Card";
            this.Ndc.UseVisualStyleBackColor = true;
            // 
            // cnorms
            // 
            this.cnorms.Controls.Add(this.Ndc);
            this.cnorms.Controls.Add(this.Ncc);
            this.cnorms.Location = new System.Drawing.Point(102, 272);
            this.cnorms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cnorms.Name = "cnorms";
            this.cnorms.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cnorms.Size = new System.Drawing.Size(138, 68);
            this.cnorms.TabIndex = 14;
            this.cnorms.TabStop = false;
            this.cnorms.Text = "Card Type";
            // 
            // platradio
            // 
            this.platradio.AutoSize = true;
            this.platradio.Location = new System.Drawing.Point(34, 39);
            this.platradio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.platradio.Name = "platradio";
            this.platradio.Size = new System.Drawing.Size(90, 17);
            this.platradio.TabIndex = 15;
            this.platradio.TabStop = true;
            this.platradio.Text = "Platinum Card";
            this.platradio.UseVisualStyleBackColor = true;
            // 
            // blackradio
            // 
            this.blackradio.AutoSize = true;
            this.blackradio.Location = new System.Drawing.Point(34, 17);
            this.blackradio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blackradio.Name = "blackradio";
            this.blackradio.Size = new System.Drawing.Size(77, 17);
            this.blackradio.TabIndex = 16;
            this.blackradio.TabStop = true;
            this.blackradio.Text = "Black Card";
            this.blackradio.UseVisualStyleBackColor = true;
            this.blackradio.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // HNW
            // 
            this.HNW.Controls.Add(this.blackradio);
            this.HNW.Controls.Add(this.platradio);
            this.HNW.Location = new System.Drawing.Point(102, 362);
            this.HNW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HNW.Name = "HNW";
            this.HNW.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HNW.Size = new System.Drawing.Size(137, 76);
            this.HNW.TabIndex = 17;
            this.HNW.TabStop = false;
            this.HNW.Text = "Card Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(161, 186);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(103, 20);
            this.name.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HNW);
            this.Controls.Add(this.cnorms);
            this.Controls.Add(this.pemail);
            this.Controls.Add(this.labelpemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtype);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backlogin);
            this.Controls.Add(this.signbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.cnorms.ResumeLayout(false);
            this.cnorms.PerformLayout();
            this.HNW.ResumeLayout(false);
            this.HNW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signbtn;
        private System.Windows.Forms.Button backlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.ComboBox mtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelpemail;
        private System.Windows.Forms.TextBox pemail;
        private System.Windows.Forms.RadioButton Ncc;
        private System.Windows.Forms.RadioButton Ndc;
        private System.Windows.Forms.GroupBox cnorms;
        private System.Windows.Forms.RadioButton platradio;
        private System.Windows.Forms.RadioButton blackradio;
        private System.Windows.Forms.GroupBox HNW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}