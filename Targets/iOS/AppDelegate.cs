using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MediandoUI;
using Autofac;

using PSPDFKit;
//using Connectivity.Plugin;

namespace Mediando.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{

			Forms.Init ();
			FFImageLoading.Forms.Touch.CachedImageRenderer.Init();
		
			PSPDFKitGlobal.SetLicenseKey ("Y3Bqql3OalXRl48bnbk9xtd6ZuDlrCZLUpKIwqZSvsBoeoRcg3pJUv1Mkr4fAn3GZxQIB7xp+Rlqxd+rrorXvolIpe2tXXuYN0Qv+4SlZUbGwePPseh1/Co7pY2nnP0GM9ppHCu/atHaMTB89UgoMtY+SSlNhVaFzHPtCP+lmazOlajqVjGN6YwfrlIb+H4EX66qQqU3+iR6y2XLCrm2IdJ2xDssNifAL0OlpujjCtGQWpLTFy3dGp7Sai5qqwEmnrbFv9TWdNFJ0wr8lOPi6DDBmgD8IzZPz8qfV9xEwiOqHhQ6G91OBKlIetojJcxqYc4x9ZG96TCoym4JRgBiu4p/5WarK5Yw1K4pz7BezsGh3InvD0cv6YnsgulGsQbBLFjAFoWbe+VLuiaMg+f07foklE6Yf5oncn4y46pEB6ZJUkXKqdhfKCb3GiE+77D4pa1+e3ntSYj6aLrdYd4RR3OTx6Ml3cveDIT7c1uFCYYzr95hGgu4NbxImb5tRmat//NXzZqnCVkaWze/szd0d1VsX6imtffJkIuqCjGPifZeL7QWGokN32P5/hxcIK6K");
			//[PSPDFKit sharedInstance][@"com.pspdfkit.development.suppress-warning-alerts"] = @YES;
			App.CurrentDevice = new iOSDeviceInfo ().GetDeviceModel (DeviceHardware.Version);
			App.ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;
			App.ScreenHeight = (int)UIScreen.MainScreen.Bounds.Height;

			LoadApplication (new App());

			return base.FinishedLaunching (app,options);


//			Forms.Init ();
//			//var version = PSPDFKitGlobal.SharedInstance.Version;
//			// Activate PSPDFKit for com.corning.mediando.opcomm
//			//[PSPDFKit setLicenseKey:@"Y3Bqql3OalXRl48bnbk9xtd6ZuDlrCZLUpKIwqZSvsBoeoRcg3pJUv1Mkr4fAn3GZxQIB7xp+Rlqxd+rrorXvolIpe2tXXuYN0Qv+4SlZUbGwePPseh1/Co7pY2nnP0GM9ppHCu/atHaMTB89UgoMtY+SSlNhVaFzHPtCP+lmazOlajqVjGN6YwfrlIb+H4EX66qQqU3+iR6y2XLCrm2IdJ2xDssNifAL0OlpujjCtGQWpLTFy3dGp7Sai5qqwEmnrbFv9TWdNFJ0wr8lOPi6DDBmgD8IzZPz8qfV9xEwiOqHhQ6G91OBKlIetojJcxqYc4x9ZG96TCoym4JRgBiu4p/5WarK5Yw1K4pz7BezsGh3InvD0cv6YnsgulGsQbBLFjAFoWbe+VLuiaMg+f07foklE6Yf5oncn4y46pEB6ZJUkXKqdhfKCb3GiE+77D4pa1+e3ntSYj6aLrdYd4RR3OTx6Ml3cveDIT7c1uFCYYzr95hGgu4NbxImb5tRmat//NXzZqnCVkaWze/szd0d1VsX6imtffJkIuqCjGPifZeL7QWGokN32P5/hxcIK6K");
//			//PSPDFKitGlobal.SetLicenseKey ("Y3Bqql3OalXRl48bnbk9xtd6ZuDlrCZLUpKIwqZSvsBoeoRcg3pJUv1Mkr4fAn3GZxQIB7xp+Rlqxd+rrorXvolIpe2tXXuYN0Qv+4SlZUbGwePPseh1/Co7pY2nnP0GM9ppHCu/atHaMTB89UgoMtY+SSlNhVaFzHPtCP+lmazOlajqVjGN6YwfrlIb+H4EX66qQqU3+iR6y2XLCrm2IdJ2xDssNifAL0OlpujjCtGQWpLTFy3dGp7Sai5qqwEmnrbFv9TWdNFJ0wr8lOPi6DDBmgD8IzZPz8qfV9xEwiOqHhQ6G91OBKlIetojJcxqYc4x9ZG96TCoym4JRgBiu4p/5WarK5Yw1K4pz7BezsGh3InvD0cv6YnsgulGsQbBLFjAFoWbe+VLuiaMg+f07foklE6Yf5oncn4y46pEB6ZJUkXKqdhfKCb3GiE+77D4pa1+e3ntSYj6aLrdYd4RR3OTx6Ml3cveDIT7c1uFCYYzr95hGgu4NbxImb5tRmat//NXzZqnCVkaWze/szd0d1VsX6imtffJkIuqCjGPifZeL7QWGokN32P5/hxcIK6K");
//			//var version = PSPDFKitGlobal.SharedInstance.Version;
//			PSPDFKitGlobal.SetLicenseKey ("blcWhXFIwpatKqQ1FoOb3HyC_2clmIg-rDyAKwQapxIFxDfXqmFqKYedy0oMW94i90ERmUNfPU4B8_V1D6TeTyNmFlL-ICnqWCW5NxT2MW1E_K1RkhWgyqo0rOACe6o5tdoKwwCHLrccRnHzDnGShjYRs9boy2bcZmegG5KIti21WRkkhiUu5kIyRG7DvIOPliWFGMoQI9020S6Ak6j8Nc6abAkVQXAjPFXbEVpFTIIRcD7xGFkEwS6oL7YatYkKYbY94GFRYv6YLedMblRntdMVOPsrSidxOqerjU2Myom9Dxkx5CxvIvWKZLV00cjma_BCy4rgq9GO9ScYytQH1qiyaK8Hyk8oBSAiGhveUP7SAA7uS2CR9ZU0buZ-Cneqli4yw91PHPwRx1GpFItvMw5og157ajhN5UixQJ76T3c=");
//			App.CurrentDevice = new iOSDeviceInfo ().GetDeviceModel (DeviceHardware.Version);
//			App.ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;
//			App.ScreenHeight = (int)UIScreen.MainScreen.Bounds.Height;
//
//			LoadApplication (new App());
//
//			return base.FinishedLaunching (app,options);
		}

//		public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations (UIApplication application, UIWindow forWindow)
//		{
//			if (forWindow != null) {
//				if (forWindow.RootViewController.PresentedViewController is MediaPlayer.MPMoviePlayerViewController &&
//					!forWindow.RootViewController.PresentedViewController.IsBeingDismissed)
//					return UIInterfaceOrientationMask.All;
//			}
//
//			return UIInterfaceOrientationMask.Portrait;
//		}


	}


}

