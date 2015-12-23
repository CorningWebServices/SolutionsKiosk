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
	[Register("PSPDFFontInfo", true)]
	public unsafe partial class PSPDFFontInfo : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFontInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFontInfo () : base (NSObjectFlag.Empty)
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
		protected PSPDFFontInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFontInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("glyphNames")]
		[CompilerGenerated]
		public static NSDictionary GlyphNames ()
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("glyphNames")));
		}
		
		[Export ("isEqualToFontInfo:")]
		[CompilerGenerated]
		public virtual bool IsEqualToFontInfo (PSPDFFontInfo otherFontInfo)
		{
			if (otherFontInfo == null)
				throw new ArgumentNullException ("otherFontInfo");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualToFontInfo:"), otherFontInfo.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualToFontInfo:"), otherFontInfo.Handle);
			}
		}
		
		[Export ("standardFontWidths")]
		[CompilerGenerated]
		public static NSDictionary StandardFontWidths ()
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("standardFontWidths")));
		}
		
		[Export ("unicodeStringForCharacter:")]
		[CompilerGenerated]
		public virtual string UnicodeStringForCharacter (global::System.UInt16 character)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("unicodeStringForCharacter:"), character));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("unicodeStringForCharacter:"), character));
			}
		}
		
		[Export ("widthForCharacter:")]
		[CompilerGenerated]
		public virtual global::System.nfloat WidthForCharacter (global::System.UInt16 character)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("widthForCharacter:"), character);
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("widthForCharacter:"), character);
			}
		}
		
		[CompilerGenerated]
		public virtual int Ascent {
			[Export ("ascent", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("ascent"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ascent"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Descent {
			[Export ("descent", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("descent"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("descent"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string[] EncodingArray {
			[Export ("encodingArray", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("encodingArray")));
				} else {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("encodingArray")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FontCMap_var;
		[CompilerGenerated]
		public virtual NSObject FontCMap {
			[Export ("fontCMap", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fontCMap")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontCMap")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FontCMap_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FontFileDescriptor_var;
		[CompilerGenerated]
		public virtual NSObject FontFileDescriptor {
			[Export ("fontFileDescriptor", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fontFileDescriptor")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontFileDescriptor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FontFileDescriptor_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string FontKey {
			[Export ("fontKey")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fontKey")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontKey")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsMultiByteFont {
			[Export ("isMultiByteFont", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMultiByteFont"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMultiByteFont"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("name")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("name")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ToUnicodeMap_var;
		[CompilerGenerated]
		public virtual NSObject ToUnicodeMap {
			[Export ("toUnicodeMap", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("toUnicodeMap")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toUnicodeMap")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ToUnicodeMap_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFFontInfoType Type {
			[Export ("type", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFFontInfoType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFontInfoType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					} else {
						ret = (PSPDFFontInfoType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFFontInfoType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					} else {
						ret = (PSPDFFontInfoType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_UcsCMap_var;
		[CompilerGenerated]
		public virtual NSObject UcsCMap {
			[Export ("ucsCMap", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("ucsCMap")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ucsCMap")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UcsCMap_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FontCMap_var = null;
				__mt_FontFileDescriptor_var = null;
				__mt_ToUnicodeMap_var = null;
				__mt_UcsCMap_var = null;
			}
		}
	} /* class PSPDFFontInfo */
}
