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
	[Protocol (Name = "PSPDFTabBarViewDataSource", WrapperType = typeof (PSPDFTabBarViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfTabsInTabBarView", Selector = "numberOfTabsInTabBarView:", ReturnType = typeof (nint), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabBarView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TitleForTabAtIndex", Selector = "tabBarView:titleForTabAtIndex:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabBarView), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFTabBarViewDataSource : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("numberOfTabsInTabBarView:")]
		[Preserve (Conditional = true)]
		global::System.nint NumberOfTabsInTabBarView (PSPDFTabBarView tabBarView);
		
		[CompilerGenerated]
		[Export ("tabBarView:titleForTabAtIndex:")]
		[Preserve (Conditional = true)]
		string TitleForTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index);
		
	}
	
	internal sealed class PSPDFTabBarViewDataSourceWrapper : BaseWrapper, IPSPDFTabBarViewDataSource {
		public PSPDFTabBarViewDataSourceWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFTabBarViewDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("numberOfTabsInTabBarView:")]
		[CompilerGenerated]
		public global::System.nint NumberOfTabsInTabBarView (PSPDFTabBarView tabBarView)
		{
			if (tabBarView == null)
				throw new ArgumentNullException ("tabBarView");
			return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("numberOfTabsInTabBarView:"), tabBarView.Handle);
		}
		
		[Export ("tabBarView:titleForTabAtIndex:")]
		[CompilerGenerated]
		public string TitleForTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index)
		{
			if (tabBarView == null)
				throw new ArgumentNullException ("tabBarView");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("tabBarView:titleForTabAtIndex:"), tabBarView.Handle, index));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFTabBarViewDataSource", false)]
	[Model]
	public unsafe abstract partial class PSPDFTabBarViewDataSource : NSObject, IPSPDFTabBarViewDataSource {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFTabBarViewDataSource () : base (NSObjectFlag.Empty)
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
		protected PSPDFTabBarViewDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTabBarViewDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("numberOfTabsInTabBarView:")]
		[CompilerGenerated]
		public abstract global::System.nint NumberOfTabsInTabBarView (PSPDFTabBarView tabBarView);
		[Export ("tabBarView:titleForTabAtIndex:")]
		[CompilerGenerated]
		public abstract string TitleForTabAtIndex (PSPDFTabBarView tabBarView, global::System.nuint index);
	} /* class PSPDFTabBarViewDataSource */
}
