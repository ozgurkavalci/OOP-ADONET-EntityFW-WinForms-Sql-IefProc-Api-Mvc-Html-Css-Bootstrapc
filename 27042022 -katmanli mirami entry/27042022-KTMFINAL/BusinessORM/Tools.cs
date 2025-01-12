﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BusinessORM
{
    public class Tools
    {

        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Services"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }

        }

        public static bool ExecuteNonQuery(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();
                return komut.ExecuteNonQuery() > 0;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Close();

            }

        }

    }
}
