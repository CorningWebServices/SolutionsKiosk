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
	[Register("PSPDFMultiDocumentViewController", true)]
	public unsafe partial class PSPDFMultiDocumentViewController : PSPDFBaseViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMultiDocumentViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMultiDocumentViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFMultiDocumentViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFMultiDocumentViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMultiDocumentViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFViewController:")]
		[CompilerGenerated]
		public PSPDFMultiDocumentViewController (PSPDFMultiDocumentPDFViewController pdfController)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithPDFViewController:"), pdfController == null ? IntPtr.Zero : pdfController.Handle), "initWithPDFViewController:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithPDFViewController:"), pdfController == null ? IntPtr.Zero : pdfController.Handle), "initWithPDFViewController:");
			}
		}
		
		[Export ("addDocuments:atIndex:")]
		[CompilerGenerated]
		public virtual void AddDocuments (PSPDFDocument[] documents, global::System.nuint index)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("addDocuments:atIndex:"), nsa_documents.Handle, index);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("addDocuments:atIndex:"), nsa_documents.Handle, index);
			}
			nsa_documents.Dispose ();
			
		}
		
		[Export ("commonInitWithPDFController:")]
		[CompilerGenerated]
		public virtual void CommonInitWithPdfController (PSPDFViewController pdfController)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("commonInitWithPDFController:"), pdfController.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("commonInitWithPDFController:"), pdfController.Handle);
			}
		}
		
		[Export ("persistState")]
		[CompilerGenerated]
		public virtual void PersistState ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("persistState"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("persistState"));
			}
		}
		
		[Export ("removeDocuments:")]
		[CompilerGenerated]
		public virtual void RemoveDocuments (PSPDFDocument[] documents)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeDocuments:"), nsa_documents.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeDocuments:"), nsa_documents.Handle);
			}
			nsa_documents.Dispose ();
			
		}
		
		[Export ("restoreState")]
		[CompilerGenerated]
		public virtual bool RestoreState ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("restoreState"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("restoreState"));
			}
		}
		
		[Export ("restoreStateAndMergeWithDocuments:")]
		[CompilerGenerated]
		public virtual bool RestoreState (PSPDFDocument[] documents)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("restoreStateAndMergeWithDocuments:"), nsa_documents.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("restoreStateAndMergeWithDocuments:"), nsa_documents.Handle);
			}
			nsa_documents.Dispose ();
			
			return ret;
		}
		
		[Export ("swizzlePDFController:")]
		[CompilerGenerated]
		public virtual void SwizzlePdfController (PSPDFViewController pdfController)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("swizzlePDFController:"), pdfController.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("swizzlePDFController:"), pdfController.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool ChangeDocumentOnTapPageEndMargin {
			[Export ("changeDocumentOnTapPageEndMargin", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("changeDocumentOnTapPageEndMargin"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("changeDocumentOnTapPageEndMargin"));
				}
			}
			
			[Export ("setChangeDocumentOnTapPageEndMargin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setChangeDocumentOnTapPageEndMargin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setChangeDocumentOnTapPageEndMargin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFMultiDocumentViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFMultiDocumentViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFMultiDocumentViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFMultiDocumentViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_Documents_var;
		[CompilerGenerated]
		public virtual PSPDFDocument[] Documents {
			[Export ("documents", ArgumentSemantic.Copy)]
			get {
				PSPDFDocument[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFDocument>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documents")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFDocument>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documents")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Documents_var = ret;
				return ret;
			}
			
			[Export ("setDocuments:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDocuments:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDocuments:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Documents_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableAutomaticStatePersistence {
			[Export ("enableAutomaticStatePersistence", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableAutomaticStatePersistence"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableAutomaticStatePersistence"));
				}
			}
			
			[Export ("setEnableAutomaticStatePersistence:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableAutomaticStatePersistence:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableAutomaticStatePersistence:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool MultiDocumentThumbnails {
			[Export ("multiDocumentThumbnails", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("multiDocumentThumbnails"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("multiDocumentThumbnails"));
				}
			}
			
			[Export ("setMultiDocumentThumbnails:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMultiDocumentThumbnails:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMultiDocumentThumbnails:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController", ArgumentSemantic.Retain)]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pdfController")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pdfController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PdfController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShowTitle {
			[Export ("showTitle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showTitle"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showTitle"));
				}
			}
			
			[Export ("setShowTitle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowTitle:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowTitle:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string StatePersistenceKey {
			[Export ("statePersistenceKey")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("statePersistenceKey")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("statePersistenceKey")));
				}
			}
			
			[Export ("setStatePersistenceKey:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStatePersistenceKey:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStatePersistenceKey:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_VisibleDocument_var;
		[CompilerGenerated]
		public virtual PSPDFDocument VisibleDocument {
			[Export ("visibleDocument", ArgumentSemantic.Retain)]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visibleDocument")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visibleDocument")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_VisibleDocument_var = ret;
				return ret;
			}
			
			[Export ("setVisibleDocument:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVisibleDocument:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setVisibleDocument:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_VisibleDocument_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Documents_var = null;
				__mt_PdfController_var = null;
				__mt_VisibleDocument_var = null;
			}
		}
	} /* class PSPDFMultiDocumentViewController */
}
