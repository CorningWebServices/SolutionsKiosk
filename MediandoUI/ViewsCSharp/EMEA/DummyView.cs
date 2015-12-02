using System;
using System.Threading;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace MediandoUI
{

	public class DummyView : BaseContentPage
	{
		Grid grid;

		protected BaseViewModel ViewModel {
			get { return BindingContext as BaseViewModel; }
			set { BindingContext = value; }
		}

		public DummyView ()
		{
			BindingContext = new BaseViewModel ();
			//ViewModel.IsRunning = true;
			NavigationPage.SetHasNavigationBar (this, false);
			this.BackgroundImage = ImageConstants.backgroundImage;	

			grid = new Grid {
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			var list = new ListView {
				HasUnevenRows = true,
				SeparatorColor = Color.Transparent,
			};
			list.BackgroundColor = Color.Transparent;
			Device.OnPlatform 
			(
				iOS: () => { 
					grid.Children.Add (ControlUtilities.GetAppHeader (), 0, 0);
					grid.Children.Add (list, 0, 1);
					grid.Children.Add (CreateLoadingIndicator (), 0, 1);
				},
				Android: () => {
					//grid.Children.Add (ControlUtilities.GetAppHeader (), 0, 0);
					grid.Children.Add (list, 0, 1);
					grid.Children.Add (CreateLoadingIndicator (), 0, 1);
				},
				WinPhone: () => {
					//grid.Children.Add (ControlUtilities.GetAppHeader (), 0, 0);
					grid.Children.Add (list, 0, 1);
					grid.Children.Add (CreateLoadingIndicator (), 0, 1);
				}
			);
				
			Content = grid;
		}

		protected async override void OnAppearing ()
		{
			base.OnAppearing ();
			ViewModel.IsRunning = true;
			while (GlobalVariables.IsDownloadingData) {
				await Task.Delay (1000);
			}

			ViewModel.IsRunning = false;
			if (App.ShowAppSelection) {
				await Navigation.PushModalAsync (new AppSelectorView (), true);
			} else {
				await Navigation.PushAsync (new HomeView (), false);
			}
		}

		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height); // Important!
			if (grid.WidthRequest != width) {
				grid.WidthRequest = width;
				if (width > height) {
					this.BackgroundImage = ImageConstants.landscapebackground;
				} else {
					this.BackgroundImage = ImageConstants.backgroundImage;
				}
			}
		}
	}
}


