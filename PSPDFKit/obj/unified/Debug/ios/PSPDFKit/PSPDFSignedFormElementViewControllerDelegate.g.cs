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
	[Protocol (Name = "PSPDFSignedFormElementViewControllerDelegate", WrapperType = typeof (PSPDFSignedFormElementViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemovedSignatureFromDocument", Selector = "signedFormElementViewController:removedSignatureFromDocument:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSignedFormElementViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFSignedFormElementViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFSignedFormElementViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void RemovedSignatureFromDocument (this IPSPDFSignedFormElementViewControllerDelegate This, PSPDFSignedFormElementViewController controller, PSPDFDocument document)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (document == null)
				throw new ArgumentNullException ("document");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("signedFormElementViewController:removedSignatureFromDocument:"), controller.Handle, document.Handle);
		}
		
	}
	
	internal sealed class PSPDFSignedFormElementViewControllerDelegateWrapper : BaseWrapper, IPSPDFSignedFormElementViewControllerDelegate {
		public PSPDFSignedFormElementViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFSignedFormElementViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFSignedFormElementViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFSignedFormElementViewControllerDelegate : NSObject, IPSPDFSignedFormElementViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSignedFormElementViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFSignedFormElementViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSignedFormElementViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("signedFormElementViewController:removedSignatureFromDocument:")]
		[CompilerGenerated]
		public virtual void RemovedSignatureFromDocument (PSPDFSignedFormElementViewController controller, PSPDFDocument document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFSignedFormElementViewControllerDelegate */
}
