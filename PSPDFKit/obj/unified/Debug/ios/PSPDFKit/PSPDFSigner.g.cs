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
	[Register("PSPDFSigner", true)]
	public unsafe partial class PSPDFSigner : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSigner");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSigner () : base (NSObjectFlag.Empty)
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
		protected PSPDFSigner (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSigner (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("requestSigningCertificate:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void RequestSigningCertificate (global::UIKit.UINavigationController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V6))]global::System.Action<PSPDFX509, NSError> completionHandler)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity2V6.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("requestSigningCertificate:completionBlock:"), controller.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("requestSigningCertificate:completionBlock:"), controller.Handle, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("signFormElement:withCertificate:writeTo:completion:")]
		[CompilerGenerated]
		public unsafe virtual void SignFormElement (PSPDFSignatureFormElement element, PSPDFX509 x509, string path, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<bool, PSPDFDocument, NSError> done)
		{
			if (element == null)
				throw new ArgumentNullException ("element");
			if (x509 == null)
				throw new ArgumentNullException ("x509");
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_done;
			BlockLiteral block_done;
			if (done == null){
				block_ptr_done = null;
			} else {
				block_done = new BlockLiteral ();
				block_ptr_done = &block_done;
				block_done.SetupBlock (Trampolines.SDActionArity3V1.Handler, done);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("signFormElement:withCertificate:writeTo:completion:"), element.Handle, x509.Handle, nspath, (IntPtr) block_ptr_done);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("signFormElement:withCertificate:writeTo:completion:"), element.Handle, x509.Handle, nspath, (IntPtr) block_ptr_done);
			}
			NSString.ReleaseNative (nspath);
			if (block_ptr_done != null)
				block_ptr_done->CleanupBlock ();
			
		}
		
		[Export ("signHash:algorithm:error:")]
		[CompilerGenerated]
		internal virtual NSData SignHash (NSData hash, PSPDFSigningAlgorithm algorithm, global::System.IntPtr error)
		{
			if (hash == null)
				throw new ArgumentNullException ("hash");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr (this.Handle, Selector.GetHandle ("signHash:algorithm:error:"), hash.Handle, (Int64)algorithm, error));
				} else {
					return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr (this.Handle, Selector.GetHandle ("signHash:algorithm:error:"), hash.Handle, (int)algorithm, error));
				}
			} else {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr (this.SuperHandle, Selector.GetHandle ("signHash:algorithm:error:"), hash.Handle, (Int64)algorithm, error));
				} else {
					return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, Selector.GetHandle ("signHash:algorithm:error:"), hash.Handle, (int)algorithm, error));
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string DisplayName {
			[Export ("displayName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("displayName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Filter {
			[Export ("filter")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("filter")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("filter")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFSigningAlgorithm SigningAlgorithm {
			[Export ("signingAlgorithm")]
			get {
				PSPDFSigningAlgorithm ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSigningAlgorithm) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("signingAlgorithm"));
					} else {
						ret = (PSPDFSigningAlgorithm) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("signingAlgorithm"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSigningAlgorithm) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signingAlgorithm"));
					} else {
						ret = (PSPDFSigningAlgorithm) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signingAlgorithm"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SubFilter {
			[Export ("subFilter")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subFilter")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subFilter")));
				}
			}
			
		}
		
	} /* class PSPDFSigner */
}
