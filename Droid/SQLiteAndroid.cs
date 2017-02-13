using System;
using System.IO;
using Xamarin.Forms;
using GroshiSQLite.Droid;
using SQLite;

[assembly: Dependency(typeof(SQLiteAndroid))]

namespace GroshiSQLite.Droid
{
	public class SQLiteAndroid:ISQLiteInterface
	{
		public SQLiteAndroid()
		{
		}

		#region ISQLite implementation
		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "GroshiDB.sqlite";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);
			Console.WriteLine(path);
			if (!File.Exists(path)) File.Create(path);
			//var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			var conn = new SQLite.SQLiteConnection(path);
			// Return the database connection 
			return conn;
		}

		#endregion

	}
}
