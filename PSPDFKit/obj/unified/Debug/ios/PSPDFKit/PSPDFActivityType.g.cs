//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace PSPDFKit {
	public unsafe static partial class PSPDFActivityType  {
		
		[CompilerGenerated]
		static NSString _Bookmarks;
		[Field ("PSPDFActivityTypeBookmarks",  "__Internal")]
		public static unsafe NSString Bookmarks {
			get {
				if (_Bookmarks == null)
					_Bookmarks = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActivityTypeBookmarks");
				return _Bookmarks;
			}
		}
		[CompilerGenerated]
		static NSString _GoToPage;
		[Field ("PSPDFActivityTypeGoToPage",  "__Internal")]
		public static unsafe NSString GoToPage {
			get {
				if (_GoToPage == null)
					_GoToPage = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActivityTypeGoToPage");
				return _GoToPage;
			}
		}
		[CompilerGenerated]
		static NSString _OpenIn;
		[Field ("PSPDFActivityTypeOpenIn",  "__Internal")]
		public static unsafe NSString OpenIn {
			get {
				if (_OpenIn == null)
					_OpenIn = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActivityTypeOpenIn");
				return _OpenIn;
			}
		}
		[CompilerGenerated]
		static NSString _Outline;
		[Field ("PSPDFActivityTypeOutline",  "__Internal")]
		public static unsafe NSString Outline {
			get {
				if (_Outline == null)
					_Outline = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActivityTypeOutline");
				return _Outline;
			}
		}
		[CompilerGenerated]
		static NSString _Search;
		[Field ("PSPDFActivityTypeSearch",  "__Internal")]
		public static unsafe NSString Search {
			get {
				if (_Search == null)
					_Search = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActivityTypeSearch");
				return _Search;
			}
		}
	} /* class PSPDFActivityType */
}
