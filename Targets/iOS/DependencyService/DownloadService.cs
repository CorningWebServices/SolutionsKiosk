using MediandoUI;

using PSPDFKit;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Mediando.iOS;
using System.Net;
using System.IO;
using System;
using System.Threading.Tasks;

[assembly: DependencyAttribute (typeof(DownloadService))]
namespace Mediando.iOS
{

	public class DownloadService : IDownloadService
	{
		
		public void DownloadData (ProductCatalog fileItem, Action<string> filePath = null)
		{
			var status = PSPDFStatusHUDItem.GetIndeterminateProgressHud ("Downloading");
			status.Push (true,null);

			var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (documents, "Downloads");
			Directory.CreateDirectory (directoryname);

			string localFilename = fileItem.FilePath.Substring (fileItem.FilePath.LastIndexOf ("/") + 1, fileItem.FilePath.Length - 1 - fileItem.FilePath.LastIndexOf ("/"));
			string localfilePath = Path.Combine (directoryname, localFilename);
			string localImagename = fileItem.ThumbPath.Substring (fileItem.ThumbPath.LastIndexOf ("/") + 1, fileItem.ThumbPath.Length - 1 - fileItem.ThumbPath.LastIndexOf ("/"));
			string localimagePath = Path.Combine (directoryname, localImagename);

			var imageClient = new WebClient ();
			imageClient.DownloadFileAsync(NSUrl.FromString (fileItem.ThumbPath), localimagePath);

			var webClient = new WebClient ();
			webClient.DownloadFileAsync (NSUrl.FromString (fileItem.FilePath), localfilePath);

			webClient.DownloadFileCompleted += (s, e) => {
				try {
					status.Pop(true,null);
					filePath.Invoke (localFilename);
					status = null;
				} catch(Exception ex) {
					new UIAlertView ("Error", "Download Failed", null, "OK", null).Show ();
				}
			};

			webClient.DownloadProgressChanged += (s,e) => {
				status.Progress = (float)e.ProgressPercentage;
			};

			imageClient.DownloadDataCompleted += (s, e) => {
				
			};

		}
	}
}
