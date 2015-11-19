using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using PropertyChanged;
using System.Collections.Generic;
using System.Linq;

namespace MediandoUI
{
	[ImplementPropertyChanged]
	public class LibraryViewModel : BaseViewModel
	{
		public IEnumerable<Category> LibraryCategory { get; set; }

		public bool IsEmpty { get; set; }

		public LibraryViewModel ()
		{
			IsEmpty = false;
		}

		private ICommand LoadCategories;

		public ICommand LoadItemsCommand {
			get {
				return LoadCategories ?? (LoadCategories = new Command (async () => await ExecuteLoadItemsCommand ()));
			}
		}

		protected async Task ExecuteLoadItemsCommand ()
		{
			if (IsLoading)
				return;
			IsLoading = true;
			try {
				
				LibraryCategory = db.GetCategories ();

				int i = 0;
				while (!LibraryCategory.Any ()) {
					if (i < 25) {
						LibraryCategory = db.GetCategories ();
						i++;
					} else
						break;
				}
			} finally {
				IsLoading = false;
				IsRunning = false;
				if (!LibraryCategory.Any ()) {
					IsEmpty = true;
				} else {
					IsEmpty = false;
				}
			}
		}
	}
}

