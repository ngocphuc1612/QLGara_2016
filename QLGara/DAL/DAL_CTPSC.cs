﻿using System;
using System.Data;

namespace DAL
{
    public class DAL_CTPSC
    {
        DataProvider con = new DataProvider();
        public DataTable GetData()
        {
            //const string strSQL = "SP_GETDATA";
            //const string pNames = "@tableName";
            //const string pValues = "CT_PHIEUSUACHUA";
            //return con.GetData(strSQL, pNames, pValues);
            return GetAllInfor.GetData("CT_PHIEUSUACHUA");
        }
    }
}
