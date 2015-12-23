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
	[Register("PSPDFDocumentInfoCoordinator", true)]
	public unsafe partial class PSPDFDocumentInfoCoordinator : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentInfoCoordinator");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocumentInfoCoordinator () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentInfoCoordinator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentInfoCoordinator (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("controllerForOption:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController ControllerForOption (NSString option)
		{
			if (option == null)
				throw new ArgumentNullException ("option");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("controllerForOption:"), option.Handle));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("controllerForOption:"), option.Handle));
			}
		}
		
		[Export ("isAvailable")]
		[CompilerGenerated]
		public virtual bool IsAvailable ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAvailable"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAvailable"));
			}
		}
		
		[Export ("isOptionAvailable:")]
		[CompilerGenerated]
		public virtual bool IsOptionAvailable (NSString option)
		{
			if (option == null)
				throw new ArgumentNullException ("option");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isOptionAvailable:"), option.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isOptionAvailable:"), option.Handle);
			}
		}
		
		[Export ("presentToViewController:options:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual NSObject PresentToViewController (IPSPDFPresentationActions targetController, NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (targetController == null)
				throw new ArgumentNullException ("targetController");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("presentToViewController:options:sender:animated:completion:"), targetController.Handle, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_completion));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("presentToViewController:options:sender:animated:completion:"), targetController.Handle, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_completion));
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("setDidCreateControllerBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetDidCreateControllerHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<global::UIKit.UIViewController, NSString> handler)
		{
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDActionArity2V0.Handler, handler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDidCreateControllerBlock:"), (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDidCreateControllerBlock:"), (IntPtr) block_ptr_handler);
			}
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_AvailableControllerOptions_var;
		[CompilerGenerated]
		public virtual NSString[] AvailableControllerOptions {
			[Export ("availableControllerOptions", ArgumentSemantic.Copy)]
			get {
				NSString[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("availableControllerOptions")));
				} else {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availableControllerOptions")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AvailableControllerOptions_var = ret;
				return ret;
			}
			
			[Export ("setAvailableControllerOptions:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAvailableControllerOptions:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAvailableControllerOptions:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_AvailableControllerOptions_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFOverridable Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFOverridable ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFOverridable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFOverridable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document", ArgumentSemantic.Retain)]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("document")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("document")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDocument:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDocument:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AvailableControllerOptions_var = null;
				__mt_Delegate_var = null;
				__mt_Document_var = null;
			}
		}
	} /* class PSPDFDocumentInfoCoordinator */
}
