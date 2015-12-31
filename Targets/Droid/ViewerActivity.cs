using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using System.Threading.Tasks;

using PSPDFKit;
using PSPDFKit.Configuration;
using PSPDFKit.UI;
using PSPDFKit.Configuration.Activity;
using PSPDFKit.Configuration.Page;
using PSPDFKit.Configuration.Theming;
using Android;
using Android.Content.PM;
using Android.Support.V4.Content;
using Android.Support.V4.App;
using Xamarin.Forms;

//[assembly: ExportRenderer(typeof(MediandoUI.ViewerPage), typeof(Mediando.Droid.ViewerActivity))]
namespace Mediando.Droid
{
	[Activity (Label = "MyThirdActivity")]
	public class ViewerActivity : Activity
	{		
		static readonly string yourLicenseKey = "aV13BvsPiHES35otxucsuk6Nlz29upfSq_IAumR41odUSR5o1wDJb2ltZD7kcnGwd8Mk8HwemR-wT-eSnVKNInzUjY_0s5i37L7S3ecCphc86XUiIy6diCcSNjKUPHQkdRoteXz2UgMOCecG0Xtx9a0Zi-H__Au_UIEqYJw_p0gOrg6aFw239AYeN9Ak7JTLZVH1CtpUV718n-JpYvDTJENLDnaPHSRK9uVymUMGnUzCN_VrYwo-YJMazADcsODYQ1-fclzH_tC_rIzDI43T4B701-Y6dK59kdn5GJxG9Sz-3_vqKrc7xYdpE-3zmZ5Dy8x4GjdT6nPw6QptNekBREffqt0cGPd16W0RSb4z_3PheSOEv8lAa3c0RkQtF2hkNEvDhAzMi2gDYm_YOapkaL2ziuSshRCyJYggMIqeKIwY1RbTy0pDwWnm5rXK0eAxR6SR_JTXkEo94Cp6c1CRC8cDqg1JdgSh7lnQnB3wxGSN-wEHYEv1ryqOccaWK3JL_x2VNDmwegsTuicdoYX8HKcV-CxW9vaVIlnGEmJWfZjNgV4TZjf4_3e6a3qe_jqu";
		const string sampleDoc = "LAN-1433-BEN.pdf";

		const int RequestOpenDocument = 1;

		// On Marshmallow+ devices this is used to ask for the necessary write permission.
		const int RequestWritePermission = 2;
		readonly string [] PermissionsExternalStorage = 
		{
			Manifest.Permission.ReadExternalStorage,
			Manifest.Permission.WriteExternalStorage
		};

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			PSPDFKitGlobal.Initialize (this, yourLicenseKey);

			const string permission = Manifest.Permission.WriteExternalStorage;
			if (ContextCompat.CheckSelfPermission(this, permission) == (int)Permission.Granted)
			{
				ShowDocumentFromAssets ();
				return;
			}

			ActivityCompat.RequestPermissions(this, PermissionsExternalStorage, RequestWritePermission);
		}

		void ShowDocumentFromAssets() {
			// Extract the pdf from assets if not already extracted
			var docUri = DocumentHelper.ExtractAsset (this, sampleDoc);
			ShowPdfDocument (docUri);
			return;
		}

		void ShowPdfDocument (Android.Net.Uri docUri)
		{
			// Customize thumbnailBar color defaults
			var thumbnailBarThemeConfiguration = new ThumbnailBarThemeConfiguration.Builder (this)
				.SetBackgroundColor (Android.Graphics.Color.Argb (255, 52, 152, 219))
				.SetThumbnailBorderColor (Android.Graphics.Color.Argb (255, 44, 62, 80))
				.Build ();

			// Show Document using PSPDFKit activity
			var pspdfkitConfiguration = new PSPDFActivityConfiguration.Builder (ApplicationContext, yourLicenseKey)
				.ScrollDirection (PageScrollDirection.Horizontal)
				.ShowPageNumberOverlay ()
				.ShowThumbnailGrid ()
				.ShowThumbnailBar ()
				.ThumbnailBarThemeConfiguration (thumbnailBarThemeConfiguration)
				.Build ();

			if (!PSPDFKitGlobal.IsOpenableUri (this, docUri))
				ShowError ("This document uri cannot be opened \n " + docUri.ToString ());
			else
				PSPDFAppCompatActivity.ShowDocument (this, docUri, pspdfkitConfiguration);
		}

		protected async override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);

			if (requestCode == RequestOpenDocument && resultCode == Result.Ok && data != null) {
				// Only document accessible as files are openable directly with PSPDFKit so we have to
				// transfer other documents to application cache
				if (!PSPDFKitGlobal.IsOpenableUri (this, data.Data)) {
					var dialog = SetUpProgressDialog ("Downloading", "Downloading file....", false, ProgressDialogStyle.Horizontal);
					dialog.Show ();

					var docPath = Path.Combine (ApplicationContext.CacheDir.ToString (), DateTime.Now.Ticks.ToString () + ".pdf");
					var progressReporter = new Progress<DownloadBytesProgress> ();
					progressReporter.ProgressChanged += (s, args) => dialog.Progress = (int)(100 * args.PercentComplete);
					var docUri = await DocumentHelper.DownloadDocument (this, data.Data, docPath, progressReporter);
					dialog.Hide ();
					ShowPdfDocument (docUri);
				} else
					ShowPdfDocument (data.Data);
			}
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
		{
			if(requestCode == RequestWritePermission && grantResults[0] == Permission.Granted) {	
				ShowDocumentFromAssets ();
			}
		}

		void ShowError (string message = null)
		{
			var alert = new AlertDialog.Builder (this);

			alert.SetTitle ("Error");
			alert.SetMessage (message ?? "There was an error");

			alert.SetPositiveButton ("Ok", (senderAlert, args) => {
				// Do something here to handle error
			});

			if (message != null) {
				alert.SetNeutralButton ("Visit", (sender, e) => {
					var uri = Android.Net.Uri.Parse ("https://pspdfkit.com/android/");
					var intent = new Intent (Intent.ActionView, uri);
					StartActivity (intent);
				});
			}

			RunOnUiThread (() => {
				alert.Show();
			});
		}

		ProgressDialog SetUpProgressDialog (string title, string message, bool indeterminate, ProgressDialogStyle style)
		{
			var dialog = new ProgressDialog (this) {
				Indeterminate = indeterminate,
				Max = 100,
				Progress = 0
			};

			dialog.SetTitle (title);
			dialog.SetMessage (message);
			dialog.SetProgressStyle (style);
			return dialog;
		}
	}
}


