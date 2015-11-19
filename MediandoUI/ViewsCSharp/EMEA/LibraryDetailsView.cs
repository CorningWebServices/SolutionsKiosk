using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MediandoUI
{
	public class LibraryDetailsView : BaseContentPage
	{

		ListView listView;
		GridView imageGrid;
		Grid grid;
		LayoutType CurrentLayout;
		Label breadcrumbcategory;

		protected LibraryDetailsViewModel ViewModel {
			get { return BindingContext as LibraryDetailsViewModel; }
			set { BindingContext = value; }
		}

		public LibraryDetailsView ()
		{
			NavigationPage.SetBackButtonTitle(this,Translation.Localize("BackButton"));
			BindingContext = new LibraryDetailsViewModel ();
			ViewModel.IsRunning = true;
			CurrentLayout = LayoutType.ListLayout;
			SwitchLayouts (CurrentLayout);
			AddToolBarItems ();

			this.BackgroundImage = ImageConstants.backgroundImage;
		}

		void SwitchLayouts (LayoutType layoutType)
		{
			if (layoutType == LayoutType.ListLayout) {
				if (listView == null) {
					listView = new ListView {
						BackgroundColor = Color.White,
						HasUnevenRows = true,
						ItemTemplate = new DataTemplate (typeof(LibraryDetailsCellTemplate)),
						SeparatorColor = Color.Transparent,

					};
					listView.ItemsSource = ViewModel.Files;
					listView.BackgroundColor = Color.Transparent;

					listView.ItemTapped += (sender, e) => {
						var currentItem = (ProductCatalog)e.Item;
						var fileItem = ViewModel.Files.ToList ().FirstOrDefault (i => i.Id == currentItem.Id);
						var page = new DetailsPopup (fileItem, LibraryType.All);
						Navigation.PushAsync (page, true);
					};
				}


				grid = new Grid {
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
					RowDefinitions = {
						new RowDefinition { Height = GridLength.Auto },
						new RowDefinition { Height = GridLength.Auto },
					},
					ColumnDefinitions = {
						new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					}
				};

				grid.Children.Add (GetBreadCrumbs (), 0, 0);
				grid.Children.Add (listView, 0, 1);
				grid.Children.Add (CreateLoadingIndicator (), 0, 1);
				grid.Children.Add (ShowEmptyResults (), 0, 1);

				this.Content = grid;
				breadcrumbcategory.Text = GlobalVariables.SelectedCategory;


			} else {
				if (imageGrid == null) {
					imageGrid = new GridView {
						//BackgroundColor = Color.Green,
						RowSpacing = 5,
						Padding = 5,
						ColumnSpacing = 5,
						WidthRequest = listView.Width,
						HeightRequest = App.ScreenHeight,
						ItemWidth = UIConstants.GetGridViewItemWidths (),
						ItemHeight = UIConstants.GetGridViewItemHeights (),
						ItemsSource = ViewModel.ImageFiles,
						ItemTemplate = new DataTemplate (typeof(GridViewCellTemplate)),
					};

					imageGrid.ItemSelected += (sender, e) => {
						var currentItem = (ProductCatalog)e.Value;
						var fileItem = ViewModel.Files.ToList ().FirstOrDefault (i => i.Id == currentItem.Id);
						var page = new DetailsPopup (fileItem, LibraryType.All);
						this.Navigation.PushAsync (page, true);
					};

				}

				Grid grid = new Grid {
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
					RowDefinitions = {
						new RowDefinition { Height = GridLength.Auto },
						new RowDefinition { Height = GridLength.Auto },
					},
					ColumnDefinitions = {
						new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					}
				};

				grid.Children.Add (GetBreadCrumbs (), 0, 0);
				grid.Children.Add (imageGrid, 0, 1);
				grid.Children.Add (CreateLoadingIndicator (), 0, 1);
				grid.Children.Add (ShowEmptyResults (), 0, 1);

				this.Content = grid;
				breadcrumbcategory.Text = GlobalVariables.SelectedCategory;
			}
		}

		void AddToolBarItems ()
		{
			ToolbarItems.Add (new ToolbarItem ("DisplayView", ImageConstants.tiledIcon, () => {
				
				breadcrumbcategory.Text = GlobalVariables.SelectedCategory;
				ViewModel.IsRunning = true;

				if (CurrentLayout == LayoutType.ListLayout) {
					CurrentLayout = LayoutType.TiledLayout;
					ToolbarItems.FirstOrDefault (i => i.Text == "DisplayView").Icon = ImageConstants.listIcon;
					SwitchLayouts (CurrentLayout);
				} else {
					CurrentLayout = LayoutType.ListLayout;
					ToolbarItems.FirstOrDefault (i => i.Text == "DisplayView").Icon = ImageConstants.tiledIcon;
					SwitchLayouts (CurrentLayout);
				}

				ViewModel.IsRunning = false;
					
			}));

			ToolbarItems.Add (
				new ToolbarItem ("LanguageFilter", ImageConstants.languageIcon, async () => {
					var content = new NavigationPage (new ToolBarFilters (FilterTypes.Languages));
					content.BarBackgroundColor = Color.Transparent;
					content.BarTextColor = Color.White;
					await Navigation.PushModalAsync (content, true);
				}));

			ToolbarItems.Add (new ToolbarItem ("Refresh", "New/refresh.png", () => {
				LoadDataAsync ();
			}));


			ToolbarItems.Add (new ToolbarItem ("CategoryFilter", ImageConstants.filterIcon, async () => {
				var content = new NavigationPage (new ToolBarFilters (FilterTypes.Categories));
				content.BarBackgroundColor = Color.Transparent;
				content.BarTextColor = Color.White;
				await Navigation.PushModalAsync (content, true);
			})
			);

			ToolbarItems.Add (new ToolbarItem ("SearchFilter", ImageConstants.searchIcon, async () => {
				var content = new SearchView (LibraryType.All);
				await Navigation.PushAsync (content, true);
			})
			);

		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			breadcrumbcategory.Text = GlobalVariables.SelectedCategory;
			if (GlobalVariables.SelectedLanguage == "British_English") {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.englishIcon;
			} else if (GlobalVariables.SelectedLanguage == "German") {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.germanIcon;
			} else {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.languageIcon;
			}

			if (GlobalVariables.SelectedCategory == "All") {
				ToolbarItems.FirstOrDefault (i => i.Text == "CategoryFilter").Icon = ImageConstants.flagIcon;
			} else {
				ToolbarItems.FirstOrDefault (i => i.Text == "CategoryFilter").Icon = ImageConstants.filterIcon;
			}
			LoadDataAsync ();
		}

		protected async void LoadDataAsync ()
		{
			if (ViewModel == null || ViewModel.IsLoading)
				return;

			ViewModel.LoadItemsCommand.Execute (null);

			Device.BeginInvokeOnMainThread (() => {
				try {
					

					listView.ItemsSource = ViewModel.Files;
					ViewModel.IsRunning = false;
				} catch (Exception) {
					DisplayAlert ("Error", "Refresh the form.", "Ok");
				}

			});
		}

		protected StackLayout GetBreadCrumbs ()
		{

			var home = new Button {
				Text = Translation.Localize("HomeIcon"),
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Button))
					: Device.GetNamedSize (NamedSize.Large, typeof(Button)),
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
			};

			home.Clicked += (sender, args) => {
				var masterPage = this.Parent.Parent as TabbedPage;
				masterPage.Children [0].Title =  Translation.Localize ("StartIcon");
				masterPage.CurrentPage = masterPage.Children [0];
			};

			var spacer = new Label {
				Text = " | ",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Label))
					: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
			};

			var library = new Button {
				Text = Translation.Localize("LibraryIcon"),
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Button))
					: Device.GetNamedSize (NamedSize.Large, typeof(Button)),
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
			};

			library.Clicked += async (sender, args) => {
				await this.Navigation.PopAsync ();
			};

			var spacer2 = new Label {
				Text = " | ",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Label))
					: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
			};

			breadcrumbcategory = new Label {
				//Text = GlobalVariables.SelectedCategory,
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Label))
					: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
			};


			return new StackLayout {
				BackgroundColor = Color.White,
				Padding = new Thickness (10, 0, 0, 0),
				HeightRequest = 25,
				Orientation = StackOrientation.Horizontal,
				Children = {
					home,
					spacer,
					library,
					spacer2,
					breadcrumbcategory
				}
			};
		}

		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height); // Important!
			if ((int)grid.WidthRequest != (int)width) {
				grid.WidthRequest = width;
				if (listView != null) {
					listView.WidthRequest = width;
				}
				if (imageGrid != null) {
					imageGrid.WidthRequest = width;
					imageGrid.HeightRequest = height;
				}

				if (width > height) {
					this.BackgroundImage = ImageConstants.landscapebackground;
				} else {
					this.BackgroundImage = ImageConstants.backgroundImage;
				}
			}
		}
	}
}

