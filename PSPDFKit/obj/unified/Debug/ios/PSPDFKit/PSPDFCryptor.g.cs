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
	[Register("PSPDFCryptor", true)]
	public unsafe partial class PSPDFCryptor : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFCryptor");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFCryptor () : base (NSObjectFlag.Empty)
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
		protected PSPDFCryptor (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFCryptor (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("decryptFromURL:toURL:key:error:")]
		[CompilerGenerated]
		public virtual bool Decrypt (NSUrl sourceUrl, NSUrl targetUrl, NSData key, out NSError error)
		{
			if (sourceUrl == null)
				throw new ArgumentNullException ("sourceUrl");
			if (targetUrl == null)
				throw new ArgumentNullException ("targetUrl");
			if (key == null)
				throw new ArgumentNullException ("key");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("decryptFromURL:toURL:key:error:"), sourceUrl.Handle, targetUrl.Handle, key.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("decryptFromURL:toURL:key:error:"), sourceUrl.Handle, targetUrl.Handle, key.Handle, ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("decryptFromURL:toURL:passphrase:error:")]
		[CompilerGenerated]
		public virtual bool Decrypt (NSUrl sourceUrl, NSUrl targetUrl, string passphrase, out NSError error)
		{
			if (sourceUrl == null)
				throw new ArgumentNullException ("sourceUrl");
			if (targetUrl == null)
				throw new ArgumentNullException ("targetUrl");
			if (passphrase == null)
				throw new ArgumentNullException ("passphrase");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspassphrase = NSString.CreateNative (passphrase);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("decryptFromURL:toURL:passphrase:error:"), sourceUrl.Handle, targetUrl.Handle, nspassphrase, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("decryptFromURL:toURL:passphrase:error:"), sourceUrl.Handle, targetUrl.Handle, nspassphrase, ref errorValue);
			}
			NSString.ReleaseNative (nspassphrase);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("encryptFromURL:toURL:key:error:")]
		[CompilerGenerated]
		public virtual bool Encrypt (NSUrl sourceUrl, NSUrl targetUrl, NSData key, out NSError error)
		{
			if (sourceUrl == null)
				throw new ArgumentNullException ("sourceUrl");
			if (targetUrl == null)
				throw new ArgumentNullException ("targetUrl");
			if (key == null)
				throw new ArgumentNullException ("key");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("encryptFromURL:toURL:key:error:"), sourceUrl.Handle, targetUrl.Handle, key.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("encryptFromURL:toURL:key:error:"), sourceUrl.Handle, targetUrl.Handle, key.Handle, ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("encryptFromURL:toURL:passphrase:error:")]
		[CompilerGenerated]
		public virtual bool Encrypt (NSUrl sourceUrl, NSUrl targetUrl, string passphrase, out NSError error)
		{
			if (sourceUrl == null)
				throw new ArgumentNullException ("sourceUrl");
			if (targetUrl == null)
				throw new ArgumentNullException ("targetUrl");
			if (passphrase == null)
				throw new ArgumentNullException ("passphrase");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspassphrase = NSString.CreateNative (passphrase);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("encryptFromURL:toURL:passphrase:error:"), sourceUrl.Handle, targetUrl.Handle, nspassphrase, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("encryptFromURL:toURL:passphrase:error:"), sourceUrl.Handle, targetUrl.Handle, nspassphrase, ref errorValue);
			}
			NSString.ReleaseNative (nspassphrase);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("keyFromPassphrase:salt:")]
		[CompilerGenerated]
		public virtual NSData GetKey (string passphrase, string salt)
		{
			if (passphrase == null)
				throw new ArgumentNullException ("passphrase");
			if (salt == null)
				throw new ArgumentNullException ("salt");
			var nspassphrase = NSString.CreateNative (passphrase);
			var nssalt = NSString.CreateNative (salt);
			
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("keyFromPassphrase:salt:"), nspassphrase, nssalt));
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("keyFromPassphrase:salt:"), nspassphrase, nssalt));
			}
			NSString.ReleaseNative (nspassphrase);
			NSString.ReleaseNative (nssalt);
			
			return ret;
		}
		
		[Export ("legacyKeyFromPassphrase:salt:")]
		[CompilerGenerated]
		public virtual NSData GetLegacyKey (string passphrase, string salt)
		{
			if (passphrase == null)
				throw new ArgumentNullException ("passphrase");
			if (salt == null)
				throw new ArgumentNullException ("salt");
			var nspassphrase = NSString.CreateNative (passphrase);
			var nssalt = NSString.CreateNative (salt);
			
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("legacyKeyFromPassphrase:salt:"), nspassphrase, nssalt));
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("legacyKeyFromPassphrase:salt:"), nspassphrase, nssalt));
			}
			NSString.ReleaseNative (nspassphrase);
			NSString.ReleaseNative (nssalt);
			
			return ret;
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FileManager_var = null;
			}
		}
	} /* class PSPDFCryptor */
}
