using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GardenLibrary
{
    public class GroupList : List<GroupInfo>
    {
        public static GroupList GetDefaultGroupList()
        {
            GroupList myList = new GroupList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-GBM29CQT\\SQLEXPRESS01;Initial Catalog=Kindergarden;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetGroupList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                GroupInfo newGroup = new GroupInfo();
                newGroup.GroupID = (int)dr["GroupID"];
                newGroup.GroupNamber = (int)dr["GroupNamber"];

                myList.Add(newGroup);
            }

            return myList;
        }
    }
}