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
	[Protocol (Name = "PSPDFAnnotationGridViewControllerDelegate", WrapperType = typeof (PSPDFAnnotationGridViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnnotationGridViewControllerDidCancel", Selector = "annotationGridViewControllerDidCancel:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationGridViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectAnnotationSet", Selector = "annotationGridViewController:didSelectAnnotationSet:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationGridViewController), typeof (PSPDFKit.PSPDFAnnotationSet) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFAnnotationGridViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
	}
	
	public static partial class PSPDFAnnotationGridViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void AnnotationGridViewControllerDidCancel (this IPSPDFAnnotationGridViewControllerDelegate This, PSPDFAnnotationGridViewController annotationGridController)
		{
			if (annotationGridController == null)
				throw new ArgumentNullException ("annotationGridController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("annotationGridViewControllerDidCancel:"), annotationGridController.Handle);
		}
		
		[CompilerGenerated]
		public static void DidSelectAnnotationSet (this IPSPDFAnnotationGridViewControllerDelegate This, PSPDFAnnotationGridViewController annotationGridController, PSPDFAnnotationSet annotationSet)
		{
			if (annotationGridController == null)
				throw new ArgumentNullException ("annotationGridController");
			if (annotationSet == null)
				throw new ArgumentNullException ("annotationSet");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("annotationGridViewController:didSelectAnnotationSet:"), annotationGridController.Handle, annotationSet.Handle);
		}
		
	}
	
	internal sealed class PSPDFAnnotationGridViewControllerDelegateWrapper : BaseWrapper, IPSPDFAnnotationGridViewControllerDelegate {
		public PSPDFAnnotationGridViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationGridViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAnnotationGridViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFAnnotationGridViewControllerDelegate : NSObject, IPSPDFAnnotationGridViewControllerDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationGridViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationGridViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationGridViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("annotationGridViewControllerDidCancel:")]
		[CompilerGenerated]
		public virtual void AnnotationGridViewControllerDidCancel (PSPDFAnnotationGridViewController annotationGridController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("annotationGridViewController:didSelectAnnotationSet:")]
		[CompilerGenerated]
		public virtual void DidSelectAnnotationSet (PSPDFAnnotationGridViewController annotationGridController, PSPDFAnnotationSet annotationSet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFAnnotationGridViewControllerDelegate */
}
