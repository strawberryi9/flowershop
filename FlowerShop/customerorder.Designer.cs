namespace FlowerShop
{
    partial class customerorder
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
            this.btfinish = new System.Windows.Forms.Button();
            this.btnofinish = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl_lookup = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsl_finish = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsl_nofinish = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tspupdate = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 781);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btfinish
            // 
            this.btfinish.Location = new System.Drawing.Point(147, 944);
            this.btfinish.Name = "btfinish";
            this.btfinish.Size = new System.Drawing.Size(170, 81);
            this.btfinish.TabIndex = 1;
            this.btfinish.Text = "已完成";
            this.btfinish.UseVisualStyleBackColor = true;
            this.btfinish.Click += new System.EventHandler(this.btfinish_Click);
            // 
            // btnofinish
            // 
            this.btnofinish.Location = new System.Drawing.Point(634, 944);
            this.btnofinish.Name = "btnofinish";
            this.btnofinish.Size = new System.Drawing.Size(170, 81);
            this.btnofinish.TabIndex = 2;
            this.btnofinish.Text = "未完成";
            this.btnofinish.UseVisualStyleBackColor = true;
            this.btnofinish.Click += new System.EventHandler(this.btnofinish_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(1091, 944);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(170, 81);
            this.btdelete.TabIndex = 3;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_lookup,
            this.toolStripSeparator1,
            this.tsl_finish,
            this.toolStripSeparator2,
            this.tsl_nofinish,
            this.toolStripSeparator3,
            this.tspupdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1407, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "浏览";
            // 
            // tsl_lookup
            // 
            this.tsl_lookup.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsl_lookup.Name = "tsl_lookup";
            this.tsl_lookup.Size = new System.Drawing.Size(71, 36);
            this.tsl_lookup.Text = "浏览";
            this.tsl_lookup.Click += new System.EventHandler(this.tsl_lookup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsl_finish
            // 
            this.tsl_finish.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsl_finish.Name = "tsl_finish";
            this.tsl_finish.Size = new System.Drawing.Size(155, 36);
            this.tsl_finish.Text = "显示已完成";
            this.tsl_finish.Click += new System.EventHandler(this.tsl_finish_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsl_nofinish
            // 
            this.tsl_nofinish.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsl_nofinish.Name = "tsl_nofinish";
            this.tsl_nofinish.Size = new System.Drawing.Size(155, 36);
            this.tsl_nofinish.Text = "显示未完成";
            this.tsl_nofinish.Click += new System.EventHandler(this.tsl_nofinish_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tspupdate
            // 
            this.tspupdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tspupdate.Name = "tspupdate";
            this.tspupdate.Size = new System.Drawing.Size(127, 36);
            this.tspupdate.Text = "修改任务";
            this.tspupdate.Click += new System.EventHandler(this.tspupdate_Click);
            // 
            // customerorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._161;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1407, 1128);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btnofinish);
            this.Controls.Add(this.btfinish);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerorder";
            this.Text = "customerorder";
            this.Load += new System.EventHandler(this.customerorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btfinish;
        private System.Windows.Forms.Button btnofinish;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_lookup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsl_finish;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsl_nofinish;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tspupdate;
    }
}