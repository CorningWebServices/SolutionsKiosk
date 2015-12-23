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
	[Register("PSPDFDocumentActionExecutor", true)]
	public unsafe partial class PSPDFDocumentActionExecutor : NSObject, IPSPDFDocumentSharingCoordinatorDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentActionExecutor");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocumentActionExecutor () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentActionExecutor (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentActionExecutor (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPresentationController:")]
		[CompilerGenerated]
		public PSPDFDocumentActionExecutor (IPSPDFPresentationActions presentationController)
			: base (NSObjectFlag.Empty)
		{
			if (presentationController == null)
				throw new ArgumentNullException ("presentationController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithPresentationController:"), presentationController.Handle), "initWithPresentationController:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithPresentationController:"), presentationController.Handle), "initWithPresentationController:");
			}
		}
		
		[Export ("canExecuteAction:")]
		[CompilerGenerated]
		public virtual bool CanExecuteAction (string action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsaction = NSString.CreateNative (action);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("canExecuteAction:"), nsaction);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("canExecuteAction:"), nsaction);
			}
			NSString.ReleaseNative (nsaction);
			
			return ret;
		}
		
		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			if (originalClass == null)
				throw new ArgumentNullException ("originalClass");
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("classForClass:"), originalClass.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("classForClass:"), originalClass.Handle);
			}
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("documentSharingCoordinator:didFailWithError:")]
		[CompilerGenerated]
		public virtual void DidFail (PSPDFDocumentSharingCoordinator coordinator, NSError error)
		{
			if (coordinator == null)
				throw new ArgumentNullException ("coordinator");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("documentSharingCoordinator:didFailWithError:"), coordinator.Handle, error.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("documentSharingCoordinator:didFailWithError:"), coordinator.Handle, error.Handle);
			}
		}
		
		[Export ("executeAction:options:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void ExecuteAction (string action, NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsaction = NSString.CreateNative (action);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("executeAction:options:sender:animated:completion:"), nsaction, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("executeAction:options:sender:animated:completion:"), nsaction, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_completion);
			}
			NSString.ReleaseNative (nsaction);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFDocumentActionExecutorDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFDocumentActionExecutorDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentActionExecutorDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentActionExecutorDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDocument:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDocument:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PresentationController_var;
		[CompilerGenerated]
		public virtual IPSPDFPresentationActions PresentationController {
			[Export ("presentationController", ArgumentSemantic.Weak)]
			get {
				IPSPDFPresentationActions ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationActions> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("presentationController")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationActions> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presentationController")), false);
				}
				MarkDirty ();
				__mt_PresentationController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Document_var = null;
				__mt_PresentationController_var = null;
			}
		}
	} /* class PSPDFDocumentActionExecutor */
}
