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
	[Register("PSPDFXFDFParser", true)]
	public unsafe partial class PSPDFXFDFParser : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFXFDFParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFXFDFParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFXFDFParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithInputStream:documentProvider:")]
		[CompilerGenerated]
		public PSPDFXFDFParser (NSInputStream inputStream, PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			if (inputStream == null)
				throw new ArgumentNullException ("inputStream");
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithInputStream:documentProvider:"), inputStream.Handle, documentProvider.Handle), "initWithInputStream:documentProvider:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithInputStream:documentProvider:"), inputStream.Handle, documentProvider.Handle), "initWithInputStream:documentProvider:");
			}
		}
		
		[Export ("parseWithError:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] Parse (out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			PSPDFAnnotation[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_ref_IntPtr (this.Handle, Selector.GetHandle ("parseWithError:"), ref errorValue));
			} else {
				ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("parseWithError:"), ref errorValue));
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_Annotations_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] Annotations {
			[Export ("annotations", ArgumentSemantic.Copy)]
			get {
				PSPDFAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotations")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Annotations_var = ret;
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
			
		}
		
		[CompilerGenerated]
		object __mt_InputStream_var;
		[CompilerGenerated]
		public virtual NSInputStream InputStream {
			[Export ("inputStream", ArgumentSemantic.Retain)]
			get {
				NSInputStream ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSInputStream> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputStream")));
				} else {
					ret =  Runtime.GetNSObject<NSInputStream> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputStream")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_InputStream_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Parsing {
			[Export ("isParsing", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isParsing"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isParsing"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ParsingEnded {
			[Export ("parsingEnded", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("parsingEnded"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parsingEnded"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotations_var = null;
				__mt_DocumentProvider_var = null;
				__mt_InputStream_var = null;
			}
		}
	} /* class PSPDFXFDFParser */
}
