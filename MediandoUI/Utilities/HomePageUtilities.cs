using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public static class HomePageButtons //: ViewCell
	{

		public static Grid GetHomePageTextButtons (ImageSource ImageSource, string MainText, string DetailsText)
		{
			var contentProfileImage = new Image {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Start,
				Source = ImageSource,
			};

			var mainLabel = new Label () {
				FontSize = UIConstants.GetHomePageFontSize(),
				TextColor = Color.White,
				Text = MainText
			};

			var detailsLabel = new Label () {
				FontSize = UIConstants.GetHomePageFontSize(),
				TextColor = Color.White,
				Text = DetailsText,
				LineBreakMode = LineBreakMode.WordWrap,
			};
				
			var mainLayout = new StackLayout {
				Padding= new Thickness(5,0,0,0),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				Children = { 
					mainLabel, 
					detailsLabel 
				}
			};

			var tapImage = new Image () {
				Source = ImageConstants.nextIcon,
				HorizontalOptions = LayoutOptions.End,
			};
				
			Grid grid = new Grid {
				VerticalOptions = LayoutOptions.Center,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = GridLength.Auto },
				}
			};



			grid.Children.Add (contentProfileImage, 0, 0);
			grid.Children.Add (mainLayout, 1, 0);
			grid.Children.Add (tapImage, 2, 0);

			if (GlobalVariables.CurrentLocale.StartsWith("en")) {
				if (Device.Idiom == TargetIdiom.Phone) {
					if (App.CurrentDevice == IOSDevices.IPhone4S) {
						grid.Padding = new Thickness (0, 0, 0, 5);

					} else if (App.CurrentDevice == IOSDevices.IPhone5) {
						grid.Padding = new Thickness (0, 0, 0, 10);

					} else if (App.CurrentDevice == IOSDevices.IPhone5S) {
						grid.Padding = new Thickness (0, 0, 0, 10);

					} else if (App.CurrentDevice == IOSDevices.IPhone6) {
						grid.Padding = new Thickness (0, 0, 0, 20);

					} else if (App.CurrentDevice == IOSDevices.IPhone6Plus) {
						grid.Padding = new Thickness (0, 0, 0, 20);

					} 
					else {
						grid.Padding = new Thickness (0, 0, 0, 20);
					}
				} 
				else {
					grid.Padding = 30;
				}
			} else {
				if (Device.Idiom == TargetIdiom.Phone) {
					if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
						grid.Padding = 0;
					} else if (App.CurrentDevice == IOSDevices.IPhone6) {
						grid.Padding = new Thickness (0, 0, 0, 0);

					} else if (App.CurrentDevice == IOSDevices.IPhone6Plus) {
						grid.Padding = new Thickness (0, 0, 0, 5);

					} 
					else {
						grid.Padding = new Thickness (0, 0, 0, 0);
					}
				} 
				else {
					grid.Padding = 30;
				}
			}


			return grid;
		}

		public static Frame CreateEMEAHomeButton (ImageSource ImageSource, string Description)
		{

			var contentProfileImage = new Image {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Source = ImageSource,

			};


			Label lblDescription = new Label {
				Text = Description,
				FontSize = UIConstants.GetHomePageFontSize(),
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.White,
			};

			Image next = new Image {
				Source = ImageConstants.nextIcon,
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center,
			};
				
			var stackedButtons = new StackLayout { 
				//Padding = 10,
				HorizontalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					lblDescription,
					next
				}
			};

			Grid grid = new Grid {
				VerticalOptions = LayoutOptions.End,
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};



			var stack = new StackLayout { 
				HorizontalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					contentProfileImage,
					stackedButtons
				}
			};

			grid.Children.Add (stack, 0, 0);


			var frame = new Frame {
				OutlineColor = ColorConstants.SemiOpaqueOutline,
				HasShadow = true,
				HorizontalOptions = LayoutOptions.Center,
				BackgroundColor = ColorConstants.SemiOpaqueBackground,
				VerticalOptions = LayoutOptions.Center,
				//Padding = 10,
				Content = new StackLayout {
					Children = {
						grid
					}
				}
			};

			if (Device.Idiom != TargetIdiom.Phone) {
				frame.WidthRequest = 250;
			}
			return frame;
		}
	}
}



