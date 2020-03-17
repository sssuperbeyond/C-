namespace World_Game
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vc = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.CheckBox();
            this.loginbu = new System.Windows.Forms.Button();
            this.closebu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(372, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(116, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "The system can be logged in through email and password\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(253, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(341, 153);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(201, 25);
            this.email.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(223, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "PassWord:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(341, 206);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(201, 25);
            this.pass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(133, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Verification Code:";
            this.label5.Visible = false;
            // 
            // vc
            // 
            this.vc.Location = new System.Drawing.Point(341, 261);
            this.vc.Name = "vc";
            this.vc.Size = new System.Drawing.Size(118, 25);
            this.vc.TabIndex = 3;
            this.vc.Visible = false;
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.code.Location = new System.Drawing.Point(465, 261);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(77, 25);
            this.code.TabIndex = 4;
            this.code.UseVisualStyleBackColor = true;
            this.code.Visible = false;
            this.code.Click += new System.EventHandler(this.code_Click);
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Location = new System.Drawing.Point(331, 312);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(189, 19);
            this.auto.TabIndex = 5;
            this.auto.Text = "Auto login in 7 days";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // loginbu
            // 
            this.loginbu.Location = new System.Drawing.Point(307, 372);
            this.loginbu.Name = "loginbu";
            this.loginbu.Size = new System.Drawing.Size(65, 29);
            this.loginbu.TabIndex = 6;
            this.loginbu.Text = "Login";
            this.loginbu.UseVisualStyleBackColor = true;
            this.loginbu.Click += new System.EventHandler(this.button1_Click);
            // 
            // closebu
            // 
            this.closebu.Location = new System.Drawing.Point(427, 372);
            this.closebu.Name = "closebu";
            this.closebu.Size = new System.Drawing.Size(65, 29);
            this.closebu.TabIndex = 6;
            this.closebu.Text = "Close";
            this.closebu.UseVisualStyleBackColor = true;
            this.closebu.Click += new System.EventHandler(this.closebu_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closebu);
            this.Controls.Add(this.loginbu);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.code);
            this.Controls.Add(this.vc);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.Activated += new System.EventHandler(this.login_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vc;
        private System.Windows.Forms.Button code;
        private System.Windows.Forms.CheckBox auto;
        private System.Windows.Forms.Button loginbu;
        private System.Windows.Forms.Button closebu;
    }
}