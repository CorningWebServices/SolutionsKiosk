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
	[Register("PSPDFFormInputAccessoryView", true)]
	public unsafe partial class PSPDFFormInputAccessoryView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFormInputAccessoryView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFormInputAccessoryView () : base (NSObjectFlag.Empty)
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
		public PSPDFFormInputAccessoryView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFFormInputAccessoryView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFormInputAccessoryView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFFormInputAccessoryView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("clearButtonPressed:")]
		[CompilerGenerated]
		public virtual void ClearButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("clearButtonPressed:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("clearButtonPressed:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("doneButtonPressed:")]
		[CompilerGenerated]
		public virtual void DoneButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("doneButtonPressed:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("doneButtonPressed:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("nextButtonPressed:")]
		[CompilerGenerated]
		public virtual void NextButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("nextButtonPressed:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("nextButtonPressed:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("prevButtonPressed:")]
		[CompilerGenerated]
		public virtual void PrevButtonPressed (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("prevButtonPressed:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("prevButtonPressed:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("updateToolbar")]
		[CompilerGenerated]
		public virtual void UpdateToolbar ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateToolbar"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateToolbar"));
			}
		}
		
		[CompilerGenerated]
		object __mt_ClearButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem ClearButton {
			[Export ("clearButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("clearButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ClearButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFFormInputAccessoryViewDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFFormInputAccessoryViewDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFFormInputAccessoryViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFFormInputAccessoryViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		public virtual bool DisplayClearButton {
			[Export ("displayClearButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("displayClearButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayClearButton"));
				}
			}
			
			[Export ("setDisplayClearButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisplayClearButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisplayClearButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DisplayDoneButton {
			[Export ("displayDoneButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("displayDoneButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayDoneButton"));
				}
			}
			
			[Export ("setDisplayDoneButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisplayDoneButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisplayDoneButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DoneButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem DoneButton {
			[Export ("doneButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("doneButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("doneButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DoneButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_NextButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem NextButton {
			[Export ("nextButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("nextButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nextButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NextButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PrevButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem PrevButton {
			[Export ("prevButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("prevButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prevButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PrevButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _DidPressClearButtonNotification;
		[Field ("PSPDFFormInputAccessoryViewDidPressClearButtonNotification",  "__Internal")]
		public static unsafe NSString DidPressClearButtonNotification {
			get {
				if (_DidPressClearButtonNotification == null)
					_DidPressClearButtonNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFFormInputAccessoryViewDidPressClearButtonNotification");
				return _DidPressClearButtonNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ClearButton_var = null;
				__mt_Delegate_var = null;
				__mt_DoneButton_var = null;
				__mt_NextButton_var = null;
				__mt_PrevButton_var = null;
			}
		}
		public partial class PSPDFFormInputAccessoryViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFFormInputAccessoryViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFFormInputAccessoryViewAppearance Appearance {
			get { return new PSPDFFormInputAccessoryViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFFormInputAccessoryViewAppearance GetAppearance<T> () where T: PSPDFFormInputAccessoryView {
			return new PSPDFFormInputAccessoryViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFFormInputAccessoryViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFFormInputAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFFormInputAccessoryViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFFormInputAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFFormInputAccessoryViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFFormInputAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFFormInputAccessoryViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFFormInputAccessoryView {
			return new PSPDFFormInputAccessoryViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFFormInputAccessoryViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFFormInputAccessoryView{
			return new PSPDFFormInputAccessoryViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDidPressClearButton (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidPressClearButtonNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFFormInputAccessoryView */
}
