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
			double width = 200;

			if (Device.Idiom == TargetIdiom.Phone) {
				if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					width= 110d;
				} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
					width=  120d;
				} else {
					width=  120d;
				}
			} else {
				width=  140d;
			}
			return width;

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
			double width = 200;
			Device.OnPlatform (
				iOS: () => {
					if (Device.Idiom == TargetIdiom.Phone) {
						if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
							width=  200d;
						} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
							width=  220d;
						} else {
							width=  220d;
						}
					} else {
						width=  250d;
					}
				},
				Android: () => {
					if (Device.Idiom == TargetIdiom.Phone) {
						if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
							width=  350d;
						} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
							width=  550d;
						} else {
							width=  600d;
						}
					} else {
						width=  650d;
					}
				},
				WinPhone: () => {
					if (Device.Idiom == TargetIdiom.Phone) {
						if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
							width=  200d;
						} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
							width=  220d;
						} else {
							width=  220d;
						}
					} else {
						width=  250d;
					}
				}
			);
			return width;

		}

		public static double GetGridViewItemWidths ()
		{
			double width = 200;
			Device.OnPlatform (
				iOS: () => {
					if (Device.Idiom == TargetIdiom.Phone) {
						if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
							width=  150;
						} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
							width=  160;
						} else {
							width=  160;
						}
					} else {
						width=  170;
					}
				},
				Android: () => {
					if (Device.Idiom == TargetIdiom.Phone) {
						if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
							width=  300;
						} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
							width=  500;
						} else {
							width=  550;
						}
					} else {
						width=  550;
					}
				},
				WinPhone: () => {
					if (Device.Idiom == TargetIdiom.Phone) {
						if (App.CurrentDevice == IOSDevices.IPhone4S || App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
							width=  150;
						} else if (App.CurrentDevice == IOSDevices.IPhone6 || App.CurrentDevice == IOSDevices.IPhone6Plus) {
							width=  160;
						} else {
							width=  160;
						}
					} else {
						width=  170;
					}
				}
			);
			return width;
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

