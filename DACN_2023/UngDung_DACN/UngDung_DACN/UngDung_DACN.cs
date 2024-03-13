using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AnalysisServices.AdomdClient;

namespace UngDung_DACN
{
    internal class UngDung_DACN
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;

        public UngDung_DACN() { }

        /*--------------------------------------------------------------------*/
        /*|                             FORM_LOGIN                           |*/
        /*--------------------------------------------------------------------*/
        public bool checkUser_Pwd(string userName, string passWord)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=Tger\TGER;Initial Catalog=UngDung_DACN2023;Integrated Security=True"))
                {
                    connect.Open();

                    string checkString = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @username AND MatKhau = @password";
                    SqlCommand cmd = new SqlCommand(checkString, connect);
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@password", passWord);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                // Xử lý ngoại lệ, có thể ghi log hoặc thông báo lỗi
                return false;
            }
        }

        public string checkRoles(string userName)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=Tger\TGER;Initial Catalog=UngDung_DACN2023;Integrated Security=True"))
                {
                    connect.Open();

                    string checkString = "SELECT MaVaiTro FROM NguoiDung_VaiTro WHERE MaNguoiDung = (SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = @username)";
                    SqlCommand cmd = new SqlCommand(checkString, connect);
                    cmd.Parameters.AddWithValue("@username", userName);

                    string roles = cmd.ExecuteScalar()?.ToString(); // Handle NULL value

                    return roles;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                // Xử lý ngoại lệ, có thể ghi log hoặc thông báo lỗi
                return null;
            }
        }


        /*--------------------------------------------------------------------*/
        /*|                   KET NOI ANALYSIS SERVER                        |*/
        /*--------------------------------------------------------------------*/
        public void ConnectToAnalysisServer()
        {
            try
            {
                string connectionString = "Provider=MSOLAP;Data Source=Tger\\TGER;Catalog=SSAS;Integrated Security=SSPI;";

                using (AdomdConnection conn = new AdomdConnection(connectionString))
                {
                    conn.Open();

                    // Thực hiện các thao tác tại đây
                    // Ví dụ: thực hiện truy vấn MDX
                    string mdxQuery = "SELECT [Measures].[Sales Amount] ON COLUMNS, [Date].[Calendar].[Month].Members ON ROWS FROM [YourCubeName]";
                    using (AdomdCommand cmd = new AdomdCommand(mdxQuery, conn))
                    {
                        AdomdDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0].ToString());
                        }
                        reader.Close();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                // Xử lý ngoại lệ, ghi log hoặc thông báo lỗi
            }
        }


        /*--------------------------------------------------------------------*/
        /*|                             FORM_CHINH                           |*/
        /*--------------------------------------------------------------------*/
        


        /*--------------------------------------------------------------------*/
        /*|                             FORM_PHANTICH                        |*/
        /*--------------------------------------------------------------------*/



        /*--------------------------------------------------------------------*/
        /*|                             FORM_BAOCAO                           |*/
        /*--------------------------------------------------------------------*/



        /*--------------------------------------------------------------------*/
        /*|                             FORM_NAPDULIEU                       |*/
        /*--------------------------------------------------------------------*/
    }

}
