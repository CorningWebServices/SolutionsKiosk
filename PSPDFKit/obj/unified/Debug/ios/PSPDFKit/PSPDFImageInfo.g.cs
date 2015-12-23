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
	[Register("PSPDFImageInfo", true)]
	public unsafe partial class PSPDFImageInfo : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFImageInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFImageInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFImageInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithImageID:pixelSize:bitsPerComponent:transform:vertices:page:documentProvider:")]
		[CompilerGenerated]
		public PSPDFImageInfo (string imageId, CGSize pixelSize, global::System.nuint bitsPerComponent, CGAffineTransform transform, global::System.IntPtr vertices, global::System.nuint page, PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			var nsimageId = NSString.CreateNative (imageId);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_CGSize_nuint_CGAffineTransform_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("initWithImageID:pixelSize:bitsPerComponent:transform:vertices:page:documentProvider:"), nsimageId, pixelSize, bitsPerComponent, transform, vertices, page, documentProvider == null ? IntPtr.Zero : documentProvider.Handle), "initWithImageID:pixelSize:bitsPerComponent:transform:vertices:page:documentProvider:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGSize_nuint_CGAffineTransform_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithImageID:pixelSize:bitsPerComponent:transform:vertices:page:documentProvider:"), nsimageId, pixelSize, bitsPerComponent, transform, vertices, page, documentProvider == null ? IntPtr.Zero : documentProvider.Handle), "initWithImageID:pixelSize:bitsPerComponent:transform:vertices:page:documentProvider:");
			}
			NSString.ReleaseNative (nsimageId);
			
		}
		
		[Export ("boundingBox")]
		[CompilerGenerated]
		public virtual CGRect BoundingBox ()
		{
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
		
		[Export ("imageWithError:")]
		[CompilerGenerated]
		internal virtual global::UIKit.UIImage GetImage (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("imageWithError:"), error));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("imageWithError:"), error));
			}
		}
		
		[Export ("imageInRGBColorSpaceWithError:")]
		[CompilerGenerated]
		internal virtual global::UIKit.UIImage GetImageInRgbColorSpace (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("imageInRGBColorSpaceWithError:"), error));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("imageInRGBColorSpaceWithError:"), error));
			}
		}
		
		[Export ("hitTest:")]
		[CompilerGenerated]
		public virtual bool HitTest (CGPoint point)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("hitTest:"), point);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("hitTest:"), point);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint BitsPerComponent {
			[Export ("bitsPerComponent", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("bitsPerComponent"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bitsPerComponent"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGSize DisplaySize {
			[Export ("displaySize", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("displaySize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("displaySize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("displaySize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("displaySize"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displaySize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("displaySize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displaySize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displaySize"));
					}
				}
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
		public virtual global::System.nfloat HorizontalResolution {
			[Export ("horizontalResolution", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("horizontalResolution"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("horizontalResolution"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ImageId {
			[Export ("imageID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("imageID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("imageID")));
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
			
		}
		
		[CompilerGenerated]
		public virtual int PixelSize {
			[Export ("pixelSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("pixelSize"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pixelSize"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGAffineTransform Transform {
			[Export ("transform", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("transform"));
						} else {
							global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("transform"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("transform"));
					} else {
						global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("transform"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transform"));
						} else {
							global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("transform"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("transform"));
					} else {
						global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("transform"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat VerticalResolution {
			[Export ("verticalResolution", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("verticalResolution"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("verticalResolution"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGPoint Vertices {
			[Export ("vertices", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("vertices"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("vertices"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("vertices"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("vertices"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("vertices"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("vertices"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("vertices"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("vertices"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentProvider_var = null;
			}
		}
	} /* class PSPDFImageInfo */
}
