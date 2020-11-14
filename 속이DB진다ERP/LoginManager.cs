using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace 속이DB진다ERP
{
    class LoginManager
    {
        public string id { get; set; }
        public string userID { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string getID { get; set; }
        public string getPW { get; set; }

        private static LoginManager instance = new LoginManager();
        public static LoginManager GetInstance()
        {
            return instance;
        }
        private LoginManager()
        {

        }

        public void Login()
        {
            MySqlDataReader rdr = DBManager.GetInstance().Load_data_rdr("SELECT idLogin,ID,Password FROM Login WHERE ID ='"+id+" and Password='"+password+"'");
            while (rdr.Read())
            {
                id = rdr["idLogin"].ToString();
                getID = rdr["ID"].ToString();
                getPW = rdr["Password"].ToString();
            }
            rdr.Close();
        }
    }
}
