using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public static class ImageConstants
	{
		public static readonly string backgroundImage = 
			Device.OnPlatform
			(
				//iOS: App.CurrentDevice == IOSDevices.IPhone5 ? "Images/background@2x.png" : "Images/background.png",
				iOS: "background.jpg",
				Android: "Images/bg.jpg",
				WinPhone: "Images/bg.jpg"
			);

		public static readonly string landscapebackground = 
			Device.OnPlatform
			(
						//iOS: App.CurrentDevice == IOSDevices.IPhone5 ? "Images/background@2x.png" : "Images/background.png",
				iOS: "landscapebg.jpg",
				Android: "Images/bg.jpg",
				WinPhone: "Images/bg.jpg"
			);
		
		public static readonly string nextIcon = 
			Device.OnPlatform
			(
				iOS: "next.png",
				Android: "Images/nextdr.png",
				WinPhone: "Images/next.png"
			);

		public static readonly string homeIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/home.png",
				Android: "Images/homedr.png",
				WinPhone: "Images/home.png"
			);

		public static readonly string libraryIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/library.png",
				Android: "Images/librarydr.png",
				WinPhone: "Images/library.png"
			);

		public static readonly string newsIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/newsletter.png",
				Android: "Images/newsdr.png",
				WinPhone: "Images/news.png"
			);

		public static readonly string documentsIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/mydocuments.png",
				Android: "Images/documentsdr.png",
				WinPhone: "Images/documents.png"
			);

		public static readonly string settingsIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/settings.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);


		public static readonly string library32Icon = 
			Device.OnPlatform
			(
				iOS: "libraryinvert.png",
				Android: "Images/librarydr.png",
				WinPhone: "Images/library.png"
			);

		public static readonly string libraryhomeIcon = 
			Device.OnPlatform
			(
				iOS: "librarynew.png",
				Android: "Images/librarydr.png",
				WinPhone: "Images/library.png"
			);

		public static readonly string news32Icon = 
			Device.OnPlatform
			(
				iOS: "newsletter.png",
				Android: "Images/newsdr.png",
				WinPhone: "Images/news.png"
			);

		public static readonly string documents32Icon = 
			Device.OnPlatform
			(
				iOS: "mydocumentsinvert.png",
				Android: "Images/documentsdr.png",
				WinPhone: "Images/documents.png"
			);

		public static readonly string about32icon = 
			Device.OnPlatform
			(
				iOS: "about.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);

		public static readonly string websitesIcon = 
			Device.OnPlatform
			(
				iOS: "website.png",
				Android: "Images/documentsdr.png",
				WinPhone: "Images/documents.png"
			);

		public static readonly string catalogIcon = 
			Device.OnPlatform
			(
				iOS: "libraryinvert.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);

		public static readonly string listIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/hamburger.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);
		
		public static readonly string tiledIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/tiled.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);

		public static readonly string englishIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/english.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);

		public static readonly string flagIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/flag.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);

		public static readonly string germanIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/german.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);

		public static readonly string languageIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/language.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);

		public static readonly string searchIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/search.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);

		public static readonly string filterIcon = 
			Device.OnPlatform
			(
				iOS: "New/filter.png",
				Android: "Images/settingsdr.png",
				WinPhone: "Images/settings.png"
			);


	}
}



//using System;
//using Xamarin.Forms;
//
//namespace MediandoUI
//{
//	public static class ImageConstants
//	{
//		public static readonly string backgroundImage =
//			Device.OnPlatform
//			(
//				//iOS: App.CurrentDevice == IOSDevices.IPhone5 ? "Images/background@2x.png" : "Images/background.png",
//				iOS: "background.png",
//				Android: "Images/bg.jpg",
//				WinPhone: "Images/bg.jpg"
//			);
//
//		public static readonly string landscapebackground =
//			Device.OnPlatform
//			(
//				//iOS: App.CurrentDevice == IOSDevices.IPhone5 ? "Images/background@2x.png" : "Images/background.png",
//				iOS: "landscapebg.png",
//				Android: "Images/bg.jpg",
//				WinPhone: "Images/bg.jpg"
//			);
//
//
//		public static readonly string nextIcon =
//			Device.OnPlatform
//			(
//				iOS: "next.png",
//				Android: "Images/nextdr.png",
//				WinPhone: "Images/next.png"
//
//			);
//
//		public static readonly string homeIcon =
//			Device.OnPlatform
//			(
//				iOS: "start.png",
//				Android: "Images/homedr.png",
//				WinPhone: "Images/home.png"
//			);
//
//		public static readonly string libraryIcon =
//			Device.OnPlatform
//			(
//				iOS: "library.png",
//				Android: "Images/librarydr.png",
//				WinPhone: "Images/library.png"
//			);
//
//		public static readonly string newsIcon =
//			Device.OnPlatform
//			(
//				iOS: "newsletter.png",
//				Android: "Images/newsdr.png",
//				WinPhone: "Images/news.png"
//			);
//
//		public static readonly string documentsIcon =
//			Device.OnPlatform
//			(
//				iOS: "mydocuments.png",
//				Android: "Images/documentsdr.png",
//				WinPhone: "Images/documents.png"
//			);
//
//		public static readonly string settingsIcon =
//			Device.OnPlatform
//			(
//				iOS: "settings.png",
//				Android: "Images/settingsdr.png",
//				WinPhone: "Images/settings.png"
//			);
//
//
//		public static readonly string library32Icon =
//			Device.OnPlatform
//			(
//				iOS: "libraryinvert.png",
//				Android: "Images/librarydr.png",
//				WinPhone: "Images/library.png"
//			);
//
//		public static readonly string news32Icon =
//			Device.OnPlatform
//			(
//				iOS: "newsletterinvert.png",
//				Android: "Images/newsdr.png",
//				WinPhone: "Images/news.png"
//			);
//
//		public static readonly string documents32Icon =
//			Device.OnPlatform
//			(
//				iOS: "mydocumentsinvert.png",
//				Android: "Images/documentsdr.png",
//				WinPhone: "Images/documents.png"
//			);
//
//		public static readonly string about32icon =
//			Device.OnPlatform
//			(
//				iOS: "about.png",
//				Android: "Images/settingsdr.png",
//				WinPhone: "Images/settings.png"
//			);
//
//		public static readonly string websitesIcon =
//			Device.OnPlatform
//			(
//				iOS: "website.png",
//				Android: "Images/documentsdr.png",
//				WinPhone: "Images/documents.png"
//			);
//
//		public static readonly string catalogIcon =
//			Device.OnPlatform
//			(
//				iOS: "catalog.png",
//				Android: "Images/settingsdr.png",
//				WinPhone: "Images/settings.png"
//			);
//	}
//}
//
