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
	[Protocol (Name = "PSPDFCacheDelegate", WrapperType = typeof (PSPDFCacheDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRenderImage", Selector = "didRenderImage:document:page:size:", ParameterType = new Type [] { typeof (UIImage), typeof (PSPDFKit.PSPDFDocument), typeof (nuint), typeof (CGSize) }, ParameterByRef = new bool [] { false, false, false, false })]
	public interface IPSPDFCacheDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFCacheDelegate_Extensions {
		[CompilerGenerated]
		public static void DidRenderImage (this IPSPDFCacheDelegate This, global::UIKit.UIImage image, PSPDFDocument document, global::System.nuint page, CGSize size)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (document == null)
				throw new ArgumentNullException ("document");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_CGSize (This.Handle, Selector.GetHandle ("didRenderImage:document:page:size:"), image.Handle, document.Handle, page, size);
		}
		
	}
	
	internal sealed class PSPDFCacheDelegateWrapper : BaseWrapper, IPSPDFCacheDelegate {
		public PSPDFCacheDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFCacheDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFCacheDelegate", false)]
	[Model]
	public unsafe partial class PSPDFCacheDelegate : NSObject, IPSPDFCacheDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFCacheDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFCacheDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFCacheDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("didRenderImage:document:page:size:")]
		[CompilerGenerated]
		public virtual void DidRenderImage (global::UIKit.UIImage image, PSPDFDocument document, global::System.nuint page, CGSize size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFCacheDelegate */
}
