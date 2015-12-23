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
	[Register("PSPDFDocumentSharingCoordinator", true)]
	public unsafe partial class PSPDFDocumentSharingCoordinator : NSObject, IPSPDFDocumentSharingViewControllerDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentSharingCoordinator");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFDocumentSharingCoordinator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentSharingCoordinator (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFDocumentSharingCoordinator (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocument:"), document.Handle), "initWithDocument:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocument:"), document.Handle), "initWithDocument:");
			}
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
		
		[Export ("configureSharingController:")]
		[CompilerGenerated]
		public virtual bool ConfigureSharingController (PSPDFDocumentSharingViewController sharingController)
		{
			if (sharingController == null)
				throw new ArgumentNullException ("sharingController");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("configureSharingController:"), sharingController.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("configureSharingController:"), sharingController.Handle);
			}
		}
		
		[Export ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:")]
		[CompilerGenerated]
		public virtual void DidFinishWithSelectedOptions (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions selectedSharingOption, NSObject[] files, NSAttributedString annotationSummary, NSError error)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (files == null)
				throw new ArgumentNullException ("files");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsa_files = NSArray.FromNSObjects (files);
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:"), shareController.Handle, (UInt64)selectedSharingOption, nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, error.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:"), shareController.Handle, (UInt32)selectedSharingOption, nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, error.Handle);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:"), shareController.Handle, (UInt64)selectedSharingOption, nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, error.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:"), shareController.Handle, (UInt32)selectedSharingOption, nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, error.Handle);
				}
			}
			nsa_files.Dispose ();
			
		}
		
		[Export ("documentSharingViewControllerDidCancel:")]
		[CompilerGenerated]
		public virtual void DocumentSharingViewControllerDidCancel (PSPDFDocumentSharingViewController shareController)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("documentSharingViewControllerDidCancel:"), shareController.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("documentSharingViewControllerDidCancel:"), shareController.Handle);
			}
		}
		
		[Export ("isAvailableUserInvoked:")]
		[CompilerGenerated]
		public virtual bool IsAvailableUserInvoked (bool userInvoked)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("isAvailableUserInvoked:"), userInvoked);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("isAvailableUserInvoked:"), userInvoked);
			}
		}
		
		[Export ("documentSharingViewController:preparationProgress:")]
		[CompilerGenerated]
		public virtual string PreparationProgress (PSPDFDocumentSharingViewController shareController, global::System.nfloat progress)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nfloat (this.Handle, Selector.GetHandle ("documentSharingViewController:preparationProgress:"), shareController.Handle, progress));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:preparationProgress:"), shareController.Handle, progress));
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
		
		[Export ("processorOptionsForDocumentSharingViewController:")]
		[CompilerGenerated]
		public virtual NSDictionary ProcessorOptionsForDocumentSharingViewController (PSPDFDocumentSharingViewController shareController)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("processorOptionsForDocumentSharingViewController:"), shareController.Handle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("processorOptionsForDocumentSharingViewController:"), shareController.Handle));
			}
		}
		
		[Export ("documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:")]
		[CompilerGenerated]
		public virtual bool ShouldPrepareWithSelectedOptions (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions selectedSharingOption, NSIndexSet selectedPages)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (selectedPages == null)
				throw new ArgumentNullException ("selectedPages");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr (this.Handle, Selector.GetHandle ("documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:"), shareController.Handle, (UInt64)selectedSharingOption, selectedPages.Handle);
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:"), shareController.Handle, (UInt32)selectedSharingOption, selectedPages.Handle);
				}
			} else {
				if (IntPtr.Size == 8) {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:"), shareController.Handle, (UInt64)selectedSharingOption, selectedPages.Handle);
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:"), shareController.Handle, (UInt32)selectedSharingOption, selectedPages.Handle);
				}
			}
		}
		
		[Export ("showActionControllerToViewController:sender:sendOptions:files:annotationSummary:animated:")]
		[CompilerGenerated]
		public virtual void ShowActionController (IPSPDFPresentationActions targetController, NSObject sender, PSPDFDocumentSharingOptions sendOptions, NSObject[] files, NSAttributedString annotationSummary, bool animated)
		{
			if (targetController == null)
				throw new ArgumentNullException ("targetController");
			var nsa_files = files == null ? null : NSArray.FromNSObjects (files);
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("showActionControllerToViewController:sender:sendOptions:files:annotationSummary:animated:"), targetController.Handle, sender == null ? IntPtr.Zero : sender.Handle, (UInt64)sendOptions, nsa_files == null ? IntPtr.Zero : nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, animated);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("showActionControllerToViewController:sender:sendOptions:files:annotationSummary:animated:"), targetController.Handle, sender == null ? IntPtr.Zero : sender.Handle, (UInt32)sendOptions, nsa_files == null ? IntPtr.Zero : nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, animated);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showActionControllerToViewController:sender:sendOptions:files:annotationSummary:animated:"), targetController.Handle, sender == null ? IntPtr.Zero : sender.Handle, (UInt64)sendOptions, nsa_files == null ? IntPtr.Zero : nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, animated);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showActionControllerToViewController:sender:sendOptions:files:annotationSummary:animated:"), targetController.Handle, sender == null ? IntPtr.Zero : sender.Handle, (UInt32)sendOptions, nsa_files == null ? IntPtr.Zero : nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, animated);
				}
			}
			if (nsa_files != null)
				nsa_files.Dispose ();
			
		}
		
		[Export ("documentSharingViewController:subtitleForOption:")]
		[CompilerGenerated]
		public virtual string SubtitleForOption (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions option)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("documentSharingViewController:subtitleForOption:"), shareController.Handle, (UInt64)option));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("documentSharingViewController:subtitleForOption:"), shareController.Handle, (UInt32)option));
				}
			} else {
				if (IntPtr.Size == 8) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:subtitleForOption:"), shareController.Handle, (UInt64)option));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:subtitleForOption:"), shareController.Handle, (UInt32)option));
				}
			}
		}
		
		[Export ("temporaryDirectoryForDocumentSharingViewController:")]
		[CompilerGenerated]
		public virtual string TemporaryDirectoryForDocumentSharingViewController (PSPDFDocumentSharingViewController shareController)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("temporaryDirectoryForDocumentSharingViewController:"), shareController.Handle));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("temporaryDirectoryForDocumentSharingViewController:"), shareController.Handle));
			}
		}
		
		[Export ("documentSharingViewController:titleForOption:")]
		[CompilerGenerated]
		public virtual string TitleForOption (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions option)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("documentSharingViewController:titleForOption:"), shareController.Handle, (UInt64)option));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("documentSharingViewController:titleForOption:"), shareController.Handle, (UInt32)option));
				}
			} else {
				if (IntPtr.Size == 8) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:titleForOption:"), shareController.Handle, (UInt64)option));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("documentSharingViewController:titleForOption:"), shareController.Handle, (UInt32)option));
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Available {
			[Export ("isAvailable", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAvailable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAvailable"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CommitButtonTitle {
			[Export ("commitButtonTitle")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("commitButtonTitle")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("commitButtonTitle")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFDocumentSharingCoordinatorDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFDocumentSharingCoordinatorDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentSharingCoordinatorDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentSharingCoordinatorDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
			
		}
		
		[CompilerGenerated]
		public virtual bool Executing {
			[Export ("isExecuting", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isExecuting"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isExecuting"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FileManager_var;
		[CompilerGenerated]
		public virtual IPSPDFFileManager FileManager {
			[Export ("fileManager", ArgumentSemantic.Retain)]
			get {
				IPSPDFFileManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFFileManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileManager")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFFileManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileManager")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileManager_var = ret;
				return ret;
			}
			
			[Export ("setFileManager:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFileManager:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFileManager:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileManager_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Policy_var;
		[CompilerGenerated]
		public virtual IPSPDFApplicationPolicy Policy {
			[Export ("policy", ArgumentSemantic.Retain)]
			get {
				IPSPDFApplicationPolicy ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFApplicationPolicy> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("policy")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFApplicationPolicy> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("policy")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Policy_var = ret;
				return ret;
			}
			
			[Export ("setPolicy:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPolicy:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPolicy:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Policy_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string PolicyEvent {
			[Export ("policyEvent")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("policyEvent")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("policyEvent")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SharingController_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentSharingViewController SharingController {
			[Export ("sharingController", ArgumentSemantic.Retain)]
			get {
				PSPDFDocumentSharingViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocumentSharingViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sharingController")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocumentSharingViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sharingController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SharingController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFDocumentSharingOptions SharingOptions {
			[Export ("sharingOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDocumentSharingOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("sharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sharingOptions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sharingOptions"));
					}
				}
				return ret;
			}
			
			[Export ("setSharingOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setSharingOptions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setSharingOptions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_VisiblePages_var;
		[CompilerGenerated]
		public virtual NSOrderedSet VisiblePages {
			[Export ("visiblePages", ArgumentSemantic.Copy)]
			get {
				NSOrderedSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePages")));
				} else {
					ret =  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visiblePages")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_VisiblePages_var = ret;
				return ret;
			}
			
			[Export ("setVisiblePages:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVisiblePages:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setVisiblePages:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_VisiblePages_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Document_var = null;
				__mt_FileManager_var = null;
				__mt_Policy_var = null;
				__mt_SharingController_var = null;
				__mt_VisiblePages_var = null;
			}
		}
	} /* class PSPDFDocumentSharingCoordinator */
}
