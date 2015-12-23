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
	[Register("PSPDFOpenInCoordinator", true)]
	public unsafe partial class PSPDFOpenInCoordinator : PSPDFDocumentSharingCoordinator {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOpenInCoordinator");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOpenInCoordinator () : base (NSObjectFlag.Empty)
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
		protected PSPDFOpenInCoordinator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFOpenInCoordinator (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_DocumentInteractionController_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIDocumentInteractionController DocumentInteractionController {
			[Export ("documentInteractionController", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIDocumentInteractionController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIDocumentInteractionController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentInteractionController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIDocumentInteractionController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentInteractionController")));
				}
				MarkDirty ();
				__mt_DocumentInteractionController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _DidEndSendingToApplicationNotification;
		[Field ("PSPDFDocumentInteractionControllerDidEndSendingToApplicationNotification",  "__Internal")]
		public static unsafe NSString DidEndSendingToApplicationNotification {
			get {
				if (_DidEndSendingToApplicationNotification == null)
					_DidEndSendingToApplicationNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFDocumentInteractionControllerDidEndSendingToApplicationNotification");
				return _DidEndSendingToApplicationNotification;
			}
		}
		[CompilerGenerated]
		static NSString _WillBeginSendingToApplicationNotification;
		[Field ("PSPDFDocumentInteractionControllerWillBeginSendingToApplicationNotification",  "__Internal")]
		public static unsafe NSString WillBeginSendingToApplicationNotification {
			get {
				if (_WillBeginSendingToApplicationNotification == null)
					_WillBeginSendingToApplicationNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFDocumentInteractionControllerWillBeginSendingToApplicationNotification");
				return _WillBeginSendingToApplicationNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentInteractionController_var = null;
			}
		}
	} /* class PSPDFOpenInCoordinator */
}
