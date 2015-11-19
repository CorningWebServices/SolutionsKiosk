using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using MediandoUI;
using Mediando.iOS;
using UIKit;


[assembly: ExportRenderer (typeof (CustomLabel2), typeof (CustomLabelRenderer))]

namespace Mediando.iOS
{
	public class CustomLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				UILabel label = Control;
				label.Lines = 2;
			}
		}
	}
}

