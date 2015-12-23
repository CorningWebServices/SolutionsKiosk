using System;

namespace MediandoUI
{
	public enum MediaType{
		Document,
		Image,
		Video
	}

	public interface IPdfService
	{
		void OpenPDF (LibraryType DocumentType, string MediaURL, string FileName, int NavigationRoot = 0, Action<bool> completed = null);
	}

	public interface IVideoService
	{
		void PlayVideo (LibraryType DocumentType, string MediaURL, Action<bool> completed = null);
	}

	public interface IDownloadService
	{
		void DownloadData (ProductCatalog fileItem,  Action<string> filePath = null);
	}

	public interface IDeleteService
	{
		void DeleteFile (string fileName, Action<bool> completed = null);
		void DeleteAllMedia (Action<bool> completed = null);
		void DeleteTempFiles (Action<bool> completed = null);
	}

	public interface IFileService
	{
		void GetTempSize (Action<long> size = null);
		void GetMediaSize (Action<long> size = null);
		void GetDownloadsFolder (Action<string> path = null);
	}

	public interface ILocale
	{
		string GetCurrent();

		void SetLocale();
	}
}

