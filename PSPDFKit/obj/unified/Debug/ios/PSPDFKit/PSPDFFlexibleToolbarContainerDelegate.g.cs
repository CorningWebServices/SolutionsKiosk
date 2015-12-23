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
	[Protocol (Name = "PSPDFFlexibleToolbarContainerDelegate", WrapperType = typeof (PSPDFFlexibleToolbarContainerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarContainerWillShow", Selector = "flexibleToolbarContainerWillShow:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbarContainer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarContainerDidShow", Selector = "flexibleToolbarContainerDidShow:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbarContainer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarContainerWillHide", Selector = "flexibleToolbarContainerWillHide:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbarContainer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarContainerDidHide", Selector = "flexibleToolbarContainerDidHide:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbarContainer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarContainerContentRect", Selector = "flexibleToolbarContainerContentRect:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbarContainer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarContainerWillStartDragging", Selector = "flexibleToolbarContainerWillStartDragging:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbarContainer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WithPosition", Selector = "flexibleToolbarContainerDidEndDragging:withPosition:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbarContainer), typeof (PSPDFKit.PSPDFFlexibleToolbarPosition) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFFlexibleToolbarContainerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFFlexibleToolbarContainerDelegate_Extensions {
		[CompilerGenerated]
		public static void FlexibleToolbarContainerWillShow (this IPSPDFFlexibleToolbarContainerDelegate This, PSPDFFlexibleToolbarContainer container)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarContainerWillShow:"), container.Handle);
		}
		
		[CompilerGenerated]
		public static void FlexibleToolbarContainerDidShow (this IPSPDFFlexibleToolbarContainerDelegate This, PSPDFFlexibleToolbarContainer container)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarContainerDidShow:"), container.Handle);
		}
		
		[CompilerGenerated]
		public static void FlexibleToolbarContainerWillHide (this IPSPDFFlexibleToolbarContainerDelegate This, PSPDFFlexibleToolbarContainer container)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarContainerWillHide:"), container.Handle);
		}
		
		[CompilerGenerated]
		public static void FlexibleToolbarContainerDidHide (this IPSPDFFlexibleToolbarContainerDelegate This, PSPDFFlexibleToolbarContainer container)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarContainerDidHide:"), container.Handle);
		}
		
		[CompilerGenerated]
		public static CGRect FlexibleToolbarContainerContentRect (this IPSPDFFlexibleToolbarContainerDelegate This, PSPDFFlexibleToolbarContainer container)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			CGRect ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarContainerContentRect:"), container.Handle);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_IntPtr (out ret, This.Handle, Selector.GetHandle ("flexibleToolbarContainerContentRect:"), container.Handle);
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_IntPtr (out ret, This.Handle, Selector.GetHandle ("flexibleToolbarContainerContentRect:"), container.Handle);
			} else {
				global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_IntPtr (out ret, This.Handle, Selector.GetHandle ("flexibleToolbarContainerContentRect:"), container.Handle);
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static void FlexibleToolbarContainerWillStartDragging (this IPSPDFFlexibleToolbarContainerDelegate This, PSPDFFlexibleToolbarContainer container)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarContainerWillStartDragging:"), container.Handle);
		}
		
		[CompilerGenerated]
		public static void WithPosition (this IPSPDFFlexibleToolbarContainerDelegate This, PSPDFFlexibleToolbarContainer container, PSPDFFlexibleToolbarPosition position)
		{
			if (container == null)
				throw new ArgumentNullException ("container");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("flexibleToolbarContainerDidEndDragging:withPosition:"), container.Handle, (UInt64)position);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("flexibleToolbarContainerDidEndDragging:withPosition:"), container.Handle, (UInt32)position);
			}
		}
		
	}
	
	internal sealed class PSPDFFlexibleToolbarContainerDelegateWrapper : BaseWrapper, IPSPDFFlexibleToolbarContainerDelegate {
		public PSPDFFlexibleToolbarContainerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFFlexibleToolbarContainerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFFlexibleToolbarContainerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFFlexibleToolbarContainerDelegate : NSObject, IPSPDFFlexibleToolbarContainerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFlexibleToolbarContainerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFFlexibleToolbarContainerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFlexibleToolbarContainerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("flexibleToolbarContainerContentRect:")]
		[CompilerGenerated]
		public virtual CGRect FlexibleToolbarContainerContentRect (PSPDFFlexibleToolbarContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarContainerDidHide:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarContainerDidHide (PSPDFFlexibleToolbarContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarContainerDidShow:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarContainerDidShow (PSPDFFlexibleToolbarContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarContainerWillHide:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarContainerWillHide (PSPDFFlexibleToolbarContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarContainerWillShow:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarContainerWillShow (PSPDFFlexibleToolbarContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarContainerWillStartDragging:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarContainerWillStartDragging (PSPDFFlexibleToolbarContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarContainerDidEndDragging:withPosition:")]
		[CompilerGenerated]
		public virtual void WithPosition (PSPDFFlexibleToolbarContainer container, PSPDFFlexibleToolbarPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFFlexibleToolbarContainerDelegate */
}
