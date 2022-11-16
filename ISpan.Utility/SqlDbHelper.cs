using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Utility
{
	public class SqlDbHelper
	{
		private string connString;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="keyOfConnString">app.config裡的值，例如"default"</param>
		public SqlDbHelper(string keyOfConnString)
		{
			connString = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString].ConnectionString;
		}

		public void ExecuteNonQuery(string sql, SqlParameter[] parameters)
		{
			using (var conn = new SqlConnection(connString))
			{

				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();


				cmd.Parameters.AddRange(parameters);
				cmd.ExecuteNonQuery();

			}

		}

		public DataTable Select(string sql, SqlParameter[] parameters)
		{
			using (var conn = new SqlConnection(connString))
			{

				SqlCommand cmd = new SqlCommand(sql, conn);
				if (parameters != null)
				{
					cmd.Parameters.AddRange(parameters);
				}
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				DataSet dataset = new DataSet();
				adapter.Fill(dataset, "News");

				return dataset.Tables["News"];
			}
		}
	}
}
