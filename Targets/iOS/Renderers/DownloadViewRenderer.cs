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

[assembly: ExportRenderer(typeof(DownloadViewer), typeof(DownloadViewRenderer))]

namespace Mediando.iOS
{
	using CoreGraphics;
	using MediaPlayer;
	using Xamarin.Forms.Platform.iOS;

	class DownloadViewRenderer : PageRenderer
	{
		MPMoviePlayerController moviePlayer;
		double screenWidth;
		double screenHeight;

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var page = e.NewElement as DownloadViewer;
			var fileItem = page.FileItem;

			UIWindow window = UIApplication.SharedApplication.KeyWindow;
			var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [3].TabBarController;
			rootController.TabBar.Hidden = true;

			//var url = new NSUrl.FromFilename (new Uri (fileItem.FilePath).ToString ());
			moviePlayer = new MPMoviePlayerController();
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (documents, "Downloads");
			var path = Path.Combine (directoryname, fileItem.FilePath);

			moviePlayer.ContentUrl = NSUrl.FromFilename (path);

			screenWidth = (int)UIScreen.MainScreen.Bounds.Width;
			screenHeight = (int)UIScreen.MainScreen.Bounds.Height;

			//moviePlayer.View.Frame = new CGRect(0,(NativeView.Bounds.Height - 300)/2,NativeView.Bounds.Width,300);
			moviePlayer.View.Frame = new CGRect(0, 0, screenWidth, screenHeight);

			MPMoviePlayerController.Notifications.ObserveLoadStateDidChange(OnLoadStateChanged);
			MPMoviePlayerController.Notifications.ObservePlaybackDidFinish(OnPlaybackComplete);

			var overlayView = moviePlayer.View;
			View.AddSubview(overlayView);
			//View.AddSubview(moviePlayer.View);
			List<NSLayoutConstraint> constraints = new List<NSLayoutConstraint>();
			constraints.Add (NSLayoutConstraint.Create (View, NSLayoutAttribute.Top, NSLayoutRelation.Equal, overlayView, NSLayoutAttribute.Top, 1f, 0));
			constraints.Add (NSLayoutConstraint.Create (View, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, overlayView, NSLayoutAttribute.Bottom, 1f, -0));
			constraints.Add (NSLayoutConstraint.Create (View, NSLayoutAttribute.Left, NSLayoutRelation.Equal, overlayView, NSLayoutAttribute.Left, 1f, 0));
			constraints.Add (NSLayoutConstraint.Create (View, NSLayoutAttribute.Right, NSLayoutRelation.Equal, overlayView, NSLayoutAttribute.Right, 1f, -0));

			View.AddConstraints (constraints.ToArray ());

			moviePlayer.PrepareToPlay();
			moviePlayer.ShouldAutoplay = true;
			moviePlayer.SetFullscreen (true, true);
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
			var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [3].TabBarController;
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