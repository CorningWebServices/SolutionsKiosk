using System;
using UIKit;
using Foundation;

namespace Mediando.iOS
{
	/// <summary>
	/// Sample of a custom cell layout, taken from the iOS docs at
	/// http://developer.xamarin.com/guides/ios/user_interface/tables/part_3_-_customizing_a_table's_appearance/
	/// </summary>
	public class NativeCell : UITableViewCell  {

		UILabel nameLabel, descriptionLabel, publishedDateLabel;
		UIImageView imageView;
		UIButton downloadButton, readButton;

		public NativeCell (NSString cellId) : base (UITableViewCellStyle.Default, cellId)
		{
			//SelectionStyle = UITableViewCellSelectionStyle.Gray;

			ContentView.BackgroundColor = UIColor.Clear;

			imageView = new UIImageView();
			imageView.Image = UIImage.FromFile ("corningimages/foldeddoc.png");

			nameLabel = new UILabel () {
				TextColor = UIColor.Black,
				BackgroundColor = UIColor.Clear,
				Lines = 3, 
			};

			descriptionLabel = new UILabel () {
				TextColor = UIColor.Black,
				BackgroundColor = UIColor.Clear,
				Lines = 3, 
				LineBreakMode = UILineBreakMode.TailTruncation,
			};

			publishedDateLabel = new UILabel () {
				TextColor = UIColor.Black,
				BackgroundColor = UIColor.Clear
			};

			downloadButton = new UIButton () {
				BackgroundColor = UIColor.FromRGB(00,66,99),
			};

			readButton = new UIButton () {
				BackgroundColor = UIColor.FromRGB(00,66,99),

			};

			ContentView.Add (publishedDateLabel);
			ContentView.Add (nameLabel);
			ContentView.Add (descriptionLabel);
			ContentView.Add (imageView);
		}


		public void UpdateCell (string name, string description, string publisheddate, string mimetype, UIImage image)
		{
//			if (image != null) {
//				imageView.Image = image;
//			} 

			nameLabel.Text = name;
			descriptionLabel.Text = description;
			publishedDateLabel.Text = publisheddate;
			downloadButton.TitleLabel.Text = "Download";
			readButton.TitleLabel.Text = (mimetype == "mp4") ? "Play Online" : "Read Online" ;
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			imageView.Frame = new CoreGraphics.CGRect(5, 5, 100, 180);
			publishedDateLabel.Frame = new CoreGraphics.CGRect(110, 5, ContentView.Bounds.Width - 100, 20);
			nameLabel.Frame = new CoreGraphics.CGRect(110, 25, ContentView.Bounds.Width - 100, 50);
			descriptionLabel.Frame = new CoreGraphics.CGRect(110, 75, ContentView.Bounds.Width - 100, 50);
			readButton.Frame = new CoreGraphics.CGRect(110, 125, ContentView.Bounds.Width - 100, 20);
			downloadButton.Frame = new CoreGraphics.CGRect(110, 150, ContentView.Bounds.Width - 100, 20);

		}
	}
}

