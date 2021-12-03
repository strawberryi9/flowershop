namespace FlowerShop
{
    partial class inventoryupdate
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btupdate = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.tbfid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbsum = new System.Windows.Forms.TextBox();
            this.tbout = new System.Windows.Forms.TextBox();
            this.tbresidue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "鲜花编号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(112, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "库存名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(112, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "鲜花总数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(112, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "出库数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(112, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "剩余数量";
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(101, 633);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(149, 73);
            this.btupdate.TabIndex = 9;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(516, 633);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(149, 73);
            this.btcancel.TabIndex = 10;
            this.btcancel.Text = "退出";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // tbfid
            // 
            this.tbfid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbfid.Location = new System.Drawing.Point(339, 97);
            this.tbfid.Name = "tbfid";
            this.tbfid.Size = new System.Drawing.Size(339, 44);
            this.tbfid.TabIndex = 11;
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbname.Location = new System.Drawing.Point(339, 194);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(339, 44);
            this.tbname.TabIndex = 12;
            // 
            // tbsum
            // 
            this.tbsum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbsum.Location = new System.Drawing.Point(339, 291);
            this.tbsum.Name = "tbsum";
            this.tbsum.Size = new System.Drawing.Size(339, 44);
            this.tbsum.TabIndex = 13;
            // 
            // tbout
            // 
            this.tbout.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbout.Location = new System.Drawing.Point(339, 392);
            this.tbout.Name = "tbout";
            this.tbout.Size = new System.Drawing.Size(339, 44);
            this.tbout.TabIndex = 14;
            // 
            // tbresidue
            // 
            this.tbresidue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbresidue.Location = new System.Drawing.Point(339, 503);
            this.tbresidue.Name = "tbresidue";
            this.tbresidue.ReadOnly = true;
            this.tbresidue.Size = new System.Drawing.Size(339, 44);
            this.tbresidue.TabIndex = 15;
            // 
            // inventoryupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._24;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 820);
            this.Controls.Add(this.tbresidue);
            this.Controls.Add(this.tbout);
            this.Controls.Add(this.tbsum);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbfid);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "inventoryupdate";
            this.Text = "修改仓库信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.TextBox tbfid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbsum;
        private System.Windows.Forms.TextBox tbout;
        private System.Windows.Forms.TextBox tbresidue;
    }
}