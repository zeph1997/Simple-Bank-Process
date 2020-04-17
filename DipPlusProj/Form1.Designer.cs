namespace DipPlusProj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // usertxt
            // 
            this.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertxt.Location = new System.Drawing.Point(80, 13);
            this.usertxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(87, 20);
            this.usertxt.TabIndex = 2;
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(80, 44);
            this.passtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(87, 20);
            this.passtxt.TabIndex = 3;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(144, 68);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(60, 32);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login!";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(15, 68);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(69, 32);
            this.signupbtn.TabIndex = 5;
            this.signupbtn.Text = "Sign up!";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.signupbtn);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Controls.Add(this.passtxt);
            this.panel1.Controls.Add(this.usertxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(267, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 111);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(-9, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 74);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

