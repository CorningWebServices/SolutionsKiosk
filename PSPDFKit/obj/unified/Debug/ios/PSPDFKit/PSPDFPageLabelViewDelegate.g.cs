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
	[Protocol (Name = "PSPDFPageLabelViewDelegate", WrapperType = typeof (PSPDFPageLabelViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidPressThumbnailGridButton", Selector = "pageLabelView:didPressThumbnailGridButton:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFPageLabelView), typeof (UIButton) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFPageLabelViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("pageLabelView:didPressThumbnailGridButton:")]
		[Preserve (Conditional = true)]
		void DidPressThumbnailGridButton (PSPDFPageLabelView pageLabelView, global::UIKit.UIButton sender);
		
	}
	
	internal sealed class PSPDFPageLabelViewDelegateWrapper : BaseWrapper, IPSPDFPageLabelViewDelegate {
		public PSPDFPageLabelViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFPageLabelViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("pageLabelView:didPressThumbnailGridButton:")]
		[CompilerGenerated]
		public void DidPressThumbnailGridButton (PSPDFPageLabelView pageLabelView, global::UIKit.UIButton sender)
		{
			if (pageLabelView == null)
				throw new ArgumentNullException ("pageLabelView");
			if (sender == null)
				throw new ArgumentNullException ("sender");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("pageLabelView:didPressThumbnailGridButton:"), pageLabelView.Handle, sender.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFPageLabelViewDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFPageLabelViewDelegate : NSObject, IPSPDFPageLabelViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFPageLabelViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFPageLabelViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPageLabelViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("pageLabelView:didPressThumbnailGridButton:")]
		[CompilerGenerated]
		public abstract void DidPressThumbnailGridButton (PSPDFPageLabelView pageLabelView, global::UIKit.UIButton sender);
	} /* class PSPDFPageLabelViewDelegate */
}
