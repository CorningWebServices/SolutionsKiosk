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
	[Protocol (Name = "PSPDFPasswordViewDelegate", WrapperType = typeof (PSPDFPasswordViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUnlock", Selector = "passwordView:didUnlockWithPassword:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFPasswordView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToUnlock", Selector = "passwordView:didFailToUnlockWithPassword:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFPasswordView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUnlock", Selector = "passwordView:shouldUnlockWithPassword:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFPasswordView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUnlock", Selector = "passwordView:willUnlockWithPassword:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFPasswordView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFPasswordViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("passwordView:didUnlockWithPassword:")]
		[Preserve (Conditional = true)]
		void DidUnlock (PSPDFPasswordView passwordView, string password);
		
	}
	
	public static partial class PSPDFPasswordViewDelegate_Extensions {
		[CompilerGenerated]
		public static void DidFailToUnlock (this IPSPDFPasswordViewDelegate This, PSPDFPasswordView passwordView, string password)
		{
			if (passwordView == null)
				throw new ArgumentNullException ("passwordView");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("passwordView:didFailToUnlockWithPassword:"), passwordView.Handle, nspassword);
			NSString.ReleaseNative (nspassword);
			
		}
		
		[CompilerGenerated]
		public static bool ShouldUnlock (this IPSPDFPasswordViewDelegate This, PSPDFPasswordView passwordView, string password)
		{
			if (passwordView == null)
				throw new ArgumentNullException ("passwordView");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("passwordView:shouldUnlockWithPassword:"), passwordView.Handle, nspassword);
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void WillUnlock (this IPSPDFPasswordViewDelegate This, PSPDFPasswordView passwordView, string password)
		{
			if (passwordView == null)
				throw new ArgumentNullException ("passwordView");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("passwordView:willUnlockWithPassword:"), passwordView.Handle, nspassword);
			NSString.ReleaseNative (nspassword);
			
		}
		
	}
	
	internal sealed class PSPDFPasswordViewDelegateWrapper : BaseWrapper, IPSPDFPasswordViewDelegate {
		public PSPDFPasswordViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFPasswordViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("passwordView:didUnlockWithPassword:")]
		[CompilerGenerated]
		public void DidUnlock (PSPDFPasswordView passwordView, string password)
		{
			if (passwordView == null)
				throw new ArgumentNullException ("passwordView");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("passwordView:didUnlockWithPassword:"), passwordView.Handle, nspassword);
			NSString.ReleaseNative (nspassword);
			
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFPasswordViewDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFPasswordViewDelegate : NSObject, IPSPDFPasswordViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFPasswordViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFPasswordViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPasswordViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("passwordView:didFailToUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual void DidFailToUnlock (PSPDFPasswordView passwordView, string password)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("passwordView:didUnlockWithPassword:")]
		[CompilerGenerated]
		public abstract void DidUnlock (PSPDFPasswordView passwordView, string password);
		[Export ("passwordView:shouldUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual bool ShouldUnlock (PSPDFPasswordView passwordView, string password)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("passwordView:willUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual void WillUnlock (PSPDFPasswordView passwordView, string password)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFPasswordViewDelegate */
}
