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
	[Protocol (Name = "PSPDFBookmarkViewControllerDelegate", WrapperType = typeof (PSPDFBookmarkViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CurrentPageForBookmarkViewController", Selector = "currentPageForBookmarkViewController:", ReturnType = typeof (nuint), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFBookmarkViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectBookmark", Selector = "bookmarkViewController:didSelectBookmark:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFBookmarkViewController), typeof (PSPDFKit.PSPDFBookmark) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFBookmarkViewControllerDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("currentPageForBookmarkViewController:")]
		[Preserve (Conditional = true)]
		global::System.nuint CurrentPageForBookmarkViewController (PSPDFBookmarkViewController bookmarkController);
		
		[CompilerGenerated]
		[Export ("bookmarkViewController:didSelectBookmark:")]
		[Preserve (Conditional = true)]
		void DidSelectBookmark (PSPDFBookmarkViewController bookmarkController, PSPDFBookmark bookmark);
		
	}
	
	internal sealed class PSPDFBookmarkViewControllerDelegateWrapper : BaseWrapper, IPSPDFBookmarkViewControllerDelegate {
		public PSPDFBookmarkViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFBookmarkViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("currentPageForBookmarkViewController:")]
		[CompilerGenerated]
		public global::System.nuint CurrentPageForBookmarkViewController (PSPDFBookmarkViewController bookmarkController)
		{
			if (bookmarkController == null)
				throw new ArgumentNullException ("bookmarkController");
			return global::ApiDefinition.Messaging.nuint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("currentPageForBookmarkViewController:"), bookmarkController.Handle);
		}
		
		[Export ("bookmarkViewController:didSelectBookmark:")]
		[CompilerGenerated]
		public void DidSelectBookmark (PSPDFBookmarkViewController bookmarkController, PSPDFBookmark bookmark)
		{
			if (bookmarkController == null)
				throw new ArgumentNullException ("bookmarkController");
			if (bookmark == null)
				throw new ArgumentNullException ("bookmark");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bookmarkViewController:didSelectBookmark:"), bookmarkController.Handle, bookmark.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFBookmarkViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFBookmarkViewControllerDelegate : NSObject, IPSPDFBookmarkViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFBookmarkViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFBookmarkViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFBookmarkViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("currentPageForBookmarkViewController:")]
		[CompilerGenerated]
		public abstract global::System.nuint CurrentPageForBookmarkViewController (PSPDFBookmarkViewController bookmarkController);
		[Export ("bookmarkViewController:didSelectBookmark:")]
		[CompilerGenerated]
		public abstract void DidSelectBookmark (PSPDFBookmarkViewController bookmarkController, PSPDFBookmark bookmark);
	} /* class PSPDFBookmarkViewControllerDelegate */
}
