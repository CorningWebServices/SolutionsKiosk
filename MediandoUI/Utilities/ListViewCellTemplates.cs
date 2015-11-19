using System;
using Xamarin.Forms;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Threading;
using FFImageLoading.Forms;


namespace MediandoUI
{
	#region "ListViewCellTemplate"
	public class ListViewCellTemplate : ViewCell
	{
		public static double DeviceFontSize ()
		{
			if (App.CurrentDevice == IOSDevices.IPhone4S) {
				return Device.GetNamedSize (NamedSize.Small, typeof(Label));
			} else if (App.CurrentDevice == IOSDevices.IPhone5) {
				return Device.GetNamedSize (NamedSize.Small, typeof(Label));
			} else if (App.CurrentDevice == IOSDevices.IPhone5S) {
				return Device.GetNamedSize (NamedSize.Small, typeof(Label));
			} else if (App.CurrentDevice == IOSDevices.IPhone6) {
				return Device.GetNamedSize (NamedSize.Medium, typeof(Label));
			} else if (App.CurrentDevice == IOSDevices.IPhone6Plus) {
				return Device.GetNamedSize (NamedSize.Large, typeof(Label));
			} 
				//Simulator Debug Testing.
				else {
				return Device.GetNamedSize (NamedSize.Medium, typeof(Label));
			}
				
		}

