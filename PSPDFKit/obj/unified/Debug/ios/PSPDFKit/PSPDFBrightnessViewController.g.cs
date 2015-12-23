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
	[Register("PSPDFBrightnessViewController", true)]
	public unsafe partial class PSPDFBrightnessViewController : PSPDFBaseViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBrightnessViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBrightnessViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFBrightnessViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFBrightnessViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFBrightnessViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("removeDimmingView")]
		[CompilerGenerated]
		public virtual void RemoveDimmingView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeDimmingView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeDimmingView"));
			}
		}
		
		[CompilerGenerated]
		object __mt_AddDimmingView_var;
		[CompilerGenerated]
		public virtual PSPDFDimmingView AddDimmingView {
			[Export ("addDimmingView")]
			get {
				PSPDFDimmingView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDimmingView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("addDimmingView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDimmingView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("addDimmingView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AddDimmingView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat AdditionalBrightnessDimmingFactor {
			[Export ("additionalBrightnessDimmingFactor", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("additionalBrightnessDimmingFactor"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("additionalBrightnessDimmingFactor"));
				}
			}
			
			[Export ("setAdditionalBrightnessDimmingFactor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAdditionalBrightnessDimmingFactor:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAdditionalBrightnessDimmingFactor:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DimmingView_var;
		[CompilerGenerated]
		public virtual PSPDFDimmingView DimmingView {
			[Export ("dimmingView")]
			get {
				PSPDFDimmingView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDimmingView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dimmingView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDimmingView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dimmingView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DimmingView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat MaximumAdditionalBrightnessDimmingFactor {
			[Export ("maximumAdditionalBrightnessDimmingFactor", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maximumAdditionalBrightnessDimmingFactor"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumAdditionalBrightnessDimmingFactor"));
				}
			}
			
			[Export ("setMaximumAdditionalBrightnessDimmingFactor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMaximumAdditionalBrightnessDimmingFactor:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMaximumAdditionalBrightnessDimmingFactor:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Slider_var;
		[CompilerGenerated]
		public virtual global::UIKit.UISlider Slider {
			[Export ("slider", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UISlider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UISlider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("slider")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UISlider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("slider")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Slider_var = ret;
				return ret;
			}
			
			[Export ("setSlider:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSlider:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSlider:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Slider_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool WantsAdditionalSoftwareDimming {
			[Export ("wantsAdditionalSoftwareDimming", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wantsAdditionalSoftwareDimming"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("wantsAdditionalSoftwareDimming"));
				}
			}
			
			[Export ("setWantsAdditionalSoftwareDimming:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWantsAdditionalSoftwareDimming:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setWantsAdditionalSoftwareDimming:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool WantsSoftwareDimming {
			[Export ("wantsSoftwareDimming", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wantsSoftwareDimming"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("wantsSoftwareDimming"));
				}
			}
			
			[Export ("setWantsSoftwareDimming:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWantsSoftwareDimming:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setWantsSoftwareDimming:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AddDimmingView_var = null;
				__mt_DimmingView_var = null;
				__mt_Slider_var = null;
			}
		}
	} /* class PSPDFBrightnessViewController */
}
