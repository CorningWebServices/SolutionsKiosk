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
	[Register("PSPDFFormParser", true)]
	public unsafe partial class PSPDFFormParser : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFormParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFFormParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFormParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFFormParser (PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocumentProvider:"), documentProvider.Handle), "initWithDocumentProvider:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocumentProvider:"), documentProvider.Handle), "initWithDocumentProvider:");
			}
		}
		
		[Export ("findAnnotationWithFieldName:")]
		[CompilerGenerated]
		public virtual PSPDFFormElement FindAnnotation (string fieldName)
		{
			if (fieldName == null)
				throw new ArgumentNullException ("fieldName");
			var nsfieldName = NSString.CreateNative (fieldName);
			
			PSPDFFormElement ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFFormElement> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("findAnnotationWithFieldName:"), nsfieldName));
			} else {
				ret =  Runtime.GetNSObject<PSPDFFormElement> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("findAnnotationWithFieldName:"), nsfieldName));
			}
			NSString.ReleaseNative (nsfieldName);
			
			return ret;
		}
		
		[Export ("findAnnotationWithFullFieldName:descendingFromForm:")]
		[CompilerGenerated]
		public virtual PSPDFFormElement FindAnnotation (string fullFieldName, PSPDFFormElement parent)
		{
			if (fullFieldName == null)
				throw new ArgumentNullException ("fullFieldName");
			var nsfullFieldName = NSString.CreateNative (fullFieldName);
			
			PSPDFFormElement ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFFormElement> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("findAnnotationWithFullFieldName:descendingFromForm:"), nsfullFieldName, parent == null ? IntPtr.Zero : parent.Handle));
			} else {
				ret =  Runtime.GetNSObject<PSPDFFormElement> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("findAnnotationWithFullFieldName:descendingFromForm:"), nsfullFieldName, parent == null ? IntPtr.Zero : parent.Handle));
			}
			NSString.ReleaseNative (nsfullFieldName);
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_DirtyForms_var;
		[CompilerGenerated]
		public virtual PSPDFFormElement[] DirtyForms {
			[Export ("dirtyForms")]
			get {
				PSPDFFormElement[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFFormElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dirtyForms")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFFormElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dirtyForms")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DirtyForms_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DocumentProvider_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProvider {
			[Export ("documentProvider", ArgumentSemantic.Weak)]
			get {
				PSPDFDocumentProvider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentProvider")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentProvider")));
				}
				MarkDirty ();
				__mt_DocumentProvider_var = ret;
				return ret;
			}
			
			[Export ("setDocumentProvider:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDocumentProvider:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDocumentProvider:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_DocumentProvider_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Forms_var;
		[CompilerGenerated]
		public virtual PSPDFFormElement[] Forms {
			[Export ("forms", ArgumentSemantic.Copy)]
			get {
				PSPDFFormElement[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFFormElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("forms")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFFormElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("forms")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Forms_var = ret;
				return ret;
			}
			
			[Export ("setForms:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setForms:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setForms:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Forms_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DirtyForms_var = null;
				__mt_DocumentProvider_var = null;
				__mt_Forms_var = null;
			}
		}
	} /* class PSPDFFormParser */
}
