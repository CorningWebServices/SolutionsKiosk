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
	[Register("PSPDFSearchHighlightView", true)]
	public unsafe partial class PSPDFSearchHighlightView : global::UIKit.UIView, IPSPDFAnnotationViewProtocol {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchHighlightView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFSearchHighlightView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFSearchHighlightView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSearchHighlightView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("didChangePageBounds:")]
		[CompilerGenerated]
		public virtual void DidChangePageBounds (CGRect bounds)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("didChangePageBounds:"), bounds);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("didChangePageBounds:"), bounds);
			}
		}
		
		[Export ("didHidePageView:")]
		[CompilerGenerated]
		public virtual void DidHidePageView (PSPDFPageView pageView)
		{
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didHidePageView:"), pageView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didHidePageView:"), pageView.Handle);
			}
		}
		
		[Export ("didShowPageView:")]
		[CompilerGenerated]
		public virtual void DidShowPageView (PSPDFPageView pageView)
		{
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didShowPageView:"), pageView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didShowPageView:"), pageView.Handle);
			}
		}
		
		[Export ("didTapAtPoint:")]
		[CompilerGenerated]
		public virtual void DidTapAtPoint (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("didTapAtPoint:"), point);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("didTapAtPoint:"), point);
			}
		}
		
		[Export ("annotation")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation GetAnnotation ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotation")));
			} else {
				return  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotation")));
			}
		}
		
		[Export ("configuration")]
		[CompilerGenerated]
		public virtual PSPDFConfiguration GetConfiguration ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("configuration")));
			} else {
				return  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("configuration")));
			}
		}
		
		[Export ("PageView")]
		[CompilerGenerated]
		public virtual PSPDFPageView GetPageView ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("PageView")));
			} else {
				return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("PageView")));
			}
		}
		
		[Export ("PDFScale")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetPdfScale ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("PDFScale"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("PDFScale"));
			}
		}
		
		[Export ("isSelected")]
		[CompilerGenerated]
		public virtual bool GetSelected ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSelected"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSelected"));
			}
		}
		
		[Export ("zIndex")]
		[CompilerGenerated]
		public virtual global::System.nuint GetZIndex ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("zIndex"));
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zIndex"));
			}
		}
		
		[Export ("zoomScale")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetZoomScale ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("zoomScale"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomScale"));
			}
		}
		
		[Export ("popupAnimation")]
		[CompilerGenerated]
		public virtual void PopupAnimation ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popupAnimation"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("popupAnimation"));
			}
		}
		
		[Export ("setAnnotation:")]
		[CompilerGenerated]
		public virtual void SetAnnotation (PSPDFAnnotation annotation)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotation:"), annotation == null ? IntPtr.Zero : annotation.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotation:"), annotation == null ? IntPtr.Zero : annotation.Handle);
			}
		}
		
		[Export ("setConfiguration:")]
		[CompilerGenerated]
		public virtual void SetConfiguration (PSPDFConfiguration configuration)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConfiguration:"), configuration.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConfiguration:"), configuration.Handle);
			}
		}
		
		[Export ("setPageView:")]
		[CompilerGenerated]
		public virtual void SetPageView (PSPDFPageView PageView)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPageView:"), PageView == null ? IntPtr.Zero : PageView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPageView:"), PageView == null ? IntPtr.Zero : PageView.Handle);
			}
		}
		
		[Export ("setPDFScale:")]
		[CompilerGenerated]
		public virtual void SetPdfScale (global::System.nfloat pdfScale)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPDFScale:"), pdfScale);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPDFScale:"), pdfScale);
			}
		}
		
		[Export ("setSelected:")]
		[CompilerGenerated]
		public virtual void SetSelected (bool selected)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSelected:"), selected);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSelected:"), selected);
			}
		}
		
		[Export ("setZIndex:")]
		[CompilerGenerated]
		public virtual void SetZIndex (global::System.nuint index)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setZIndex:"), index);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setZIndex:"), index);
			}
		}
		
		[Export ("setZoomScale:")]
		[CompilerGenerated]
		public virtual void SetZoomScale (global::System.nfloat zoomScale)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setZoomScale:"), zoomScale);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setZoomScale:"), zoomScale);
			}
		}
		
		[Export ("shouldSyncRemovalFromSuperview")]
		[CompilerGenerated]
		public virtual bool ShouldSyncRemovalFromSuperview ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldSyncRemovalFromSuperview"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldSyncRemovalFromSuperview"));
			}
		}
		
		[Export ("willRemoveFromSuperview")]
		[CompilerGenerated]
		public virtual void WillRemoveFromSuperview ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("willRemoveFromSuperview"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("willRemoveFromSuperview"));
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint CornerRadius {
			[Export ("cornerRadius", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("cornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cornerRadius"));
				}
			}
			
			[Export ("setCornerRadius:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SearchResult_var;
		[CompilerGenerated]
		public virtual PSPDFSearchResult SearchResult {
			[Export ("searchResult", ArgumentSemantic.Retain)]
			get {
				PSPDFSearchResult ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSearchResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("searchResult")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSearchResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchResult")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchResult_var = ret;
				return ret;
			}
			
			[Export ("setSearchResult:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSearchResult:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSearchResult:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchResult_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectionBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SelectionBackgroundColor {
			[Export ("selectionBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectionBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectionBackgroundColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectionBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setSelectionBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectionBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectionBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectionBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SearchResult_var = null;
				__mt_SelectionBackgroundColor_var = null;
			}
		}
		public partial class PSPDFSearchHighlightViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFSearchHighlightViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFSearchHighlightViewAppearance Appearance {
			get { return new PSPDFSearchHighlightViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFSearchHighlightViewAppearance GetAppearance<T> () where T: PSPDFSearchHighlightView {
			return new PSPDFSearchHighlightViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFSearchHighlightViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFSearchHighlightViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFSearchHighlightViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFSearchHighlightViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFSearchHighlightViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFSearchHighlightViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFSearchHighlightViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFSearchHighlightView {
			return new PSPDFSearchHighlightViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFSearchHighlightViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFSearchHighlightView{
			return new PSPDFSearchHighlightViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFSearchHighlightView */
}
