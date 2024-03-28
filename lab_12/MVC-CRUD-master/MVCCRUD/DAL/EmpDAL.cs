using MVCCRUD.Models;
using MVCCRUD.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCCRUD.DAL
{
	public class EmpDAL : BaseService
	{
		#region CRUD
		/// <summary>
		/// Creates a new record for Employee
		/// </summary>
		/// <param name="empModel">EmpModel object as params</param>
		/// <returns>Returns id of the employee</returns>
		public int Create(EmpModel empModel)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);

			SqlCommand command = new SqlCommand();
			command.Connection = sqlConnection;
			string sqlQuery = String.Format("Insert into Employee (name,age) Values('{0}', '{1}');" + "Select @@Identity", empModel.Name, empModel.Age);
			command.CommandText = sqlQuery;
			sqlConnection.Open();
			int num = Convert.ToInt32(command.ExecuteScalar());
			sqlConnection.Close();
			return num;
		}

		/// <summary>
		/// Gets all employee details as list of employees
		/// </summary>
		/// <returns>Returns List of EmpModel</returns>
		public List<EmpModel> Read()
		{
			List<EmpModel> empList = new List<EmpModel>();
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);

			SqlCommand command = new SqlCommand();
			command.Connection = sqlConnection;
			string sqlQuery = String.Format("select id,name,age from Employee;");
			command.CommandText = sqlQuery;
			sqlConnection.Open();

			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			sqlDataAdapter.Fill(dt);

			foreach (DataRow dr in dt.Rows)
			{
				empList.Add(new EmpModel
				{
					Id = GetDBInt(dr["id"]),
					Age = GetDBInt(dr["age"]),
					Name =GetDBString(dr["name"].ToString())
				});
			}

			return empList;
		}

		/// <summary>
		/// Updates the Employee for the given id
		/// </summary>
		/// <param name="empModel">Employee model object</param>
		/// <returns>Returns int if successfully updated</returns>
		public int Update(EmpModel empModel)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);

			SqlCommand command = new SqlCommand();
			command.CommandText = string.Format("update Employee set name='{0}', age={1} where id={2};", empModel.Name, empModel.Age, empModel.Id);
			command.Connection = sqlConnection;

			sqlConnection.Open();
			int update = Convert.ToInt32(command.ExecuteScalar());
			sqlConnection.Close();
			return update;
		}

		/// <summary>
		/// Deletes the employee for the given id
		/// </summary>
		/// <param name="empModel">EmpModel object</param>
		/// <returns></returns>
		public int Delete(EmpModel empModel)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);

			SqlCommand command = new SqlCommand();
			command.CommandText = string.Format("delete from Employee where id={0};", empModel.Id);
			command.Connection = sqlConnection;

			sqlConnection.Open();
			int update = Convert.ToInt32(command.ExecuteScalar());
			sqlConnection.Close();
			return update;
		}
		#endregion

		#region Get Employee details
		/// <summary>
		/// Gets employee details for the given id
		/// </summary>
		/// <param name="empModel">Employee Model</param>
		/// <returns>Returns Employee details</returns>
		public EmpModel GetEmployee(EmpModel empModel)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			SqlCommand command = new SqlCommand();
			command.Connection = sqlConnection;
			command.CommandText = "select id,name,age from Employee where id=@id;";
			command.Parameters.AddWithValue("@id", empModel.Id);
			sqlConnection.Open();

			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				empModel.Name = GetDBString(reader["name"]);
				empModel.Age = GetDBInt(reader["age"]);
			}

			return empModel;
		}
		#endregion

	}
}
