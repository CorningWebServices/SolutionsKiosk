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
	[Register("PSPDFEmbeddedFile", true)]
	public unsafe partial class PSPDFEmbeddedFile : PSPDFModel, IPSPDFStreamProvider {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFEmbeddedFile");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFEmbeddedFile (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFEmbeddedFile (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFEmbeddedFile (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFileName:size:description:modificationDate:")]
		[CompilerGenerated]
		public PSPDFEmbeddedFile (string fileName, global::System.nuint fileSize, string description, NSDate modificationDate)
			: base (NSObjectFlag.Empty)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsfileName = NSString.CreateNative (fileName);
			var nsdescription = NSString.CreateNative (description);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithFileName:size:description:modificationDate:"), nsfileName, fileSize, nsdescription, modificationDate == null ? IntPtr.Zero : modificationDate.Handle), "initWithFileName:size:description:modificationDate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFileName:size:description:modificationDate:"), nsfileName, fileSize, nsdescription, modificationDate == null ? IntPtr.Zero : modificationDate.Handle), "initWithFileName:size:description:modificationDate:");
			}
			NSString.ReleaseNative (nsfileName);
			NSString.ReleaseNative (nsdescription);
			
		}
		
		[Export ("fileURLWithError:")]
		[CompilerGenerated]
		public virtual NSUrl FileUrlWithError (out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			NSUrl ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_ref_IntPtr (this.Handle, Selector.GetHandle ("fileURLWithError:"), ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("fileURLWithError:"), ref errorValue));
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("documentProvider")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider GetDocumentProvider ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentProvider")));
			} else {
				return  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentProvider")));
			}
		}
		
		[Export ("streamPath")]
		[CompilerGenerated]
		public virtual string StreamPath ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("streamPath")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("streamPath")));
			}
		}
		
		[CompilerGenerated]
		public virtual string FileDescription {
			[Export ("fileDescription")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileDescription")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileDescription")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string FileName {
			[Export ("fileName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint FileSize {
			[Export ("fileSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("fileSize"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileSize"));
				}
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
			
			[Export ("setFileURL:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFileURL:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFileURL:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileUrl_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ModificationDate_var;
		[CompilerGenerated]
		public virtual NSDate ModificationDate {
			[Export ("modificationDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("modificationDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("modificationDate")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ModificationDate_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FileUrl_var = null;
				__mt_ModificationDate_var = null;
			}
		}
	} /* class PSPDFEmbeddedFile */
}
