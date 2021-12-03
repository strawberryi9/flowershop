namespace FlowerShop
{
    partial class useradd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(useradd));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.conpwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "> >添加用户";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.conpwd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(186, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 590);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbid
            // 
            this.cbid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbid.FormattingEnabled = true;
            this.cbid.Items.AddRange(new object[] {
            "管理员",
            "店长",
            "普通员工1",
            "普通员工2",
            "普通员工3",
            "普通员工4",
            "普通员工5",
            "普通员工6"});
            this.cbid.Location = new System.Drawing.Point(408, 409);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(401, 41);
            this.cbid.TabIndex = 7;
            this.cbid.Text = "  ——请选择身份——";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(112, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "身        份：";
            // 
            // conpwd
            // 
            this.conpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.conpwd.Location = new System.Drawing.Point(408, 302);
            this.conpwd.Name = "conpwd";
            this.conpwd.PasswordChar = '*';
            this.conpwd.Size = new System.Drawing.Size(401, 44);
            this.conpwd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(112, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "确认密码：";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(408, 198);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(401, 44);
            this.password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(112, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "密        码：";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(408, 91);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(401, 44);
            this.username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(112, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名称：";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(197, 960);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(170, 81);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "添加";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(660, 960);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(170, 81);
            this.btclear.TabIndex = 3;
            this.btclear.Text = "重置";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(1114, 960);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(170, 81);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "返回";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // useradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1503, 1154);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "useradd";
            this.Text = "useradd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox conpwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btcancel;
    }
}