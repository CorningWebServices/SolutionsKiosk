using System;
using Foundation;

using PSPDFKit;
using UIKit;
using CoreGraphics;
using MediandoUI;
using Xamarin.Forms;

namespace Mediando.iOS
{
	public class ViewerPageController  : PSPDFViewController
	{
		double screenWidth;
		double screenHeight;

		public ViewerPageController (PSPDFDocument document) : base (document)
		{
			document.Title = document.FileName.Replace (".pdf", "");
		}

		public ViewerPageController (NSUrl documentPath) : this (new PSPDFDocument (documentPath))
		{
			
		}
			

		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();
			screenWidth = (int)UIScreen.MainScreen.Bounds.Width;
			screenHeight = (int)UIScreen.MainScreen.Bounds.Height;
			if(App.CurrentDevice == IOSDevices.IPhone4S 
				|| App.CurrentDevice == IOSDevices.IPhone5 
				|| App.CurrentDevice == IOSDevices.IPhone5S)
			{
				if (screenWidth > screenHeight) {
					this.RightBarButtonItems = new [] { 
						this.AnnotationButtonItem,	
						this.SearchButtonItem, 
						this.BookmarkButtonItem, 
						this.OutlineButtonItem, 
						this.ViewModeButtonItem, 
						this.ActivityButtonItem,
					};
				} else {
					this.RightBarButtonItems = new [] { 
						this.AnnotationButtonItem,	
						this.SearchButtonItem, 
						this.BookmarkButtonItem, 
						this.OutlineButtonItem, 
						//this.ViewModeButtonItem, 
						this.ActivityButtonItem,
					};
				}
			}
			else{
				this.RightBarButtonItems = new [] { 
					this.AnnotationButtonItem,	
					this.SearchButtonItem, 
					this.BookmarkButtonItem, 
					this.OutlineButtonItem, 
					this.ViewModeButtonItem, 
					this.ActivityButtonItem,
				};
			}

			this.LeftBarButtonItems = new [] {
				this.CloseButtonItem
			};
		}



		public override void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			screenWidth = (int)UIScreen.MainScreen.Bounds.Width;
			screenHeight = (int)UIScreen.MainScreen.Bounds.Height;

			if(App.CurrentDevice == IOSDevices.IPhone4S 
				|| App.CurrentDevice == IOSDevices.IPhone5 
				|| App.CurrentDevice == IOSDevices.IPhone5S)
			{
				if (screenWidth > screenHeight) {
					this.RightBarButtonItems = new [] { 
						this.AnnotationButtonItem,	
						this.SearchButtonItem, 
						this.BookmarkButtonItem, 
						this.OutlineButtonItem, 
						this.ViewModeButtonItem, 
						this.ActivityButtonItem,
					};
				} else {
					this.RightBarButtonItems = new [] { 
						this.AnnotationButtonItem,	
						this.SearchButtonItem, 
						this.BookmarkButtonItem, 
						this.OutlineButtonItem, 
						//this.ViewModeButtonItem, 
						this.ActivityButtonItem,
					};
				}
			}
			else{
				this.RightBarButtonItems = new [] { 
					this.AnnotationButtonItem,	
					this.SearchButtonItem, 
					this.BookmarkButtonItem, 
					this.OutlineButtonItem, 
					this.ViewModeButtonItem, 
					this.ActivityButtonItem,
				};
			}

		}
			
	}
}

