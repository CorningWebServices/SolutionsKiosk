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
	[Register("PSPDFProcessor", true)]
	public unsafe partial class PSPDFProcessor : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFProcessor");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFProcessor (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFProcessor (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("generatePDFFromDocument:pageRanges:outputFileURL:options:progressBlock:error:")]
		[CompilerGenerated]
		public unsafe virtual bool GeneratePdf (PSPDFDocument document, NSIndexSet[] pageRange, NSUrl fileURL, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFProcessorProgressHandler))]PSPDFProcessorProgressHandler progressHandler, out NSError error)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pageRange == null)
				throw new ArgumentNullException ("pageRange");
			if (fileURL == null)
				throw new ArgumentNullException ("fileURL");
			IntPtr errorValue = IntPtr.Zero;
			
			var nsa_pageRange = NSArray.FromNSObjects (pageRange);
			BlockLiteral *block_ptr_progressHandler;
			BlockLiteral block_progressHandler;
			if (progressHandler == null){
				block_ptr_progressHandler = null;
			} else {
				block_progressHandler = new BlockLiteral ();
				block_ptr_progressHandler = &block_progressHandler;
				block_progressHandler.SetupBlock (Trampolines.SDPSPDFProcessorProgressHandler.Handler, progressHandler);
			}
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("generatePDFFromDocument:pageRanges:outputFileURL:options:progressBlock:error:"), document.Handle, nsa_pageRange.Handle, fileURL.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_progressHandler, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("generatePDFFromDocument:pageRanges:outputFileURL:options:progressBlock:error:"), document.Handle, nsa_pageRange.Handle, fileURL.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_progressHandler, ref errorValue);
			}
			nsa_pageRange.Dispose ();
			if (block_ptr_progressHandler != null)
				block_ptr_progressHandler->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("generatePDFFromDocument:pageRanges:options:progressBlock:error:")]
		[CompilerGenerated]
		public unsafe virtual NSData GeneratePdf (PSPDFDocument document, NSIndexSet[] pageRange, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFProcessorProgressHandler))]PSPDFProcessorProgressHandler progressHandler, out NSError error)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pageRange == null)
				throw new ArgumentNullException ("pageRange");
			IntPtr errorValue = IntPtr.Zero;
			
			var nsa_pageRange = NSArray.FromNSObjects (pageRange);
			BlockLiteral *block_ptr_progressHandler;
			BlockLiteral block_progressHandler;
			if (progressHandler == null){
				block_ptr_progressHandler = null;
			} else {
				block_progressHandler = new BlockLiteral ();
				block_ptr_progressHandler = &block_progressHandler;
				block_progressHandler.SetupBlock (Trampolines.SDPSPDFProcessorProgressHandler.Handler, progressHandler);
			}
			
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("generatePDFFromDocument:pageRanges:options:progressBlock:error:"), document.Handle, nsa_pageRange.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_progressHandler, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("generatePDFFromDocument:pageRanges:options:progressBlock:error:"), document.Handle, nsa_pageRange.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_progressHandler, ref errorValue));
			}
			nsa_pageRange.Dispose ();
			if (block_ptr_progressHandler != null)
				block_ptr_progressHandler->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("generatePDFFromHTMLString:outputFileURL:options:error:")]
		[CompilerGenerated]
		public virtual bool GeneratePdf (string html, NSUrl filerUrl, NSDictionary options, out NSError error)
		{
			if (html == null)
				throw new ArgumentNullException ("html");
			if (filerUrl == null)
				throw new ArgumentNullException ("filerUrl");
			IntPtr errorValue = IntPtr.Zero;
			
			var nshtml = NSString.CreateNative (html);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("generatePDFFromHTMLString:outputFileURL:options:error:"), nshtml, filerUrl.Handle, options == null ? IntPtr.Zero : options.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("generatePDFFromHTMLString:outputFileURL:options:error:"), nshtml, filerUrl.Handle, options == null ? IntPtr.Zero : options.Handle, ref errorValue);
			}
			NSString.ReleaseNative (nshtml);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("generatePDFFromHTMLString:options:error:")]
		[CompilerGenerated]
		public virtual NSData GeneratePdf (string html, NSDictionary options, out NSError error)
		{
			if (html == null)
				throw new ArgumentNullException ("html");
			IntPtr errorValue = IntPtr.Zero;
			
			var nshtml = NSString.CreateNative (html);
			
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("generatePDFFromHTMLString:options:error:"), nshtml, options == null ? IntPtr.Zero : options.Handle, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("generatePDFFromHTMLString:options:error:"), nshtml, options == null ? IntPtr.Zero : options.Handle, ref errorValue));
			}
			NSString.ReleaseNative (nshtml);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("generatePDFFromURL:outputFileURL:options:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual PSPDFConversionOperation GeneratePdf (NSUrl inputUrl, NSUrl outputUrl, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFProcessorPdfFromUrlHandler))]PSPDFProcessorPdfFromUrlHandler completionHandler)
		{
			if (inputUrl == null)
				throw new ArgumentNullException ("inputUrl");
			if (outputUrl == null)
				throw new ArgumentNullException ("outputUrl");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDPSPDFProcessorPdfFromUrlHandler.Handler, completionHandler);
			}
			
			PSPDFConversionOperation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFConversionOperation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("generatePDFFromURL:outputFileURL:options:completionBlock:"), inputUrl.Handle, outputUrl.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_completionHandler));
			} else {
				ret =  Runtime.GetNSObject<PSPDFConversionOperation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("generatePDFFromURL:outputFileURL:options:completionBlock:"), inputUrl.Handle, outputUrl.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_completionHandler));
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("generatePDFFromURL:options:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual PSPDFConversionOperation GeneratePdf (NSUrl inputUrl, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFProcessorPdfFromUrlNsdataHandler))]PSPDFProcessorPdfFromUrlNsdataHandler completionHandler)
		{
			if (inputUrl == null)
				throw new ArgumentNullException ("inputUrl");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDPSPDFProcessorPdfFromUrlNsdataHandler.Handler, completionHandler);
			}
			
			PSPDFConversionOperation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFConversionOperation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("generatePDFFromURL:options:completionBlock:"), inputUrl.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_completionHandler));
			} else {
				ret =  Runtime.GetNSObject<PSPDFConversionOperation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("generatePDFFromURL:options:completionBlock:"), inputUrl.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_completionHandler));
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		static object __mt_DefaultProcessor_var_static;
		[CompilerGenerated]
		public static PSPDFProcessor DefaultProcessor {
			[Export ("defaultProcessor")]
			get {
				PSPDFProcessor ret;
				ret =  Runtime.GetNSObject<PSPDFProcessor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultProcessor")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_DefaultProcessor_var_static = ret;
				return ret;
			}
			
		}
		
	} /* class PSPDFProcessor */
}
