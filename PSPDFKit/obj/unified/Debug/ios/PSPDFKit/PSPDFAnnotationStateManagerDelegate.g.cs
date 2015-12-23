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
	[Protocol (Name = "PSPDFAnnotationStateManagerDelegate", WrapperType = typeof (PSPDFAnnotationStateManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeState", Selector = "annotationStateManager:didChangeState:to:variant:to:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationStateManager), typeof (NSString), typeof (NSString), typeof (NSString), typeof (NSString) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeUndoState", Selector = "annotationStateManager:didChangeUndoState:redoState:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationStateManager), typeof (bool), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPSPDFAnnotationStateManagerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFAnnotationStateManagerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidChangeState (this IPSPDFAnnotationStateManagerDelegate This, PSPDFAnnotationStateManager manager, NSString state, NSString newState, NSString variant, NSString newVariant)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("annotationStateManager:didChangeState:to:variant:to:"), manager.Handle, state == null ? IntPtr.Zero : state.Handle, newState == null ? IntPtr.Zero : newState.Handle, variant == null ? IntPtr.Zero : variant.Handle, newVariant == null ? IntPtr.Zero : newVariant.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeUndoState (this IPSPDFAnnotationStateManagerDelegate This, PSPDFAnnotationStateManager manager, bool undoEnabled, bool redoEnabled)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_bool (This.Handle, Selector.GetHandle ("annotationStateManager:didChangeUndoState:redoState:"), manager.Handle, undoEnabled, redoEnabled);
		}
		
	}
	
	internal sealed class PSPDFAnnotationStateManagerDelegateWrapper : BaseWrapper, IPSPDFAnnotationStateManagerDelegate {
		public PSPDFAnnotationStateManagerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationStateManagerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAnnotationStateManagerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFAnnotationStateManagerDelegate : NSObject, IPSPDFAnnotationStateManagerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationStateManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationStateManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationStateManagerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("annotationStateManager:didChangeState:to:variant:to:")]
		[CompilerGenerated]
		public virtual void DidChangeState (PSPDFAnnotationStateManager manager, NSString state, NSString newState, NSString variant, NSString newVariant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("annotationStateManager:didChangeUndoState:redoState:")]
		[CompilerGenerated]
		public virtual void DidChangeUndoState (PSPDFAnnotationStateManager manager, bool undoEnabled, bool redoEnabled)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFAnnotationStateManagerDelegate */
}
