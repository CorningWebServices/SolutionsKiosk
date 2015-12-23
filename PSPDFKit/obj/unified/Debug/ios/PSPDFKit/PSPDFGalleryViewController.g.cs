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
	[Register("PSPDFGalleryViewController", true)]
	public unsafe partial class PSPDFGalleryViewController : PSPDFBaseViewController, IPSPDFOverridable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGalleryViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFGalleryViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPluginRegistry:options:")]
		[CompilerGenerated]
		public PSPDFGalleryViewController (NSObject pluginRegistry, NSDictionary options)
			: base (NSObjectFlag.Empty)
		{
			if (pluginRegistry == null)
				throw new ArgumentNullException ("pluginRegistry");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithPluginRegistry:options:"), pluginRegistry.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithPluginRegistry:options:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithPluginRegistry:options:"), pluginRegistry.Handle, options == null ? IntPtr.Zero : options.Handle), "initWithPluginRegistry:options:");
			}
		}
		
		[Export ("initWithLinkAnnotation:")]
		[CompilerGenerated]
		public PSPDFGalleryViewController (PSPDFLinkAnnotation linkAnnotation)
			: base (NSObjectFlag.Empty)
		{
			if (linkAnnotation == null)
				throw new ArgumentNullException ("linkAnnotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithLinkAnnotation:"), linkAnnotation.Handle), "initWithLinkAnnotation:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithLinkAnnotation:"), linkAnnotation.Handle), "initWithLinkAnnotation:");
			}
		}
		
		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			if (originalClass == null)
				throw new ArgumentNullException ("originalClass");
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("classForClass:"), originalClass.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("classForClass:"), originalClass.Handle);
			}
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("setFullscreen:animated:")]
		[CompilerGenerated]
		public virtual void SetFullscreen (bool fullscreen, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setFullscreen:animated:"), fullscreen, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setFullscreen:animated:"), fullscreen, animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_Configuration_var;
		[CompilerGenerated]
		public virtual PSPDFGalleryConfiguration Configuration {
			[Export ("configuration", ArgumentSemantic.Retain)]
			get {
				PSPDFGalleryConfiguration ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFGalleryConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("configuration")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFGalleryConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("configuration")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Configuration_var = ret;
				return ret;
			}
			
			[Export ("setConfiguration:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConfiguration:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConfiguration:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Configuration_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DoubleTapGestureRecognizer_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer DoubleTapGestureRecognizer {
			[Export ("doubleTapGestureRecognizer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("doubleTapGestureRecognizer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("doubleTapGestureRecognizer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DoubleTapGestureRecognizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Fullscreen {
			[Export ("isFullscreen", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFullscreen"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isFullscreen"));
				}
			}
			
			[Export ("setFullscreen:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFullscreen:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFullscreen:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Items_var;
		[CompilerGenerated]
		public virtual PSPDFGalleryItem[] Items {
			[Export ("items", ArgumentSemantic.Copy)]
			get {
				PSPDFGalleryItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFGalleryItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("items")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFGalleryItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("items")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Items_var = ret;
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
		object __mt_PanGestureRecognizer_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIPanGestureRecognizer PanGestureRecognizer {
			[Export ("panGestureRecognizer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIPanGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIPanGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("panGestureRecognizer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIPanGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("panGestureRecognizer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PanGestureRecognizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SingleTapGestureRecognizer_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer SingleTapGestureRecognizer {
			[Export ("singleTapGestureRecognizer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("singleTapGestureRecognizer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("singleTapGestureRecognizer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SingleTapGestureRecognizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFGalleryViewControllerState State {
			[Export ("state", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFGalleryViewControllerState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryViewControllerState) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					} else {
						ret = (PSPDFGalleryViewControllerState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryViewControllerState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					} else {
						ret = (PSPDFGalleryViewControllerState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Transitioning {
			[Export ("isTransitioning", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTransitioning"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isTransitioning"));
				}
			}
			
			[Export ("setTransitioning:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTransitioning:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTransitioning:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ZoomScale {
			[Export ("zoomScale", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("zoomScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomScale"));
				}
			}
			
			[Export ("setZoomScale:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setZoomScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setZoomScale:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Configuration_var = null;
				__mt_DoubleTapGestureRecognizer_var = null;
				__mt_Items_var = null;
				__mt_LinkAnnotation_var = null;
				__mt_PanGestureRecognizer_var = null;
				__mt_SingleTapGestureRecognizer_var = null;
			}
		}
	} /* class PSPDFGalleryViewController */
}
