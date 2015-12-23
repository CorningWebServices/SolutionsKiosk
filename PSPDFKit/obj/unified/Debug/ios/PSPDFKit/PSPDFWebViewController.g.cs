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
	[Register("PSPDFWebViewController", true)]
	public unsafe partial class PSPDFWebViewController : PSPDFBaseViewController, IPSPDFStyleable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFWebViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFWebViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFWebViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFWebViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFWebViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithURLRequest:")]
		[CompilerGenerated]
		public PSPDFWebViewController (NSUrlRequest request)
			: base (NSObjectFlag.Empty)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithURLRequest:"), request.Handle), "initWithURLRequest:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURLRequest:"), request.Handle), "initWithURLRequest:");
			}
		}
		
		[Export ("initWithURL:")]
		[CompilerGenerated]
		public PSPDFWebViewController (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithURL:"), url.Handle), "initWithURL:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURL:"), url.Handle), "initWithURL:");
			}
		}
		
		[Export ("action:")]
		[CompilerGenerated]
		public virtual void Action (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("action:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("action:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("createDefaultActivityViewController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIActivityViewController CreateDefaultActivityViewController ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIActivityViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("createDefaultActivityViewController")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIActivityViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("createDefaultActivityViewController")));
			}
		}
		
		[Export ("done:")]
		[CompilerGenerated]
		public virtual void Done (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("done:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("done:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("barStyle")]
		[CompilerGenerated]
		public virtual global::UIKit.UIBarStyle GetBarStyle ()
		{
			global::UIKit.UIBarStyle ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("barStyle"));
				} else {
					ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("barStyle"));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barStyle"));
				} else {
					ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barStyle"));
				}
			}
			return ret;
		}
		
		[Export ("modalWebViewWithURL:")]
		[CompilerGenerated]
		public static global::UIKit.UINavigationController GetModalWebView (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return  Runtime.GetNSObject<global::UIKit.UINavigationController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("modalWebViewWithURL:"), url.Handle));
		}
		
		[Export ("parentPopoverController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIPopoverController GetParentPopoverController ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("parentPopoverController")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parentPopoverController")));
			}
		}
		
		[Export ("prefersStatusBarHidden")]
		[CompilerGenerated]
		public virtual bool GetPrefersStatusBarHidden ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("prefersStatusBarHidden"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prefersStatusBarHidden"));
			}
		}
		
		[Export ("goBack:")]
		[CompilerGenerated]
		public virtual void GoBack (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("goBack:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("goBack:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("goForward:")]
		[CompilerGenerated]
		public virtual void GoForward (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("goForward:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("goForward:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("isBarTranslucent")]
		[CompilerGenerated]
		public virtual bool IsBarTranslucent ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBarTranslucent"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBarTranslucent"));
			}
		}
		
		[Export ("isInPopover")]
		[CompilerGenerated]
		public virtual bool IsInPopover ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInPopover"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isInPopover"));
			}
		}
		
		[Export ("setIsInPopover:")]
		[CompilerGenerated]
		public virtual void IsInPopover (bool isInPopover)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsInPopover:"), isInPopover);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsInPopover:"), isInPopover);
			}
		}
		
		[Export ("reload:")]
		[CompilerGenerated]
		public virtual void Reload (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("reload:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("reload:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("setBarStyle:")]
		[CompilerGenerated]
		public virtual void SetBarStyle (global::UIKit.UIBarStyle style)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setBarStyle:"), (Int64)style);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setBarStyle:"), (int)style);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setBarStyle:"), (Int64)style);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setBarStyle:"), (int)style);
				}
			}
		}
		
		[Export ("setIsBarTranslucent:")]
		[CompilerGenerated]
		public virtual void SetIsBarTranslucent (bool isBarTranslucent)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsBarTranslucent:"), isBarTranslucent);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsBarTranslucent:"), isBarTranslucent);
			}
		}
		
		[Export ("setParentPopoverController:")]
		[CompilerGenerated]
		public virtual void SetParentPopoverController (global::UIKit.UIPopoverController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setParentPopoverController:"), controller.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setParentPopoverController:"), controller.Handle);
			}
		}
		
		[Export ("setPrefersStatusBarHidden:")]
		[CompilerGenerated]
		public virtual void SetPrefersStatusBarHidden (bool val)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPrefersStatusBarHidden:"), val);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPrefersStatusBarHidden:"), val);
			}
		}
		
		[Export ("showHTMLWithError:")]
		[CompilerGenerated]
		public virtual void ShowHtml (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("showHTMLWithError:"), error.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("showHTMLWithError:"), error.Handle);
			}
		}
		
		[Export ("stop:")]
		[CompilerGenerated]
		public virtual void Stop (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stop:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stop:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFWebViewControllerAvailableActions AvailableActions {
			[Export ("availableActions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFWebViewControllerAvailableActions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFWebViewControllerAvailableActions) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("availableActions"));
					} else {
						ret = (PSPDFWebViewControllerAvailableActions) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("availableActions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFWebViewControllerAvailableActions) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availableActions"));
					} else {
						ret = (PSPDFWebViewControllerAvailableActions) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availableActions"));
					}
				}
				return ret;
			}
			
			[Export ("setAvailableActions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setAvailableActions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAvailableActions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setAvailableActions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAvailableActions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFWebViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFWebViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFWebViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFWebViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_ExcludedActivities_var;
		[CompilerGenerated]
		public virtual NSString[] ExcludedActivities {
			[Export ("excludedActivities", ArgumentSemantic.Copy)]
			get {
				NSString[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("excludedActivities")));
				} else {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("excludedActivities")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExcludedActivities_var = ret;
				return ret;
			}
			
			[Export ("setExcludedActivities:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setExcludedActivities:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setExcludedActivities:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ExcludedActivities_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PopoverController_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIPopoverController PopoverController {
			[Export ("popoverController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIPopoverController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("popoverController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("popoverController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PopoverController_var = ret;
				return ret;
			}
			
			[Export ("setPopoverController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPopoverController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPopoverController:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PopoverController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldUpdateTitleFromWebContent {
			[Export ("shouldUpdateTitleFromWebContent", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldUpdateTitleFromWebContent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldUpdateTitleFromWebContent"));
				}
			}
			
			[Export ("setShouldUpdateTitleFromWebContent:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldUpdateTitleFromWebContent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldUpdateTitleFromWebContent:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowProgressIndicator {
			[Export ("showProgressIndicator", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showProgressIndicator"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showProgressIndicator"));
				}
			}
			
			[Export ("setShowProgressIndicator:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowProgressIndicator:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowProgressIndicator:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseCustomErrorPage {
			[Export ("useCustomErrorPage", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useCustomErrorPage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useCustomErrorPage"));
				}
			}
			
			[Export ("setUseCustomErrorPage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseCustomErrorPage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseCustomErrorPage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseModernWebKit {
			[Export ("useModernWebKit", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useModernWebKit"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useModernWebKit"));
				}
			}
			
			[Export ("setUseModernWebKit:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseModernWebKit:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseModernWebKit:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WebView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView WebView {
			[Export ("webView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("webView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("webView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_WebView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _DidFailToLoadNotification;
		[Field ("PSPDFWebViewControllerDidFailToLoadNotification",  "__Internal")]
		public static unsafe NSString DidFailToLoadNotification {
			get {
				if (_DidFailToLoadNotification == null)
					_DidFailToLoadNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFWebViewControllerDidFailToLoadNotification");
				return _DidFailToLoadNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidFinishLoadingNotification;
		[Field ("PSPDFWebViewControllerDidFinishLoadingNotification",  "__Internal")]
		public static unsafe NSString DidFinishLoadingNotification {
			get {
				if (_DidFinishLoadingNotification == null)
					_DidFinishLoadingNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFWebViewControllerDidFinishLoadingNotification");
				return _DidFinishLoadingNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidStartLoadingNotification;
		[Field ("PSPDFWebViewControllerDidStartLoadingNotification",  "__Internal")]
		public static unsafe NSString DidStartLoadingNotification {
			get {
				if (_DidStartLoadingNotification == null)
					_DidStartLoadingNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFWebViewControllerDidStartLoadingNotification");
				return _DidStartLoadingNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_ExcludedActivities_var = null;
				__mt_PopoverController_var = null;
				__mt_WebView_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDidFailToLoad (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFailToLoadNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidFinishLoading (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFinishLoadingNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidStartLoading (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStartLoadingNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFWebViewController */
}
