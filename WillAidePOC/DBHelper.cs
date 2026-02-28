using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WillAidePOC.Models;

namespace WillAidePOC
{
    public class DBHelper
    {

        private readonly IConfiguration _configuration;

        public DBHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DataTable GetUserDetailsAndNominees()
        {
            //Need to write actual db call logic
            string Query = @"SELECT [First_Name],[Last_Name],[Date_Of_Birth],[Address_Line1],[Address_Line2],[State_Of_Residence],[Postal_Code],[City_Of_Residence],[Personal_Contact],[Office_Contact],[Personal_Email],[Office_Email] FROM [WillAide].[dbo].[tbl_User]";
            DataTable dt = new DataTable();
            string conn = _configuration.GetConnectionString("WillAideConnectionString");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(conn))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(Query, myConn))
                {
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();

                }
            }

            return dt;
        }
    }
}
