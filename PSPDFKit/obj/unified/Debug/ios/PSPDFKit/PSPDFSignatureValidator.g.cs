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
	[Register("PSPDFSignatureValidator", true)]
	public unsafe partial class PSPDFSignatureValidator : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSignatureValidator");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFSignatureValidator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSignatureValidator (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSignatureFormElement:")]
		[CompilerGenerated]
		public PSPDFSignatureValidator (PSPDFSignatureFormElement formElement)
			: base (NSObjectFlag.Empty)
		{
			if (formElement == null)
				throw new ArgumentNullException ("formElement");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithSignatureFormElement:"), formElement.Handle), "initWithSignatureFormElement:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithSignatureFormElement:"), formElement.Handle), "initWithSignatureFormElement:");
			}
		}
		
		[Export ("verifySignatureWithError:")]
		[CompilerGenerated]
		public virtual NSObject VerifySignature (out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_ref_IntPtr (this.Handle, Selector.GetHandle ("verifySignatureWithError:"), ref errorValue));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("verifySignatureWithError:"), ref errorValue));
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_SignatureFormElement_var;
		[CompilerGenerated]
		public virtual PSPDFSignatureFormElement SignatureFormElement {
			[Export ("signatureFormElement")]
			get {
				PSPDFSignatureFormElement ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSignatureFormElement> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("signatureFormElement")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSignatureFormElement> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signatureFormElement")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SignatureFormElement_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SignatureFormElement_var = null;
			}
		}
	} /* class PSPDFSignatureValidator */
}
