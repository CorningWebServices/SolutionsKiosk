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
	[Register("PSPDFXFDFAnnotationProvider", true)]
	public unsafe partial class PSPDFXFDFAnnotationProvider : PSPDFContainerAnnotationProvider {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFXFDFAnnotationProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFXFDFAnnotationProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFXFDFAnnotationProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFXFDFAnnotationProvider (PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocumentProvider:"), documentProvider.Handle), "initWithDocumentProvider:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocumentProvider:"), documentProvider.Handle), "initWithDocumentProvider:");
			}
		}
		
		[Export ("initWithDocumentProvider:fileURL:")]
		[CompilerGenerated]
		public PSPDFXFDFAnnotationProvider (PSPDFDocumentProvider documentProvider, NSUrl XfdfFileUrl)
			: base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (XfdfFileUrl == null)
				throw new ArgumentNullException ("XfdfFileUrl");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDocumentProvider:fileURL:"), documentProvider.Handle, XfdfFileUrl.Handle), "initWithDocumentProvider:fileURL:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocumentProvider:fileURL:"), documentProvider.Handle, XfdfFileUrl.Handle), "initWithDocumentProvider:fileURL:");
			}
		}
		
		[Export ("loadAllAnnotations")]
		[CompilerGenerated]
		public virtual void LoadAllAnnotations ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("loadAllAnnotations"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadAllAnnotations"));
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual PSPDFXFDFAnnotationProviderStreamHandler CreateInputStreamHandler {
			[Export ("createInputStreamBlock", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("createInputStreamBlock"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("createInputStreamBlock"));
				}
				return global::ObjCRuntime.Trampolines.NIDPSPDFXFDFAnnotationProviderStreamHandler.Create (ret);
			}
			
			[Export ("setCreateInputStreamBlock:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDPSPDFXFDFAnnotationProviderStreamHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCreateInputStreamBlock:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCreateInputStreamBlock:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual PSPDFXFDFAnnotationProviderStreamHandler CreateOutputStreamHandler {
			[Export ("createOutputStreamBlock", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("createOutputStreamBlock"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("createOutputStreamBlock"));
				}
				return global::ObjCRuntime.Trampolines.NIDPSPDFXFDFAnnotationProviderStreamHandler.Create (ret);
			}
			
			[Export ("setCreateOutputStreamBlock:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDPSPDFXFDFAnnotationProviderStreamHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCreateOutputStreamBlock:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCreateOutputStreamBlock:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_FileUrl_var;
		[CompilerGenerated]
		public virtual NSUrl FileUrl {
			[Export ("fileURL", ArgumentSemantic.Copy)]
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
		object __mt_InputStream_var;
		[CompilerGenerated]
		public virtual NSInputStream InputStream {
			[Export ("inputStream", ArgumentSemantic.Retain)]
			get {
				NSInputStream ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSInputStream> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputStream")));
				} else {
					ret =  Runtime.GetNSObject<NSInputStream> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputStream")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_InputStream_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OutputStream_var;
		[CompilerGenerated]
		public virtual NSOutputStream OutputStream {
			[Export ("outputStream", ArgumentSemantic.Retain)]
			get {
				NSOutputStream ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOutputStream> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputStream")));
				} else {
					ret =  Runtime.GetNSObject<NSOutputStream> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("outputStream")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OutputStream_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FileUrl_var = null;
				__mt_InputStream_var = null;
				__mt_OutputStream_var = null;
			}
		}
	} /* class PSPDFXFDFAnnotationProvider */
}
