using System;
using System.Reflection;
using System.Diagnostics;
using System.Resources;
using System.Threading;
using System.Globalization;
using Xamarin.Forms;

namespace MediandoUI
{
	public static class Translation
	{
		public static void SetLocale ()
		{
			DependencyService.Get<ILocale>().SetLocale();
		}

		/// <remarks>
		/// Maybe we can cache this info rather than querying every time
		/// </remarks>
		public static string Locale ()
		{
			GlobalVariables.CurrentLocale =  DependencyService.Get<ILocale>().GetCurrent();
			return GlobalVariables.CurrentLocale;
		}

		public static string Localize(string key, string comment="") {

			var netLanguage = string.IsNullOrWhiteSpace(GlobalVariables.CurrentLocale) ? Locale () : GlobalVariables.CurrentLocale;
			// Platform-specific
			ResourceManager temp = new ResourceManager("MediandoUI.Resx.AppResources", typeof(Translation).GetTypeInfo().Assembly);
			string result = temp.GetString (key, new CultureInfo (netLanguage));
			//Debug.WriteLine ("Localize: " + key + "/" +result);
			return result; 
		}
	}
}

