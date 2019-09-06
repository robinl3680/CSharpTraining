using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using static CompleteApllication.DataAcceessLayer.DataAccessDao;
using ApplicationUtilities;
namespace CompleteApllication.DataAcceessLayer
{
    public class DataAccess
    {
        string connectionString;
        SqlConnection connection;
        SqlCommand command;
        string procedureName;

        public DataAccess()
        {
            string connectionString = null;
            
            SqlCommand command = null;
            string procedureName = null;
            try
            {
                connectionString = GetConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = CreateConnection(connectionString);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public List<Employee> GetAllEmployees(int deptid)
        {
            SqlDataReader reader = null;
            List<Employee> employees = null;
            if(connection != null)
            {
                procedureName = GetProcedureName("GETALL_SELECT_QUERY");
                command = CreateCommand(connection, procedureName);

                if(command != null)
                {
                    SqlParameter pmDeptId = CreateParameter("@deptid", deptid, SqlDbType.Int);
                    command.Parameters.Add(pmDeptId);
                    OpenConnection(connection);
                    reader = command.ExecuteReader();
                    if (reader != null && reader.HasRows)
                    {
                        employees = new List<Employee>();
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                Name = reader["employeename"].ToString(),
                                Id = (int)reader["employeeid"],
                                Salary = (decimal)reader["employeesalary"],
                                Location = (string)reader["employeelocation"]
                            };
                            employees.Add(employee);
                        }
                        reader.Close();
                    }
                    CloseConnection(connection);
                }
                
            }
            return employees;
        
        }
        public List<string> GetAllDepartmentName()
        {
            List<string> departmentName = null;
            SqlDataReader reader = null;
            if(connection != null)
            {
                procedureName = GetProcedureName("GETALL_DEPARTMENT_NAME");
                command = CreateCommand(connection, procedureName);
                if(command != null)
                {
                    OpenConnection(connection);
                    reader = command.ExecuteReader();
                    if (reader != null && reader.HasRows)
                    {
                        departmentName = new List<string>();
                        while (reader.Read())
                        {
                            departmentName.Add(reader["departmentname"].ToString());
                        }
                        reader.Close();
                    }
                }
                CloseConnection(connection);
            }
            return departmentName;
        }

        public int GetDepartmentId(string departmentname)
        {
            SqlDataReader reader = null;
            int result = -1;
            if(connection != null)
            {
                string query = $"select departmentid from department where departmentname='{departmentname}'";
                command = CreateCommand(connection, query, CommandType.Text);
                if(command != null)
                {
                    OpenConnection(connection);
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return result;
        }
        public bool DeleteEmployee(int id)
        {
            bool deleted = false;
            string query = $"Delete from employee where employeeid={id}";
            if(connection != null)
            {
                OpenConnection(connection);
                command = CreateCommand(connection, query, CommandType.Text);
                if(command != null)
                {
                    int recordsUpdated = command.ExecuteNonQuery();
                    if (recordsUpdated > 0)
                        deleted = true;
                }
            }
            return deleted;
        }
        
        
    }
}
