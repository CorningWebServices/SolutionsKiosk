using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;

using MediandoUI;
using Mediando.iOS;

using UIKit;

using Xamarin.Forms;
using System.IO;

[assembly: ExportRenderer(typeof(VideoView), typeof(VideoViewRenderer))]

namespace Mediando.iOS
{
	using CoreGraphics;
	using MediaPlayer;
	using Xamarin.Forms.Platform.iOS;

	class VideoViewRenderer : PageRenderer
	{
		MPMoviePlayerController moviePlayer;
		UITabBarController rootController;
		double screenWidth;
		double screenHeight;

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);
			View.BackgroundColor = UIColor.Black;
			var page = e.NewElement as VideoView;
			var fileItem = page.FileItem;


			UIWindow window = UIApplication.SharedApplication.KeyWindow;
			rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [1].TabBarController;
			rootController.TabBar.Hidden = true;

			moviePlayer = new MPMoviePlayerController();
			if (fileItem.FilePath.StartsWith ("http")) {
				var url =  new NSUrl(fileItem.FilePath);
				moviePlayer.ContentUrl = url;
			} else {
				var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				var directoryname = Path.Combine (documents, "Downloads");
				var path = Path.Combine (directoryname, fileItem.FilePath);

				moviePlayer.ContentUrl = NSUrl.FromFilename (path);
			}
			//moviePlayer.View.Frame = new CGRect((float)((NativeView.Bounds.Width - 600) / 2), (float)((NativeView.Bounds.Height - 450) / 2), 600, 400);
			screenWidth = (int)UIScreen.MainScreen.Bounds.Width;
			screenHeight = (int)UIScreen.MainScreen.Bounds.Height;
			moviePlayer.View.Frame = new CGRect(0, 0, screenWidth, screenHeight);


			MPMoviePlayerController.Notifications.ObserveLoadStateDidChange(OnLoadStateChanged);
			MPMoviePlayerController.Notifications.ObservePlaybackDidFinish(OnPlaybackComplete);


			View.AddSubview(moviePlayer.View);


			moviePlayer.PrepareToPlay();
			moviePlayer.ShouldAutoplay = true;
			//moviePlayer.SetFullscreen (true, true);
			moviePlayer.ControlStyle = MPMovieControlStyle.Fullscreen;
			moviePlayer.Play();
		}

		private void OnLoadStateChanged(object sender, NSNotificationEventArgs e)
		{
			if (moviePlayer.LoadState == MPMovieLoadState.Playable)
			{

			}
		}

		private void OnPlaybackComplete(object sender, MPMoviePlayerFinishedEventArgs e)
		{
			UIWindow window = UIApplication.SharedApplication.KeyWindow;
			//var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [1].TabBarController;
			rootController.TabBar.Hidden = false;
			try
			{
				this.NavigationController.PopViewController (true);
			}
			catch
			{

			}
		}

		public override void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			screenWidth = (int)UIScreen.MainScreen.Bounds.Width;
			screenHeight = (int)UIScreen.MainScreen.Bounds.Height;
			moviePlayer.View.Frame = new CGRect(0, 0, screenWidth, screenHeight);
		}


	}
}