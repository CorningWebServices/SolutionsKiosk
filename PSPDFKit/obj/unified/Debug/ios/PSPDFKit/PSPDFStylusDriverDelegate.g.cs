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
	[Protocol (Name = "PSPDFStylusDriverDelegate", WrapperType = typeof (PSPDFStylusDriverDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConnectionStatusChanged", Selector = "connectionStatusChanged")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ButtonFired", Selector = "buttonFired:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClassificationsDidChangeForTouches", Selector = "classificationsDidChangeForTouches:", ParameterType = new Type [] { typeof (NSSet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StylusTouchBegan", Selector = "stylusTouchBegan:", ParameterType = new Type [] { typeof (NSSet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StylusTouchMoved", Selector = "stylusTouchMoved:", ParameterType = new Type [] { typeof (NSSet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StylusTouchEnded", Selector = "stylusTouchEnded:", ParameterType = new Type [] { typeof (NSSet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StylusTouchCancelled", Selector = "stylusTouchCancelled:", ParameterType = new Type [] { typeof (NSSet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StylusSuggestsToDisableGestures", Selector = "stylusSuggestsToDisableGestures")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StylusSuggestsToEnableGestures", Selector = "stylusSuggestsToEnableGestures")]
	public interface IPSPDFStylusDriverDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("connectionStatusChanged")]
		[Preserve (Conditional = true)]
		void ConnectionStatusChanged ();
		
	}
	
	public static partial class PSPDFStylusDriverDelegate_Extensions {
		[CompilerGenerated]
		public static void ButtonFired (this IPSPDFStylusDriverDelegate This, global::System.nuint buttonNumber)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("buttonFired:"), buttonNumber);
		}
		
		[CompilerGenerated]
		public static void ClassificationsDidChangeForTouches (this IPSPDFStylusDriverDelegate This, NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("classificationsDidChangeForTouches:"), touches.Handle);
		}
		
		[CompilerGenerated]
		public static void StylusTouchBegan (this IPSPDFStylusDriverDelegate This, NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("stylusTouchBegan:"), touches.Handle);
		}
		
		[CompilerGenerated]
		public static void StylusTouchMoved (this IPSPDFStylusDriverDelegate This, NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("stylusTouchMoved:"), touches.Handle);
		}
		
		[CompilerGenerated]
		public static void StylusTouchEnded (this IPSPDFStylusDriverDelegate This, NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("stylusTouchEnded:"), touches.Handle);
		}
		
		[CompilerGenerated]
		public static void StylusTouchCancelled (this IPSPDFStylusDriverDelegate This, NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("stylusTouchCancelled:"), touches.Handle);
		}
		
		[CompilerGenerated]
		public static void StylusSuggestsToDisableGestures (this IPSPDFStylusDriverDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("stylusSuggestsToDisableGestures"));
		}
		
		[CompilerGenerated]
		public static void StylusSuggestsToEnableGestures (this IPSPDFStylusDriverDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("stylusSuggestsToEnableGestures"));
		}
		
	}
	
	internal sealed class PSPDFStylusDriverDelegateWrapper : BaseWrapper, IPSPDFStylusDriverDelegate {
		public PSPDFStylusDriverDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFStylusDriverDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("connectionStatusChanged")]
		[CompilerGenerated]
		public void ConnectionStatusChanged ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatusChanged"));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFStylusDriverDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFStylusDriverDelegate : NSObject, IPSPDFStylusDriverDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFStylusDriverDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFStylusDriverDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStylusDriverDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("buttonFired:")]
		[CompilerGenerated]
		public virtual void ButtonFired (global::System.nuint buttonNumber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("classificationsDidChangeForTouches:")]
		[CompilerGenerated]
		public virtual void ClassificationsDidChangeForTouches (NSSet touches)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("connectionStatusChanged")]
		[CompilerGenerated]
		public abstract void ConnectionStatusChanged ();
		[Export ("stylusSuggestsToDisableGestures")]
		[CompilerGenerated]
		public virtual void StylusSuggestsToDisableGestures ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stylusSuggestsToEnableGestures")]
		[CompilerGenerated]
		public virtual void StylusSuggestsToEnableGestures ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stylusTouchBegan:")]
		[CompilerGenerated]
		public virtual void StylusTouchBegan (NSSet touches)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stylusTouchCancelled:")]
		[CompilerGenerated]
		public virtual void StylusTouchCancelled (NSSet touches)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stylusTouchEnded:")]
		[CompilerGenerated]
		public virtual void StylusTouchEnded (NSSet touches)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stylusTouchMoved:")]
		[CompilerGenerated]
		public virtual void StylusTouchMoved (NSSet touches)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFStylusDriverDelegate */
}
