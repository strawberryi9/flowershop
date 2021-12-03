namespace FlowerShop
{
    partial class repasswd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpwd = new System.Windows.Forms.TextBox();
            this.tbnewpwd = new System.Windows.Forms.TextBox();
            this.tbrepwd = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "> >重置密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(218, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(218, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(218, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "原密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(218, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "确认密码";
            // 
            // tbuser
            // 
            this.tbuser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbuser.Location = new System.Drawing.Point(408, 180);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(338, 44);
            this.tbuser.TabIndex = 5;
            // 
            // tbpwd
            // 
            this.tbpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbpwd.Location = new System.Drawing.Point(408, 292);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Size = new System.Drawing.Size(338, 44);
            this.tbpwd.TabIndex = 6;
            // 
            // tbnewpwd
            // 
            this.tbnewpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbnewpwd.Location = new System.Drawing.Point(417, 433);
            this.tbnewpwd.Name = "tbnewpwd";
            this.tbnewpwd.PasswordChar = '*';
            this.tbnewpwd.Size = new System.Drawing.Size(329, 44);
            this.tbnewpwd.TabIndex = 7;
            // 
            // tbrepwd
            // 
            this.tbrepwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbrepwd.Location = new System.Drawing.Point(417, 561);
            this.tbrepwd.Name = "tbrepwd";
            this.tbrepwd.PasswordChar = '*';
            this.tbrepwd.Size = new System.Drawing.Size(329, 44);
            this.tbrepwd.TabIndex = 8;
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(207, 864);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(151, 80);
            this.btok.TabIndex = 9;
            this.btok.Text = "提交";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(767, 864);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(151, 80);
            this.btreset.TabIndex = 10;
            this.btreset.Text = "重置";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // repasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._24;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 1055);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.tbrepwd);
            this.Controls.Add(this.tbnewpwd);
            this.Controls.Add(this.tbpwd);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "repasswd";
            this.Text = "repasswd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbpwd;
        private System.Windows.Forms.TextBox tbnewpwd;
        private System.Windows.Forms.TextBox tbrepwd;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btreset;
    }
}