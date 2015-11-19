using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using System.Linq;
using MediandoUI;

namespace Mediando.iOS
{
	public class NativeListViewSource : UITableViewSource
	{
		// declare vars
		IList<ProductCatalog> tableItems;
		NativeListView listView;
		readonly NSString cellIdentifier = new NSString("TableCell");

		public IEnumerable<ProductCatalog> Items {
			set{
				tableItems = value.ToList();
			}
		}

		public NativeListViewSource (NativeListView view)
		{
			tableItems = view.Items.ToList();
			listView = view;
		}

		/// <summary>
		/// Called by the TableView to determine how many cells to create for that particular section.
		/// </summary>
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Count;
		}

		#region user interaction methods

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			listView.NotifyItemSelected (tableItems [indexPath.Row]);
			//Console.WriteLine("Row " + indexPath.Row.ToString() + " selected");	
			tableView.DeselectRow (indexPath, true);
		}

//		public override void RowDeselected (UITableView tableView, NSIndexPath indexPath)
//		{
//			Console.WriteLine("Row " + indexPath.Row.ToString() + " deselected");	
//		}

		#endregion

		/// <summary>
		/// Called by the TableView to get the actual UITableViewCell to render for the particular section and row
		/// </summary>
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// request a recycled cell to save memory
			NativeCell cell = tableView.DequeueReusableCell (cellIdentifier) as NativeCell;

			// if there are no cells to reuse, create a new one
			if (cell == null) {
				cell = new NativeCell (cellIdentifier);
			}

			var product = tableItems [indexPath.Row];
			var publishDate = product.PublicationDate == null ? "" 
				: Convert.ToDateTime (product.PublicationDate).ToString ("d");
			
			if (String.IsNullOrWhiteSpace (product.ThumbPath)) 
			{
				cell.UpdateCell (product.FileName, product.Description, publishDate, product.MimeType, null);
			} 
			else 
			{
				cell.UpdateCell (product.FileName, product.Description, publishDate, product.MimeType, FromUrl(product.ThumbPath));
			}

			return cell;
		}

		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 250;
		}

		static UIImage FromUrl (string uri)
		{
			using (var url = new NSUrl (uri))
			using (var data = NSData.FromUrl (url))
				return UIImage.LoadFromData (data);
		}

	}
}

