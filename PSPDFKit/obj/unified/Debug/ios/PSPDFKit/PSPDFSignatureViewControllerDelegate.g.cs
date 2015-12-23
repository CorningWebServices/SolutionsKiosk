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
	[Protocol (Name = "PSPDFSignatureViewControllerDelegate", WrapperType = typeof (PSPDFSignatureViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SignatureViewControllerDidCancel", Selector = "signatureViewControllerDidCancel:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSignatureViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SignatureViewControllerDidSave", Selector = "signatureViewControllerDidSave:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSignatureViewController) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFSignatureViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
	}
	
	public static partial class PSPDFSignatureViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void SignatureViewControllerDidCancel (this IPSPDFSignatureViewControllerDelegate This, PSPDFSignatureViewController signatureController)
		{
			if (signatureController == null)
				throw new ArgumentNullException ("signatureController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("signatureViewControllerDidCancel:"), signatureController.Handle);
		}
		
		[CompilerGenerated]
		public static void SignatureViewControllerDidSave (this IPSPDFSignatureViewControllerDelegate This, PSPDFSignatureViewController signatureController)
		{
			if (signatureController == null)
				throw new ArgumentNullException ("signatureController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("signatureViewControllerDidSave:"), signatureController.Handle);
		}
		
	}
	
	internal sealed class PSPDFSignatureViewControllerDelegateWrapper : BaseWrapper, IPSPDFSignatureViewControllerDelegate {
		public PSPDFSignatureViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFSignatureViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFSignatureViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFSignatureViewControllerDelegate : NSObject, IPSPDFSignatureViewControllerDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSignatureViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFSignatureViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSignatureViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("signatureViewControllerDidCancel:")]
		[CompilerGenerated]
		public virtual void SignatureViewControllerDidCancel (PSPDFSignatureViewController signatureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("signatureViewControllerDidSave:")]
		[CompilerGenerated]
		public virtual void SignatureViewControllerDidSave (PSPDFSignatureViewController signatureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFSignatureViewControllerDelegate */
}
