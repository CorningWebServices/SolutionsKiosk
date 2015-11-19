using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public abstract class BaseContentPage : ContentPage
	{
		//BackgroundImage = UIImage.FromBundle ("dessert.jpg");
		protected MediandoDatabase db = App.Database;


		protected Frame CreateLoadingIndicator()
		{
			var loadingIndicator = new ActivityIndicator
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Scale = 2,
				Color = Color.White
			};


			var label = new Label {
				Text = Translation.Localize("LoadingText"),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};
				
			var frame = new Frame {
				OutlineColor = ColorConstants.SemiOpaqueOutline,
				HasShadow = true,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				BackgroundColor = Color.Black,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Padding = 20,
				Content = new StackLayout {
					WidthRequest = 100,
					HeightRequest = 80,
					Children = {
						loadingIndicator,
						label
					}
				}
			};

			frame.SetBinding(VisualElement.IsVisibleProperty, "IsRunning");
			loadingIndicator.SetBinding(ActivityIndicator.IsRunningProperty, "IsRunning");
			loadingIndicator.SetBinding(VisualElement.IsVisibleProperty, "IsRunning");

			return  frame;
		}

		protected Frame ShowEmptyResults()
		{
			var label = new Label {
				Text = Translation.Localize("NoResultsText"),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			var frame = new Frame {
				OutlineColor = ColorConstants.SemiOpaqueOutline,
				HasShadow = true,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				BackgroundColor = Color.Black,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Padding = 20,
				Content = new StackLayout {
					WidthRequest = 100,
					HeightRequest = 80,
					Children = {
						label
					}
				}
			};

			frame.SetBinding(VisualElement.IsVisibleProperty, "IsEmpty");

			return  frame;
		}
			

		public string SelectedCategory {
			get;
			set;
		}


	}
}
