using System;
using SQLite.Net.Attributes;
using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediandoUI
{
	public class MediandoDatabase
	{
		private SQLiteConnection _connection;

		public MediandoDatabase ()
		{
			_connection = DependencyService.Get<ISQLite> ().GetConnection ();
			_connection.CreateTable<Settings> ();
			_connection.CreateTable<AppVersion> ();
			EnableDefaultSettings ();
			_connection.CreateTable<EMEAApplication> ();
			_connection.CreateTable<AppLanguage> ();
			_connection.CreateTable<Language> ();
			_connection.CreateTable<Category> ();
			_connection.CreateTable<Filter> ();
			_connection.CreateTable<ProductCatalog> ();
			_connection.CreateTable<Downloads> ();
			_connection.CreateTable<Search> ();
		}

		public void EnableDefaultSettings ()
		{
			var count = _connection.Table<Settings> ().Count ();
			if (count != 3) {
				_connection.DeleteAll<Settings> ();

				_connection.Insert (new Settings { 
					Id = 1,
					Key = "Version",
					Value = "1.0"
				});

				_connection.Insert (new Settings { 
					Id = 2,
					Key = "Language",
					Value = "British_English"
				});

				_connection.Insert (new Settings { 
					Id = 3,
					Key = "WifiDownload",
					Value = "1"
				});
			}
		}

		public void UpdateSettings(string key, string value)
		{
			var setting = (from t in _connection.Table<Settings> ()
				where t.Key == key
			               select t).FirstOrDefault ();

			_connection.Delete (setting);

			_connection.Insert (new Settings { 
				Id =  setting.Id,
				Key = key,
				Value = value
			});
		}

		public IEnumerable<Settings> GetDefaultSettings()
		{
			return (from t in _connection.Table<Settings> ()
				select t).ToList ();
			
		}

		public AppVersion GetAppVersion()
		{
			return (from t in _connection.Table<AppVersion> ()
				select t).FirstOrDefault();

		}

		public void UpdateAppVersion(AppVersion val)
		{
			_connection.DeleteAll<AppVersion> ();

			_connection.Insert (val);
		}


		public IEnumerable<Language> GetLanguages ()
		{
			return (from t in _connection.Table<Language> ()
			        select t).ToList ();
		}

		public IEnumerable<Category> GetCategories ()
		{
			return (from t in _connection.Table<Category> ()
				where t.Language == GlobalVariables.AppSelectedLanguage && t.CategoryCode != "newsletter"
			        select t).OrderBy (t => t.CategoryName).ToList ();
		}

		public IEnumerable<Category> GetAllCategories ()
		{
			return (from t in _connection.Table<Category> ()
				where t.Language == GlobalVariables.AppSelectedLanguage 
				select t).OrderBy (t => t.CategoryName).ToList ();
		}

		public IEnumerable<Filter> GetFilters ()
		{
			return (from t in _connection.Table<Filter> ()
				where t.Code == GlobalVariables.AppSelectedLanguage
			        select t).ToList ();
		}

		public IEnumerable<ProductCatalog> GetCatalogs ()
		{
			return (from t in _connection.Table<ProductCatalog> ()
				where t.Language == GlobalVariables.AppSelectedLanguage
			        select t).ToList ();
		}
			
		public IEnumerable<ProductCatalog> GetNewLetters (string language)
		{
			return (from t in _connection.Table<ProductCatalog> ()
				where t.Language == language && t.CategoryCode == "newsletter"
				 select t).ToList ();
		}


		public IEnumerable<ProductCatalog> GetCatalogsByFilters (string language, string categoryCode)
		{
			var data =  (from t in _connection.Table<ProductCatalog> ()
				join p in _connection.Table<Downloads>() 
				on new {
					lang = t.Language,
					prodID = t.ProductID
				} equals new {
					lang = p.Language,
					prodID = p.ProductID
				}
				into q
				from download in q.DefaultIfEmpty()
			            where !t.MimeType.StartsWith ("zip")
			                && (t.CategoryCode == categoryCode || categoryCode == "all")
							&& (t.CategoryCode != "newsletter")
			                && (t.Language == language || language == "All")
				select new ProductCatalog{
					Id = t.Id,
					ProductID = t.ProductID,
					AppCode = t.AppCode,
					CategoryCode = t.CategoryCode,
					Language = t.Language,
					FileName = t.FileName,
					Description = t.Description,
					MimeType = t.MimeType,
					PublicationDate = t.PublicationDate,
					FilePath = download == null ? t.FilePath : download.FilePath,
					ThumbPath = download == null ? t.ThumbPath : download.ThumbPath,
					DownloadDate = download == null ? t.DownloadDate : download.DownloadDate,
					ButtonText = download == null 
						? (t.MimeType.StartsWith("mp4") ?   Translation.Localize("PlayOnlineText") : Translation.Localize("ReadOnlineText")) 
						: (t.MimeType.StartsWith("mp4") ?   Translation.Localize("PlayOfflineText") : Translation.Localize("ReadOfflineText"))
				}
			).OrderByDescending (t => t.PublicationDate).ToList ();
			return data;
		}

		public IEnumerable<ProductCatalog> GetNewsLetters (string language)
		{
			var data = (from t in _connection.Table<ProductCatalog> ()
				join p in _connection.Table<Downloads>() 
				on new {
					lang = t.Language,
					prodID = t.ProductID
				} equals new {
					lang = p.Language,
					prodID = p.ProductID
				}
				into q
				from download in q.DefaultIfEmpty()
				where !t.MimeType.StartsWith ("zip")
				&& (t.CategoryCode == "newsletter")
				&& (t.Language == language || language == "All")
				select new ProductCatalog{
					Id = t.Id,
					ProductID = t.ProductID,
					AppCode = t.AppCode,
					CategoryCode = t.CategoryCode,
					Language = t.Language,
					FileName = t.FileName,
					Description = t.Description,
					MimeType = t.MimeType,
					PublicationDate = t.PublicationDate,
					FilePath = download == null ? t.FilePath : download.FilePath,
					ThumbPath = download == null ? t.ThumbPath : download.ThumbPath,
					DownloadDate = download == null ? t.DownloadDate : download.DownloadDate,
					ButtonText = download == null 
						? (t.MimeType.StartsWith("mp4") ?   Translation.Localize("PlayOnlineText") : Translation.Localize("ReadOnlineText")) 
						: (t.MimeType.StartsWith("mp4") ?   Translation.Localize("PlayOfflineText") : Translation.Localize("ReadOfflineText"))
			}
			).OrderByDescending (t => t.PublicationDate).ToList ();
			return data;
		}

		public IEnumerable<ProductCatalog> GetCatalogsByName (string searchText)
		{
			var data = 
				(
					from t in _connection.Table<ProductCatalog> ()
					join p in _connection.Table<Downloads>() 
					on new {
						lang = t.Language,
						prodID = t.ProductID
					} equals new {
						lang = p.Language,
						prodID = p.ProductID
					}
					into q
					from download in q.DefaultIfEmpty()
					where !t.MimeType.StartsWith ("zip")
					&& (t.FileName.ToLower().Contains(searchText.ToLower()) || 
						(t.Description ?? "").ToLower().Contains(searchText.ToLower()) ||
						(t.SearchKeywords ?? "").ToLower().Contains(searchText.ToLower()))
					select new ProductCatalog{
						Id = t.Id,
						ProductID = t.ProductID,
						AppCode = t.AppCode,
						CategoryCode = t.CategoryCode,
						Language = t.Language,
						FileName = t.FileName,
						Description = t.Description,
						MimeType = t.MimeType,
						PublicationDate = t.PublicationDate,
						FilePath = download == null ? t.FilePath : download.FilePath,
						ThumbPath = download == null ? t.ThumbPath : download.ThumbPath,
						DownloadDate = download == null ? t.DownloadDate : download.DownloadDate,
						ButtonText = download == null 
							? (t.MimeType.StartsWith("mp4") ?   Translation.Localize("PlayOnlineText") : Translation.Localize("ReadOnlineText")) 
							: (t.MimeType.StartsWith("mp4") ?   Translation.Localize("PlayOfflineText") : Translation.Localize("ReadOfflineText"))
			}
			).OrderByDescending (t => t.PublicationDate).ToList ();
			
			return data;
		}

		public IEnumerable<Downloads> GetDownloadedCatalogsByName (string searchText)
		{
			var data = (from t in _connection.Table<Downloads> ()
				select t).ToList();

			var searchlist = data.Where (i => i.FileName.ToLower ().Contains (searchText.ToLower ())
				|| (i.Description ?? "").ToLower().Contains(searchText.ToLower()) || (i.SearchKeywords ?? "").ToLower().Contains(searchText.ToLower()));
			return searchlist.ToList ();
		}

		public ProductCatalog GetCatalogsByID (int ID)
		{
			var data = (from t in _connection.Table<ProductCatalog> ()
				join p in _connection.Table<Downloads>() 
				on new {
					lang = t.Language,
					prodID = t.ProductID
				} equals new {
					lang = p.Language,
					prodID = p.ProductID
				}
				into q
				from download in q.DefaultIfEmpty()
				where !t.MimeType.StartsWith ("zip")
				&& t.Id == ID
				select new ProductCatalog{
					Id = t.Id,
					ProductID = t.ProductID,
					AppCode = t.AppCode,
					CategoryCode = t.CategoryCode,
					Language = t.Language,
					FileName = t.FileName,
					Description = t.Description,
					MimeType = t.MimeType,
					PublicationDate = t.PublicationDate,
					FilePath = download == null ? t.FilePath : download.FilePath,
					ThumbPath = download == null ? t.ThumbPath : download.ThumbPath,
					DownloadDate = download == null ? t.DownloadDate : download.DownloadDate,
					ButtonText = download == null 
						? (t.MimeType.StartsWith("mp4") ?   Translation.Localize("PlayOnlineText") : Translation.Localize("ReadOnlineText")) 
						: (t.MimeType.StartsWith("mp4") ?   Translation.Localize("PlayOfflineText") : Translation.Localize("ReadOfflineText"))
			}
			).FirstOrDefault();
			return data;
		}

		public IEnumerable<Downloads> GetDownloads (string language, string categoryCode)
		{
			var data = (from t in _connection.Table<Downloads> ()
			             where !t.MimeType.StartsWith ("zip")
			                 && (t.CategoryCode == categoryCode || categoryCode == "all")
			                 && (t.Language == language || language == "All")
			             select t)
				.OrderByDescending (t => t.DownloadDate);

			return data.ToList ();
		}


		public IEnumerable<Language> GetLanguagesByID (string languageCode)
		{
			var data =(from t in _connection.Table<Language> ()
			        where t.LanguageRefCode == languageCode
			        select t).ToList ();

			return data;
		}

		public IEnumerable<Search> GetPreloadedSearch ()
		{
			var data = (from t in _connection.Table<Search> ()
				select t).ToList ();

			return data;
		}

		public void InsertSearchCriteria (string text, string results)
		{
			var data = (from t in _connection.Table<Search> ()
				where t.SearchText == text
				select t).ToList();

			if (!data.Any()) {
				var item = new Search{ SearchText = text, CatalogID = results, IsUpdated = true };
				_connection.Insert (item);
			}
		}

		public void DeleteSearchCriteria (string text)
		{
			var data = (from t in _connection.Table<Search> ()
				where t.SearchText == text
				select t).ToList();

			if (data != null) {
				foreach (var item in data) {
					_connection.Delete (item);
				}
			}
		}

		public void UpdateLanguages (IEnumerable<Language> languages)
		{
			_connection.DeleteAll<Language> ();
//			foreach (var item in languages) {
//				_connection.Insert (item);
//			}
			_connection.InsertAll (languages, true);
		}

		public void UpdateCatalogs (IEnumerable<ProductCatalog> catalogs)
		{
			_connection.DeleteAll<ProductCatalog> ();
//			foreach (var item in catalogs) {
//				_connection.Insert (item);
//			}

			_connection.InsertAll (catalogs, true);
		}

		public void UpdateCategories (IEnumerable<Category> categories)
		{

			_connection.DeleteAll<Category> ();
			_connection.Insert (new Category { 
				Id = -1,
				CategoryCode = "all",
				CategoryName = "All",
				AppCode = "all",
				Language = "British_English"
			});
			_connection.Insert (new Category { 
				Id = -2,
				CategoryCode = "all",
				CategoryName = "Alle",
				AppCode = "all",
				Language = "German"
			});

			_connection.InsertAll (categories, true);
		}

		public void UpdateFilters (IEnumerable<Filter> filters)
		{
			_connection.DeleteAll<Filter> ();
			_connection.Insert (new Filter { 
				Id = -1,
				Code = "British_English",
				Language = "All",
				Name = "All",
			});
			_connection.Insert (new Filter { 
				Id = -2,
				Code = "German",
				Language = "All",
				Name = "Alle",
			});

			_connection.InsertAll (filters, true);
		}

		public void InsertDownloadItem (ProductCatalog download)
		{
			var item = new Downloads {
				Id = download.Id,
				ProductID = download.ProductID,
				AppCode = download.AppCode,
				CategoryCode = download.CategoryCode,
				Language = download.Language,
				FileName = download.FileName,
				Description = download.Description,
				MimeType = download.MimeType,
				PublicationDate = download.PublicationDate,
				FilePath = download.FilePath,
				ThumbPath = download.ThumbPath,
				DownloadDate = DateTime.Now,
				SearchKeywords = download.SearchKeywords,
			};
			_connection.Insert (item);
		}

		public void DeleteDownloadItem (int ID)
		{
			var item = (from t in _connection.Table<Downloads> ()
			            where t.Id == ID
			            select t);
			foreach (var downloadItem in item) {
				_connection.Delete (downloadItem);
			}
		}

		public void DeleteAllDownloads ()
		{
			_connection.DeleteAll<Downloads> ();
		}
	}

	public class Language
	{
		[PrimaryKey]
		public int Id { get; set; }

		public string LanguageRefCode { get; set; }

		public string LanguageCode { get; set; }

		public string LanguageName { get; set; }

	}

	public class AppLanguage
	{
		[PrimaryKey]
		public int Id { get; set; }

		public int AppId { get; set; }

		public string AppCode { get; set; }

		public string AppName { get; set; }

		public string Language { get; set; }
	}

	public class ProductCatalog
	{
		[PrimaryKey]
		public int Id { get; set; }

		public string ProductID { get; set; }

		public string AppCode { get; set; }

		public string CategoryCode { get; set; }

		public string Language { get; set; }

		public string FileName { get; set; }

		public string Description { get; set; }

		public string MimeType { get; set; }

		public DateTime? PublicationDate { get; set; }

		public string FilePath { get; set; }

		public string ThumbPath { get; set; }

		public string SearchKeywords { get; set; }

		public DateTime? DownloadDate { get; set; }

		public string ButtonText { get; set; }
	}

	public class Downloads
	{
		[PrimaryKey]
		public int Id { get; set; }

		public string ProductID { get; set; }

		public string AppCode { get; set; }

		public string CategoryCode { get; set; }

		public string Language { get; set; }

		public string FileName { get; set; }

		public string Description { get; set; }

		public string MimeType { get; set; }

		public DateTime? PublicationDate { get; set; }

		public string FilePath { get; set; }

		public string ThumbPath { get; set; }

		public string SearchKeywords { get; set; }

		public DateTime DownloadDate { get; set; }

	}

	public class Category
	{
		[PrimaryKey]
		public int Id { get; set; }

		public string CategoryCode { get; set; }

		public string CategoryName { get; set; }

		public string Language { get; set; }

		public string AppCode { get; set; }
	}

	public class Filter
	{
		[PrimaryKey]
		public int Id { get; set; }

		public string Code { get; set; }

		public string Name { get; set; }

		public string Language { get; set; }
	}

	public class Settings
	{
		[PrimaryKey]
		public int Id { get; set; }

		public string Key { get; set; }

		public string Value { get; set; }
	}

	public class Search
	{
		public string SearchText { get; set; }
		public string CatalogID { get; set; }
		public bool IsUpdated { get; set; }
	}

	public class EMEAApplication
	{
		public int AppId { get; set; }
		public string AppCode { get; set; }
	}

	public class AppVersion
	{
		public int Id { get; set; }
		public int Major { get; set; }
		public int Minor { get; set; }
		public int DataVersion { get; set; }
		public DateTime DateUpdated { get; set; }
	}
}

