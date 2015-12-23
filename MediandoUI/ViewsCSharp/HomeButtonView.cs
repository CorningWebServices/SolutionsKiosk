using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public class HomeButtonView : Frame
	{
		
		public Frame HomeButtonView (string MainHeader, string SubHeader, string details)
		{
			Label label = new Label {
				Text = MainHeader,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.White,
			};

			Label tinyLabel = new Label {
				Text = SubHeader,
				FontSize = Device.GetNamedSize (NamedSize.Micro, typeof(Label)),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.Blue,
			};

			Label tinydetailsLabel = new Label {
				Text = details,
				FontSize = Device.GetNamedSize (NamedSize.Micro, typeof(Label)),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.White,
			};

			//this.Padding = new Thickness (3);
			var frame = new Frame {
				OutlineColor = Color.FromRgba(255,255,255,0.1),
				BackgroundColor = Color.FromRgba(255,255,255,0.1),
				//Padding = new Thickness (5, 10, 5, 0),
				Content = new StackLayout {
					Spacing = 0,
					Children = {
						label,
						tinyLabel,
						tinydetailsLabel
					}
				}
			};



			//this.Content = frame;



			// Don't let touch pass us by.
			this.BackgroundColor = Color.Transparent;
			return frame;
		}
	}
}

