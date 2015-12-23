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
	[Register("PSPDFDocumentPickerController", true)]
	public unsafe partial class PSPDFDocumentPickerController : PSPDFStatefulTableViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentPickerController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFDocumentPickerController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentPickerController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentPickerController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDirectory:includeSubdirectories:library:")]
		[CompilerGenerated]
		public PSPDFDocumentPickerController (string directory, bool includeSubdirectories, PSPDFLibrary library)
			: base (NSObjectFlag.Empty)
		{
			var nsdirectory = NSString.CreateNative (directory);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("initWithDirectory:includeSubdirectories:library:"), nsdirectory, includeSubdirectories, library == null ? IntPtr.Zero : library.Handle), "initWithDirectory:includeSubdirectories:library:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDirectory:includeSubdirectories:library:"), nsdirectory, includeSubdirectories, library == null ? IntPtr.Zero : library.Handle), "initWithDirectory:includeSubdirectories:library:");
			}
			NSString.ReleaseNative (nsdirectory);
			
		}
		
		[Export ("initWithDocuments:library:")]
		[CompilerGenerated]
		public PSPDFDocumentPickerController (PSPDFDocument[] documents, PSPDFLibrary library)
			: base (NSObjectFlag.Empty)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDocuments:library:"), nsa_documents.Handle, library == null ? IntPtr.Zero : library.Handle), "initWithDocuments:library:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocuments:library:"), nsa_documents.Handle, library == null ? IntPtr.Zero : library.Handle), "initWithDocuments:library:");
			}
			nsa_documents.Dispose ();
			
		}
		
		[Export ("documentsFromDirectory:includeSubdirectories:")]
		[CompilerGenerated]
		public static PSPDFDocument[] DocumentsFromDirectory (string directoryName, bool includeSubdirectories)
		{
			if (directoryName == null)
				throw new ArgumentNullException ("directoryName");
			var nsdirectoryName = NSString.CreateNative (directoryName);
			
			PSPDFDocument[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFDocument>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("documentsFromDirectory:includeSubdirectories:"), nsdirectoryName, includeSubdirectories));
			NSString.ReleaseNative (nsdirectoryName);
			
			return ret;
		}
		
		[Export ("enqueueDocumentsIfRequired")]
		[CompilerGenerated]
		public virtual void EnqueueDocumentsIfRequired ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("enqueueDocumentsIfRequired"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enqueueDocumentsIfRequired"));
			}
		}
		
		[Export ("updateStatusCell:")]
		[CompilerGenerated]
		public virtual void UpdateStatusCell (PSPDFDocumentPickerIndexStatusCell cell)
		{
			if (cell == null)
				throw new ArgumentNullException ("cell");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("updateStatusCell:"), cell.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("updateStatusCell:"), cell.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool AlwaysShowDocuments {
			[Export ("alwaysShowDocuments", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("alwaysShowDocuments"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alwaysShowDocuments"));
				}
			}
			
			[Export ("setAlwaysShowDocuments:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAlwaysShowDocuments:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAlwaysShowDocuments:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFDocumentPickerControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFDocumentPickerControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentPickerControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentPickerControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		public virtual string Directory {
			[Export ("directory")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("directory")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("directory")));
				}
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
			
		}
		
		[CompilerGenerated]
		public virtual bool FullTextSearchEnabled {
			[Export ("fullTextSearchEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("fullTextSearchEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fullTextSearchEnabled"));
				}
			}
			
			[Export ("setFullTextSearchEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFullTextSearchEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFullTextSearchEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FullTextSearchExactWordMatch {
			[Export ("fullTextSearchExactWordMatch", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("fullTextSearchExactWordMatch"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fullTextSearchExactWordMatch"));
				}
			}
			
			[Export ("setFullTextSearchExactWordMatch:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFullTextSearchExactWordMatch:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFullTextSearchExactWordMatch:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsSearchingIndex {
			[Export ("isSearchingIndex", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSearchingIndex"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSearchingIndex"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Library_var;
		[CompilerGenerated]
		public virtual PSPDFLibrary Library {
			[Export ("library", ArgumentSemantic.Retain)]
			get {
				PSPDFLibrary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFLibrary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("library")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFLibrary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("library")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Library_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint MaximumNumberOfSearchResultsDisplayed {
			[Export ("maximumNumberOfSearchResultsDisplayed", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNumberOfSearchResultsDisplayed"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumNumberOfSearchResultsDisplayed"));
				}
			}
			
			[Export ("setMaximumNumberOfSearchResultsDisplayed:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMaximumNumberOfSearchResultsDisplayed:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMaximumNumberOfSearchResultsDisplayed:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint MaximumNumberOfSearchResultsPerDocument {
			[Export ("maximumNumberOfSearchResultsPerDocument", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNumberOfSearchResultsPerDocument"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumNumberOfSearchResultsPerDocument"));
				}
			}
			
			[Export ("setMaximumNumberOfSearchResultsPerDocument:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMaximumNumberOfSearchResultsPerDocument:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMaximumNumberOfSearchResultsPerDocument:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint NumberOfSearchPreviewLines {
			[Export ("numberOfSearchPreviewLines", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfSearchPreviewLines"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfSearchPreviewLines"));
				}
			}
			
			[Export ("setNumberOfSearchPreviewLines:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setNumberOfSearchPreviewLines:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setNumberOfSearchPreviewLines:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowSearchPageResults {
			[Export ("showSearchPageResults", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showSearchPageResults"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showSearchPageResults"));
				}
			}
			
			[Export ("setShowSearchPageResults:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowSearchPageResults:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowSearchPageResults:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowSearchPreviewText {
			[Export ("showSearchPreviewText", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showSearchPreviewText"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showSearchPreviewText"));
				}
			}
			
			[Export ("setShowSearchPreviewText:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowSearchPreviewText:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowSearchPreviewText:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowSectionIndexes {
			[Export ("showSectionIndexes", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showSectionIndexes"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showSectionIndexes"));
				}
			}
			
			[Export ("setShowSectionIndexes:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowSectionIndexes:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowSectionIndexes:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseDocumentTitles {
			[Export ("useDocumentTitles", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useDocumentTitles"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useDocumentTitles"));
				}
			}
			
			[Export ("setUseDocumentTitles:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseDocumentTitles:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseDocumentTitles:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Documents_var = null;
				__mt_Library_var = null;
			}
		}
	} /* class PSPDFDocumentPickerController */
}
