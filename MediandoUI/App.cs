﻿using System;
using Xamarin.Forms;
using Connectivity.Plugin;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace MediandoUI
{
	public enum UIImplementation
	{
		CSharp = 0,
		Xaml
	}

	public enum ApplicationID
	{
		Default = 0,
		EMEA = 1,
		NA = 2
	}

	public class App : Application
	{
		//Change the following line to switch between XAML and C# versions
		//For Windows Phone Implemetation 
		//private static UIImplementation uiImplementation = UIImplementation.CSharp;
		public static DateTime? AppLastUsedTime;

		public App ()
		{
			Translation.SetLocale ();

			var netLanguage = DependencyService.Get<ILocale>().GetCurrent();
			AppResources.Culture = new CultureInfo (netLanguage);

			Database = new MediandoDatabase ();
			//SyncData (Database);

			var homePage = new StartView ();
			MainPage = homePage;
			App.AppSelected = ApplicationID.Default;
		}

		public static MediandoDatabase _database;
		public static MediandoDatabase Database{
			get{ 
				return _database;
			}
			set{ 
				_database = value;
			}
		} 



		protected override void OnStart ()
		{
			base.OnStart ();
			App.AppLastUsedTime = null;
		}

		public static Page GetNewsLetterPage ()
		{
			var formsPage = new NavigationPage (new NewsletterView ()); 
			return formsPage;
		}

		private static ApplicationID _appSelected;
		public static ApplicationID AppSelected
		{
			get{
				return _appSelected;
			}
			set{
				_appSelected = value;
			}
		}


		public static bool IsOnline() {
			return CrossConnectivity.Current.IsConnected;
		}

		public static bool IsWifiReachable() {
			return IsOnline () && CrossConnectivity.Current.ConnectionTypes.ToList ().Any (i => i.ToString () == "WiFi");
		}

		public static bool IsCellularReachable() {
			return IsOnline () && CrossConnectivity.Current.ConnectionTypes.ToList ().Any (i => i.ToString () != "WiFi");
		}

		private static IOSDevices _currentDevice;
		public static IOSDevices CurrentDevice
		{
			get{
				#if DEBUG
					if(_currentDevice == IOSDevices.Simulator){
						return IOSDevices.IPhone6SPlus;
					}
				return _currentDevice;
				#else
				return _currentDevice;
				#endif
			}
			set{
				_currentDevice = value;
			}
		}

		public static int ScreenWidth {
			get;
			set;
		}

		public static int ScreenHeight {
			get;
			set;
		}

		private static bool _showAppSelection = true;
		public static bool ShowAppSelection {
			get{
				return _showAppSelection;
			}
			set{
				_showAppSelection = value;
			}
		}

	}
}