		public ListViewCellTemplate ()
		{
			var nameLabel = new Label () {
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? DeviceFontSize ()
					: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand,
			};
			nameLabel.SetBinding (Label.TextProperty, "Name");


			var tapImage = new Image () {
				Source = ImageConstants.nextIcon,
				HorizontalOptions = LayoutOptions.End,
				HeightRequest = 18,
				WidthRequest = 18,
			};

			Grid grid = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = GridLength.Auto },
				}
			};

			grid.Children.Add (nameLabel, 0, 0);
			grid.Children.Add (tapImage, 1, 0);


			var frame = new Frame {
				OutlineColor = ColorConstants.SemiOpaqueOutline,
				HasShadow = true,
				HorizontalOptions = LayoutOptions.Center,
				BackgroundColor = ColorConstants.SemiOpaqueBackground,
				VerticalOptions = LayoutOptions.Center,
				Padding = 5,
				Content = new StackLayout {
					Padding = 0,
					Children = {
						grid
					}
				}
			};

			this.View = frame;
		}
	}
	 
	#endregion

	public class NoCacheConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!(value is string)) {
				System.Diagnostics.Debug.WriteLine ("No Value");
				return null;
			} else {
				//System.Diagnostics.Debug.WriteLine ((string)value);
				if (((string)value).StartsWith ("http")) {
					return (string)value;
					//return ImageSource.FromUri(new Uri ((string)value));
				} else {
					var path = Path.Combine (GlobalVariables.DownloadPath, (string)value);
					return ImageSource.FromFile (path);
					//return path;
				}
			}
		
		}

		public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}

	public class TextConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (((string)value).ToLower() == "videos") {
				return Translation.Localize("PlayOnlineText"); 
			} else {
				return Translation.Localize("ReadOnlineText");
			}
		}

		public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}

	public class OfflineTextConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (((string)value).ToLower() == "videos") {
				return Translation.Localize ("PlayOfflineText");
			} else {
				return Translation.Localize("ReadOfflineText");
			}
		}

		public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}

	public class DownloadTextConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (string.IsNullOrWhiteSpace(value == null ? "" : value.ToString())) {
				return Translation.Localize ("DownloadText");
			} else {
				return Translation.Localize ("DeleteText");
			}
		}

		public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}

	public class DateConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null) {
				return ""; 
			} else {
				return ((DateTime)value).ToString ("d");
			}
		}

		public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}

	public class DownloadDateConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null) {
				return "  "; 
			} else {
				return ((DateTime)value).ToString ("d");
			}
		}

		public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}


	public class GridViewCellTemplate : ViewCell
	{
		
		public GridViewCellTemplate ()
		{

//			var thumbnailImage = new Image () {
//				HorizontalOptions = LayoutOptions.Center,
//				VerticalOptions = LayoutOptions.Center,
//				BackgroundColor = ColorConstants.SemiOpaqueBackground,
//				WidthRequest = UIConstants.GetGridViewItemWidths (),
//				HeightRequest = UIConstants.GetGridViewItemHeights () - 40,
//				Source = "New/foldedpdf.png"
//			};
//			thumbnailImage.SetBinding (Image.SourceProperty, new Binding ("ThumbPath", converter: new NoCacheConverter ()));

			var thumbnailImage = new CachedImage() {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				WidthRequest = UIConstants.GetGridViewItemWidths (),
				HeightRequest = UIConstants.GetGridViewItemHeights () - 40,
				BackgroundColor = ColorConstants.SemiOpaqueBackground,

				CacheDuration = TimeSpan.FromDays(30),
				DownsampleHeight = UIConstants.GetThumbnailHeight ()-100,
				RetryCount = 3,
				RetryDelay = 250,
				TransparencyEnabled = false,
				// Shown after loading error occurs:
				ErrorPlaceholder = "cornimages/loading.png",
				// Shown before targe image is loaded:
				LoadingPlaceholder = "cornimages/loading.png",
			};

			thumbnailImage.SetBinding (CachedImage.SourceProperty, new Binding ("ThumbPath", converter: new NoCacheConverter ()));

//			var thumbnailImage = new CachedImage() {
//				HorizontalOptions = LayoutOptions.StartAndExpand,
//				VerticalOptions = LayoutOptions.StartAndExpand,
//				WidthRequest = UIConstants.GetGridViewItemWidths (),
//				HeightRequest = UIConstants.GetGridViewItemHeights () - 40,
//				BackgroundColor = ColorConstants.SemiOpaqueBackground,
//
//				CacheDuration = TimeSpan.FromDays(30),
//				DownsampleHeight = UIConstants.GetThumbnailHeight ()-100,
//				RetryCount = 3,
//				RetryDelay = 250,
//				TransparencyEnabled = false,
//				// Shown after loading error occurs:
//				ErrorPlaceholder = "cornimages/loading.png",
//				// Shown before targe image is loaded:
//				LoadingPlaceholder = "New/foldedpdf.png"
//			};
//
//			thumbnailImage.SetBinding (CachedImage.SourceProperty, new Binding ("ThumbPath", converter: new NoCacheConverter ()));


			var titleLabel = new CustomLabel2 () {
				FontSize = UIConstants.GetGridViewFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand,
				WidthRequest = UIConstants.GetGridViewItemWidths (),
				HeightRequest = 40,
			};
			titleLabel.SetBinding (Label.TextProperty, "FileName");

			this.View = new StackLayout {
				WidthRequest = UIConstants.GetGridViewItemWidths (),
				HeightRequest = UIConstants.GetGridViewItemHeights (),
				Orientation = StackOrientation.Vertical,
				Children = {
					thumbnailImage,
					titleLabel
				}
			};
		}
	}

	public class DocumentsCellTemplate : ViewCell
	{

		public DocumentsCellTemplate ()
		{
			var publishLabel = new Label () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand,
			};
			publishLabel.SetBinding (Label.TextProperty, new Binding ("PublicationDate", converter: new DateConverter ()));

			var nameLabel = new CustomLabel () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.StartAndExpand,
				LineBreakMode = LineBreakMode.TailTruncation,
			};
			nameLabel.SetBinding (Label.TextProperty, "FileName");

			var descriptionLabel = new CustomLabel2 () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.StartAndExpand,
				LineBreakMode = LineBreakMode.TailTruncation,
			};
			descriptionLabel.SetBinding (Label.TextProperty, "Description");

			var thumbnailImage = new CachedImage() {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand,
				HeightRequest = UIConstants.GetThumbnailHeight (),
				WidthRequest = UIConstants.GetThumbnailWidth (),
				BackgroundColor = ColorConstants.SemiOpaqueBackground,

				CacheDuration = TimeSpan.FromDays(30),
				DownsampleHeight = UIConstants.GetThumbnailHeight ()-100,
				RetryCount = 3,
				RetryDelay = 250,
				TransparencyEnabled = false,
				// Shown after loading error occurs:
				ErrorPlaceholder = "cornimages/loading.png",
				// Shown before targe image is loaded:
				LoadingPlaceholder = "cornimages/loading.png",
			};

			thumbnailImage.SetBinding (CachedImage.SourceProperty, new Binding ("ThumbPath", converter: new NoCacheConverter ()));

			var downloadLabel = new Label () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand,
			};
			downloadLabel.SetBinding (Label.TextProperty, new Binding ("DownloadDate", converter: new DownloadDateConverter ()));


			//Read Online Button
			var readOnline = new Button () {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex ("#006699"),
				TextColor = Color.White,
				HeightRequest = UIConstants.GetButtonHeight (),
				WidthRequest = UIConstants.GetButtonWidth (),
			};

			readOnline.SetBinding (Button.TextProperty, new Binding ("CategoryCode", converter: new OfflineTextConverter ()));
			readOnline.SetBinding (Button.CommandParameterProperty, new Binding ("."));

			readOnline.Clicked += (sender, e) => {

				var btn = ((Button)sender);

				var fileItem = (Downloads)btn.CommandParameter;

				var pdfService = DependencyService.Get<IPdfService> ();
				if (pdfService == null)
					return;

				if (fileItem.MimeType.StartsWith ("mp4")) {
					var page = (Page)Activator.CreateInstance (typeof(DownloadViewer), fileItem);
					this.ParentView.Navigation.PushAsync (page, true);
				} else {
					pdfService.OpenPDF (LibraryType.MyDocuments, fileItem.FilePath, fileItem.FileName, 0, null);
				}

			};

			//Download Button
			var download = new Button () {
				Text = Translation.Localize ("DeleteText"),
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex ("#006699"),
				TextColor = Color.White,
				HeightRequest = UIConstants.GetButtonHeight (),
				WidthRequest = UIConstants.GetButtonWidth (),
			};
			download.SetBinding (Button.CommandParameterProperty, new Binding ("."));

			download.Clicked += async (sender, e) => {

				var btn = ((Button)sender);
				//download.IsEnabled = false;
				var fileItem = (Downloads)btn.CommandParameter;
				var parent = (MyDocumentsView)this.ParentView.ParentView.Parent;

				var textToDisplay = 
					fileItem.MimeType.StartsWith ("mp4") 
					? Translation.Localize ("DeleteVideoMessage")
					: Translation.Localize ("DeleteDocumentMessage");



				var confirm = await parent.DisplayAlert ("", textToDisplay, Translation.Localize ("Yes"), Translation.Localize ("No"));

				if (confirm) {

					var deleteService = DependencyService.Get<IDeleteService> ();
					if (deleteService == null)
						return;

					deleteService.DeleteFile (fileItem.FilePath, (bool completed) => {
						if (completed == true) {
							var ViewModel = (MyDocumentsViewModel)this.Parent.BindingContext;
							ViewModel.DocFileID = fileItem.Id;
							ViewModel.DeleteDocumentsCommand.Execute (null);
							//downloadLabel.Text = "";
						}
						//download.IsEnabled = true;
					});

				}
			};

			Grid grid = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Center,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			Grid details = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },

				}
			};

			details.Children.Add (publishLabel, 0, 0);
			details.Children.Add (nameLabel, 0, 1);
			details.Children.Add (descriptionLabel, 0, 2);
			details.Children.Add (readOnline, 0, 3);
			details.Children.Add (download, 0, 4);

			Grid leftdetails = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			leftdetails.Children.Add (thumbnailImage, 0, 0);
			leftdetails.Children.Add (downloadLabel, 0, 1);

			grid.Children.Add (leftdetails, 0, 0);
			grid.Children.Add (details, 1, 0);


			var frame = new Frame {
				OutlineColor = Color.FromRgba (255, 255, 255, 0.5),
				HasShadow = true,
				HorizontalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromRgba (255, 255, 255, 0.1),
				VerticalOptions = LayoutOptions.Center,
				Padding = 5,
				Content = new StackLayout {
					Padding = 0,
					Children = {
						grid
					}
				}
			};

			this.View = frame;
		}
	}

	public class LibraryDetailsCellTemplate : ViewCell
	{

		public LibraryDetailsCellTemplate ()
		{
			var publishLabel = new Label () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand,
			};
			publishLabel.SetBinding (Label.TextProperty, new Binding ("PublicationDate", converter: new DateConverter ()));

			var nameLabel = new CustomLabel () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.StartAndExpand,
				LineBreakMode = LineBreakMode.TailTruncation,
			};
			nameLabel.SetBinding (Label.TextProperty, "FileName");

			var descriptionLabel = new CustomLabel () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.StartAndExpand,
				LineBreakMode = LineBreakMode.TailTruncation,
			};
			descriptionLabel.SetBinding (Label.TextProperty, "Description");

			var thumbnailImage = new CachedImage() {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand,
				HeightRequest = UIConstants.GetThumbnailHeight (),
				WidthRequest = UIConstants.GetThumbnailWidth (),
				BackgroundColor = ColorConstants.SemiOpaqueBackground,

				CacheDuration = TimeSpan.FromDays(30),
				DownsampleHeight = UIConstants.GetThumbnailHeight ()-100,
				RetryCount = 3,
				RetryDelay = 250,
				TransparencyEnabled = false,
				// Shown after loading error occurs:
				ErrorPlaceholder = "cornimages/loading.png",
				// Shown before targe image is loaded:
				LoadingPlaceholder = "cornimages/loading.png",
			};

			thumbnailImage.SetBinding (CachedImage.SourceProperty, new Binding ("ThumbPath", converter: new NoCacheConverter ()));

			var downloadLabel = new Label () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand,
			};
			downloadLabel.SetBinding (Label.TextProperty, new Binding ("DownloadDate", converter: new DownloadDateConverter ()));


			//Read Online Button
			var readOnline = new Button () {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex ("#006699"),
				TextColor = Color.White,
				HeightRequest = UIConstants.GetButtonHeight (),
				WidthRequest = UIConstants.GetButtonWidth (),
				FontSize = UIConstants.GetHomePageFontSize (),
			};
			readOnline.SetBinding (Button.TextProperty, new Binding ("ButtonText"));
			readOnline.SetBinding (Button.CommandParameterProperty, new Binding ("."));

			readOnline.Clicked += (sender, e) => {

				var btn = ((Button)sender);

				var ViewModel = (LibraryDetailsViewModel)this.Parent.BindingContext;
				var currentItem = (ProductCatalog)btn.CommandParameter;
				var fileItem = ViewModel.Files.ToList ().FirstOrDefault (i => i.Id == currentItem.Id);

				var pdfService = DependencyService.Get<IPdfService> ();
				if (pdfService == null)
					return;

				if (fileItem.MimeType.StartsWith ("mp4")) {
					var page = (Page)Activator.CreateInstance (typeof(VideoView), fileItem);
						this.ParentView.Navigation.PushAsync (page, true);
				} else {
					if (fileItem.CategoryCode == "newsletter") {
						pdfService.OpenPDF (LibraryType.NewsLetter, fileItem.FilePath, fileItem.FileName, 0, null);
					} else {
						
						pdfService.OpenPDF (LibraryType.All, fileItem.FilePath, fileItem.FileName, 0, null);

					}
				}

			};

			//Download Button
			var download = new Button () {
				Text = Translation.Localize("DownloadText"),
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex ("#006699"),
				TextColor = Color.White,
				HeightRequest = UIConstants.GetButtonHeight (),
				WidthRequest = UIConstants.GetButtonWidth (),
				FontSize = UIConstants.GetHomePageFontSize (),
			};
			download.SetBinding (Button.TextProperty, new Binding ("DownloadDate", converter: new DownloadTextConverter ()));
			download.SetBinding (Button.CommandParameterProperty, new Binding ("."));

			download.Clicked += async (sender, e) => {

				var btn = ((Button)sender);
				var ViewModel = (LibraryDetailsViewModel)this.Parent.BindingContext;
				var currentItem = (ProductCatalog)btn.CommandParameter;
				var parent = (LibraryDetailsView)this.ParentView.ParentView.Parent;

				var fileItem = ViewModel.Files.ToList ().FirstOrDefault (i => i.Id == currentItem.Id);
				if (fileItem.DownloadDate == null) {
					if (GlobalVariables.WifiDownloadOnly) {
						if (!App.IsWifiReachable ()) {
							await parent.DisplayAlert ("", GlobalVariables.WifiConnectionOnlyAlert, "Ok");
							return;
						}
					}

					var textToDisplay = 
						currentItem.MimeType.StartsWith ("mp4")
						? Translation.Localize("DownloadVideoMessage")
						: Translation.Localize("DownloadDocumentMessage");



					var confirm = await parent.DisplayAlert ("", textToDisplay, Translation.Localize ("Yes"), Translation.Localize ("No"));

					if (confirm) {
						var pdfService = DependencyService.Get<IDownloadService> ();
						if (pdfService == null)
							return;

						pdfService.DownloadData (fileItem, (string filePath) => {
							if (filePath != "") {
								fileItem.FilePath = filePath;
								fileItem.ThumbPath = filePath.Replace (".pdf", ".jpeg").Replace (".mp4", ".jpeg");
								if (fileItem.MimeType.StartsWith ("mp4"))
									readOnline.Text = Translation.Localize("PlayOfflineText");
								else
									readOnline.Text = Translation.Localize("ReadOfflineText");

								download.Text = Translation.Localize("DeleteText");
								downloadLabel.Text = DateTime.Now.ToString("d");
								ViewModel.fileItem = fileItem;
								ViewModel.InsertDocumentsCommand.Execute (null);
							}
						});
					}
				} else {
					var textToDisplay = 
						currentItem.MimeType.StartsWith ("mp4")
						? Translation.Localize("DeleteVideoMessage")
						: Translation.Localize("DeleteDocumentMessage");



					var confirm = await parent.DisplayAlert ("", textToDisplay, Translation.Localize("Yes"), Translation.Localize("No"));
					if(confirm)
					{
						var deleteService = DependencyService.Get<IDeleteService> ();
						if (deleteService == null)
							return;

						deleteService.DeleteFile (fileItem.FilePath, (bool completed) => {
							if (completed == true) {
								if (fileItem.MimeType.StartsWith ("mp4"))
									readOnline.Text = Translation.Localize("PlayOnlineText");
								else
									readOnline.Text = Translation.Localize("ReadOnlineText");

								download.Text = Translation.Localize("DownloadText");
								downloadLabel.Text = "";
								ViewModel.DocFileID = fileItem.Id;
								ViewModel.DeleteDocumentsCommand.Execute (null);
							}
						});
					}
				}

			};

			Grid grid = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Center,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			Grid details = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },

				}
			};

			details.Children.Add (publishLabel, 0, 0);
			details.Children.Add (nameLabel, 0, 1);
			details.Children.Add (descriptionLabel, 0, 2);

			details.Children.Add (readOnline, 0, 3);
			details.Children.Add (download, 0, 4);



			Grid leftdetails = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			leftdetails.Children.Add (thumbnailImage, 0, 0);
			leftdetails.Children.Add (downloadLabel, 0, 1);

			grid.Children.Add (leftdetails, 0, 0);
			grid.Children.Add (details, 1, 0);


			var frame = new Frame {
				OutlineColor = Color.FromRgba (255, 255, 255, 0.5),
				HasShadow = true,
				HorizontalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromRgba (255, 255, 255, 0.1),
				VerticalOptions = LayoutOptions.Center,
				Padding = 5,
				Content = new StackLayout {
					Padding = 0,
					Children = {
						grid
					}
				}
			};

			this.View = frame;
		}
	}

	public class NewsLetterCellTemplate : ViewCell
	{
		public NewsLetterCellTemplate ()
		{
			var publishLabel = new Label () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand,
			};
			publishLabel.SetBinding (Label.TextProperty, new Binding ("PublicationDate", converter: new DateConverter ()));

			var nameLabel = new CustomLabel () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.StartAndExpand,
				LineBreakMode = LineBreakMode.TailTruncation,
			};
			nameLabel.SetBinding (Label.TextProperty, "FileName");

			var descriptionLabel = new CustomLabel () {
				FontSize = UIConstants.GetHomePageFontSize (),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.StartAndExpand,
				LineBreakMode = LineBreakMode.TailTruncation,
			};
			descriptionLabel.SetBinding (Label.TextProperty, "Description");


			var thumbnailImage = new Image () {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand,
				HeightRequest = UIConstants.GetThumbnailHeight (),
				WidthRequest = UIConstants.GetThumbnailWidth (),
				BackgroundColor = ColorConstants.SemiOpaqueBackground,
			};
			thumbnailImage.SetBinding (Image.SourceProperty, new Binding ("ThumbPath", converter: new NoCacheConverter ()));

			var downloadLabel = new Label () {
				FontSize = (Device.Idiom == TargetIdiom.Phone) 
					? Device.GetNamedSize (NamedSize.Small, typeof(Label))
					: Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.StartAndExpand,
			};
			downloadLabel.SetBinding (Label.TextProperty, new Binding ("DownloadDate", converter: new DownloadDateConverter ()));


			//Read Online Button
			var readOnline = new Button () {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex ("#006699"),
				TextColor = Color.White,
				HeightRequest = UIConstants.GetButtonHeight (),
				WidthRequest = UIConstants.GetButtonWidth (),
			};
			readOnline.SetBinding (Button.TextProperty, new Binding ("ButtonText"));
			readOnline.SetBinding (Button.CommandParameterProperty, new Binding ("."));

			readOnline.Clicked += (sender, e) => {

				var btn = ((Button)sender);
				var ViewModel = (NewsLetterViewModel)this.Parent.BindingContext;
				var currentItem = (ProductCatalog)btn.CommandParameter;
				var fileItem = ViewModel.Files.ToList ().FirstOrDefault (i => i.Id == currentItem.Id);

				var pdfService = DependencyService.Get<IPdfService> ();
				if (pdfService == null)
					return;

				if (fileItem.MimeType.StartsWith ("mp4")) {
					var page = (Page)Activator.CreateInstance (typeof(VideoView), fileItem);
					this.ParentView.Navigation.PushAsync (page, true);
				} else {
					if (fileItem.CategoryCode == "newsletter") {
						pdfService.OpenPDF (LibraryType.NewsLetter, fileItem.FilePath, fileItem.FileName, 0, null);
					} else {
						pdfService.OpenPDF (LibraryType.All, fileItem.FilePath, fileItem.FileName, 0, null);

					}
				}

			};

			//Download Button
			var download = new Button () {
				Text = Translation.Localize("DownloadText"),
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex ("#006699"),
				TextColor = Color.White,
				HeightRequest = UIConstants.GetButtonHeight (),
				WidthRequest = UIConstants.GetButtonWidth (),
			};
			download.SetBinding (Button.TextProperty, new Binding ("DownloadDate", converter: new DownloadTextConverter ()));
			download.SetBinding (Button.CommandParameterProperty, new Binding ("."));

			download.Clicked += async (sender, e) => {

				var btn = ((Button)sender);
				var currentItem = (ProductCatalog)btn.CommandParameter;

				var ViewModel = (NewsLetterViewModel)this.Parent.BindingContext;
				var parent = (NewsletterView)this.ParentView.ParentView.Parent;

				var fileItem = ViewModel.Files.ToList ().FirstOrDefault (i => i.Id == currentItem.Id);
				if (fileItem.DownloadDate == null) {

					if (GlobalVariables.WifiDownloadOnly) {
						if (!App.IsWifiReachable ()) {
							await parent.DisplayAlert ("", GlobalVariables.WifiConnectionOnlyAlert, Translation.Localize("Ok"));
							return;
						}
					}

					var textToDisplay = 
						currentItem.MimeType.StartsWith ("mp4") 
						? Translation.Localize("DownloadVideoMessage")
						: Translation.Localize("DownloadDocumentMessage");



					var confirm = await parent.DisplayAlert ("", textToDisplay, Translation.Localize("Yes"), Translation.Localize("No"));

					if (confirm) {
						var pdfService = DependencyService.Get<IDownloadService> ();
						if (pdfService == null)
							return;

						pdfService.DownloadData (fileItem, (string filePath) => {
							if (filePath != "") {
								fileItem.FilePath = filePath;
								fileItem.ThumbPath = filePath.Replace (".pdf", ".jpeg").Replace (".mp4", ".jpeg");
								if (fileItem.MimeType.StartsWith ("mp4"))
									readOnline.Text = Translation.Localize("PlayOfflineText");
								else
									readOnline.Text = Translation.Localize("ReadOfflineText");
								//
								download.Text = Translation.Localize("DeleteText");
								downloadLabel.Text = DateTime.Now.ToString("d");
								ViewModel.fileItem = fileItem;
								ViewModel.InsertDocumentsCommand.Execute (null);
							}
						});
					}
				} else {
					var textToDisplay = currentItem.MimeType.StartsWith ("mp4") 
						? Translation.Localize("DeleteVideoMessage")
						: Translation.Localize("DeleteDocumentMessage");
					var confirm = await parent.DisplayAlert ("", textToDisplay, Translation.Localize("Yes"), Translation.Localize("No"));
					if (confirm) {
						var deleteService = DependencyService.Get<IDeleteService> ();
						if (deleteService == null)
							return;

						deleteService.DeleteFile (fileItem.FilePath, (bool completed) => {
							if (completed == true) {

								if (fileItem.MimeType.StartsWith ("mp4"))
									readOnline.Text = Translation.Localize("PlayOnlineText");
								else
									readOnline.Text = Translation.Localize("ReadOnlineText");
								//
								download.Text = Translation.Localize("DownloadText");
								downloadLabel.Text = "";
								ViewModel.DocFileID = fileItem.Id;
								ViewModel.DeleteDocumentsCommand.Execute (null);
							}
						});
					}
				}


			};

			Grid grid = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Center,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			Grid details = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },

				}
			};

			details.Children.Add (publishLabel, 0, 0);
			details.Children.Add (nameLabel, 0, 1);
			details.Children.Add (descriptionLabel, 0, 2);
			details.Children.Add (readOnline, 0, 3);
			details.Children.Add (download, 0, 4);


			Grid leftdetails = new Grid {
				Padding = 5,
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			leftdetails.Children.Add (thumbnailImage, 0, 0);
			leftdetails.Children.Add (downloadLabel, 0, 1);

			grid.Children.Add (leftdetails, 0, 0);
			grid.Children.Add (details, 1, 0);


			var frame = new Frame {
				OutlineColor = Color.FromRgba (255, 255, 255, 0.5),
				HasShadow = true,
				HorizontalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromRgba (255, 255, 255, 0.1),
				VerticalOptions = LayoutOptions.Center,
				Padding = 5,
				Content = new StackLayout {
					Padding = 0,
					Children = {
						grid
					}
				}
			};

			this.View = frame;
		}
	}
}

