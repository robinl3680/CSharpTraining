using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace CompleteApllication.DataAcceessLayer
{
    public static class DataAccessDao
    {
        public static string GetConnectionString()
        {
            string connectionString = null;
            try
            {
                /*
                var connectionSettings =  ConfigurationManager.ConnectionStrings;
                var singleConnectionSetting =  connectionSettings["siemensDbConStr"];
                connectionString = singleConnectionSetting.ConnectionString;
                */
                connectionString = ConfigurationManager.ConnectionStrings["siemensDbConStr"].ConnectionString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return connectionString;
        }

        public static SqlCommand CreateCommand(SqlConnection connection, string query, CommandType commandType = CommandType.StoredProcedure)
        {
            SqlCommand command = null;
            try
            {
                //command = new SqlCommand(query, connection);
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = commandType;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return command;
        }

        public static void OpenConnection(SqlConnection connection)
        {
            try
            {
                ConnectionState state = connection.State;
                if (state == ConnectionState.Closed)
                    connection.Open();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try
            {
                ConnectionState state = connection.State;
                if (state == ConnectionState.Open)
                    connection.Close();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SqlConnection CreateConnection(string connectionString)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return connection;
        }
        public static string GetProcedureName(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static SqlParameter CreateParameter(string parameterName, object parameterValue, SqlDbType parameterDbType, ParameterDirection parameterDirection = ParameterDirection.Input)
        {
            SqlParameter parameter = null;
            try
            {
                parameter = new SqlParameter();
                parameter.ParameterName = parameterName;
                parameter.Value = parameterValue;
                parameter.SqlDbType = parameterDbType;
                parameter.Direction = parameterDirection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return parameter;
        }

    }
}
