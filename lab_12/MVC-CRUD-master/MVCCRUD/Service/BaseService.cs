using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVCCRUD.Service
{
	public class BaseService
	{
		#region Property declaration
		/// <summary>
		/// Gets the connection string from the web config
		/// </summary>
		private string _connectionString = ConfigurationManager.ConnectionStrings["EmpConnection"].ConnectionString.ToString();

		/// <summary>
		/// Instance creation
		/// </summary>
		public String ConnectionString
		{
			get
			{
				if (_connectionString == null)
				{
					_connectionString = ConfigurationManager.ConnectionStrings["EmpConnection"].ConnectionString.ToString();
					return _connectionString;
				}
				else
				{
					return _connectionString;
				}
			}
		}

		#endregion

		#region DB operations
		/// <summary>
		/// Returns a friendly string. If obj is DBNull or null, it returns an empty string.
		/// </summary>
		/// <param name="obj">String, DBNull or null.</param>
		/// <returns></returns>
		public static string GetDBString(object obj)
		{
			if (!(obj is DBNull) && obj != null)
			{
				return Convert.ToString(obj);
			}
			else
			{
				return string.Empty;
			}
		}

		/// <summary>
		/// Returns a friendly integer. If obj is DBNull or null, it returns 0.
		/// </summary>
		/// <param name="obj">Can be a string, DBNull or null.</param>
		/// <returns>0 if param was DBNull or null.</returns>
		public static int GetDBInt(object obj)
		{
			if (!(obj is DBNull) && obj != null)
			{
				return Convert.ToInt32(obj);
			}
			else
			{
				return 0;
			}
		}

		#endregion
	}
}