namespace MVC_Forms_vs_ModelBinding
{
	using System;
	using System.Data.Entity;
	using System.Linq;
	using MVC_Forms_vs_ModelBinding.Models;


	public class HouseDB : DbContext
	{
		// Your context has been configured to use a 'HouseDB' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'MVC_Forms_vs_ModelBinding.HouseDB' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'HouseDB' 
		// connection string in the application configuration file.
		public HouseDB()
			: base("name=HouseDB")
		{
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		public virtual DbSet<House> Houses { get; set; }

	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}