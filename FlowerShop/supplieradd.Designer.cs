namespace FlowerShop
{
    partial class supplieradd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplieradd));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsname = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbremarks = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = ">>添加供应商";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbremarks);
            this.groupBox1.Controls.Add(this.tbaddress);
            this.groupBox1.Controls.Add(this.tbphone);
            this.groupBox1.Controls.Add(this.tbsname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(137, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 816);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "供应商";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "电话";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "备注供货材料";
            // 
            // tbsname
            // 
            this.tbsname.Location = new System.Drawing.Point(354, 83);
            this.tbsname.Name = "tbsname";
            this.tbsname.Size = new System.Drawing.Size(362, 44);
            this.tbsname.TabIndex = 4;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(354, 199);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(362, 44);
            this.tbphone.TabIndex = 5;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(354, 312);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(362, 44);
            this.tbaddress.TabIndex = 6;
            // 
            // tbremarks
            // 
            this.tbremarks.Location = new System.Drawing.Point(84, 509);
            this.tbremarks.Multiline = true;
            this.tbremarks.Name = "tbremarks";
            this.tbremarks.Size = new System.Drawing.Size(928, 268);
            this.tbremarks.TabIndex = 7;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(137, 1056);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(151, 77);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "添加";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(577, 1056);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(151, 77);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "重置";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(1055, 1056);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(151, 77);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "退出";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // supplieradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 1184);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "supplieradd";
            this.Text = "supplieradd";
            this.Load += new System.EventHandler(this.supplieradd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbremarks;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbsname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btcancel;
    }
}