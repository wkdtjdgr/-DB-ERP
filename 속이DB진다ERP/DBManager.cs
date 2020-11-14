using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace 속이DB진다ERP
{
    public class DBManager
    {
        private static DBManager instance_ = new DBManager();

        public static DBManager GetInstance()
        {
            return instance_;
        }

        //private connection_string = “…”;

        private DBManager()
        {
            // .. Some initialization for this singleton object
        }
        string strConn = "Server=49.50.174.201;Database=s0000000;Uid=s0000000;Pwd=s0000000;Charset=utf8";

        public void insert(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void update(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void delete(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public bool data_check(string query)
        {   // 데이터 유무 확인 쿼리 함수
            bool result;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                    return result = true;
                else result = false;
            }
            return result;
        }
        public DataTable Load_data(string query)
        {   // 데이터 불러오는 함수_datatable 형긱
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();  //필요한 데이터 불러오기
            DataTable dt = new DataTable();
            dt.Load(rdr);
            return dt;  //datatable 형식으로 반환
        }

        public MySqlDataReader Load_data_rdr(string query)
        {   // 데이터 불러오는 함수_rdr 형식
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();  //필요한 데이터 불러오기
            return rdr; //MySqlDataReader 형식으로 반환
        }
    }
}
