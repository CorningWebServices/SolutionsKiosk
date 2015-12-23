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
	[Register("PSPDFPKCS12Signer", true)]
	public unsafe partial class PSPDFPKCS12Signer : PSPDFSigner {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPKCS12Signer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFPKCS12Signer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPKCS12Signer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDisplayName:PKCS12:")]
		[CompilerGenerated]
		public PSPDFPKCS12Signer (string name, PSPDFPKCS12 p12)
			: base (NSObjectFlag.Empty)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (p12 == null)
				throw new ArgumentNullException ("p12");
			var nsname = NSString.CreateNative (name);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDisplayName:PKCS12:"), nsname, p12.Handle), "initWithDisplayName:PKCS12:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDisplayName:PKCS12:"), nsname, p12.Handle), "initWithDisplayName:PKCS12:");
			}
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("signFormElement:usingPassword:writeTo:completion:")]
		[CompilerGenerated]
		public unsafe virtual void SignFormElement (PSPDFSignatureFormElement element, string password, string path, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFPKCS12SignerSignHandler))]PSPDFPKCS12SignerSignHandler completion)
		{
			if (element == null)
				throw new ArgumentNullException ("element");
			if (password == null)
				throw new ArgumentNullException ("password");
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspassword = NSString.CreateNative (password);
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDPSPDFPKCS12SignerSignHandler.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("signFormElement:usingPassword:writeTo:completion:"), element.Handle, nspassword, nspath, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("signFormElement:usingPassword:writeTo:completion:"), element.Handle, nspassword, nspath, (IntPtr) block_ptr_completion);
			}
			NSString.ReleaseNative (nspassword);
			NSString.ReleaseNative (nspath);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public new virtual string DisplayName {
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
		object __mt_P12_var;
		[CompilerGenerated]
		public virtual PSPDFPKCS12 P12 {
			[Export ("p12", ArgumentSemantic.Retain)]
			get {
				PSPDFPKCS12 ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFPKCS12> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("p12")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFPKCS12> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("p12")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_P12_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PKey_var;
		[CompilerGenerated]
		public virtual PSPDFRSAKey PKey {
			[Export ("pkey", ArgumentSemantic.Retain)]
			get {
				PSPDFRSAKey ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFRSAKey> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pkey")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFRSAKey> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pkey")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PKey_var = ret;
				return ret;
			}
			
			[Export ("setPkey:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPkey:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPkey:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PKey_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_P12_var = null;
				__mt_PKey_var = null;
			}
		}
	} /* class PSPDFPKCS12Signer */
}
