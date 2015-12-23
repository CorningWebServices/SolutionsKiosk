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
	[Protocol (Name = "PSPDFGalleryViewDelegate", WrapperType = typeof (PSPDFGalleryViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillScrollToItemAtIndex", Selector = "galleryView:willScrollToItemAtIndex:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFGalleryView), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScrollToItemAtIndex", Selector = "galleryView:didScrollToItemAtIndex:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFGalleryView), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillReuseContentView", Selector = "galleryView:willReuseContentView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFGalleryView), typeof (PSPDFKit.PSPDFGalleryContentView) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFGalleryViewDelegate : INativeObject, IDisposable, 
		UIKit.IUIScrollViewDelegate
		
	{
	}
	
	public static partial class PSPDFGalleryViewDelegate_Extensions {
		[CompilerGenerated]
		public static void WillScrollToItemAtIndex (this IPSPDFGalleryViewDelegate This, PSPDFGalleryView galleryView, global::System.nuint index)
		{
			if (galleryView == null)
				throw new ArgumentNullException ("galleryView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (This.Handle, Selector.GetHandle ("galleryView:willScrollToItemAtIndex:"), galleryView.Handle, index);
		}
		
		[CompilerGenerated]
		public static void DidScrollToItemAtIndex (this IPSPDFGalleryViewDelegate This, PSPDFGalleryView galleryView, global::System.nuint index)
		{
			if (galleryView == null)
				throw new ArgumentNullException ("galleryView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (This.Handle, Selector.GetHandle ("galleryView:didScrollToItemAtIndex:"), galleryView.Handle, index);
		}
		
		[CompilerGenerated]
		public static void WillReuseContentView (this IPSPDFGalleryViewDelegate This, PSPDFGalleryView galleryView, PSPDFGalleryContentView contentView)
		{
			if (galleryView == null)
				throw new ArgumentNullException ("galleryView");
			if (contentView == null)
				throw new ArgumentNullException ("contentView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("galleryView:willReuseContentView:"), galleryView.Handle, contentView.Handle);
		}
		
	}
	
	internal sealed class PSPDFGalleryViewDelegateWrapper : BaseWrapper, IPSPDFGalleryViewDelegate {
		public PSPDFGalleryViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFGalleryViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFGalleryViewDelegate", false)]
	[Model]
	public unsafe partial class PSPDFGalleryViewDelegate : NSObject, IPSPDFGalleryViewDelegate, global::UIKit.IUIScrollViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFGalleryViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("galleryView:didScrollToItemAtIndex:")]
		[CompilerGenerated]
		public virtual void DidScrollToItemAtIndex (PSPDFGalleryView galleryView, global::System.nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("galleryView:willReuseContentView:")]
		[CompilerGenerated]
		public virtual void WillReuseContentView (PSPDFGalleryView galleryView, PSPDFGalleryContentView contentView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("galleryView:willScrollToItemAtIndex:")]
		[CompilerGenerated]
		public virtual void WillScrollToItemAtIndex (PSPDFGalleryView galleryView, global::System.nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFGalleryViewDelegate */
}
