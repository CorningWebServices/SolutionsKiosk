using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using PropertyChanged;
using System.Collections.Generic;

namespace MediandoUI
{
	[ImplementPropertyChanged]
	public class MyDocumentsViewModel : BaseViewModel
	{
		public IEnumerable<Downloads> Files { get; set; }
		public ObservableCollection<Downloads> ImageFiles { get; set; }
		public int DocFileID { get; set; }


		public MyDocumentsViewModel()
		{
			ImageFiles = new ObservableCollection<Downloads> ();
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
				Files = db.GetDownloads(GlobalVariables.DocsLanguage,GlobalVariables.DocsCategory);

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

		protected async Task ExecuteDeleteDocumentsCommand()
		{
			if (IsLoading)
				return;

			IsLoading = true;
			try
			{
				db.DeleteDownloadItem(DocFileID);	
				Files = db.GetDownloads(GlobalVariables.DocsLanguage,GlobalVariables.DocsCategory);

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
			}
		}
	}
}

