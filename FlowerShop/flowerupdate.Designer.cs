namespace FlowerShop
{
    partial class flowerupdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flowerupdate));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbiid = new System.Windows.Forms.ComboBox();
            this.tbfsalecost = new System.Windows.Forms.TextBox();
            this.tbfprice = new System.Windows.Forms.TextBox();
            this.cmbfname = new System.Windows.Forms.ComboBox();
            this.tbfid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbflanguage = new System.Windows.Forms.TextBox();
            this.btupdate = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("华文宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "> >修改花类";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbiid);
            this.groupBox1.Controls.Add(this.tbfsalecost);
            this.groupBox1.Controls.Add(this.tbfprice);
            this.groupBox1.Controls.Add(this.cmbfname);
            this.groupBox1.Controls.Add(this.tbfid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(142, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 944);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbiid
            // 
            this.cmbiid.FormattingEnabled = true;
            this.cmbiid.Location = new System.Drawing.Point(363, 559);
            this.cmbiid.Name = "cmbiid";
            this.cmbiid.Size = new System.Drawing.Size(400, 41);
            this.cmbiid.TabIndex = 10;
            this.cmbiid.Text = "   ——请选择编号——";
            // 
            // tbfsalecost
            // 
            this.tbfsalecost.Location = new System.Drawing.Point(363, 430);
            this.tbfsalecost.Name = "tbfsalecost";
            this.tbfsalecost.Size = new System.Drawing.Size(400, 44);
            this.tbfsalecost.TabIndex = 9;
            // 
            // tbfprice
            // 
            this.tbfprice.Location = new System.Drawing.Point(363, 329);
            this.tbfprice.Name = "tbfprice";
            this.tbfprice.Size = new System.Drawing.Size(400, 44);
            this.tbfprice.TabIndex = 8;
            // 
            // cmbfname
            // 
            this.cmbfname.FormattingEnabled = true;
            this.cmbfname.Location = new System.Drawing.Point(363, 212);
            this.cmbfname.Name = "cmbfname";
            this.cmbfname.Size = new System.Drawing.Size(400, 41);
            this.cmbfname.TabIndex = 7;
            this.cmbfname.Text = "   ——请选择花名——";
            this.cmbfname.SelectedIndexChanged += new System.EventHandler(this.cmbfname_SelectedIndexChanged);
            // 
            // tbfid
            // 
            this.tbfid.Location = new System.Drawing.Point(363, 96);
            this.tbfid.Name = "tbfid";
            this.tbfid.ReadOnly = true;
            this.tbfid.Size = new System.Drawing.Size(400, 44);
            this.tbfid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(143, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "仓库编号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(143, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "售卖价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(143, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "进货价：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(143, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "鲜花名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(143, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "鲜花编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbflanguage);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(48, 678);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1095, 226);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "花语";
            // 
            // tbflanguage
            // 
            this.tbflanguage.Location = new System.Drawing.Point(31, 52);
            this.tbflanguage.Multiline = true;
            this.tbflanguage.Name = "tbflanguage";
            this.tbflanguage.Size = new System.Drawing.Size(1031, 150);
            this.tbflanguage.TabIndex = 0;
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(169, 1063);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(170, 81);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(584, 1063);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(170, 81);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "重置";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(1059, 1063);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(170, 81);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "返回";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // flowerupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1472, 1190);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "flowerupdate";
            this.Text = "flowerupdatecs";
            this.Load += new System.EventHandler(this.flowerupdate_Load);
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
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.ComboBox cmbfname;
        private System.Windows.Forms.TextBox tbfid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbflanguage;
        private System.Windows.Forms.ComboBox cmbiid;
        private System.Windows.Forms.TextBox tbfsalecost;
        private System.Windows.Forms.TextBox tbfprice;
    }
}