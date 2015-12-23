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
	[Register("PSPDFSearchResultCell", true)]
	public unsafe partial class PSPDFSearchResultCell : PSPDFTableViewCell, IPSPDFCacheDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchResultCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSearchResultCell () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFSearchResultCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFSearchResultCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSearchResultCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("configureWithSearchResult:")]
		[CompilerGenerated]
		public virtual void Configure (PSPDFSearchResult searchResult)
		{
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("configureWithSearchResult:"), searchResult.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("configureWithSearchResult:"), searchResult.Handle);
			}
		}
		
		[Export ("configureWithDocument:page:text:detailText:")]
		[CompilerGenerated]
		public virtual void Configure (PSPDFDocument document, global::System.nuint page, string text, NSAttributedString detailText)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (text == null)
				throw new ArgumentNullException ("text");
			if (detailText == null)
				throw new ArgumentNullException ("detailText");
			var nstext = NSString.CreateNative (text);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("configureWithDocument:page:text:detailText:"), document.Handle, page, nstext, detailText.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("configureWithDocument:page:text:detailText:"), document.Handle, page, nstext, detailText.Handle);
			}
			NSString.ReleaseNative (nstext);
			
		}
		
		[Export ("detailLabelFont")]
		[CompilerGenerated]
		public static global::UIKit.UIFont DetailLabelFont ()
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("detailLabelFont")));
		}
		
		[Export ("didRenderImage:document:page:size:")]
		[CompilerGenerated]
		public virtual void DidRenderImage (global::UIKit.UIImage image, PSPDFDocument document, global::System.nuint page, CGSize size)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_CGSize (this.Handle, Selector.GetHandle ("didRenderImage:document:page:size:"), image.Handle, document.Handle, page, size);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_CGSize (this.SuperHandle, Selector.GetHandle ("didRenderImage:document:page:size:"), image.Handle, document.Handle, page, size);
			}
		}
		
		[Export ("heightForSearchPreviewText:cellWidth:rotatedPageRect:maxNumberOfPreviewLines:")]
		[CompilerGenerated]
		public static global::System.nfloat HeightForSearchPreviewText (NSAttributedString text, global::System.nfloat cellWidth, CGRect rotatedPageRect, global::System.nuint numberOfPreviewLines)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend_IntPtr_nfloat_CGRect_nuint (class_ptr, Selector.GetHandle ("heightForSearchPreviewText:cellWidth:rotatedPageRect:maxNumberOfPreviewLines:"), text.Handle, cellWidth, rotatedPageRect, numberOfPreviewLines);
		}
		
		[Export ("heightForSearchResult:cellWidth:maxNumberOfPreviewLines:")]
		[CompilerGenerated]
		public static global::System.nfloat HeightForSearchResult (PSPDFSearchResult searchResult, global::System.nfloat cellWidth, global::System.nuint numberOfPreviewLines)
		{
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend_IntPtr_nfloat_nuint (class_ptr, Selector.GetHandle ("heightForSearchResult:cellWidth:maxNumberOfPreviewLines:"), searchResult.Handle, cellWidth, numberOfPreviewLines);
		}
		
		[Export ("placeholderImage")]
		[CompilerGenerated]
		public virtual global::UIKit.UIImage PlaceholderImage ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("placeholderImage")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("placeholderImage")));
			}
		}
		
		[Export ("textLabelFont")]
		[CompilerGenerated]
		public static global::UIKit.UIFont TextLabelFont ()
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("textLabelFont")));
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
		public virtual global::System.nuint Page {
			[Export ("page", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("page"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("page"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PagePreviewImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage PagePreviewImage {
			[Export ("pagePreviewImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pagePreviewImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pagePreviewImage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PagePreviewImage_var = ret;
				return ret;
			}
			
			[Export ("setPagePreviewImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPagePreviewImage:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPagePreviewImage:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PagePreviewImage_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseOutlineForPageNames {
			[Export ("useOutlineForPageNames", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useOutlineForPageNames"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useOutlineForPageNames"));
				}
			}
			
			[Export ("setUseOutlineForPageNames:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseOutlineForPageNames:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseOutlineForPageNames:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Document_var = null;
				__mt_PagePreviewImage_var = null;
			}
		}
		public partial class PSPDFSearchResultCellAppearance : global::PSPDFKit.PSPDFTableViewCell.PSPDFTableViewCellAppearance {
			protected internal PSPDFSearchResultCellAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFSearchResultCellAppearance Appearance {
			get { return new PSPDFSearchResultCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFSearchResultCellAppearance GetAppearance<T> () where T: PSPDFSearchResultCell {
			return new PSPDFSearchResultCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFSearchResultCellAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFSearchResultCellAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFSearchResultCellAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFSearchResultCellAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFSearchResultCellAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFSearchResultCellAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFSearchResultCellAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFSearchResultCell {
			return new PSPDFSearchResultCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFSearchResultCellAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFSearchResultCell{
			return new PSPDFSearchResultCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFSearchResultCell */
}
