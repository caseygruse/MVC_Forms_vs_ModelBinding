using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Forms_vs_ModelBinding.Models
{
	public class HouseDBHelper
	{
		public static string GetConnectionString()
		{
			return "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=MVC_Forms_vs_ModelBinding.HouseDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
		}

		public static SqlConnection GetConnection()
		{
			string con = GetConnectionString();
			SqlConnection dbCon = new SqlConnection(con);
			return dbCon;
		}
	}
}