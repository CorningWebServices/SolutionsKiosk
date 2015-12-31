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
using Mediando.Droid;
using MediandoUI;
using System.Net;


[assembly: DependencyAttribute (typeof(PdfService))]
namespace Mediando.Droid
{
	
	public class PdfService : IPdfService
	{
		

		public void OpenPDF (LibraryType DocumentType, string MediaURL, string FileName, int NavigationRoot = 0, Action<bool> completed = null)
		{
			PSPDFKitGlobal.Initialize (Forms.Context, MainActivity.LicenseKey);

			const string permission = Manifest.Permission.WriteExternalStorage;
			if (ContextCompat.CheckSelfPermission(Forms.Context, permission) == (int)Permission.Granted)
			{
				var docUri = ExtractAsset (Forms.Context, "LAN-1433-BEN.pdf");
				ShowPdfDocument (docUri,"");
			}
		
		}

		public static Android.Net.Uri ExtractAsset (Context ctx, string assetName)
		{
			var docPath = Path.Combine (Android.OS.Environment.ExternalStorageDirectory.ToString (), assetName);
			if (!File.Exists (docPath)) {
				using (var br = new BinaryReader (ctx.Assets.Open (assetName))) {
					using (var bw = new BinaryWriter (new FileStream (docPath, FileMode.Create))) {
						var buffer = new byte[2048];
						var len = 0;
						while ((len = br.Read (buffer, 0, buffer.Length)) > 0) {
							bw.Write (buffer, 0, len);
						}
					}
				}
			}
			var file = new Java.IO.File (docPath);
			return Android.Net.Uri.FromFile (file);
		}

		void DownloadData(string MediaURL, string FileName)
		{
			var status = SetUpProgressDialog ("Downloading", "Downloading file....", false, ProgressDialogStyle.Horizontal);

	

			var documents = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
			//var directoryname = Path.Combine (documents, "TempDownloads");
			Directory.CreateDirectory (documents);
	
			string localFilename = MediaURL.Substring (MediaURL.LastIndexOf ("/") + 1, MediaURL.Length - 1 - MediaURL.LastIndexOf ("/"));
			//string localfilePath = Path.Combine (directoryname, localFilename);

			string localfilePath = Path.Combine (documents, localFilename);

			var webClient = new WebClient ();
			webClient.DownloadFileAsync (new Uri(MediaURL), localfilePath);

			webClient.DownloadFileCompleted += (s, e) => {
				try {
					var file = new Java.IO.File (localfilePath);
					var docUri = Android.Net.Uri.FromFile (file);
					ShowPdfDocument(docUri, localFilename);
				} catch(Exception ex) {
					var error = ex.StackTrace;
					//new UIAlertView ("Error", "Download Failed", null, "OK", null).Show ();
				}
			};

			webClient.DownloadProgressChanged += (s,e) => {
				status.Progress = e.ProgressPercentage;
			};
		}

		void ShowPdfDocument (Android.Net.Uri docUri, string filename)
		{
			// Customize thumbnailBar color defaults
			var thumbnailBarThemeConfiguration = new ThumbnailBarThemeConfiguration.Builder (Forms.Context)
				.SetBackgroundColor (Android.Graphics.Color.Argb (255, 52, 152, 219))
				.SetThumbnailBorderColor (Android.Graphics.Color.Argb (255, 44, 62, 80))
				.Build ();

			// Show Document using PSPDFKit activity
			var pspdfkitConfiguration = new PSPDFActivityConfiguration.Builder (Forms.Context, MainActivity.LicenseKey)
				.ScrollDirection (PageScrollDirection.Horizontal)
				.ShowPageNumberOverlay ()
				.ShowThumbnailGrid ()
				.ShowThumbnailBar ()
				.ThumbnailBarThemeConfiguration (thumbnailBarThemeConfiguration)
				.Build ();

			if (!PSPDFKitGlobal.IsOpenableUri (Forms.Context, docUri)) {
				ShowError ("This document uri cannot be opened \n " + docUri.ToString ());
			} else {
				try{
					PSPDFAppCompatActivity.ShowDocument (Forms.Context, docUri, pspdfkitConfiguration);
				}
				catch(Exception ex){
					var error = ex.StackTrace;
				}

			}
		}

		ProgressDialog SetUpProgressDialog (string title, string message, bool indeterminate, ProgressDialogStyle style)
		{
			var dialog = new ProgressDialog (Forms.Context) {
				Indeterminate = indeterminate,
				Max = 100,
				Progress = 0
			};

			dialog.SetTitle (title);
			dialog.SetMessage (message);
			dialog.SetProgressStyle (style);
			return dialog;
		}

		void ShowError (string message = null)
		{
			var alert = new AlertDialog.Builder (Forms.Context);

			alert.SetTitle ("Error");
			alert.SetMessage (message ?? "There was an error");

			alert.SetPositiveButton ("Ok", (senderAlert, args) => {
				// Do something here to handle error
			});

			if (message != null) {
				alert.SetNeutralButton ("Visit", (sender, e) => {
					var uri = Android.Net.Uri.Parse ("https://pspdfkit.com/android/");
					var intent = new Intent (Intent.ActionView, uri);
					Forms.Context.ApplicationContext.StartActivity (intent);
				});
			}

			new MainActivity().RunOnUiThread (() => {
				alert.Show();
			});
		}

	}
}

