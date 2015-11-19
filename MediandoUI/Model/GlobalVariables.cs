using System;
using System.Linq;
using Xamarin.Forms;

namespace MediandoUI
{
	public static class GlobalVariables
	{

		public const string WifiConnectionOnlyAlert = "This feature is available only if you are connected to the internet by WiFi.";

		private static bool _isDownloadingData = false;
		public static bool IsDownloadingData { 
			get { 
				return _isDownloadingData;
			} set{ 
				_isDownloadingData = value;
			}
		}

		public static string SelectedCategory { get; set; }

		private static string _selectedCategoryCode = "all";
		public static string SelectedCategoryCode { 
			get { 
				return _selectedCategoryCode;
			} set{ 
				_selectedCategoryCode = value;
			}
		}

		private static string _selectedLanguage;
		public static string SelectedLanguage { 
			get { 
				if (_selectedLanguage == null) {
					_selectedLanguage = AppSelectedLanguage;
				}
				return _selectedLanguage;
			} set{ 
				_selectedLanguage = value;
			}
		}

		private static string _newsCategory = "all";
		public static string NewsCategory { 
			get { return _newsCategory;
			} set{ 
				_newsCategory = value;
			}
		}

		private static string _newsLanguage = "All";
		public static string NewsLanguage { 
			get 
			{ 
				return _newsLanguage;
			} 
			set
			{ 
				_newsLanguage = value;
			}
		}

		private static string _docsCategory = "all";
		public static string DocsCategory { 
			get { return _docsCategory;
			} set{ 
				_docsCategory = value;
			}
		}

		private static string _docsLanguage = "All";
		public static string DocsLanguage { 
			get 
			{ 
				return _docsLanguage;
			} 
			set
			{ 
				_docsLanguage = value;
			}
		}


		public static string AppSelectedLanguage { 

			get 
			{ 
				//var db = App.Database;
				//return db.GetDefaultSettings ().FirstOrDefault (i => i.Key == "Language").Value;
				if(CurrentLocale == "de"){
					return "German";
				}
				else 
					return "British_English";
			} 
		
		}

		public static string ApplicationVersion { 

			get 
			{ 
				var db = App.Database;
				return db.GetDefaultSettings ().FirstOrDefault (i => i.Key == "Version").Value;
			} 

		}

		public static bool WifiDownloadOnly {
			get 
			{ 
				var db = App.Database;
				var val = db.GetDefaultSettings ().FirstOrDefault (i => i.Key == "WifiDownload").Value;
				if (val == "1") {
					return true;
				} else {
					return false;
				}
			} 
		}

		public static string DownloadPath {
			get;
			set;
		}


		private static string _currentLocale;
		public static string CurrentLocale { 
			get { 
				if (_currentLocale == null) {
					_currentLocale =  DependencyService.Get<ILocale>().GetCurrent();
				}
				return _currentLocale;
			} set{ 
				_currentLocale = value;
			}
		}
	}

	public enum FilterTypes
	{
		Categories = 1,
		Languages = 2
	}

	public class MultiSelectSource
	{
		public string Code { get; set; }

		public string Name { get; set; }

		public bool IsSelected { get; set; }

		public MultiSelectSource (string code, string _name, bool _isselected)
		{
			Code = code;
			Name = _name;
			IsSelected = _isselected;
		}
	}
}

