namespace FlowerShop
{
    partial class retailselect
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbfid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbrid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btselect = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(937, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "> >查询零售";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbfid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbrid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(122, 743);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cmbfid
            // 
            this.cmbfid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbfid.FormattingEnabled = true;
            this.cmbfid.Location = new System.Drawing.Point(820, 71);
            this.cmbfid.Name = "cmbfid";
            this.cmbfid.Size = new System.Drawing.Size(272, 41);
            this.cmbfid.TabIndex = 3;
            this.cmbfid.Text = "--请选择编号--";
            this.cmbfid.SelectedIndexChanged += new System.EventHandler(this.cmbfid_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(628, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "花编号：";
            // 
            // cmbrid
            // 
            this.cmbrid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbrid.FormattingEnabled = true;
            this.cmbrid.Location = new System.Drawing.Point(232, 68);
            this.cmbrid.Name = "cmbrid";
            this.cmbrid.Size = new System.Drawing.Size(262, 41);
            this.cmbrid.TabIndex = 1;
            this.cmbrid.Text = "--请选择编号--";
            this.cmbrid.SelectedIndexChanged += new System.EventHandler(this.cmbrid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "零售编号：";
            // 
            // btselect
            // 
            this.btselect.Location = new System.Drawing.Point(122, 1031);
            this.btselect.Name = "btselect";
            this.btselect.Size = new System.Drawing.Size(170, 81);
            this.btselect.TabIndex = 3;
            this.btselect.Text = "查询";
            this.btselect.UseVisualStyleBackColor = true;
            this.btselect.Click += new System.EventHandler(this.btselect_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(618, 1031);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(170, 81);
            this.btreset.TabIndex = 4;
            this.btreset.Text = "重置";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(1104, 1031);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(170, 81);
            this.btcancel.TabIndex = 5;
            this.btcancel.Text = "返回";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // retailselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._231;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1565, 1196);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btselect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "retailselect";
            this.Text = "retailselect";
            this.Load += new System.EventHandler(this.retailselect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbfid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btselect;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btcancel;
    }
}