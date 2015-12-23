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
	[Register("PSPDFLibrary", true)]
	public unsafe partial class PSPDFLibrary : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLibrary");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFLibrary (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFLibrary (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancelAllPreviewTextOperations")]
		[CompilerGenerated]
		public virtual void CancelAllPreviewTextOperations ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelAllPreviewTextOperations"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelAllPreviewTextOperations"));
			}
		}
		
		[Export ("clearAllIndexes")]
		[CompilerGenerated]
		public virtual void ClearAllIndexes ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearAllIndexes"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearAllIndexes"));
			}
		}
		
		[Export ("documentUIDsMatchingString:options:completionHandler:")]
		[CompilerGenerated]
		public unsafe virtual void DocumentUidsMatchingString (string searchString, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<string, NSDictionary> completionHandler)
		{
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			var nssearchString = NSString.CreateNative (searchString);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity2V4.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("documentUIDsMatchingString:options:completionHandler:"), nssearchString, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("documentUIDsMatchingString:options:completionHandler:"), nssearchString, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_completionHandler);
			}
			NSString.ReleaseNative (nssearchString);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("documentUIDsMatchingString:options:completionHandler:previewTextHandler:")]
		[CompilerGenerated]
		public unsafe virtual void DocumentUidsMatchingString (string searchString, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<string, NSDictionary> completionHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V5))]global::System.Action<NSString, NSDictionary> previewTextHandler)
		{
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			var nssearchString = NSString.CreateNative (searchString);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity2V4.Handler, completionHandler);
			}
			BlockLiteral *block_ptr_previewTextHandler;
			BlockLiteral block_previewTextHandler;
			if (previewTextHandler == null){
				block_ptr_previewTextHandler = null;
			} else {
				block_previewTextHandler = new BlockLiteral ();
				block_ptr_previewTextHandler = &block_previewTextHandler;
				block_previewTextHandler.SetupBlock (Trampolines.SDActionArity2V5.Handler, previewTextHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("documentUIDsMatchingString:options:completionHandler:previewTextHandler:"), nssearchString, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_completionHandler, (IntPtr) block_ptr_previewTextHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("documentUIDsMatchingString:options:completionHandler:previewTextHandler:"), nssearchString, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_completionHandler, (IntPtr) block_ptr_previewTextHandler);
			}
			NSString.ReleaseNative (nssearchString);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			if (block_ptr_previewTextHandler != null)
				block_ptr_previewTextHandler->CleanupBlock ();
			
		}
		
		[Export ("enqueueDocuments:")]
		[CompilerGenerated]
		public virtual void EnqueueDocuments (PSPDFDocument[] documents)
		{
			if (documents == null)
				throw new ArgumentNullException ("documents");
			var nsa_documents = NSArray.FromNSObjects (documents);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("enqueueDocuments:"), nsa_documents.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("enqueueDocuments:"), nsa_documents.Handle);
			}
			nsa_documents.Dispose ();
			
		}
		
		[Export ("libraryWithPath:")]
		[CompilerGenerated]
		public static PSPDFLibrary FromPath (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			PSPDFLibrary ret;
			ret =  Runtime.GetNSObject<PSPDFLibrary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("libraryWithPath:"), nspath));
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("encryptedLibraryWithPath:encryptionKeyProvider:")]
		[CompilerGenerated]
		public unsafe static PSPDFLibrary GetEncryptedLibrary (string path, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V0))]global::System.Func<NSData> encryptionKeyProvider)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_encryptionKeyProvider;
			BlockLiteral block_encryptionKeyProvider;
			if (encryptionKeyProvider == null){
				block_ptr_encryptionKeyProvider = null;
			} else {
				block_encryptionKeyProvider = new BlockLiteral ();
				block_ptr_encryptionKeyProvider = &block_encryptionKeyProvider;
				block_encryptionKeyProvider.SetupBlock (Trampolines.SDFuncArity1V0.Handler, encryptionKeyProvider);
			}
			
			PSPDFLibrary ret;
			ret =  Runtime.GetNSObject<PSPDFLibrary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("encryptedLibraryWithPath:encryptionKeyProvider:"), nspath, (IntPtr) block_ptr_encryptionKeyProvider));
			NSString.ReleaseNative (nspath);
			if (block_ptr_encryptionKeyProvider != null)
				block_ptr_encryptionKeyProvider->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("indexStatusForUID:withProgress:")]
		[CompilerGenerated]
		public virtual PSPDFLibraryIndexStatus IndexStatus (string uid, out global::System.nfloat outProgress)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			var nsuid = NSString.CreateNative (uid);
			
			PSPDFLibraryIndexStatus ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (PSPDFLibraryIndexStatus) global::ApiDefinition.Messaging.UInt64_objc_msgSend_IntPtr_out_nfloat (this.Handle, Selector.GetHandle ("indexStatusForUID:withProgress:"), nsuid, out outProgress);
				} else {
					ret = (PSPDFLibraryIndexStatus) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr_out_nfloat (this.Handle, Selector.GetHandle ("indexStatusForUID:withProgress:"), nsuid, out outProgress);
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (PSPDFLibraryIndexStatus) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper_IntPtr_out_nfloat (this.SuperHandle, Selector.GetHandle ("indexStatusForUID:withProgress:"), nsuid, out outProgress);
				} else {
					ret = (PSPDFLibraryIndexStatus) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr_out_nfloat (this.SuperHandle, Selector.GetHandle ("indexStatusForUID:withProgress:"), nsuid, out outProgress);
				}
			}
			NSString.ReleaseNative (nsuid);
			
			return ret;
		}
		
		[Export ("isIndexing")]
		[CompilerGenerated]
		public virtual bool IsIndexing ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isIndexing"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isIndexing"));
			}
		}
		
		[Export ("metadataForUID:")]
		[CompilerGenerated]
		public virtual NSDictionary MetadataFor (string UID)
		{
			if (UID == null)
				throw new ArgumentNullException ("UID");
			var nsUID = NSString.CreateNative (UID);
			
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("metadataForUID:"), nsUID));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("metadataForUID:"), nsUID));
			}
			NSString.ReleaseNative (nsUID);
			
			return ret;
		}
		
		[Export ("queuedUIDs")]
		[CompilerGenerated]
		public virtual NSOrderedSet QueuedUids ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("queuedUIDs")));
			} else {
				return  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("queuedUIDs")));
			}
		}
		
		[Export ("removeIndexForUID:")]
		[CompilerGenerated]
		public virtual void RemoveIndex (string uid)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			var nsuid = NSString.CreateNative (uid);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeIndexForUID:"), nsuid);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeIndexForUID:"), nsuid);
			}
			NSString.ReleaseNative (nsuid);
			
		}
		
		[CompilerGenerated]
		public virtual bool Encrypted {
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
		public virtual string Path {
			[Export ("path")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("path")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("path")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool SaveGlyphPositions {
			[Export ("saveGlyphPositions", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("saveGlyphPositions"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("saveGlyphPositions"));
				}
			}
			
			[Export ("setSaveGlyphPositions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSaveGlyphPositions:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSaveGlyphPositions:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SaveReversedPageText {
			[Export ("saveReversedPageText", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("saveReversedPageText"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("saveReversedPageText"));
				}
			}
			
			[Export ("setSaveReversedPageText:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSaveReversedPageText:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSaveReversedPageText:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Tokenizer {
			[Export ("tokenizer")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tokenizer")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tokenizer")));
				}
			}
			
			[Export ("setTokenizer:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTokenizer:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTokenizer:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		static NSString _DidFailIndexingDocumentNotification;
		[Field ("PSPDFLibraryDidFailIndexingDocumentNotification",  "__Internal")]
		public static unsafe NSString DidFailIndexingDocumentNotification {
			get {
				if (_DidFailIndexingDocumentNotification == null)
					_DidFailIndexingDocumentNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFLibraryDidFailIndexingDocumentNotification");
				return _DidFailIndexingDocumentNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidFinishIndexingDocumentNotification;
		[Field ("PSPDFLibraryDidFinishIndexingDocumentNotification",  "__Internal")]
		public static unsafe NSString DidFinishIndexingDocumentNotification {
			get {
				if (_DidFinishIndexingDocumentNotification == null)
					_DidFinishIndexingDocumentNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFLibraryDidFinishIndexingDocumentNotification");
				return _DidFinishIndexingDocumentNotification;
			}
		}
		[CompilerGenerated]
		static NSString _MatchExactWordsOnlyKey;
		[Field ("PSPDFLibraryMatchExactWordsOnlyKey",  "__Internal")]
		public static unsafe NSString MatchExactWordsOnlyKey {
			get {
				if (_MatchExactWordsOnlyKey == null)
					_MatchExactWordsOnlyKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFLibraryMatchExactWordsOnlyKey");
				return _MatchExactWordsOnlyKey;
			}
		}
		[CompilerGenerated]
		static NSString _MaximumSearchResultsPerDocumentKey;
		[Field ("PSPDFLibraryMaximumSearchResultsPerDocumentKey",  "__Internal")]
		public static unsafe NSString MaximumSearchResultsPerDocumentKey {
			get {
				if (_MaximumSearchResultsPerDocumentKey == null)
					_MaximumSearchResultsPerDocumentKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFLibraryMaximumSearchResultsPerDocumentKey");
				return _MaximumSearchResultsPerDocumentKey;
			}
		}
		[CompilerGenerated]
		static NSString _MaximumSearchResultsTotalKey;
		[Field ("PSPDFLibraryMaximumSearchResultsTotalKey",  "__Internal")]
		public static unsafe NSString MaximumSearchResultsTotalKey {
			get {
				if (_MaximumSearchResultsTotalKey == null)
					_MaximumSearchResultsTotalKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFLibraryMaximumSearchResultsTotalKey");
				return _MaximumSearchResultsTotalKey;
			}
		}
		[CompilerGenerated]
		static NSString _PreviewRangeKey;
		[Field ("PSPDFLibraryPreviewRangeKey",  "__Internal")]
		public static unsafe NSString PreviewRangeKey {
			get {
				if (_PreviewRangeKey == null)
					_PreviewRangeKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFLibraryPreviewRangeKey");
				return _PreviewRangeKey;
			}
		}
		[CompilerGenerated]
		static NSString _WillStartIndexingDocumentNotification;
		[Field ("PSPDFLibraryWillStartIndexingDocumentNotification",  "__Internal")]
		public static unsafe NSString WillStartIndexingDocumentNotification {
			get {
				if (_WillStartIndexingDocumentNotification == null)
					_WillStartIndexingDocumentNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFLibraryWillStartIndexingDocumentNotification");
				return _WillStartIndexingDocumentNotification;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDidFailIndexingDocument (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFailIndexingDocumentNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidFinishIndexingDocument (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFinishIndexingDocumentNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveWillStartIndexingDocument (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillStartIndexingDocumentNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFLibrary */
}
