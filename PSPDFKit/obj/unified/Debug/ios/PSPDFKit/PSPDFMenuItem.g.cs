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
	[Register("PSPDFMenuItem", true)]
	public unsafe partial class PSPDFMenuItem : global::UIKit.UIMenuItem {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMenuItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMenuItem () : base (NSObjectFlag.Empty)
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
		protected PSPDFMenuItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMenuItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTitle:block:")]
		[CompilerGenerated]
		public unsafe PSPDFMenuItem (string title, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDAction.Handler, handler);
			}
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTitle:block:"), nstitle, (IntPtr) block_ptr_handler), "initWithTitle:block:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTitle:block:"), nstitle, (IntPtr) block_ptr_handler), "initWithTitle:block:");
			}
			NSString.ReleaseNative (nstitle);
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("initWithTitle:block:identifier:")]
		[CompilerGenerated]
		public unsafe PSPDFMenuItem (string title, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler, string identifier)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDAction.Handler, handler);
			}
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTitle:block:identifier:"), nstitle, (IntPtr) block_ptr_handler, nsidentifier), "initWithTitle:block:identifier:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTitle:block:identifier:"), nstitle, (IntPtr) block_ptr_handler, nsidentifier), "initWithTitle:block:identifier:");
			}
			NSString.ReleaseNative (nstitle);
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithTitle:image:block:identifier:")]
		[CompilerGenerated]
		public unsafe PSPDFMenuItem (string title, global::UIKit.UIImage image, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler, string identifier)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDAction.Handler, handler);
			}
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTitle:image:block:identifier:"), nstitle, image.Handle, (IntPtr) block_ptr_handler, nsidentifier), "initWithTitle:image:block:identifier:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTitle:image:block:identifier:"), nstitle, image.Handle, (IntPtr) block_ptr_handler, nsidentifier), "initWithTitle:image:block:identifier:");
			}
			NSString.ReleaseNative (nstitle);
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("initWithTitle:image:block:identifier:allowImageColors:")]
		[CompilerGenerated]
		public unsafe PSPDFMenuItem (string title, global::UIKit.UIImage image, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler, string identifier, bool allowImageColors)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDAction.Handler, handler);
			var nsidentifier = NSString.CreateNative (identifier);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithTitle:image:block:identifier:allowImageColors:"), nstitle, image.Handle, (IntPtr) block_ptr_handler, nsidentifier, allowImageColors), "initWithTitle:image:block:identifier:allowImageColors:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithTitle:image:block:identifier:allowImageColors:"), nstitle, image.Handle, (IntPtr) block_ptr_handler, nsidentifier, allowImageColors), "initWithTitle:image:block:identifier:allowImageColors:");
			}
			NSString.ReleaseNative (nstitle);
			block_ptr_handler->CleanupBlock ();
			NSString.ReleaseNative (nsidentifier);
			
		}
		
		[Export ("installMenuHandlerForObject:")]
		[CompilerGenerated]
		public static void InstallMenuHandler (NSObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("installMenuHandlerForObject:"), obj.Handle);
		}
		
		[Export ("performBlock")]
		[CompilerGenerated]
		public virtual void PerformHandler ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("performBlock"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("performBlock"));
			}
		}
		
		[Export ("setActionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetAction ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDAction.Handler, handler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActionBlock:"), (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setActionBlock:"), (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual bool Enabled {
			[Export ("isEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEnabled"));
				}
			}
			
			[Export ("setEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Identifier {
			[Export ("identifier")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("identifier")));
				}
			}
			
			[Export ("setIdentifier:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIdentifier:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setIdentifier:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_PsImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage PsImage {
			[Export ("ps_image", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("ps_image")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ps_image")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PsImage_var = ret;
				return ret;
			}
			
			[Export ("setPs_image:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPs_image:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPs_image:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PsImage_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldInvokeAutomatically {
			[Export ("shouldInvokeAutomatically", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldInvokeAutomatically"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldInvokeAutomatically"));
				}
			}
			
			[Export ("setShouldInvokeAutomatically:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldInvokeAutomatically:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldInvokeAutomatically:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PsImage_var = null;
			}
		}
	} /* class PSPDFMenuItem */
}
