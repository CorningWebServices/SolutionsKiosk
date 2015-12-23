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
	public class FilterViewModel : BaseViewModel
	{

		public IEnumerable<MultiSelectSource> Items { get; set; }

		public string Title { get; set; }

		public FilterTypes CurrentFilter { get; set; }

		public FilterViewModel (FilterTypes filter)
		{
			CurrentFilter = filter;
			if (filter == FilterTypes.Categories) {
				Title = Translation.Localize("CategoriesTitle");

			} else {
				Title = Translation.Localize("LanguagesTitle");
			}
		}

		private ICommand LoadItems;

		public ICommand LoadItemsCommand {
			get {
				return LoadItems ?? (LoadItems = new Command (async () => await ExecuteLoadItemsCommand ()));
			}
		}


		protected async Task ExecuteLoadItemsCommand ()
		{
			if (IsLoading)
				return;
			IsLoading = true;
			try {
				List<MultiSelectSource> source;

				if (CurrentFilter == FilterTypes.Categories) {
					var categories = db.GetCategories ();
					source = new List<MultiSelectSource> ();
					foreach (var item in categories) {
						source.Add (new MultiSelectSource (item.CategoryCode, item.CategoryName,
							item.CategoryCode == GlobalVariables.SelectedCategoryCode ? true : false));
					}
				} 
				else 
				{
					var categories = db.GetFilters ();
					source = new List<MultiSelectSource> ();
					foreach (var item in categories) {
						source.Add (new MultiSelectSource (item.Language, item.Name,
							item.Language == GlobalVariables.SelectedLanguage ? true : false));
					
					}
				}
				Items = source.AsEnumerable ();
			} finally {
				IsLoading = false;
			}
		}

	}


}

