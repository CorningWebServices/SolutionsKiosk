using System;

namespace MediandoUI
{
	public class WebApiConfig
	{
		public static readonly string Base = "https://customer6.corning.com/corningopticalcommunications/catalogkiosk/api/AppData/";
		public static readonly string Language = Base + "Languages";
		public static readonly string Filters = Base + "Filters";
		public static readonly string Categories = Base + "Categories";
		public static readonly string ProductCatalogs = Base + "ProductCatalogs";
		public static readonly string CurrentVersion = Base + "CurrentVersion";
	}
}

