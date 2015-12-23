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
	[Register("PSPDFXFDFWriter", true)]
	public unsafe partial class PSPDFXFDFWriter : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFXFDFWriter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFXFDFWriter () : base (NSObjectFlag.Empty)
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
		protected PSPDFXFDFWriter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFXFDFWriter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("writeAnnotations:toOutputStream:documentProvider:error:")]
		[CompilerGenerated]
		public virtual bool WriteAnnotations (PSPDFAnnotation[] annotations, NSOutputStream outputStream, PSPDFDocumentProvider documentProvider, out NSError error)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (outputStream == null)
				throw new ArgumentNullException ("outputStream");
			IntPtr errorValue = IntPtr.Zero;
			
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("writeAnnotations:toOutputStream:documentProvider:error:"), nsa_annotations.Handle, outputStream.Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("writeAnnotations:toOutputStream:documentProvider:error:"), nsa_annotations.Handle, outputStream.Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle, ref errorValue);
			}
			nsa_annotations.Dispose ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
	} /* class PSPDFXFDFWriter */
}
