using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GardenLibrary
{
    public class ChildList : List<ChildInfo>
    {
       public static ChildList GetDefaultChildList()
        {
            ChildList myList = new ChildList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-GBM29CQT\\SQLEXPRESS01;Initial Catalog=Kindergarden;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetChildList";

            SqlDataReader dr = cm.ExecuteReader();

            while(dr.Read())
            {
                ChildInfo newChild = new ChildInfo();
                newChild.ChildID = (int)dr["ChildID"];
                newChild.ChildName = dr["ChildName"].ToString();
                newChild.ChildSecondName = dr["ChildSecondName"].ToString();
                newChild.ChildDateBirth = (DateTime)dr["ChildDateBirth"];
                newChild.ChildAge = (int)dr["ChildAge"];
                newChild.GroupID = (int)dr["GroupID"];

                myList.Add(newChild);
            }

            return myList;
        }
    }
}
