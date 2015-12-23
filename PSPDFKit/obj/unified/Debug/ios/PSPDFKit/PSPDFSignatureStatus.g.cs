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
	[Register("PSPDFSignatureStatus", true)]
	public unsafe partial class PSPDFSignatureStatus : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSignatureStatus");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFSignatureStatus (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSignatureStatus (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSigner:signingDate:wasModified:")]
		[CompilerGenerated]
		public PSPDFSignatureStatus (string signer, NSDate date, bool wasModified)
			: base (NSObjectFlag.Empty)
		{
			if (signer == null)
				throw new ArgumentNullException ("signer");
			if (date == null)
				throw new ArgumentNullException ("date");
			var nssigner = NSString.CreateNative (signer);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithSigner:signingDate:wasModified:"), nssigner, date.Handle, wasModified), "initWithSigner:signingDate:wasModified:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithSigner:signingDate:wasModified:"), nssigner, date.Handle, wasModified), "initWithSigner:signingDate:wasModified:");
			}
			NSString.ReleaseNative (nssigner);
			
		}
		
		[Export ("reportSignatureProblem:")]
		[CompilerGenerated]
		public virtual void ReportSignatureProblem (int error)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("reportSignatureProblem:"), error);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("reportSignatureProblem:"), error);
			}
		}
		
		[CompilerGenerated]
		public virtual string[] Problems {
			[Export ("problems")]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("problems")));
				} else {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("problems")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFSignatureStatusSeverity Severity {
			[Export ("severity", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFSignatureStatusSeverity ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSignatureStatusSeverity) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("severity"));
					} else {
						ret = (PSPDFSignatureStatusSeverity) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("severity"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSignatureStatusSeverity) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("severity"));
					} else {
						ret = (PSPDFSignatureStatusSeverity) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("severity"));
					}
				}
				return ret;
			}
			
			[Export ("setSeverity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setSeverity:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setSeverity:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setSeverity:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setSeverity:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Signer {
			[Export ("signer")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("signer")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signer")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SigningDate_var;
		[CompilerGenerated]
		public virtual NSDate SigningDate {
			[Export ("signingDate", ArgumentSemantic.Copy)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("signingDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signingDate")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SigningDate_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Summary {
			[Export ("summary")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("summary")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("summary")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool WasModified {
			[Export ("wasModified")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wasModified"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("wasModified"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SigningDate_var = null;
			}
		}
	} /* class PSPDFSignatureStatus */
}
