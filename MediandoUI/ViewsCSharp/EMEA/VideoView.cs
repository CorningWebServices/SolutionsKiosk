using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public class VideoView : ContentPage
	{
		public ProductCatalog FileItem;
		public VideoView (ProductCatalog fileItem)
		{
			NavigationPage.SetHasNavigationBar(this, false);
			FileItem = fileItem;

		}
	}
}


