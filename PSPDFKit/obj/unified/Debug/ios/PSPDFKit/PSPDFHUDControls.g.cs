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
	[Protocol (Name = "PSPDFHUDControls", WrapperType = typeof (PSPDFHUDControlsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HideControls", Selector = "hideControlsAnimated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HideControlsForUserScrollAction", Selector = "hideControlsForUserScrollActionAnimated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HideControlsAndPageElements", Selector = "hideControlsAndPageElementsAnimated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ToggleControls", Selector = "toggleControlsAnimated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldShowControls", Selector = "shouldShowControls", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShowControls", Selector = "showControlsAnimated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShowMenuIfSelected", Selector = "showMenuIfSelectedAnimated:allowPopovers:", ParameterType = new Type [] { typeof (bool), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFHUDControls : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("hideControlsAnimated:")]
		[Preserve (Conditional = true)]
		bool HideControls (bool animated);
		
		[CompilerGenerated]
		[Export ("hideControlsForUserScrollActionAnimated:")]
		[Preserve (Conditional = true)]
		bool HideControlsForUserScrollAction (bool animated);
		
		[CompilerGenerated]
		[Export ("hideControlsAndPageElementsAnimated:")]
		[Preserve (Conditional = true)]
		bool HideControlsAndPageElements (bool animated);
		
		[CompilerGenerated]
		[Export ("toggleControlsAnimated:")]
		[Preserve (Conditional = true)]
		bool ToggleControls (bool animated);
		
		[CompilerGenerated]
		[Export ("shouldShowControls")]
		[Preserve (Conditional = true)]
		bool ShouldShowControls ();
		
		[CompilerGenerated]
		[Export ("showControlsAnimated:")]
		[Preserve (Conditional = true)]
		bool ShowControls (bool animated);
		
		[CompilerGenerated]
		[Export ("showMenuIfSelectedAnimated:allowPopovers:")]
		[Preserve (Conditional = true)]
		void ShowMenuIfSelected (bool animated, bool allowPopovers);
		
	}
	
	internal sealed class PSPDFHUDControlsWrapper : BaseWrapper, IPSPDFHUDControls {
		public PSPDFHUDControlsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFHUDControlsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("hideControlsAnimated:")]
		[CompilerGenerated]
		public bool HideControls (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideControlsAnimated:"), animated);
		}
		
		[Export ("hideControlsForUserScrollActionAnimated:")]
		[CompilerGenerated]
		public bool HideControlsForUserScrollAction (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideControlsForUserScrollActionAnimated:"), animated);
		}
		
		[Export ("hideControlsAndPageElementsAnimated:")]
		[CompilerGenerated]
		public bool HideControlsAndPageElements (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideControlsAndPageElementsAnimated:"), animated);
		}
		
		[Export ("toggleControlsAnimated:")]
		[CompilerGenerated]
		public bool ToggleControls (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("toggleControlsAnimated:"), animated);
		}
		
		[Export ("shouldShowControls")]
		[CompilerGenerated]
		public bool ShouldShowControls ()
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldShowControls"));
		}
		
		[Export ("showControlsAnimated:")]
		[CompilerGenerated]
		public bool ShowControls (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("showControlsAnimated:"), animated);
		}
		
		[Export ("showMenuIfSelectedAnimated:allowPopovers:")]
		[CompilerGenerated]
		public void ShowMenuIfSelected (bool animated, bool allowPopovers)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("showMenuIfSelectedAnimated:allowPopovers:"), animated, allowPopovers);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFHUDControls", false)]
	[Model]
	public unsafe abstract partial class PSPDFHUDControls : NSObject, IPSPDFHUDControls {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFHUDControls () : base (NSObjectFlag.Empty)
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
		protected PSPDFHUDControls (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFHUDControls (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hideControlsAnimated:")]
		[CompilerGenerated]
		public abstract bool HideControls (bool animated);
		[Export ("hideControlsAndPageElementsAnimated:")]
		[CompilerGenerated]
		public abstract bool HideControlsAndPageElements (bool animated);
		[Export ("hideControlsForUserScrollActionAnimated:")]
		[CompilerGenerated]
		public abstract bool HideControlsForUserScrollAction (bool animated);
		[Export ("shouldShowControls")]
		[CompilerGenerated]
		public abstract bool ShouldShowControls ();
		[Export ("showControlsAnimated:")]
		[CompilerGenerated]
		public abstract bool ShowControls (bool animated);
		[Export ("showMenuIfSelectedAnimated:allowPopovers:")]
		[CompilerGenerated]
		public abstract void ShowMenuIfSelected (bool animated, bool allowPopovers);
		[Export ("toggleControlsAnimated:")]
		[CompilerGenerated]
		public abstract bool ToggleControls (bool animated);
	} /* class PSPDFHUDControls */
}
