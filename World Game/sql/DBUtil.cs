using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace World_Game.sql
{
    class DBUtil
    {
        SqlConnection con;
        public DBUtil() {
            string str = ConfigurationManager.ConnectionStrings["dbstr"].ToString();
            con = new SqlConnection(str);
        }

        //根据email查询密码并返回
        public string queryByName(string email) {
            con.Open();
            string sql = "select * from Users where Email='"+email+"'";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            string pass = "";
            while (reader.Read())
            {
                pass = reader["Password"].ToString();
            }
            reader.Close();
            con.Close();
            return pass;
        }


        public List<string> queryAllCity() {
            List<string> citylist = new List<string>();
            con.Open();
            string sql = "select CityName from City";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                citylist.Add(reader.GetString(0));
            }
            reader.Close();
            con.Close();
            return citylist;
        }
    }
}
