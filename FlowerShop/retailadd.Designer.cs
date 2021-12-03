namespace FlowerShop
{
    partial class retailadd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.cmbfid = new System.Windows.Forms.ComboBox();
            this.tbfsalecost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbinumber = new System.Windows.Forms.TextBox();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = ">>零售添加";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbfname);
            this.groupBox1.Controls.Add(this.cmbfid);
            this.groupBox1.Controls.Add(this.tbfsalecost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(173, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "花类选择";
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(316, 161);
            this.tbfname.Name = "tbfname";
            this.tbfname.ReadOnly = true;
            this.tbfname.Size = new System.Drawing.Size(380, 49);
            this.tbfname.TabIndex = 5;
            // 
            // cmbfid
            // 
            this.cmbfid.FormattingEnabled = true;
            this.cmbfid.Location = new System.Drawing.Point(316, 65);
            this.cmbfid.Name = "cmbfid";
            this.cmbfid.Size = new System.Drawing.Size(380, 44);
            this.cmbfid.TabIndex = 4;
            this.cmbfid.Text = "——请选择编号——";
            this.cmbfid.SelectedIndexChanged += new System.EventHandler(this.cmbfid_SelectedIndexChanged);
            // 
            // tbfsalecost
            // 
            this.tbfsalecost.Location = new System.Drawing.Point(316, 257);
            this.tbfsalecost.Name = "tbfsalecost";
            this.tbfsalecost.ReadOnly = true;
            this.tbfsalecost.Size = new System.Drawing.Size(392, 49);
            this.tbfsalecost.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "销售金额";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "编号";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbinumber);
            this.groupBox2.Controls.Add(this.dtptime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(173, 659);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 312);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "零售填写";
            // 
            // tbinumber
            // 
            this.tbinumber.Location = new System.Drawing.Point(423, 82);
            this.tbinumber.Name = "tbinumber";
            this.tbinumber.Size = new System.Drawing.Size(357, 49);
            this.tbinumber.TabIndex = 3;
            this.tbinumber.TextChanged += new System.EventHandler(this.tbinumber_TextChanged);
            // 
            // dtptime
            // 
            this.dtptime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptime.Location = new System.Drawing.Point(423, 181);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(371, 49);
            this.dtptime.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "零售时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "零售数量";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(100, 1045);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(170, 81);
            this.btadd.TabIndex = 3;
            this.btadd.Text = "添加";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(597, 1045);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(170, 81);
            this.btreset.TabIndex = 4;
            this.btreset.Text = "重置";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(1099, 1045);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(170, 81);
            this.btcancel.TabIndex = 5;
            this.btcancel.Text = "返回";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // retailadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._182;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1505, 1206);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "retailadd";
            this.Text = "retailadd";
            this.Load += new System.EventHandler(this.retailadd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbfid;
        private System.Windows.Forms.TextBox tbfsalecost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbinumber;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btcancel;
    }
}