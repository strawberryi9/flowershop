namespace FlowerShop
{
    partial class retailupdate
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
            this.tbfsalecost = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.cmbfid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.tbinumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btupdate = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbfsalecost);
            this.groupBox1.Controls.Add(this.tbfname);
            this.groupBox1.Controls.Add(this.cmbfid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(214, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "花类选择";
            // 
            // tbfsalecost
            // 
            this.tbfsalecost.Location = new System.Drawing.Point(315, 263);
            this.tbfsalecost.Name = "tbfsalecost";
            this.tbfsalecost.ReadOnly = true;
            this.tbfsalecost.Size = new System.Drawing.Size(362, 49);
            this.tbfsalecost.TabIndex = 5;
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(315, 169);
            this.tbfname.Name = "tbfname";
            this.tbfname.ReadOnly = true;
            this.tbfname.Size = new System.Drawing.Size(362, 49);
            this.tbfname.TabIndex = 4;
            // 
            // cmbfid
            // 
            this.cmbfid.FormattingEnabled = true;
            this.cmbfid.Location = new System.Drawing.Point(315, 75);
            this.cmbfid.Name = "cmbfid";
            this.cmbfid.Size = new System.Drawing.Size(362, 44);
            this.cmbfid.TabIndex = 3;
            this.cmbfid.Text = "——请选择编号——";
            this.cmbfid.SelectedIndexChanged += new System.EventHandler(this.cmbfid_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "销售价额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtptime);
            this.groupBox2.Controls.Add(this.tbinumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(214, 622);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "零售填写";
            // 
            // dtptime
            // 
            this.dtptime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptime.Location = new System.Drawing.Point(261, 141);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(381, 44);
            this.dtptime.TabIndex = 3;
            // 
            // tbinumber
            // 
            this.tbinumber.Location = new System.Drawing.Point(261, 69);
            this.tbinumber.Name = "tbinumber";
            this.tbinumber.Size = new System.Drawing.Size(381, 44);
            this.tbinumber.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "零售时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "零售数量：";
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(103, 957);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(170, 81);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(572, 957);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(170, 81);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "重置";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(1076, 957);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(170, 81);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "返回";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(29, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = ">>修改零售";
            // 
            // retailupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._191;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1452, 1101);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "retailupdate";
            this.Text = "retailupdate";
            this.Load += new System.EventHandler(this.retailupdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.TextBox tbfsalecost;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.ComboBox cmbfid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.TextBox tbinumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}