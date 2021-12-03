namespace FlowerShop
{
    partial class provideupdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbfname = new System.Windows.Forms.ComboBox();
            this.tbfid = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.cmbsname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbremarks = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.tbinumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btupdate = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbfname);
            this.groupBox1.Controls.Add(this.tbfid);
            this.groupBox1.Controls.Add(this.tbphone);
            this.groupBox1.Controls.Add(this.cmbsname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(144, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1166, 688);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改供应";
            // 
            // cmbfname
            // 
            this.cmbfname.FormattingEnabled = true;
            this.cmbfname.Location = new System.Drawing.Point(338, 604);
            this.cmbfname.Name = "cmbfname";
            this.cmbfname.Size = new System.Drawing.Size(379, 41);
            this.cmbfname.TabIndex = 8;
            this.cmbfname.SelectedValueChanged += new System.EventHandler(this.cmbfname_SelectedValueChanged);
            // 
            // tbfid
            // 
            this.tbfid.Location = new System.Drawing.Point(338, 502);
            this.tbfid.Name = "tbfid";
            this.tbfid.ReadOnly = true;
            this.tbfid.Size = new System.Drawing.Size(379, 44);
            this.tbfid.TabIndex = 7;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(359, 157);
            this.tbphone.Name = "tbphone";
            this.tbphone.ReadOnly = true;
            this.tbphone.Size = new System.Drawing.Size(378, 44);
            this.tbphone.TabIndex = 6;
            // 
            // cmbsname
            // 
            this.cmbsname.FormattingEnabled = true;
            this.cmbsname.Location = new System.Drawing.Point(359, 64);
            this.cmbsname.Name = "cmbsname";
            this.cmbsname.Size = new System.Drawing.Size(378, 41);
            this.cmbsname.TabIndex = 5;
            this.cmbsname.Text = "--请选择供应商--";
            this.cmbsname.SelectedIndexChanged += new System.EventHandler(this.cmbsname_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "鲜花编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "鲜花名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "供应商";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbremarks);
            this.groupBox2.Location = new System.Drawing.Point(94, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1007, 209);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可提供鲜花信息";
            // 
            // tbremarks
            // 
            this.tbremarks.Location = new System.Drawing.Point(74, 66);
            this.tbremarks.Multiline = true;
            this.tbremarks.Name = "tbremarks";
            this.tbremarks.ReadOnly = true;
            this.tbremarks.Size = new System.Drawing.Size(849, 121);
            this.tbremarks.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dtptime);
            this.groupBox3.Controls.Add(this.tbinumber);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(144, 770);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1166, 254);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "供应填写";
            // 
            // dtptime
            // 
            this.dtptime.CustomFormat = "yyyy-MM-dd";
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptime.Location = new System.Drawing.Point(338, 184);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(379, 44);
            this.dtptime.TabIndex = 3;
            // 
            // tbinumber
            // 
            this.tbinumber.Location = new System.Drawing.Point(338, 63);
            this.tbinumber.Name = "tbinumber";
            this.tbinumber.Size = new System.Drawing.Size(379, 44);
            this.tbinumber.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "供应日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "供应数量";
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(144, 1084);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(170, 81);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(631, 1084);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(170, 81);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "重置";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(1140, 1071);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(170, 81);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "返回";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // provideupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._151;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1457, 1270);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "provideupdate";
            this.Text = "provideupdate";
            this.Load += new System.EventHandler(this.provideupdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.ComboBox cmbsname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbremarks;
        private System.Windows.Forms.TextBox tbfid;
        private System.Windows.Forms.ComboBox cmbfname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbinumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btcancel;
    }
}