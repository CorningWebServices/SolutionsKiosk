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
	[Register("PSPDFDiskCache", true)]
	public unsafe partial class PSPDFDiskCache : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDiskCache");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDiskCache () : base (NSObjectFlag.Empty)
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
		protected PSPDFDiskCache (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDiskCache (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithCacheDirectory:fileFormat:settings:")]
		[CompilerGenerated]
		public PSPDFDiskCache (string cacheDirectory, string fileFormat, PSPDFKitGlobal settings)
			: base (NSObjectFlag.Empty)
		{
			if (cacheDirectory == null)
				throw new ArgumentNullException ("cacheDirectory");
			if (fileFormat == null)
				throw new ArgumentNullException ("fileFormat");
			if (settings == null)
				throw new ArgumentNullException ("settings");
			var nscacheDirectory = NSString.CreateNative (cacheDirectory);
			var nsfileFormat = NSString.CreateNative (fileFormat);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithCacheDirectory:fileFormat:settings:"), nscacheDirectory, nsfileFormat, settings.Handle), "initWithCacheDirectory:fileFormat:settings:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCacheDirectory:fileFormat:settings:"), nscacheDirectory, nsfileFormat, settings.Handle), "initWithCacheDirectory:fileFormat:settings:");
			}
			NSString.ReleaseNative (nscacheDirectory);
			NSString.ReleaseNative (nsfileFormat);
			
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
		
		[Export ("cancelWriteRequestsWithUID:page:")]
		[CompilerGenerated]
		public virtual void CancelWriteRequests (string uid, global::System.nuint page)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			var nsuid = NSString.CreateNative (uid);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("cancelWriteRequestsWithUID:page:"), nsuid, page);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("cancelWriteRequestsWithUID:page:"), nsuid, page);
			}
			NSString.ReleaseNative (nsuid);
			
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
		
		[Export ("imageWithUID:page:size:infoSelector:decryptionHelper:cacheInfo:")]
		[CompilerGenerated]
		public unsafe virtual global::UIKit.UIImage ImageWithUid (string uid, global::System.nuint page, CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<NSOrderedSet, PSPDFCacheInfo> infoSelector, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V1))]global::System.Func<NSString, global::UIKit.UIImage> decryptionHelper, out PSPDFCacheInfo outCacheInfo)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			if (decryptionHelper == null)
				throw new ArgumentNullException ("decryptionHelper");
			IntPtr outCacheInfoValue = IntPtr.Zero;
			
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
			BlockLiteral *block_ptr_decryptionHelper;
			BlockLiteral block_decryptionHelper;
			block_decryptionHelper = new BlockLiteral ();
			block_ptr_decryptionHelper = &block_decryptionHelper;
			block_decryptionHelper.SetupBlock (Trampolines.SDFuncArity2V1.Handler, decryptionHelper);
			
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("imageWithUID:page:size:infoSelector:decryptionHelper:cacheInfo:"), nsuid, page, size, (IntPtr) block_ptr_infoSelector, (IntPtr) block_ptr_decryptionHelper, ref outCacheInfoValue));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("imageWithUID:page:size:infoSelector:decryptionHelper:cacheInfo:"), nsuid, page, size, (IntPtr) block_ptr_infoSelector, (IntPtr) block_ptr_decryptionHelper, ref outCacheInfoValue));
			}
			NSString.ReleaseNative (nsuid);
			if (block_ptr_infoSelector != null)
				block_ptr_infoSelector->CleanupBlock ();
			block_ptr_decryptionHelper->CleanupBlock ();
			
			
			outCacheInfo = outCacheInfoValue != IntPtr.Zero ? Runtime.GetNSObject<PSPDFKit.PSPDFCacheInfo> (outCacheInfoValue) : null;
			return ret;
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
		
		[Export ("scheduleLoadImageWithUID:page:size:infoSelector:decryptionHelper:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual PSPDFCacheInfo ScheduleLoadImage (string uid, global::System.nuint page, CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<NSOrderedSet, PSPDFCacheInfo> infoSelector, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V1))]global::System.Func<NSString, global::UIKit.UIImage> decryptionHelper, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<global::UIKit.UIImage, PSPDFCacheInfo> completionBlock)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			if (decryptionHelper == null)
				throw new ArgumentNullException ("decryptionHelper");
			if (completionBlock == null)
				throw new ArgumentNullException ("completionBlock");
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
			BlockLiteral *block_ptr_decryptionHelper;
			BlockLiteral block_decryptionHelper;
			block_decryptionHelper = new BlockLiteral ();
			block_ptr_decryptionHelper = &block_decryptionHelper;
			block_decryptionHelper.SetupBlock (Trampolines.SDFuncArity2V1.Handler, decryptionHelper);
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			block_completionBlock = new BlockLiteral ();
			block_ptr_completionBlock = &block_completionBlock;
			block_completionBlock.SetupBlock (Trampolines.SDActionArity2V2.Handler, completionBlock);
			
			PSPDFCacheInfo ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFCacheInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("scheduleLoadImageWithUID:page:size:infoSelector:decryptionHelper:completionBlock:"), nsuid, page, size, (IntPtr) block_ptr_infoSelector, (IntPtr) block_ptr_decryptionHelper, (IntPtr) block_ptr_completionBlock));
			} else {
				ret =  Runtime.GetNSObject<PSPDFCacheInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("scheduleLoadImageWithUID:page:size:infoSelector:decryptionHelper:completionBlock:"), nsuid, page, size, (IntPtr) block_ptr_infoSelector, (IntPtr) block_ptr_decryptionHelper, (IntPtr) block_ptr_completionBlock));
			}
			NSString.ReleaseNative (nsuid);
			if (block_ptr_infoSelector != null)
				block_ptr_infoSelector->CleanupBlock ();
			block_ptr_decryptionHelper->CleanupBlock ();
			block_ptr_completionBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("storeImage:UID:page:encryptionHelper:receipt:")]
		[CompilerGenerated]
		public unsafe virtual void StoreImage (global::UIKit.UIImage image, string uid, global::System.nuint page, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V2))]global::System.Func<global::UIKit.UIImage, NSData> encryptionHelper, string renderReceipt)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (uid == null)
				throw new ArgumentNullException ("uid");
			if (encryptionHelper == null)
				throw new ArgumentNullException ("encryptionHelper");
			if (renderReceipt == null)
				throw new ArgumentNullException ("renderReceipt");
			var nsuid = NSString.CreateNative (uid);
			BlockLiteral *block_ptr_encryptionHelper;
			BlockLiteral block_encryptionHelper;
			block_encryptionHelper = new BlockLiteral ();
			block_ptr_encryptionHelper = &block_encryptionHelper;
			block_encryptionHelper.SetupBlock (Trampolines.SDFuncArity2V2.Handler, encryptionHelper);
			var nsrenderReceipt = NSString.CreateNative (renderReceipt);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("storeImage:UID:page:encryptionHelper:receipt:"), image.Handle, nsuid, page, (IntPtr) block_ptr_encryptionHelper, nsrenderReceipt);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("storeImage:UID:page:encryptionHelper:receipt:"), image.Handle, nsuid, page, (IntPtr) block_ptr_encryptionHelper, nsrenderReceipt);
			}
			NSString.ReleaseNative (nsuid);
			block_ptr_encryptionHelper->CleanupBlock ();
			NSString.ReleaseNative (nsrenderReceipt);
			
		}
		
		[Export ("storeImage:UID:page:encryptionHelper:receipt:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void StoreImage (global::UIKit.UIImage image, string uid, global::System.nuint page, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V2))]global::System.Func<global::UIKit.UIImage, NSData> encryptionHelper, string renderReceipt, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<PSPDFCacheInfo> completionBlock)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (uid == null)
				throw new ArgumentNullException ("uid");
			if (encryptionHelper == null)
				throw new ArgumentNullException ("encryptionHelper");
			if (renderReceipt == null)
				throw new ArgumentNullException ("renderReceipt");
			var nsuid = NSString.CreateNative (uid);
			BlockLiteral *block_ptr_encryptionHelper;
			BlockLiteral block_encryptionHelper;
			block_encryptionHelper = new BlockLiteral ();
			block_ptr_encryptionHelper = &block_encryptionHelper;
			block_encryptionHelper.SetupBlock (Trampolines.SDFuncArity2V2.Handler, encryptionHelper);
			var nsrenderReceipt = NSString.CreateNative (renderReceipt);
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			if (completionBlock == null){
				block_ptr_completionBlock = null;
			} else {
				block_completionBlock = new BlockLiteral ();
				block_ptr_completionBlock = &block_completionBlock;
				block_completionBlock.SetupBlock (Trampolines.SDActionArity1V4.Handler, completionBlock);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("storeImage:UID:page:encryptionHelper:receipt:completionBlock:"), image.Handle, nsuid, page, (IntPtr) block_ptr_encryptionHelper, nsrenderReceipt, (IntPtr) block_ptr_completionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("storeImage:UID:page:encryptionHelper:receipt:completionBlock:"), image.Handle, nsuid, page, (IntPtr) block_ptr_encryptionHelper, nsrenderReceipt, (IntPtr) block_ptr_completionBlock);
			}
			NSString.ReleaseNative (nsuid);
			block_ptr_encryptionHelper->CleanupBlock ();
			NSString.ReleaseNative (nsrenderReceipt);
			if (block_ptr_completionBlock != null)
				block_ptr_completionBlock->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt64 AllowedDiskSpace {
			[Export ("allowedDiskSpace", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("allowedDiskSpace"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowedDiskSpace"));
				}
			}
			
			[Export ("setAllowedDiskSpace:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setAllowedDiskSpace:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setAllowedDiskSpace:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string FileFormat {
			[Export ("fileFormat")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileFormat")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileFormat")));
				}
			}
			
			[Export ("setFileFormat:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFileFormat:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFileFormat:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt64 FreeDiskSpace {
			[Export ("freeDiskSpace", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("freeDiskSpace"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("freeDiskSpace"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt64 UsedDiskSpace {
			[Export ("usedDiskSpace", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("usedDiskSpace"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("usedDiskSpace"));
				}
			}
			
		}
		
	} /* class PSPDFDiskCache */
}
