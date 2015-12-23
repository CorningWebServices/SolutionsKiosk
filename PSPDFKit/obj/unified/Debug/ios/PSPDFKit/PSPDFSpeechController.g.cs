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
	[Register("PSPDFSpeechController", true)]
	public unsafe partial class PSPDFSpeechController : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSpeechController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSpeechController () : base (NSObjectFlag.Empty)
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
		protected PSPDFSpeechController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSpeechController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("speakText:options:delegate:")]
		[CompilerGenerated]
		public virtual void Speak (string speechString, NSDictionary options, global::AVFoundation.IAVSpeechSynthesizerDelegate aDelegate)
		{
			if (speechString == null)
				throw new ArgumentNullException ("speechString");
			var nsspeechString = NSString.CreateNative (speechString);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("speakText:options:delegate:"), nsspeechString, options == null ? IntPtr.Zero : options.Handle, aDelegate == null ? IntPtr.Zero : aDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("speakText:options:delegate:"), nsspeechString, options == null ? IntPtr.Zero : options.Handle, aDelegate == null ? IntPtr.Zero : aDelegate.Handle);
			}
			NSString.ReleaseNative (nsspeechString);
			
		}
		
		[Export ("stopSpeakingForDelegate:")]
		[CompilerGenerated]
		public virtual bool StopSpeaking (global::AVFoundation.IAVSpeechSynthesizerDelegate aDelegate)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stopSpeakingForDelegate:"), aDelegate == null ? IntPtr.Zero : aDelegate.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stopSpeakingForDelegate:"), aDelegate == null ? IntPtr.Zero : aDelegate.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string[] LanguageCodes {
			[Export ("languageCodes", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("languageCodes")));
				} else {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("languageCodes")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float PitchMultiplier {
			[Export ("pitchMultiplier", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("pitchMultiplier"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pitchMultiplier"));
				}
			}
			
			[Export ("setPitchMultiplier:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setPitchMultiplier:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setPitchMultiplier:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectedLanguage_var;
		[CompilerGenerated]
		public virtual NSString SelectedLanguage {
			[Export ("selectedLanguage")]
			get {
				NSString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedLanguage")));
				} else {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedLanguage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedLanguage_var = ret;
				return ret;
			}
			
			[Export ("setSelectedLanguage:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedLanguage:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedLanguage:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedLanguage_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float SpeakRate {
			[Export ("speakRate", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("speakRate"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("speakRate"));
				}
			}
			
			[Export ("setSpeakRate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setSpeakRate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setSpeakRate:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SpeechSynthesizer_var;
		[CompilerGenerated]
		public virtual global::AVFoundation.AVSpeechSynthesizer SpeechSynthesizer {
			[Export ("speechSynthesizer", ArgumentSemantic.Retain)]
			get {
				global::AVFoundation.AVSpeechSynthesizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVSpeechSynthesizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("speechSynthesizer")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVSpeechSynthesizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("speechSynthesizer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SpeechSynthesizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _AutoDetectLanguage;
		[Field ("PSPDFSpeechSynthesizerAutoDetectLanguage",  "__Internal")]
		public static unsafe NSString AutoDetectLanguage {
			get {
				if (_AutoDetectLanguage == null)
					_AutoDetectLanguage = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFSpeechSynthesizerAutoDetectLanguage");
				return _AutoDetectLanguage;
			}
		}
		[CompilerGenerated]
		static NSString _LanguageHintKey;
		[Field ("PSPDFSpeechSynthesizerLanguageHintKey",  "__Internal")]
		public static unsafe NSString LanguageHintKey {
			get {
				if (_LanguageHintKey == null)
					_LanguageHintKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFSpeechSynthesizerLanguageHintKey");
				return _LanguageHintKey;
			}
		}
		[CompilerGenerated]
		static NSString _LanguageKey;
		[Field ("PSPDFSpeechSynthesizerLanguageKey",  "__Internal")]
		public static unsafe NSString LanguageKey {
			get {
				if (_LanguageKey == null)
					_LanguageKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFSpeechSynthesizerLanguageKey");
				return _LanguageKey;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SelectedLanguage_var = null;
				__mt_SpeechSynthesizer_var = null;
			}
		}
	} /* class PSPDFSpeechController */
}
