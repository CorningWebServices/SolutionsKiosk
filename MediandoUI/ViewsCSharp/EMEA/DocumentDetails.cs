using System;
using Xamarin.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace MediandoUI
{
	public class DocumentDetails : BaseContentPage
	{
		Label downloadlabel;
		ScrollView scrollView;

		public DocumentDetails (Downloads item)
		{
			this.BackgroundImage = ImageConstants.backgroundImage;

			var thumb = new Image { 
				WidthRequest = 150, 
				HeightRequest = 200,
				Source = GetSource (item.ThumbPath),
				BackgroundColor = ColorConstants.SemiOpaqueBackground

			};

			downloadlabel = 
				new Label { 
				Text = string.Format ("{0}", ((DateTime)item.DownloadDate).ToString ("d")), 
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Label))
					: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				TextColor = Color.White,  
			};
				

			var publishedlabel = new StackLayout {
				HorizontalOptions = LayoutOptions.Start,
				//Padding = 20,
				Orientation = StackOrientation.Vertical,
				Children = { 
					new CustomLabel { 
						Text = "Publication Date:", 
						FontSize = (Device.Idiom == TargetIdiom.Phone) 
							? Device.GetNamedSize (NamedSize.Small, typeof(Label))
							: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
						TextColor = Color.White, 
						FontAttributes = FontAttributes.Italic,
					},
					new CustomLabel { 
						Text = item.PublicationDate == null ? "" : string.Format ("{0}", ((DateTime)item.PublicationDate).ToString ("d")), 
						FontSize = (Device.Idiom == TargetIdiom.Phone) 
							? Device.GetNamedSize (NamedSize.Small, typeof(Label))
							: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
						TextColor = Color.White, 
						FontAttributes = FontAttributes.Bold,
					},
				}
			};

			var namelabel = new StackLayout {
				HorizontalOptions = LayoutOptions.Start,
				//Padding = 20,
				Orientation = StackOrientation.Vertical,
				Children = { 
					new CustomLabel { 
						Text = "File Name:", 
						FontSize = (Device.Idiom == TargetIdiom.Phone) 
							? Device.GetNamedSize (NamedSize.Small, typeof(Label))
							: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
						TextColor = Color.White, 
						FontAttributes = FontAttributes.Italic,
					},
					new CustomLabel { 
						Text = item.FileName, 
						FontSize = (Device.Idiom == TargetIdiom.Phone) 
							? Device.GetNamedSize (NamedSize.Small, typeof(Label))
							: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
						TextColor = Color.White, 
						FontAttributes = FontAttributes.Bold,
					},
				}
			};

			var description = new StackLayout {
				HorizontalOptions = LayoutOptions.Start,
				//Padding = 20,
				Orientation = StackOrientation.Vertical,
				Children = { 
					new CustomLabel { 
						Text = "Description:", 
						FontSize = (Device.Idiom == TargetIdiom.Phone) 
							? Device.GetNamedSize (NamedSize.Small, typeof(Label))
							: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
						TextColor = Color.White, 
						FontAttributes = FontAttributes.Italic,
					},
					new CustomLabel { 
						Text = item.Description, 
						FontSize = (Device.Idiom == TargetIdiom.Phone) 
							? Device.GetNamedSize (NamedSize.Small, typeof(Label))
							: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
						TextColor = Color.White,  
						FontAttributes = FontAttributes.Bold,
					},
				}
			};


			//Read Online Button
			var readOnline = new Button () {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex ("#006699"),
				TextColor = Color.White,
				HeightRequest = 40,
				WidthRequest = 140,
			};

			var download = new Button () {
				Text = "Delete",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex ("#006699"),
				TextColor = Color.White,
				HeightRequest = 40,
				WidthRequest = 140,
			};


			if (item.MimeType.StartsWith ("mp4")) {
				readOnline.Text = Translation.Localize ("PlayOfflineText");
			} else {
				readOnline.Text = Translation.Localize ("ReadOfflineText");
			}
	


			readOnline.Clicked += (sender, e) => {

				var btn = ((Button)sender);


				var pdfService = DependencyService.Get<IPdfService> ();
				if (pdfService == null)
					return;

				if (item.MimeType.StartsWith ("mp4")) {
					var page = (Page)Activator.CreateInstance (typeof(VideoView), item);
					this.ParentView.Navigation.PushAsync (page, true);
				} else {
					pdfService.OpenPDF (LibraryType.MyDocuments, item.FilePath, item.FileName,0, null);
				}

			};

			download.Clicked += async (sender, e) => {
				var currentitem = db.GetCatalogsByID(item.Id);


				var textToDisplay = 
					currentitem.MimeType.StartsWith ("mp4") 
					? Translation.Localize("DeleteVideoMessage")
					: Translation.Localize("DeleteDocumentMessage");

				var confirm = await this.DisplayAlert ("", textToDisplay, Translation.Localize("Yes"), Translation.Localize("No"));

				if (confirm) {
				var deleteService = DependencyService.Get<IDeleteService> ();
				if (deleteService == null)
					return;

				deleteService.DeleteFile (currentitem.FilePath, (bool completed) => {
					if (completed == true) {
						
						db.DeleteDownloadItem (currentitem.Id);
						if (item.MimeType.StartsWith ("mp4"))
							readOnline.Text = Translation.Localize ("PlayOnlineText");
						else
								readOnline.Text = Translation.Localize ("ReadOnlineText");

							download.Text = Translation.Localize ("DownloadText");

						downloadlabel.Text = "";
						this.Navigation.PopAsync ();
					}
					});
				}

			};

			var leftheader = new StackLayout {
				HorizontalOptions = LayoutOptions.Start,
				Orientation = StackOrientation.Vertical,
				Children = { 
					thumb,
					downloadlabel,
				}
			};

			var rightheader = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Vertical,
				Padding = new Thickness (0, 10, 0, 20),
				Children = { 
					//publicationlabel,
					readOnline,
					download
				}
			};

			var headerView = new StackLayout {
				Padding = 10,
				HorizontalOptions = LayoutOptions.Start,
				Orientation = StackOrientation.Horizontal,
				Children = { 
					leftheader,
					rightheader,
				}
			};

			var detailsView = new StackLayout {
				Padding = 10,
				HorizontalOptions = LayoutOptions.Start,
				Orientation = StackOrientation.Vertical,
				Children = { 
					publishedlabel, namelabel, description
				}
			};

