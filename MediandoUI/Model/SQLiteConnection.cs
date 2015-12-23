using System;
using SQLite.Net;

namespace MediandoUI
{
	public interface ISQLite {
		SQLiteConnection GetConnection();
	}
}


