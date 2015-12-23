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
	[Register("PSPDFTextBlock", true)]
	public unsafe partial class PSPDFTextBlock : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextBlock");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFTextBlock (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTextBlock (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithGlyphs:")]
		[CompilerGenerated]
		public PSPDFTextBlock (PSPDFGlyph[] glyphs)
			: base (NSObjectFlag.Empty)
		{
			if (glyphs == null)
				throw new ArgumentNullException ("glyphs");
			var nsa_glyphs = NSArray.FromNSObjects (glyphs);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithGlyphs:"), nsa_glyphs.Handle), "initWithGlyphs:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithGlyphs:"), nsa_glyphs.Handle), "initWithGlyphs:");
			}
			nsa_glyphs.Dispose ();
			
		}
		
		[Export ("isEqualToTextBlock:")]
		[CompilerGenerated]
		public virtual bool IsEqualToTextBlock (PSPDFTextBlock otherBlock)
		{
			if (otherBlock == null)
				throw new ArgumentNullException ("otherBlock");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualToTextBlock:"), otherBlock.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualToTextBlock:"), otherBlock.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string Content {
			[Export ("content")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("content")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("content")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGRect Frame {
			[Export ("frame", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("frame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("frame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("frame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("frame"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("frame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("frame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("frame"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Glyphs_var;
		[CompilerGenerated]
		public virtual PSPDFGlyph[] Glyphs {
			[Export ("glyphs", ArgumentSemantic.Copy)]
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
		object __mt_Words_var;
		[CompilerGenerated]
		public virtual PSPDFWord[] Words {
			[Export ("words", ArgumentSemantic.Copy)]
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
				__mt_Glyphs_var = null;
				__mt_Words_var = null;
			}
		}
	} /* class PSPDFTextBlock */
}
