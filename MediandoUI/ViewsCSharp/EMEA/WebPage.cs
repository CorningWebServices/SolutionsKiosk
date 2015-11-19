using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public class WebPage : ContentPage
	{
		public WebPage (CorningLinks link)
		{
			
			var browser = new WebView();

			browser.Source = link.URL;

			Content = browser;

		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			App.ShowAppSelection = false;
			var masterPage = this.Parent.Parent as TabbedPage;
			masterPage.Children [0].Title = Translation.Localize ("HomeIcon");

		}
			
	}
}


