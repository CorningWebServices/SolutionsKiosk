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
	[Protocol (Name = "PSPDFResizableViewDelegate", WrapperType = typeof (PSPDFResizableViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResizableViewDidBeginEditing", Selector = "resizableViewDidBeginEditing:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFResizableView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OuterKnobType", Selector = "resizableViewChangedFrame:outerKnobType:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFResizableView), typeof (PSPDFKit.PSPDFResizableViewOuterKnob) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResizableViewDidEndEditing", Selector = "resizableViewDidEndEditing:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFResizableView) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFResizableViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFResizableViewDelegate_Extensions {
		[CompilerGenerated]
		public static void ResizableViewDidBeginEditing (this IPSPDFResizableViewDelegate This, PSPDFResizableView resizableView)
		{
			if (resizableView == null)
				throw new ArgumentNullException ("resizableView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("resizableViewDidBeginEditing:"), resizableView.Handle);
		}
		
		[CompilerGenerated]
		public static void OuterKnobType (this IPSPDFResizableViewDelegate This, PSPDFResizableView resizableView, PSPDFResizableViewOuterKnob outerKnobType)
		{
			if (resizableView == null)
				throw new ArgumentNullException ("resizableView");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("resizableViewChangedFrame:outerKnobType:"), resizableView.Handle, (UInt64)outerKnobType);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("resizableViewChangedFrame:outerKnobType:"), resizableView.Handle, (UInt32)outerKnobType);
			}
		}
		
		[CompilerGenerated]
		public static void ResizableViewDidEndEditing (this IPSPDFResizableViewDelegate This, PSPDFResizableView resizableView)
		{
			if (resizableView == null)
				throw new ArgumentNullException ("resizableView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("resizableViewDidEndEditing:"), resizableView.Handle);
		}
		
	}
	
	internal sealed class PSPDFResizableViewDelegateWrapper : BaseWrapper, IPSPDFResizableViewDelegate {
		public PSPDFResizableViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFResizableViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFResizableViewDelegate", false)]
	[Model]
	public unsafe partial class PSPDFResizableViewDelegate : NSObject, IPSPDFResizableViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFResizableViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFResizableViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFResizableViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("resizableViewChangedFrame:outerKnobType:")]
		[CompilerGenerated]
		public virtual void OuterKnobType (PSPDFResizableView resizableView, PSPDFResizableViewOuterKnob outerKnobType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("resizableViewDidBeginEditing:")]
		[CompilerGenerated]
		public virtual void ResizableViewDidBeginEditing (PSPDFResizableView resizableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("resizableViewDidEndEditing:")]
		[CompilerGenerated]
		public virtual void ResizableViewDidEndEditing (PSPDFResizableView resizableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFResizableViewDelegate */
}
