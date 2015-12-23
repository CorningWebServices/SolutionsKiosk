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
	[Register("PSPDFSoundAnnotation", true)]
	public unsafe partial class PSPDFSoundAnnotation : PSPDFAnnotation {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSoundAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFSoundAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFSoundAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSoundAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initRecorder")]
		[CompilerGenerated]
		public PSPDFSoundAnnotation ()
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("initRecorder")), "initRecorder");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("initRecorder")), "initRecorder");
			}
		}
		
		[Export ("initWithRate:channels:bits:encoding:")]
		[CompilerGenerated]
		public PSPDFSoundAnnotation (global::System.nuint rate, global::System.nuint channels, global::System.nuint bits, NSString soundAnnotationEncoding)
			: base (NSObjectFlag.Empty)
		{
			if (soundAnnotationEncoding == null)
				throw new ArgumentNullException ("soundAnnotationEncoding");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_IntPtr (this.Handle, Selector.GetHandle ("initWithRate:channels:bits:encoding:"), rate, channels, bits, soundAnnotationEncoding.Handle), "initWithRate:channels:bits:encoding:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRate:channels:bits:encoding:"), rate, channels, bits, soundAnnotationEncoding.Handle), "initWithRate:channels:bits:encoding:");
			}
		}
		
		[Export ("initWithURL:error:")]
		[CompilerGenerated]
		public PSPDFSoundAnnotation (NSUrl soundUrl, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			if (soundUrl == null)
				throw new ArgumentNullException ("soundUrl");
			IntPtr errorValue = IntPtr.Zero;
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("initWithURL:error:"), soundUrl.Handle, ref errorValue), "initWithURL:error:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURL:error:"), soundUrl.Handle, ref errorValue), "initWithURL:error:");
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
		}
		
		[Export ("loadAttributesFromAudioFile:")]
		[CompilerGenerated]
		internal virtual bool LoadAttributesFromAudioFile (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadAttributesFromAudioFile:"), error);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadAttributesFromAudioFile:"), error);
			}
		}
		
		[Export ("soundData")]
		[CompilerGenerated]
		public virtual NSData SoundData ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("soundData")));
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("soundData")));
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Bits {
			[Export ("bits", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("bits"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bits"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CanRecord {
			[Export ("canRecord", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canRecord"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canRecord"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Channels {
			[Export ("channels", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("channels"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("channels"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Controller_var;
		[CompilerGenerated]
		public virtual PSPDFSoundAnnotationController Controller {
			[Export ("controller", ArgumentSemantic.Retain)]
			get {
				PSPDFSoundAnnotationController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSoundAnnotationController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("controller")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSoundAnnotationController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("controller")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Controller_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Encoding_var;
		[CompilerGenerated]
		public virtual NSString Encoding {
			[Export ("encoding")]
			get {
				NSString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("encoding")));
				} else {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("encoding")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Encoding_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string IconName {
			[Export ("iconName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("iconName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("iconName")));
				}
			}
			
			[Export ("setIconName:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIconName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setIconName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Rate {
			[Export ("rate", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("rate"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rate"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SoundUrl_var;
		[CompilerGenerated]
		public virtual NSUrl SoundUrl {
			[Export ("soundURL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("soundURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("soundURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SoundUrl_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Controller_var = null;
				__mt_Encoding_var = null;
				__mt_SoundUrl_var = null;
			}
		}
	} /* class PSPDFSoundAnnotation */
}
