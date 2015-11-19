using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MediandoUI;
using Mediando.iOS;
using UIKit;


[assembly: ExportRenderer (typeof (CustomLabel), typeof (LongLabelRenderer))]

namespace Mediando.iOS
{
	public class LongLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				UILabel label = Control;
				label.Lines = 3;
			}
		}
	}
}

