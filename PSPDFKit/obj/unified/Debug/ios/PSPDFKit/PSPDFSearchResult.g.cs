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
	[Register("PSPDFSearchResult", true)]
	public unsafe partial class PSPDFSearchResult : PSPDFModel {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchResult");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFSearchResult (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFSearchResult (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSearchResult (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentUID:page:range:previewText:rangeInPreviewText:selection:annotation:")]
		[CompilerGenerated]
		public PSPDFSearchResult (string documentUid, global::System.nuint page, NSRange range, string previewText, NSRange rangeInPreviewText, PSPDFTextBlock selection, PSPDFAnnotation annotation)
			: base (NSObjectFlag.Empty)
		{
			if (documentUid == null)
				throw new ArgumentNullException ("documentUid");
			var nsdocumentUid = NSString.CreateNative (documentUid);
			var nspreviewText = NSString.CreateNative (previewText);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_NSRange_IntPtr_NSRange_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDocumentUID:page:range:previewText:rangeInPreviewText:selection:annotation:"), nsdocumentUid, page, range, nspreviewText, rangeInPreviewText, selection == null ? IntPtr.Zero : selection.Handle, annotation == null ? IntPtr.Zero : annotation.Handle), "initWithDocumentUID:page:range:previewText:rangeInPreviewText:selection:annotation:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_NSRange_IntPtr_NSRange_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocumentUID:page:range:previewText:rangeInPreviewText:selection:annotation:"), nsdocumentUid, page, range, nspreviewText, rangeInPreviewText, selection == null ? IntPtr.Zero : selection.Handle, annotation == null ? IntPtr.Zero : annotation.Handle), "initWithDocumentUID:page:range:previewText:rangeInPreviewText:selection:annotation:");
			}
			NSString.ReleaseNative (nsdocumentUid);
			NSString.ReleaseNative (nspreviewText);
			
		}
		
		[Export ("initWithDocument:page:range:previewText:rangeInPreviewText:selection:annotation:")]
		[CompilerGenerated]
		public PSPDFSearchResult (PSPDFDocument document, global::System.nuint page, NSRange range, string previewText, NSRange rangeInPreviewText, PSPDFTextBlock selection, PSPDFAnnotation annotation)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			var nspreviewText = NSString.CreateNative (previewText);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_NSRange_IntPtr_NSRange_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDocument:page:range:previewText:rangeInPreviewText:selection:annotation:"), document.Handle, page, range, nspreviewText, rangeInPreviewText, selection == null ? IntPtr.Zero : selection.Handle, annotation == null ? IntPtr.Zero : annotation.Handle), "initWithDocument:page:range:previewText:rangeInPreviewText:selection:annotation:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_NSRange_IntPtr_NSRange_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocument:page:range:previewText:rangeInPreviewText:selection:annotation:"), document.Handle, page, range, nspreviewText, rangeInPreviewText, selection == null ? IntPtr.Zero : selection.Handle, annotation == null ? IntPtr.Zero : annotation.Handle), "initWithDocument:page:range:previewText:rangeInPreviewText:selection:annotation:");
			}
			NSString.ReleaseNative (nspreviewText);
			
		}
		
		[CompilerGenerated]
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation Annotation {
			[Export ("annotation", ArgumentSemantic.Weak)]
			get {
				PSPDFAnnotation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotation")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotation")));
				}
				MarkDirty ();
				__mt_Annotation_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document", ArgumentSemantic.Weak)]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("document")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("document")));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DocumentUid {
			[Export ("documentUID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentUID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentUID")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint PageIndex {
			[Export ("pageIndex", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("pageIndex"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageIndex"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PreviewText {
			[Export ("previewText")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("previewText")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("previewText")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSRange Range {
			[Export ("range", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("range"));
						} else {
							global::ApiDefinition.Messaging.NSRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("range"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("range"));
					} else {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("range"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("range"));
						} else {
							global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("range"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("range"));
					} else {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("range"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSRange RangeInPreviewText {
			[Export ("rangeInPreviewText", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("rangeInPreviewText"));
						} else {
							global::ApiDefinition.Messaging.NSRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("rangeInPreviewText"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("rangeInPreviewText"));
					} else {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("rangeInPreviewText"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rangeInPreviewText"));
						} else {
							global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("rangeInPreviewText"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rangeInPreviewText"));
					} else {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rangeInPreviewText"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Selection_var;
		[CompilerGenerated]
		public virtual PSPDFTextBlock Selection {
			[Export ("selection", ArgumentSemantic.Retain)]
			get {
				PSPDFTextBlock ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFTextBlock> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selection")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFTextBlock> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selection")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Selection_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
				__mt_Document_var = null;
				__mt_Selection_var = null;
			}
		}
	} /* class PSPDFSearchResult */
}
