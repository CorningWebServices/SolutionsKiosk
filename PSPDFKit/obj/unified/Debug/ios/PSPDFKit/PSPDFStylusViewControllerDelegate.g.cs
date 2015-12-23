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
	[Protocol (Name = "PSPDFStylusViewControllerDelegate", WrapperType = typeof (PSPDFStylusViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StylusViewControllerDidUpdateSelectedType", Selector = "stylusViewControllerDidUpdateSelectedType:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFStylusViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StylusViewControllerDidTapSettingsButton", Selector = "stylusViewControllerDidTapSettingsButton:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFStylusViewController) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFStylusViewControllerDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("stylusViewControllerDidUpdateSelectedType:")]
		[Preserve (Conditional = true)]
		void StylusViewControllerDidUpdateSelectedType (PSPDFStylusViewController stylusViewController);
		
		[CompilerGenerated]
		[Export ("stylusViewControllerDidTapSettingsButton:")]
		[Preserve (Conditional = true)]
		void StylusViewControllerDidTapSettingsButton (PSPDFStylusViewController stylusViewController);
		
	}
	
	internal sealed class PSPDFStylusViewControllerDelegateWrapper : BaseWrapper, IPSPDFStylusViewControllerDelegate {
		public PSPDFStylusViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFStylusViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("stylusViewControllerDidUpdateSelectedType:")]
		[CompilerGenerated]
		public void StylusViewControllerDidUpdateSelectedType (PSPDFStylusViewController stylusViewController)
		{
			if (stylusViewController == null)
				throw new ArgumentNullException ("stylusViewController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stylusViewControllerDidUpdateSelectedType:"), stylusViewController.Handle);
		}
		
		[Export ("stylusViewControllerDidTapSettingsButton:")]
		[CompilerGenerated]
		public void StylusViewControllerDidTapSettingsButton (PSPDFStylusViewController stylusViewController)
		{
			if (stylusViewController == null)
				throw new ArgumentNullException ("stylusViewController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stylusViewControllerDidTapSettingsButton:"), stylusViewController.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFStylusViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFStylusViewControllerDelegate : NSObject, IPSPDFStylusViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFStylusViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFStylusViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStylusViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("stylusViewControllerDidTapSettingsButton:")]
		[CompilerGenerated]
		public abstract void StylusViewControllerDidTapSettingsButton (PSPDFStylusViewController stylusViewController);
		[Export ("stylusViewControllerDidUpdateSelectedType:")]
		[CompilerGenerated]
		public abstract void StylusViewControllerDidUpdateSelectedType (PSPDFStylusViewController stylusViewController);
	} /* class PSPDFStylusViewControllerDelegate */
}
