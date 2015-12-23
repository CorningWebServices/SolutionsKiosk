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
	[Protocol (Name = "PSPDFTabBarViewDelegate", WrapperType = typeof (PSPDFTabBarViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectTabAtIndex", Selector = "tabBarView:didSelectTabAtIndex:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabBarView), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectCloseButtonOfTabAtIndex", Selector = "tabBarView:didSelectCloseButtonOfTabAtIndex:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabBarView), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFTabBarViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("tabBarView:didSelectTabAtIndex:")]
		[Preserve (Conditional = true)]
		void DidSelectTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index);
		
		[CompilerGenerated]
		[Export ("tabBarView:didSelectCloseButtonOfTabAtIndex:")]
		[Preserve (Conditional = true)]
		void DidSelectCloseButtonOfTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index);
		
	}
	
	internal sealed class PSPDFTabBarViewDelegateWrapper : BaseWrapper, IPSPDFTabBarViewDelegate {
		public PSPDFTabBarViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFTabBarViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("tabBarView:didSelectTabAtIndex:")]
		[CompilerGenerated]
		public void DidSelectTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index)
		{
			if (tabBarView == null)
				throw new ArgumentNullException ("tabBarView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("tabBarView:didSelectTabAtIndex:"), tabBarView.Handle, index);
		}
		
		[Export ("tabBarView:didSelectCloseButtonOfTabAtIndex:")]
		[CompilerGenerated]
		public void DidSelectCloseButtonOfTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index)
		{
			if (tabBarView == null)
				throw new ArgumentNullException ("tabBarView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("tabBarView:didSelectCloseButtonOfTabAtIndex:"), tabBarView.Handle, index);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFTabBarViewDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFTabBarViewDelegate : NSObject, IPSPDFTabBarViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFTabBarViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFTabBarViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTabBarViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("tabBarView:didSelectCloseButtonOfTabAtIndex:")]
		[CompilerGenerated]
		public abstract void DidSelectCloseButtonOfTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index);
		[Export ("tabBarView:didSelectTabAtIndex:")]
		[CompilerGenerated]
		public abstract void DidSelectTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index);
	} /* class PSPDFTabBarViewDelegate */
}
