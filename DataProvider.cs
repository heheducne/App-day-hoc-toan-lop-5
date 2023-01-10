﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace doancuoiki
{
    public class DataProvider
    {
        private string connectionStr = @"Data Source=TUANC;Initial Catalog=LEARNING;Integrated Security=True";
        //private string connectionStr = @"Data Source=FASTSHJTDUCK;Initial Catalog=LEARNING;Integrated Security=True";
        public DataTable excuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public void excuteNonquery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}