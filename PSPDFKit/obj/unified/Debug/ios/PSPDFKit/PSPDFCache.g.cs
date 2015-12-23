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
	[Register("PSPDFCache", true)]
	public unsafe partial class PSPDFCache : NSObject, IPSPDFRenderDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFCache");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFCache (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFCache (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSettings:")]
		[CompilerGenerated]
		public PSPDFCache (PSPDFKitGlobal pspdfkit)
			: base (NSObjectFlag.Empty)
		{
			if (pspdfkit == null)
				throw new ArgumentNullException ("pspdfkit");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithSettings:"), pspdfkit.Handle), "initWithSettings:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithSettings:"), pspdfkit.Handle), "initWithSettings:");
			}
		}
		
		[Export ("addDelegate:")]
		[CompilerGenerated]
		public virtual void AddDelegate (IPSPDFCacheDelegate aDelegate)
		{
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addDelegate:"), aDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addDelegate:"), aDelegate.Handle);
			}
		}
		
		[Export ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:")]
		[CompilerGenerated]
		public virtual void CacheDocument (PSPDFDocument document, NSValue[] sizes, PSPDFDiskCacheStrategy strategy, global::System.nuint page)
		{
			if (sizes == null)
				throw new ArgumentNullException ("sizes");
			var nsa_sizes = NSArray.FromNSObjects (sizes);
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_nuint (this.Handle, Selector.GetHandle ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:"), document == null ? IntPtr.Zero : document.Handle, nsa_sizes.Handle, (Int64)strategy, page);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_int_nuint (this.Handle, Selector.GetHandle ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:"), document == null ? IntPtr.Zero : document.Handle, nsa_sizes.Handle, (int)strategy, page);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64_nuint (this.SuperHandle, Selector.GetHandle ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:"), document == null ? IntPtr.Zero : document.Handle, nsa_sizes.Handle, (Int64)strategy, page);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_int_nuint (this.SuperHandle, Selector.GetHandle ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:"), document == null ? IntPtr.Zero : document.Handle, nsa_sizes.Handle, (int)strategy, page);
				}
			}
			nsa_sizes.Dispose ();
			
		}
		
		[Export ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:imageRenderingCompletionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void CacheDocument (PSPDFDocument document, NSValue[] sizes, PSPDFDiskCacheStrategy strategy, global::System.nuint page, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity4V0))]global::System.Action<global::UIKit.UIImage, PSPDFDocument, global::System.nuint, CGSize> pageCompletionHandler)
		{
			if (sizes == null)
				throw new ArgumentNullException ("sizes");
			var nsa_sizes = NSArray.FromNSObjects (sizes);
			BlockLiteral *block_ptr_pageCompletionHandler;
			BlockLiteral block_pageCompletionHandler;
			if (pageCompletionHandler == null){
				block_ptr_pageCompletionHandler = null;
			} else {
				block_pageCompletionHandler = new BlockLiteral ();
				block_ptr_pageCompletionHandler = &block_pageCompletionHandler;
				block_pageCompletionHandler.SetupBlock (Trampolines.SDActionArity4V0.Handler, pageCompletionHandler);
			}
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_nuint_IntPtr (this.Handle, Selector.GetHandle ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:imageRenderingCompletionBlock:"), document == null ? IntPtr.Zero : document.Handle, nsa_sizes.Handle, (Int64)strategy, page, (IntPtr) block_ptr_pageCompletionHandler);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_int_nuint_IntPtr (this.Handle, Selector.GetHandle ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:imageRenderingCompletionBlock:"), document == null ? IntPtr.Zero : document.Handle, nsa_sizes.Handle, (int)strategy, page, (IntPtr) block_ptr_pageCompletionHandler);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:imageRenderingCompletionBlock:"), document == null ? IntPtr.Zero : document.Handle, nsa_sizes.Handle, (Int64)strategy, page, (IntPtr) block_ptr_pageCompletionHandler);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_int_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("cacheDocument:pageSizes:withDiskCacheStrategy:aroundPage:imageRenderingCompletionBlock:"), document == null ? IntPtr.Zero : document.Handle, nsa_sizes.Handle, (int)strategy, page, (IntPtr) block_ptr_pageCompletionHandler);
				}
			}
			nsa_sizes.Dispose ();
			if (block_ptr_pageCompletionHandler != null)
				block_ptr_pageCompletionHandler->CleanupBlock ();
			
		}
		
		[Export ("cacheStatusForImageFromDocument:page:size:options:")]
		[CompilerGenerated]
		public virtual PSPDFCacheStatus CacheStatusForImage (PSPDFDocument document, global::System.nuint page, CGSize size, PSPDFCacheOptions options)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			PSPDFCacheStatus ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (PSPDFCacheStatus) global::ApiDefinition.Messaging.UInt64_objc_msgSend_IntPtr_nuint_CGSize_UInt64 (this.Handle, Selector.GetHandle ("cacheStatusForImageFromDocument:page:size:options:"), document.Handle, page, size, (UInt64)options);
				} else {
					ret = (PSPDFCacheStatus) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr_nuint_CGSize_UInt32 (this.Handle, Selector.GetHandle ("cacheStatusForImageFromDocument:page:size:options:"), document.Handle, page, size, (UInt32)options);
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (PSPDFCacheStatus) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper_IntPtr_nuint_CGSize_UInt64 (this.SuperHandle, Selector.GetHandle ("cacheStatusForImageFromDocument:page:size:options:"), document.Handle, page, size, (UInt64)options);
				} else {
					ret = (PSPDFCacheStatus) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr_nuint_CGSize_UInt32 (this.SuperHandle, Selector.GetHandle ("cacheStatusForImageFromDocument:page:size:options:"), document.Handle, page, size, (UInt32)options);
				}
			}
			return ret;
		}
		
		[Export ("cancelRequestForImageFromDocument:page:size:")]
		[CompilerGenerated]
		public virtual void CancelRequestForImageFromDocument (PSPDFDocument document, global::System.nuint page, CGSize size)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_CGSize (this.Handle, Selector.GetHandle ("cancelRequestForImageFromDocument:page:size:"), document.Handle, page, size);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint_CGSize (this.SuperHandle, Selector.GetHandle ("cancelRequestForImageFromDocument:page:size:"), document.Handle, page, size);
			}
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
		
		[Export ("imageFromDocument:page:size:options:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIImage ImageFromDocument (PSPDFDocument document, global::System.nuint page, CGSize size, PSPDFCacheOptions options)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_UInt64 (this.Handle, Selector.GetHandle ("imageFromDocument:page:size:options:"), document == null ? IntPtr.Zero : document.Handle, page, size, (UInt64)options));
				} else {
					return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_UInt32 (this.Handle, Selector.GetHandle ("imageFromDocument:page:size:options:"), document == null ? IntPtr.Zero : document.Handle, page, size, (UInt32)options));
				}
			} else {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_UInt64 (this.SuperHandle, Selector.GetHandle ("imageFromDocument:page:size:options:"), document == null ? IntPtr.Zero : document.Handle, page, size, (UInt64)options));
				} else {
					return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_UInt32 (this.SuperHandle, Selector.GetHandle ("imageFromDocument:page:size:options:"), document == null ? IntPtr.Zero : document.Handle, page, size, (UInt32)options));
				}
			}
		}
		
		[Export ("imageFromDocument:page:size:options:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual global::UIKit.UIImage ImageFromDocument (PSPDFDocument document, global::System.nuint page, CGSize size, PSPDFCacheOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity4V0))]global::System.Action<global::UIKit.UIImage, PSPDFDocument, global::System.nuint, CGSize> completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity4V0.Handler, completionHandler);
			}
			
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_UInt64_IntPtr (this.Handle, Selector.GetHandle ("imageFromDocument:page:size:options:completionBlock:"), document == null ? IntPtr.Zero : document.Handle, page, size, (UInt64)options, (IntPtr) block_ptr_completionHandler));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_UInt32_IntPtr (this.Handle, Selector.GetHandle ("imageFromDocument:page:size:options:completionBlock:"), document == null ? IntPtr.Zero : document.Handle, page, size, (UInt32)options, (IntPtr) block_ptr_completionHandler));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_UInt64_IntPtr (this.SuperHandle, Selector.GetHandle ("imageFromDocument:page:size:options:completionBlock:"), document == null ? IntPtr.Zero : document.Handle, page, size, (UInt64)options, (IntPtr) block_ptr_completionHandler));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("imageFromDocument:page:size:options:completionBlock:"), document == null ? IntPtr.Zero : document.Handle, page, size, (UInt32)options, (IntPtr) block_ptr_completionHandler));
				}
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("invalidateImageFromDocument:page:")]
		[CompilerGenerated]
		public virtual void InvalidateImageFromDocument (PSPDFDocument document, global::System.nuint page)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("invalidateImageFromDocument:page:"), document == null ? IntPtr.Zero : document.Handle, page);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("invalidateImageFromDocument:page:"), document == null ? IntPtr.Zero : document.Handle, page);
			}
		}
		
		[Export ("renderQueue:jobDidFinish:")]
		[CompilerGenerated]
		public virtual void JobDidFinish (PSPDFRenderQueue renderQueue, PSPDFRenderJob job)
		{
			if (renderQueue == null)
				throw new ArgumentNullException ("renderQueue");
			if (job == null)
				throw new ArgumentNullException ("job");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("renderQueue:jobDidFinish:"), renderQueue.Handle, job.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("renderQueue:jobDidFinish:"), renderQueue.Handle, job.Handle);
			}
		}
		
		[Export ("pauseCachingForService:")]
		[CompilerGenerated]
		public virtual void PauseCachingForService (NSObject service)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("pauseCachingForService:"), service.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("pauseCachingForService:"), service.Handle);
			}
		}
		
		[Export ("removeCacheForDocument:deleteDocument:error:")]
		[CompilerGenerated]
		public virtual bool RemoveCacheForDocument (PSPDFDocument document, bool deleteDocument, out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool_ref_IntPtr (this.Handle, Selector.GetHandle ("removeCacheForDocument:deleteDocument:error:"), document == null ? IntPtr.Zero : document.Handle, deleteDocument, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("removeCacheForDocument:deleteDocument:error:"), document == null ? IntPtr.Zero : document.Handle, deleteDocument, ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("removeDelegate:")]
		[CompilerGenerated]
		public virtual bool RemoveDelegate (IPSPDFCacheDelegate aDelegate)
		{
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeDelegate:"), aDelegate.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeDelegate:"), aDelegate.Handle);
			}
		}
		
		[Export ("resumeCachingForService:")]
		[CompilerGenerated]
		public virtual void ResumeCachingForService (NSObject service)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("resumeCachingForService:"), service.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("resumeCachingForService:"), service.Handle);
			}
		}
		
		[Export ("saveImage:document:page:receipt:")]
		[CompilerGenerated]
		public virtual void SaveImage (global::UIKit.UIImage image, PSPDFDocument document, global::System.nuint page, string renderReceipt)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (document == null)
				throw new ArgumentNullException ("document");
			if (renderReceipt == null)
				throw new ArgumentNullException ("renderReceipt");
			var nsrenderReceipt = NSString.CreateNative (renderReceipt);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("saveImage:document:page:receipt:"), image.Handle, document.Handle, page, nsrenderReceipt);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("saveImage:document:page:receipt:"), image.Handle, document.Handle, page, nsrenderReceipt);
			}
			NSString.ReleaseNative (nsrenderReceipt);
			
		}
		
		[Export ("setDecryptFromPathBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetDecryptFromPathHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFCacheDecryptFromPathHandler))]PSPDFCacheDecryptFromPathHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDPSPDFCacheDecryptFromPathHandler.Handler, handler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDecryptFromPathBlock:"), (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDecryptFromPathBlock:"), (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("setEncryptDataBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetEncryptDataHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFCacheEncryptDataHandler))]PSPDFCacheEncryptDataHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDPSPDFCacheEncryptDataHandler.Handler, handler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEncryptDataBlock:"), (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEncryptDataBlock:"), (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("stopCachingDocument:")]
		[CompilerGenerated]
		public virtual void StopCachingDocument (PSPDFDocument document)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stopCachingDocument:"), document == null ? IntPtr.Zero : document.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stopCachingDocument:"), document == null ? IntPtr.Zero : document.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string CacheDirectory {
			[Export ("cacheDirectory")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cacheDirectory")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cacheDirectory")));
				}
			}
			
			[Export ("setCacheDirectory:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCacheDirectory:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCacheDirectory:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_DiskCache_var;
		[CompilerGenerated]
		public virtual PSPDFDiskCache DiskCache {
			[Export ("diskCache", ArgumentSemantic.Retain)]
			get {
				PSPDFDiskCache ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDiskCache> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("diskCache")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDiskCache> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("diskCache")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DiskCache_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFDiskCacheStrategy DiskCacheStrategy {
			[Export ("diskCacheStrategy", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDiskCacheStrategy ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDiskCacheStrategy) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("diskCacheStrategy"));
					} else {
						ret = (PSPDFDiskCacheStrategy) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("diskCacheStrategy"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDiskCacheStrategy) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("diskCacheStrategy"));
					} else {
						ret = (PSPDFDiskCacheStrategy) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("diskCacheStrategy"));
					}
				}
				return ret;
			}
			
			[Export ("setDiskCacheStrategy:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setDiskCacheStrategy:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDiskCacheStrategy:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setDiskCacheStrategy:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDiskCacheStrategy:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat JpgFormatCompression {
			[Export ("JPGFormatCompression", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("JPGFormatCompression"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("JPGFormatCompression"));
				}
			}
			
			[Export ("setJPGFormatCompression:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setJPGFormatCompression:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setJPGFormatCompression:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_MemoryCache_var;
		[CompilerGenerated]
		public virtual PSPDFMemoryCache MemoryCache {
			[Export ("memoryCache", ArgumentSemantic.Retain)]
			get {
				PSPDFMemoryCache ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFMemoryCache> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("memoryCache")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFMemoryCache> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("memoryCache")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MemoryCache_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool UseJpgFormat {
			[Export ("useJPGFormat", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useJPGFormat"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useJPGFormat"));
				}
			}
			
			[Export ("setUseJPGFormat:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseJPGFormat:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseJPGFormat:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DiskCache_var = null;
				__mt_MemoryCache_var = null;
			}
		}
	} /* class PSPDFCache */
}
