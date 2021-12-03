namespace FlowerShop
{
    partial class lookprovide
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
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btlookup = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.cmbfid = new System.Windows.Forms.ComboBox();
            this.cbmsname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinfo
            // 
            this.dgvinfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Location = new System.Drawing.Point(76, 94);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.RowHeadersWidth = 50;
            this.dgvinfo.RowTemplate.Height = 37;
            this.dgvinfo.Size = new System.Drawing.Size(1241, 736);
            this.dgvinfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 911);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "鲜花编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(749, 911);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "供货商";
            // 
            // btlookup
            // 
            this.btlookup.Location = new System.Drawing.Point(146, 1034);
            this.btlookup.Name = "btlookup";
            this.btlookup.Size = new System.Drawing.Size(142, 71);
            this.btlookup.TabIndex = 3;
            this.btlookup.Text = "浏览";
            this.btlookup.UseVisualStyleBackColor = true;
            this.btlookup.Click += new System.EventHandler(this.btlookup_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(625, 1034);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(142, 71);
            this.btdelete.TabIndex = 4;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(1087, 1034);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(142, 71);
            this.btcancel.TabIndex = 5;
            this.btcancel.Text = "退出";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // cmbfid
            // 
            this.cmbfid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbfid.FormattingEnabled = true;
            this.cmbfid.Location = new System.Drawing.Point(287, 911);
            this.cmbfid.Name = "cmbfid";
            this.cmbfid.Size = new System.Drawing.Size(335, 41);
            this.cmbfid.TabIndex = 6;
            this.cmbfid.Text = "--请选择编号--";
            this.cmbfid.SelectedIndexChanged += new System.EventHandler(this.cmbfid_SelectedIndexChanged);
            // 
            // cbmsname
            // 
            this.cbmsname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbmsname.FormattingEnabled = true;
            this.cbmsname.Location = new System.Drawing.Point(965, 903);
            this.cbmsname.Name = "cbmsname";
            this.cbmsname.Size = new System.Drawing.Size(352, 41);
            this.cbmsname.TabIndex = 7;
            this.cbmsname.Text = "--请选择供应商--";
            this.cbmsname.SelectedIndexChanged += new System.EventHandler(this.cbmsname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "> >浏览供应";
            // 
            // lookprovide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._16;
            this.ClientSize = new System.Drawing.Size(1427, 1193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbmsname);
            this.Controls.Add(this.cmbfid);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btlookup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lookprovide";
            this.Text = "providelook";
            this.Load += new System.EventHandler(this.lookprovide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btlookup;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.ComboBox cmbfid;
        private System.Windows.Forms.ComboBox cbmsname;
        private System.Windows.Forms.Label label3;
    }
}