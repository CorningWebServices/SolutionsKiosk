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
	[Protocol (Name = "PSPDFMultimediaViewController", WrapperType = typeof (PSPDFMultimediaViewControllerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFullscreen", Selector = "isFullscreen", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTransitioning", Selector = "isTransitioning", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetZoomScale", Selector = "zoomScale", ReturnType = typeof (nfloat))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetOverrideDelegate", Selector = "overrideDelegate", ReturnType = typeof (PSPDFKit.IPSPDFOverridable))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetOverrideDelegate", Selector = "setOverrideDelegate:", ParameterType = new Type [] { typeof (PSPDFKit.IPSPDFOverridable) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFullscreen", Selector = "setFullscreen:animated:", ParameterType = new Type [] { typeof (bool), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformAction", Selector = "performAction:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Configure", Selector = "configure:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFConfiguration) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFMultimediaViewController : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setFullscreen:animated:")]
		[Preserve (Conditional = true)]
		void SetFullscreen (bool fullscreen, bool animated);
		
		[CompilerGenerated]
		[Export ("performAction:")]
		[Preserve (Conditional = true)]
		void PerformAction (PSPDFAction action);
		
	}
	
	public static partial class PSPDFMultimediaViewController_Extensions {
		[CompilerGenerated]
		public static bool GetFullscreen (this IPSPDFMultimediaViewController This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isFullscreen"));
		}
		
		[CompilerGenerated]
		public static bool GetTransitioning (this IPSPDFMultimediaViewController This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isTransitioning"));
		}
		
		[CompilerGenerated]
		public static global::System.nfloat GetZoomScale (this IPSPDFMultimediaViewController This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("zoomScale"));
		}
		
		[CompilerGenerated]
		public static IPSPDFOverridable GetOverrideDelegate (this IPSPDFMultimediaViewController This)
		{
			return  Runtime.GetINativeObject<IPSPDFOverridable> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("overrideDelegate")), false);
		}
		
		[CompilerGenerated]
		public static void SetOverrideDelegate (this IPSPDFMultimediaViewController This, IPSPDFOverridable overrideDelegate)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setOverrideDelegate:"), overrideDelegate == null ? IntPtr.Zero : overrideDelegate.Handle);
		}
		
		[CompilerGenerated]
		public static void Configure (this IPSPDFMultimediaViewController This, PSPDFConfiguration configuration)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("configure:"), configuration.Handle);
		}
		
	}
	
	internal sealed class PSPDFMultimediaViewControllerWrapper : BaseWrapper, IPSPDFMultimediaViewController {
		public PSPDFMultimediaViewControllerWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFMultimediaViewControllerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setFullscreen:animated:")]
		[CompilerGenerated]
		public void SetFullscreen (bool fullscreen, bool animated)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setFullscreen:animated:"), fullscreen, animated);
		}
		
		[Export ("performAction:")]
		[CompilerGenerated]
		public void PerformAction (PSPDFAction action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("performAction:"), action.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFMultimediaViewController", false)]
	[Model]
	public unsafe abstract partial class PSPDFMultimediaViewController : NSObject, IPSPDFMultimediaViewController {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFMultimediaViewController () : base (NSObjectFlag.Empty)
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
		protected PSPDFMultimediaViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMultimediaViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("configure:")]
		[CompilerGenerated]
		public virtual void Configure (PSPDFConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isFullscreen")]
		[CompilerGenerated]
		public virtual bool GetFullscreen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("overrideDelegate")]
		[CompilerGenerated]
		public virtual IPSPDFOverridable GetOverrideDelegate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isTransitioning")]
		[CompilerGenerated]
		public virtual bool GetTransitioning ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("zoomScale")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetZoomScale ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("performAction:")]
		[CompilerGenerated]
		public abstract void PerformAction (PSPDFAction action);
		[Export ("setFullscreen:animated:")]
		[CompilerGenerated]
		public abstract void SetFullscreen (bool fullscreen, bool animated);
		[Export ("setOverrideDelegate:")]
		[CompilerGenerated]
		public virtual void SetOverrideDelegate (IPSPDFOverridable overrideDelegate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFMultimediaViewController */
}
