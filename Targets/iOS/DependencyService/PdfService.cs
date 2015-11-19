using System;
using MediandoUI;

using PSPDFKit;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Mediando.iOS;
using System.Net;
using System.IO;

[assembly: DependencyAttribute (typeof(PdfService))]
namespace Mediando.iOS
{
	
	public class PdfService : IPdfService
	{
		public void OpenPDF (LibraryType DocumentType, string MediaURL, string FileName, int NavigationRoot = 0, Action<bool> completed = null)
		{

			UIWindow window = UIApplication.SharedApplication.KeyWindow;
				
			var uid = MediaURL.Substring (MediaURL.LastIndexOf ("/") + 1, MediaURL.Length - 1 - MediaURL.LastIndexOf ("/")).Replace (".pdf", "") + FileName;
			if (DocumentType == LibraryType.NewsLetter) {
				PSPDFDocument document;
				if (!MediaURL.StartsWith ("http")) {
					var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
					var directoryname = Path.Combine (documents, "Downloads");
					MediaURL = Path.Combine (directoryname, MediaURL);
					document = new PSPDFDocument (NSUrl.FromFilename (new Uri (MediaURL).ToString ()));
				} else {
					document = new PSPDFDocument (NSUrl.FromString (MediaURL));
				}
				document.Uid = uid;
				var pdfViewer = new ViewerPageController (document);
				var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [2];
				var navcontroller = rootController as UINavigationController;
				if (navcontroller != null) {
					pdfViewer.HidesBottomBarWhenPushed = true;
					navcontroller.PushViewController (pdfViewer, true);
				}
			} else if (DocumentType == LibraryType.MyDocuments) {
				var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				var directoryname = Path.Combine (documents, "Downloads");
				var path = Path.Combine (directoryname, MediaURL);
				var document = new PSPDFDocument (NSUrl.FromFilename (new Uri (path).ToString ()));
				document.Uid = uid;
				var pdfViewer = new ViewerPageController (document);
				var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [3];
				var navcontroller = rootController as UINavigationController;
				if (navcontroller != null) {
					pdfViewer.HidesBottomBarWhenPushed = true;
					navcontroller.PushViewController (pdfViewer, true);
				}
			} else if (DocumentType == LibraryType.Search) {
				PSPDFDocument document;
				if (!MediaURL.StartsWith ("http")) {
					var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
					var directoryname = Path.Combine (documents, "Downloads");
					MediaURL = Path.Combine (directoryname, MediaURL);
					document = new PSPDFDocument (NSUrl.FromFilename (new Uri (MediaURL).ToString ()));
				} else {
					document = new PSPDFDocument (NSUrl.FromString (MediaURL));
				}
				document.Uid = uid;
				var pdfViewer = new ViewerPageController (document);
				var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [NavigationRoot];
				var navcontroller = rootController as UINavigationController;
				if (navcontroller != null) {
					pdfViewer.HidesBottomBarWhenPushed = true;
					navcontroller.PushViewController (pdfViewer, true);
				}
			} else {
				PSPDFDocument document;
				if (!MediaURL.StartsWith ("http")) {
					var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
					var directoryname = Path.Combine (documents, "Downloads");
					MediaURL = Path.Combine (directoryname, MediaURL);
					document = new PSPDFDocument (NSUrl.FromFilename (new Uri (MediaURL).ToString ()));
				} else {
					document = new PSPDFDocument (NSUrl.FromString (MediaURL));
				}
				document.Uid = uid;
				var pdfViewer = new ViewerPageController (document);
				var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [1];
				var navcontroller = rootController as UINavigationController;
				if (navcontroller != null) {
					pdfViewer.HidesBottomBarWhenPushed = true;
					navcontroller.PushViewController (pdfViewer, true);
				}
			}
		}
				
	}

}


