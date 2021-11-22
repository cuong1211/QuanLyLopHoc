using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_LOPHOC : DBconnect
    {
        // <summary>
        /// Get toàn bộ thành viên
        /// </summary>
        /// <returns></returns>
        public DataTable getLopHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOPHOC", _conn);
            DataTable dtLophoc = new DataTable();
            da.Fill(dtLophoc);
            return dtLophoc;
        }

        /// <summary>
        /// Thêm thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themLopHoc(DTO_LOPHOC lh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO LOPHOC(LH_NAME, GV_ID, MH_ID) VALUES ('{0}', '{1}', '{2}')", lh.LH_NAME, lh.GV_ID, lh.MH_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Sửa thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool suaLopHoc(DTO_LOPHOC lh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE LOPHOC SET LH_NAME = '{0}', GV_ID = '{1}', MH_ID = '{2}' WHERE LOPHOC_ID = {3}", lh.LH_NAME, lh.GV_ID, lh.MH_ID, lh.LH_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Xóa thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool xoaLopHoc(int LH_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM LOPHOC WHERE LH_ID = {0}", LH_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        public DataTable getGV()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select GV_ID,GV_NAME From GIANGVIEN ", _conn);
            da.Fill(dt);
            return (dt);

        }
        public DataTable getMH()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MH_ID,MH_NAME From MONHOC", _conn);
            da.Fill(dt);
            return (dt);

        }
    }
}
