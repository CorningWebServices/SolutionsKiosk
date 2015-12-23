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
	[Register("PSPDFFlexibleToolbarContainer", true)]
	public unsafe partial class PSPDFFlexibleToolbarContainer : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFlexibleToolbarContainer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFlexibleToolbarContainer () : base (NSObjectFlag.Empty)
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
		public PSPDFFlexibleToolbarContainer (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFFlexibleToolbarContainer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFlexibleToolbarContainer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFFlexibleToolbarContainer (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("animateToolbarPositionChangeFrom:to:")]
		[CompilerGenerated]
		public virtual void AnimateToolbarPositionChangeFrom (PSPDFFlexibleToolbarPosition currentPosition, PSPDFFlexibleToolbarPosition newPosition)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_UInt64 (this.Handle, Selector.GetHandle ("animateToolbarPositionChangeFrom:to:"), (UInt64)currentPosition, (UInt64)newPosition);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_UInt32 (this.Handle, Selector.GetHandle ("animateToolbarPositionChangeFrom:to:"), (UInt32)currentPosition, (UInt32)newPosition);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64_UInt64 (this.SuperHandle, Selector.GetHandle ("animateToolbarPositionChangeFrom:to:"), (UInt64)currentPosition, (UInt64)newPosition);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, Selector.GetHandle ("animateToolbarPositionChangeFrom:to:"), (UInt32)currentPosition, (UInt32)newPosition);
				}
			}
		}
		
		[Export ("hideAndRemoveAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void HideAndRemove (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity1V1.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("hideAndRemoveAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("hideAndRemoveAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("hideAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void HideAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity1V1.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("hideAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("hideAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("rectForToolbarPosition:")]
		[CompilerGenerated]
		public virtual CGRect RectForToolbarPosition (PSPDFFlexibleToolbarPosition toolbarPosition)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("rectForToolbarPosition:"), (UInt64)toolbarPosition);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_UInt32 (out ret, this.Handle, Selector.GetHandle ("rectForToolbarPosition:"), (UInt32)toolbarPosition);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_UInt64 (out ret, this.Handle, Selector.GetHandle ("rectForToolbarPosition:"), (UInt64)toolbarPosition);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_UInt32 (out ret, this.Handle, Selector.GetHandle ("rectForToolbarPosition:"), (UInt32)toolbarPosition);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("rectForToolbarPosition:"), (UInt64)toolbarPosition);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_UInt32 (out ret, this.SuperHandle, Selector.GetHandle ("rectForToolbarPosition:"), (UInt32)toolbarPosition);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_UInt64 (out ret, this.SuperHandle, Selector.GetHandle ("rectForToolbarPosition:"), (UInt64)toolbarPosition);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_UInt32 (out ret, this.SuperHandle, Selector.GetHandle ("rectForToolbarPosition:"), (UInt32)toolbarPosition);
				}
			}
			return ret;
		}
		
		[Export ("showAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void ShowAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity1V1.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("showAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("showAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_AnchorViewBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor AnchorViewBackgroundColor {
			[Export ("anchorViewBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("anchorViewBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("anchorViewBackgroundColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnchorViewBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setAnchorViewBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnchorViewBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnchorViewBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnchorViewBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ContainerDelegate_var;
		[CompilerGenerated]
		public virtual IPSPDFFlexibleToolbarContainerDelegate ContainerDelegate {
			[Export ("containerDelegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFFlexibleToolbarContainerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFFlexibleToolbarContainerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("containerDelegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFFlexibleToolbarContainerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("containerDelegate")), false);
				}
				MarkDirty ();
				__mt_ContainerDelegate_var = ret;
				return ret;
			}
			
			[Export ("setContainerDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContainerDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContainerDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_ContainerDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Dragging {
			[Export ("dragging", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("dragging"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dragging"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FlexibleToolbar_var;
		[CompilerGenerated]
		public virtual PSPDFFlexibleToolbar FlexibleToolbar {
			[Export ("flexibleToolbar", ArgumentSemantic.Retain)]
			get {
				PSPDFFlexibleToolbar ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFFlexibleToolbar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("flexibleToolbar")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFFlexibleToolbar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("flexibleToolbar")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FlexibleToolbar_var = ret;
				return ret;
			}
			
			[Export ("setFlexibleToolbar:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFlexibleToolbar:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFlexibleToolbar:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FlexibleToolbar_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool FlickToCloseEnabled {
			[Export ("isFlickToCloseEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFlickToCloseEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isFlickToCloseEnabled"));
				}
			}
			
			[Export ("setFlickToCloseEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFlickToCloseEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFlickToCloseEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_OverlaidBar_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView OverlaidBar {
			[Export ("overlaidBar", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("overlaidBar")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("overlaidBar")));
				}
				MarkDirty ();
				__mt_OverlaidBar_var = ret;
				return ret;
			}
			
			[Export ("setOverlaidBar:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOverlaidBar:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOverlaidBar:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_OverlaidBar_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnchorViewBackgroundColor_var = null;
				__mt_ContainerDelegate_var = null;
				__mt_FlexibleToolbar_var = null;
				__mt_OverlaidBar_var = null;
			}
		}
		public partial class PSPDFFlexibleToolbarContainerAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFFlexibleToolbarContainerAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFFlexibleToolbarContainerAppearance Appearance {
			get { return new PSPDFFlexibleToolbarContainerAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFFlexibleToolbarContainerAppearance GetAppearance<T> () where T: PSPDFFlexibleToolbarContainer {
			return new PSPDFFlexibleToolbarContainerAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFFlexibleToolbarContainerAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFFlexibleToolbarContainerAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFFlexibleToolbarContainerAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFFlexibleToolbarContainerAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFFlexibleToolbarContainerAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFFlexibleToolbarContainerAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFFlexibleToolbarContainerAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFFlexibleToolbarContainer {
			return new PSPDFFlexibleToolbarContainerAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFFlexibleToolbarContainerAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFFlexibleToolbarContainer{
			return new PSPDFFlexibleToolbarContainerAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFFlexibleToolbarContainer */
}
