﻿using System;
using System.IO;
using SQLite;
using Mediando.iOS;
using Xamarin.Forms;
using MediandoUI;
using SQLite.Net;

[assembly: Dependency(typeof(SQLite_iOS))]

namespace Mediando.iOS
{
	public class SQLite_iOS: ISQLite
	{
		public SQLite_iOS ()
		{
		}

		#region ISQLite implementation

		public SQLiteConnection GetConnection ()
		{
			var fileName = "Mediando.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, fileName);

			var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS ();
			var connection = new SQLite.Net.SQLiteConnection (platform, path);

			return connection;
		}

		#endregion
	}
}


