namespace FlowerShop
{
    partial class inventoryselect
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbfid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btselect = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbiid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1207, 660);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "> >查询库存信息";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbiid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbfid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(144, 821);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1207, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "花编号";
            // 
            // cmbfid
            // 
            this.cmbfid.FormattingEnabled = true;
            this.cmbfid.Location = new System.Drawing.Point(177, 82);
            this.cmbfid.Name = "cmbfid";
            this.cmbfid.Size = new System.Drawing.Size(331, 41);
            this.cmbfid.TabIndex = 1;
            this.cmbfid.Text = "--请选择编号--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "仓库编号";
            // 
            // btselect
            // 
            this.btselect.Location = new System.Drawing.Point(144, 1078);
            this.btselect.Name = "btselect";
            this.btselect.Size = new System.Drawing.Size(164, 69);
            this.btselect.TabIndex = 3;
            this.btselect.Text = "查找";
            this.btselect.UseVisualStyleBackColor = true;
            this.btselect.Click += new System.EventHandler(this.btselect_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(634, 1078);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(164, 69);
            this.btreset.TabIndex = 4;
            this.btreset.Text = "重置";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1141, 1078);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 69);
            this.button3.TabIndex = 5;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbiid
            // 
            this.cmbiid.FormattingEnabled = true;
            this.cmbiid.Location = new System.Drawing.Point(794, 82);
            this.cmbiid.Name = "cmbiid";
            this.cmbiid.Size = new System.Drawing.Size(355, 41);
            this.cmbiid.TabIndex = 3;
            this.cmbiid.Text = "--请选择编号--";
            // 
            // inventoryselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 1195);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btselect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryselect";
            this.Text = "查询库存信息";
            this.Load += new System.EventHandler(this.inventoryselect_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbfid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btselect;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbiid;
    }
}