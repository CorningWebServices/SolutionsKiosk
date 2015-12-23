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
	[Register("PSPDFKeychainSignatureStore", true)]
	public unsafe partial class PSPDFKeychainSignatureStore : NSObject, IPSPDFSignatureStore {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFKeychainSignatureStore");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFKeychainSignatureStore () : base (NSObjectFlag.Empty)
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
		protected PSPDFKeychainSignatureStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFKeychainSignatureStore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addSignature:")]
		[CompilerGenerated]
		public virtual void AddSignature (PSPDFInkAnnotation signature)
		{
			if (signature == null)
				throw new ArgumentNullException ("signature");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addSignature:"), signature.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addSignature:"), signature.Handle);
			}
		}
		
		[Export ("signatures")]
		[CompilerGenerated]
		public virtual PSPDFInkAnnotation[] GetSignatures ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFInkAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("signatures")));
			} else {
				return NSArray.ArrayFromHandle<PSPDFInkAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signatures")));
			}
		}
		
		[Export ("storeName")]
		[CompilerGenerated]
		public virtual string GetStoreName ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("storeName")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("storeName")));
			}
		}
		
		[Export ("removeSignature:")]
		[CompilerGenerated]
		public virtual bool RemoveSignature (PSPDFInkAnnotation signature)
		{
			if (signature == null)
				throw new ArgumentNullException ("signature");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeSignature:"), signature.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeSignature:"), signature.Handle);
			}
		}
		
		[Export ("setSignatures:")]
		[CompilerGenerated]
		public virtual void SetSignatures (PSPDFInkAnnotation[] signatures)
		{
			var nsa_signatures = signatures == null ? null : NSArray.FromNSObjects (signatures);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSignatures:"), nsa_signatures == null ? IntPtr.Zero : nsa_signatures.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSignatures:"), nsa_signatures == null ? IntPtr.Zero : nsa_signatures.Handle);
			}
			if (nsa_signatures != null)
				nsa_signatures.Dispose ();
			
		}
		
		[CompilerGenerated]
		static NSString _DefaultStoreName;
		[Field ("PSPDFKeychainSignatureStoreDefaultStoreName",  "__Internal")]
		public static unsafe NSString DefaultStoreName {
			get {
				if (_DefaultStoreName == null)
					_DefaultStoreName = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFKeychainSignatureStoreDefaultStoreName");
				return _DefaultStoreName;
			}
		}
	} /* class PSPDFKeychainSignatureStore */
}
