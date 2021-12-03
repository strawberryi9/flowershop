using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;


namespace FlowerShop
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btok = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpasswd = new System.Windows.Forms.TextBox();
            this.txtValidCode = new System.Windows.Forms.TextBox();
            this.picValidCode = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(100, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(100, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(99, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "验证码";
            // 
            // btok
            // 
            this.btok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(225)))), ((int)(((byte)(192)))));
            this.btok.Location = new System.Drawing.Point(85, 775);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(167, 59);
            this.btok.TabIndex = 3;
            this.btok.Text = "登录";
            this.btok.UseVisualStyleBackColor = false;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btclear
            // 
            this.btclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(225)))), ((int)(((byte)(192)))));
            this.btclear.Location = new System.Drawing.Point(428, 775);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(163, 59);
            this.btclear.TabIndex = 4;
            this.btclear.Text = "重置";
            this.btclear.UseVisualStyleBackColor = false;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbusername.Location = new System.Drawing.Point(299, 306);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(336, 44);
            this.tbusername.TabIndex = 6;
            // 
            // tbpasswd
            // 
            this.tbpasswd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbpasswd.Location = new System.Drawing.Point(299, 399);
            this.tbpasswd.Name = "tbpasswd";
            this.tbpasswd.PasswordChar = '*';
            this.tbpasswd.Size = new System.Drawing.Size(336, 44);
            this.tbpasswd.TabIndex = 7;
            // 
            // txtValidCode
            // 
            this.txtValidCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtValidCode.Location = new System.Drawing.Point(299, 614);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(336, 44);
            this.txtValidCode.TabIndex = 8;
            // 
            // picValidCode
            // 
            this.picValidCode.Location = new System.Drawing.Point(727, 608);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(193, 58);
            this.picValidCode.TabIndex = 9;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文行楷", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Location = new System.Drawing.Point(87, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(722, 117);
            this.label4.TabIndex = 10;
            this.label4.Text = "花店管理系统";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(225)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(743, 775);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(100, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "身  份";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "管理员",
            "店长",
            "普通员工1",
            "普通员工2",
            "普通员工3"});
            this.comboBox1.Location = new System.Drawing.Point(299, 502);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 41);
            this.comboBox1.TabIndex = 13;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 912);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picValidCode);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.tbpasswd);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "登录界面";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpasswd;
        private System.Windows.Forms.TextBox txtValidCode;
        private System.Windows.Forms.PictureBox picValidCode;
        private System.Windows.Forms.Label label4;
        private Button button1;
        private Label label5;
        private ComboBox comboBox1;
    }
}