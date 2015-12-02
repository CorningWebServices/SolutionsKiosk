using System;
using System.IO;
using SQLite;
using Mediando.Droid;
using Xamarin.Forms;
using MediandoUI;
using SQLite.Net;

[assembly: Dependency(typeof(SqliteDb_Droid))]

namespace Mediando.Droid
{
	public class SqliteDb_Droid: ISQLite
	{
		public SqliteDb_Droid ()
		{
		}

		#region ISQLite implementation

		public SQLiteConnection GetConnection ()
		{
			var fileName = "Mediando.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, fileName);
			System.IO.Directory.CreateDirectory(libraryPath);

			var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid ();
			var connection = new SQLite.Net.SQLiteConnection (platform, path);

			return connection;
		}

		#endregion
	}
}


