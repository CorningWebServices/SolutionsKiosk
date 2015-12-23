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
	[Protocol (Name = "PSPDFUnsignedFormElementViewControllerDelegate", WrapperType = typeof (PSPDFUnsignedFormElementViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsInkSignature", Selector = "unsignedFormElementViewControllerRequestsInkSignature:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFUnsignedFormElementViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SignedDocument", Selector = "unsignedFormElementViewController:signedDocument:error:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFUnsignedFormElementViewController), typeof (PSPDFKit.PSPDFDocument), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPSPDFUnsignedFormElementViewControllerDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("unsignedFormElementViewControllerRequestsInkSignature:")]
		[Preserve (Conditional = true)]
		void RequestsInkSignature (PSPDFUnsignedFormElementViewController controller);
		
	}
	
	public static partial class PSPDFUnsignedFormElementViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void SignedDocument (this IPSPDFUnsignedFormElementViewControllerDelegate This, PSPDFUnsignedFormElementViewController controller, PSPDFDocument document, NSError error)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (document == null)
				throw new ArgumentNullException ("document");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("unsignedFormElementViewController:signedDocument:error:"), controller.Handle, document.Handle, error.Handle);
		}
		
	}
	
	internal sealed class PSPDFUnsignedFormElementViewControllerDelegateWrapper : BaseWrapper, IPSPDFUnsignedFormElementViewControllerDelegate {
		public PSPDFUnsignedFormElementViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFUnsignedFormElementViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("unsignedFormElementViewControllerRequestsInkSignature:")]
		[CompilerGenerated]
		public void RequestsInkSignature (PSPDFUnsignedFormElementViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unsignedFormElementViewControllerRequestsInkSignature:"), controller.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFUnsignedFormElementViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFUnsignedFormElementViewControllerDelegate : NSObject, IPSPDFUnsignedFormElementViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFUnsignedFormElementViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFUnsignedFormElementViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFUnsignedFormElementViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("unsignedFormElementViewControllerRequestsInkSignature:")]
		[CompilerGenerated]
		public abstract void RequestsInkSignature (PSPDFUnsignedFormElementViewController controller);
		[Export ("unsignedFormElementViewController:signedDocument:error:")]
		[CompilerGenerated]
		public virtual void SignedDocument (PSPDFUnsignedFormElementViewController controller, PSPDFDocument document, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFUnsignedFormElementViewControllerDelegate */
}