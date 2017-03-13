using System;
using System.IO;
using FormAssistControl.Droid;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLiteDroid))]
namespace FormAssistControl.Droid
{
	public class SQLiteDroid:ISQLite
	{
		public SQLiteDroid()
		{
		}

		public SQLiteConnection GetConnection()
		{
			// initializing
			SQLitePCL.Batteries.Init();
			var sqliteFilename = "TodoSQLite.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentsPath, sqliteFilename);
			// Create connection
			var conn = new SQLite.SQLiteConnection(path);
			// Return the database connection
			return conn;
		}
	}
}
