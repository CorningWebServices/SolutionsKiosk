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
	[Register("PSPDFMediaPlayerPlaceholderView", true)]
	public unsafe partial class PSPDFMediaPlayerPlaceholderView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMediaPlayerPlaceholderView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMediaPlayerPlaceholderView () : base (NSObjectFlag.Empty)
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
		public PSPDFMediaPlayerPlaceholderView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFMediaPlayerPlaceholderView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMediaPlayerPlaceholderView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_GradientEndColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor GradientEndColor {
			[Export ("gradientEndColor", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gradientEndColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gradientEndColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GradientEndColor_var = ret;
				return ret;
			}
			
			[Export ("setGradientEndColor:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGradientEndColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGradientEndColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_GradientEndColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_GradientStartColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor GradientStartColor {
			[Export ("gradientStartColor", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gradientStartColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gradientStartColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GradientStartColor_var = ret;
				return ret;
			}
			
			[Export ("setGradientStartColor:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGradientStartColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGradientStartColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_GradientStartColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PlaceholderImageTemplate_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage PlaceholderImageTemplate {
			[Export ("placeholderImageTemplate", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("placeholderImageTemplate")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("placeholderImageTemplate")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PlaceholderImageTemplate_var = ret;
				return ret;
			}
			
			[Export ("setPlaceholderImageTemplate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPlaceholderImageTemplate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPlaceholderImageTemplate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PlaceholderImageTemplate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_GradientEndColor_var = null;
				__mt_GradientStartColor_var = null;
				__mt_PlaceholderImageTemplate_var = null;
			}
		}
		public partial class PSPDFMediaPlayerPlaceholderViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFMediaPlayerPlaceholderViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFMediaPlayerPlaceholderViewAppearance Appearance {
			get { return new PSPDFMediaPlayerPlaceholderViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFMediaPlayerPlaceholderViewAppearance GetAppearance<T> () where T: PSPDFMediaPlayerPlaceholderView {
			return new PSPDFMediaPlayerPlaceholderViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFMediaPlayerPlaceholderViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFMediaPlayerPlaceholderViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFMediaPlayerPlaceholderViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFMediaPlayerPlaceholderViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFMediaPlayerPlaceholderViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFMediaPlayerPlaceholderViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFMediaPlayerPlaceholderViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFMediaPlayerPlaceholderView {
			return new PSPDFMediaPlayerPlaceholderViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFMediaPlayerPlaceholderViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFMediaPlayerPlaceholderView{
			return new PSPDFMediaPlayerPlaceholderViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFMediaPlayerPlaceholderView */
}
