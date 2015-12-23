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
	[Protocol (Name = "PSPDFColorSelectionViewControllerDelegate", WrapperType = typeof (PSPDFColorSelectionViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectedColor", Selector = "colorSelectionControllerSelectedColor:context:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (UIViewController), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectColor", Selector = "colorSelectionController:didSelectColor:finishedSelection:context:", ParameterType = new Type [] { typeof (UIViewController), typeof (UIColor), typeof (bool), typeof (CGContext) }, ParameterByRef = new bool [] { false, false, false, false })]
	public interface IPSPDFColorSelectionViewControllerDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("colorSelectionControllerSelectedColor:context:")]
		[Preserve (Conditional = true)]
		global::UIKit.UIColor SelectedColor (global::UIKit.UIViewController controller, NSObject context);
		
		[CompilerGenerated]
		[Export ("colorSelectionController:didSelectColor:finishedSelection:context:")]
		[Preserve (Conditional = true)]
		void DidSelectColor (global::UIKit.UIViewController controller, global::UIKit.UIColor color, bool finished, CGContext context);
		
	}
	
	internal sealed class PSPDFColorSelectionViewControllerDelegateWrapper : BaseWrapper, IPSPDFColorSelectionViewControllerDelegate {
		public PSPDFColorSelectionViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFColorSelectionViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("colorSelectionControllerSelectedColor:context:")]
		[CompilerGenerated]
		public global::UIKit.UIColor SelectedColor (global::UIKit.UIViewController controller, NSObject context)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("colorSelectionControllerSelectedColor:context:"), controller.Handle, context.Handle));
		}
		
		[Export ("colorSelectionController:didSelectColor:finishedSelection:context:")]
		[CompilerGenerated]
		public void DidSelectColor (global::UIKit.UIViewController controller, global::UIKit.UIColor color, bool finished, CGContext context)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (color == null)
				throw new ArgumentNullException ("color");
			if (context == null)
				throw new ArgumentNullException ("context");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("colorSelectionController:didSelectColor:finishedSelection:context:"), controller.Handle, color.Handle, finished, context.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFColorSelectionViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFColorSelectionViewControllerDelegate : NSObject, IPSPDFColorSelectionViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFColorSelectionViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFColorSelectionViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFColorSelectionViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("colorSelectionController:didSelectColor:finishedSelection:context:")]
		[CompilerGenerated]
		public abstract void DidSelectColor (global::UIKit.UIViewController controller, global::UIKit.UIColor color, bool finished, CGContext context);
		[Export ("colorSelectionControllerSelectedColor:context:")]
		[CompilerGenerated]
		public abstract global::UIKit.UIColor SelectedColor (global::UIKit.UIViewController controller, NSObject context);
	} /* class PSPDFColorSelectionViewControllerDelegate */
}
