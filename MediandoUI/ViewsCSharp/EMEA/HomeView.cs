using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace MediandoUI
{
	
	public class HomeView : BaseContentPage
	{
		Grid grid;
		StackLayout contentLayout;

		protected BaseViewModel ViewModel {
			get { return BindingContext as BaseViewModel; }
			set { BindingContext = value; }
		}

		AppSelectorView loginModal = new AppSelectorView();
		void tbi_Clicked (object sender, EventArgs e)
		{
			var selector = new NavigationPage (loginModal) {
				BarBackgroundColor = Color.Black,
				BarTextColor = Color.White,
			};
			this.Navigation.PushModalAsync (selector, false);
		}

		public HomeView ()
		{
			NavigationPage.SetTitleIcon (this, "corning_logo.png"); 
	
			ToolbarItem tbi = new ToolbarItem ();
			tbi.Text = "Start";
			tbi.Icon = "home.png";
			tbi.Clicked += tbi_Clicked;
			this.ToolbarItems.Add (tbi);

			loginModal.Disappearing += (sender, e) => {
				this.OnAppearing();
			};

			NavigationPage.SetBackButtonTitle (this, Translation.Localize ("BackButton"));
			BindingContext = new BaseViewModel ();

			grid = new Grid {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.Center,
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};
					

			var btnLibrary = HomePageButtons.GetHomePageTextButtons (
				                 ImageSource: ImageConstants.libraryhomeIcon,
				                 MainText: Translation.Localize ("LibraryLinkMainText"), 
				                 DetailsText: Translation.Localize ("LibraryLinkDescription")
			                 );

			TapGestureRecognizer tapLibrary = new TapGestureRecognizer ();
			tapLibrary.Tapped += (sender, args) => {
				Device.OnPlatform (
					iOS: () => {
						var masterPage = this.Parent.Parent as TabbedPage;
						masterPage.CurrentPage = masterPage.Children [1];
						masterPage.Children [0].Title = Translation.Localize ("HomeIcon");
					},
					Android: () => {
						var masterPage = this.Parent as TabbedPage;
						masterPage.CurrentPage = masterPage.Children [1];
					}
				);
			};
			btnLibrary.GestureRecognizers.Add (tapLibrary);



			var btnNewsLetter = HomePageButtons.GetHomePageTextButtons (
				                    ImageSource: ImageConstants.newshomeIcon,
				                    MainText: Translation.Localize ("NewsLetterLinkMainText"), 
				                    DetailsText: Translation.Localize ("NewsLetterLinkDescription")
				                  //  MainText: "NEWSLETTER", 
				                  //  DetailsText: "New Corning products, system solutions, News and Events"
			                    );

			TapGestureRecognizer tapNews = new TapGestureRecognizer ();
			tapNews.Tapped += (sender, args) => {
				Device.OnPlatform (
					iOS: () => {
						var masterPage = this.Parent.Parent as TabbedPage;
						masterPage.CurrentPage = masterPage.Children [2];
						masterPage.Children [0].Title = Translation.Localize ("HomeIcon");
					},
					Android: () => {
						var masterPage = this.Parent as TabbedPage;
						masterPage.CurrentPage = masterPage.Children [2];
					}
				);
			};
			btnNewsLetter.GestureRecognizers.Add (tapNews);



			var btnDocs = HomePageButtons.GetHomePageTextButtons (
				              ImageSource: ImageConstants.documentshomeIcon,
				              MainText: Translation.Localize ("MyDocsLinkMainText"), 
				              DetailsText: Translation.Localize ("MyDocsLinkDescription")
				             // MainText: "MY DOCUMENTS", 
				            //  DetailsText: "Collection of Corning documents on my device"
			              );

			TapGestureRecognizer tapDocs = new TapGestureRecognizer ();
			tapDocs.Tapped += (sender, args) => {
				Device.OnPlatform (
					iOS: () => {
						var masterPage = this.Parent.Parent as TabbedPage;
						masterPage.CurrentPage = masterPage.Children [3];
						masterPage.Children [0].Title = Translation.Localize ("HomeIcon");
					},
					Android: () => {
						var masterPage = this.Parent as TabbedPage;
						masterPage.CurrentPage = masterPage.Children [3];
					}
				);
			};
			btnDocs.GestureRecognizers.Add (tapDocs);



			var btnCorning = HomePageButtons.GetHomePageTextButtons (
				                 ImageSource: ImageConstants.abouthomeicon,
				                 MainText: Translation.Localize ("AboutCorningLinkMainText"), 
				                 DetailsText: Translation.Localize ("AboutCorningLinkDescription")
				                 //MainText: "ABOUT CORNING", 
				                 //DetailsText: "Contact us, Corporate, Data Protection, Copyright"
			                 );

			TapGestureRecognizer tapCorning = new TapGestureRecognizer ();
			tapCorning.Tapped += (sender, args) => {
				Device.OnPlatform (
					iOS: async () => {
						var masterPage = this.Parent.Parent as TabbedPage;
						masterPage.Children [0].Title = Translation.Localize ("HomeIcon");
						var page = (Page)Activator.CreateInstance (typeof(AboutCorning));
						await this.Navigation.PushAsync (page, true);
					},
					Android: async () => {
						await this.Navigation.PushAsync (new AboutCorning (),true);
					}
				);
			};
			btnCorning.GestureRecognizers.Add (tapCorning);



			var corningWebsite = HomePageButtons.CreateEMEAHomeButton (
				                     ImageSource: ImageConstants.websitesIcon,
				                     Description: Translation.Localize ("CorningWebsite") 
			                     );

			TapGestureRecognizer tapCorningLinks = new TapGestureRecognizer ();
			tapCorningLinks.Tapped += (sender, args) => {
				Device.OnPlatform (
					iOS: async () => {
						var masterPage = this.Parent.Parent as TabbedPage;
						masterPage.Children [0].Title = Translation.Localize ("HomeIcon");
						var fileItem = new CorningLinks ("CorningWebsite", Translation.Localize ("CorningWebsiteLink"));
						var page = (Page)Activator.CreateInstance (typeof(WebPage), fileItem);
						await this.Navigation.PushAsync (page, true);
					},
					Android: async () => {
						var fileItem = new CorningLinks ("CorningWebsite", Translation.Localize ("CorningWebsiteLink"));
						var page = (Page)Activator.CreateInstance (typeof(WebPage), fileItem);
						await this.Navigation.PushAsync (page, true);
					}
				);


			};
			corningWebsite.GestureRecognizers.Add (tapCorningLinks);

			var productCatalog = HomePageButtons.CreateEMEAHomeButton (
				                     ImageSource: ImageConstants.catalogIcon,
				                     Description: Translation.Localize ("ProductCatalog"));
			TapGestureRecognizer tapCatalog = new TapGestureRecognizer ();
			tapCatalog.Tapped += (sender, args) => {
				// Analysis disable once ConvertToLambdaExpression
				Device.OnPlatform (
					iOS: async () => {
						var masterPage = this.Parent.Parent as TabbedPage;
						masterPage.Children [0].Title = Translation.Localize ("HomeIcon");
						var fileItem = new CorningLinks ("ProductCatalog", Translation.Localize ("ProductCatalogLink"));
						var page = (Page)Activator.CreateInstance (typeof(WebPage), fileItem);
						await this.Navigation.PushAsync (page, true);
					},
					Android: async () => {
						var fileItem = new CorningLinks ("ProductCatalog", Translation.Localize ("ProductCatalogLink"));
						var page = (Page)Activator.CreateInstance (typeof(WebPage), fileItem);
						await this.Navigation.PushAsync (page, true);
					}
				);

			};
			productCatalog.GestureRecognizers.Add (tapCatalog);


			Grid grdButtons = new Grid {
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star)  },
				}
			};



			grdButtons.Children.Add (corningWebsite, 0, 0);
			grdButtons.Children.Add (productCatalog, 1, 0);

			if (Device.Idiom != TargetIdiom.Phone) {
				grdButtons.Padding = 30;
				grid.WidthRequest = 520;
			} else {
				if (App.CurrentDevice == IOSDevices.IPhone4S) {
					grid.Padding = new Thickness (10, 5, 10, 0);
				} else if (App.CurrentDevice == IOSDevices.IPhone5 || App.CurrentDevice == IOSDevices.IPhone5S) {
					grid.Padding = 10;
				} else {
					if (GlobalVariables.CurrentLocale.StartsWith ("en")) {
						grid.Padding = new Thickness (10, 20, 10, 5);
					} else {
						grid.Padding = new Thickness (10, 20, 10, 0);
					}
				} 
			}


			grid.Children.Add (btnLibrary, 0, 0);
			grid.Children.Add (btnNewsLetter, 0, 1);
			grid.Children.Add (btnDocs, 0, 2);
			grid.Children.Add (btnCorning, 0, 3);
			grid.Children.Add (grdButtons, 0, 4);

			var scrolView = new ScrollView ();
			scrolView.Content = grid;

			Device.OnPlatform (
				iOS: () => contentLayout = new StackLayout { 
					Padding = 0,
					Children = {
						ControlUtilities.GetAppHeader (),
						scrolView
					},
				},
				Android: () => {
					//grid.Children.Add (CreateLoadingIndicator (), 0, 2);
					contentLayout = new StackLayout { 
						Padding = 0,
						Children = {
							//ControlUtilities.GetAppHeader (),
							scrolView
						},
					};
				},
				WinPhone: () => contentLayout = new StackLayout { 
					Padding = 0,
					Children = {
						ControlUtilities.GetAppHeader (),
						scrolView
					},
				}
			);
		 	
			this.Content = contentLayout;
			this.BackgroundImage = ImageConstants.backgroundImage;	

		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			Device.OnPlatform (
				iOS: () => {
					var masterPage = this.Parent.Parent as TabbedPage;
					masterPage.Children [0].Title = Translation.Localize ("StartIcon");
					masterPage.Children [0].IsEnabled = false;
					App.ShowAppSelection = true;
				}
			);
		}

		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height); // Important!
			if (contentLayout.WidthRequest != width) {
				contentLayout.WidthRequest = width;
				if (width > height) {
					this.BackgroundImage = ImageConstants.landscapebackground;
				} else {
					this.BackgroundImage = ImageConstants.backgroundImage;
				}
				if (Device.Idiom != TargetIdiom.Phone) {
					grid.WidthRequest = 520;
				} else {
					grid.WidthRequest = width;
				}
			}
		}
	}
}


