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
	[Protocol (Name = "PSPDFResizableTrackedViewDelegate", WrapperType = typeof (PSPDFResizableTrackedViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetResizableView", Selector = "resizableView", ReturnType = typeof (PSPDFKit.PSPDFResizableView))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetResizableView", Selector = "setResizableView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFResizableView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnnotation", Selector = "annotation", ReturnType = typeof (PSPDFKit.PSPDFAnnotation))]
	public interface IPSPDFResizableTrackedViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFResizableTrackedViewDelegate_Extensions {
		[CompilerGenerated]
		public static PSPDFResizableView GetResizableView (this IPSPDFResizableTrackedViewDelegate This)
		{
			return  Runtime.GetNSObject<PSPDFResizableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("resizableView")));
		}
		
		[CompilerGenerated]
		public static void SetResizableView (this IPSPDFResizableTrackedViewDelegate This, PSPDFResizableView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setResizableView:"), view.Handle);
		}
		
		[CompilerGenerated]
		public static PSPDFAnnotation GetAnnotation (this IPSPDFResizableTrackedViewDelegate This)
		{
			return  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("annotation")));
		}
		
	}
	
	internal sealed class PSPDFResizableTrackedViewDelegateWrapper : BaseWrapper, IPSPDFResizableTrackedViewDelegate {
		public PSPDFResizableTrackedViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFResizableTrackedViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFResizableTrackedViewDelegate", false)]
	[Model]
	public unsafe partial class PSPDFResizableTrackedViewDelegate : NSObject, IPSPDFResizableTrackedViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFResizableTrackedViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFResizableTrackedViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFResizableTrackedViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("annotation")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation GetAnnotation ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("resizableView")]
		[CompilerGenerated]
		public virtual PSPDFResizableView GetResizableView ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setResizableView:")]
		[CompilerGenerated]
		public virtual void SetResizableView (PSPDFResizableView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFResizableTrackedViewDelegate */
}
