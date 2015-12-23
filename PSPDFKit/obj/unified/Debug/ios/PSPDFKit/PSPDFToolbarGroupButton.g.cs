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
	[Register("PSPDFToolbarGroupButton", true)]
	public unsafe partial class PSPDFToolbarGroupButton : PSPDFToolbarButton {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFToolbarGroupButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFToolbarGroupButton () : base (NSObjectFlag.Empty)
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
		public PSPDFToolbarGroupButton (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFToolbarGroupButton (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFToolbarGroupButton (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFToolbarGroupButton (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFToolbarGroupButtonIndicatorPosition GroupIndicatorPosition {
			[Export ("groupIndicatorPosition", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFToolbarGroupButtonIndicatorPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFToolbarGroupButtonIndicatorPosition) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("groupIndicatorPosition"));
					} else {
						ret = (PSPDFToolbarGroupButtonIndicatorPosition) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("groupIndicatorPosition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFToolbarGroupButtonIndicatorPosition) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("groupIndicatorPosition"));
					} else {
						ret = (PSPDFToolbarGroupButtonIndicatorPosition) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("groupIndicatorPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setGroupIndicatorPosition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setGroupIndicatorPosition:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setGroupIndicatorPosition:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setGroupIndicatorPosition:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setGroupIndicatorPosition:"), (int)value);
					}
				}
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
		public partial class PSPDFToolbarGroupButtonAppearance : global::PSPDFKit.PSPDFToolbarButton.PSPDFToolbarButtonAppearance {
			protected internal PSPDFToolbarGroupButtonAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFToolbarGroupButtonAppearance Appearance {
			get { return new PSPDFToolbarGroupButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFToolbarGroupButtonAppearance GetAppearance<T> () where T: PSPDFToolbarGroupButton {
			return new PSPDFToolbarGroupButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFToolbarGroupButtonAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFToolbarGroupButtonAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFToolbarGroupButtonAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFToolbarGroupButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFToolbarGroupButtonAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFToolbarGroupButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFToolbarGroupButtonAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFToolbarGroupButton {
			return new PSPDFToolbarGroupButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFToolbarGroupButtonAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFToolbarGroupButton{
			return new PSPDFToolbarGroupButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFToolbarGroupButton */
}
