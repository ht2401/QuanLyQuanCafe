
namespace QuanLyQuanCafe.DanhMuc
{
    partial class frmSetPassWord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPw1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPw2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSavepw = new System.Windows.Forms.Button();
            this.ckbHienpw = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPw1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu mới :";
            // 
            // txtPw1
            // 
            this.txtPw1.Location = new System.Drawing.Point(116, 8);
            this.txtPw1.Name = "txtPw1";
            this.txtPw1.Size = new System.Drawing.Size(232, 20);
            this.txtPw1.TabIndex = 1;
            this.txtPw1.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPw2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 37);
            this.panel2.TabIndex = 0;
            // 
            // txtPw2
            // 
            this.txtPw2.Location = new System.Drawing.Point(116, 8);
            this.txtPw2.Name = "txtPw2";
            this.txtPw2.Size = new System.Drawing.Size(232, 20);
            this.txtPw2.TabIndex = 1;
            this.txtPw2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập lại mật khẩu :\r\n";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckbHienpw);
            this.panel3.Controls.Add(this.btnSavepw);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 198);
            this.panel3.TabIndex = 1;
            // 
            // btnSavepw
            // 
            this.btnSavepw.Location = new System.Drawing.Point(292, 148);
            this.btnSavepw.Name = "btnSavepw";
            this.btnSavepw.Size = new System.Drawing.Size(69, 33);
            this.btnSavepw.TabIndex = 2;
            this.btnSavepw.Text = "Lưu";
            this.btnSavepw.UseVisualStyleBackColor = true;
            this.btnSavepw.Click += new System.EventHandler(this.btnSavepw_Click);
            // 
            // ckbHienpw
            // 
            this.ckbHienpw.AutoSize = true;
            this.ckbHienpw.Location = new System.Drawing.Point(129, 164);
            this.ckbHienpw.Name = "ckbHienpw";
            this.ckbHienpw.Size = new System.Drawing.Size(109, 17);
            this.ckbHienpw.TabIndex = 3;
            this.ckbHienpw.Text = "Hiển thị mật khẩu";
            this.ckbHienpw.UseVisualStyleBackColor = true;
            this.ckbHienpw.CheckedChanged += new System.EventHandler(this.ckbHienpw_CheckedChanged);
            // 
            // frmSetPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 231);
            this.Controls.Add(this.panel3);
            this.Name = "frmSetPassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết Lập Mật Khẩu";
            this.Load += new System.EventHandler(this.frmSetPassWord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPw1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPw2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSavepw;
        private System.Windows.Forms.CheckBox ckbHienpw;
    }
}