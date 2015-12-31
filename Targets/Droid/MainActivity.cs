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
using PSPDFKit;


namespace Mediando.Droid
{
	[Activity (MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsApplicationActivity
	{
		public const string LicenseKey = "aV13BvsPiHES35otxucsuk6Nlz29upfSq_IAumR41odUSR5o1wDJb2ltZD7kcnGwd8Mk8HwemR-wT-eSnVKNInzUjY_0s5i37L7S3ecCphc86XUiIy6diCcSNjKUPHQkdRoteXz2UgMOCecG0Xtx9a0Zi-H__Au_UIEqYJw_p0gOrg6aFw239AYeN9Ak7JTLZVH1CtpUV718n-JpYvDTJENLDnaPHSRK9uVymUMGnUzCN_VrYwo-YJMazADcsODYQ1-fclzH_tC_rIzDI43T4B701-Y6dK59kdn5GJxG9Sz-3_vqKrc7xYdpE-3zmZ5Dy8x4GjdT6nPw6QptNekBREffqt0cGPd16W0RSb4z_3PheSOEv8lAa3c0RkQtF2hkNEvDhAzMi2gDYm_YOapkaL2ziuSshRCyJYggMIqeKIwY1RbTy0pDwWnm5rXK0eAxR6SR_JTXkEo94Cp6c1CRC8cDqg1JdgSh7lnQnB3wxGSN-wEHYEv1ryqOccaWK3JL_x2VNDmwegsTuicdoYX8HKcV-CxW9vaVIlnGEmJWfZjNgV4TZjf4_3e6a3qe_jqu";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			Forms.Init (this, bundle);
			PSPDFKitGlobal.Initialize (this, LicenseKey);
			FFImageLoading.Forms.Droid.CachedImageRenderer.Init();

			LoadApplication (new App ());
		}
	}
		
}

