using DTO_QuanLY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_QuanLy.DAL_QuanLY;

namespace DAL_QuanLy
{
    public class DAL_ThanhVien : DBConect
    {
        /// <summary>
        /// get toàn bộ thành viên
        /// </summary>
        /// <returns></returns>
        public DataTable getThanhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "select * from ThanhVien", _conn);

            DataTable dtThanhVien = new DataTable();
            da.Fill(dtThanhVien);
            return dtThanhVien;
        }

        /// <summary>
        /// thêm thàn viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themThanhVien(DTO_ThanhVien tv)
        {
            try
            {
                _conn.Open();

                string sql = ($"insert into thanhvien(tv_name,tv_phone,tv_email) " +
                $"values ('{tv.THANHVIEN_NAME}','{tv.THANHVIEN_PHONE}','{tv.THANHVIEN_EMAIL}')");

                SqlCommand cmd = new SqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { _conn.Close(); }
            return false;
        }


        /// <summary>
        /// sửa thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool suaThanhVien(DTO_ThanhVien tv)
        {
            try
            {
                _conn.Open();

                string sql = ($"update thanhvien set tv_name = " +
                    $"'{tv.THANHVIEN_NAME}', tv_phone='{tv.THANHVIEN_PHONE}', tv_email = '{tv.THANHVIEN_EMAIL}' " +
                    $"where tv_id = {tv.THANHVIEN_ID}");

                SqlCommand cmd = new SqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { _conn.Close(); }
            return false;
        }


        public bool xoaThanhVien(int tv_id)
        {
            try
            {
                _conn.Open();

                string sql = ($"delete from thanhvien where tv_id = {tv_id}");

                SqlCommand cmd = new SqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { _conn.Close(); }
            return false;
        }
    }
}
