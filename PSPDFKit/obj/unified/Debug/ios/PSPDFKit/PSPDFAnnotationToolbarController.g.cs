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
	[Register("PSPDFAnnotationToolbarController", true)]
	public unsafe partial class PSPDFAnnotationToolbarController : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationToolbarController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFAnnotationToolbarController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationToolbarController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAnnotationToolbar:")]
		[CompilerGenerated]
		public PSPDFAnnotationToolbarController (PSPDFAnnotationToolbar annotationToolbar)
			: base (NSObjectFlag.Empty)
		{
			if (annotationToolbar == null)
				throw new ArgumentNullException ("annotationToolbar");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithAnnotationToolbar:"), annotationToolbar.Handle), "initWithAnnotationToolbar:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAnnotationToolbar:"), annotationToolbar.Handle), "initWithAnnotationToolbar:");
			}
		}
		
		[Export ("hideToolbarAnimated:")]
		[CompilerGenerated]
		public virtual bool HideToolbar (bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideToolbarAnimated:"), animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("hideToolbarAnimated:"), animated);
			}
		}
		
		[Export ("showToolbarAnimated:")]
		[CompilerGenerated]
		public virtual bool ShowToolbar (bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("showToolbarAnimated:"), animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("showToolbarAnimated:"), animated);
			}
		}
		
		[Export ("toggleToolbarAnimated:")]
		[CompilerGenerated]
		public virtual void ToggleToolbar (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("toggleToolbarAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("toggleToolbarAnimated:"), animated);
			}
		}
		
		[Export ("updateHostView:container:viewController:")]
		[CompilerGenerated]
		public virtual void UpdateHostView (global::UIKit.UIView hostView, NSObject container, global::UIKit.UIViewController viewController)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateHostView:container:viewController:"), hostView == null ? IntPtr.Zero : hostView.Handle, container == null ? IntPtr.Zero : container.Handle, viewController == null ? IntPtr.Zero : viewController.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateHostView:container:viewController:"), hostView == null ? IntPtr.Zero : hostView.Handle, container == null ? IntPtr.Zero : container.Handle, viewController == null ? IntPtr.Zero : viewController.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationToolbar_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationToolbar AnnotationToolbar {
			[Export ("annotationToolbar", ArgumentSemantic.Retain)]
			get {
				PSPDFAnnotationToolbar ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAnnotationToolbar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationToolbar")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAnnotationToolbar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationToolbar")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationToolbar_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFFlexibleToolbarContainerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFFlexibleToolbarContainerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFFlexibleToolbarContainerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFFlexibleToolbarContainerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_FlexibleToolbarContainer_var;
		[CompilerGenerated]
		public virtual PSPDFFlexibleToolbarContainer FlexibleToolbarContainer {
			[Export ("flexibleToolbarContainer", ArgumentSemantic.Retain)]
			get {
				PSPDFFlexibleToolbarContainer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFFlexibleToolbarContainer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("flexibleToolbarContainer")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFFlexibleToolbarContainer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("flexibleToolbarContainer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FlexibleToolbarContainer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_HostToolbar_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView HostToolbar {
			[Export ("hostToolbar", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hostToolbar")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hostToolbar")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HostToolbar_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_HostView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView HostView {
			[Export ("hostView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hostView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hostView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HostView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_HostViewController_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController HostViewController {
			[Export ("hostViewController", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hostViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hostViewController")));
				}
				MarkDirty ();
				__mt_HostViewController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ToolbarVisible {
			[Export ("isToolbarVisible", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isToolbarVisible"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isToolbarVisible"));
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _VisibilityAnimatedKey;
		[Field ("PSPDFAnnotationToolbarControllerVisibilityAnimatedKey",  "__Internal")]
		public static unsafe NSString VisibilityAnimatedKey {
			get {
				if (_VisibilityAnimatedKey == null)
					_VisibilityAnimatedKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFAnnotationToolbarControllerVisibilityAnimatedKey");
				return _VisibilityAnimatedKey;
			}
		}
		[CompilerGenerated]
		static NSString _VisibilityDidChangeNotification;
		[Field ("PSPDFAnnotationToolbarControllerVisibilityDidChangeNotification",  "__Internal")]
		public static unsafe NSString VisibilityDidChangeNotification {
			get {
				if (_VisibilityDidChangeNotification == null)
					_VisibilityDidChangeNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFAnnotationToolbarControllerVisibilityDidChangeNotification");
				return _VisibilityDidChangeNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnnotationToolbar_var = null;
				__mt_Delegate_var = null;
				__mt_FlexibleToolbarContainer_var = null;
				__mt_HostToolbar_var = null;
				__mt_HostView_var = null;
				__mt_HostViewController_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveVisibilityDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VisibilityDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFAnnotationToolbarController */
}
