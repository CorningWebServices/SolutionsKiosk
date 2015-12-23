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
	[Register("PSPDFBackForwardButton", true)]
	public unsafe partial class PSPDFBackForwardButton : PSPDFButton {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBackForwardButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBackForwardButton () : base (NSObjectFlag.Empty)
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
		public PSPDFBackForwardButton (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFBackForwardButton (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFBackForwardButton (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_BackButton_var_static;
		[CompilerGenerated]
		public static PSPDFBackForwardButton BackButton {
			[Export ("backButton")]
			get {
				PSPDFBackForwardButton ret;
				ret =  Runtime.GetNSObject<PSPDFBackForwardButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("backButton")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_BackButton_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIBlurEffectStyle BlurEffectStyle {
			[Export ("blurEffectStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIBlurEffectStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIBlurEffectStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("blurEffectStyle"));
					} else {
						ret = (global::UIKit.UIBlurEffectStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("blurEffectStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIBlurEffectStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("blurEffectStyle"));
					} else {
						ret = (global::UIKit.UIBlurEffectStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("blurEffectStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setBlurEffectStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setBlurEffectStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setBlurEffectStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setBlurEffectStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setBlurEffectStyle:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFBackButtonStyle ButtonStyle {
			[Export ("buttonStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFBackButtonStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFBackButtonStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("buttonStyle"));
					} else {
						ret = (PSPDFBackButtonStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("buttonStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFBackButtonStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonStyle"));
					} else {
						ret = (PSPDFBackButtonStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setButtonStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setButtonStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setButtonStyle:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setButtonStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setButtonStyle:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_ForwardButton_var_static;
		[CompilerGenerated]
		public static PSPDFBackForwardButton ForwardButton {
			[Export ("forwardButton")]
			get {
				PSPDFBackForwardButton ret;
				ret =  Runtime.GetNSObject<PSPDFBackForwardButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("forwardButton")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_ForwardButton_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LongPressRecognizer_var;
		[CompilerGenerated]
		public virtual global::UIKit.UILongPressGestureRecognizer LongPressRecognizer {
			[Export ("longPressRecognizer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UILongPressGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILongPressGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("longPressRecognizer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILongPressGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("longPressRecognizer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LongPressRecognizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LongPressRecognizer_var = null;
			}
		}
		public partial class PSPDFBackForwardButtonAppearance : global::PSPDFKit.PSPDFButton.PSPDFButtonAppearance {
			protected internal PSPDFBackForwardButtonAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFBackForwardButtonAppearance Appearance {
			get { return new PSPDFBackForwardButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFBackForwardButtonAppearance GetAppearance<T> () where T: PSPDFBackForwardButton {
			return new PSPDFBackForwardButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFBackForwardButtonAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFBackForwardButtonAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFBackForwardButtonAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFBackForwardButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFBackForwardButtonAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFBackForwardButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFBackForwardButtonAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFBackForwardButton {
			return new PSPDFBackForwardButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFBackForwardButtonAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFBackForwardButton{
			return new PSPDFBackForwardButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFBackForwardButton */
}
