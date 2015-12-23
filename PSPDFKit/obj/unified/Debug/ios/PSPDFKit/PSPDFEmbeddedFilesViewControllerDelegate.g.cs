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
	[Protocol (Name = "PSPDFEmbeddedFilesViewControllerDelegate", WrapperType = typeof (PSPDFEmbeddedFilesViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectFile", Selector = "embeddedFilesController:didSelectFile:sender:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFEmbeddedFilesViewController), typeof (PSPDFKit.PSPDFEmbeddedFile), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPSPDFEmbeddedFilesViewControllerDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("embeddedFilesController:didSelectFile:sender:")]
		[Preserve (Conditional = true)]
		void DidSelectFile (PSPDFEmbeddedFilesViewController embeddedFilesController, PSPDFEmbeddedFile embeddedFile, NSObject sender);
		
	}
	
	internal sealed class PSPDFEmbeddedFilesViewControllerDelegateWrapper : BaseWrapper, IPSPDFEmbeddedFilesViewControllerDelegate {
		public PSPDFEmbeddedFilesViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFEmbeddedFilesViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("embeddedFilesController:didSelectFile:sender:")]
		[CompilerGenerated]
		public void DidSelectFile (PSPDFEmbeddedFilesViewController embeddedFilesController, PSPDFEmbeddedFile embeddedFile, NSObject sender)
		{
			if (embeddedFilesController == null)
				throw new ArgumentNullException ("embeddedFilesController");
			if (embeddedFile == null)
				throw new ArgumentNullException ("embeddedFile");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("embeddedFilesController:didSelectFile:sender:"), embeddedFilesController.Handle, embeddedFile.Handle, sender == null ? IntPtr.Zero : sender.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFEmbeddedFilesViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFEmbeddedFilesViewControllerDelegate : NSObject, IPSPDFEmbeddedFilesViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFEmbeddedFilesViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFEmbeddedFilesViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFEmbeddedFilesViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("embeddedFilesController:didSelectFile:sender:")]
		[CompilerGenerated]
		public abstract void DidSelectFile (PSPDFEmbeddedFilesViewController embeddedFilesController, PSPDFEmbeddedFile embeddedFile, NSObject sender);
	} /* class PSPDFEmbeddedFilesViewControllerDelegate */
}
