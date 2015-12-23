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
	[Register("PSPDFSignatureManager", true)]
	public unsafe partial class PSPDFSignatureManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSignatureManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSignatureManager () : base (NSObjectFlag.Empty)
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
		protected PSPDFSignatureManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSignatureManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addTrustedCertificate:")]
		[CompilerGenerated]
		public virtual void AddTrustedCertificate (PSPDFX509 x509)
		{
			if (x509 == null)
				throw new ArgumentNullException ("x509");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addTrustedCertificate:"), x509.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addTrustedCertificate:"), x509.Handle);
			}
		}
		
		[Export ("registeredSigners")]
		[CompilerGenerated]
		public virtual PSPDFSigner[] RegisteredSigners ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFSigner>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("registeredSigners")));
			} else {
				return NSArray.ArrayFromHandle<PSPDFSigner>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("registeredSigners")));
			}
		}
		
		[Export ("registerSigner:")]
		[CompilerGenerated]
		public virtual void RegisterSigner (PSPDFSigner signer)
		{
			if (signer == null)
				throw new ArgumentNullException ("signer");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerSigner:"), signer.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerSigner:"), signer.Handle);
			}
		}
		
		[Export ("trustedCertificates")]
		[CompilerGenerated]
		public virtual PSPDFX509[] TrustedCertificates ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFX509>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("trustedCertificates")));
			} else {
				return NSArray.ArrayFromHandle<PSPDFX509>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("trustedCertificates")));
			}
		}
		
		[CompilerGenerated]
		static object __mt_SharedManager_var_static;
		[CompilerGenerated]
		public static PSPDFSignatureManager SharedManager {
			[Export ("sharedManager")]
			get {
				PSPDFSignatureManager ret;
				ret =  Runtime.GetNSObject<PSPDFSignatureManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedManager")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_SharedManager_var_static = ret;
				return ret;
			}
			
		}
		
	} /* class PSPDFSignatureManager */
}
