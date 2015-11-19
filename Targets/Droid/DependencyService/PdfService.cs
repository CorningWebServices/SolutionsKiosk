using System;
using MediandoUI;
using Xamarin.Forms;
using Mediando.Droid;

[assembly: DependencyAttribute (typeof(PdfService))]
namespace Mediando.Droid
{
	
	public class PdfService //: IPdfService
	{
		

		public void OpenPDF (string MediaURL, string FileName, Action<bool> completed = null)
		{

//			// Show Document using PSPDFKit activity
//			var thumbnailBarConfiguration = new ThumbnailBarConfiguration (Forms.Context, Resource.Color.pspdf_color);
//			var pspdfkitConfiguration = new PSPDFKitActivityConfiguration.Builder (Forms.Context, MainActivity.LicenseKey)
//				.ScrollDirection (PageScrollDirection.Horizontal)
//				.ShowPageNumberOverlay ()
//				.ShowThumbnailGrid ()
//				.ShowThumbnailBar ()
//				.ThumbnailBarConfiguration (thumbnailBarConfiguration)
//				.Build ();
//			
//
//			Android.Net.Uri docUri;
//			// Extract the pdf from assets
//			var docPath = Path.Combine (Android.OS.Environment.ExternalStorageDirectory.ToString (), FileName);
//			if (!System.IO.File.Exists (docPath)) {
//				 
//				var bytes = System.IO.File.ReadAllBytes(Android.Net.Uri.Parse(MediaURL).ToString());
//
//				//Copy the private file's data to the EXTERNAL PUBLIC location
//				//var externalPath = global::Android.OS.Environment.ExternalStorageDirectory.Path + "/report.pdf";
//				System.IO.File.WriteAllBytes(docPath, bytes);
//
//			} 
//			docUri = Android.Net.Uri.FromFile (new Java.IO.File(docPath));
//
//
//			if (PSPDFKitGlobal.IsOpenableUri (Forms.Context, docUri))
//				PSPDFKitAppCompatActivity.ShowDocument (Forms.Context, docUri, pspdfkitConfiguration);

		}




	}
}

