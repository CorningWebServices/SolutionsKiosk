using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MediandoUI
{

	public class AboutCorning : ContentPage
	{
		IEnumerable<CorningLinks> data;
		readonly ListView listView;
		readonly StackLayout headerLayout;

		public AboutCorning ()
		{
			//NavigationPage.SetTitleIcon (this, "corning_logo.png"); 
			//NavigationPage.SetHasNavigationBar (this, false);
			NavigationPage.SetBackButtonTitle(this,Translation.Localize("BackButton"));

			listView = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(ListViewCellTemplate)),
				SeparatorColor = Color.Transparent,
			};

			headerLayout = new StackLayout { 
				Children = {
					new Image { 
						//BackgroundColor = Color.FromHex("#006699"),
						Source = "corningimages/corninglogo.png",
						WidthRequest = 200,
						HeightRequest = 200
					}
				}
			};
			listView.Header = headerLayout;
			

			listView.BackgroundColor = Color.Transparent;

			listView.ItemTapped += (sender, e) => {
				if (e.Item != null) {
					var fileItem = ((CorningLinks)listView.SelectedItem);
					listView.SelectedItem = null;
					var page = (Page)Activator.CreateInstance (typeof(WebPage), fileItem);
					this.Navigation.PushAsync (page, true);
				}
			};


			Content = new StackLayout { 
				Padding = 0,
				Children = {
					ControlUtilities.GetAppHeader (),
					GetBreadCrumbs (),
					listView
				},
			};
			this.BackgroundImage = ImageConstants.backgroundImage;
		}

		protected StackLayout GetBreadCrumbs ()
		{

			var home = new Button {
				Text = Translation.Localize ("HomeIcon"),
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Button))
					: Device.GetNamedSize (NamedSize.Large, typeof(Button)),
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
			};

			home.Clicked += (sender, args) => {
				this.Navigation.PopAsync ();
			};

			var spacer = new Label {
				Text = " | ",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Label))
					: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
			};

			var library = new Label {
				Text = Translation.Localize ("AboutCorning"),
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Label))
					: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
			};


			return new StackLayout {
				BackgroundColor = Color.White,
				Padding = new Thickness (10, 0, 0, 0),
				HeightRequest = 25,
				Orientation = StackOrientation.Horizontal,
				Children = {
					home,
					spacer,
					library
				}
			};
		}


		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			App.ShowAppSelection = false;
			var masterPage = this.Parent.Parent as TabbedPage;
			masterPage.Children [0].Title = Translation.Localize ("HomeIcon");

			var fileInfo = new Library ();
			data = fileInfo.AboutCorningAsync (GlobalVariables.AppSelectedLanguage);
			Device.BeginInvokeOnMainThread (() => {
				listView.ItemsSource = data;

			});

		}

		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height); // Important!

			if (width > height) {
				this.BackgroundImage = ImageConstants.landscapebackground;
				if (Device.Idiom == TargetIdiom.Phone) {
					listView.Header  = new StackLayout ();
				}
			} else {
				this.BackgroundImage = ImageConstants.backgroundImage;
				listView.Header = headerLayout;
			}
		}
	}
}


