using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using FFImageLoading.Forms;

namespace MediandoUI
{
	public class NewsletterView : BaseContentPage
	{

		ListView listView;
		GridView imageGrid;
		Grid grid;
		LayoutType CurrentLayout;
		public static NewsletterView Instance;

		protected NewsLetterViewModel ViewModel {
			get { return BindingContext as NewsLetterViewModel; }
			set { BindingContext = value; }
		}

		public NewsletterView ()
		{
			NavigationPage.SetBackButtonTitle (this, Translation.Localize ("BackButton"));
			BindingContext = new NewsLetterViewModel ();
			ViewModel.IsRunning = true;
			Instance = this;
	
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
						ItemTemplate = new DataTemplate (typeof(NewsLetterCellTemplate)),
						SeparatorColor = Color.Transparent,
					};
					listView.ItemsSource = ViewModel.Files;
					listView.BackgroundColor = Color.Transparent;


					listView.ItemTapped += (sender, e) => {
						((ListView)sender).SelectedItem = null;
					};

					listView.ItemSelected += (sender, e) => {
						if (e.SelectedItem == null)
							return;

						var currentItem = (ProductCatalog)e.SelectedItem;
						var page = new DetailsPopup (currentItem, LibraryType.NewsLetter);
						this.Navigation.PushAsync (page, false);
					};

				}

				Device.OnPlatform 
				(
					iOS: () => { 
						grid = new Grid {
							VerticalOptions = LayoutOptions.Center,
							HorizontalOptions = LayoutOptions.Center,
							RowDefinitions = {
								new RowDefinition { Height = GridLength.Auto },
							},
							ColumnDefinitions = {
								new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
							}
						};
					},
					Android: () => {
						grid = new Grid {
							VerticalOptions = LayoutOptions.StartAndExpand,
							HorizontalOptions = LayoutOptions.Center,
							RowDefinitions = {
								new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
							},
							ColumnDefinitions = {
								new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
							}
						};
					},
					WinPhone: () => {
						grid = new Grid {
							VerticalOptions = LayoutOptions.Center,
							HorizontalOptions = LayoutOptions.Center,
							RowDefinitions = {
								new RowDefinition { Height = GridLength.Auto },
							},
							ColumnDefinitions = {
								new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
							}
						};
					}
				);


				grid.Children.Add (listView, 0, 0);
				grid.Children.Add (CreateLoadingIndicator (), 0, 0);
				grid.Children.Add (ShowEmptyResults (), 0, 0);
				this.Content = grid;
			} else {
				if (imageGrid == null) {
					Device.OnPlatform (iOS: () => {
						imageGrid = new GridView {
							RowSpacing = 5,
							Padding = 5,
							ColumnSpacing = 5,
							WidthRequest = App.ScreenWidth - 20,
							HeightRequest = App.ScreenHeight,
							ItemWidth = UIConstants.GetGridViewItemWidths (),
							ItemHeight = UIConstants.GetGridViewItemHeights (),
							ItemsSource = ViewModel.ImageFiles,
							ItemTemplate = new DataTemplate (typeof(GridViewCellTemplate)),
						};
					},
						Android: () => {
							imageGrid = new GridView {
								Padding = 20,
								RowSpacing = 20,
								ColumnSpacing = 20,
								ItemWidth = 500,
								ItemHeight = 732,
								ItemsSource = ViewModel.ImageFiles,
								ItemTemplate = new DataTemplate (typeof(DynamicNewsLetterTemplateLayout)),
								IsClippedToBounds = true,
							};
						});



					imageGrid.ItemSelected += (sender, e) => {
						var currentItem = (ProductCatalog)e.Value;
						var fileItem = ViewModel.Files.ToList ().FirstOrDefault (i => i.Id == currentItem.Id);
						var page = new DetailsPopup (fileItem, LibraryType.NewsLetter);
						Navigation.PushAsync (page, true);
					};



				}
				grid = new Grid {
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
					RowDefinitions = {
						new RowDefinition { Height = GridLength.Auto },
					},
					ColumnDefinitions = {
						new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					}
				};

				grid.Children.Add (imageGrid, 0, 0);
				grid.Children.Add (CreateLoadingIndicator (), 0, 0);
				grid.Children.Add (ShowEmptyResults (), 0, 0);
				this.Content = grid;
			}


		}

		void AddToolBarItems ()
		{
			ToolbarItems.Add (new ToolbarItem ("DisplayView", ImageConstants.tiledIcon, () => {

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
					var content = new NavigationPage (new NewsLetterFilters (FilterTypes.Languages));
					content.BarBackgroundColor = Color.Transparent;
					content.BarTextColor = Color.White;
					await Navigation.PushModalAsync (content, true);
				}));

			ToolbarItems.Add (new ToolbarItem ("Refresh", "corningimages/refresh.png", LoadDataAsync));
				

			ToolbarItems.Add (new ToolbarItem ("SearchFilter", ImageConstants.searchIcon, async () => {
				var content = new SearchView (LibraryType.NewsLetter);
				await Navigation.PushAsync (content, true);
			})
			);

		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			if (GlobalVariables.NewsLanguage == "British_English") {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.englishIcon;
			} else if (GlobalVariables.NewsLanguage == "German") {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.germanIcon;
			} else {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.languageIcon;
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

		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height); // Important!
			if (grid.WidthRequest != width) {
				grid.WidthRequest = width;
				if (listView != null) {
					listView.WidthRequest = width;
					listView.HeightRequest = height;
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