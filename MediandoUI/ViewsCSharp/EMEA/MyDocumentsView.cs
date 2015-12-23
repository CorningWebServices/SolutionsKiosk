using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MediandoUI
{
	public class MyDocumentsView : BaseContentPage
	{

		ListView listView;
		GridView imageGrid;
		StackLayout contentLayout;
		double screenwidth;
		double screenheight;
		LayoutType CurrentLayout;
		public static MyDocumentsView Instance;

		protected MyDocumentsViewModel ViewModel {
			get { return BindingContext as MyDocumentsViewModel; }
			set { BindingContext = value; }
		}

		public MyDocumentsView ()
		{
			NavigationPage.SetBackButtonTitle (this, Translation.Localize ("BackButton"));
			BindingContext = new MyDocumentsViewModel ();
			ViewModel.IsRunning = true;
			CurrentLayout = LayoutType.ListLayout;
			SwitchLayouts (CurrentLayout);
			AddToolBarItems ();
			Instance = Instance;
			this.BackgroundImage = ImageConstants.backgroundImage;
		}

		void SwitchLayouts (LayoutType layoutType)
		{

			if (layoutType == LayoutType.ListLayout) {
				if (listView == null) {
					listView = new ListView {
						BackgroundColor = Color.White,
						HasUnevenRows = true,
						ItemTemplate = new DataTemplate (typeof(DocumentsCellTemplate)),
						ItemsSource = ViewModel.ImageFiles,
						SeparatorColor = Color.Transparent,
					};
					//listView.ItemsSource = ViewModel.Files;
					listView.BackgroundColor = Color.Transparent;

					listView.ItemTapped += (sender, e) => {
						var fileItem = (Downloads)e.Item;
						var page = new DocumentDetails (fileItem);
						this.Navigation.PushAsync (page, true);
					};
				}
				contentLayout = new StackLayout {
					Children = {
						listView,
					}
				};

			} else {
				if (imageGrid == null) {
					Device.OnPlatform (iOS: () => {
						imageGrid = new GridView {
							RowSpacing = 5,
							Padding = 5,
							ColumnSpacing = 5,
							WidthRequest = App.ScreenWidth,
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
								ItemTemplate = new DataTemplate (typeof(DynamicDocsTemplateLayout)),
								IsClippedToBounds = true,
							};
						});
					

					imageGrid.ItemSelected += (sender, e) => {
						var fileItem = (Downloads)e.Value;
						var page = new DocumentDetails (fileItem);
						this.Navigation.PushAsync (page, true);
					};
				} else {
					imageGrid.WidthRequest = screenwidth;
					imageGrid.HeightRequest = screenheight;
				}
				contentLayout = new StackLayout {
					Children = {
						imageGrid,
					}
				};

			}
			this.Content = contentLayout;
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
					var content = new NavigationPage (new DocumentsFilters (FilterTypes.Languages));
					content.BarBackgroundColor = Color.Transparent;
					content.BarTextColor = Color.White;
					await Navigation.PushModalAsync (content, true);
				}));


			ToolbarItems.Add (new ToolbarItem ("CategoryFilter", ImageConstants.filterIcon, async () => {
				var content = new NavigationPage (new DocumentsFilters (FilterTypes.Categories));
				content.BarBackgroundColor = Color.Transparent;
				content.BarTextColor = Color.White;
				await Navigation.PushModalAsync (content, true);

			})
			);

			ToolbarItems.Add (new ToolbarItem ("SearchFilter", ImageConstants.searchIcon, async () => {
				var content = new SearchView (LibraryType.MyDocuments);
				await Navigation.PushAsync (content, true);
			})
			);

				
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			if (GlobalVariables.DocsLanguage == "British_English") {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.englishIcon;
			} else if (GlobalVariables.DocsLanguage == "German") {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.germanIcon;
			} else {
				ToolbarItems.FirstOrDefault (i => i.Text == "LanguageFilter").Icon = ImageConstants.languageIcon;
			}

			if (GlobalVariables.DocsCategory == "All") {
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
			ViewModel.IsRunning = false;
		}

		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height); // Important!
			if (contentLayout.WidthRequest != width) {
				screenwidth = width;
				screenheight = height;
				contentLayout.WidthRequest = width;
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

