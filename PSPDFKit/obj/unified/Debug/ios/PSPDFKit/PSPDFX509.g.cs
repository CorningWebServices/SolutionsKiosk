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
	[Register("PSPDFX509", true)]
	public unsafe partial class PSPDFX509 : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFX509");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		 PSPDFX509 () : base (NSObjectFlag.Empty)
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
		protected PSPDFX509 (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFX509 (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("certificatesFromPKCS7Data:error:")]
		[CompilerGenerated]
		public static PSPDFX509[] CertificatesFromPKCS7Data (NSData data, out NSError error)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IntPtr errorValue = IntPtr.Zero;
			
			PSPDFX509[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFX509>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("certificatesFromPKCS7Data:error:"), data.Handle, ref errorValue));
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("initWithX509:")]
		[CompilerGenerated]
		internal virtual global::System.IntPtr InitWithX509 (global::System.IntPtr x509)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithX509:"), x509);
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithX509:"), x509);
			}
		}
		
		[CompilerGenerated]
		static object __mt_AdobeCA_var_static;
		[CompilerGenerated]
		public static PSPDFX509 AdobeCA {
			[Export ("adobeCA")]
			get {
				PSPDFX509 ret;
				ret =  Runtime.GetNSObject<PSPDFX509> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("adobeCA")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_AdobeCA_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr Cert {
			[Export ("cert")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cert"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cert"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CommonName {
			[Export ("commonName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("commonName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("commonName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PublicKey_var;
		[CompilerGenerated]
		public virtual PSPDFRSAKey PublicKey {
			[Export ("publicKey")]
			get {
				PSPDFRSAKey ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFRSAKey> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("publicKey")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFRSAKey> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("publicKey")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PublicKey_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PublicKey_var = null;
			}
		}
	} /* class PSPDFX509 */
}
