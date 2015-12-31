//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

using Android.App;
using Android.Content;
using MediandoUI;


[assembly: ExportRenderer(typeof(MediandoUI.ViewerPage), typeof(Mediando.Droid.PDFRenderer))]

namespace Mediando.Droid
{
	public class PDFRenderer : PageRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Page> e)
		{
			base.OnElementChanged(e);

			var page = e.NewElement as ViewerPage;

			// this is a ViewGroup - so should be able to load an AXML file and FindView<>
			var activity = this.Context as Activity;

			var thirdActivity = new Intent(activity, typeof(ViewerActivity));
			thirdActivity.PutExtra("FilePath", page.FileItem.FilePath);
			activity.StartActivity(thirdActivity);
		}
	}
}
	

