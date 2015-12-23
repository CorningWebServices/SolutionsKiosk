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
	[Protocol (Name = "PSPDFFontPickerViewControllerDelegate", WrapperType = typeof (PSPDFFontPickerViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectFont", Selector = "fontPickerViewController:didSelectFont:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFontPickerViewController), typeof (UIFont) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFFontPickerViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
		[CompilerGenerated]
		[Export ("fontPickerViewController:didSelectFont:")]
		[Preserve (Conditional = true)]
		void DidSelectFont (PSPDFFontPickerViewController fontPickerViewController, global::UIKit.UIFont selectedFont);
		
	}
	
	internal sealed class PSPDFFontPickerViewControllerDelegateWrapper : BaseWrapper, IPSPDFFontPickerViewControllerDelegate {
		public PSPDFFontPickerViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFFontPickerViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("fontPickerViewController:didSelectFont:")]
		[CompilerGenerated]
		public void DidSelectFont (PSPDFFontPickerViewController fontPickerViewController, global::UIKit.UIFont selectedFont)
		{
			if (fontPickerViewController == null)
				throw new ArgumentNullException ("fontPickerViewController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("fontPickerViewController:didSelectFont:"), fontPickerViewController.Handle, selectedFont == null ? IntPtr.Zero : selectedFont.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFFontPickerViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFFontPickerViewControllerDelegate : NSObject, IPSPDFFontPickerViewControllerDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFFontPickerViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFFontPickerViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFontPickerViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("fontPickerViewController:didSelectFont:")]
		[CompilerGenerated]
		public abstract void DidSelectFont (PSPDFFontPickerViewController fontPickerViewController, global::UIKit.UIFont selectedFont);
	} /* class PSPDFFontPickerViewControllerDelegate */
}
