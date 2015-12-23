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
				Android: "background.jpg",
				WinPhone: "background.jpg"
			);

		public static readonly string landscapebackground = 
			Device.OnPlatform
			(
						//iOS: App.CurrentDevice == IOSDevices.IPhone5 ? "Images/background@2x.png" : "Images/background.png",
				iOS: "landscapebg.jpg",
				Android: "landscapebg.jpg",
				WinPhone: "landscapebg.jpg"
			);
		
		public static readonly string nextIcon = 
			Device.OnPlatform
			(
				iOS: "next.png",
				Android: "next.png",
				WinPhone: "Images/next.png"
			);

		public static readonly string homeIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/home.png",
				Android: "home.png",
				WinPhone: "home.png"
			);

		public static readonly string libraryIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/library.png",
				Android: "library.png",
				WinPhone: "library.png"
			);

		public static readonly string newsIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/newsletter.png",
				Android: "newsletter.png",
				WinPhone: "newsletter.png"
			);

			public static readonly string newshomeIcon = 
			Device.OnPlatform
			(
				iOS: "newsletter.png",
				Android: "newsletterhome.png",
				WinPhone: "newsletterhome.png"
			);

		public static readonly string documentsIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/mydocuments.png",
				Android: "mydocuments.png",
				WinPhone: "mydocuments.png"
			);

		public static readonly string documentshomeIcon = 
			Device.OnPlatform
			(
				iOS: "mydocumentsinvert.png",
				Android: "documentshome.png",
				WinPhone: "Images/documents.png"
			);

		public static readonly string settingsIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/settings.png",
				Android: "settings.png",
				WinPhone: "settings.png"
			);

			public static readonly string abouthomeicon = 
			Device.OnPlatform
			(
				iOS: "about.png",
				Android: "abouthome.png",
				WinPhone: "about.png"
			);



		public static readonly string libraryhomeIcon = 
			Device.OnPlatform
			(
				iOS: "librarynew.png",
				Android: "libraryhome.png",
				WinPhone: "libraryhome.png"
			);
				

		public static readonly string websitesIcon = 
			Device.OnPlatform
			(
				iOS: "website.png",
				Android: "websiteshome.png",
				WinPhone: "websiteshome.png"
			);

		public static readonly string catalogIcon = 
			Device.OnPlatform
			(
				iOS: "libraryinvert.png",
				Android: "cataloghome.png",
				WinPhone: "cataloghome.png"
			);

		public static readonly string listIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/hamburger.png",
				Android: "hamburger.png",
				WinPhone: "hamburger.png"
			);
		
		public static readonly string tiledIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/tiled.png",
				Android: "tiled.png",
				WinPhone: "tiled.png"
			);

		public static readonly string englishIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/english.png",
				Android: "english.png",
				WinPhone: "english.png"
			);

		public static readonly string flagIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/flag.png",
				Android: "flag.png",
				WinPhone: "flag.png"
			);

		public static readonly string germanIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/german.png",
				Android: "german.png",
				WinPhone: "german.png"
			);

		public static readonly string languageIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/language.png",
				Android: "language.png",
				WinPhone:  "language.png"
			);

		public static readonly string searchIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/search.png",
				Android: "search.png",
				WinPhone: "search.png"
			);

		public static readonly string filterIcon = 
			Device.OnPlatform
			(
				iOS: "corningimages/filter.png",
				Android: "filter.png",
				WinPhone: "filter.png"
			);


	}
}
