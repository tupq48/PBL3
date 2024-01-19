using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ThuCung : DbConnectionData
    {
        /*  private static DAL_ThuCung instance;

          public static DAL_ThuCung Instance
          {
              get { if (instance == null) instance = new DAL_ThuCung(); return DAL_ThuCung.instance; }
              private set { DAL_ThuCung.instance = value; }
          }
          private DAL_ThuCung() { }

          */

        public DataTable LayNhaCungCap()
        {
            //List<NhaCungCap> ncc = new List<NhaCungCap>();
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from NHACUNGCAP", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable LayLoaiThuCung()
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from LOAITHUCUNG", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getDataThuCung()
        {

            SqlCommand sqlCommand = new SqlCommand("sp_GetDataThuCung", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool themThuCung(ThuCung tc)
        {
            try
            {
                conn.Open();
                  /*   SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                     string sql = @"insert into THUCUNG(IdThuCung,IdLoai,TenGiong,SoLuongConLai,GiaBan,MoTa,IdNhaCungCap)
                               values(tc.IdThuCung,tc.IdLoai,tc.TenGiong,tc.SoLuongConLai,tc.GiaBan,tc.MoTa,tc.IdNhaCungCap)";
                     sqlCommand.CommandText = sql;
                     sqlCommand.Connection = conn;
                  */
                string SQL = string.Format("insert into THUCUNG(IdThuCung,IdLoai,TenGiong,SoLuongConLai,GiaBan,Mota,IdNhaCungCap) VALUES (@IdThuCung,@IdLoai,@TenGiong,@SoLuongConLai,@GiaBan,@Mota,@IdNhaCungCap)");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdThuCung", SqlDbType.Char).Value = tc.IdThuCung;
                cmd.Parameters.Add("@IdLoai", SqlDbType.Char).Value = tc.IdLoai;
                cmd.Parameters.Add("@TenGiong", SqlDbType.NVarChar).Value = tc.TenGiong;
                cmd.Parameters.Add("@SoLuongConLai", SqlDbType.Int).Value = tc.SoLuongConLai;
                cmd.Parameters.Add("@GiaBan", SqlDbType.Int).Value = tc.GiaBan;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = tc.MoTa;
                cmd.Parameters.Add("@IdNhaCungCap", SqlDbType.NVarChar).Value = tc.IdNhaCungCap;
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;

        }
        public bool suaThuCung(ThuCung tc)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE THUCUNG SET IdThuCung = @IdThuCung, IdLoai = @IdLoai, TenGiong = @TenGiong, SoLuongConLai = @SoLuongConLai ,GiaBan = @GiaBan,Mota=@Mota, IdNhaCungCap= @IdNhaCungCap where IdThuCung = @IdThuCung");
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdThuCung", SqlDbType.Char).Value = tc.IdThuCung;
                cmd.Parameters.Add("@IdLoai", SqlDbType.Char).Value = tc.IdLoai;
                cmd.Parameters.Add("@TenGiong", SqlDbType.NVarChar).Value = tc.TenGiong;
                cmd.Parameters.Add("@SoLuongConLai", SqlDbType.Int).Value = tc.SoLuongConLai;
                cmd.Parameters.Add("@GiaBan", SqlDbType.Int).Value = tc.GiaBan;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = tc.MoTa;
                cmd.Parameters.Add("@IdNhaCungCap", SqlDbType.NVarChar).Value = tc.IdNhaCungCap;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool xoaThuCung(String IDtc)
        {
            try
            {
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM THUCUNG WHERE IdThuCung = @IdThuCung");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdThuCung", SqlDbType.Char).Value = IDtc;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable timkiemThuCung(String ten)
        {
            conn.Open();
            string sql = "Select * from THUCUNG where TenGiong LIKE N'%" + ten + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn); 
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }


        //tu code - update số lượng thú cưng sau khi tạo hóa đơn

        public static int GetSoLuongThuCungConLai(string idThuCung)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL = string.Format("SELECT * FROM THUCUNG");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row["IdThuCung"].ToString() == idThuCung)
                    return int.Parse(row["SoLuongConLai"].ToString());
            }
            conn.Close();
            return 0;
        }
        public static void UpdateSoLuongThuCung(string idThuCung, int soLuongDaBan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            conn.Open();
            try
            {
                string SQL = string.Format(
                "UPDATE THUCUNG SET SoLuongConLai = @SoLuongConLai "
                + "where IdThuCung = @IdThuCung");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdThuCung", SqlDbType.Char).Value = idThuCung;
                cmd.Parameters.Add("@SoLuongConLai", SqlDbType.Int).Value = DAL_ThuCung.GetSoLuongThuCungConLai(idThuCung) - soLuongDaBan;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public static string GetTenThuCung(string idThuCung)
        {
            string name = "";
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL = string.Format("SELECT * FROM ThuCung");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row["IdThuCung"].ToString() == idThuCung)
                    return row["TenGiong"].ToString();
            }
            conn.Close();


            return name;
        }
        public string AutoIdThuCung()
        {
            string id;
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AutoIdThuCung", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                object obj = cmd.ExecuteScalar();
                id = obj.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("lỗi ở autoidtiakhoan trong dalthucung");
                throw;
            }

            return id;
        }
    }
}

