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
	[Register("PSPDFDigitalSignatureReference", true)]
	public unsafe partial class PSPDFDigitalSignatureReference : PSPDFModel {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDigitalSignatureReference");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFDigitalSignatureReference (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFDigitalSignatureReference (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDigitalSignatureReference (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDictionary:")]
		[CompilerGenerated]
		internal static PSPDFDigitalSignatureReference FromDictionary (global::System.IntPtr dict)
		{
			return  Runtime.GetNSObject<PSPDFDigitalSignatureReference> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("initWithDictionary:"), dict));
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr Data {
			[Export ("data", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("data"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("data"));
				}
			}
			
			[Export ("setData:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setData:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setData:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSRange DigestLocation {
			[Export ("digestLocation", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("digestLocation"));
						} else {
							global::ApiDefinition.Messaging.NSRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("digestLocation"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("digestLocation"));
					} else {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("digestLocation"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("digestLocation"));
						} else {
							global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("digestLocation"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("digestLocation"));
					} else {
						ret = global::ApiDefinition.Messaging.NSRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("digestLocation"));
					}
				}
				return ret;
			}
			
			[Export ("setDigestLocation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("setDigestLocation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NSRange (this.SuperHandle, Selector.GetHandle ("setDigestLocation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string DigestMethod {
			[Export ("digestMethod")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("digestMethod")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("digestMethod")));
				}
			}
			
			[Export ("setDigestMethod:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDigestMethod:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDigestMethod:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string DigestValue {
			[Export ("digestValue")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("digestValue")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("digestValue")));
				}
			}
			
			[Export ("setDigestValue:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDigestValue:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDigestValue:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDigitalSignatureReferenceTransformMethod TransformMethod {
			[Export ("transformMethod", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDigitalSignatureReferenceTransformMethod ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDigitalSignatureReferenceTransformMethod) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("transformMethod"));
					} else {
						ret = (PSPDFDigitalSignatureReferenceTransformMethod) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("transformMethod"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDigitalSignatureReferenceTransformMethod) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transformMethod"));
					} else {
						ret = (PSPDFDigitalSignatureReferenceTransformMethod) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transformMethod"));
					}
				}
				return ret;
			}
			
			[Export ("setTransformMethod:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setTransformMethod:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setTransformMethod:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setTransformMethod:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setTransformMethod:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TransformParams_var;
		[CompilerGenerated]
		public virtual NSDictionary TransformParams {
			[Export ("transformParams", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transformParams")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transformParams")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TransformParams_var = ret;
				return ret;
			}
			
			[Export ("setTransformParams:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTransformParams:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTransformParams:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TransformParams_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TransformParams_var = null;
			}
		}
	} /* class PSPDFDigitalSignatureReference */
}
