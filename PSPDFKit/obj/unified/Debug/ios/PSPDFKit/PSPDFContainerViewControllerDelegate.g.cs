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
	[Protocol (Name = "PSPDFContainerViewControllerDelegate", WrapperType = typeof (PSPDFContainerViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateSelectedIndex", Selector = "containerViewController:didUpdateSelectedIndex:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFContainerViewController), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFContainerViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFContainerViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidUpdateSelectedIndex (this IPSPDFContainerViewControllerDelegate This, PSPDFContainerViewController controller, global::System.nuint selectedIndex)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (This.Handle, Selector.GetHandle ("containerViewController:didUpdateSelectedIndex:"), controller.Handle, selectedIndex);
		}
		
	}
	
	internal sealed class PSPDFContainerViewControllerDelegateWrapper : BaseWrapper, IPSPDFContainerViewControllerDelegate {
		public PSPDFContainerViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFContainerViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFContainerViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFContainerViewControllerDelegate : NSObject, IPSPDFContainerViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFContainerViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFContainerViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFContainerViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("containerViewController:didUpdateSelectedIndex:")]
		[CompilerGenerated]
		public virtual void DidUpdateSelectedIndex (PSPDFContainerViewController controller, global::System.nuint selectedIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFContainerViewControllerDelegate */
}
