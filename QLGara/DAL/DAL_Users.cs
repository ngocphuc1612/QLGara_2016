﻿using System;
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

    }
}
