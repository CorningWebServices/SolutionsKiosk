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
	[Register("PSPDFStylusManager", true)]
	public unsafe partial class PSPDFStylusManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFStylusManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFStylusManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFStylusManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStylusManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addDelegate:")]
		[CompilerGenerated]
		public virtual void AddDelegate (IPSPDFStylusDriverDelegate aDelegate)
		{
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addDelegate:"), aDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addDelegate:"), aDelegate.Handle);
			}
		}
		
		[Export ("driverAllowsClassification")]
		[CompilerGenerated]
		public virtual bool DriverAllowsClassification ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("driverAllowsClassification"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("driverAllowsClassification"));
			}
		}
		
		[Export ("embeddedSizeForSettingsController")]
		[CompilerGenerated]
		public virtual CGSize EmbeddedSizeForSettingsController ()
		{
			CGSize ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("embeddedSizeForSettingsController"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("embeddedSizeForSettingsController"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("embeddedSizeForSettingsController"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("embeddedSizeForSettingsController"));
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("embeddedSizeForSettingsController"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("embeddedSizeForSettingsController"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("embeddedSizeForSettingsController"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("embeddedSizeForSettingsController"));
				}
			}
			return ret;
		}
		
		[Export ("enableLastDriver")]
		[CompilerGenerated]
		public virtual bool EnableLastDriver ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableLastDriver"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableLastDriver"));
			}
		}
		
		[Export ("hasSettingsControllerForDriverClass:")]
		[CompilerGenerated]
		public virtual bool HasSettingsControllerForDriverClass (Class driver)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hasSettingsControllerForDriverClass:"), driver == null ? IntPtr.Zero : driver.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hasSettingsControllerForDriverClass:"), driver == null ? IntPtr.Zero : driver.Handle);
			}
		}
		
		[Export ("registerView:")]
		[CompilerGenerated]
		public virtual void RegisterView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerView:"), view.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerView:"), view.Handle);
			}
		}
		
		[Export ("removeDelegate:")]
		[CompilerGenerated]
		public virtual void RemoveDelegate (IPSPDFStylusDriverDelegate aDelegate)
		{
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeDelegate:"), aDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeDelegate:"), aDelegate.Handle);
			}
		}
		
		[Export ("settingsControllerForCurrentDriver")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController SettingsControllerForCurrentDriver ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("settingsControllerForCurrentDriver")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("settingsControllerForCurrentDriver")));
			}
		}
		
		[Export ("stylusController")]
		[CompilerGenerated]
		public virtual PSPDFStylusViewController StylusController ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFStylusViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stylusController")));
			} else {
				return  Runtime.GetNSObject<PSPDFStylusViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stylusController")));
			}
		}
		
		[Export ("touchInfoForTouch:")]
		[CompilerGenerated]
		public virtual IPSPDFStylusTouch TouchInfoForTouch (global::UIKit.UITouch touch)
		{
			if (touch == null)
				throw new ArgumentNullException ("touch");
			if (IsDirectBinding) {
				return  Runtime.GetINativeObject<IPSPDFStylusTouch> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("touchInfoForTouch:"), touch.Handle), false);
			} else {
				return  Runtime.GetINativeObject<IPSPDFStylusTouch> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("touchInfoForTouch:"), touch.Handle), false);
			}
		}
		
		[Export ("unregisterView:")]
		[CompilerGenerated]
		public virtual void UnregisterView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unregisterView:"), view.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("unregisterView:"), view.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_AvailableDriverClasses_var;
		[CompilerGenerated]
		public virtual NSOrderedSet AvailableDriverClasses {
			[Export ("availableDriverClasses", ArgumentSemantic.Copy)]
			get {
				NSOrderedSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("availableDriverClasses")));
				} else {
					ret =  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availableDriverClasses")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AvailableDriverClasses_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFStylusConnectionStatus ConnectionStatus {
			[Export ("connectionStatus", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFStylusConnectionStatus ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFStylusConnectionStatus) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatus"));
					} else {
						ret = (PSPDFStylusConnectionStatus) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatus"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFStylusConnectionStatus) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionStatus"));
					} else {
						ret = (PSPDFStylusConnectionStatus) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionStatus"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual Class CurrentDriverClass {
			[Export ("currentDriverClass", ArgumentSemantic.UnsafeUnretained)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentDriverClass"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentDriverClass"));
				}
				return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
			}
			
			[Export ("setCurrentDriverClass:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCurrentDriverClass:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCurrentDriverClass:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string StylusName {
			[Export ("stylusName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stylusName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stylusName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _ConnectionStatusChangedNotification;
		[Field ("PSPDFStylusManagerConnectionStatusChangedNotification",  "__Internal")]
		public static unsafe NSString ConnectionStatusChangedNotification {
			get {
				if (_ConnectionStatusChangedNotification == null)
					_ConnectionStatusChangedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFStylusManagerConnectionStatusChangedNotification");
				return _ConnectionStatusChangedNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AvailableDriverClasses_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveConnectionStatusChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ConnectionStatusChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFStylusManager */
}
