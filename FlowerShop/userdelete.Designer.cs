namespace FlowerShop
{
    partial class userdelete
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
            this.comname = new System.Windows.Forms.ComboBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "> >删除用户";
            // 
            // comname
            // 
            this.comname.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comname.FormattingEnabled = true;
            this.comname.ItemHeight = 37;
            this.comname.Location = new System.Drawing.Point(348, 360);
            this.comname.Name = "comname";
            this.comname.Size = new System.Drawing.Size(459, 45);
            this.comname.TabIndex = 2;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(194, 664);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(170, 81);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(112, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "请选择你要删除的用户：";
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(761, 664);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(170, 81);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "返回";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // userdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlowerShop.Properties.Resources._241;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 757);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.comname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userdelete";
            this.Text = "userdelete";
            this.Load += new System.EventHandler(this.userdelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comname;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btcancel;
    }
}