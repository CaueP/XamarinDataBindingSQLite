using System;
using System.IO;
using FormAssistControl.iOS;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLiteIOS))]
namespace FormAssistControl.iOS
{
	public class SQLiteIOS:ISQLite
	{
		public SQLiteIOS()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "TodoSQLite.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine(documentsPath,"..", "Library");	// Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);
			// CreateFlags connection
			var conn = new SQLite.SQLiteConnection(path);
			// Return the database connection
			return conn;
		}
	}
}
