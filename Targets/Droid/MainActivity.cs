using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MediandoUI;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
//using PSPDFKit;

namespace Mediando.Droid
{
	[Activity (Label = "Mediando.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsApplicationActivity
	{
		public const string LicenseKey = "blcWhXFIwpatKqQ1FoOb3HyC_2clmIg-rDyAKwQapxIFxDfXqmFqKYedy0oMW94i90ERmUNfPU4B8_V1D6TeTyNmFlL-ICnqWCW5NxT2MW1E_K1RkhWgyqo0rOACe6o5tdoKwwCHLrccRnHzDnGShjYRs9boy2bcZmegG5KIti21WRkkhiUu5kIyRG7DvIOPliWFGMoQI9020S6Ak6j8Nc6abAkVQXAjPFXbEVpFTIIRcD7xGFkEwS6oL7YatYkKYbY94GFRYv6YLedMblRntdMVOPsrSidxOqerjU2Myom9Dxkx5CxvIvWKZLV00cjma_BCy4rgq9GO9ScYytQH1qiyaK8Hyk8oBSAiGhveUP7SAA7uS2CR9ZU0buZ-Cneqli4yw91PHPwRx1GpFItvMw5og157ajhN5UixQJ76T3c=";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Forms.Init (this, bundle);
			//PSPDFKitGlobal.Initialize (this, LicenseKey);

			LoadApplication (new App ());
		}
	}
}

