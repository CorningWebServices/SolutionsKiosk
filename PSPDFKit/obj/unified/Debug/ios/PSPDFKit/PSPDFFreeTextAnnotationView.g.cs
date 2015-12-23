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
	[Register("PSPDFFreeTextAnnotationView", true)]
	public unsafe partial class PSPDFFreeTextAnnotationView : PSPDFHostingAnnotationView, global::UIKit.IUIScrollViewDelegate, global::UIKit.IUITextViewDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFreeTextAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFreeTextAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFFreeTextAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFFreeTextAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFreeTextAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFFreeTextAnnotationView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("beginEditing")]
		[CompilerGenerated]
		public virtual void BeginEditing ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("beginEditing"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beginEditing"));
			}
		}
		
		[Export ("endEditing")]
		[CompilerGenerated]
		public virtual void EndEditing ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endEditing"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endEditing"));
			}
		}
		
		[Export ("textViewForEditing")]
		[CompilerGenerated]
		public virtual global::UIKit.UITextView TextViewForEditing ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UITextView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textViewForEditing")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UITextView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textViewForEditing")));
			}
		}
		
		[CompilerGenerated]
		object __mt_ResizableView_var;
		[CompilerGenerated]
		public virtual PSPDFResizableView ResizableView {
			[Export ("resizableView", ArgumentSemantic.Weak)]
			get {
				PSPDFResizableView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFResizableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resizableView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFResizableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resizableView")));
				}
				MarkDirty ();
				__mt_ResizableView_var = ret;
				return ret;
			}
			
			[Export ("setResizableView:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setResizableView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setResizableView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_ResizableView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TextView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITextView TextView {
			[Export ("textView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITextView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITextView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITextView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TextView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ResizableView_var = null;
				__mt_TextView_var = null;
			}
		}
		public partial class PSPDFFreeTextAnnotationViewAppearance : global::PSPDFKit.PSPDFHostingAnnotationView.PSPDFHostingAnnotationViewAppearance {
			protected internal PSPDFFreeTextAnnotationViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFFreeTextAnnotationViewAppearance Appearance {
			get { return new PSPDFFreeTextAnnotationViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFFreeTextAnnotationViewAppearance GetAppearance<T> () where T: PSPDFFreeTextAnnotationView {
			return new PSPDFFreeTextAnnotationViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFFreeTextAnnotationViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFFreeTextAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFFreeTextAnnotationViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFFreeTextAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFFreeTextAnnotationViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFFreeTextAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFFreeTextAnnotationViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFFreeTextAnnotationView {
			return new PSPDFFreeTextAnnotationViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFFreeTextAnnotationViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFFreeTextAnnotationView{
			return new PSPDFFreeTextAnnotationViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFFreeTextAnnotationView */
}
