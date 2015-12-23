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
	[Register("PSPDFAnnotation", true)]
	public unsafe partial class PSPDFAnnotation : PSPDFModel, IPSPDFJSONSerializing, IPSPDFUndoProtocol {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("attributedString")]
		[CompilerGenerated]
		public virtual NSAttributedString AttributedString ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attributedString")));
			} else {
				return  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributedString")));
			}
		}
		
		[Export ("attributedStringWithContents:")]
		[CompilerGenerated]
		public virtual NSAttributedString AttributedString (string contents)
		{
			var nscontents = NSString.CreateNative (contents);
			
			NSAttributedString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("attributedStringWithContents:"), nscontents));
			} else {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("attributedStringWithContents:"), nscontents));
			}
			NSString.ReleaseNative (nscontents);
			
			return ret;
		}
		
		[Export ("boundingBoxForPageRect:")]
		[CompilerGenerated]
		public virtual CGRect BoundingBoxForPageRect (CGRect pageRect)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("boundingBoxForPageRect:"), pageRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("boundingBoxForPageRect:"), pageRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("boundingBoxForPageRect:"), pageRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("boundingBoxForPageRect:"), pageRect);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("boundingBoxForPageRect:"), pageRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("boundingBoxForPageRect:"), pageRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("boundingBoxForPageRect:"), pageRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("boundingBoxForPageRect:"), pageRect);
				}
			}
			return ret;
		}
		
		[Export ("classForParsingJSONDictionary:")]
		[CompilerGenerated]
		public virtual Class ClassForParsingJSONDictionary (NSDictionary JSONDictionary)
		{
			if (JSONDictionary == null)
				throw new ArgumentNullException ("JSONDictionary");
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("classForParsingJSONDictionary:"), JSONDictionary.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("classForParsingJSONDictionary:"), JSONDictionary.Handle);
			}
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("copyToClipboard")]
		[CompilerGenerated]
		public virtual void CopyToClipboard ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("copyToClipboard"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("copyToClipboard"));
			}
		}
		
		[Export ("defaultFont")]
		[CompilerGenerated]
		public virtual global::UIKit.UIFont DefaultFont ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("defaultFont")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultFont")));
			}
		}
		
		[Export ("defaultFontName")]
		[CompilerGenerated]
		public virtual string DefaultFontName ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("defaultFontName")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultFontName")));
			}
		}
		
		[Export ("defaultFontSize")]
		[CompilerGenerated]
		public virtual global::System.nfloat DefaultFontSize ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("defaultFontSize"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultFontSize"));
			}
		}
		
		[Export ("didUndoOrRedoChange:")]
		[CompilerGenerated]
		public virtual void DidUndoOrRedoChange (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didUndoOrRedoChange:"), nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didUndoOrRedoChange:"), nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("drawInContext:withOptions:")]
		[CompilerGenerated]
		public virtual void DrawInContext (CGContext context, NSDictionary options)
		{
			if (context == null)
				throw new ArgumentNullException ("context");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("drawInContext:withOptions:"), context.Handle, options == null ? IntPtr.Zero : options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("drawInContext:withOptions:"), context.Handle, options == null ? IntPtr.Zero : options.Handle);
			}
		}
		
		[Export ("extractImageFromAppearanceStreamWithTransform:error:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIImage ExtractImageFromAppearanceStream (CGAffineTransform transform, out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGAffineTransform_ref_IntPtr (this.Handle, Selector.GetHandle ("extractImageFromAppearanceStreamWithTransform:error:"), transform, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("extractImageFromAppearanceStreamWithTransform:error:"), transform, ref errorValue));
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("annotationFromJSONDictionary:documentProvider:error:")]
		[CompilerGenerated]
		public static PSPDFAnnotation FromJsonDictionary (NSDictionary jsonDictionary, PSPDFDocumentProvider documentProvider, out NSError error)
		{
			if (jsonDictionary == null)
				throw new ArgumentNullException ("jsonDictionary");
			IntPtr errorValue = IntPtr.Zero;
			
			PSPDFAnnotation ret;
			ret =  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("annotationFromJSONDictionary:documentProvider:error:"), jsonDictionary.Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle, ref errorValue));
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("hitTest:minDiameter:")]
		[CompilerGenerated]
		public virtual bool HitTest (CGPoint point, global::System.nfloat minDiameter)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_CGPoint_nfloat (this.Handle, Selector.GetHandle ("hitTest:minDiameter:"), point, minDiameter);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_CGPoint_nfloat (this.SuperHandle, Selector.GetHandle ("hitTest:minDiameter:"), point, minDiameter);
			}
		}
		
		[Export ("imageWithSize:withOptions:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIImage ImageWithSize (CGSize size, NSDictionary options)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGSize_IntPtr (this.Handle, Selector.GetHandle ("imageWithSize:withOptions:"), size, options == null ? IntPtr.Zero : options.Handle));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGSize_IntPtr (this.SuperHandle, Selector.GetHandle ("imageWithSize:withOptions:"), size, options == null ? IntPtr.Zero : options.Handle));
			}
		}
		
		[Export ("insertUndoObjects:forKey:")]
		[CompilerGenerated]
		public virtual void InsertUndoObjects (NSSet objects, string key)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("insertUndoObjects:forKey:"), objects.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("insertUndoObjects:forKey:"), objects.Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("isEqualToAnnotation:")]
		[CompilerGenerated]
		public virtual bool IsEqualToAnnotation (PSPDFAnnotation otherAnnotation)
		{
			if (otherAnnotation == null)
				throw new ArgumentNullException ("otherAnnotation");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualToAnnotation:"), otherAnnotation.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualToAnnotation:"), otherAnnotation.Handle);
			}
		}
		
		[Export ("JSONKeyPathsByPropertyKey")]
		[CompilerGenerated]
		public virtual NSDictionary JSONKeyPathsByPropertyKey ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("JSONKeyPathsByPropertyKey")));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("JSONKeyPathsByPropertyKey")));
			}
		}
		
		[Export ("JSONTransformerForKey:")]
		[CompilerGenerated]
		public virtual NSObject JSONTransformerForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("JSONTransformerForKey:"), nskey));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("JSONTransformerForKey:"), nskey));
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("keysForValuesToObserveForUndo")]
		[CompilerGenerated]
		public virtual NSSet KeysForValuesToObserveForUndo ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keysForValuesToObserveForUndo")));
			} else {
				return  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("keysForValuesToObserveForUndo")));
			}
		}
		
		[Export ("localizedUndoActionNameForKey:")]
		[CompilerGenerated]
		public static string LocalizedUndoActionNameForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("localizedUndoActionNameForKey:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("minimumSize")]
		[CompilerGenerated]
		public virtual CGSize MinimumSize ()
		{
			CGSize ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("minimumSize"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("minimumSize"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("minimumSize"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("minimumSize"));
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumSize"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("minimumSize"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumSize"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumSize"));
				}
			}
			return ret;
		}
		
		[Export ("noteIconPoint")]
		[CompilerGenerated]
		public virtual CGPoint NoteIconPoint ()
		{
			CGPoint ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("noteIconPoint"));
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("noteIconPoint"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("noteIconPoint"));
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("noteIconPoint"));
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("noteIconPoint"));
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("noteIconPoint"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("noteIconPoint"));
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("noteIconPoint"));
				}
			}
			return ret;
		}
		
		[Export ("performUndoAction:")]
		[CompilerGenerated]
		public virtual void PerformUndoAction (NSObject action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("performUndoAction:"), action.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("performUndoAction:"), action.Handle);
			}
		}
		
		[Export ("removeUndoObjects:forKey:")]
		[CompilerGenerated]
		public virtual void RemoveUndoObjects (NSSet objects, string key)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeUndoObjects:forKey:"), objects.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removeUndoObjects:forKey:"), objects.Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("setBoundingBox:transform:includeOptional:")]
		[CompilerGenerated]
		public virtual void SetBoundingBox (CGRect boundingBox, bool transform, bool optionalProperties)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect_bool_bool (this.Handle, Selector.GetHandle ("setBoundingBox:transform:includeOptional:"), boundingBox, transform, optionalProperties);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect_bool_bool (this.SuperHandle, Selector.GetHandle ("setBoundingBox:transform:includeOptional:"), boundingBox, transform, optionalProperties);
			}
		}
		
		[Export ("shouldDeleteAnnotation")]
		[CompilerGenerated]
		public virtual bool ShouldDeleteAnnotation ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldDeleteAnnotation"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldDeleteAnnotation"));
			}
		}
		
		[Export ("shouldUpdateOptionalPropertiesOnBoundsChange")]
		[CompilerGenerated]
		public virtual bool ShouldUpdateOptionalPropertiesOnBoundsChange ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldUpdateOptionalPropertiesOnBoundsChange"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldUpdateOptionalPropertiesOnBoundsChange"));
			}
		}
		
		[Export ("shouldUpdatePropertiesOnBoundsChange")]
		[CompilerGenerated]
		public virtual bool ShouldUpdatePropertiesOnBoundsChange ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldUpdatePropertiesOnBoundsChange"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldUpdatePropertiesOnBoundsChange"));
			}
		}
		
		[Export ("undoCoalescingForKey:")]
		[CompilerGenerated]
		public static PSPDFUndoCoalescing UndoCoalescingForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			PSPDFUndoCoalescing ret;
			if (IntPtr.Size == 8) {
				ret = (PSPDFUndoCoalescing) global::ApiDefinition.Messaging.UInt64_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("undoCoalescingForKey:"), nskey);
			} else {
				ret = (PSPDFUndoCoalescing) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("undoCoalescingForKey:"), nskey);
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("updateOptionalPropertiesWithTransform:isSizeChange:meanScale:")]
		[CompilerGenerated]
		public virtual void UpdateOptionalPropertiesWithTransform (CGAffineTransform transform, bool isSizeChange, global::System.nfloat meanScale)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGAffineTransform_bool_nfloat (this.Handle, Selector.GetHandle ("updateOptionalPropertiesWithTransform:isSizeChange:meanScale:"), transform, isSizeChange, meanScale);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGAffineTransform_bool_nfloat (this.SuperHandle, Selector.GetHandle ("updateOptionalPropertiesWithTransform:isSizeChange:meanScale:"), transform, isSizeChange, meanScale);
			}
		}
		
		[Export ("updatePropertiesWithTransform:isSizeChange:meanScale:")]
		[CompilerGenerated]
		public virtual void UpdateProperties (CGAffineTransform transform, bool isSizeChange, global::System.nfloat meanScale)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGAffineTransform_bool_nfloat (this.Handle, Selector.GetHandle ("updatePropertiesWithTransform:isSizeChange:meanScale:"), transform, isSizeChange, meanScale);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGAffineTransform_bool_nfloat (this.SuperHandle, Selector.GetHandle ("updatePropertiesWithTransform:isSizeChange:meanScale:"), transform, isSizeChange, meanScale);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint AbsolutePage {
			[Export ("absolutePage", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("absolutePage"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("absolutePage"));
				}
			}
			
			[Export ("setAbsolutePage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setAbsolutePage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setAbsolutePage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_AdditionalActions_var;
		[CompilerGenerated]
		public virtual NSDictionary AdditionalActions {
			[Export ("additionalActions", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("additionalActions")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("additionalActions")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalActions_var = ret;
				return ret;
			}
			
			[Export ("setAdditionalActions:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdditionalActions:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdditionalActions:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalActions_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Alpha {
			[Export ("alpha", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("alpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alpha"));
				}
			}
			
			[Export ("setAlpha:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAlpha:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationIcon_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage AnnotationIcon {
			[Export ("annotationIcon")]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationIcon")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationIcon")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationIcon_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BorderColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BorderColor {
			[Export ("borderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("borderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BorderColor_var = ret;
				return ret;
			}
			
			[Export ("setBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BorderColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationBorderEffect BorderEffect {
			[Export ("borderEffect", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationBorderEffect ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationBorderEffect) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("borderEffect"));
					} else {
						ret = (PSPDFAnnotationBorderEffect) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("borderEffect"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationBorderEffect) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderEffect"));
					} else {
						ret = (PSPDFAnnotationBorderEffect) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderEffect"));
					}
				}
				return ret;
			}
			
			[Export ("setBorderEffect:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setBorderEffect:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setBorderEffect:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setBorderEffect:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setBorderEffect:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat BorderEffectIntensity {
			[Export ("borderEffectIntensity", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("borderEffectIntensity"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderEffectIntensity"));
				}
			}
			
			[Export ("setBorderEffectIntensity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setBorderEffectIntensity:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setBorderEffectIntensity:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationBorderStyle BorderStyle {
			[Export ("borderStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationBorderStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationBorderStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("borderStyle"));
					} else {
						ret = (PSPDFAnnotationBorderStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("borderStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationBorderStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderStyle"));
					} else {
						ret = (PSPDFAnnotationBorderStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setBorderStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setBorderStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setBorderStyle:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setBorderStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setBorderStyle:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGRect BoundingBox {
			[Export ("boundingBox", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("boundingBox"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("boundingBox"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("boundingBox"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("boundingBox"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("boundingBox"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("boundingBox"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("boundingBox"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("boundingBox"));
					}
				}
				return ret;
			}
			
			[Export ("setBoundingBox:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setBoundingBox:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("setBoundingBox:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Color_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor Color {
			[Export ("color", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("color")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("color")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color_var = ret;
				return ret;
			}
			
			[Export ("setColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Contents {
			[Export ("contents")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contents")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contents")));
				}
			}
			
			[Export ("setContents:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContents:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContents:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_CreationDate_var;
		[CompilerGenerated]
		public virtual NSDate CreationDate {
			[Export ("creationDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("creationDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("creationDate")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CreationDate_var = ret;
				return ret;
			}
			
			[Export ("setCreationDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCreationDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCreationDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CreationDate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DashArray_var;
		[CompilerGenerated]
		public virtual NSValue[] DashArray {
			[Export ("dashArray", ArgumentSemantic.Copy)]
			get {
				NSValue[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSValue>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dashArray")));
				} else {
					ret = NSArray.ArrayFromHandle<NSValue>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dashArray")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DashArray_var = ret;
				return ret;
			}
			
			[Export ("setDashArray:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDashArray:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDashArray:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_DashArray_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Deleted {
			[Export ("isDeleted", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDeleted"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDeleted"));
				}
			}
			
			[Export ("setDeleted:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDeleted:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDeleted:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Dirty {
			[Export ("isDirty", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDirty"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDirty"));
				}
			}
			
			[Export ("setDirty:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDirty:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDirty:"), value);
				}
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
		public virtual bool Editable {
			[Export ("isEditable", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEditable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEditable"));
				}
			}
			
			[Export ("setEditable:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEditable:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEditable:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_FillColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor FillColor {
			[Export ("fillColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fillColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fillColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FillColor_var = ret;
				return ret;
			}
			
			[Export ("setFillColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFillColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFillColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FillColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public static CGSize FixedSize {
			[Export ("fixedSize")]
			get {
				CGSize ret;
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (class_ptr, Selector.GetHandle ("fixedSize"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, class_ptr, Selector.GetHandle ("fixedSize"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (class_ptr, Selector.GetHandle ("fixedSize"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (class_ptr, Selector.GetHandle ("fixedSize"));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationFlags Flags {
			[Export ("flags", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationFlags ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationFlags) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("flags"));
					} else {
						ret = (PSPDFAnnotationFlags) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("flags"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationFlags) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("flags"));
					} else {
						ret = (PSPDFAnnotationFlags) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("flags"));
					}
				}
				return ret;
			}
			
			[Export ("setFlags:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setFlags:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setFlags:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setFlags:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setFlags:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_FontAttributes_var;
		[CompilerGenerated]
		public virtual NSDictionary FontAttributes {
			[Export ("fontAttributes", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fontAttributes")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontAttributes")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FontAttributes_var = ret;
				return ret;
			}
			
			[Export ("setFontAttributes:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFontAttributes:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFontAttributes:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FontAttributes_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string FontName {
			[Export ("fontName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fontName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontName")));
				}
			}
			
			[Export ("setFontName:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFontName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFontName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat FontSize {
			[Export ("fontSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("fontSize"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontSize"));
				}
			}
			
			[Export ("setFontSize:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setFontSize:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setFontSize:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Group {
			[Export ("group")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("group")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("group")));
				}
			}
			
			[Export ("setGroup:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGroup:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGroup:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasAppearanceStream {
			[Export ("hasAppearanceStream")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasAppearanceStream"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasAppearanceStream"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Hidden {
			[Export ("isHidden", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isHidden"));
				}
			}
			
			[Export ("setHidden:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint IndexOnPage {
			[Export ("indexOnPage")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("indexOnPage"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("indexOnPage"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsDeletable {
			[Export ("isDeletable")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isDeletable"));
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsFixedSize {
			[Export ("isFixedSize")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isFixedSize"));
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsMovable {
			[Export ("isMovable")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMovable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMovable"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsResizable {
			[Export ("isResizable")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isResizable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isResizable"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsWriteable {
			[Export ("isWriteable")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isWriteable"));
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LastModified_var;
		[CompilerGenerated]
		public virtual NSDate LastModified {
			[Export ("lastModified", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastModified")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastModified")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastModified_var = ret;
				return ret;
			}
			
			[Export ("setLastModified:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLastModified:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLastModified:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastModified_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat LineWidth {
			[Export ("lineWidth", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("lineWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineWidth"));
				}
			}
			
			[Export ("setLineWidth:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLineWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLineWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string LocalizedDescription {
			[Export ("localizedDescription")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("localizedDescription")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("localizedDescription")));
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
			
			[Export ("setName:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool Overlay {
			[Export ("isOverlay", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isOverlay"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isOverlay"));
				}
			}
			
			[Export ("setOverlay:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOverlay:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setOverlay:"), value);
				}
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
			
			[Export ("setPage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Points_var;
		[CompilerGenerated]
		public virtual NSValue[] Points {
			[Export ("points", ArgumentSemantic.Copy)]
			get {
				NSValue[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSValue>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("points")));
				} else {
					ret = NSArray.ArrayFromHandle<NSValue>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("points")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Points_var = ret;
				return ret;
			}
			
			[Export ("setPoints:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPoints:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPoints:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Points_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Rects_var;
		[CompilerGenerated]
		public virtual NSValue[] Rects {
			[Export ("rects", ArgumentSemantic.Copy)]
			get {
				NSValue[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSValue>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rects")));
				} else {
					ret = NSArray.ArrayFromHandle<NSValue>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rects")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Rects_var = ret;
				return ret;
			}
			
			[Export ("setRects:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRects:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRects:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Rects_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool RequriesPopupAnnotation {
			[Export ("requriesPopupAnnotation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requriesPopupAnnotation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requriesPopupAnnotation"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Rotation {
			[Export ("rotation", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("rotation"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotation"));
				}
			}
			
			[Export ("setRotation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setRotation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setRotation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldMaintainAspectRatio {
			[Export ("shouldMaintainAspectRatio")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldMaintainAspectRatio"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldMaintainAspectRatio"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Subject {
			[Export ("subject")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subject")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subject")));
				}
			}
			
			[Export ("setSubject:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubject:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubject:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UITextAlignment TextAlignment {
			[Export ("textAlignment", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UITextAlignment ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UITextAlignment) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("textAlignment"));
					} else {
						ret = (global::UIKit.UITextAlignment) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("textAlignment"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UITextAlignment) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textAlignment"));
					} else {
						ret = (global::UIKit.UITextAlignment) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textAlignment"));
					}
				}
				return ret;
			}
			
			[Export ("setTextAlignment:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setTextAlignment:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setTextAlignment:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setTextAlignment:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setTextAlignment:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType Type {
			[Export ("type", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TypeString {
			[Export ("typeString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("typeString")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("typeString")));
				}
			}
			
			[Export ("setTypeString:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTypeString:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTypeString:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string User {
			[Export ("user")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("user")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("user")));
				}
			}
			
			[Export ("setUser:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUser:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUser:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Value_var;
		[CompilerGenerated]
		public virtual NSObject Value {
			[Export ("value", ArgumentSemantic.Copy)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("value")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("value")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Value_var = ret;
				return ret;
			}
			
			[Export ("setValue:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setValue:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setValue:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Value_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFVerticalAlignment VerticalTextAlignment {
			[Export ("verticalTextAlignment", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFVerticalAlignment ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFVerticalAlignment) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("verticalTextAlignment"));
					} else {
						ret = (PSPDFVerticalAlignment) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("verticalTextAlignment"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFVerticalAlignment) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("verticalTextAlignment"));
					} else {
						ret = (PSPDFVerticalAlignment) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("verticalTextAlignment"));
					}
				}
				return ret;
			}
			
			[Export ("setVerticalTextAlignment:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setVerticalTextAlignment:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setVerticalTextAlignment:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setVerticalTextAlignment:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setVerticalTextAlignment:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool WantsSelectionBorder {
			[Export ("wantsSelectionBorder")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wantsSelectionBorder"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("wantsSelectionBorder"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AdditionalActions_var = null;
				__mt_AnnotationIcon_var = null;
				__mt_BorderColor_var = null;
				__mt_Color_var = null;
				__mt_CreationDate_var = null;
				__mt_DashArray_var = null;
				__mt_Document_var = null;
				__mt_DocumentProvider_var = null;
				__mt_FillColor_var = null;
				__mt_FontAttributes_var = null;
				__mt_LastModified_var = null;
				__mt_Points_var = null;
				__mt_Rects_var = null;
				__mt_Value_var = null;
			}
		}
	} /* class PSPDFAnnotation */
}
