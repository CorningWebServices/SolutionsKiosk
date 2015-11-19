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
	public class LibraryDetailsViewModel : BaseViewModel
	{
		public IEnumerable<ProductCatalog> Files { get; set; }
		public ObservableCollection<ProductCatalog> ImageFiles { get; set; }

		public bool IsEmpty { get; set; }

		public LibraryDetailsViewModel()
		{
			ImageFiles = new ObservableCollection<ProductCatalog> ();
			IsEmpty = false;
		}


		private ICommand LoadLibraryDetails;

		public ICommand LoadItemsCommand
		{
			get
			{
				return LoadLibraryDetails ?? (LoadLibraryDetails = new Command(async () => await ExecuteLoadItemsCommand()));
			}
		}

		protected async Task ExecuteLoadItemsCommand()
		{
			if (IsLoading)
				return;
			
			IsLoading = true;
			try
			{
				GlobalVariables.SelectedLanguage = GlobalVariables.SelectedLanguage ?? GlobalVariables.AppSelectedLanguage;
				Files =  db.GetCatalogsByFilters(GlobalVariables.SelectedLanguage,GlobalVariables.SelectedCategoryCode);
				ImageFiles.Clear();
				foreach(var item in Files){
					ImageFiles.Add(item);
				}
			}
			catch(Exception ex){
				var error = ex.StackTrace;
			}
			finally
			{
				IsLoading = false;
				IsRunning = false;
				if (!Files.Any ()) {
					IsEmpty = true;
				} else {
					IsEmpty = false;
				}
			}
		}

		private ICommand DeleteDocuments;

		public ICommand DeleteDocumentsCommand
		{
			get
			{
				return DeleteDocuments ?? (DeleteDocuments = new Command(async () => 
					await ExecuteDeleteDocumentsCommand()));
			}
		}

		public int DocFileID {
			get;
			set;
		}

		protected async Task ExecuteDeleteDocumentsCommand()
		{
			if (IsLoading)
				return;

			IsLoading = true;
			try
			{
				db.DeleteDownloadItem(DocFileID);	
				Files = db.GetCatalogsByFilters(GlobalVariables.SelectedLanguage,GlobalVariables.SelectedCategoryCode);

			}
			catch(Exception ex){
				var error = ex.StackTrace;
			}
			finally
			{
				IsLoading = false;
			}
		}

		private ICommand InsertDocuments;

		public ICommand InsertDocumentsCommand
		{
			get
			{
				return InsertDocuments ?? (InsertDocuments = new Command(async () => 
					await ExecuteInsertDocumentsCommand()));
			}
		}

		public ProductCatalog fileItem {
			get;
			set;
		}

		protected async Task ExecuteInsertDocumentsCommand()
		{
			if (IsLoading)
				return;

			IsLoading = true;
			try
			{
				db.InsertDownloadItem(fileItem);	
				Files = db.GetCatalogsByFilters(GlobalVariables.SelectedLanguage,GlobalVariables.SelectedCategoryCode);
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

