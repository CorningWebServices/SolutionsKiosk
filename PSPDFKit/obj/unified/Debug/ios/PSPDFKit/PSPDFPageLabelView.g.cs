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
	[Register("PSPDFPageLabelView", true)]
	public unsafe partial class PSPDFPageLabelView : PSPDFLabelView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageLabelView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPageLabelView () : base (NSObjectFlag.Empty)
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
		public PSPDFPageLabelView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFPageLabelView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPageLabelView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("pageLabelWithDocument:page:visiblePages:")]
		[CompilerGenerated]
		public virtual string PageLabel (PSPDFDocument document, global::System.nuint page, NSOrderedSet visiblePages)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (visiblePages == null)
				throw new ArgumentNullException ("visiblePages");
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("pageLabelWithDocument:page:visiblePages:"), document.Handle, page, visiblePages.Handle));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("pageLabelWithDocument:page:visiblePages:"), document.Handle, page, visiblePages.Handle));
			}
		}
		
		[Export ("updateFrame")]
		[CompilerGenerated]
		public virtual void UpdateFrame ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateFrame"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateFrame"));
			}
		}
		
		[Export ("updateLabelWithDocument:page:visiblePages:")]
		[CompilerGenerated]
		public virtual bool UpdateLabelWithDocument (PSPDFDocument document, global::System.nuint page, NSOrderedSet visiblePages)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (visiblePages == null)
				throw new ArgumentNullException ("visiblePages");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("updateLabelWithDocument:page:visiblePages:"), document.Handle, page, visiblePages.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("updateLabelWithDocument:page:visiblePages:"), document.Handle, page, visiblePages.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFPageLabelViewDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFPageLabelViewDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFPageLabelViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFPageLabelViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowThumbnailGridButton {
			[Export ("showThumbnailGridButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showThumbnailGridButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showThumbnailGridButton"));
				}
			}
			
			[Export ("setShowThumbnailGridButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowThumbnailGridButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowThumbnailGridButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ThumbnailGridButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton ThumbnailGridButton {
			[Export ("thumbnailGridButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailGridButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailGridButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ThumbnailGridButton_var = ret;
				return ret;
			}
			
			[Export ("setThumbnailGridButton:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setThumbnailGridButton:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setThumbnailGridButton:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ThumbnailGridButton_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_ThumbnailGridButton_var = null;
			}
		}
		public partial class PSPDFPageLabelViewAppearance : global::PSPDFKit.PSPDFLabelView.PSPDFLabelViewAppearance {
			protected internal PSPDFPageLabelViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFPageLabelViewAppearance Appearance {
			get { return new PSPDFPageLabelViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFPageLabelViewAppearance GetAppearance<T> () where T: PSPDFPageLabelView {
			return new PSPDFPageLabelViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFPageLabelViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFPageLabelViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFPageLabelViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFPageLabelViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFPageLabelViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFPageLabelViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFPageLabelViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFPageLabelView {
			return new PSPDFPageLabelViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFPageLabelViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFPageLabelView{
			return new PSPDFPageLabelViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFPageLabelView */
}
