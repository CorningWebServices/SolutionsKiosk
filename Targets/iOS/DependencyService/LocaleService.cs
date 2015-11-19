using System;
using Xamarin.Forms;
using Foundation;
using System.Threading;
using Mediando.iOS;

[assembly:Dependency(typeof(LocaleService))]

namespace Mediando.iOS
{
	public class LocaleService : MediandoUI.ILocale
	{
		public void SetLocale ()
		{

			var iosLocaleAuto = NSLocale.AutoUpdatingCurrentLocale.LocaleIdentifier;
			var netLocale = iosLocaleAuto.Replace ("_", "-");
			System.Globalization.CultureInfo ci;
			try {
				ci = new System.Globalization.CultureInfo (netLocale);
			} catch {
				ci = new System.Globalization.CultureInfo (GetCurrent ());
			}
			Thread.CurrentThread.CurrentCulture = ci;
			Thread.CurrentThread.CurrentUICulture = ci;
		}
		/// <remarks>
		/// Not sure if we can cache this info rather than querying every time
		/// </remarks>
		public string GetCurrent ()
		{
			
			var iosLanguageAuto = NSLocale.AutoUpdatingCurrentLocale.LanguageCode;
			var netLanguage = iosLanguageAuto.Replace ("_", "-");

			return netLanguage;
		}
	}
}

