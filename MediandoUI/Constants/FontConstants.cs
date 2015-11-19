using System;
using Xamarin.Forms;

namespace MediandoUI
{
	public static class UIConstants
	{
		//public static double FontSize
		public static double GetHomePageFontSize ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return Device.GetNamedSize (NamedSize.Medium, typeof(Label));
				} else {
					return Device.GetNamedSize (NamedSize.Medium, typeof(Label));
				}
			} else {
				return Device.GetNamedSize (NamedSize.Large, typeof(Label));
			}
		}


		public static double GetLanguageFontSize ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return Device.GetNamedSize (NamedSize.Micro, typeof(Label));
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				} else {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				}
			} else {
				return Device.GetNamedSize (NamedSize.Large, typeof(Label));
			}
		}

		public static double GetLogoSize ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return 20;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return 25;
				} else {
					return 25;
				}
			} else {
				return 50;
			}
		}

		//public static double FontSize
		public static double GetAppSelectorHeaderFonts ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				} else {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				}
			} else {
				return Device.GetNamedSize (NamedSize.Large, typeof(Label));
			}
		}

		//public static double FontSize
		public static double GetAppSelectorDetailsFonts ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return Device.GetNamedSize (NamedSize.Micro, typeof(Label));
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return Device.GetNamedSize (NamedSize.Micro, typeof(Label));
				} else {
					return Device.GetNamedSize (NamedSize.Micro, typeof(Label));
				}
			} else {
				return Device.GetNamedSize (NamedSize.Medium, typeof(Label));
			}
		}

		//public static double FontSize
		public static double GetAppSelectorPadding ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return 5;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return 20;
				} else {
					return 20;
				}
			} else {
				return 30;
			}
		}

		//public static double FontSize
		public static double GetThumbnailWidth ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return 110d;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return 120d;
				} else {
					return 120d;
				}
			} else {
				return 140d;
			}
		}

		public static double GetThumbnailHeight ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return 156d;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return 170d;
				} else {
					return 170d;
				}
			} else {
				return 198d;
			}
		}


		public static double GetButtonWidth ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return 130d;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return 140d;
				} else {
					return 140d;
				}
			} else {
				return 160d;
			}
		}

		public static double GetButtonHeight ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return 35d;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return 40d;
				} else {
					return 40d;
				}
			} else {
				return 50d;
			}
		}

		public static double GetTemplateFonts ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return Device.GetNamedSize (NamedSize.Medium, typeof(Label));
				} else {
					return Device.GetNamedSize (NamedSize.Medium, typeof(Label));
				}
			} else {
				return Device.GetNamedSize (NamedSize.Large, typeof(Label));
			}
		}

		public static double GetGridViewItemHeights ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return 200d;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return 220d;
				} else {
					return 220d;
				}
			} else {
				return 250d;
			}
		}

		public static double GetGridViewItemWidths ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return 150;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return 160;
				} else {
					return 160;
				}
			} else {
				return 170;
			}
		}

		public static double GetGridViewFontSize ()
		{
			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				} else {
					return Device.GetNamedSize (NamedSize.Small, typeof(Label));
				}
			} else {
				return Device.GetNamedSize (NamedSize.Medium, typeof(Label));
			}
		}

	}
}

