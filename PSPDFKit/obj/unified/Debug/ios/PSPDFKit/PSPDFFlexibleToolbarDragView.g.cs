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
	[Register("PSPDFFlexibleToolbarDragView", true)]
	public unsafe partial class PSPDFFlexibleToolbarDragView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFlexibleToolbarDragView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFlexibleToolbarDragView () : base (NSObjectFlag.Empty)
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
		public PSPDFFlexibleToolbarDragView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFFlexibleToolbarDragView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFlexibleToolbarDragView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFFlexibleToolbarDragView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("setInverted:animated:")]
		[CompilerGenerated]
		public virtual void SetInverted (bool inverted, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setInverted:animated:"), inverted, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setInverted:animated:"), inverted, animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_BarColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BarColor {
			[Export ("barColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("barColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarColor_var = ret;
				return ret;
			}
			
			[Export ("setBarColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBarColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBarColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Inverted {
			[Export ("inverted", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("inverted"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inverted"));
				}
			}
			
			[Export ("setInverted:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setInverted:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setInverted:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BarColor_var = null;
			}
		}
		public partial class PSPDFFlexibleToolbarDragViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFFlexibleToolbarDragViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFFlexibleToolbarDragViewAppearance Appearance {
			get { return new PSPDFFlexibleToolbarDragViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFFlexibleToolbarDragViewAppearance GetAppearance<T> () where T: PSPDFFlexibleToolbarDragView {
			return new PSPDFFlexibleToolbarDragViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFFlexibleToolbarDragViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFFlexibleToolbarDragViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFFlexibleToolbarDragViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFFlexibleToolbarDragViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFFlexibleToolbarDragViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFFlexibleToolbarDragViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFFlexibleToolbarDragViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFFlexibleToolbarDragView {
			return new PSPDFFlexibleToolbarDragViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFFlexibleToolbarDragViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFFlexibleToolbarDragView{
			return new PSPDFFlexibleToolbarDragViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFFlexibleToolbarDragView */
}
