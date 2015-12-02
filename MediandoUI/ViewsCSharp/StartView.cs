using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MediandoUI
{
	public class StartView : TabbedPage
	{

		public StartView ()
		{
			this.BackgroundImage = ImageConstants.backgroundImage;
			//this.Title = "Corning";
			this.Children.Clear ();

			this.Children.Add (new NavigationPage(new DummyView ()){
				Title = Translation.Localize("HomeIcon"),
				Icon = ImageConstants.homeIcon,
				BarBackgroundColor = Color.Black,
				BarTextColor = Color.White,
			});

			this.Children.Add (new NavigationPage (new LibraryView ()) { 
				Title = Translation.Localize("LibraryIcon"),
				Icon = ImageConstants.libraryIcon,
				IsEnabled = true,
				BarBackgroundColor = Color.Black,
				BarTextColor = Color.White,
			});

			this.Children.Add (new NavigationPage (new NewsletterView ()) {
				Title = Translation.Localize("NewsLetterIcon"),
				Icon = ImageConstants.newsIcon,
				BarBackgroundColor = Color.Black,
				BarTextColor = Color.White,
			});

			this.Children.Add (new NavigationPage (new MyDocumentsView ()) {
				Title = Translation.Localize("MyDocsIcon"),
				Icon = ImageConstants.documentsIcon,
				BarBackgroundColor = Color.Black,
				BarTextColor = Color.White,
			});

			this.Children.Add (new NavigationPage (new SettingsView ()) {
				Title = Translation.Localize("SettingsIcon"),
				Icon = ImageConstants.settingsIcon,
				BarBackgroundColor = Color.Black,
				BarTextColor = Color.White,
			});
		}
	}
}



