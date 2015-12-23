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
	[Register("PSPDFGalleryFullscreenBackgroundView", true)]
	public unsafe partial class PSPDFGalleryFullscreenBackgroundView : PSPDFBlurView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGalleryFullscreenBackgroundView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFGalleryFullscreenBackgroundView () : base (NSObjectFlag.Empty)
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
		public PSPDFGalleryFullscreenBackgroundView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryFullscreenBackgroundView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryFullscreenBackgroundView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFGalleryFullscreenBackgroundView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		public partial class PSPDFGalleryFullscreenBackgroundViewAppearance : global::PSPDFKit.PSPDFBlurView.PSPDFBlurViewAppearance {
			protected internal PSPDFGalleryFullscreenBackgroundViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFGalleryFullscreenBackgroundViewAppearance Appearance {
			get { return new PSPDFGalleryFullscreenBackgroundViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFGalleryFullscreenBackgroundViewAppearance GetAppearance<T> () where T: PSPDFGalleryFullscreenBackgroundView {
			return new PSPDFGalleryFullscreenBackgroundViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFGalleryFullscreenBackgroundViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFGalleryFullscreenBackgroundViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFGalleryFullscreenBackgroundViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFGalleryFullscreenBackgroundViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFGalleryFullscreenBackgroundViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFGalleryFullscreenBackgroundViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFGalleryFullscreenBackgroundViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFGalleryFullscreenBackgroundView {
			return new PSPDFGalleryFullscreenBackgroundViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFGalleryFullscreenBackgroundViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFGalleryFullscreenBackgroundView{
			return new PSPDFGalleryFullscreenBackgroundViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFGalleryFullscreenBackgroundView */
}
