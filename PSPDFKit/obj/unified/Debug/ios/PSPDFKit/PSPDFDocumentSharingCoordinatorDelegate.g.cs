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
	[Protocol (Name = "PSPDFDocumentSharingCoordinatorDelegate", WrapperType = typeof (PSPDFDocumentSharingCoordinatorDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "documentSharingCoordinator:didFailWithError:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingCoordinator), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFDocumentSharingCoordinatorDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
		[CompilerGenerated]
		[Export ("documentSharingCoordinator:didFailWithError:")]
		[Preserve (Conditional = true)]
		void DidFail (PSPDFDocumentSharingCoordinator coordinator, NSError error);
		
	}
	
	internal sealed class PSPDFDocumentSharingCoordinatorDelegateWrapper : BaseWrapper, IPSPDFDocumentSharingCoordinatorDelegate {
		public PSPDFDocumentSharingCoordinatorDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFDocumentSharingCoordinatorDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("documentSharingCoordinator:didFailWithError:")]
		[CompilerGenerated]
		public void DidFail (PSPDFDocumentSharingCoordinator coordinator, NSError error)
		{
			if (coordinator == null)
				throw new ArgumentNullException ("coordinator");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("documentSharingCoordinator:didFailWithError:"), coordinator.Handle, error.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFDocumentSharingCoordinatorDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFDocumentSharingCoordinatorDelegate : NSObject, IPSPDFDocumentSharingCoordinatorDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFDocumentSharingCoordinatorDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentSharingCoordinatorDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentSharingCoordinatorDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentSharingCoordinator:didFailWithError:")]
		[CompilerGenerated]
		public abstract void DidFail (PSPDFDocumentSharingCoordinator coordinator, NSError error);
	} /* class PSPDFDocumentSharingCoordinatorDelegate */
}
