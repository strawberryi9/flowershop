namespace FlowerShop
{
    partial class userupdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userupdate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbgygl = new System.Windows.Forms.CheckBox();
            this.cbgkgl = new System.Windows.Forms.CheckBox();
            this.cblsgl = new System.Windows.Forms.CheckBox();
            this.cbxtgl = new System.Windows.Forms.CheckBox();
            this.btupdate = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(175, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "身份选择";
            // 
            // cbid
            // 
            this.cbid.FormattingEnabled = true;
            this.cbid.Items.AddRange(new object[] {
            "管理员",
            "店长",
            "普通员工1",
            "普通员工2",
            "普通员工3",
            "普通员工4"});
            this.cbid.Location = new System.Drawing.Point(341, 89);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(401, 44);
            this.cbid.TabIndex = 16;
            this.cbid.Text = "  ——请选择身份——";
            this.cbid.SelectedValueChanged += new System.EventHandler(this.cbid_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份名称";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbgygl);
            this.groupBox2.Controls.Add(this.cbgkgl);
            this.groupBox2.Controls.Add(this.cblsgl);
            this.groupBox2.Controls.Add(this.cbxtgl);
            this.groupBox2.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(175, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "权限选择";
            // 
            // cbgygl
            // 
            this.cbgygl.AutoSize = true;
            this.cbgygl.Location = new System.Drawing.Point(555, 203);
            this.cbgygl.Name = "cbgygl";
            this.cbgygl.Size = new System.Drawing.Size(239, 40);
            this.cbgygl.TabIndex = 3;
            this.cbgygl.Text = "花店供应管理";
            this.cbgygl.UseVisualStyleBackColor = true;
            // 
            // cbgkgl
            // 
            this.cbgkgl.AutoSize = true;
            this.cbgkgl.Location = new System.Drawing.Point(555, 100);
            this.cbgkgl.Name = "cbgkgl";
            this.cbgkgl.Size = new System.Drawing.Size(239, 40);
            this.cbgkgl.TabIndex = 2;
            this.cbgkgl.Text = "顾客订购管理";
            this.cbgkgl.UseVisualStyleBackColor = true;
            // 
            // cblsgl
            // 
            this.cblsgl.AutoSize = true;
            this.cblsgl.Location = new System.Drawing.Point(51, 216);
            this.cblsgl.Name = "cblsgl";
            this.cblsgl.Size = new System.Drawing.Size(175, 40);
            this.cblsgl.TabIndex = 1;
            this.cblsgl.Text = "零售管理";
            this.cblsgl.UseVisualStyleBackColor = true;
            // 
            // cbxtgl
            // 
            this.cbxtgl.AutoSize = true;
            this.cbxtgl.Location = new System.Drawing.Point(51, 100);
            this.cbxtgl.Name = "cbxtgl";
            this.cbxtgl.Size = new System.Drawing.Size(175, 40);
            this.cbxtgl.TabIndex = 0;
            this.cbxtgl.Text = "用户管理";
            this.cbxtgl.UseVisualStyleBackColor = true;
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(163, 925);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(170, 81);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(962, 935);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(170, 81);
            this.btcancel.TabIndex = 3;
            this.btcancel.Text = "返回";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(201, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "修改用户权限";
            // 
            // userupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 1104);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userupdate";
            this.Text = "upuser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbgygl;
        private System.Windows.Forms.CheckBox cbgkgl;
        private System.Windows.Forms.CheckBox cblsgl;
        private System.Windows.Forms.CheckBox cbxtgl;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Label label2;
    }
}