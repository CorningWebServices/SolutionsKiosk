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
	[Register("PSPDFMemoryCache", true)]
	public unsafe partial class PSPDFMemoryCache : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMemoryCache");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFMemoryCache (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMemoryCache (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSettings:")]
		[CompilerGenerated]
		public PSPDFMemoryCache (IPSPDFSettings settings)
			: base (NSObjectFlag.Empty)
		{
			if (settings == null)
				throw new ArgumentNullException ("settings");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithSettings:"), settings.Handle), "initWithSettings:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithSettings:"), settings.Handle), "initWithSettings:");
			}
		}
		
		[Export ("cacheInfoForImageWithUID:page:size:infoSelector:")]
		[CompilerGenerated]
		public unsafe virtual PSPDFCacheInfo CacheInfoForImage (string uid, global::System.nuint page, CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<NSOrderedSet, PSPDFCacheInfo> infoSelector)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			var nsuid = NSString.CreateNative (uid);
			BlockLiteral *block_ptr_infoSelector;
			BlockLiteral block_infoSelector;
			if (infoSelector == null){
				block_ptr_infoSelector = null;
			} else {
				block_infoSelector = new BlockLiteral ();
				block_ptr_infoSelector = &block_infoSelector;
				block_infoSelector.SetupBlock (Trampolines.SDFuncArity2V0.Handler, infoSelector);
			}
			
			PSPDFCacheInfo ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFCacheInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_IntPtr (this.Handle, Selector.GetHandle ("cacheInfoForImageWithUID:page:size:infoSelector:"), nsuid, page, size, (IntPtr) block_ptr_infoSelector));
			} else {
				ret =  Runtime.GetNSObject<PSPDFCacheInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_IntPtr (this.SuperHandle, Selector.GetHandle ("cacheInfoForImageWithUID:page:size:infoSelector:"), nsuid, page, size, (IntPtr) block_ptr_infoSelector));
			}
			NSString.ReleaseNative (nsuid);
			if (block_ptr_infoSelector != null)
				block_ptr_infoSelector->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("clearCache")]
		[CompilerGenerated]
		public virtual void ClearCache ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearCache"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearCache"));
			}
		}
		
		[Export ("count")]
		[CompilerGenerated]
		public virtual global::System.nuint Count ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("count"));
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("count"));
			}
		}
		
		[Export ("invalidateAllImagesWithUID:")]
		[CompilerGenerated]
		public virtual bool InvalidateAllImages (string uid)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			var nsuid = NSString.CreateNative (uid);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("invalidateAllImagesWithUID:"), nsuid);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("invalidateAllImagesWithUID:"), nsuid);
			}
			NSString.ReleaseNative (nsuid);
			
			return ret;
		}
		
		[Export ("invalidateAllImagesWithUID:page:")]
		[CompilerGenerated]
		public virtual bool InvalidateAllImages (string uid, global::System.nuint page)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			var nsuid = NSString.CreateNative (uid);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("invalidateAllImagesWithUID:page:"), nsuid, page);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("invalidateAllImagesWithUID:page:"), nsuid, page);
			}
			NSString.ReleaseNative (nsuid);
			
			return ret;
		}
		
		[Export ("storeImage:UID:page:receipt:")]
		[CompilerGenerated]
		public virtual void StoreImage (global::UIKit.UIImage image, string uid, global::System.nuint page, string renderReceipt)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (uid == null)
				throw new ArgumentNullException ("uid");
			if (renderReceipt == null)
				throw new ArgumentNullException ("renderReceipt");
			var nsuid = NSString.CreateNative (uid);
			var nsrenderReceipt = NSString.CreateNative (renderReceipt);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("storeImage:UID:page:receipt:"), image.Handle, nsuid, page, nsrenderReceipt);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("storeImage:UID:page:receipt:"), image.Handle, nsuid, page, nsrenderReceipt);
			}
			NSString.ReleaseNative (nsuid);
			NSString.ReleaseNative (nsrenderReceipt);
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint MaxNumberOfPixels {
			[Export ("maxNumberOfPixels", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maxNumberOfPixels"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxNumberOfPixels"));
				}
			}
			
			[Export ("setMaxNumberOfPixels:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMaxNumberOfPixels:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMaxNumberOfPixels:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint MaxNumberOfPixelsUnderStress {
			[Export ("maxNumberOfPixelsUnderStress", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maxNumberOfPixelsUnderStress"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxNumberOfPixelsUnderStress"));
				}
			}
			
			[Export ("setMaxNumberOfPixelsUnderStress:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMaxNumberOfPixelsUnderStress:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMaxNumberOfPixelsUnderStress:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint NumberOfPixels {
			[Export ("numberOfPixels", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfPixels"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfPixels"));
				}
			}
			
		}
		
	} /* class PSPDFMemoryCache */
}
