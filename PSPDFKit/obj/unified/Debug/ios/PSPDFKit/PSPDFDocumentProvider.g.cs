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
	[Register("PSPDFDocumentProvider", true)]
	public unsafe partial class PSPDFDocumentProvider : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFDocumentProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dataRepresentationWithError:")]
		[CompilerGenerated]
		internal virtual NSData DataRepresentationWithError (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("dataRepresentationWithError:"), error));
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("dataRepresentationWithError:"), error));
			}
		}
		
		[Export ("pageInfoForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageInfo PageInfoForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("pageInfoForPage:"), page));
			} else {
				return  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("pageInfoForPage:"), page));
			}
		}
		
		[Export ("pageInfoForPage:pageRef:")]
		[CompilerGenerated]
		internal virtual PSPDFPageInfo PageInfoForPage (global::System.nuint page, global::System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_IntPtr (this.Handle, Selector.GetHandle ("pageInfoForPage:pageRef:"), page, pageRef));
			} else {
				return  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("pageInfoForPage:pageRef:"), page, pageRef));
			}
		}
		
		[Export ("pageOffsetForDocument")]
		[CompilerGenerated]
		public virtual global::System.nuint PageOffsetForDocument ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("pageOffsetForDocument"));
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageOffsetForDocument"));
			}
		}
		
		[Export ("resolveTokenizedPath:alwaysLocal:")]
		[CompilerGenerated]
		public virtual string ResolveTokenizedPath (string path, bool alwaysLocal)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("resolveTokenizedPath:alwaysLocal:"), nspath, alwaysLocal));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("resolveTokenizedPath:alwaysLocal:"), nspath, alwaysLocal));
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("saveAnnotationsWithOptions:error:")]
		[CompilerGenerated]
		internal virtual bool SaveAnnotationsWithOptions (NSDictionary options, global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("saveAnnotationsWithOptions:error:"), options == null ? IntPtr.Zero : options.Handle, error);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("saveAnnotationsWithOptions:error:"), options == null ? IntPtr.Zero : options.Handle, error);
			}
		}
		
		[Export ("setPageInfo:forPage:")]
		[CompilerGenerated]
		public virtual void SetPageInfo (PSPDFPageInfo pageInfo, global::System.nuint page)
		{
			if (pageInfo == null)
				throw new ArgumentNullException ("pageInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("setPageInfo:forPage:"), pageInfo.Handle, page);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("setPageInfo:forPage:"), pageInfo.Handle, page);
			}
		}
		
		[Export ("textParserForPage:")]
		[CompilerGenerated]
		public virtual PSPDFTextParser TextParserForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFTextParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("textParserForPage:"), page));
			} else {
				return  Runtime.GetNSObject<PSPDFTextParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("textParserForPage:"), page));
			}
		}
		
		[Export ("translateCappedPageToRealPage:")]
		[CompilerGenerated]
		public virtual global::System.nuint TranslateCappedPageToRealPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("translateCappedPageToRealPage:"), page);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("translateCappedPageToRealPage:"), page);
			}
		}
		
		[Export ("translateRealPageToCappedPage:")]
		[CompilerGenerated]
		public virtual global::System.nuint TranslateRealPageToCappedPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("translateRealPageToCappedPage:"), page);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("translateRealPageToCappedPage:"), page);
			}
		}
		
		[Export ("unlockWithPassword:")]
		[CompilerGenerated]
		public virtual bool Unlock (string password)
		{
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unlockWithPassword:"), nspassword);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("unlockWithPassword:"), nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[CompilerGenerated]
		internal virtual global::System.IntPtr _DataProvider {
			[Export ("dataProvider")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataProvider"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataProvider"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AllowAnnotationChanges {
			[Export ("allowAnnotationChanges", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowAnnotationChanges"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowAnnotationChanges"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AllowsCopying {
			[Export ("allowsCopying", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsCopying"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowsCopying"));
				}
			}
			
			[Export ("setAllowsCopying:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsCopying:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowsCopying:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowsPrinting {
			[Export ("allowsPrinting", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsPrinting"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowsPrinting"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationManager_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationManager AnnotationManager {
			[Export ("annotationManager", ArgumentSemantic.Retain)]
			get {
				PSPDFAnnotationManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAnnotationManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationManager")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAnnotationManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationManager")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CanEmbedAnnotations {
			[Export ("canEmbedAnnotations", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canEmbedAnnotations"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canEmbedAnnotations"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ContentSignature_var;
		[CompilerGenerated]
		public virtual NSData ContentSignature {
			[Export ("contentSignature", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentSignature")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentSignature")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentSignature_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Data_var;
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("data")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("data")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Data_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFDocumentProviderDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFDocumentProviderDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentProviderDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentProviderDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
			[Export ("document", ArgumentSemantic.Weak)]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("document")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("document")));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_EmbeddedFilesParser_var;
		[CompilerGenerated]
		public virtual PSPDFEmbeddedFilesParser EmbeddedFilesParser {
			[Export ("embeddedFilesParser", ArgumentSemantic.Retain)]
			get {
				PSPDFEmbeddedFilesParser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFEmbeddedFilesParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("embeddedFilesParser")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFEmbeddedFilesParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("embeddedFilesParser")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_EmbeddedFilesParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt64 FileSize {
			[Export ("fileSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("fileSize"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileSize"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FileUrl_var;
		[CompilerGenerated]
		public virtual NSUrl FileUrl {
			[Export ("fileURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileUrl_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint FirstPageIndex {
			[Export ("firstPageIndex", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("firstPageIndex"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("firstPageIndex"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FormParser_var;
		[CompilerGenerated]
		public virtual PSPDFFormParser FormParser {
			[Export ("formParser", ArgumentSemantic.Retain)]
			get {
				PSPDFFormParser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFFormParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("formParser")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFFormParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formParser")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FormParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsEncrypted {
			[Export ("isEncrypted", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEncrypted"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEncrypted"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLocked {
			[Export ("isLocked", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLocked"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLocked"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LabelParser_var;
		[CompilerGenerated]
		public virtual PSPDFLabelParser LabelParser {
			[Export ("labelParser", ArgumentSemantic.Retain)]
			get {
				PSPDFLabelParser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFLabelParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labelParser")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFLabelParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labelParser")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LabelParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Metadata_var;
		[CompilerGenerated]
		public virtual NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("metadata")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("metadata")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Metadata_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool MetadataLoaded {
			[Export ("isMetadataLoaded", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMetadataLoaded"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMetadataLoaded"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OutlineParser_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineParser OutlineParser {
			[Export ("outlineParser", ArgumentSemantic.Retain)]
			get {
				PSPDFOutlineParser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFOutlineParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outlineParser")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFOutlineParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("outlineParser")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OutlineParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint PageCount {
			[Export ("pageCount", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("pageCount"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageCount"));
				}
			}
			
			[Export ("setPageCount:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPageCount:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPageCount:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint PageCountUnfiltered {
			[Export ("pageCountUnfiltered", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("pageCountUnfiltered"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageCountUnfiltered"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageRange_var;
		[CompilerGenerated]
		public virtual NSIndexSet PageRange {
			[Export ("pageRange", ArgumentSemantic.Retain)]
			get {
				NSIndexSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageRange")));
				} else {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageRange")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageRange_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Password {
			[Export ("password")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("password")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("password")));
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
		public virtual string XmpMetadata {
			[Export ("XMPMetadata")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("XMPMetadata")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("XMPMetadata")));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnnotationManager_var = null;
				__mt_ContentSignature_var = null;
				__mt_Data_var = null;
				__mt_Delegate_var = null;
				__mt_Document_var = null;
				__mt_EmbeddedFilesParser_var = null;
				__mt_FileUrl_var = null;
				__mt_FormParser_var = null;
				__mt_LabelParser_var = null;
				__mt_Metadata_var = null;
				__mt_OutlineParser_var = null;
				__mt_PageRange_var = null;
			}
		}
	} /* class PSPDFDocumentProvider */
}
