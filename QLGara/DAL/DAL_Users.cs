using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Users
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            return GetAllInfor.GetData("USERS");
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "USERS";
            //return con.GetData(strSQL, pNames, pValues);
        }

        public bool insertUser(Entity_User us)
        {
            try
            {
                string strSQL = "SP_REGISTER";
                string[] pNames = { "@username", "@email", "@pass", "@role", "@gender", "@birthday", "@full_name", "@phone", "@direction" };
                object[] pValues = { us.Username, us.Email, us.Pass, us.Role, us.Gender, us.Birthday, us.FullName, us.Phone, us.Direction };
                int count = con.ExecuteStoredProcedure(strSQL, pNames, pValues);
                if (count >= 0)
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public DataTable login(string user, string pass)
        {
            try
            {
                const string strSQL = "SP_LOGIN";
                string[] pNames = { "@username", "@pass" };
                object[] pValues = { user, pass };

                return con.GetValue(strSQL, pNames, pValues);

            }
            catch
            {
                
                return null;
            }
        }

        public bool updateProfile(Entity_User _us)
        {
            try
            {
                const string strSQL = "SP_UPDATE_PROFILE";
                string[] pNames = { "@id", "@email", "@sdt", "@pass", "@direction" };
                object[] pValues = { _us.id, _us.Email, _us.Phone, _us.Pass, _us.Direction };
                int count = con.ExecuteStoredProcedure(strSQL, pNames, pValues);
                if (count >= 0)
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool delUser(string username)
        {
            try
            {
                const string strSQL = "SP_DEL_USER";
                string[] pNames = { "@username" };
                object[] pValues = { username };
                int count = con.ExecuteStoredProcedure(strSQL, pNames, pValues);
                if (count >= 0)
                    return true;
                else return false;

            }
            catch
            {

                return false;
            }
        }

        public DataTable searchUser(string content)
        {
            try
            {
                const string strSQL = "SP_SEARCH_USER";
                string[] pNames = { "@content" };
                object[] pValues = { content };

                return con.GetValue(strSQL, pNames, pValues);

            }
            catch
            {

                return null;
            }
        }
    }
}
