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
	[Register("PSPDFMediaPlayerScrubberView", true)]
	public unsafe partial class PSPDFMediaPlayerScrubberView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMediaPlayerScrubberView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMediaPlayerScrubberView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFMediaPlayerScrubberView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFMediaPlayerScrubberView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMediaPlayerScrubberView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::CoreMedia.CMTime CurrentTime {
			[Export ("currentTime", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("currentTime"));
						} else {
							global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("currentTime"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("currentTime"));
					} else {
						global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("currentTime"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentTime"));
						} else {
							global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("currentTime"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("currentTime"));
					} else {
						global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("currentTime"));
					}
				}
				return ret;
			}
			
			[Export ("setCurrentTime:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CMTime (this.Handle, Selector.GetHandle ("setCurrentTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CMTime (this.SuperHandle, Selector.GetHandle ("setCurrentTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CurrentTimeLabel_var;
		[CompilerGenerated]
		public virtual global::UIKit.UILabel CurrentTimeLabel {
			[Export ("currentTimeLabel", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UILabel ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentTimeLabel")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentTimeLabel")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CurrentTimeLabel_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::CoreMedia.CMTime Duration {
			[Export ("duration", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("duration"));
						} else {
							global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("duration"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("duration"));
					} else {
						global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("duration"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("duration"));
						} else {
							global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("duration"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("duration"));
					} else {
						global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("duration"));
					}
				}
				return ret;
			}
			
			[Export ("setDuration:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CMTime (this.Handle, Selector.GetHandle ("setDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CMTime (this.SuperHandle, Selector.GetHandle ("setDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_RemainingTimeLabel_var;
		[CompilerGenerated]
		public virtual global::UIKit.UILabel RemainingTimeLabel {
			[Export ("remainingTimeLabel", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UILabel ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remainingTimeLabel")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remainingTimeLabel")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RemainingTimeLabel_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Slider_var;
		[CompilerGenerated]
		public virtual PSPDFMediaPlayerSlider Slider {
			[Export ("slider", ArgumentSemantic.Retain)]
			get {
				PSPDFMediaPlayerSlider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFMediaPlayerSlider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("slider")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFMediaPlayerSlider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("slider")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Slider_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CurrentTimeLabel_var = null;
				__mt_RemainingTimeLabel_var = null;
				__mt_Slider_var = null;
			}
		}
		public partial class PSPDFMediaPlayerScrubberViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFMediaPlayerScrubberViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFMediaPlayerScrubberViewAppearance Appearance {
			get { return new PSPDFMediaPlayerScrubberViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFMediaPlayerScrubberViewAppearance GetAppearance<T> () where T: PSPDFMediaPlayerScrubberView {
			return new PSPDFMediaPlayerScrubberViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFMediaPlayerScrubberViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFMediaPlayerScrubberViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFMediaPlayerScrubberViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFMediaPlayerScrubberViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFMediaPlayerScrubberViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFMediaPlayerScrubberViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFMediaPlayerScrubberViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFMediaPlayerScrubberView {
			return new PSPDFMediaPlayerScrubberViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFMediaPlayerScrubberViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFMediaPlayerScrubberView{
			return new PSPDFMediaPlayerScrubberViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFMediaPlayerScrubberView */
}
