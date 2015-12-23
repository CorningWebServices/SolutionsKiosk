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
	[Register("PSPDFGalleryVideoItem", true)]
	public unsafe partial class PSPDFGalleryVideoItem : PSPDFGalleryItem {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGalleryVideoItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFGalleryVideoItem () : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryVideoItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryVideoItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("content")]
		[CompilerGenerated]
		public new virtual NSUrl Content ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("content")));
			} else {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("content")));
			}
		}
		
		[Export ("playableRange")]
		[CompilerGenerated]
		public virtual global::CoreMedia.CMTimeRange PlayableRange ()
		{
			global::CoreMedia.CMTimeRange ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CMTimeRange_objc_msgSend (this.Handle, Selector.GetHandle ("playableRange"));
					} else {
						global::ApiDefinition.Messaging.CMTimeRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("playableRange"));
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CMTimeRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("playableRange"));
				} else {
					global::ApiDefinition.Messaging.CMTimeRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("playableRange"));
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CMTimeRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playableRange"));
					} else {
						global::ApiDefinition.Messaging.CMTimeRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("playableRange"));
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CMTimeRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("playableRange"));
				} else {
					global::ApiDefinition.Messaging.CMTimeRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("playableRange"));
				}
			}
			return ret;
		}
		
		[CompilerGenerated]
		public virtual bool AutoplayEnabled {
			[Export ("autoplayEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoplayEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("autoplayEnabled"));
				}
			}
			
			[Export ("setAutoplayEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoplayEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutoplayEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CoverImageUrl_var;
		[CompilerGenerated]
		public virtual NSUrl CoverImageUrl {
			[Export ("coverImageURL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("coverImageURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coverImageURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CoverImageUrl_var = ret;
				return ret;
			}
			
			[Export ("setCoverImageURL:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCoverImageURL:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCoverImageURL:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CoverImageUrl_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFGalleryVideoItemCoverMode CoverMode {
			[Export ("coverMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFGalleryVideoItemCoverMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryVideoItemCoverMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("coverMode"));
					} else {
						ret = (PSPDFGalleryVideoItemCoverMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("coverMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFGalleryVideoItemCoverMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coverMode"));
					} else {
						ret = (PSPDFGalleryVideoItemCoverMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coverMode"));
					}
				}
				return ret;
			}
			
			[Export ("setCoverMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setCoverMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setCoverMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setCoverMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setCoverMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CoverPreviewCaptureTime_var;
		[CompilerGenerated]
		public virtual NSNumber CoverPreviewCaptureTime {
			[Export ("coverPreviewCaptureTime", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("coverPreviewCaptureTime")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coverPreviewCaptureTime")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CoverPreviewCaptureTime_var = ret;
				return ret;
			}
			
			[Export ("setCoverPreviewCaptureTime:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCoverPreviewCaptureTime:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCoverPreviewCaptureTime:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CoverPreviewCaptureTime_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_EndTime_var;
		[CompilerGenerated]
		public virtual NSNumber EndTime {
			[Export ("endTime", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("endTime")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endTime")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_EndTime_var = ret;
				return ret;
			}
			
			[Export ("setEndTime:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEndTime:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEndTime:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_EndTime_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool LoopEnabled {
			[Export ("loopEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("loopEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loopEnabled"));
				}
			}
			
			[Export ("setLoopEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLoopEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLoopEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string[] PreferredVideoQualities {
			[Export ("preferredVideoQualities", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredVideoQualities")));
				} else {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("preferredVideoQualities")));
				}
			}
			
			[Export ("setPreferredVideoQualities:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPreferredVideoQualities:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPreferredVideoQualities:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double SeekTime {
			[Export ("seekTime", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("seekTime"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("seekTime"));
				}
			}
			
			[Export ("setSeekTime:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setSeekTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setSeekTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_StartTime_var;
		[CompilerGenerated]
		public virtual NSNumber StartTime {
			[Export ("startTime", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("startTime")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startTime")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_StartTime_var = ret;
				return ret;
			}
			
			[Export ("setStartTime:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStartTime:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStartTime:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_StartTime_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CoverImageUrl_var = null;
				__mt_CoverPreviewCaptureTime_var = null;
				__mt_EndTime_var = null;
				__mt_StartTime_var = null;
			}
		}
	} /* class PSPDFGalleryVideoItem */
}
