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

			this.Children.Clear ();

			Device.OnPlatform(
				iOS: () => {
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
				},
				Android: () => {

					var selector = new NavigationPage (new AppSelectorView ()) {
						BarBackgroundColor = Color.Black,
						BarTextColor = Color.White,
					};

					this.Navigation.PushModalAsync(selector,false);
					NavigationPage.SetTitleIcon (this, "corning_logo.png"); 

					this.Children.Add (new HomeView (){
						Title = Translation.Localize("HomeIcon"),
					});
					this.Children.Add (new LibraryView (){
						Title = Translation.Localize("LibraryIcon"),
					});
					this.Children.Add (new NewsletterView (){
						Title = Translation.Localize("NewsLetterIcon"),
					});
					this.Children.Add (new MyDocumentsView (){
						Title = Translation.Localize("MyDocsIcon"),
					});
					this.Children.Add (new SettingsView (){
						Title = Translation.Localize("SettingsIcon"),
					});
						
				},
				WinPhone: () => {
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
			);
				
		}


	}
}



