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
	[Register("PSPDFDownloadManager", true)]
	public unsafe partial class PSPDFDownloadManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDownloadManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFDownloadManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDownloadManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFileCache:fileManager:downloadManagerPolicy:")]
		[CompilerGenerated]
		public PSPDFDownloadManager (PSPDFFileCache fileCache, IPSPDFFileManager fileManager, IPSPDFDownloadManagerPolicy downloadManagerPolicy)
			: base (NSObjectFlag.Empty)
		{
			if (fileCache == null)
				throw new ArgumentNullException ("fileCache");
			if (fileManager == null)
				throw new ArgumentNullException ("fileManager");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithFileCache:fileManager:downloadManagerPolicy:"), fileCache.Handle, fileManager.Handle, downloadManagerPolicy == null ? IntPtr.Zero : downloadManagerPolicy.Handle), "initWithFileCache:fileManager:downloadManagerPolicy:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFileCache:fileManager:downloadManagerPolicy:"), fileCache.Handle, fileManager.Handle, downloadManagerPolicy == null ? IntPtr.Zero : downloadManagerPolicy.Handle), "initWithFileCache:fileManager:downloadManagerPolicy:");
			}
		}
		
		[Export ("cancelAllObjects")]
		[CompilerGenerated]
		public virtual void CancelAllObjects ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelAllObjects"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelAllObjects"));
			}
		}
		
		[Export ("cancelObject:")]
		[CompilerGenerated]
		public virtual void CancelObject (IPSPDFRemoteContentObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cancelObject:"), obj.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cancelObject:"), obj.Handle);
			}
		}
		
		[Export ("enqueueObject:")]
		[CompilerGenerated]
		public virtual void EnqueueObject (IPSPDFRemoteContentObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("enqueueObject:"), obj.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("enqueueObject:"), obj.Handle);
			}
		}
		
		[Export ("enqueueObject:atFront:")]
		[CompilerGenerated]
		public virtual void EnqueueObject (IPSPDFRemoteContentObject obj, bool enqueueAtFront)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("enqueueObject:atFront:"), obj.Handle, enqueueAtFront);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("enqueueObject:atFront:"), obj.Handle, enqueueAtFront);
			}
		}
		
		[Export ("enqueueObjects:")]
		[CompilerGenerated]
		public virtual void EnqueueObjects (IPSPDFRemoteContentObject[] objects)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			var nsa_objects = NSArray.FromNSObjects (objects);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("enqueueObjects:"), nsa_objects.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("enqueueObjects:"), nsa_objects.Handle);
			}
			nsa_objects.Dispose ();
			
		}
		
		[Export ("enqueueObjects:atFront:")]
		[CompilerGenerated]
		public virtual void EnqueueObjects (IPSPDFRemoteContentObject[] objects, bool enqueueAtFront)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			var nsa_objects = NSArray.FromNSObjects (objects);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("enqueueObjects:atFront:"), nsa_objects.Handle, enqueueAtFront);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("enqueueObjects:atFront:"), nsa_objects.Handle, enqueueAtFront);
			}
			nsa_objects.Dispose ();
			
		}
		
		[Export ("handlesObject:")]
		[CompilerGenerated]
		public virtual bool HandlesObject (IPSPDFRemoteContentObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("handlesObject:"), obj.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("handlesObject:"), obj.Handle);
			}
		}
		
		[Export ("objectsPassingTest:")]
		[CompilerGenerated]
		public unsafe virtual IPSPDFRemoteContentObject[] ObjectsPassingTest ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFDownloadManagerPredicateHandler))]PSPDFDownloadManagerPredicateHandler predicateHandler)
		{
			if (predicateHandler == null)
				throw new ArgumentNullException ("predicateHandler");
			BlockLiteral *block_ptr_predicateHandler;
			BlockLiteral block_predicateHandler;
			block_predicateHandler = new BlockLiteral ();
			block_ptr_predicateHandler = &block_predicateHandler;
			block_predicateHandler.SetupBlock (Trampolines.SDPSPDFDownloadManagerPredicateHandler.Handler, predicateHandler);
			
			IPSPDFRemoteContentObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<IPSPDFRemoteContentObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("objectsPassingTest:"), (IntPtr) block_ptr_predicateHandler));
			} else {
				ret = NSArray.ArrayFromHandle<IPSPDFRemoteContentObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("objectsPassingTest:"), (IntPtr) block_ptr_predicateHandler));
			}
			block_ptr_predicateHandler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("stateForObject:")]
		[CompilerGenerated]
		public virtual PSPDFDownloadManagerObjectState StateForObject (IPSPDFRemoteContentObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			PSPDFDownloadManagerObjectState ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (PSPDFDownloadManagerObjectState) global::ApiDefinition.Messaging.UInt64_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stateForObject:"), obj.Handle);
				} else {
					ret = (PSPDFDownloadManagerObjectState) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stateForObject:"), obj.Handle);
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (PSPDFDownloadManagerObjectState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stateForObject:"), obj.Handle);
				} else {
					ret = (PSPDFDownloadManagerObjectState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stateForObject:"), obj.Handle);
				}
			}
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_Cache_var;
		[CompilerGenerated]
		public virtual PSPDFFileCache Cache {
			[Export ("cache", ArgumentSemantic.Retain)]
			get {
				PSPDFFileCache ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFFileCache> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cache")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFFileCache> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cache")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Cache_var = ret;
				return ret;
			}
			
			[Export ("setCache:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCache:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCache:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Cache_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFDownloadManagerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFDownloadManagerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFDownloadManagerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFDownloadManagerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableDynamicNumberOfConcurrentDownloads {
			[Export ("enableDynamicNumberOfConcurrentDownloads", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableDynamicNumberOfConcurrentDownloads"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableDynamicNumberOfConcurrentDownloads"));
				}
			}
			
			[Export ("setEnableDynamicNumberOfConcurrentDownloads:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableDynamicNumberOfConcurrentDownloads:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableDynamicNumberOfConcurrentDownloads:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_FailedObjects_var;
		[CompilerGenerated]
		public virtual IPSPDFRemoteContentObject[] FailedObjects {
			[Export ("failedObjects", ArgumentSemantic.Copy)]
			get {
				IPSPDFRemoteContentObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<IPSPDFRemoteContentObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("failedObjects")));
				} else {
					ret = NSArray.ArrayFromHandle<IPSPDFRemoteContentObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("failedObjects")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FailedObjects_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LoadingObjects_var;
		[CompilerGenerated]
		public virtual IPSPDFRemoteContentObject[] LoadingObjects {
			[Export ("loadingObjects", ArgumentSemantic.Copy)]
			get {
				IPSPDFRemoteContentObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<IPSPDFRemoteContentObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("loadingObjects")));
				} else {
					ret = NSArray.ArrayFromHandle<IPSPDFRemoteContentObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadingObjects")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LoadingObjects_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint NumberOfConcurrentDownloads {
			[Export ("numberOfConcurrentDownloads", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfConcurrentDownloads"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfConcurrentDownloads"));
				}
			}
			
			[Export ("setNumberOfConcurrentDownloads:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setNumberOfConcurrentDownloads:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setNumberOfConcurrentDownloads:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFReachability Reachability {
			[Export ("reachability", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFReachability ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFReachability) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("reachability"));
					} else {
						ret = (PSPDFReachability) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("reachability"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFReachability) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reachability"));
					} else {
						ret = (PSPDFReachability) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reachability"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShouldFinishLoadingObjectsInBackground {
			[Export ("shouldFinishLoadingObjectsInBackground", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldFinishLoadingObjectsInBackground"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldFinishLoadingObjectsInBackground"));
				}
			}
			
			[Export ("setShouldFinishLoadingObjectsInBackground:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldFinishLoadingObjectsInBackground:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldFinishLoadingObjectsInBackground:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WaitingObjects_var;
		[CompilerGenerated]
		public virtual IPSPDFRemoteContentObject[] WaitingObjects {
			[Export ("waitingObjects", ArgumentSemantic.Copy)]
			get {
				IPSPDFRemoteContentObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<IPSPDFRemoteContentObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("waitingObjects")));
				} else {
					ret = NSArray.ArrayFromHandle<IPSPDFRemoteContentObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("waitingObjects")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_WaitingObjects_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _DidFailToLoadTaskNotification;
		[Field ("PSPDFDownloadManagerDidFailToLoadTaskNotification",  "__Internal")]
		public static unsafe NSString DidFailToLoadTaskNotification {
			get {
				if (_DidFailToLoadTaskNotification == null)
					_DidFailToLoadTaskNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFDownloadManagerDidFailToLoadTaskNotification");
				return _DidFailToLoadTaskNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidFinishLoadingTaskNotification;
		[Field ("PSPDFDownloadManagerDidFinishLoadingTaskNotification",  "__Internal")]
		public static unsafe NSString DidFinishLoadingTaskNotification {
			get {
				if (_DidFinishLoadingTaskNotification == null)
					_DidFinishLoadingTaskNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFDownloadManagerDidFinishLoadingTaskNotification");
				return _DidFinishLoadingTaskNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidStartLoadingTaskNotification;
		[Field ("PSPDFDownloadManagerDidStartLoadingTaskNotification",  "__Internal")]
		public static unsafe NSString DidStartLoadingTaskNotification {
			get {
				if (_DidStartLoadingTaskNotification == null)
					_DidStartLoadingTaskNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFDownloadManagerDidStartLoadingTaskNotification");
				return _DidStartLoadingTaskNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Cache_var = null;
				__mt_Delegate_var = null;
				__mt_FailedObjects_var = null;
				__mt_LoadingObjects_var = null;
				__mt_WaitingObjects_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDidFailToLoadTask (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFailToLoadTaskNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidFinishLoadingTask (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFinishLoadingTaskNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidStartLoadingTask (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidStartLoadingTaskNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFDownloadManager */
}
