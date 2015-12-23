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
	[Register("PSPDFFormRequest", true)]
	public unsafe partial class PSPDFFormRequest : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFormRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFFormRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFormRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFormat:values:request:")]
		[CompilerGenerated]
		public PSPDFFormRequest (NSObject format, NSDictionary values, NSUrlRequest request)
			: base (NSObjectFlag.Empty)
		{
			if (format == null)
				throw new ArgumentNullException ("format");
			if (values == null)
				throw new ArgumentNullException ("values");
			if (request == null)
				throw new ArgumentNullException ("request");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithFormat:values:request:"), format.Handle, values.Handle, request.Handle), "initWithFormat:values:request:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFormat:values:request:"), format.Handle, values.Handle, request.Handle), "initWithFormat:values:request:");
			}
		}
		
		[CompilerGenerated]
		object __mt_FormValues_var;
		[CompilerGenerated]
		public virtual NSDictionary FormValues {
			[Export ("formValues")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("formValues")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formValues")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FormValues_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Request_var;
		[CompilerGenerated]
		public virtual NSUrlRequest Request {
			[Export ("request")]
			get {
				NSUrlRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlRequest> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("request")));
				} else {
					ret =  Runtime.GetNSObject<NSUrlRequest> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("request")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Request_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFSubmitFormActionFormat SubmissionFormat {
			[Export ("submissionFormat")]
			get {
				PSPDFSubmitFormActionFormat ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSubmitFormActionFormat) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("submissionFormat"));
					} else {
						ret = (PSPDFSubmitFormActionFormat) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("submissionFormat"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSubmitFormActionFormat) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("submissionFormat"));
					} else {
						ret = (PSPDFSubmitFormActionFormat) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("submissionFormat"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FormValues_var = null;
				__mt_Request_var = null;
			}
		}
	} /* class PSPDFFormRequest */
}
