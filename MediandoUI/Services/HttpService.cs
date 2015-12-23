using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using Newtonsoft.Json;

namespace MediandoUI
{
	public class HttpService
	{
		public static async Task CheckForDataUpdate (MediandoDatabase db)
		{
			var client = new HttpClient ();
			try {
				if (App.IsOnline ()) {
					GlobalVariables.IsDownloadingData = true;
					string result = await client.GetStringAsync (WebApiConfig.CurrentVersion);
					var data = JsonConvert.DeserializeObject<IEnumerable<AppVersion>> (result).FirstOrDefault ();
					var currentversion = db.GetAppVersion();
					if(currentversion != null){
						if(currentversion.Major != data.Major || 
							currentversion.Minor != data.Minor){
						    Task.Factory.StartNew (async () => {
								await HttpService.SyncLanguageData (db);
								await HttpService.SyncFiltersData (db);
								await HttpService.SyncCategoriesData (db);
								await HttpService.SyncCatalogData (db);

							});
							Task.WaitAll ();
						}
						else if(currentversion.DataVersion != data.DataVersion){
							await Task.Factory.StartNew (async () => {
								await HttpService.SyncCatalogData (db);

							});
							Task.WaitAll ();
						}
					}
					else{
						await Task.Factory.StartNew (async () => {
							await HttpService.SyncLanguageData (db);
							await HttpService.SyncFiltersData (db);
							await HttpService.SyncCategoriesData (db);
							await HttpService.SyncCatalogData (db);

						});
						Task.WaitAll ();
					}

					db.UpdateAppVersion(data);
				}
			} catch (Exception ex) {
				var stri = ex.InnerException.StackTrace;
			} finally {
				GlobalVariables.IsDownloadingData = false;
			}
		}

		public static async Task SyncLanguageData (MediandoDatabase db)
		{

			var client = new HttpClient ();
			try {
				string result = await client.GetStringAsync (WebApiConfig.Language);
				var data = JsonConvert.DeserializeObject<IEnumerable<Language>> (result).ToList ();
				db.UpdateLanguages (data);

			} catch (Exception ex) {
				var stri = ex.InnerException.StackTrace;
			}	
		}

		public static async Task SyncFiltersData (MediandoDatabase db)
		{

			var client = new HttpClient ();
			try {
				string result = await client.GetStringAsync (WebApiConfig.Filters);
				var data = JsonConvert.DeserializeObject<IEnumerable<Filter>> (result).ToList ();
				db.UpdateFilters (data);

			} catch (Exception ex) {
				var stri = ex.InnerException.StackTrace;
			}

		}

		public static async Task SyncCategoriesData (MediandoDatabase db)
		{

			var client = new HttpClient ();
			try {
				string result = await client.GetStringAsync (WebApiConfig.Categories);
				var data = JsonConvert.DeserializeObject<IEnumerable<Category>> (result).ToList ();
				db.UpdateCategories (data);

			} catch (Exception ex) {
				var stri = ex.InnerException.StackTrace;
			}

		}

		public static async Task SyncCatalogData (MediandoDatabase db)
		{

			var client = new HttpClient ();
			try {
				string result = await client.GetStringAsync (WebApiConfig.ProductCatalogs);
				var data = JsonConvert.DeserializeObject<IEnumerable<ProductCatalog>> (result).ToList ();
				db.UpdateCatalogs (data);

			} catch (Exception ex) {
				var stri = ex.InnerException.StackTrace;
			}

		}
	}
}

