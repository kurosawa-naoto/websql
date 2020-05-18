using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using websql.Models;

namespace websql.Controllers
{
    public class DaoClass
    {
        public int ExecuteQuery(List<Usertbl> utblList)
        {
            int result = 0;
            string server = "localhost";
            string db = "user";
            string user = "root";
            string pass = "kashiwa6";
            string connectionStr = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", server, db, user, pass);
            string tbl = "user.usertbl";
            MySqlDataReader dataReader;


            try
            {
                MySqlConnection mysqlConnect = new MySqlConnection(connectionStr);
                mysqlConnect.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("select * from " + tbl + ";", mysqlConnect);
                dataReader = mysqlCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Usertbl utbl = new Usertbl();
                    utbl.Id = int.Parse(dataReader.GetValue(0).ToString());
                    utbl.Name = dataReader.GetValue(1).ToString();
                    utbl.Gender = int.Parse(dataReader.GetValue(2).ToString());
                    utbl.Birth = dataReader.GetValue(3).ToString();
                    utbl.Pass = dataReader.GetValue(4).ToString();
                    utblList.Add(utbl);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("exception:" + e.Message);
                result = 1;

            }

            return result;
        }
    }
}
