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
	[Register("PSPDFRenderQueue", true)]
	public unsafe partial class PSPDFRenderQueue : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFRenderQueue");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFRenderQueue () : base (NSObjectFlag.Empty)
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
		protected PSPDFRenderQueue (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFRenderQueue (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancelAllJobs")]
		[CompilerGenerated]
		public virtual void CancelAllJobs ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelAllJobs"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelAllJobs"));
			}
		}
		
		[Export ("cancelJob:onlyIfQueued:")]
		[CompilerGenerated]
		public virtual bool CancelJob (PSPDFRenderJob job, bool onlyIfQueued)
		{
			if (job == null)
				throw new ArgumentNullException ("job");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("cancelJob:onlyIfQueued:"), job.Handle, onlyIfQueued);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("cancelJob:onlyIfQueued:"), job.Handle, onlyIfQueued);
			}
		}
		
		[Export ("cancelJobsForDelegate:")]
		[CompilerGenerated]
		public virtual void CancelJobsForDelegate (IPSPDFRenderDelegate aDelegate)
		{
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cancelJobsForDelegate:"), aDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cancelJobsForDelegate:"), aDelegate.Handle);
			}
		}
		
		[Export ("cancelJobsForDocument:page:delegate:includeRunning:")]
		[CompilerGenerated]
		public virtual void CancelJobsForDocument (PSPDFDocument document, global::System.nuint page, IPSPDFRenderDelegate aDelegate, bool includeRunning)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_bool (this.Handle, Selector.GetHandle ("cancelJobsForDocument:page:delegate:includeRunning:"), document.Handle, page, aDelegate.Handle, includeRunning);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("cancelJobsForDocument:page:delegate:includeRunning:"), document.Handle, page, aDelegate.Handle, includeRunning);
			}
		}
		
		[Export ("hasRenderJobsForDelegate:")]
		[CompilerGenerated]
		public virtual bool HasRenderJobsForDelegate (IPSPDFRenderDelegate aDelegate)
		{
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hasRenderJobsForDelegate:"), aDelegate.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hasRenderJobsForDelegate:"), aDelegate.Handle);
			}
		}
		
		[Export ("renderJobsForDocument:page:delegate:")]
		[CompilerGenerated]
		public virtual PSPDFRenderJob[] RenderJobsForDocument (PSPDFDocument document, global::System.nuint page, IPSPDFRenderDelegate aDelegate)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFRenderJob>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("renderJobsForDocument:page:delegate:"), document.Handle, page, aDelegate.Handle));
			} else {
				return NSArray.ArrayFromHandle<PSPDFRenderJob>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("renderJobsForDocument:page:delegate:"), document.Handle, page, aDelegate.Handle));
			}
		}
		
		[Export ("requestRenderedImageForDocument:page:size:clippedToRect:annotations:options:priority:queueAsNext:delegate:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual PSPDFRenderJob RequestRenderedImageForDocument (PSPDFDocument document, global::System.nuint page, CGSize size, CGRect clipRect, PSPDFAnnotation[] annotations, NSDictionary options, PSPDFRenderQueuePriority priority, bool queueAsNext, IPSPDFRenderDelegate aDelegate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PSPDFRenderJob, PSPDFRenderQueue> completionHandler)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			var nsa_annotations = annotations == null ? null : NSArray.FromNSObjects (annotations);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity2V3.Handler, completionHandler);
			}
			
			PSPDFRenderJob ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<PSPDFRenderJob> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_CGRect_IntPtr_IntPtr_UInt64_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("requestRenderedImageForDocument:page:size:clippedToRect:annotations:options:priority:queueAsNext:delegate:completionBlock:"), document.Handle, page, size, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, (UInt64)priority, queueAsNext, aDelegate == null ? IntPtr.Zero : aDelegate.Handle, (IntPtr) block_ptr_completionHandler));
				} else {
					ret =  Runtime.GetNSObject<PSPDFRenderJob> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_CGSize_CGRect_IntPtr_IntPtr_UInt32_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("requestRenderedImageForDocument:page:size:clippedToRect:annotations:options:priority:queueAsNext:delegate:completionBlock:"), document.Handle, page, size, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, (UInt32)priority, queueAsNext, aDelegate == null ? IntPtr.Zero : aDelegate.Handle, (IntPtr) block_ptr_completionHandler));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<PSPDFRenderJob> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_CGRect_IntPtr_IntPtr_UInt64_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("requestRenderedImageForDocument:page:size:clippedToRect:annotations:options:priority:queueAsNext:delegate:completionBlock:"), document.Handle, page, size, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, (UInt64)priority, queueAsNext, aDelegate == null ? IntPtr.Zero : aDelegate.Handle, (IntPtr) block_ptr_completionHandler));
				} else {
					ret =  Runtime.GetNSObject<PSPDFRenderJob> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_CGSize_CGRect_IntPtr_IntPtr_UInt32_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("requestRenderedImageForDocument:page:size:clippedToRect:annotations:options:priority:queueAsNext:delegate:completionBlock:"), document.Handle, page, size, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, (UInt32)priority, queueAsNext, aDelegate == null ? IntPtr.Zero : aDelegate.Handle, (IntPtr) block_ptr_completionHandler));
				}
			}
			if (nsa_annotations != null)
				nsa_annotations.Dispose ();
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint ConcurrentRunningRenderRequests {
			[Export ("concurrentRunningRenderRequests", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("concurrentRunningRenderRequests"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("concurrentRunningRenderRequests"));
				}
			}
			
			[Export ("setConcurrentRunningRenderRequests:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setConcurrentRunningRenderRequests:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setConcurrentRunningRenderRequests:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFRenderQueuePriority MinimumProcessPriority {
			[Export ("minimumProcessPriority", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFRenderQueuePriority ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFRenderQueuePriority) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("minimumProcessPriority"));
					} else {
						ret = (PSPDFRenderQueuePriority) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("minimumProcessPriority"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFRenderQueuePriority) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumProcessPriority"));
					} else {
						ret = (PSPDFRenderQueuePriority) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumProcessPriority"));
					}
				}
				return ret;
			}
			
			[Export ("setMinimumProcessPriority:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setMinimumProcessPriority:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setMinimumProcessPriority:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setMinimumProcessPriority:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setMinimumProcessPriority:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint NumberOfQueuedJobs {
			[Export ("numberOfQueuedJobs")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfQueuedJobs"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfQueuedJobs"));
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _DidCancelJobNotification;
		[Field ("PSPDFRenderQueueDidCancelJobNotification",  "__Internal")]
		public static unsafe NSString DidCancelJobNotification {
			get {
				if (_DidCancelJobNotification == null)
					_DidCancelJobNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFRenderQueueDidCancelJobNotification");
				return _DidCancelJobNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidEnqueueJobNotification;
		[Field ("PSPDFRenderQueueDidEnqueueJobNotification",  "__Internal")]
		public static unsafe NSString DidEnqueueJobNotification {
			get {
				if (_DidEnqueueJobNotification == null)
					_DidEnqueueJobNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFRenderQueueDidEnqueueJobNotification");
				return _DidEnqueueJobNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidFinishJobNotification;
		[Field ("PSPDFRenderQueueDidFinishJobNotification",  "__Internal")]
		public static unsafe NSString DidFinishJobNotification {
			get {
				if (_DidFinishJobNotification == null)
					_DidFinishJobNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFRenderQueueDidFinishJobNotification");
				return _DidFinishJobNotification;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDidCancelJob (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidCancelJobNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidEnqueueJob (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEnqueueJobNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidFinishJob (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFinishJobNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFRenderQueue */
}
