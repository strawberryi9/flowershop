namespace FlowerShop
{
    partial class flowerlookup
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btok = new System.Windows.Forms.Button();
            this.cmbfname = new System.Windows.Forms.ComboBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.bt_out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "> >浏览花类";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1277, 710);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(897, 922);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "鲜花编号：";
            // 
            // tbfid
            // 
            this.tbfid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbfid.Location = new System.Drawing.Point(1078, 914);
            this.tbfid.Name = "tbfid";
            this.tbfid.ReadOnly = true;
            this.tbfid.Size = new System.Drawing.Size(292, 44);
            this.tbfid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(87, 919);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "鲜花名称：";
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(145, 1075);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(170, 81);
            this.btok.TabIndex = 6;
            this.btok.Text = "浏览";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // cmbfname
            // 
            this.cmbfname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbfname.FormattingEnabled = true;
            this.cmbfname.Location = new System.Drawing.Point(290, 914);
            this.cmbfname.Name = "cmbfname";
            this.cmbfname.Size = new System.Drawing.Size(303, 41);
            this.cmbfname.TabIndex = 9;
            this.cmbfname.Text = "--请选择花名--";
            this.cmbfname.SelectedIndexChanged += new System.EventHandler(this.cmbfname_SelectedIndexChanged);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(1122, 1075);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(170, 81);
            this.btdelete.TabIndex = 7;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // bt_out
            // 
            this.bt_out.Location = new System.Drawing.Point(602, 1075);
            this.bt_out.Name = "bt_out";
            this.bt_out.Size = new System.Drawing.Size(170, 81);
            this.bt_out.TabIndex = 10;
            this.bt_out.Text = "导出";
            this.bt_out.UseVisualStyleBackColor = true;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // flowerlookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._17;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bt_out);
            this.Controls.Add(this.cmbfname);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbfid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "flowerlookup";
            this.Size = new System.Drawing.Size(1491, 1435);
            this.Load += new System.EventHandler(this.flowerlookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.ComboBox cmbfname;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button bt_out;
    }
}
