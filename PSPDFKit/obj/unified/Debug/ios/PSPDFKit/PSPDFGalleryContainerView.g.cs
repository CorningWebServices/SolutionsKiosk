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
	[Register("PSPDFGalleryContainerView", true)]
	public unsafe partial class PSPDFGalleryContainerView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGalleryContainerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFGalleryContainerView () : base (NSObjectFlag.Empty)
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
		public PSPDFGalleryContainerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryContainerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryContainerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:overrideDelegate:")]
		[CompilerGenerated]
		public PSPDFGalleryContainerView (CGRect frame, IPSPDFOverridable overrideDelegate)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("initWithFrame:overrideDelegate:"), frame, overrideDelegate == null ? IntPtr.Zero : overrideDelegate.Handle), "initWithFrame:overrideDelegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFrame:overrideDelegate:"), frame, overrideDelegate == null ? IntPtr.Zero : overrideDelegate.Handle), "initWithFrame:overrideDelegate:");
			}
		}
		
		[Export ("dismissStatusHUDAnimated:")]
		[CompilerGenerated]
		public virtual void DismissStatusHud (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("dismissStatusHUDAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("dismissStatusHUDAnimated:"), animated);
			}
		}
		
		[Export ("presentStatusHUDWithTimeout:animated:")]
		[CompilerGenerated]
		public virtual void PresentStatusHud (global::System.Double timeout, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Double_bool (this.Handle, Selector.GetHandle ("presentStatusHUDWithTimeout:animated:"), timeout, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double_bool (this.SuperHandle, Selector.GetHandle ("presentStatusHUDWithTimeout:animated:"), timeout, animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundView_var;
		[CompilerGenerated]
		public virtual PSPDFGalleryEmbeddedBackgroundView BackgroundView {
			[Export ("backgroundView", ArgumentSemantic.Retain)]
			get {
				PSPDFGalleryEmbeddedBackgroundView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFGalleryEmbeddedBackgroundView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFGalleryEmbeddedBackgroundView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundView_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ContentContainerView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView ContentContainerView {
			[Export ("contentContainerView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentContainerView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentContainerView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentContainerView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFGalleryContainerViewContentState ContentState {
			[Export ("contentState", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFGalleryContainerViewContentState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryContainerViewContentState) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("contentState"));
					} else {
						ret = (PSPDFGalleryContainerViewContentState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("contentState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryContainerViewContentState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentState"));
					} else {
						ret = (PSPDFGalleryContainerViewContentState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentState"));
					}
				}
				return ret;
			}
			
			[Export ("setContentState:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setContentState:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setContentState:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setContentState:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setContentState:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_FullscreenBackgroundView_var;
		[CompilerGenerated]
		public virtual PSPDFGalleryFullscreenBackgroundView FullscreenBackgroundView {
			[Export ("fullscreenBackgroundView", ArgumentSemantic.Retain)]
			get {
				PSPDFGalleryFullscreenBackgroundView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFGalleryFullscreenBackgroundView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fullscreenBackgroundView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFGalleryFullscreenBackgroundView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fullscreenBackgroundView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FullscreenBackgroundView_var = ret;
				return ret;
			}
			
			[Export ("setFullscreenBackgroundView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFullscreenBackgroundView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFullscreenBackgroundView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FullscreenBackgroundView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_GalleryView_var;
		[CompilerGenerated]
		public virtual PSPDFGalleryView GalleryView {
			[Export ("galleryView", ArgumentSemantic.Retain)]
			get {
				PSPDFGalleryView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFGalleryView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("galleryView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFGalleryView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("galleryView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GalleryView_var = ret;
				return ret;
			}
			
			[Export ("setGalleryView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGalleryView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGalleryView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_GalleryView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_LoadingView_var;
		[CompilerGenerated]
		public virtual IPSPDFGalleryContentViewLoading LoadingView {
			[Export ("loadingView", ArgumentSemantic.Retain)]
			get {
				IPSPDFGalleryContentViewLoading ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFGalleryContentViewLoading> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("loadingView")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFGalleryContentViewLoading> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadingView")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LoadingView_var = ret;
				return ret;
			}
			
			[Export ("setLoadingView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLoadingView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLoadingView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LoadingView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_OverrideDelegate_var;
		[CompilerGenerated]
		public virtual IPSPDFOverridable OverrideDelegate {
			[Export ("overrideDelegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFOverridable ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFOverridable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("overrideDelegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFOverridable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("overrideDelegate")), false);
				}
				MarkDirty ();
				__mt_OverrideDelegate_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFGalleryContainerViewPresentationMode PresentationMode {
			[Export ("presentationMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFGalleryContainerViewPresentationMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryContainerViewPresentationMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("presentationMode"));
					} else {
						ret = (PSPDFGalleryContainerViewPresentationMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("presentationMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryContainerViewPresentationMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presentationMode"));
					} else {
						ret = (PSPDFGalleryContainerViewPresentationMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presentationMode"));
					}
				}
				return ret;
			}
			
			[Export ("setPresentationMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setPresentationMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPresentationMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setPresentationMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPresentationMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_StatusHudView_var;
		[CompilerGenerated]
		public virtual PSPDFStatusHUDView StatusHudView {
			[Export ("statusHUDView", ArgumentSemantic.Retain)]
			get {
				PSPDFStatusHUDView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFStatusHUDView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("statusHUDView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFStatusHUDView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("statusHUDView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_StatusHudView_var = ret;
				return ret;
			}
			
			[Export ("setStatusHUDView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStatusHUDView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStatusHUDView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_StatusHudView_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BackgroundView_var = null;
				__mt_ContentContainerView_var = null;
				__mt_FullscreenBackgroundView_var = null;
				__mt_GalleryView_var = null;
				__mt_LoadingView_var = null;
				__mt_OverrideDelegate_var = null;
				__mt_StatusHudView_var = null;
			}
		}
		public partial class PSPDFGalleryContainerViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFGalleryContainerViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFGalleryContainerViewAppearance Appearance {
			get { return new PSPDFGalleryContainerViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFGalleryContainerViewAppearance GetAppearance<T> () where T: PSPDFGalleryContainerView {
			return new PSPDFGalleryContainerViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFGalleryContainerViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFGalleryContainerViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFGalleryContainerViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFGalleryContainerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFGalleryContainerViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFGalleryContainerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFGalleryContainerViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFGalleryContainerView {
			return new PSPDFGalleryContainerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFGalleryContainerViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFGalleryContainerView{
			return new PSPDFGalleryContainerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFGalleryContainerView */
}
