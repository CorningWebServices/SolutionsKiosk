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
	[Register("PSPDFStatefulTableViewController", true)]
	public unsafe partial class PSPDFStatefulTableViewController : PSPDFBaseTableViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFStatefulTableViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFStatefulTableViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFStatefulTableViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFStatefulTableViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStatefulTableViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setControllerState:animated:")]
		[CompilerGenerated]
		public virtual void SetControllerState (PSPDFStatefulTableViewState controllerState, bool animated)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_bool (this.Handle, Selector.GetHandle ("setControllerState:animated:"), (UInt64)controllerState, animated);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, Selector.GetHandle ("setControllerState:animated:"), (UInt32)controllerState, animated);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64_bool (this.SuperHandle, Selector.GetHandle ("setControllerState:animated:"), (UInt64)controllerState, animated);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, Selector.GetHandle ("setControllerState:animated:"), (UInt32)controllerState, animated);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFStatefulTableViewState ControllerState {
			[Export ("controllerState", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFStatefulTableViewState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFStatefulTableViewState) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("controllerState"));
					} else {
						ret = (PSPDFStatefulTableViewState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("controllerState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFStatefulTableViewState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("controllerState"));
					} else {
						ret = (PSPDFStatefulTableViewState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("controllerState"));
					}
				}
				return ret;
			}
			
			[Export ("setControllerState:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setControllerState:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setControllerState:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setControllerState:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setControllerState:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_EmptyView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView EmptyView {
			[Export ("emptyView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("emptyView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("emptyView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_EmptyView_var = ret;
				return ret;
			}
			
			[Export ("setEmptyView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEmptyView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEmptyView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_EmptyView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_LoadingView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView LoadingView {
			[Export ("loadingView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("loadingView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadingView")));
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_EmptyView_var = null;
				__mt_LoadingView_var = null;
			}
		}
	} /* class PSPDFStatefulTableViewController */
}
