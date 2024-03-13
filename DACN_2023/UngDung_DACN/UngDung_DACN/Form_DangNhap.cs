using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UngDung_DACN
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();

            txtTenDangNhap_DN.TextChanged += txt_TextChanged;
            txtMatKhau_DN.TextChanged += txt_TextChanged;
        }

        UngDung_DACN qlDN = new UngDung_DACN();

        public static string UserName = "";
        public static string roles = "";

        private void txt_TextChanged(object sender, EventArgs e)
        {
            bool checkPassWord = false;
            if (txtMatKhau_DN.Text.Length >= 4)
                checkPassWord = true;

            if (checkPassWord)
            {
                btnDangNhap_DN.Enabled = true;
            }
            else
            {
                btnDangNhap_DN.Enabled = false;
            }
        }

        private void txtMatKhau_DN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnDangNhap_DN_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap_DN.Text, passWord = txtMatKhau_DN.Text;

            if (qlDN.checkUser_Pwd(userName, passWord) == true)
            {
                UserName = userName;
                roles = qlDN.checkRoles(userName);

                Form_TrangChu frm_TC = new Form_TrangChu();
                this.Hide();

                txtTenDangNhap_DN.Clear();
                txtMatKhau_DN.Clear();

                frm_TC.ShowDialog();
                this.Show();
                txtTenDangNhap_DN.Focus();
                this.Close();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
