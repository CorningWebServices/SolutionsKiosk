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
	[Register("PSPDFAESCryptoDataProvider", true)]
	public unsafe partial class PSPDFAESCryptoDataProvider : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAESCryptoDataProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAESCryptoDataProvider () : base (NSObjectFlag.Empty)
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
		protected PSPDFAESCryptoDataProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAESCryptoDataProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithURL:passphrase:salt:rounds:")]
		[CompilerGenerated]
		public PSPDFAESCryptoDataProvider (NSUrl url, string passphrase, string salt, global::System.nuint rounds)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (passphrase == null)
				throw new ArgumentNullException ("passphrase");
			if (salt == null)
				throw new ArgumentNullException ("salt");
			var nspassphrase = NSString.CreateNative (passphrase);
			var nssalt = NSString.CreateNative (salt);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint (this.Handle, Selector.GetHandle ("initWithURL:passphrase:salt:rounds:"), url.Handle, nspassphrase, nssalt, rounds), "initWithURL:passphrase:salt:rounds:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("initWithURL:passphrase:salt:rounds:"), url.Handle, nspassphrase, nssalt, rounds), "initWithURL:passphrase:salt:rounds:");
			}
			NSString.ReleaseNative (nspassphrase);
			NSString.ReleaseNative (nssalt);
			
		}
		
		[Export ("initWithURL:passphraseData:salt:rounds:")]
		[CompilerGenerated]
		public PSPDFAESCryptoDataProvider (NSUrl url, NSData passphraseData, NSData saltData, global::System.nuint rounds)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (passphraseData == null)
				throw new ArgumentNullException ("passphraseData");
			if (saltData == null)
				throw new ArgumentNullException ("saltData");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint (this.Handle, Selector.GetHandle ("initWithURL:passphraseData:salt:rounds:"), url.Handle, passphraseData.Handle, saltData.Handle, rounds), "initWithURL:passphraseData:salt:rounds:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("initWithURL:passphraseData:salt:rounds:"), url.Handle, passphraseData.Handle, saltData.Handle, rounds), "initWithURL:passphraseData:salt:rounds:");
			}
		}
		
		[Export ("initWithURL:passphrase:")]
		[CompilerGenerated]
		public PSPDFAESCryptoDataProvider (NSUrl url, string passphrase)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (passphrase == null)
				throw new ArgumentNullException ("passphrase");
			var nspassphrase = NSString.CreateNative (passphrase);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithURL:passphrase:"), url.Handle, nspassphrase), "initWithURL:passphrase:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURL:passphrase:"), url.Handle, nspassphrase), "initWithURL:passphrase:");
			}
			NSString.ReleaseNative (nspassphrase);
			
		}
		
		[Export ("initWithURL:binaryKey:")]
		[CompilerGenerated]
		public PSPDFAESCryptoDataProvider (NSUrl url, NSData key)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (key == null)
				throw new ArgumentNullException ("key");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithURL:binaryKey:"), url.Handle, key.Handle), "initWithURL:binaryKey:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURL:binaryKey:"), url.Handle, key.Handle), "initWithURL:binaryKey:");
			}
		}
		
		[Export ("isAESCryptoDataProvider:")]
		[CompilerGenerated]
		public static bool IsAESCryptoDataProvider (global::System.IntPtr dataProvider)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isAESCryptoDataProvider:"), dataProvider);
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
		
	} /* class PSPDFAESCryptoDataProvider */
}
