using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace MediandoUI
{
	public class ToolBarFilters : BaseContentPage
	{
		ListView listView;

		protected FilterViewModel ViewModel {
			get { return BindingContext as FilterViewModel; }
			set { BindingContext = value; }
		}

		public ToolBarFilters (FilterTypes filter)
		{
			BindingContext = new FilterViewModel(filter);
			Title = ViewModel.Title;
		

			listView = new ListView () {
				ItemsSource = ViewModel.Items,
				BackgroundColor = Color.Transparent,
				ItemTemplate = new DataTemplate (() => {
					Label titleLabel = new Label ();
					titleLabel.VerticalOptions = LayoutOptions.Center;
					titleLabel.SetBinding (Label.TextProperty, "Name");

					Image blueCheck = new Image ();
					blueCheck.Source = "New/selected.png";
					blueCheck.WidthRequest = 18;
					blueCheck.HeightRequest = 18;
					blueCheck.HorizontalOptions = LayoutOptions.EndAndExpand;
					blueCheck.SetBinding (Image.IsVisibleProperty, "IsSelected");

					return new ViewCell {
						View = new StackLayout {
							Orientation = StackOrientation.Horizontal,
							HorizontalOptions = LayoutOptions.StartAndExpand,
							Padding = new Thickness(20,0,10,0),
							Children = { titleLabel, blueCheck }
						}
					};
				})
			};
					

			listView.ItemSelected += (sender, e) =>
			{
				if (e.SelectedItem == null)
					return;

				var item =(MultiSelectSource)e.SelectedItem;
				if(filter == FilterTypes.Categories){
					GlobalVariables.SelectedCategory = item.Name;
					GlobalVariables.SelectedCategoryCode = item.Code;
				} else {
					GlobalVariables.SelectedLanguage = item.Code;
				}
				Navigation.PopModalAsync (true);
			};


			Content = new StackLayout { 
				Children = {
					listView
				}
			};

			this.ToolbarItems.Add (new ToolbarItem (Translation.Localize("DoneLabel"), null, () => {
				Navigation.PopModalAsync (true);
			}));
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			LoadDataAsync ();
		}

		protected async void LoadDataAsync ()
		{
			if (ViewModel == null || ViewModel.IsLoading)
				return;

			ViewModel.LoadItemsCommand.Execute (null);
			Device.BeginInvokeOnMainThread (() => {
				try {
					listView.ItemsSource = ViewModel.Items;

				} catch (Exception) {
					DisplayAlert ("Error", "Refresh the form.", "Ok");
				}

			});
		}
	}
}
