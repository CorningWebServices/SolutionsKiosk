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
	[Protocol (Name = "PSPDFThumbnailBarDelegate", WrapperType = typeof (PSPDFThumbnailBarDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPage", Selector = "thumbnailBar:didSelectPage:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFThumbnailBar), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFThumbnailBarDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFThumbnailBarDelegate_Extensions {
		[CompilerGenerated]
		public static void DidSelectPage (this IPSPDFThumbnailBarDelegate This, PSPDFThumbnailBar thumbnailBar, global::System.nuint page)
		{
			if (thumbnailBar == null)
				throw new ArgumentNullException ("thumbnailBar");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (This.Handle, Selector.GetHandle ("thumbnailBar:didSelectPage:"), thumbnailBar.Handle, page);
		}
		
	}
	
	internal sealed class PSPDFThumbnailBarDelegateWrapper : BaseWrapper, IPSPDFThumbnailBarDelegate {
		public PSPDFThumbnailBarDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFThumbnailBarDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFThumbnailBarDelegate", false)]
	[Model]
	public unsafe partial class PSPDFThumbnailBarDelegate : NSObject, IPSPDFThumbnailBarDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFThumbnailBarDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFThumbnailBarDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFThumbnailBarDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("thumbnailBar:didSelectPage:")]
		[CompilerGenerated]
		public virtual void DidSelectPage (PSPDFThumbnailBar thumbnailBar, global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFThumbnailBarDelegate */
}
