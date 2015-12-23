using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public class DownloadViewer : ContentPage
	{
		public Downloads FileItem;

		public DownloadViewer(Downloads fileItem)
		{
			NavigationPage.SetHasNavigationBar(this, false);

			//Title = fileItem.Name;

			FileItem = fileItem;

			// rendering of this page is done natively on each platform
		}
	}
}


