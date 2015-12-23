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
	[Register("PSPDFButton", true)]
	public unsafe partial class PSPDFButton : global::UIKit.UIButton {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFButton () : base (NSObjectFlag.Empty)
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
		public PSPDFButton (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFButton (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFButton (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setActionBlock:forControlEvents:")]
		[CompilerGenerated]
		public unsafe virtual void SetActionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V9))]global::System.Action<PSPDFButton> action, global::UIKit.UIControlEvent controlEvents)
		{
			BlockLiteral *block_ptr_action;
			BlockLiteral block_action;
			if (action == null){
				block_ptr_action = null;
			} else {
				block_action = new BlockLiteral ();
				block_ptr_action = &block_action;
				block_action.SetupBlock (Trampolines.SDActionArity1V9.Handler, action);
			}
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("setActionBlock:forControlEvents:"), (IntPtr) block_ptr_action, (UInt64)controlEvents);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("setActionBlock:forControlEvents:"), (IntPtr) block_ptr_action, (UInt32)controlEvents);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("setActionBlock:forControlEvents:"), (IntPtr) block_ptr_action, (UInt64)controlEvents);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("setActionBlock:forControlEvents:"), (IntPtr) block_ptr_action, (UInt32)controlEvents);
				}
			}
			if (block_ptr_action != null)
				block_ptr_action->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public unsafe virtual global::System.Action<PSPDFButton> ActionHandler {
			[Export ("actionBlock", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("actionBlock"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionBlock"));
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity1V9.Create (ret);
			}
			
			[Export ("setActionBlock:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDActionArity1V9.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActionBlock:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setActionBlock:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool PositionImageOnRight {
			[Export ("positionImageOnRight", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("positionImageOnRight"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("positionImageOnRight"));
				}
			}
			
			[Export ("setPositionImageOnRight:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPositionImageOnRight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPositionImageOnRight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets TouchAreaInsets {
			[Export ("touchAreaInsets", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("touchAreaInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("touchAreaInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("touchAreaInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("touchAreaInsets"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("touchAreaInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("touchAreaInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("touchAreaInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("touchAreaInsets"));
					}
				}
				return ret;
			}
			
			[Export ("setTouchAreaInsets:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setTouchAreaInsets:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setTouchAreaInsets:"), value);
				}
			}
		}
		
		public partial class PSPDFButtonAppearance : global::UIKit.UIButton.UIButtonAppearance {
			protected internal PSPDFButtonAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFButtonAppearance Appearance {
			get { return new PSPDFButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFButtonAppearance GetAppearance<T> () where T: PSPDFButton {
			return new PSPDFButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFButtonAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFButtonAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFButtonAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFButtonAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFButtonAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFButton {
			return new PSPDFButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFButtonAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFButton{
			return new PSPDFButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFButton */
}
