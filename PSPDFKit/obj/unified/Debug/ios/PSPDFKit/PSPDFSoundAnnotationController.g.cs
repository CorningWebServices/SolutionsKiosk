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
	[Register("PSPDFSoundAnnotationController", true)]
	public unsafe partial class PSPDFSoundAnnotationController : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSoundAnnotationController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFSoundAnnotationController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSoundAnnotationController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSoundAnnotation:")]
		[CompilerGenerated]
		public PSPDFSoundAnnotationController (PSPDFSoundAnnotation annotation)
			: base (NSObjectFlag.Empty)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithSoundAnnotation:"), annotation.Handle), "initWithSoundAnnotation:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithSoundAnnotation:"), annotation.Handle), "initWithSoundAnnotation:");
			}
		}
		
		[Export ("discardRecording")]
		[CompilerGenerated]
		public virtual void DiscardRecording ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("discardRecording"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("discardRecording"));
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
		
		[Export ("requestRecordPermission:")]
		[CompilerGenerated]
		public unsafe static void RequestRecordPermission ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> hanlder)
		{
			BlockLiteral *block_ptr_hanlder;
			BlockLiteral block_hanlder;
			if (hanlder == null){
				block_ptr_hanlder = null;
			} else {
				block_hanlder = new BlockLiteral ();
				block_ptr_hanlder = &block_hanlder;
				block_hanlder.SetupBlock (Trampolines.SDActionArity1V1.Handler, hanlder);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("requestRecordPermission:"), (IntPtr) block_ptr_hanlder);
			if (block_ptr_hanlder != null)
				block_ptr_hanlder->CleanupBlock ();
			
		}
		
		[Export ("startPlayback:")]
		[CompilerGenerated]
		public virtual bool StartPlayback (out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_ref_IntPtr (this.Handle, Selector.GetHandle ("startPlayback:"), ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("startPlayback:"), ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("startRecording:")]
		[CompilerGenerated]
		public virtual bool StartRecording (out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_ref_IntPtr (this.Handle, Selector.GetHandle ("startRecording:"), ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("startRecording:"), ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("stop:")]
		[CompilerGenerated]
		public virtual bool Stop (out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_ref_IntPtr (this.Handle, Selector.GetHandle ("stop:"), ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("stop:"), ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("stopRecordingOrPlaybackForAllExcept:")]
		[CompilerGenerated]
		public static void StopRecordingOrPlaybackForAllExcept (NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("stopRecordingOrPlaybackForAllExcept:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[CompilerGenerated]
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFSoundAnnotation Annotation {
			[Export ("annotation", ArgumentSemantic.Weak)]
			get {
				PSPDFSoundAnnotation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSoundAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotation")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSoundAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotation")));
				}
				MarkDirty ();
				__mt_Annotation_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AudioPlayer_var;
		[CompilerGenerated]
		public virtual global::AVFoundation.AVAudioPlayer AudioPlayer {
			[Export ("audioPlayer", ArgumentSemantic.Retain)]
			get {
				global::AVFoundation.AVAudioPlayer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioPlayer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("audioPlayer")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioPlayer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("audioPlayer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AudioPlayer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFSoundAnnotationState State {
			[Export ("state", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFSoundAnnotationState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSoundAnnotationState) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					} else {
						ret = (PSPDFSoundAnnotationState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSoundAnnotationState) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					} else {
						ret = (PSPDFSoundAnnotationState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _ChangedStateNotification;
		[Field ("PSPDFSoundAnnotationChangedStateNotification",  "__Internal")]
		public static unsafe NSString ChangedStateNotification {
			get {
				if (_ChangedStateNotification == null)
					_ChangedStateNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFSoundAnnotationChangedStateNotification");
				return _ChangedStateNotification;
			}
		}
		[CompilerGenerated]
		static NSString _StopAllNotification;
		[Field ("PSPDFSoundAnnotationStopAllNotification",  "__Internal")]
		public static unsafe NSString StopAllNotification {
			get {
				if (_StopAllNotification == null)
					_StopAllNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFSoundAnnotationStopAllNotification");
				return _StopAllNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
				__mt_AudioPlayer_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveChangedState (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedStateNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveStopAll (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (StopAllNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFSoundAnnotationController */
}
