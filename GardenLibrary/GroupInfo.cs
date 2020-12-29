using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GardenLibrary
{
    public class GroupInfo
    {
        private int _groupID = 0;
        private int _groupNamber = 0;

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

    }
}