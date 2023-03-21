using QLNS_TinhVanSoftWare.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_TinhVanSoftWare.DataAccessLayer
{
    class NghiPhepDAL
    {
        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source=DESKTOP-96D4EUK\\ADMIN;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
        // Hàm thêm đơn xin nghỉ
        public bool ThemDonXinNghi(DonXinNghi donXinNghi)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ThemDonXinNghi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_sMaDon", donXinNghi.PK_sMaDon);
                    cmd.Parameters.AddWithValue("@dNgaylap", donXinNghi.dNgayLap);
                    cmd.Parameters.AddWithValue("@sLoaidon", donXinNghi.sLoaiDon);
                    cmd.Parameters.AddWithValue("@dNgaybatdau", donXinNghi.dNgayBatDau);
                    cmd.Parameters.AddWithValue("@dNgayketthuc", donXinNghi.dNgayKetThuc);
                    cmd.Parameters.AddWithValue("@FK_sMaNV", donXinNghi.FK_sMaNV);
                    cmd.Parameters.AddWithValue("@FK_sMaCV", donXinNghi.FK_sMaCV);
                    cmd.Parameters.AddWithValue("@FK_sMaPB", donXinNghi.FK_sMaPB);
                    cmd.Parameters.AddWithValue("@sLydo", donXinNghi.sLyDo);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        // Hàm sửa đơn xin nghỉ
        public bool SuaDonXinNghi(DonXinNghi donXinNghi)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_SuaDonXinNghi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_sMaDon", donXinNghi.PK_sMaDon);
                    cmd.Parameters.AddWithValue("@dNgaylap", donXinNghi.dNgayLap);
                    cmd.Parameters.AddWithValue("@sLoaidon", donXinNghi.sLoaiDon);
                    cmd.Parameters.AddWithValue("@dNgaybatdau", donXinNghi.dNgayBatDau);
                    cmd.Parameters.AddWithValue("@dNgayketthuc", donXinNghi.dNgayKetThuc);
                    cmd.Parameters.AddWithValue("@FK_sMaNV", donXinNghi.FK_sMaNV);
                    cmd.Parameters.AddWithValue("@FK_sMaCV", donXinNghi.FK_sMaCV);
                    cmd.Parameters.AddWithValue("@FK_sMaPB", donXinNghi.FK_sMaPB);
                    cmd.Parameters.AddWithValue("@sLydo", donXinNghi.sLyDo);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        // Hàm xóa đơn xin nghỉ
        public bool XoaDonXinNghi(string PK_sMaDon)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_XoaDonXinNghi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_sMaDon", PK_sMaDon);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        // Hàm lấy danh sách đơn xin nghỉ
        public List<DonXinNghi> LayDanhSachDonXinNghi()
        {
            List<DonXinNghi> danhSachDonXinNghi = new List<DonXinNghi>();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_LayDanhSachDonXinNghi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DonXinNghi donXinNghi = new DonXinNghi
                            {
                                PK_sMaDon = reader["PK_sMaDon"].ToString(),
                                dNgayLap = Convert.ToDateTime(reader["dNgaylap"]),
                                sLoaiDon = reader["sLoaidon"].ToString(),
                                dNgayBatDau = Convert.ToDateTime(reader["dNgaybatdau"]),
                                dNgayKetThuc = Convert.ToDateTime(reader["dNgayketthuc"]),
                                FK_sMaNV = reader["FK_sMaNV"].ToString(),
                                FK_sMaCV = reader["FK_sMaCV"].ToString(),
                                FK_sMaPB = reader["FK_sMaPB"].ToString(),
                                sLyDo = reader["sLydo"].ToString()
                            };
                            danhSachDonXinNghi.Add(donXinNghi);
                        }
                    }
                }
            }
            return danhSachDonXinNghi;
        }
        public List<DonXinNghi> TimKiemDonXinNghi(string loaiDon, string maNV, string maCV, string maPB, string lyDo)
        {
            List<DonXinNghi> danhSachDonXinNghi = new List<DonXinNghi>();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("sp_TimKiemDonXinNghi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@LoaiDon", "%" + loaiDon + "%");
                    cmd.Parameters.AddWithValue("@MaNV", "%" + maNV + "%");
                    cmd.Parameters.AddWithValue("@MaCV", "%" + maCV + "%");
                    cmd.Parameters.AddWithValue("@MaPB", "%" + maPB + "%");
                    cmd.Parameters.AddWithValue("@LyDo", "%" + lyDo + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DonXinNghi donXinNghi = new DonXinNghi
                            {

                                dNgayLap = Convert.ToDateTime(reader["dNgayLap"]),
                                sLoaiDon = reader["sLoaiDon"].ToString(),
                                dNgayBatDau = Convert.ToDateTime(reader["dNgayBatDau"]),
                                dNgayKetThuc = Convert.ToDateTime(reader["dNgayKetThuc"]),
                                FK_sMaNV = reader["FK_sMaNV"].ToString(),
                                FK_sMaCV = reader["FK_sMaCV"].ToString(),
                                FK_sMaPB = reader["FK_sMaPB"].ToString(),
                                sLyDo = reader["sLyDo"].ToString()
                            };

                            danhSachDonXinNghi.Add(donXinNghi);
                        }
                    }
                }
            }

            return danhSachDonXinNghi;
        }

    }
}