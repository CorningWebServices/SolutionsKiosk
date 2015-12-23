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
	[Protocol (Name = "PSPDFMediaPlayerControllerDelegate", WrapperType = typeof (PSPDFMediaPlayerControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPauseOtherInstances", Selector = "mediaPlayerControllerShouldPauseOtherInstances:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMediaPlayerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartPlaying", Selector = "mediaPlayerControllerDidStartPlaying:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMediaPlayerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPause", Selector = "mediaPlayerControllerDidPause:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMediaPlayerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishPlaying", Selector = "mediaPlayerControllerDidFinishPlaying:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMediaPlayerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ExternalPlaybackActiveDidChange", Selector = "mediaPlayerController:externalPlaybackActiveDidChange:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMediaPlayerController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHideToolbar", Selector = "mediaPlayerController:didHideToolbar:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMediaPlayerController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContentStateDidChange", Selector = "mediaPlayerController:contentStateDidChange:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMediaPlayerController), typeof (PSPDFKit.PSPDFMediaPlayerControllerContentState) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFMediaPlayerControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFMediaPlayerControllerDelegate_Extensions {
		[CompilerGenerated]
		public static bool ShouldPauseOtherInstances (this IPSPDFMediaPlayerControllerDelegate This, PSPDFMediaPlayerController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mediaPlayerControllerShouldPauseOtherInstances:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void DidStartPlaying (this IPSPDFMediaPlayerControllerDelegate This, PSPDFMediaPlayerController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mediaPlayerControllerDidStartPlaying:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void DidPause (this IPSPDFMediaPlayerControllerDelegate This, PSPDFMediaPlayerController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mediaPlayerControllerDidPause:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFinishPlaying (this IPSPDFMediaPlayerControllerDelegate This, PSPDFMediaPlayerController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mediaPlayerControllerDidFinishPlaying:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void ExternalPlaybackActiveDidChange (this IPSPDFMediaPlayerControllerDelegate This, PSPDFMediaPlayerController controller, bool externalPlaybackActive)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("mediaPlayerController:externalPlaybackActiveDidChange:"), controller.Handle, externalPlaybackActive);
		}
		
		[CompilerGenerated]
		public static void DidHideToolbar (this IPSPDFMediaPlayerControllerDelegate This, PSPDFMediaPlayerController controller, bool hidden)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("mediaPlayerController:didHideToolbar:"), controller.Handle, hidden);
		}
		
		[CompilerGenerated]
		public static void ContentStateDidChange (this IPSPDFMediaPlayerControllerDelegate This, PSPDFMediaPlayerController controller, PSPDFMediaPlayerControllerContentState contentState)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("mediaPlayerController:contentStateDidChange:"), controller.Handle, (UInt64)contentState);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("mediaPlayerController:contentStateDidChange:"), controller.Handle, (UInt32)contentState);
			}
		}
		
	}
	
	internal sealed class PSPDFMediaPlayerControllerDelegateWrapper : BaseWrapper, IPSPDFMediaPlayerControllerDelegate {
		public PSPDFMediaPlayerControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFMediaPlayerControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFMediaPlayerControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFMediaPlayerControllerDelegate : NSObject, IPSPDFMediaPlayerControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMediaPlayerControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFMediaPlayerControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMediaPlayerControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("mediaPlayerController:contentStateDidChange:")]
		[CompilerGenerated]
		public virtual void ContentStateDidChange (PSPDFMediaPlayerController controller, PSPDFMediaPlayerControllerContentState contentState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mediaPlayerControllerDidFinishPlaying:")]
		[CompilerGenerated]
		public virtual void DidFinishPlaying (PSPDFMediaPlayerController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mediaPlayerController:didHideToolbar:")]
		[CompilerGenerated]
		public virtual void DidHideToolbar (PSPDFMediaPlayerController controller, bool hidden)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mediaPlayerControllerDidPause:")]
		[CompilerGenerated]
		public virtual void DidPause (PSPDFMediaPlayerController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mediaPlayerControllerDidStartPlaying:")]
		[CompilerGenerated]
		public virtual void DidStartPlaying (PSPDFMediaPlayerController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mediaPlayerController:externalPlaybackActiveDidChange:")]
		[CompilerGenerated]
		public virtual void ExternalPlaybackActiveDidChange (PSPDFMediaPlayerController controller, bool externalPlaybackActive)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mediaPlayerControllerShouldPauseOtherInstances:")]
		[CompilerGenerated]
		public virtual bool ShouldPauseOtherInstances (PSPDFMediaPlayerController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFMediaPlayerControllerDelegate */
}
