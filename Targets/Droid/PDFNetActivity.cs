//
//using System;
//using System.Collections.Generic;
//using System;
//using System.IO;
//
//using Android.App;
//using Android.Content;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Android.OS;
//
//using pdftron;
//using pdftron.PDF;
//using pdftron.PDF.Tools;
//
//namespace Mediando.Droid
//{
//	[Activity(Label = "PDFNetActivity", HardwareAccelerated = true,
//		ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.KeyboardHidden,
//		WindowSoftInputMode = SoftInput.AdjustPan, Theme = "@style/AppTheme")]
//	public class PDFNetActivity : Activity
//	{
////		private PDFViewCtrl mPdfViewCtrl;
////
////		protected override void OnCreate(Bundle bundle)
////		{
////			base.OnCreate(bundle);
////
////			string filePath = Intent.GetStringExtra("FilePath");
////
////			initialSetup(filePath);
////		}
////
////		public void initialSetup(string filePath)
////		{
////			try
////			{
////				PDFNet.Initialize(this, Resource.Raw.pdf); // No license key, will produce water-marks
////				//PDFNet.Initialize(this, Resource.Raw.pdfnet, "your license key"); // Full version mode
////				// Disk caching should be disabled if write-external-storage is not permitted.
////				// To add the permission, add <uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
////				// to the manifest file.
////				PDFNet.SetDefaultDiskCachingEnabled(true);
////				PDFNet.SetViewerCache(100 * 1024 * 1024, false);                    // Set viewer cache to 100MB, and store cache on memory.
////			}
////			catch (pdftron.Common.PDFNetException e)
////			{
////				Console.WriteLine(e.GetMessage());
////				return;
////			}
////
////			//SetContentView(Resource.Layout.Main);
////			mPdfViewCtrl = FindViewById<PDFViewCtrl>(Resource.Id.pdfviewctrl);
////
////			// Events
////			//mPdfViewCtrl.RenderingStarted += HandleOnRenderingStarted;
////			//mPdfViewCtrl.RenderingFinished += HandleOnRenderingFinished;
////			//mPdfViewCtrl.DocumentDownloaded += HandleOnDocumentDownloaded;
////			//mPdfViewCtrl.PageNumberChanged += HandleOnPageNumberChanged;
////			//mPdfViewCtrl.OnSetDoc += HandleOnSetDoc;
////
////			mPdfViewCtrl.PagePresentationMode = PDFViewCtrl.PagePresentationModes.e_single_page;
////			// if PDFNet.SetDefaultDiskCachingEnabled is set to false, do not use persistent cache.
////			mPdfViewCtrl.SetupThumbnails(false, // Do not use embedded thumbs
////				true,                           // Generate thumbs at runtime
////				true,                           // Use persistent thumb cache, PDFNet.SetDefaultDiskCachingEnabled must be set to true for this to work
////				0,                              // 0 -> max thumb size is defined by the SDK
////				50 * 1024 * 1024,               // Max absolute size for the thumb cache
////				0.1);                           // Max percentage of free disk we allow to the cache
////			mPdfViewCtrl.SetHighlightFields(true);
////			//mPdfViewCtrl.SetProgressiveRendering(false);                      // Turn off progressive rendering.
////			//mPdfViewCtrl.SetImageSmoothing(true);                             // Turn on image smoothing (better quality, but more expensive)
////			//mPdfViewCtrl.SetCaching(true);                                    // Turn on caching (consume more memory, but faster)
////			//mPdfViewCtrl.SetOverprint(PDFViewCtrl.OverprintPreviewModes.e_op_pdfx_on);            // Turn on overprint for PDF/X files (more accurate, but more expensive)
////			//mPdfViewCtrl.PageViewMode = PDFViewCtrl.PageViewModes.e_fit_width;    // Set the page view mode
////			//mPdfViewCtrl.PageRefViewMode = PDFViewCtrl.PageViewModes.e_fit_width; // Set the reference page view mode (more meaningful for non-continuous modes)
////
////			/*
////             * If you want to set the background of PDFViewCtrl to a Drawable,
////             * you can first set its background to be transparent and then set
////             * the Drawable.
////             */
////			//mPdfViewCtrl.SetBackgroundColor(255, 255, 255, true);
////			//Drawable draw = ...
////			//mPdfViewCtrl.SetBackgroundDrawable(draw);
////
////			/*
////             * Set zoom limits
////             */
////			//mPdfViewCtrl.SetZoomLimits(PDFViewCtrl.ZoomLimitModes.e_zoom_limit_relative, 1.0, 4.0);
////
////			/*
////             * Set content memory usage
////             */
////			//mPdfViewCtrl.SetRenderedContentCacheSize((long)(Java.Lang.Runtime.GetRuntime().MaxMemory() / (1024*1024) * 0.5));
////
////			/*
////             * Enables URL extraction
////             */
////			//mPdfViewCtrl.SetUrlExtraction(true);
////
////			PDFDoc docToOpen = null;
////			bool load_from_url = false;
////			if (!load_from_url)
////			{
////				docToOpen = null;
////				try
////				{
////					// Load from resource
////					docToOpen = new PDFDoc(filePath);
////
////					// If the document is password protected, you can "unlock" it now,
////					// or PDFViewCtrl will prompt for password when setDoc() is called later.
////					//docToOpen.InitStdSecurityHandler("password")
////					mPdfViewCtrl.Doc = docToOpen;
////				}
////				catch
////				{
////					docToOpen = null;
////				}
////			}
////			else
////			{
////				try
////				{
////					string cache_file = this.CacheDir.Path + "/pdfref.pdf";
////					mPdfViewCtrl.OpenURL("http://www.pdftron.com/downloads/pdfref.pdf", cache_file, "", null);
////				}
////				catch (pdftron.Common.PDFNetException e)
////				{
////					Toast t = Toast.MakeText(mPdfViewCtrl.Context, e.StackTrace, ToastLength.Long);
////					t.SetGravity(GravityFlags.Center, 0, 0);
////					t.Show();
////				}
////			}
////
////			ToolManager toolManager = new ToolManager(mPdfViewCtrl);
////			//toolManager.SetBuiltInPanModeToolbarEnable (false);       // Hide the built-in top and bottom toolbar
////			//toolManager.SetBuiltInPageNumberIndicatorVisible(false);  // Hide the built-in page indicator
////
////			// Events
////			//toolManager.SingleTapConfirmed += toolManager_SingleTapConfirmed;
////			//toolManager.ToolChanged += toolManager_ToolChanged;
////
////			mPdfViewCtrl.ToolManager = toolManager;
////		}
////
////		protected override void OnPause()
////		{
////			base.OnPause();
////			if (mPdfViewCtrl != null)
////			{
////				mPdfViewCtrl.Pause();
////			}
////		}
////		protected override void OnResume()
////		{
////			base.OnResume();
////			if (mPdfViewCtrl != null)
////			{
////				mPdfViewCtrl.Resume();
////			}
////		}
////		protected override void OnDestroy()
////		{
////			base.OnDestroy();
////			if (mPdfViewCtrl != null)
////			{
////				mPdfViewCtrl.Destroy();
////				mPdfViewCtrl = null;
////			}
////		}
////		public override void OnLowMemory()
////		{
////			base.OnLowMemory();
////			if (mPdfViewCtrl != null)
////			{
////				mPdfViewCtrl.PurgeMemory();
////			}
////		}
//	}
//}
