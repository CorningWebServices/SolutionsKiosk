using System;

using Xamarin.Forms;
using System.Collections;
using System.Collections.Generic;

namespace MediandoUI
{
	/// <summary>
	/// Xamarin.Forms representation for a custom-renderer that uses 
	/// the native list control on each platform.
	/// </summary>
	public class NativeListView : View
	{
		public static readonly BindableProperty ItemsProperty = 
			BindableProperty.Create ("Items", typeof(IEnumerable<ProductCatalog>), typeof(NativeListView), new List<ProductCatalog>());

		public IEnumerable<ProductCatalog> Items {
			get { return (IEnumerable<ProductCatalog>)GetValue (ItemsProperty); }
			set { SetValue (ItemsProperty, value); } 
		}

		public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

		public void NotifyItemSelected (object item) {

			if (ItemSelected != null)
				ItemSelected (this, new SelectedItemChangedEventArgs (item));
		}

		public NativeListView (IEnumerable<ProductCatalog> data)
		{
			Items = data;
		}
	}
}


