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
	public class NewsLetterViewModel : BaseViewModel
	{
		public IEnumerable<ProductCatalog> Files { get; set; }
		public ObservableCollection<ProductCatalog> ImageFiles { get; set; }
		public bool IsEmpty { get; set; }

		public NewsLetterViewModel()
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
				GlobalVariables.NewsLanguage = GlobalVariables.NewsLanguage ?? GlobalVariables.AppSelectedLanguage;
				Files = db.GetNewsLetters(GlobalVariables.NewsLanguage);
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
				if (Files.Any ()) {
					IsEmpty = false;
				} else {
					IsEmpty = true;
				}
			}
		}

		public int DocFileID {
			get;
			set;
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

		protected async Task ExecuteDeleteDocumentsCommand()
		{
			if (IsLoading)
				return;

			IsLoading = true;
			try
			{
				db.DeleteDownloadItem(DocFileID);	
				Files = db.GetNewsLetters(GlobalVariables.NewsLanguage);

			}
			catch(Exception ex){
				var error = ex.StackTrace;
			}
			finally
			{
				IsLoading = false;
				if (Files.Any ()) {
					IsEmpty = false;
				} else {
					IsEmpty = true;
				}
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
				Files = db.GetNewsLetters(GlobalVariables.NewsLanguage);
			}
			catch(Exception ex){
				var error = ex.StackTrace;
			}
			finally
			{
				IsLoading = false;
				if (Files.Any ()) {
					IsEmpty = false;
				} else {
					IsEmpty = true;
				}
			}
		}
	}
}

