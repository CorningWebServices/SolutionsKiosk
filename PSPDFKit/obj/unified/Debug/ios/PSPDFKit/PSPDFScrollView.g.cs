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
	[Register("PSPDFScrollView", true)]
	public unsafe partial class PSPDFScrollView : PSPDFAvoidingScrollView, global::UIKit.IUIGestureRecognizerDelegate, global::UIKit.IUIScrollViewDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFScrollView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFScrollView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFScrollView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFScrollView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFScrollView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("createDoubleTapGesture")]
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer CreateDoubleTapGesture ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("createDoubleTapGesture")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("createDoubleTapGesture")));
			}
		}
		
		[Export ("doubleTapped:")]
		[CompilerGenerated]
		public virtual void DoubleTapped (global::UIKit.UITapGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("doubleTapped:"), recognizer.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("doubleTapped:"), recognizer.Handle);
			}
		}
		
		[Export ("ensureContentIsCentered")]
		[CompilerGenerated]
		public virtual void EnsureContentIsCentered ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("ensureContentIsCentered"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ensureContentIsCentered"));
			}
		}
		
		[Export ("longPress:")]
		[CompilerGenerated]
		public virtual void LongPress (global::UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("longPress:"), recognizer.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("longPress:"), recognizer.Handle);
			}
		}
		
		[Export ("pathShadowForView:")]
		[CompilerGenerated]
		public virtual NSObject PathShadowForView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("pathShadowForView:"), view.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("pathShadowForView:"), view.Handle));
			}
		}
		
		[Export ("singleTapped:")]
		[CompilerGenerated]
		public virtual void SingleTapped (global::UIKit.UITapGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("singleTapped:"), recognizer.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("singleTapped:"), recognizer.Handle);
			}
		}
		
		[Export ("updateScrollViewIndicator")]
		[CompilerGenerated]
		public virtual void UpdateScrollViewIndicator ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateScrollViewIndicator"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateScrollViewIndicator"));
			}
		}
		
		[CompilerGenerated]
		object __mt_CompoundView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView CompoundView {
			[Export ("compoundView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("compoundView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compoundView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CompoundView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DoubleTapGesture_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer DoubleTapGesture {
			[Export ("doubleTapGesture", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("doubleTapGesture")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("doubleTapGesture")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DoubleTapGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LeftPage_var;
		[CompilerGenerated]
		public virtual PSPDFPageView LeftPage {
			[Export ("leftPage", ArgumentSemantic.Retain)]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftPage")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftPage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LeftPage_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LongPressGesture_var;
		[CompilerGenerated]
		public virtual global::UIKit.UILongPressGestureRecognizer LongPressGesture {
			[Export ("longPressGesture", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UILongPressGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILongPressGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("longPressGesture")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILongPressGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("longPressGesture")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LongPressGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Page {
			[Export ("page", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("page"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("page"));
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PresentationContext_var;
		[CompilerGenerated]
		public virtual IPSPDFPresentationContext PresentationContext {
			[Export ("presentationContext", ArgumentSemantic.Weak)]
			get {
				IPSPDFPresentationContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("presentationContext")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presentationContext")), false);
				}
				MarkDirty ();
				__mt_PresentationContext_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RightPage_var;
		[CompilerGenerated]
		public virtual PSPDFPageView RightPage {
			[Export ("rightPage", ArgumentSemantic.Retain)]
			get {
				PSPDFPageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightPage")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightPage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightPage_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SelectedAnnotations_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] SelectedAnnotations {
			[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
			get {
				PSPDFAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedAnnotations")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedAnnotations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedAnnotations_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SingleTapGesture_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer SingleTapGesture {
			[Export ("singleTapGesture", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("singleTapGesture")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("singleTapGesture")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SingleTapGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ZoomingEnabled {
			[Export ("isZoomingEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isZoomingEnabled"));
				}
			}
			
			[Export ("setZoomingEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setZoomingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setZoomingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CompoundView_var = null;
				__mt_DoubleTapGesture_var = null;
				__mt_LeftPage_var = null;
				__mt_LongPressGesture_var = null;
				__mt_PresentationContext_var = null;
				__mt_RightPage_var = null;
				__mt_SelectedAnnotations_var = null;
				__mt_SingleTapGesture_var = null;
			}
		}
		public partial class PSPDFScrollViewAppearance : global::PSPDFKit.PSPDFAvoidingScrollView.PSPDFAvoidingScrollViewAppearance {
			protected internal PSPDFScrollViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFScrollViewAppearance Appearance {
			get { return new PSPDFScrollViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFScrollViewAppearance GetAppearance<T> () where T: PSPDFScrollView {
			return new PSPDFScrollViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFScrollViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFScrollViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFScrollViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFScrollViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFScrollView {
			return new PSPDFScrollViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFScrollViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFScrollView{
			return new PSPDFScrollViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFScrollView */
}
