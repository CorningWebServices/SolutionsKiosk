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
	[Protocol (Name = "PSPDFNoteAnnotationViewControllerDelegate", WrapperType = typeof (PSPDFNoteAnnotationViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDeleteAnnotation", Selector = "noteAnnotationController:didDeleteAnnotation:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFNoteAnnotationViewController), typeof (PSPDFKit.PSPDFAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClearContentsForAnnotation", Selector = "noteAnnotationController:didClearContentsForAnnotation:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFNoteAnnotationViewController), typeof (PSPDFKit.PSPDFAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeAnnotation", Selector = "noteAnnotationController:didChangeAnnotation:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFNoteAnnotationViewController), typeof (PSPDFKit.PSPDFAnnotation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissWithAnnotation", Selector = "noteAnnotationController:willDismissWithAnnotation:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFNoteAnnotationViewController), typeof (PSPDFKit.PSPDFAnnotation) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFNoteAnnotationViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
	}
	
	public static partial class PSPDFNoteAnnotationViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidDeleteAnnotation (this IPSPDFNoteAnnotationViewControllerDelegate This, PSPDFNoteAnnotationViewController noteController, PSPDFAnnotation annotation)
		{
			if (noteController == null)
				throw new ArgumentNullException ("noteController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("noteAnnotationController:didDeleteAnnotation:"), noteController.Handle, annotation.Handle);
		}
		
		[CompilerGenerated]
		public static void DidClearContentsForAnnotation (this IPSPDFNoteAnnotationViewControllerDelegate This, PSPDFNoteAnnotationViewController noteController, PSPDFAnnotation annotation)
		{
			if (noteController == null)
				throw new ArgumentNullException ("noteController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("noteAnnotationController:didClearContentsForAnnotation:"), noteController.Handle, annotation.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeAnnotation (this IPSPDFNoteAnnotationViewControllerDelegate This, PSPDFNoteAnnotationViewController noteController, PSPDFAnnotation annotation)
		{
			if (noteController == null)
				throw new ArgumentNullException ("noteController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("noteAnnotationController:didChangeAnnotation:"), noteController.Handle, annotation.Handle);
		}
		
		[CompilerGenerated]
		public static void WillDismissWithAnnotation (this IPSPDFNoteAnnotationViewControllerDelegate This, PSPDFNoteAnnotationViewController noteController, PSPDFAnnotation annotation)
		{
			if (noteController == null)
				throw new ArgumentNullException ("noteController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("noteAnnotationController:willDismissWithAnnotation:"), noteController.Handle, annotation == null ? IntPtr.Zero : annotation.Handle);
		}
		
	}
	
	internal sealed class PSPDFNoteAnnotationViewControllerDelegateWrapper : BaseWrapper, IPSPDFNoteAnnotationViewControllerDelegate {
		public PSPDFNoteAnnotationViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFNoteAnnotationViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFNoteAnnotationViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFNoteAnnotationViewControllerDelegate : NSObject, IPSPDFNoteAnnotationViewControllerDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFNoteAnnotationViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFNoteAnnotationViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFNoteAnnotationViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("noteAnnotationController:didChangeAnnotation:")]
		[CompilerGenerated]
		public virtual void DidChangeAnnotation (PSPDFNoteAnnotationViewController noteController, PSPDFAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("noteAnnotationController:didClearContentsForAnnotation:")]
		[CompilerGenerated]
		public virtual void DidClearContentsForAnnotation (PSPDFNoteAnnotationViewController noteController, PSPDFAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("noteAnnotationController:didDeleteAnnotation:")]
		[CompilerGenerated]
		public virtual void DidDeleteAnnotation (PSPDFNoteAnnotationViewController noteController, PSPDFAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("noteAnnotationController:willDismissWithAnnotation:")]
		[CompilerGenerated]
		public virtual void WillDismissWithAnnotation (PSPDFNoteAnnotationViewController noteController, PSPDFAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFNoteAnnotationViewControllerDelegate */
}
