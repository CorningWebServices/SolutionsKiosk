
using System;

using Foundation;
using UIKit;
using MediaPlayer;
using CoreGraphics;

namespace Mediando.iOS
{
	public class VideoViewController : UIViewController
	{
		MPMoviePlayerController moviePlayer;
		string MediaFile;

		public VideoViewController (string file)
		{
			MediaFile = file;
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//this.ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation.LandscapeRight);
			UIWindow window = UIApplication.SharedApplication.KeyWindow;
			var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [1];
			rootController.TabBarController.TabBar.Hidden = true;

			this.NavigationController.NavigationBarHidden = true;

			moviePlayer = new MPMoviePlayerController (new NSUrl (MediaFile));
			MPMoviePlayerController.Notifications.ObserveLoadStateDidChange(OnLoadStateChanged);
			MPMoviePlayerController.Notifications.ObservePlaybackDidFinish(OnPlaybackComplete);

			//moviePlayer.View.Frame = new CGRect((float)((this.View.Bounds.Width - 600) / 2), (float)((this.View.Bounds.Height - 450) / 2), 600, 400);



			View.AddSubview (moviePlayer.View);

			moviePlayer.PrepareToPlay();
			moviePlayer.ShouldAutoplay = true;
			moviePlayer.ControlStyle = MPMovieControlStyle.Fullscreen;
			moviePlayer.SetFullscreen (true, true);
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
			this.NavigationController.PopViewController (true);
		}
			
	}
}
