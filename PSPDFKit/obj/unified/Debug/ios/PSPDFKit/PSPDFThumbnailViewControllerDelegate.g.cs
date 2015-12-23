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
	[Protocol (Name = "PSPDFThumbnailViewControllerDelegate", WrapperType = typeof (PSPDFThumbnailViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPage", Selector = "thumbnailViewController:didSelectPage:inDocument:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFThumbnailViewController), typeof (nuint), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPSPDFThumbnailViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFThumbnailViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidSelectPage (this IPSPDFThumbnailViewControllerDelegate This, PSPDFThumbnailViewController thumbnailViewController, global::System.nuint page, PSPDFDocument document)
		{
			if (thumbnailViewController == null)
				throw new ArgumentNullException ("thumbnailViewController");
			if (document == null)
				throw new ArgumentNullException ("document");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (This.Handle, Selector.GetHandle ("thumbnailViewController:didSelectPage:inDocument:"), thumbnailViewController.Handle, page, document.Handle);
		}
		
	}
	
	internal sealed class PSPDFThumbnailViewControllerDelegateWrapper : BaseWrapper, IPSPDFThumbnailViewControllerDelegate {
		public PSPDFThumbnailViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFThumbnailViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFThumbnailViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFThumbnailViewControllerDelegate : NSObject, IPSPDFThumbnailViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFThumbnailViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFThumbnailViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFThumbnailViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("thumbnailViewController:didSelectPage:inDocument:")]
		[CompilerGenerated]
		public virtual void DidSelectPage (PSPDFThumbnailViewController thumbnailViewController, global::System.nuint page, PSPDFDocument document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFThumbnailViewControllerDelegate */
}
