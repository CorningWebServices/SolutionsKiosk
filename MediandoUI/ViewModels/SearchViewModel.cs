using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using PropertyChanged;
using System.Linq;
using System.Collections.Generic;

namespace MediandoUI
{
	[ImplementPropertyChanged]
	public class SearchViewModel : BaseViewModel
	{
		public IEnumerable<ProductCatalog> Files { get; set; }
		public IEnumerable<Downloads> DownloadedFiles { get; set; }

		public IEnumerable<Search> SearchItems { get; set; }

		public SearchViewModel()
		{

		}

		public string SearchText{ get; set;}


		private ICommand LoadSearchDetails;
		private ICommand LoadResults;
		private ICommand LoadPreloadedResults;


		private ICommand LoadDownloadResults;

		public ICommand LoadItemsCommand
		{
			get
			{
				return LoadSearchDetails ?? (LoadSearchDetails = new Command(async () => await ExecuteLoadItemsCommand()));
			}
		}

		protected async Task ExecuteLoadItemsCommand()
		{
			if (IsLoading)
				return;

			IsLoading = true;
			try
			{
				SearchItems = db.GetPreloadedSearch().ToList();
			}
			catch(Exception ex){
				var error = ex.StackTrace;
			}
			finally
			{
				IsLoading = false;
			}
		}
			



		public ICommand LoadResultsCommand
		{
			get
			{
				return LoadResults ?? 
					(LoadResults = new Command
						(
							async () => 
							await ExecuteLoadResultsCommand()
						)
					);
			}
		}

		protected async Task ExecuteLoadResultsCommand()
		{
			if (IsLoading)
				return;

			IsLoading = true;
			try
			{
				Files = db.GetCatalogsByName(SearchText).ToList();
				string IDs = "";
				foreach(var file in Files){
					IDs += file.Id + ",";
				}
				db.InsertSearchCriteria(SearchText,IDs);
			}
			catch(Exception ex){
				var error = ex.StackTrace;
			}
			finally
			{
				IsLoading = false;
			}
		}



		public ICommand LoadPreloadedResultsCommand
		{
			get
			{
				return LoadPreloadedResults ?? 
					(LoadPreloadedResults = 
						new Command(async () => await ExecuteLoadPreloadedResultsCommand()));
			}
		}

		protected async Task ExecuteLoadPreloadedResultsCommand()
		{
			if (IsLoading)
				return;

			IsLoading = true;
			try
			{
				Files = db.GetCatalogsByName(SearchText).ToList();
			}
			catch(Exception ex){
				var error = ex.StackTrace;
			}
			finally
			{
				IsLoading = false;
			}
		}

		public ICommand LoadDownloadedSearchResultsCommand
		{
			get
			{
				return LoadDownloadResults ?? 
					(LoadDownloadResults = new Command
						(
							async () => 
							await ExecuteDownloadedSearchResultsCommand()
						)
					);
			}
		}

		protected async Task ExecuteDownloadedSearchResultsCommand()
		{
			if (IsLoading)
				return;

			IsLoading = true;
			try
			{
				
				DownloadedFiles = db.GetDownloadedCatalogsByName(SearchText).ToList();
				string IDs = "";
				foreach(var file in Files){
					IDs += file.Id + ",";
				}
				db.InsertSearchCriteria(SearchText,IDs);
			}
			catch(Exception ex){
				var error = ex.StackTrace;
			}
			finally
			{
				IsLoading = false;
			}
		}

	}
}

