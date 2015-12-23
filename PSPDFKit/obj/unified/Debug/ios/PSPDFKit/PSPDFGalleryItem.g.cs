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
	[Register("PSPDFGalleryItem", true)]
	public unsafe partial class PSPDFGalleryItem : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGalleryItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFGalleryItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDictionary:")]
		[CompilerGenerated]
		public PSPDFGalleryItem (NSDictionary dictionary)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDictionary:"), dictionary == null ? IntPtr.Zero : dictionary.Handle), "initWithDictionary:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDictionary:"), dictionary == null ? IntPtr.Zero : dictionary.Handle), "initWithDictionary:");
			}
		}
		
		[Export ("initWithContentURL:caption:options:")]
		[CompilerGenerated]
		public PSPDFGalleryItem (NSUrl contentUrl, string caption, NSDictionary options)
			: base (NSObjectFlag.Empty)
		{
			if (contentUrl == null)
				throw new ArgumentNullException ("contentUrl");
			var nscaption = NSString.CreateNative (caption);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithContentURL:caption:options:"), contentUrl.Handle, nscaption, options == null ? IntPtr.Zero : options.Handle), "initWithContentURL:caption:options:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithContentURL:caption:options:"), contentUrl.Handle, nscaption, options == null ? IntPtr.Zero : options.Handle), "initWithContentURL:caption:options:");
			}
			NSString.ReleaseNative (nscaption);
			
		}
		
		[Export ("itemsFromJSONData:error:")]
		[CompilerGenerated]
		public static PSPDFGalleryItem[] FromJsonData (NSData data, out NSError error)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IntPtr errorValue = IntPtr.Zero;
			
			PSPDFGalleryItem[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFGalleryItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("itemsFromJSONData:error:"), data.Handle, ref errorValue));
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("itemFromLinkAnnotation:error:")]
		[CompilerGenerated]
		public static PSPDFGalleryItem FromLinkAnnotation (PSPDFLinkAnnotation annotation, out NSError error)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IntPtr errorValue = IntPtr.Zero;
			
			PSPDFGalleryItem ret;
			ret =  Runtime.GetNSObject<PSPDFGalleryItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("itemFromLinkAnnotation:error:"), annotation.Handle, ref errorValue));
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[CompilerGenerated]
		public virtual string Caption {
			[Export ("caption")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("caption")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("caption")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Content_var;
		[CompilerGenerated]
		public virtual NSObject Content {
			[Export ("content", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("content")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("content")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Content_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFGalleryItemContentState ContentState {
			[Export ("contentState", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFGalleryItemContentState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryItemContentState) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("contentState"));
					} else {
						ret = (PSPDFGalleryItemContentState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("contentState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryItemContentState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentState"));
					} else {
						ret = (PSPDFGalleryItemContentState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentState"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ContentUrl_var;
		[CompilerGenerated]
		public virtual NSUrl ContentUrl {
			[Export ("contentURL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentUrl_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ControlsEnabled {
			[Export ("controlsEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("controlsEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("controlsEnabled"));
				}
			}
			
			[Export ("setControlsEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setControlsEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setControlsEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Error_var;
		[CompilerGenerated]
		public virtual NSError Error {
			[Export ("error", ArgumentSemantic.Retain)]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("error")));
				} else {
					ret =  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("error")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Error_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Options_var;
		[CompilerGenerated]
		public virtual NSDictionary Options {
			[Export ("options", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("options")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("options")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Options_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Progress {
			[Export ("progress", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("progress"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progress"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ValidContent {
			[Export ("hasValidContent", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasValidContent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasValidContent"));
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _ContentStateDidChangeNotification;
		[Field ("PSPDFGalleryItemContentStateDidChangeNotification",  "__Internal")]
		public static unsafe NSString ContentStateDidChangeNotification {
			get {
				if (_ContentStateDidChangeNotification == null)
					_ContentStateDidChangeNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFGalleryItemContentStateDidChangeNotification");
				return _ContentStateDidChangeNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Content_var = null;
				__mt_ContentUrl_var = null;
				__mt_Error_var = null;
				__mt_Options_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveContentStateDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ContentStateDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFGalleryItem */
}
