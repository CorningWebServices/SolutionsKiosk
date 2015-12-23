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
	[Register("PSPDFFileCache", true)]
	public unsafe partial class PSPDFFileCache : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFileCache");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFFileCache (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFileCache (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDirectory:fileManager:")]
		[CompilerGenerated]
		public PSPDFFileCache (string directoryPath, IPSPDFFileManager fileManager)
			: base (NSObjectFlag.Empty)
		{
			if (directoryPath == null)
				throw new ArgumentNullException ("directoryPath");
			if (fileManager == null)
				throw new ArgumentNullException ("fileManager");
			var nsdirectoryPath = NSString.CreateNative (directoryPath);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDirectory:fileManager:"), nsdirectoryPath, fileManager.Handle), "initWithDirectory:fileManager:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDirectory:fileManager:"), nsdirectoryPath, fileManager.Handle), "initWithDirectory:fileManager:");
			}
			NSString.ReleaseNative (nsdirectoryPath);
			
		}
		
		[Export ("containsFileForRemoteURL:")]
		[CompilerGenerated]
		public virtual bool ContainsFileForRemoteUrl (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("containsFileForRemoteURL:"), url.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("containsFileForRemoteURL:"), url.Handle);
			}
		}
		
		[Export ("dataForRemoteURL:")]
		[CompilerGenerated]
		public virtual NSData DataForRemoteUrl (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("dataForRemoteURL:"), url.Handle));
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("dataForRemoteURL:"), url.Handle));
			}
		}
		
		[Export ("fileForRemoteURL:")]
		[CompilerGenerated]
		public virtual NSUrl FileForRemoteUrl (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileForRemoteURL:"), url.Handle));
			} else {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("fileForRemoteURL:"), url.Handle));
			}
		}
		
		[Export ("removeAllFiles")]
		[CompilerGenerated]
		public virtual void RemoveAllFiles ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllFiles"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeAllFiles"));
			}
		}
		
		[Export ("removeFileForURL:")]
		[CompilerGenerated]
		public virtual void RemoveFile (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeFileForURL:"), url.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeFileForURL:"), url.Handle);
			}
		}
		
		[Export ("setFile:remoteURL:")]
		[CompilerGenerated]
		public virtual void SetFile (NSUrl location, NSUrl url)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setFile:remoteURL:"), location.Handle, url.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setFile:remoteURL:"), location.Handle, url.Handle);
			}
		}
		
		[Export ("setData:remoteURL:")]
		[CompilerGenerated]
		public virtual void SetFile (NSData location, NSUrl url)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setData:remoteURL:"), location.Handle, url.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setData:remoteURL:"), location.Handle, url.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string DirectoryPath {
			[Export ("directoryPath", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("directoryPath")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("directoryPath")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint DiskSizeLimit {
			[Export ("diskSizeLimit", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("diskSizeLimit"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("diskSizeLimit"));
				}
			}
			
			[Export ("setDiskSizeLimit:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setDiskSizeLimit:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setDiskSizeLimit:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint UsedDiskSpace {
			[Export ("usedDiskSpace", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("usedDiskSpace"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("usedDiskSpace"));
				}
			}
			
		}
		
	} /* class PSPDFFileCache */
}
