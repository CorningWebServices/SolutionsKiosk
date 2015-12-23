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
	[Protocol (Name = "PSPDFAnnotationViewProtocol", WrapperType = typeof (PSPDFAnnotationViewProtocolWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnnotation", Selector = "annotation", ReturnType = typeof (PSPDFKit.PSPDFAnnotation))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetAnnotation", Selector = "setAnnotation:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetZIndex", Selector = "zIndex", ReturnType = typeof (nuint))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetZIndex", Selector = "setZIndex:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetZoomScale", Selector = "zoomScale", ReturnType = typeof (nfloat))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetZoomScale", Selector = "setZoomScale:", ParameterType = new Type [] { typeof (nfloat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPdfScale", Selector = "PDFScale", ReturnType = typeof (nfloat))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPdfScale", Selector = "setPDFScale:", ParameterType = new Type [] { typeof (nfloat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPageView", Selector = "PageView", ReturnType = typeof (PSPDFKit.PSPDFPageView))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPageView", Selector = "setPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetConfiguration", Selector = "configuration", ReturnType = typeof (PSPDFKit.PSPDFConfiguration))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetConfiguration", Selector = "setConfiguration:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFConfiguration) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSelected", Selector = "isSelected", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetSelected", Selector = "setSelected:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowPageView", Selector = "didShowPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHidePageView", Selector = "didHidePageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangePageBounds", Selector = "didChangePageBounds:", ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTapAtPoint", Selector = "didTapAtPoint:", ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSyncRemovalFromSuperview", Selector = "shouldSyncRemovalFromSuperview", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillRemoveFromSuperview", Selector = "willRemoveFromSuperview")]
	public interface IPSPDFAnnotationViewProtocol : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFAnnotationViewProtocol_Extensions {
		[CompilerGenerated]
		public static PSPDFAnnotation GetAnnotation (this IPSPDFAnnotationViewProtocol This)
		{
			return  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("annotation")));
		}
		
		[CompilerGenerated]
		public static void SetAnnotation (this IPSPDFAnnotationViewProtocol This, PSPDFAnnotation annotation)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAnnotation:"), annotation == null ? IntPtr.Zero : annotation.Handle);
		}
		
		[CompilerGenerated]
		public static global::System.nuint GetZIndex (this IPSPDFAnnotationViewProtocol This)
		{
			return global::ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("zIndex"));
		}
		
		[CompilerGenerated]
		public static void SetZIndex (this IPSPDFAnnotationViewProtocol This, global::System.nuint index)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("setZIndex:"), index);
		}
		
		[CompilerGenerated]
		public static global::System.nfloat GetZoomScale (this IPSPDFAnnotationViewProtocol This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("zoomScale"));
		}
		
		[CompilerGenerated]
		public static void SetZoomScale (this IPSPDFAnnotationViewProtocol This, global::System.nfloat zoomScale)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setZoomScale:"), zoomScale);
		}
		
		[CompilerGenerated]
		public static global::System.nfloat GetPdfScale (this IPSPDFAnnotationViewProtocol This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("PDFScale"));
		}
		
		[CompilerGenerated]
		public static void SetPdfScale (this IPSPDFAnnotationViewProtocol This, global::System.nfloat pdfScale)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setPDFScale:"), pdfScale);
		}
		
		[CompilerGenerated]
		public static PSPDFPageView GetPageView (this IPSPDFAnnotationViewProtocol This)
		{
			return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("PageView")));
		}
		
		[CompilerGenerated]
		public static void SetPageView (this IPSPDFAnnotationViewProtocol This, PSPDFPageView PageView)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPageView:"), PageView == null ? IntPtr.Zero : PageView.Handle);
		}
		
		[CompilerGenerated]
		public static PSPDFConfiguration GetConfiguration (this IPSPDFAnnotationViewProtocol This)
		{
			return  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("configuration")));
		}
		
		[CompilerGenerated]
		public static void SetConfiguration (this IPSPDFAnnotationViewProtocol This, PSPDFConfiguration configuration)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setConfiguration:"), configuration.Handle);
		}
		
		[CompilerGenerated]
		public static bool GetSelected (this IPSPDFAnnotationViewProtocol This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSelected"));
		}
		
		[CompilerGenerated]
		public static void SetSelected (this IPSPDFAnnotationViewProtocol This, bool selected)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setSelected:"), selected);
		}
		
		[CompilerGenerated]
		public static void DidShowPageView (this IPSPDFAnnotationViewProtocol This, PSPDFPageView pageView)
		{
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didShowPageView:"), pageView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidHidePageView (this IPSPDFAnnotationViewProtocol This, PSPDFPageView pageView)
		{
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didHidePageView:"), pageView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangePageBounds (this IPSPDFAnnotationViewProtocol This, CGRect bounds)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("didChangePageBounds:"), bounds);
		}
		
		[CompilerGenerated]
		public static void DidTapAtPoint (this IPSPDFAnnotationViewProtocol This, CGPoint point)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("didTapAtPoint:"), point);
		}
		
		[CompilerGenerated]
		public static bool ShouldSyncRemovalFromSuperview (this IPSPDFAnnotationViewProtocol This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldSyncRemovalFromSuperview"));
		}
		
		[CompilerGenerated]
		public static void WillRemoveFromSuperview (this IPSPDFAnnotationViewProtocol This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("willRemoveFromSuperview"));
		}
		
	}
	
	internal sealed class PSPDFAnnotationViewProtocolWrapper : BaseWrapper, IPSPDFAnnotationViewProtocol {
		public PSPDFAnnotationViewProtocolWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationViewProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAnnotationViewProtocol", false)]
	[Model]
	public unsafe partial class PSPDFAnnotationViewProtocol : NSObject, IPSPDFAnnotationViewProtocol {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationViewProtocol () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationViewProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationViewProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("didChangePageBounds:")]
		[CompilerGenerated]
		public virtual void DidChangePageBounds (CGRect bounds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didHidePageView:")]
		[CompilerGenerated]
		public virtual void DidHidePageView (PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didShowPageView:")]
		[CompilerGenerated]
		public virtual void DidShowPageView (PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didTapAtPoint:")]
		[CompilerGenerated]
		public virtual void DidTapAtPoint (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("annotation")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation GetAnnotation ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("configuration")]
		[CompilerGenerated]
		public virtual PSPDFConfiguration GetConfiguration ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("PageView")]
		[CompilerGenerated]
		public virtual PSPDFPageView GetPageView ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("PDFScale")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetPdfScale ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isSelected")]
		[CompilerGenerated]
		public virtual bool GetSelected ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("zIndex")]
		[CompilerGenerated]
		public virtual global::System.nuint GetZIndex ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("zoomScale")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetZoomScale ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setAnnotation:")]
		[CompilerGenerated]
		public virtual void SetAnnotation (PSPDFAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setConfiguration:")]
		[CompilerGenerated]
		public virtual void SetConfiguration (PSPDFConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setPageView:")]
		[CompilerGenerated]
		public virtual void SetPageView (PSPDFPageView PageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setPDFScale:")]
		[CompilerGenerated]
		public virtual void SetPdfScale (global::System.nfloat pdfScale)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setSelected:")]
		[CompilerGenerated]
		public virtual void SetSelected (bool selected)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setZIndex:")]
		[CompilerGenerated]
		public virtual void SetZIndex (global::System.nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setZoomScale:")]
		[CompilerGenerated]
		public virtual void SetZoomScale (global::System.nfloat zoomScale)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("shouldSyncRemovalFromSuperview")]
		[CompilerGenerated]
		public virtual bool ShouldSyncRemovalFromSuperview ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willRemoveFromSuperview")]
		[CompilerGenerated]
		public virtual void WillRemoveFromSuperview ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFAnnotationViewProtocol */
}
