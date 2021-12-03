namespace FlowerShop
{
    partial class backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库备份";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文行楷", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(241, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "备份路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文行楷", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(251, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "备份名称";
            // 
            // txtpath
            // 
            this.txtpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtpath.Location = new System.Drawing.Point(447, 289);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(350, 44);
            this.txtpath.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtname.Location = new System.Drawing.Point(447, 442);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(350, 44);
            this.txtname.TabIndex = 5;
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(135, 838);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(186, 74);
            this.btok.TabIndex = 6;
            this.btok.Text = "备份";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(591, 838);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(186, 74);
            this.btreset.TabIndex = 7;
            this.btreset.Text = "清空";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1026, 838);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 74);
            this.button3.TabIndex = 8;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "选择路径...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 1110);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "backup";
            this.Text = "backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}