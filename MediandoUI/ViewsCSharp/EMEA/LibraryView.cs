using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MediandoUI
{

	public class LibraryView : BaseContentPage
	{

		ListView categories;
		Grid grid;
		StackLayout headerLayout;

		protected LibraryViewModel ViewModel {
			get { return BindingContext as LibraryViewModel; }
			set { BindingContext = value; }
		}

		public LibraryView ()
		{
			NavigationPage.SetHasNavigationBar (this, false);
			NavigationPage.SetBackButtonTitle(this,Translation.Localize("BackButton"));
			BindingContext = new LibraryViewModel ();
			ViewModel.IsRunning = true;

			 grid = new Grid {
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			grid.Children.Add (ControlUtilities.GetAppHeader (), 0, 0);
			grid.Children.Add (GetBreadCrumbs(), 0, 1);
			grid.Children.Add (CreateLibraryListView(), 0, 2);
			grid.Children.Add (CreateLoadingIndicator(), 0, 2);
			grid.Children.Add (ShowEmptyResults(), 0, 2);

			Content = grid;


			this.BackgroundImage = ImageConstants.backgroundImage;
		}



		private ListView CreateLibraryListView ()
		{
			categories = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(LibraryCellTemplate)),
				SeparatorColor = Color.Transparent,
			};

			var headerimage = new Image (); 

			if (Device.Idiom == TargetIdiom.Phone) {
				headerimage.Source = Translation.Localize ("CorningLibraryImagePhone");
				if (App.CurrentDevice == IOSDevices.IPhone4S
					|| App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					headerimage.HeightRequest = 130;
				} else {

					headerimage.HeightRequest = 150;
				} 
			} else {
				headerimage.Source  = Translation.Localize("CorningLibraryImagePad");
			}

			headerLayout = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				Children = {
					headerimage
				}
			};
			categories.Header = headerLayout;

			categories.BackgroundColor = Color.Transparent;

			CreateEventHandlers (categories);
			return categories;
		}

		private void CreateEventHandlers (ListView listView)
		{
			listView.ItemTapped += (sender, e) => {
				((ListView)sender).SelectedItem = null;
			};
			listView.ItemSelected += (sender, e) => {
				if (e.SelectedItem == null)
					return;

				var item = (Category)e.SelectedItem;
				GlobalVariables.SelectedCategory = item.CategoryName;
				GlobalVariables.SelectedCategoryCode = item.CategoryCode;

				Navigation.PushAsync (new LibraryDetailsView ());
			};
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			var masterPage = this.Parent.Parent as TabbedPage;
			masterPage.Children [0].Title = Translation.Localize ("HomeIcon");

			if (ViewModel == null || ViewModel.IsLoading)
				return;
			ViewModel.LoadItemsCommand.Execute (null);

			Device.BeginInvokeOnMainThread (() => {
				try {


					categories.ItemsSource = ViewModel.LibraryCategory;
					ViewModel.IsRunning = false;
				} catch (Exception) {
					DisplayAlert ("Error", "Refresh the form.", "Ok");
				}

			});

		}

		protected StackLayout GetBreadCrumbs ()
		{

			var home = new Button {
				Text = Translation.Localize("HomeIcon"),
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Button))
					: Device.GetNamedSize (NamedSize.Large, typeof(Button)),
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
			};

			home.Clicked += (sender, args) => {
				var masterPage = this.Parent.Parent as TabbedPage;
				masterPage.Children [0].Title =  Translation.Localize ("StartIcon");
				masterPage.CurrentPage = masterPage.Children [0];
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
				Text = Translation.Localize("LibraryIcon"),
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

		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); // Important!
			if ((int)grid.WidthRequest != (int)width) {
				grid.WidthRequest = width;
				grid.HeightRequest = height;

				if (width > height) {
					this.BackgroundImage = ImageConstants.landscapebackground;
					if (Device.Idiom == TargetIdiom.Phone) {
						categories.Header = new StackLayout ();
					}
				} else {
					this.BackgroundImage = ImageConstants.backgroundImage;
					categories.Header = headerLayout;
				}

			}

		}

	}

	public class LibraryCellTemplate : ViewCell
	{
		public LibraryCellTemplate ()
		{
			var nameLabel = new Label () {
				FontSize = UIConstants.GetHomePageFontSize(),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Center,
			};
			nameLabel.SetBinding (Label.TextProperty, "CategoryName");


			var tapImage = new Image () {
				Source = ImageConstants.nextIcon,
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center,
			};

//			if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
//				tapImage.WidthRequest = 18;
//			}

			Grid grid = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = GridLength.Auto },
				}
			};


			grid.Children.Add (nameLabel, 0, 0);
			grid.Children.Add (tapImage, 1, 0);


			var frame = new Frame {
				OutlineColor = ColorConstants.SemiOpaqueOutline,
				HasShadow = true,
				HorizontalOptions = LayoutOptions.Center,
				BackgroundColor = ColorConstants.SemiOpaqueBackground,
				VerticalOptions = LayoutOptions.Center,
				Content = new StackLayout {
					Padding = 0,
					Children = {
						grid
					}
				}
			};

			if(Device.Idiom == TargetIdiom.Phone){
				frame.Padding = 5;
			}
			else{
				frame.Padding = 10;
			}


			this.View = frame;
		}
	}
}


