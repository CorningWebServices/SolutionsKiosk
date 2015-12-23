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
	[Protocol (Name = "PSPDFFlexibleToolbarDelegate", WrapperType = typeof (PSPDFFlexibleToolbarDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarWillShow", Selector = "flexibleToolbarWillShow:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarDidShow", Selector = "flexibleToolbarDidShow:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarWillHide", Selector = "flexibleToolbarWillHide:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FlexibleToolbarDidHide", Selector = "flexibleToolbarDidHide:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangePosition", Selector = "flexibleToolbar:didChangePosition:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFlexibleToolbar), typeof (PSPDFKit.PSPDFFlexibleToolbarPosition) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFFlexibleToolbarDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFFlexibleToolbarDelegate_Extensions {
		[CompilerGenerated]
		public static void FlexibleToolbarWillShow (this IPSPDFFlexibleToolbarDelegate This, PSPDFFlexibleToolbar toolbar)
		{
			if (toolbar == null)
				throw new ArgumentNullException ("toolbar");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarWillShow:"), toolbar.Handle);
		}
		
		[CompilerGenerated]
		public static void FlexibleToolbarDidShow (this IPSPDFFlexibleToolbarDelegate This, PSPDFFlexibleToolbar toolbar)
		{
			if (toolbar == null)
				throw new ArgumentNullException ("toolbar");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarDidShow:"), toolbar.Handle);
		}
		
		[CompilerGenerated]
		public static void FlexibleToolbarWillHide (this IPSPDFFlexibleToolbarDelegate This, PSPDFFlexibleToolbar toolbar)
		{
			if (toolbar == null)
				throw new ArgumentNullException ("toolbar");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarWillHide:"), toolbar.Handle);
		}
		
		[CompilerGenerated]
		public static void FlexibleToolbarDidHide (this IPSPDFFlexibleToolbarDelegate This, PSPDFFlexibleToolbar toolbar)
		{
			if (toolbar == null)
				throw new ArgumentNullException ("toolbar");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("flexibleToolbarDidHide:"), toolbar.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangePosition (this IPSPDFFlexibleToolbarDelegate This, PSPDFFlexibleToolbar toolbar, PSPDFFlexibleToolbarPosition position)
		{
			if (toolbar == null)
				throw new ArgumentNullException ("toolbar");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("flexibleToolbar:didChangePosition:"), toolbar.Handle, (UInt64)position);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("flexibleToolbar:didChangePosition:"), toolbar.Handle, (UInt32)position);
			}
		}
		
	}
	
	internal sealed class PSPDFFlexibleToolbarDelegateWrapper : BaseWrapper, IPSPDFFlexibleToolbarDelegate {
		public PSPDFFlexibleToolbarDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFFlexibleToolbarDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFFlexibleToolbarDelegate", false)]
	[Model]
	public unsafe partial class PSPDFFlexibleToolbarDelegate : NSObject, IPSPDFFlexibleToolbarDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFlexibleToolbarDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFFlexibleToolbarDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFlexibleToolbarDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("flexibleToolbar:didChangePosition:")]
		[CompilerGenerated]
		public virtual void DidChangePosition (PSPDFFlexibleToolbar toolbar, PSPDFFlexibleToolbarPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarDidHide:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarDidHide (PSPDFFlexibleToolbar toolbar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarDidShow:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarDidShow (PSPDFFlexibleToolbar toolbar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarWillHide:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarWillHide (PSPDFFlexibleToolbar toolbar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flexibleToolbarWillShow:")]
		[CompilerGenerated]
		public virtual void FlexibleToolbarWillShow (PSPDFFlexibleToolbar toolbar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFFlexibleToolbarDelegate */
}
