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
	[Protocol (Name = "PSPDFAnnotationStyleViewControllerDelegate", WrapperType = typeof (PSPDFAnnotationStyleViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChangeProperty", Selector = "annotationStyleController:didChangeProperty:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationStyleViewController), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartChangingProperty", Selector = "annotationStyleController:willStartChangingProperty:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationStyleViewController), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndChangingProperty", Selector = "annotationStyleController:didEndChangingProperty:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationStyleViewController), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnnotationViewForAnnotation", Selector = "annotationStyleController:annotationViewForAnnotation:", ReturnType = typeof (PSPDFKit.IPSPDFAnnotationViewProtocol), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationStyleViewController), typeof (PSPDFKit.PSPDFAnnotation) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFAnnotationStyleViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
		[CompilerGenerated]
		[Export ("annotationStyleController:didChangeProperty:")]
		[Preserve (Conditional = true)]
		void DidChangeProperty (PSPDFAnnotationStyleViewController styleController, NSString propertyName);
		
	}
	
	public static partial class PSPDFAnnotationStyleViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void WillStartChangingProperty (this IPSPDFAnnotationStyleViewControllerDelegate This, PSPDFAnnotationStyleViewController styleController, NSString propertyName)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("annotationStyleController:willStartChangingProperty:"), styleController.Handle, propertyName.Handle);
		}
		
		[CompilerGenerated]
		public static void DidEndChangingProperty (this IPSPDFAnnotationStyleViewControllerDelegate This, PSPDFAnnotationStyleViewController styleController, NSString propertyName)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("annotationStyleController:didEndChangingProperty:"), styleController.Handle, propertyName.Handle);
		}
		
		[CompilerGenerated]
		public static IPSPDFAnnotationViewProtocol AnnotationViewForAnnotation (this IPSPDFAnnotationStyleViewControllerDelegate This, PSPDFAnnotationStyleViewController styleController, PSPDFAnnotation annotation)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			return  Runtime.GetINativeObject<IPSPDFAnnotationViewProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("annotationStyleController:annotationViewForAnnotation:"), styleController.Handle, annotation.Handle), false);
		}
		
	}
	
	internal sealed class PSPDFAnnotationStyleViewControllerDelegateWrapper : BaseWrapper, IPSPDFAnnotationStyleViewControllerDelegate {
		public PSPDFAnnotationStyleViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationStyleViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("annotationStyleController:didChangeProperty:")]
		[CompilerGenerated]
		public void DidChangeProperty (PSPDFAnnotationStyleViewController styleController, NSString propertyName)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationStyleController:didChangeProperty:"), styleController.Handle, propertyName.Handle);
		}
		
	}
}
