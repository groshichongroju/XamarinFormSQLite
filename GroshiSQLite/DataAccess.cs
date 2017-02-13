using System;
using SQLite;
using SQLitePCL;
using Xamarin.Forms;
using System.Collections.Generic;

namespace GroshiSQLite
{
	public class DataAccess
	{
		SQLiteConnection dbConn;
		public DataAccess()
		{
			dbConn = DependencyService.Get<ISQLiteInterface>().GetConnection();
			// create the table(s)
			dbConn.CreateTable<Employee>();
		}
		public List<Employee> GetAllEmployees()
		{
			return dbConn.Query<Employee>("Select * From [Employee]");
		}
		public int SaveEmployee(Employee aEmployee)
		{
			return dbConn.Insert(aEmployee);
		}
		public int DeleteEmployee(Employee aEmployee)
		{
			return dbConn.Delete(aEmployee);
		}
		public int EditEmployee(Employee aEmployee)
		{
			return dbConn.Update(aEmployee);
		}

	}
}
