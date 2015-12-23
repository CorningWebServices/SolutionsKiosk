using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public class MediandoTabs
	{
		public MediandoTabs (string name, string icon, string page)
		{
			this.Name = name;
			this.Icon = icon;
			this.Page = page;
		}

		public string Name { private set; get; }

		public string Icon { private set; get; }

		public string Page { private set; get; }

		public override string ToString ()
		{
			return Name;
		}
	}

	public static class ControlUtilities
	{

		public static Frame AppButton (string MainHeader, string SubHeader, string details)
		{
			Label header1 = new Label {
				Text = MainHeader,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.White,
				FontAttributes = FontAttributes.Bold,
				FontSize = UIConstants.GetAppSelectorHeaderFonts(),
			}; 

			Label header2 = new Label {
				Text = string.Format("\n{0}",SubHeader),
				FontSize = UIConstants.GetAppSelectorHeaderFonts(),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.FromHex("#006699"),
				FontAttributes = FontAttributes.Bold,
			};

			Label header3 = new Label {
				Text = details,
				FontSize = UIConstants.GetAppSelectorHeaderFonts(),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.White,
			};

			Image next = new Image {
				Source = ImageConstants.nextIcon,
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.End,
			};

			if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
				next.WidthRequest = 18;
			}

			var button = new StackLayout {
				Padding = UIConstants.GetAppSelectorPadding (),
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions=LayoutOptions.Start,
				Children = {
					header1,
					header2,
					header3,
				}
			};


			var frame = new Frame {
				OutlineColor = ColorConstants.SemiOpaqueOutline,
				BackgroundColor = ColorConstants.SemiOpaqueBackground,
				HasShadow = true,
				Padding = 2,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Content = new StackLayout {
					Orientation = StackOrientation.Horizontal,
					Children = {
						button,
						next
					}
				}
			};

		

			return frame;
		}



		public static StackLayout GetAppHeader ()
		{
			var logo = new Image {
				Source = Device.OnPlatform
					(
						iOS: "corningimages/corning_logo.png",
						Android: "corning_logo.png",
						WinPhone: "corning_logo.png"
					),
				//HeightRequest = UIConstants.GetLogoSize(),
				//WidthRequest = UIConstants.GetLogoSize(),
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand
			};

			Grid header = new Grid {
				VerticalOptions = LayoutOptions.Center,
				//Padding = new Thickness (2, 0, 0, 10),
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star)  },
				},
			};
				
			header.Children.Add (logo, 0, 0);

			return new StackLayout {
				BackgroundColor = Color.Black,
				VerticalOptions = LayoutOptions.Center,
				Padding = new Thickness (10, Device.OnPlatform (25,5,5), 5, 5),
				Children = {
					header
				}
			};


		}

		public static Frame TrialAppButton (string MainHeader, string SubHeader, string details)
		{
			Label header1 = new Label {
				Text = MainHeader,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.White,
				//FontAttributes = FontAttributes.Bold,
				FontSize = UIConstants.GetAppSelectorHeaderFonts(),
			}; 

			Label header2 = new Label {
				Text = string.Format("\n{0}",SubHeader),
				FontSize = UIConstants.GetAppSelectorHeaderFonts(),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.FromHex("#006699"),
				//FontAttributes = FontAttributes.Bold,
			};

			Image next = new Image {
				Source = ImageConstants.nextIcon,
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.End,
			};

			if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
				next.WidthRequest = 18;
			}



			var button2 = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = {
					header2,
					next
				}
			};


			var frame = new Frame {
				OutlineColor = ColorConstants.SemiOpaqueOutline,
				BackgroundColor = ColorConstants.SemiOpaqueBackground,
				HasShadow = true,
				Padding = 2,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Content = new StackLayout {
					Orientation = StackOrientation.Vertical,
					Padding = UIConstants.GetAppSelectorPadding (),
					Children = {
						header1,
						button2
					}
				}
			};



			return frame;
		}
	}
}

