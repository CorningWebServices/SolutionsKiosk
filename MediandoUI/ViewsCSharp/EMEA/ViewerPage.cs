using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public class ViewerPage : ContentPage
	{
		public ProductCatalog FileItem;
		public ViewerPage(ProductCatalog fileItem)
		{
			NavigationPage.SetHasNavigationBar(this, true);

			//Title = fileItem.Name;

			FileItem = fileItem;

			// rendering of this page is done natively on each platform
		}
	}
}


