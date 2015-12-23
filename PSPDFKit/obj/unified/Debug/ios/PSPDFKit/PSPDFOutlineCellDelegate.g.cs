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
	[Protocol (Name = "PSPDFOutlineCellDelegate", WrapperType = typeof (PSPDFOutlineCellDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidTapDisclosureButton", Selector = "outlineCellDidTapDisclosureButton:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFOutlineCell) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFOutlineCellDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("outlineCellDidTapDisclosureButton:")]
		[Preserve (Conditional = true)]
		void DidTapDisclosureButton (PSPDFOutlineCell outlineCell);
		
	}
	
	internal sealed class PSPDFOutlineCellDelegateWrapper : BaseWrapper, IPSPDFOutlineCellDelegate {
		public PSPDFOutlineCellDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFOutlineCellDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("outlineCellDidTapDisclosureButton:")]
		[CompilerGenerated]
		public void DidTapDisclosureButton (PSPDFOutlineCell outlineCell)
		{
			if (outlineCell == null)
				throw new ArgumentNullException ("outlineCell");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("outlineCellDidTapDisclosureButton:"), outlineCell.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFOutlineCellDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFOutlineCellDelegate : NSObject, IPSPDFOutlineCellDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFOutlineCellDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFOutlineCellDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFOutlineCellDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("outlineCellDidTapDisclosureButton:")]
		[CompilerGenerated]
		public abstract void DidTapDisclosureButton (PSPDFOutlineCell outlineCell);
	} /* class PSPDFOutlineCellDelegate */
}
