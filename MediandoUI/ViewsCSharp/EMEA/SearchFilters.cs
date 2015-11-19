using System;
using Xamarin.Forms;
using System.Linq;

namespace MediandoUI
{
	public class SearchView : BaseContentPage
	{
		private SearchViewModel ViewModel { get { return BindingContext as SearchViewModel; } }

		private ListView searchlistView;
		private ListView resultlistView;
		private LibraryType categoryType;

		public SearchView (LibraryType type)
		{
			//this.BackgroundImage = ImageConstants.backgroundImage;
			BindingContext = new SearchViewModel ();
			categoryType = type;

			var searchBar = new SearchBar ();
			searchBar.SearchButtonPressed += OnSearchBarButtonPressed;
			searchBar.TextChanged += (sender, e) => {
				//var changedSearchBar = (SearchBar)sender;
				if (e.NewTextValue == null) {
					//this only happens when user taps "Cancel" on iOS
					ViewModel.LoadItemsCommand.Execute (null);
					searchlistView.ItemsSource = ViewModel.SearchItems;
					searchlistView.IsVisible = true;
					resultlistView.IsVisible = false;
				}
			};

			searchlistView = new ListView () {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(SearchItemTemplate)),
				SeparatorColor = Color.Transparent,
				BackgroundColor = Color.Transparent,
			};

			resultlistView = new ListView () {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(ResultsItemTemplate)),
				//SeparatorColor = Color.Transparent,
				BackgroundColor = Color.Transparent,
			};


			searchlistView.ItemTapped += (sender, e) => {
				var search = (Search)e.Item;
				ViewModel.SearchText = search.SearchText;

				if(categoryType != LibraryType.MyDocuments){
					ViewModel.LoadResultsCommand.Execute (null);
					resultlistView.ItemsSource = ViewModel.Files;
				}
				else{
					ViewModel.LoadDownloadedSearchResultsCommand.Execute (null);
					resultlistView.ItemsSource = ViewModel.DownloadedFiles;
				}


				searchlistView.IsVisible = false;
				resultlistView.IsVisible = true;
			};

			resultlistView.ItemTapped += (sender, e) => {
				if(categoryType == LibraryType.MyDocuments){
					var fileItem = (Downloads)e.Item;
					var page = new DocumentDetails (fileItem);
					this.Navigation.PushAsync (page,true);
				}
				else{
					var fileItem = (ProductCatalog)e.Item;
					var page = new DetailsPopup (fileItem,type);
					this.Navigation.PushAsync (page,true);
				}
			};

			Content = new PopupLayout {
				//VerticalOptions = LayoutOptions.Center,
				Content = new StackLayout {
					//BackgroundColor = Color.Black,
					Children = { searchBar, searchlistView, resultlistView }
				}
			};

			resultlistView.IsVisible = false;
			Title = Translation.Localize("SearchLabel");

		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			if (ViewModel == null)
				return;

			ViewModel.LoadItemsCommand.Execute (null);
			searchlistView.ItemsSource = ViewModel.SearchItems;
		}

		void OnSearchBarButtonPressed(object sender, EventArgs args)
		{
			// Get the search text.
			SearchBar searchBar = (SearchBar)sender;
			ViewModel.SearchText = searchBar.Text;

			if (categoryType == LibraryType.MyDocuments) {
				ViewModel.LoadDownloadedSearchResultsCommand.Execute (null);
				resultlistView.ItemsSource = ViewModel.DownloadedFiles;
			} else {
				ViewModel.LoadResultsCommand.Execute (null);
				resultlistView.ItemsSource = ViewModel.Files;
			}


			searchlistView.IsVisible = false;
			resultlistView.IsVisible = true;
		}
			
	}


	public class SearchItemTemplate : ViewCell
	{

		public SearchItemTemplate ()
		{
			var nameLabel = new Label () {
				FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
				HorizontalOptions = LayoutOptions.StartAndExpand,
			};
			nameLabel.SetBinding (Label.TextProperty, "SearchText");


			var tapImage = new Image () {
				Source = "New/nextblack.png",
				HorizontalOptions = LayoutOptions.End,
				HeightRequest = 18,
				WidthRequest=18,
			};

			Grid grid = new Grid
			{
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				RowDefinitions = 
				{
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions =
				{
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = GridLength.Auto },
				}
				};

			grid.Children.Add (nameLabel, 0, 0);
			grid.Children.Add (tapImage, 1, 0);


			var frame = new Frame {
				HasShadow = true,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Padding= 5,
				Content = new StackLayout {
					Padding=0,
					Children = {
						grid
					}
				}
			};

			this.View =  frame;
		}
	}


	public class ResultsItemTemplate : ViewCell
	{
		public ResultsItemTemplate ()
		{
			var image = new Image { HeightRequest = 100, WidthRequest = 100 };
			image.SetBinding (Image.SourceProperty, new Binding ("ThumbPath", converter: new NoCacheConverter ()));

			var nameLabel = new Label { 
				YAlign = TextAlignment.Center,
				FontAttributes = FontAttributes.None,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
			};

			nameLabel.SetBinding (Label.TextProperty, "FileName");


			View = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = { image, nameLabel }
			};
		}
	}
		
}