//			contentFrame = new Frame {
//				OutlineColor = Color.FromRgba (255, 255, 255, 0.5),
//				//HasShadow = true,
//				HeightRequest = App.ScreenHeight,	
//				WidthRequest = App.ScreenWidth,	
//				HorizontalOptions = LayoutOptions.Center,
//				BackgroundColor = Color.FromRgba (255, 255, 255, 0.1),
//				VerticalOptions = LayoutOptions.Center,
//				Padding = 5,
//				Content = new StackLayout {
//					Padding = 0,
//					Children = { headerView, detailsView }
//				}
//			};
					

			scrollView = new ScrollView ();
			scrollView.Content = new StackLayout {
				BackgroundColor = Color.FromRgba (255, 255, 255, 0.1),
				Padding = 0,
				Children = { headerView, detailsView }
			};

			Content = scrollView;
		}

		public ImageSource GetSource (string filePath)
		{

			ImageSource source;
			if (filePath.StartsWith ("http")) {
				source = new UriImageSource {
					Uri = new Uri (filePath),
					CachingEnabled = true,
					CacheValidity = new TimeSpan (5, 0, 0, 0)
				};
			} else {
				source = ImageSource.FromFile (Path.Combine (GlobalVariables.DownloadPath, filePath));
			}

			return source;
		}

		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); // Important!
			//if (contentFrame.WidthRequest != width) {
			//				contentFrame.WidthRequest = width;
			//				contentFrame.HeightRequest = height;
			//				scrollView.HeightRequest = height;
			if (width > height) {
				this.BackgroundImage = ImageConstants.landscapebackground;
			} else {
				this.BackgroundImage = ImageConstants.backgroundImage;
			}
			//}
		}

	}

}

