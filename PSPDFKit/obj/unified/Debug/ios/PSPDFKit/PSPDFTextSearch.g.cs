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
	[Register("PSPDFTextSearch", true)]
	public unsafe partial class PSPDFTextSearch : NSObject, INSCopying {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextSearch");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFTextSearch (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTextSearch (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFTextSearch (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocument:"), document.Handle), "initWithDocument:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocument:"), document.Handle), "initWithDocument:");
			}
		}
		
		[Export ("cancelAllOperations")]
		[CompilerGenerated]
		public virtual void CancelAllOperations ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelAllOperations"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelAllOperations"));
			}
		}
		
		[Export ("cancelAllOperationsAndWait")]
		[CompilerGenerated]
		public virtual void CancelAllOperationsAndWait ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelAllOperationsAndWait"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelAllOperationsAndWait"));
			}
		}
		
		[Export ("copyWithZone:")]
		[CompilerGenerated]
		public virtual NSObject Copy (NSZone zone)
		{
			if (zone == null)
				throw new ArgumentNullException ("zone");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			}
		}
		
		[Export ("searchForString:")]
		[CompilerGenerated]
		public virtual void SearchForString (string searchTerm)
		{
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("searchForString:"), nssearchTerm);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("searchForString:"), nssearchTerm);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[Export ("searchForString:inRanges:rangesOnly:cancelOperations:")]
		[CompilerGenerated]
		public virtual void SearchForString (string searchTerm, NSIndexSet ranges, bool rangesOnly, bool cancelOperations)
		{
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool_bool (this.Handle, Selector.GetHandle ("searchForString:inRanges:rangesOnly:cancelOperations:"), nssearchTerm, ranges == null ? IntPtr.Zero : ranges.Handle, rangesOnly, cancelOperations);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool_bool (this.SuperHandle, Selector.GetHandle ("searchForString:inRanges:rangesOnly:cancelOperations:"), nssearchTerm, ranges == null ? IntPtr.Zero : ranges.Handle, rangesOnly, cancelOperations);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[CompilerGenerated]
		public virtual NSStringCompareOptions CompareOptions {
			[Export ("compareOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSStringCompareOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (NSStringCompareOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("compareOptions"));
					} else {
						ret = (NSStringCompareOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("compareOptions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (NSStringCompareOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compareOptions"));
					} else {
						ret = (NSStringCompareOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compareOptions"));
					}
				}
				return ret;
			}
			
			[Export ("setCompareOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setCompareOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setCompareOptions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setCompareOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setCompareOptions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFTextSearchDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFTextSearchDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFTextSearchDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFTextSearchDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
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
		public virtual global::System.nuint MaximumNumberOfSearchResults {
			[Export ("maximumNumberOfSearchResults", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNumberOfSearchResults"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumNumberOfSearchResults"));
				}
			}
			
			[Export ("setMaximumNumberOfSearchResults:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMaximumNumberOfSearchResults:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMaximumNumberOfSearchResults:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSRange PreviewRange {
			[Export ("previewRange", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("previewRange"));
						} else {
							global::ApiDefinition.Messaging.NSRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("previewRange"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("previewRange"));
					} else {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("previewRange"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("previewRange"));
						} else {
							global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("previewRange"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("previewRange"));
					} else {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("previewRange"));
					}
				}
				return ret;
			}
			
			[Export ("setPreviewRange:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("setPreviewRange:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NSRange (this.SuperHandle, Selector.GetHandle ("setPreviewRange:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType SearchableAnnotationTypes {
			[Export ("searchableAnnotationTypes", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("searchableAnnotationTypes"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("searchableAnnotationTypes"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchableAnnotationTypes"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchableAnnotationTypes"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setSearchableAnnotationTypes:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setSearchableAnnotationTypes:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setSearchableAnnotationTypes:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setSearchableAnnotationTypes:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setSearchableAnnotationTypes:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SearchQueue_var;
		[CompilerGenerated]
		public virtual NSOperationQueue SearchQueue {
			[Export ("searchQueue", ArgumentSemantic.Retain)]
			get {
				NSOperationQueue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOperationQueue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("searchQueue")));
				} else {
					ret =  Runtime.GetNSObject<NSOperationQueue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchQueue")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchQueue_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Document_var = null;
				__mt_SearchQueue_var = null;
			}
		}
	} /* class PSPDFTextSearch */
}
