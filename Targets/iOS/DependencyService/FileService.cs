using System;
using MediandoUI;

using Mediando.iOS;
using Xamarin.Forms;
using System.IO;

[assembly: DependencyAttribute (typeof(FileService))]
namespace Mediando.iOS
{
	public class FileService : IFileService
	{
		public void GetTempSize (Action<long> size = null){
			var pspdfcachesize = GetPSPDFCacheSize ();
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var cache = Path.Combine (documents, ".config",".isolated-storage","ImageLoaderCache");
			if (Directory.Exists (cache)) {
				size.Invoke (GetDirectorySize (cache) + pspdfcachesize);
			} else {
				size.Invoke (pspdfcachesize + 0);
			}
		}

		static long GetDirectorySize(string p)
		{
			// 1.
			// Get array of all file names.
			string[] a = Directory.GetFiles(p, "*.*");

			// 2.
			// Calculate total bytes of all files in a loop.
			long b = 0;
			foreach (string name in a)
			{
				// 3.
				// Use FileInfo to get length of each file.
				FileInfo info = new FileInfo(name);
				b += info.Length;
			}
			// 4.
			// Return total size
			return b;
		}

		public void GetMediaSize (Action<long> size = null){
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (documents, "Downloads");
			if (Directory.Exists (directoryname)) {
				size.Invoke (GetDirectorySize (directoryname));
			} else {
				size.Invoke (0);
			}

		}

		public void GetDownloadsFolder (Action<string> path = null){
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (documents, "Downloads");
			path.Invoke (directoryname);
		}

		public long GetPSPDFCacheSize (){
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (documents, "..","Library","Caches","PSPDFKit");
			var size = CalculateFolderSize (directoryname);
			return size;
		}

		protected static long CalculateFolderSize(string folder)
		{
			long folderSize = 0;
			try
			{
				//Checks if the path is valid or not
				if (!Directory.Exists(folder))
					return folderSize;
				else
				{
					try
					{
						foreach (string file in Directory.GetFiles(folder))
						{
							if (File.Exists(file))
							{
								FileInfo finfo = new FileInfo(file);
								folderSize += finfo.Length;
							}
						}

						foreach (string dir in Directory.GetDirectories(folder))
							folderSize += CalculateFolderSize(dir);
					}
					catch (NotSupportedException e)
					{
						Console.WriteLine("Unable to calculate folder size: {0}", e.Message);
					}
				}
			}
			catch (UnauthorizedAccessException e)
			{
				Console.WriteLine("Unable to calculate folder size: {0}", e.Message);
			}
			return folderSize;
		}

	}
}

