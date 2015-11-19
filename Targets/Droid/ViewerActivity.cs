//
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//
//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
////using PSPDFKit.Configuration.Activity;
////using PSPDFKit;
////using PSPDFKit.UI;
//using Xamarin.Forms;
//
//namespace Mediando.Droid
//{
//	[Activity (Label = "ViewerActivity")]			
//	public class ViewerActivity : Activity
//	{
//		protected override void OnCreate (Bundle bundle)
//		{
//			base.OnCreate (bundle);
//			//SetContentView (Resource.Layout.Main);
//
//			Android.Net.Uri	docUri = Android.Net.Uri.FromFile (new Java.IO.File (Intent.GetStringExtra("File")));
////
////			// Show Document using PSPDFKit activity
////			var thumbnailBarConfiguration = new ThumbnailBarConfiguration (this,Resource.Color.pspdf_color);
////			var pspdfkitConfiguration = new PSPDFKitActivityConfiguration.Builder (this, MainActivity.LicenseKey)
////				.ScrollDirection (PageScrollDirection.Horizontal)
////				.ShowPageNumberOverlay ()
////				.ShowThumbnailGrid ()
////				.ShowThumbnailBar ()
////				.ThumbnailBarConfiguration (thumbnailBarConfiguration)
////				.Build ();
////
////
////
////			if (PSPDFKitGlobal.IsOpenableUri (this, docUri))
////				PSPDFKitAppCompatActivity.ShowDocument (Forms.Context, docUri, pspdfkitConfiguration);
//
//		}
//	}
//}
//
