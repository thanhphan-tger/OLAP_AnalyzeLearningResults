using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace UngDung_DACN
{
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            Form_DangNhap formDangNhap = new Form_DangNhap();
            formDangNhap.ShowDialog();
        }

        private void btn_CNBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true; // Hiển thị ứng dụng Excel

                // Đường dẫn đến tệp Excel cần mở
                string excelFilePath = "F:\\DACN_2023\\DACN_2023\\tmpB857.xlsx";

                // Mở tệp Excel
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(excelFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_CNPhanTich_Click(object sender, EventArgs e)
        {
            try
            {
                string solutionPath = "F:\\DACN_2023\\DACN_2023\\SSAS_SV\\SSAS_SV.sln";
                Process.Start("C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe", solutionPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_CNNap_Click(object sender, EventArgs e)
        {
            try
            {
                string solutionPath = "F:\\DACN_2023\\DACN_2023\\SSIS\\SSIS.sln";
                Process.Start("C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe", solutionPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_CNThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true; // Hiển thị ứng dụng Excel

                // Đường dẫn đến tệp Excel cần mở
                string excelFilePath = "F:\\DACN_2023\\DACN_2023\\tmpB857.xlsx";

                // Mở tệp Excel
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(excelFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=Tger\TGER;Initial Catalog=UngDung_DACN2023;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "SELECT * FROM NguoiDung";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgv_DSNguoiDung.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
