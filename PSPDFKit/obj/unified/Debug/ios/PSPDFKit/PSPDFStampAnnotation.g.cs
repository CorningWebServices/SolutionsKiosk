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
	[Register("PSPDFStampAnnotation", true)]
	public unsafe partial class PSPDFStampAnnotation : PSPDFAnnotation {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFStampAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFStampAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFStampAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFStampAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStampAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSubject:")]
		[CompilerGenerated]
		public PSPDFStampAnnotation (string subject)
			: base (NSObjectFlag.Empty)
		{
			var nssubject = NSString.CreateNative (subject);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithSubject:"), nssubject), "initWithSubject:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithSubject:"), nssubject), "initWithSubject:");
			}
			NSString.ReleaseNative (nssubject);
			
		}
		
		[Export ("initWithImage:")]
		[CompilerGenerated]
		public PSPDFStampAnnotation (global::UIKit.UIImage image)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithImage:"), image == null ? IntPtr.Zero : image.Handle), "initWithImage:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithImage:"), image == null ? IntPtr.Zero : image.Handle), "initWithImage:");
			}
		}
		
		[Export ("loadImageWithTransform:error:")]
		[CompilerGenerated]
		internal virtual global::UIKit.UIImage LoadImage (out CGAffineTransform transform, global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_out_CGAffineTransform_IntPtr (this.Handle, Selector.GetHandle ("loadImageWithTransform:error:"), out transform, error));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_out_CGAffineTransform_IntPtr (this.SuperHandle, Selector.GetHandle ("loadImageWithTransform:error:"), out transform, error));
			}
		}
		
		[Export ("sizeThatFits:")]
		[CompilerGenerated]
		public virtual CGSize SizeThatFits (CGSize size)
		{
			CGSize ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("sizeThatFits:"), size);
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret_CGSize (out ret, this.Handle, Selector.GetHandle ("sizeThatFits:"), size);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("sizeThatFits:"), size);
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("sizeThatFits:"), size);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("sizeThatFits:"), size);
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret_CGSize (out ret, this.SuperHandle, Selector.GetHandle ("sizeThatFits:"), size);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("sizeThatFits:"), size);
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("sizeThatFits:"), size);
				}
			}
			return ret;
		}
		
		[Export ("sizeToFit")]
		[CompilerGenerated]
		public virtual void SizeToFit ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("sizeToFit"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sizeToFit"));
			}
		}
		
		[Export ("stampColorForSubject:")]
		[CompilerGenerated]
		public static global::UIKit.UIColor StampColorForSubject (string subject)
		{
			if (subject == null)
				throw new ArgumentNullException ("subject");
			var nssubject = NSString.CreateNative (subject);
			
			global::UIKit.UIColor ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("stampColorForSubject:"), nssubject));
			NSString.ReleaseNative (nssubject);
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_Image_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage Image {
			[Export ("image", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("image")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("image")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Image_var = ret;
				return ret;
			}
			
			[Export ("setImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Image_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual CGAffineTransform ImageTransform {
			[Export ("imageTransform", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("imageTransform"));
						} else {
							global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("imageTransform"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("imageTransform"));
					} else {
						global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("imageTransform"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("imageTransform"));
						} else {
							global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("imageTransform"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("imageTransform"));
					} else {
						global::ApiDefinition.Messaging.CGAffineTransform_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("imageTransform"));
					}
				}
				return ret;
			}
			
			[Export ("setImageTransform:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, Selector.GetHandle ("setImageTransform:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGAffineTransform (this.SuperHandle, Selector.GetHandle ("setImageTransform:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string LocalizedSubject {
			[Export ("localizedSubject")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("localizedSubject")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("localizedSubject")));
				}
			}
			
			[Export ("setLocalizedSubject:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLocalizedSubject:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLocalizedSubject:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Subtext {
			[Export ("subtext")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subtext")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subtext")));
				}
			}
			
			[Export ("setSubtext:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubtext:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubtext:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Image_var = null;
			}
		}
	} /* class PSPDFStampAnnotation */
}
