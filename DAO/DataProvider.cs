﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider()
        {

        }
        
        private string connectionStr = "";
        public const string connectionString = "";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DBSQLServerUtils con = new DBSQLServerUtils();
            string connectionStr = con.conString().ToString();
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            DBSQLServerUtils con = new DBSQLServerUtils();
            string connectionStr = con.conString().ToString();
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ERROR", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            DBSQLServerUtils con = new DBSQLServerUtils();
            string connectionStr = con.conString().ToString();
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = cmd.ExecuteScalar();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("ERROR", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            return data;
        }
    }
}
