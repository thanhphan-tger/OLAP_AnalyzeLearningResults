﻿namespace UngDung_DACN
{
    partial class Form_DangNhap
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMatKhau = new System.Windows.Forms.Panel();
            this.lblResPassword = new System.Windows.Forms.Label();
            this.txtMatKhau_DN = new System.Windows.Forms.TextBox();
            this.lblMatKhau_DN = new System.Windows.Forms.Label();
            this.btnDangNhap_DN = new System.Windows.Forms.Button();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lbl_QuenMK = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.lblResUserName = new System.Windows.Forms.Label();
            this.txtTenDangNhap_DN = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap_DN = new System.Windows.Forms.Label();
            this.panelMatKhau.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::UngDung_DACN.Properties.Resources.Thư_viện_HUIT;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(598, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 456);
            this.panel3.TabIndex = 4;
            // 
            // panelMatKhau
            // 
            this.panelMatKhau.Controls.Add(this.lblResPassword);
            this.panelMatKhau.Controls.Add(this.txtMatKhau_DN);
            this.panelMatKhau.Controls.Add(this.lblMatKhau_DN);
            this.panelMatKhau.Location = new System.Drawing.Point(10, 292);
            this.panelMatKhau.Name = "panelMatKhau";
            this.panelMatKhau.Size = new System.Drawing.Size(533, 75);
            this.panelMatKhau.TabIndex = 1;
            // 
            // lblResPassword
            // 
            this.lblResPassword.AutoSize = true;
            this.lblResPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblResPassword.Location = new System.Drawing.Point(180, 53);
            this.lblResPassword.Name = "lblResPassword";
            this.lblResPassword.Size = new System.Drawing.Size(174, 16);
            this.lblResPassword.TabIndex = 3;
            this.lblResPassword.Text = "(Mật khẩu chứa ít nhất 4 kí tự)";
            // 
            // txtMatKhau_DN
            // 
            this.txtMatKhau_DN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau_DN.Location = new System.Drawing.Point(180, 22);
            this.txtMatKhau_DN.Multiline = true;
            this.txtMatKhau_DN.Name = "txtMatKhau_DN";
            this.txtMatKhau_DN.PasswordChar = '*';
            this.txtMatKhau_DN.Size = new System.Drawing.Size(350, 28);
            this.txtMatKhau_DN.TabIndex = 1;
            // 
            // lblMatKhau_DN
            // 
            this.lblMatKhau_DN.AutoSize = true;
            this.lblMatKhau_DN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau_DN.Location = new System.Drawing.Point(58, 26);
            this.lblMatKhau_DN.Name = "lblMatKhau_DN";
            this.lblMatKhau_DN.Size = new System.Drawing.Size(98, 23);
            this.lblMatKhau_DN.TabIndex = 0;
            this.lblMatKhau_DN.Text = "Mật khẩu:";
            // 
            // btnDangNhap_DN
            // 
            this.btnDangNhap_DN.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDangNhap_DN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap_DN.Location = new System.Drawing.Point(204, 383);
            this.btnDangNhap_DN.Name = "btnDangNhap_DN";
            this.btnDangNhap_DN.Size = new System.Drawing.Size(143, 52);
            this.btnDangNhap_DN.TabIndex = 3;
            this.btnDangNhap_DN.Text = "Đăng nhập";
            this.btnDangNhap_DN.UseVisualStyleBackColor = false;
            this.btnDangNhap_DN.Click += new System.EventHandler(this.btnDangNhap_DN_Click);
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblDangNhap.Location = new System.Drawing.Point(86, 137);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(392, 38);
            this.lblDangNhap.TabIndex = 5;
            this.lblDangNhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // lbl_QuenMK
            // 
            this.lbl_QuenMK.AutoSize = true;
            this.lbl_QuenMK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuenMK.ForeColor = System.Drawing.Color.Blue;
            this.lbl_QuenMK.Location = new System.Drawing.Point(23, 418);
            this.lbl_QuenMK.Name = "lbl_QuenMK";
            this.lbl_QuenMK.Size = new System.Drawing.Size(120, 17);
            this.lbl_QuenMK.TabIndex = 6;
            this.lbl_QuenMK.Text = "Quên mậtt khẩu ?";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::UngDung_DACN.Properties.Resources.sv_logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(124, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_QuenMK);
            this.panel1.Controls.Add(this.lblDangNhap);
            this.panel1.Controls.Add(this.btnDangNhap_DN);
            this.panel1.Controls.Add(this.panelMatKhau);
            this.panel1.Controls.Add(this.panelTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(40, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 456);
            this.panel1.TabIndex = 3;
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Controls.Add(this.lblResUserName);
            this.panelTaiKhoan.Controls.Add(this.txtTenDangNhap_DN);
            this.panelTaiKhoan.Controls.Add(this.lblTenDangNhap_DN);
            this.panelTaiKhoan.Location = new System.Drawing.Point(10, 193);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(533, 82);
            this.panelTaiKhoan.TabIndex = 0;
            // 
            // lblResUserName
            // 
            this.lblResUserName.AutoSize = true;
            this.lblResUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblResUserName.Location = new System.Drawing.Point(180, 56);
            this.lblResUserName.Name = "lblResUserName";
            this.lblResUserName.Size = new System.Drawing.Size(279, 16);
            this.lblResUserName.TabIndex = 2;
            this.lblResUserName.Text = "(Tên đăng nhập là mã số sinh viên/ nhân viên)";
            // 
            // txtTenDangNhap_DN
            // 
            this.txtTenDangNhap_DN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap_DN.Location = new System.Drawing.Point(180, 22);
            this.txtTenDangNhap_DN.Multiline = true;
            this.txtTenDangNhap_DN.Name = "txtTenDangNhap_DN";
            this.txtTenDangNhap_DN.Size = new System.Drawing.Size(350, 28);
            this.txtTenDangNhap_DN.TabIndex = 1;
            // 
            // lblTenDangNhap_DN
            // 
            this.lblTenDangNhap_DN.AutoSize = true;
            this.lblTenDangNhap_DN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap_DN.Location = new System.Drawing.Point(12, 25);
            this.lblTenDangNhap_DN.Name = "lblTenDangNhap_DN";
            this.lblTenDangNhap_DN.Size = new System.Drawing.Size(139, 23);
            this.lblTenDangNhap_DN.TabIndex = 0;
            this.lblTenDangNhap_DN.Text = "Tên đăng nhập:";
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UngDung_DACN.Properties.Resources.Nen_DN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 613);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DangNhap";
            this.Text = "Đăng Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelMatKhau.ResumeLayout(false);
            this.panelMatKhau.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTaiKhoan.ResumeLayout(false);
            this.panelTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMatKhau;
        private System.Windows.Forms.Label lblResPassword;
        private System.Windows.Forms.TextBox txtMatKhau_DN;
        private System.Windows.Forms.Label lblMatKhau_DN;
        private System.Windows.Forms.Button btnDangNhap_DN;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lbl_QuenMK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTaiKhoan;
        private System.Windows.Forms.Label lblResUserName;
        private System.Windows.Forms.TextBox txtTenDangNhap_DN;
        private System.Windows.Forms.Label lblTenDangNhap_DN;
    }
}

