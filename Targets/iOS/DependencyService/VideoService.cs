using System;
using MediandoUI;
using UIKit;
using Xamarin.Forms;
using Mediando.iOS;


[assembly: DependencyAttribute(typeof(VideoService))]
namespace Mediando.iOS
{
	public class VideoService : IVideoService
	{
		
		public void PlayVideo (LibraryType DocumentType, string MediaURL, Action<bool> completed = null)
		{
			var videoPlayer = new VideoViewController (MediaURL);
			UIWindow window = UIApplication.SharedApplication.KeyWindow;
			if (DocumentType == LibraryType.MyDocuments) {
				var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [1];
				var navcontroller = rootController as UINavigationController;
				if (navcontroller != null) {
					videoPlayer.HidesBottomBarWhenPushed = true;
					navcontroller.PushViewController (videoPlayer, true);
				}
			} else {
				var rootController = window.RootViewController.ChildViewControllers [0].ChildViewControllers [3];
				var navcontroller = rootController as UINavigationController;
				if (navcontroller != null) {
					videoPlayer.HidesBottomBarWhenPushed = true;
					navcontroller.PushViewController (videoPlayer, true);
				}
			}

		}

	}
}

