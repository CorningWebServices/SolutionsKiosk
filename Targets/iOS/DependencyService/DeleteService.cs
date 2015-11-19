using MediandoUI;

using PSPDFKit;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Mediando.iOS;
using System.Net;
using System.IO;
using System;

[assembly: DependencyAttribute (typeof(DeleteService))]
namespace Mediando.iOS
{

	public class DeleteService : IDeleteService
	{
		public void DeleteFile (string fileName, Action<bool> completed = null)
		{
			try {
				
				string imagename = fileName.Replace (".pdf", ".jpeg").Replace (".mp4", ".jpeg");

				var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				var directoryname = Path.Combine (documents, "Downloads");
				if (Directory.Exists (directoryname)) {
					foreach (var file in Directory.GetFiles(directoryname)) {
						var item = file.Substring (file.LastIndexOf ("/") + 1, file.Length - 1 - file.LastIndexOf ("/"));
						if (item == fileName || item == imagename) {
							File.Delete (file);
						}
					}
				}
				//File.Delete (fileItem.FilePath.Replace("file://",""));
				//File.Delete (fileItem.ThumbPath.Replace("file://",""));
				completed.Invoke (true);
			} catch {

				completed.Invoke (false);
				throw;
			}
		}

		public void DeleteAllMedia (Action<bool> completed = null)
		{
			try {
				var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				var directoryname = Path.Combine (documents, "Downloads");
				if (Directory.Exists (directoryname)) {
					foreach (var file in Directory.GetFiles(directoryname)) {
						File.Delete (file);	
					}
				}
				completed.Invoke (true);
			} catch (Exception ex) {
				completed.Invoke (false);
			}
		}

		public void DeleteTempFiles (Action<bool> completed = null)
		{
			try {
				var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				var cache = Path.Combine (documents, ".config", ".isolated-storage", "ImageLoaderCache");
				if (Directory.Exists (cache)) {
					foreach (var file in Directory.GetFiles(cache)) {
						File.Delete (file);	
					}
				}
				var pdfcache = Path.Combine (documents, "..","Library","Caches","PSPDFKit");
				if (Directory.Exists (pdfcache)) {
					foreach (var file in Directory.GetFiles(pdfcache)) {
						File.Delete (file);	
					}

					foreach (string dir in Directory.GetDirectories(pdfcache)){
						foreach (var file in Directory.GetFiles(dir)) {
							File.Delete (file);	
						}
					}
				}
				completed.Invoke (true);
			} catch (Exception ex) {
				completed.Invoke (false);
			}
		}
	}
}
