using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Forms_vs_ModelBinding.Models
{
	public class HouseDBs
	{
		public static bool AddHouse(House h)
		{
			//TODO: Add database code here...
			SqlConnection con = HouseDBHelper.GetConnection();

			string insert = "INSERT INTO Houses(City, SquareFeet, Floors, Garage, Yard, Color) " +
							"Values(@City, @SquareFeet, @Floors, @Garage, @Yard, @Color)";

			SqlCommand cmd = new SqlCommand(insert, con);

			
			cmd.Parameters.AddWithValue("@City", h.City);
			cmd.Parameters.AddWithValue("@SquareFeet", h.SquareFeet);
			cmd.Parameters.AddWithValue("@Floors", h.Floors);
			cmd.Parameters.AddWithValue("@Garage", h.Garage);
			cmd.Parameters.AddWithValue("@Yard", h.Yard);
			cmd.Parameters.AddWithValue("@Color", h.Color);

			try
			{
				con.Open();
				int rows = cmd.ExecuteNonQuery();
				if(rows >= 1)
				{
					return true;
				}
				else
				{
					//display the house was not added
					return false;
				}
			}

			catch (Exception ex)
			{
				// dipslay that the house was not added
				return false;
			}
			finally
			{
				con.Close();
			}
		}
	}
}