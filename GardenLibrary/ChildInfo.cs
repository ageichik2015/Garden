using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GardenLibrary
{
    public class ChildInfo
    {
        private int _childID = 0;
        private DateTime _childDateBirth = DateTime.Today;
        private string _childName = "";
        private string _childSecondName = "";
        private int _groupID = 0;
        private int _groupNamber = 0;
        private int _childAge = 0;


        public int ChildID
        {
            get
            {
                return _childID;
            }
            set
            {
                _childID = value;
            }
        }

        public DateTime ChildDateBirth
        {
            get
            {
                return _childDateBirth;
            }
            set
            {
                _childDateBirth = value;
            }
        }

        public int ChildAge
        {
            get
            {
                return _childAge;
            }
            set
            {
                _childAge = value;
            }
           
        }

        public string ChildName
        {
            get
            {
                return _childName;
            }
            set
            {
                _childName = value;
            }
        }

        public string ChildSecondName
        {
            get
            {
                return _childSecondName;
            }
            set
            {
                _childSecondName = value;
            }
        }

        public int GroupID
        {
            get
            {
                return _groupID;
            }
            set
            {
                _groupID = value;
            }
        }

        public int GroupNamber
        {
            get
            {
                return _groupNamber;
            }
            set
            {
                _groupNamber = value;
            }
        }

        public void InsertNewChild ()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-GBM29CQT\\SQLEXPRESS01;Initial Catalog=Kindergarden;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertChild";

            cm.Parameters.Add(new SqlParameter("@ChildName", _childName));
            cm.Parameters.Add(new SqlParameter("@ChildSecondName", _childSecondName));
            cm.Parameters.Add(new SqlParameter("@ChildDateBirth", _childDateBirth));
            cm.Parameters.Add(new SqlParameter("@ChildAge", _childAge));
            cm.Parameters.Add(new SqlParameter("@GroupID", _groupID));

            cm.ExecuteNonQuery();
        }

        public void DeleteChild()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-GBM29CQT\\SQLEXPRESS01;Initial Catalog=Kindergarden;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteChild";

            cm.Parameters.Add(new SqlParameter("@ChildID", _childID));

            cm.ExecuteNonQuery();
        }

        public void UpdateChild()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-GBM29CQT\\SQLEXPRESS01;Initial Catalog=Kindergarden;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateChild";

            cm.Parameters.Add(new SqlParameter("@ChildID", _childID));
            cm.Parameters.Add(new SqlParameter("@ChildName", _childName));
            cm.Parameters.Add(new SqlParameter("@ChildSecondName", _childSecondName));
            cm.Parameters.Add(new SqlParameter("@ChildDateBirth", _childDateBirth));
            cm.Parameters.Add(new SqlParameter("@ChildAge", _childAge));
            cm.Parameters.Add(new SqlParameter("@GroupID", _groupID));

            cm.ExecuteNonQuery();
        }

        public void GetChild(int childID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-GBM29CQT\\SQLEXPRESS01;Initial Catalog=Kindergarden;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetChild";

            cm.Parameters.Add(new SqlParameter("@ChildID", childID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _childID = (int)dr["ChildID"];
                _childName = dr["ChildName"].ToString();
                _childSecondName = dr["ChildSecondName"].ToString();
                _childDateBirth = (DateTime)dr["ChildDateBirth"];
                _childAge = (int)dr["ChildAge"];
                _groupID = (int)dr["GroupID"];
            }
        }
    }

}