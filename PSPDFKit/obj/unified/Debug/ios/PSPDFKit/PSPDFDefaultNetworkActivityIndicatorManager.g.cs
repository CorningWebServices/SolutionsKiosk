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
	[Register("PSPDFDefaultNetworkActivityIndicatorManager", true)]
	public unsafe partial class PSPDFDefaultNetworkActivityIndicatorManager : NSObject, IPSPDFNetworkActivityIndicatorManager {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDefaultNetworkActivityIndicatorManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDefaultNetworkActivityIndicatorManager () : base (NSObjectFlag.Empty)
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
		protected PSPDFDefaultNetworkActivityIndicatorManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDefaultNetworkActivityIndicatorManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("decrementActivityCount")]
		[CompilerGenerated]
		public virtual void DecrementActivityCount ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("decrementActivityCount"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("decrementActivityCount"));
			}
		}
		
		[Export ("isEnabled")]
		[CompilerGenerated]
		public virtual bool GetIsEnabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEnabled"));
			}
		}
		
		[Export ("isNetworkActivityIndicatorVisible")]
		[CompilerGenerated]
		public virtual bool GetIsNetworkActivityIndicatorVisible ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isNetworkActivityIndicatorVisible"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isNetworkActivityIndicatorVisible"));
			}
		}
		
		[Export ("incrementActivityCount")]
		[CompilerGenerated]
		public virtual void IncrementActivityCount ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("incrementActivityCount"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("incrementActivityCount"));
			}
		}
		
		[Export ("setEnabled:")]
		[CompilerGenerated]
		public virtual void SetIsEnabled (bool isEnabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), isEnabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnabled:"), isEnabled);
			}
		}
		
		[CompilerGenerated]
		static NSString _DidFinishNotification;
		[Field ("PSPDFNetworkActivityDidFinishNotification",  "__Internal")]
		public static unsafe NSString DidFinishNotification {
			get {
				if (_DidFinishNotification == null)
					_DidFinishNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFNetworkActivityDidFinishNotification");
				return _DidFinishNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidStartNotification;
		[Field ("PSPDFNetworkActivityDidStartNotification",  "__Internal")]
		public static unsafe NSString DidStartNotification {
			get {
				if (_DidStartNotification == null)
					_DidStartNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFNetworkActivityDidStartNotification");
				return _DidStartNotification;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDidFinish (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFinishNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidStart (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStartNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFDefaultNetworkActivityIndicatorManager */
}
