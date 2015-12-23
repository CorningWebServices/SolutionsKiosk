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
	[Register("PSPDFFlexibleToolbar", true)]
	public unsafe partial class PSPDFFlexibleToolbar : PSPDFToolbar {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFlexibleToolbar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFlexibleToolbar () : base (NSObjectFlag.Empty)
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
		public PSPDFFlexibleToolbar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFFlexibleToolbar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFlexibleToolbar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hideToolbarAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void HideToolbarAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler)
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
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("hideToolbarAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("hideToolbarAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("matchUIBarAppearance:")]
		[CompilerGenerated]
		public virtual void MatchUIBarAppearance (global::UIKit.UIView navigationBarOrToolbar)
		{
			if (navigationBarOrToolbar == null)
				throw new ArgumentNullException ("navigationBarOrToolbar");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("matchUIBarAppearance:"), navigationBarOrToolbar.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("matchUIBarAppearance:"), navigationBarOrToolbar.Handle);
			}
		}
		
		[Export ("menuItemForButton:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem MenuItemForButton (global::UIKit.UIButton button)
		{
			if (button == null)
				throw new ArgumentNullException ("button");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFMenuItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("menuItemForButton:"), button.Handle));
			} else {
				return  Runtime.GetNSObject<PSPDFMenuItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("menuItemForButton:"), button.Handle));
			}
		}
		
		[Export ("preferredSizeFitting:forToolbarPosition:")]
		[CompilerGenerated]
		public virtual CGSize PreferredSizeFitting (CGSize availableSize, PSPDFFlexibleToolbarPosition position)
		{
			CGSize ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_CGSize_UInt64 (this.Handle, Selector.GetHandle ("preferredSizeFitting:forToolbarPosition:"), availableSize, (UInt64)position);
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret_CGSize_UInt32 (out ret, this.Handle, Selector.GetHandle ("preferredSizeFitting:forToolbarPosition:"), availableSize, (UInt32)position);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_CGSize_UInt64 (this.Handle, Selector.GetHandle ("preferredSizeFitting:forToolbarPosition:"), availableSize, (UInt64)position);
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_CGSize_UInt32 (this.Handle, Selector.GetHandle ("preferredSizeFitting:forToolbarPosition:"), availableSize, (UInt32)position);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_CGSize_UInt64 (this.SuperHandle, Selector.GetHandle ("preferredSizeFitting:forToolbarPosition:"), availableSize, (UInt64)position);
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret_CGSize_UInt32 (out ret, this.SuperHandle, Selector.GetHandle ("preferredSizeFitting:forToolbarPosition:"), availableSize, (UInt32)position);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_CGSize_UInt64 (this.SuperHandle, Selector.GetHandle ("preferredSizeFitting:forToolbarPosition:"), availableSize, (UInt64)position);
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_CGSize_UInt32 (this.SuperHandle, Selector.GetHandle ("preferredSizeFitting:forToolbarPosition:"), availableSize, (UInt32)position);
				}
			}
			return ret;
		}
		
		[Export ("setSelectedButton:animated:")]
		[CompilerGenerated]
		public virtual void SetSelectedButton (global::UIKit.UIButton button, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setSelectedButton:animated:"), button == null ? IntPtr.Zero : button.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setSelectedButton:animated:"), button == null ? IntPtr.Zero : button.Handle, animated);
			}
		}
		
		[Export ("setToolbarPosition:animated:")]
		[CompilerGenerated]
		public virtual void SetToolbarPosition (PSPDFFlexibleToolbarPosition toolbarPosition, bool animated)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_bool (this.Handle, Selector.GetHandle ("setToolbarPosition:animated:"), (UInt64)toolbarPosition, animated);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, Selector.GetHandle ("setToolbarPosition:animated:"), (UInt32)toolbarPosition, animated);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64_bool (this.SuperHandle, Selector.GetHandle ("setToolbarPosition:animated:"), (UInt64)toolbarPosition, animated);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, Selector.GetHandle ("setToolbarPosition:animated:"), (UInt32)toolbarPosition, animated);
				}
			}
		}
		
		[Export ("showMenuForCollapsedButtons:fromButton:animated:")]
		[CompilerGenerated]
		public virtual void ShowMenuForCollapsedButtons (PSPDFToolbarButton[] buttons, global::UIKit.UIButton sourceButton, bool animated)
		{
			if (buttons == null)
				throw new ArgumentNullException ("buttons");
			if (sourceButton == null)
				throw new ArgumentNullException ("sourceButton");
			var nsa_buttons = NSArray.FromNSObjects (buttons);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("showMenuForCollapsedButtons:fromButton:animated:"), nsa_buttons.Handle, sourceButton.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showMenuForCollapsedButtons:fromButton:animated:"), nsa_buttons.Handle, sourceButton.Handle, animated);
			}
			nsa_buttons.Dispose ();
			
		}
		
		[Export ("showMenuWithItems:target:animated:")]
		[CompilerGenerated]
		public virtual void ShowMenuWithItems (PSPDFMenuItem[] menuItems, global::UIKit.UIView target, bool animated)
		{
			if (menuItems == null)
				throw new ArgumentNullException ("menuItems");
			if (target == null)
				throw new ArgumentNullException ("target");
			var nsa_menuItems = NSArray.FromNSObjects (menuItems);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("showMenuWithItems:target:animated:"), nsa_menuItems.Handle, target.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showMenuWithItems:target:animated:"), nsa_menuItems.Handle, target.Handle, animated);
			}
			nsa_menuItems.Dispose ();
			
		}
		
		[Export ("showToolbarAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void ShowToolbarAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler)
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
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("showToolbarAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("showToolbarAnimated:completion:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFFlexibleToolbarPosition BorderedToolbarPositions {
			[Export ("borderedToolbarPositions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFFlexibleToolbarPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("borderedToolbarPositions"));
					} else {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("borderedToolbarPositions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderedToolbarPositions"));
					} else {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderedToolbarPositions"));
					}
				}
				return ret;
			}
			
			[Export ("setBorderedToolbarPositions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setBorderedToolbarPositions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setBorderedToolbarPositions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setBorderedToolbarPositions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setBorderedToolbarPositions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Buttons_var;
		[CompilerGenerated]
		public new virtual global::UIKit.UIButton[] Buttons {
			[Export ("buttons", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIButton[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttons")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttons")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Buttons_var = ret;
				return ret;
			}
			
			[Export ("setButtons:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setButtons:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setButtons:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Buttons_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool DragEnabled {
			[Export ("isDragEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDragEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDragEnabled"));
				}
			}
			
			[Export ("setDragEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDragEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDragEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DragView_var;
		[CompilerGenerated]
		public virtual PSPDFFlexibleToolbarDragView DragView {
			[Export ("dragView", ArgumentSemantic.Retain)]
			get {
				PSPDFFlexibleToolbarDragView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFFlexibleToolbarDragView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dragView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFFlexibleToolbarDragView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dragView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DragView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SelectedBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SelectedBackgroundColor {
			[Export ("selectedBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedBackgroundColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setSelectedBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectedButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton SelectedButton {
			[Export ("selectedButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedButton_var = ret;
				return ret;
			}
			
			[Export ("setSelectedButton:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedButton:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedButton:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedButton_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectedTintColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SelectedTintColor {
			[Export ("selectedTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedTintColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedTintColor_var = ret;
				return ret;
			}
			
			[Export ("setSelectedTintColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedTintColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedTintColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedTintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFFlexibleToolbarPosition ShadowedToolbarPositions {
			[Export ("shadowedToolbarPositions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFFlexibleToolbarPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("shadowedToolbarPositions"));
					} else {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("shadowedToolbarPositions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shadowedToolbarPositions"));
					} else {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shadowedToolbarPositions"));
					}
				}
				return ret;
			}
			
			[Export ("setShadowedToolbarPositions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setShadowedToolbarPositions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setShadowedToolbarPositions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setShadowedToolbarPositions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setShadowedToolbarPositions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFFlexibleToolbarPosition SupportedToolbarPositions {
			[Export ("supportedToolbarPositions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFFlexibleToolbarPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("supportedToolbarPositions"));
					} else {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("supportedToolbarPositions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("supportedToolbarPositions"));
					} else {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("supportedToolbarPositions"));
					}
				}
				return ret;
			}
			
			[Export ("setSupportedToolbarPositions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setSupportedToolbarPositions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setSupportedToolbarPositions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setSupportedToolbarPositions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setSupportedToolbarPositions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ToolbarDelegate_var;
		[CompilerGenerated]
		public virtual IPSPDFFlexibleToolbarDelegate ToolbarDelegate {
			[Export ("toolbarDelegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFFlexibleToolbarDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFFlexibleToolbarDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarDelegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFFlexibleToolbarDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toolbarDelegate")), false);
				}
				MarkDirty ();
				__mt_ToolbarDelegate_var = ret;
				return ret;
			}
			
			[Export ("setToolbarDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setToolbarDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setToolbarDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_ToolbarDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFFlexibleToolbarPosition ToolbarPosition {
			[Export ("toolbarPosition", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFFlexibleToolbarPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarPosition"));
					} else {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarPosition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toolbarPosition"));
					} else {
						ret = (PSPDFFlexibleToolbarPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toolbarPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setToolbarPosition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setToolbarPosition:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setToolbarPosition:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setToolbarPosition:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setToolbarPosition:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Buttons_var = null;
				__mt_DragView_var = null;
				__mt_SelectedBackgroundColor_var = null;
				__mt_SelectedButton_var = null;
				__mt_SelectedTintColor_var = null;
				__mt_ToolbarDelegate_var = null;
			}
		}
		public partial class PSPDFFlexibleToolbarAppearance : global::PSPDFKit.PSPDFToolbar.PSPDFToolbarAppearance {
			protected internal PSPDFFlexibleToolbarAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFFlexibleToolbarAppearance Appearance {
			get { return new PSPDFFlexibleToolbarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFFlexibleToolbarAppearance GetAppearance<T> () where T: PSPDFFlexibleToolbar {
			return new PSPDFFlexibleToolbarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFFlexibleToolbarAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFFlexibleToolbarAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFFlexibleToolbarAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFFlexibleToolbarAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFFlexibleToolbarAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFFlexibleToolbarAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFFlexibleToolbarAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFFlexibleToolbar {
			return new PSPDFFlexibleToolbarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFFlexibleToolbarAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFFlexibleToolbar{
			return new PSPDFFlexibleToolbarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFFlexibleToolbar */
}
