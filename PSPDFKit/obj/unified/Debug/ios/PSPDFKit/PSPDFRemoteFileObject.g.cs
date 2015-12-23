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
	[Register("PSPDFRemoteFileObject", true)]
	public unsafe partial class PSPDFRemoteFileObject : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFRemoteFileObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFRemoteFileObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFRemoteFileObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRemoteURL:targetURL:fileManager:")]
		[CompilerGenerated]
		public PSPDFRemoteFileObject (NSUrl remoteUrl, NSUrl targetFileUrl, IPSPDFFileManager fileManager)
			: base (NSObjectFlag.Empty)
		{
			if (remoteUrl == null)
				throw new ArgumentNullException ("remoteUrl");
			if (targetFileUrl == null)
				throw new ArgumentNullException ("targetFileUrl");
			if (fileManager == null)
				throw new ArgumentNullException ("fileManager");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithRemoteURL:targetURL:fileManager:"), remoteUrl.Handle, targetFileUrl.Handle, fileManager.Handle), "initWithRemoteURL:targetURL:fileManager:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRemoteURL:targetURL:fileManager:"), remoteUrl.Handle, targetFileUrl.Handle, fileManager.Handle), "initWithRemoteURL:targetURL:fileManager:");
			}
		}
		
		[CompilerGenerated]
		public virtual bool LoadingRemoteContent {
			[Export ("isLoadingRemoteContent", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLoadingRemoteContent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLoadingRemoteContent"));
				}
			}
			
			[Export ("setLoadingRemoteContent:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLoadingRemoteContent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLoadingRemoteContent:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_RemoteContent_var;
		[CompilerGenerated]
		public virtual NSUrl RemoteContent {
			[Export ("remoteContent", ArgumentSemantic.Retain)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteContent")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteContent")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RemoteContent_var = ret;
				return ret;
			}
			
			[Export ("setRemoteContent:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteContent:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteContent:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RemoteContent_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RemoteContentError_var;
		[CompilerGenerated]
		public virtual NSError RemoteContentError {
			[Export ("remoteContentError", ArgumentSemantic.Retain)]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteContentError")));
				} else {
					ret =  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteContentError")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RemoteContentError_var = ret;
				return ret;
			}
			
			[Export ("setRemoteContentError:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteContentError:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteContentError:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RemoteContentError_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat RemoteContentProgress {
			[Export ("remoteContentProgress", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("remoteContentProgress"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteContentProgress"));
				}
			}
			
			[Export ("setRemoteContentProgress:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRemoteContentProgress:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRemoteContentProgress:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual PSPDFRemoteFileObjectRemoteObjectHandler RemoteObject {
			[Export ("remoteObject", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteObject"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteObject"));
				}
				return global::ObjCRuntime.Trampolines.NIDPSPDFRemoteFileObjectRemoteObjectHandler.Create (ret);
			}
			
			[Export ("setRemoteObject:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDPSPDFRemoteFileObjectRemoteObjectHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteObject:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteObject:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_RemoteUrl_var;
		[CompilerGenerated]
		public virtual NSUrl RemoteUrl {
			[Export ("remoteURL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RemoteUrl_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_TargetUrl_var;
		[CompilerGenerated]
		public virtual NSUrl TargetUrl {
			[Export ("targetURL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("targetURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("targetURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TargetUrl_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_RemoteContent_var = null;
				__mt_RemoteContentError_var = null;
				__mt_RemoteUrl_var = null;
				__mt_TargetUrl_var = null;
			}
		}
	} /* class PSPDFRemoteFileObject */
}
