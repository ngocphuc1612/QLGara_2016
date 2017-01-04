using System;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_Users
    {
        DAL_Users us = new DAL_Users();
        public DataTable GetData()
        {
            return us.GetData();
        }
        public bool insertUser(Entity_User _us)
        {
            return us.insertUser(_us);
        }

        public DataTable login(string user, string pass)
        {
            return us.login(user, pass);
        }

        public bool delUser(string user)
        {
            return us.delUser(user);
        }

        public DataTable searchUser(string content)
        {
            return us.searchUser(content);
        }
    }
}
