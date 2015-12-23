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
	public unsafe static partial class PSPDFFileManagerOption  {
		
		[CompilerGenerated]
		static NSString _CoordinatedAccess;
		[Field ("PSPDFFileManagerOptionCoordinatedAccess",  "__Internal")]
		public static unsafe NSString CoordinatedAccess {
			get {
				if (_CoordinatedAccess == null)
					_CoordinatedAccess = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFFileManagerOptionCoordinatedAccess");
				return _CoordinatedAccess;
			}
		}
		[CompilerGenerated]
		static NSString _FilePresenter;
		[Field ("PSPDFFileManagerOptionFilePresenter",  "__Internal")]
		public static unsafe NSString FilePresenter {
			get {
				if (_FilePresenter == null)
					_FilePresenter = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFFileManagerOptionFilePresenter");
				return _FilePresenter;
			}
		}
	} /* class PSPDFFileManagerOption */
}
