using System;
using SQLite;
using SQLitePCL;
namespace GroshiSQLite
{
	public interface ISQLiteInterface
	{
		SQLiteConnection GetConnection();
	}


}
