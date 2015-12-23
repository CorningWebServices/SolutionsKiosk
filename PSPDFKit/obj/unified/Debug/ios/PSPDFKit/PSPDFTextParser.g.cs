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
	[Register("PSPDFTextParser", true)]
	public unsafe partial class PSPDFTextParser : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFTextParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTextParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPDFPage:page:documentProvider:fontCache:hideGlyphsOutsidePageRect:PDFBox:")]
		[CompilerGenerated]
		internal PSPDFTextParser (global::System.IntPtr pageRef, global::System.nuint page, PSPDFDocumentProvider documentProvider, NSMutableDictionary fontCache, bool hideGlyphsOutsidePageRect, CGPDFBox PDFBox)
			: base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (fontCache == null)
				throw new ArgumentNullException ("fontCache");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr_IntPtr_bool_int (this.Handle, Selector.GetHandle ("initWithPDFPage:page:documentProvider:fontCache:hideGlyphsOutsidePageRect:PDFBox:"), pageRef, page, documentProvider.Handle, fontCache.Handle, hideGlyphsOutsidePageRect, (int)PDFBox), "initWithPDFPage:page:documentProvider:fontCache:hideGlyphsOutsidePageRect:PDFBox:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr_IntPtr_bool_int (this.SuperHandle, Selector.GetHandle ("initWithPDFPage:page:documentProvider:fontCache:hideGlyphsOutsidePageRect:PDFBox:"), pageRef, page, documentProvider.Handle, fontCache.Handle, hideGlyphsOutsidePageRect, (int)PDFBox), "initWithPDFPage:page:documentProvider:fontCache:hideGlyphsOutsidePageRect:PDFBox:");
			}
		}
		
		[Export ("initWithStream:")]
		[CompilerGenerated]
		internal static global::System.IntPtr FromStream (global::System.IntPtr stream)
		{
			return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("initWithStream:"), stream);
		}
		
		[Export ("shouldParseCharacter:")]
		[CompilerGenerated]
		public virtual bool ShouldParseCharacter (global::System.UInt16 character)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("shouldParseCharacter:"), character);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("shouldParseCharacter:"), character);
			}
		}
		
		[Export ("textWithGlyphs:")]
		[CompilerGenerated]
		public virtual string TextWithGlyphs (PSPDFGlyph[] glyphs)
		{
			if (glyphs == null)
				throw new ArgumentNullException ("glyphs");
			var nsa_glyphs = NSArray.FromNSObjects (glyphs);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("textWithGlyphs:"), nsa_glyphs.Handle));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("textWithGlyphs:"), nsa_glyphs.Handle));
			}
			nsa_glyphs.Dispose ();
			
			return ret;
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
		object __mt_Glyphs_var;
		[CompilerGenerated]
		public virtual PSPDFGlyph[] Glyphs {
			[Export ("glyphs", ArgumentSemantic.Retain)]
			get {
				PSPDFGlyph[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFGlyph>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("glyphs")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFGlyph>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("glyphs")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Glyphs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Images_var;
		[CompilerGenerated]
		public virtual PSPDFImageInfo[] Images {
			[Export ("images", ArgumentSemantic.Retain)]
			get {
				PSPDFImageInfo[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFImageInfo>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("images")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFImageInfo>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("images")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Images_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Lines_var;
		[CompilerGenerated]
		public virtual PSPDFTextLine[] Lines {
			[Export ("lines", ArgumentSemantic.Retain)]
			get {
				PSPDFTextLine[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFTextLine>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lines")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFTextLine>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lines")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Lines_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_MarkedContentStack_var;
		[CompilerGenerated]
		public virtual NSObject[] MarkedContentStack {
			[Export ("markedContentStack", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("markedContentStack")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("markedContentStack")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MarkedContentStack_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::CoreFoundation.DispatchQueue ParsingQueue {
			[Export ("parsingQueue", ArgumentSemantic.UnsafeUnretained)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("parsingQueue"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parsingQueue"));
				}
				return ret == IntPtr.Zero ? null : new global::CoreFoundation.DispatchQueue (ret);
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Text {
			[Export ("text")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("text")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("text")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_TextBlocks_var;
		[CompilerGenerated]
		public virtual PSPDFTextBlock[] TextBlocks {
			[Export ("textBlocks", ArgumentSemantic.Retain)]
			get {
				PSPDFTextBlock[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFTextBlock>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textBlocks")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFTextBlock>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textBlocks")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TextBlocks_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Words_var;
		[CompilerGenerated]
		public virtual PSPDFWord[] Words {
			[Export ("words", ArgumentSemantic.Retain)]
			get {
				PSPDFWord[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFWord>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("words")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFWord>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("words")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Words_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentProvider_var = null;
				__mt_Glyphs_var = null;
				__mt_Images_var = null;
				__mt_Lines_var = null;
				__mt_MarkedContentStack_var = null;
				__mt_TextBlocks_var = null;
				__mt_Words_var = null;
			}
		}
	} /* class PSPDFTextParser */
}
