using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public class AndroidVideoPlayer : ContentPage
	{
		private VideoPlayerView player;


		public AndroidVideoPlayer (ProductCatalog fileItem)
		{
			player = new VideoPlayerView ();
			NavigationPage.SetBackButtonTitle (this, Translation.Localize ("BackButton"));
//			this.ToolbarItems.Add (new ToolbarItem {
//				Order = ToolbarItemOrder.Secondary,
//				Text = "Controller",
//				Command = new Command( () => {
//					this.player.VideoPlayer.AddVideoController = !this.player.VideoPlayer.AddVideoController;
//				})
//			});
//
//			this.ToolbarItems.Add (new ToolbarItem {
//				Order = ToolbarItemOrder.Secondary,
//				Text = "Full Screen",
//				Command = new Command( () => {
//
//					// resize the Content for full screen mode
//					this.player.VideoPlayer.FullScreen = !this.player.VideoPlayer.FullScreen;
//					if (this.player.VideoPlayer.FullScreen)
//					{
//						this.player.HeightRequest = -1;
//						this.Content.VerticalOptions = LayoutOptions.FillAndExpand;
//						player.VideoPlayer.FullScreen = true;
//					}
//					else
//					{
//						this.player.HeightRequest = 200;
//						this.Content.VerticalOptions = LayoutOptions.StartAndExpand;
//						player.VideoPlayer.FullScreen = false;
//					}
//				})
//			});
//
//			this.ToolbarItems.Add (new ToolbarItem {
//				Order = ToolbarItemOrder.Secondary,
//				Text = "Play",
//				Command = new Command( () => {
//					this.player.VideoPlayer.PlayerAction = VideoState.PLAY;
//				})
//			});
//
//			this.ToolbarItems.Add (new ToolbarItem {
//				Order = ToolbarItemOrder.Secondary,
//				Text = "Stop",
//				Command = new Command( () => {
//					this.player.VideoPlayer.PlayerAction = VideoState.STOP;
//				})
//			});
//
//			this.ToolbarItems.Add (new ToolbarItem {
//				Order = ToolbarItemOrder.Secondary,
//				Text = "Pause",
//				Command = new Command( () => {
//					this.player.VideoPlayer.PlayerAction = VideoState.PAUSE;
//				})
//			});
//
//			this.ToolbarItems.Add (new ToolbarItem {
//				Order = ToolbarItemOrder.Secondary,
//				Text = "Restart",
//				Command = new Command( () => {
//					this.player.VideoPlayer.PlayerAction = VideoState.RESTART;
//				})
//			});

//			// heightRequest must be set it not full screen
//			player.HeightRequest = 200;
//			player.VideoPlayer.AddVideoController = false;

			this.player.HeightRequest = (App.ScreenHeight - 100) / 2;
			//this.Content.VerticalOptions = LayoutOptions.FillAndExpand;
			player.VideoPlayer.FullScreen = false;
			player.VideoPlayer.AddVideoController = true;


			// location in Assets folder.  file marked as Asset, NOT Resource
			player.VideoPlayer.FileSource = fileItem.FilePath;

			// autoplay video
			player.VideoPlayer.AutoPlay = true;

//			TapGestureRecognizer tapAutoHide = new TapGestureRecognizer ();
//			tapAutoHide.Tapped += (sender, args) => {
//				this.player.VideoPlayer.ActionBarHide = !this.player.VideoPlayer.ActionBarHide;
//			};
//			player.VideoPlayer.GestureRecognizers.Add (tapAutoHide);

			this.Content = new StackLayout {				
				VerticalOptions = LayoutOptions.Center,
				Children = 
				{
					player
				}
			};
		}

//		protected override void OnAppearing ()
//		{
//			base.OnAppearing ();
//			this.player.VideoPlayer.PropertyChanged += (object sender, System.ComponentModel.PropertyChangedEventArgs e) => {
//				if (e.PropertyName == MyVideoPlayer.StateProperty.PropertyName)
//				{
//					var s = this.player.VideoPlayer.State;
//					if (s == VideoState.ENDED)
//					{
//						System.Diagnostics.Debug.WriteLine("State: ENDED");
//					}
//					else if (s == VideoState.PAUSE)
//					{
//						System.Diagnostics.Debug.WriteLine("State: PAUSE");
//					}
//					else if (s == VideoState.PLAY)
//					{
//						System.Diagnostics.Debug.WriteLine("State: PLAY");
//					}
//					else if (s == VideoState.STOP)
//					{
//						System.Diagnostics.Debug.WriteLine("State: STOP");
//					}
//				}
//				else if (e.PropertyName == MyVideoPlayer.InfoProperty.PropertyName)
//				{
//					System.Diagnostics.Debug.WriteLine("Info:\r\n" + this.player.VideoPlayer.Info);
//				}
//			};
//		}

		protected override void OnSizeAllocated (double width, double height)
		{
			this.player.VideoPlayer.ContentHeight = height;
			this.player.VideoPlayer.ContentWidth = width;
			if (width < height) {
				this.player.HeightRequest = (App.ScreenHeight - 100) / 2;;
				this.Content.VerticalOptions = LayoutOptions.Center;
				player.VideoPlayer.FullScreen = false;
				player.VideoPlayer.AddVideoController = true;
				this.player.VideoPlayer.Orientation = MyVideoPlayer.ScreenOrientation.PORTRAIT;
			} else {
				this.player.HeightRequest = -1;
				this.Content.VerticalOptions = LayoutOptions.FillAndExpand;
				this.player.VideoPlayer.FullScreen = true;
				this.player.VideoPlayer.Orientation = MyVideoPlayer.ScreenOrientation.LANDSCAPE;
			}
			this.player.VideoPlayer.OrientationChanged ();
			base.OnSizeAllocated (width, height);
		}

	}
}


