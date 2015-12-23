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
	[Register("PSPDFLinkAnnotationBaseView", true)]
	public unsafe partial class PSPDFLinkAnnotationBaseView : global::UIKit.UIView, IPSPDFAnnotationViewProtocol {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLinkAnnotationBaseView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFLinkAnnotationBaseView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFLinkAnnotationBaseView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFLinkAnnotationBaseView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFLinkAnnotationBaseView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFLinkAnnotationBaseView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
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
		
		[Export ("isContentViewVisible")]
		[CompilerGenerated]
		public virtual bool IsContentViewVisible ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isContentViewVisible"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isContentViewVisible"));
			}
		}
		
		[Export ("populateContentView")]
		[CompilerGenerated]
		public virtual void PopulateContentView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("populateContentView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("populateContentView"));
			}
		}
		
		[Export ("prepareForReuse")]
		[CompilerGenerated]
		public virtual void PrepareForReuse ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepareForReuse"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prepareForReuse"));
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
		
		[Export ("setContentViewVisible:animated:")]
		[CompilerGenerated]
		public virtual void SetContentViewVisible (bool visible, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setContentViewVisible:animated:"), visible, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setContentViewVisible:animated:"), visible, animated);
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
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView ContentView {
			[Export ("contentView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LinkAnnotation_var;
		[CompilerGenerated]
		public virtual PSPDFLinkAnnotation LinkAnnotation {
			[Export ("linkAnnotation", ArgumentSemantic.Retain)]
			get {
				PSPDFLinkAnnotation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFLinkAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linkAnnotation")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFLinkAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkAnnotation")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LinkAnnotation_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContentView_var = null;
				__mt_LinkAnnotation_var = null;
			}
		}
		public partial class PSPDFLinkAnnotationBaseViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFLinkAnnotationBaseViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFLinkAnnotationBaseViewAppearance Appearance {
			get { return new PSPDFLinkAnnotationBaseViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFLinkAnnotationBaseViewAppearance GetAppearance<T> () where T: PSPDFLinkAnnotationBaseView {
			return new PSPDFLinkAnnotationBaseViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFLinkAnnotationBaseViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFLinkAnnotationBaseViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFLinkAnnotationBaseViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFLinkAnnotationBaseViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFLinkAnnotationBaseViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFLinkAnnotationBaseViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFLinkAnnotationBaseViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFLinkAnnotationBaseView {
			return new PSPDFLinkAnnotationBaseViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFLinkAnnotationBaseViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFLinkAnnotationBaseView{
			return new PSPDFLinkAnnotationBaseViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFLinkAnnotationBaseView */
}
