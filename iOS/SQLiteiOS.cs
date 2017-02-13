using System;
using SQLite;
using Xamarin.Forms;
using GroshiSQLite.iOS;
using System.IO;

[assembly: Dependency(typeof(SQLiteiOS))]
namespace GroshiSQLite.iOS
{
	public class SQLiteiOS : ISQLiteInterface
	{
		public SQLiteiOS()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "GroshiDB.sqlite";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);

			// This is where we copy in the prepopulated database
			Console.WriteLine("groshi...sqlite file path--starts");
			Console.WriteLine(path);
			Console.WriteLine("groshi...sqlite file path--ends");
			if (!File.Exists(path))
			{
				File.Create(path);
			}

			//var plat = new SQLite.Platform.XamarinIOS.SQLitePlatformIOS();
			//var conn = new SQLite.Net.SQLiteConnection(plat, path);
			var conn = new SQLite.SQLiteConnection(path);



			// Return the database connection 
			return conn;
		}
	}
}
