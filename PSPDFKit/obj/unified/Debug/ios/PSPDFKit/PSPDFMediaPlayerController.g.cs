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
	[Register("PSPDFMediaPlayerController", true)]
	public unsafe partial class PSPDFMediaPlayerController : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMediaPlayerController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFMediaPlayerController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMediaPlayerController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithContentURL:")]
		[CompilerGenerated]
		public PSPDFMediaPlayerController (NSUrl contentUrl)
			: base (NSObjectFlag.Empty)
		{
			if (contentUrl == null)
				throw new ArgumentNullException ("contentUrl");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithContentURL:"), contentUrl.Handle), "initWithContentURL:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithContentURL:"), contentUrl.Handle), "initWithContentURL:");
			}
		}
		
		[Export ("pause")]
		[CompilerGenerated]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pause"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pause"));
			}
		}
		
		[Export ("pauseAllInstances")]
		[CompilerGenerated]
		public static void PauseAllInstances ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("pauseAllInstances"));
		}
		
		[Export ("play")]
		[CompilerGenerated]
		public virtual void Play ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("play"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("play"));
			}
		}
		
		[Export ("seekToTime:")]
		[CompilerGenerated]
		public virtual void SeekToTime (global::CoreMedia.CMTime time)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CMTime (this.Handle, Selector.GetHandle ("seekToTime:"), time);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CMTime (this.SuperHandle, Selector.GetHandle ("seekToTime:"), time);
			}
		}
		
		[Export ("setShouldHideToolbar:animated:")]
		[CompilerGenerated]
		public virtual void SetShouldHideToolbar (bool shouldHideToolbar, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setShouldHideToolbar:animated:"), shouldHideToolbar, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setShouldHideToolbar:animated:"), shouldHideToolbar, animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_ContentError_var;
		[CompilerGenerated]
		public virtual NSError ContentError {
			[Export ("contentError", ArgumentSemantic.Retain)]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentError")));
				} else {
					ret =  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentError")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentError_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFMediaPlayerControllerContentState ContentState {
			[Export ("contentState", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFMediaPlayerControllerContentState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFMediaPlayerControllerContentState) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("contentState"));
					} else {
						ret = (PSPDFMediaPlayerControllerContentState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("contentState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFMediaPlayerControllerContentState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentState"));
					} else {
						ret = (PSPDFMediaPlayerControllerContentState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentState"));
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
		public virtual PSPDFMediaPlayerControlStyle ControlStyle {
			[Export ("controlStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFMediaPlayerControlStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFMediaPlayerControlStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("controlStyle"));
					} else {
						ret = (PSPDFMediaPlayerControlStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("controlStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFMediaPlayerControlStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("controlStyle"));
					} else {
						ret = (PSPDFMediaPlayerControlStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("controlStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setControlStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setControlStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setControlStyle:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setControlStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setControlStyle:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::CoreMedia.CMTime CoverImagePreviewCaptureTime {
			[Export ("coverImagePreviewCaptureTime", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("coverImagePreviewCaptureTime"));
						} else {
							global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coverImagePreviewCaptureTime"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coverImagePreviewCaptureTime"));
					} else {
						global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coverImagePreviewCaptureTime"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coverImagePreviewCaptureTime"));
						} else {
							global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coverImagePreviewCaptureTime"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coverImagePreviewCaptureTime"));
					} else {
						global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coverImagePreviewCaptureTime"));
					}
				}
				return ret;
			}
			
			[Export ("setCoverImagePreviewCaptureTime:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CMTime (this.Handle, Selector.GetHandle ("setCoverImagePreviewCaptureTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CMTime (this.SuperHandle, Selector.GetHandle ("setCoverImagePreviewCaptureTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CoverImageUrl_var;
		[CompilerGenerated]
		public virtual NSUrl CoverImageUrl {
			[Export ("coverImageURL", ArgumentSemantic.Retain)]
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
			
			[Export ("setCoverImageURL:", ArgumentSemantic.Retain)]
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
		public virtual PSPDFMediaPlayerCoverMode CoverMode {
			[Export ("coverMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFMediaPlayerCoverMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFMediaPlayerCoverMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("coverMode"));
					} else {
						ret = (PSPDFMediaPlayerCoverMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("coverMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFMediaPlayerCoverMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coverMode"));
					} else {
						ret = (PSPDFMediaPlayerCoverMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coverMode"));
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
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFMediaPlayerControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFMediaPlayerControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFMediaPlayerControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFMediaPlayerControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		public virtual bool DidFinishPlaying {
			[Export ("didFinishPlaying", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("didFinishPlaying"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didFinishPlaying"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool DidStartPlaying {
			[Export ("didStartPlaying", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("didStartPlaying"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didStartPlaying"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ExternalPlaybackActive {
			[Export ("isExternalPlaybackActive", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isExternalPlaybackActive"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isExternalPlaybackActive"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_InternalPlayer_var;
		[CompilerGenerated]
		public virtual global::AVFoundation.AVPlayer InternalPlayer {
			[Export ("internalPlayer", ArgumentSemantic.Retain)]
			get {
				global::AVFoundation.AVPlayer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVPlayer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("internalPlayer")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVPlayer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("internalPlayer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_InternalPlayer_var = ret;
				return ret;
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
		public virtual global::CoreMedia.CMTimeRange PlayableRange {
			[Export ("playableRange", ArgumentSemantic.UnsafeUnretained)]
			get {
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
			
			[Export ("setPlayableRange:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CMTimeRange (this.Handle, Selector.GetHandle ("setPlayableRange:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CMTimeRange (this.SuperHandle, Selector.GetHandle ("setPlayableRange:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Playing {
			[Export ("isPlaying", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPlaying"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPlaying"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShouldHideToolbar {
			[Export ("shouldHideToolbar", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHideToolbar"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldHideToolbar"));
				}
			}
			
			[Export ("setShouldHideToolbar:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldHideToolbar:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldHideToolbar:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TapGestureRecognizer_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer TapGestureRecognizer {
			[Export ("tapGestureRecognizer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tapGestureRecognizer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tapGestureRecognizer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TapGestureRecognizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool UsesExternalPlaybackWhileExternalScreenIsActive {
			[Export ("usesExternalPlaybackWhileExternalScreenIsActive", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesExternalPlaybackWhileExternalScreenIsActive"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("usesExternalPlaybackWhileExternalScreenIsActive"));
				}
			}
			
			[Export ("setUsesExternalPlaybackWhileExternalScreenIsActive:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsesExternalPlaybackWhileExternalScreenIsActive:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUsesExternalPlaybackWhileExternalScreenIsActive:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContentError_var = null;
				__mt_ContentUrl_var = null;
				__mt_CoverImageUrl_var = null;
				__mt_Delegate_var = null;
				__mt_InternalPlayer_var = null;
				__mt_TapGestureRecognizer_var = null;
			}
		}
	} /* class PSPDFMediaPlayerController */
}
