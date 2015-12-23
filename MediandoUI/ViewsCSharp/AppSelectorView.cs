using System;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;


namespace MediandoUI
{
	public class AppSelectorView : BaseContentPage
	{
		protected BaseViewModel ViewModel {
			get { return BindingContext as BaseViewModel; }
			set { BindingContext = value; }
		}


		public AppSelectorView ()
		{	
			
			BindingContext = new BaseViewModel ();
			ViewModel.IsRunning = false;
			Grid grid = new Grid {
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,

				RowDefinitions = {
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star)  },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star)  },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star)  },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star)  },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = GridLength.Auto  },
					new ColumnDefinition { Width = GridLength.Auto },
				},

			}; 

			if (Device.Idiom == TargetIdiom.Phone) {
				grid.Padding = 10;
			} else {
				grid.Padding = 30;
			}
				
			var btnEMEA = ControlUtilities.TrialAppButton (
				              MainHeader: Translation.Localize ("AppTitleText") == "EN" ? "Data Centres,\nLAN, Campus,\nHarsh Environments" : 
																"Rechenzentren,\nLAN, Campus,\nRaue Umgebungen",
				              SubHeader: "Europe, Middle\nEast, Africa", 
				              details: ""
			              );


//			var btnEMEA = ControlUtilities.AppButton (
//				              MainHeader: "ENTERPRISE", 
//				              SubHeader: "EMEA", 
//				              details: (Device.Idiom == TargetIdiom.Phone) 
//				? "Europe, Middle\nEast, Africa"
//				: "Europe, Middle East,\nAfrica"	
//			              );

			//btnEMEA.BackgroundColor = Color.Red;

			TapGestureRecognizer tap = new TapGestureRecognizer ();
			tap.Tapped += async (sender, args) => {
				ViewModel.IsRunning = true;
				App.AppSelected = ApplicationID.EMEA;
				App.ShowAppSelection = false;

				var fileService = DependencyService.Get<IFileService> ();
				if (fileService != null) {
					fileService.GetDownloadsFolder ((string path) => {
						GlobalVariables.DownloadPath = path;
					});
				}

				await HttpService.CheckForDataUpdate (App.Database);
				ViewModel.IsRunning = false;
				await this.Navigation.PopModalAsync ();
			};

			btnEMEA.GestureRecognizers.Add (tap);

			grid.Children.Add (btnEMEA, 0, 0);




			Device.OnPlatform (
				iOS: () => {
					var layout = new StackLayout {
						Padding = 5,
						Children = {
							ControlUtilities.GetAppHeader (),
							grid
						}
					};
					this.Content = layout;
				},
				Android: () => {
					NavigationPage.SetTitleIcon (this, "corning_logo.png"); 

					var contentgrid = new Grid {
						VerticalOptions = LayoutOptions.Center,
						HorizontalOptions = LayoutOptions.Start,

						RowDefinitions = {
							new RowDefinition { Height = new GridLength (1, GridUnitType.Star)  },
						},
						ColumnDefinitions = {
							new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star)  },
						},
					}; 

					contentgrid.Children.Add(grid,0,0);
					contentgrid.Children.Add (CreateLoadingIndicator (), 0, 0);

					var layout = new StackLayout {
						Padding = 5,
						Children = {
							//ControlUtilities.GetAppHeader (),
							contentgrid,
							//CreateLoadingIndicator ()
						}
					};
					this.Content = layout;
				}
			);

			this.BackgroundImage = ImageConstants.backgroundImage;

		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			App.AppLastUsedTime = DateTime.Now;
		}

		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height); // Important!

			if (width > height) {
				this.BackgroundImage = ImageConstants.landscapebackground;
			} else {
				this.BackgroundImage = ImageConstants.backgroundImage;
			}
		
		}
			
	}
}

