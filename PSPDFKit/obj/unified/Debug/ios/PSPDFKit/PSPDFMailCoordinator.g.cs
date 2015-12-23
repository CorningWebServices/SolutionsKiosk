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
	[Register("PSPDFMailCoordinator", true)]
	public unsafe partial class PSPDFMailCoordinator : PSPDFDocumentSharingCoordinator, global::MessageUI.IMFMailComposeViewControllerDelegate, global::UIKit.IUINavigationControllerDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMailCoordinator");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMailCoordinator () : base (NSObjectFlag.Empty)
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
		protected PSPDFMailCoordinator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMailCoordinator (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addAttachmentData:mimeType:fileName:")]
		[CompilerGenerated]
		public virtual void AddAttachmentData (NSData attachment, string mimeType, string fileName)
		{
			if (attachment == null)
				throw new ArgumentNullException ("attachment");
			if (mimeType == null)
				throw new ArgumentNullException ("mimeType");
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsmimeType = NSString.CreateNative (mimeType);
			var nsfileName = NSString.CreateNative (fileName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addAttachmentData:mimeType:fileName:"), attachment.Handle, nsmimeType, nsfileName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addAttachmentData:mimeType:fileName:"), attachment.Handle, nsmimeType, nsfileName);
			}
			NSString.ReleaseNative (nsmimeType);
			NSString.ReleaseNative (nsfileName);
			
		}
		
		[CompilerGenerated]
		object __mt_MailComposeViewController_var;
		[CompilerGenerated]
		public virtual global::MessageUI.MFMailComposeViewController MailComposeViewController {
			[Export ("mailComposeViewController", ArgumentSemantic.Weak)]
			get {
				global::MessageUI.MFMailComposeViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MessageUI.MFMailComposeViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mailComposeViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::MessageUI.MFMailComposeViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mailComposeViewController")));
				}
				MarkDirty ();
				__mt_MailComposeViewController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public new virtual PSPDFDocumentSharingOptions SharingOptions {
			[Export ("sharingOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDocumentSharingOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("sharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sharingOptions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sharingOptions"));
					}
				}
				return ret;
			}
			
			[Export ("setSharingOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setSharingOptions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setSharingOptions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_MailComposeViewController_var = null;
			}
		}
	} /* class PSPDFMailCoordinator */
}
