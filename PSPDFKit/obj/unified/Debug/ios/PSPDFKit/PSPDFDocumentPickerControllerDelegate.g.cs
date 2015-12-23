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
	[Protocol (Name = "PSPDFDocumentPickerControllerDelegate", WrapperType = typeof (PSPDFDocumentPickerControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectDocument", Selector = "documentPickerController:didSelectDocument:page:searchString:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentPickerController), typeof (PSPDFKit.PSPDFDocument), typeof (nuint), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginSearch", Selector = "documentPickerControllerWillBeginSearch:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentPickerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginSearch", Selector = "documentPickerControllerDidBeginSearch:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentPickerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEndSearch", Selector = "documentPickerControllerWillEndSearch:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentPickerController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndSearch", Selector = "documentPickerControllerDidEndSearch:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentPickerController) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFDocumentPickerControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
		[CompilerGenerated]
		[Export ("documentPickerController:didSelectDocument:page:searchString:")]
		[Preserve (Conditional = true)]
		void DidSelectDocument (PSPDFDocumentPickerController controller, PSPDFDocument document, global::System.nuint pageIndex, string searchString);
		
	}
	
	public static partial class PSPDFDocumentPickerControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void WillBeginSearch (this IPSPDFDocumentPickerControllerDelegate This, PSPDFDocumentPickerController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("documentPickerControllerWillBeginSearch:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void DidBeginSearch (this IPSPDFDocumentPickerControllerDelegate This, PSPDFDocumentPickerController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("documentPickerControllerDidBeginSearch:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void WillEndSearch (this IPSPDFDocumentPickerControllerDelegate This, PSPDFDocumentPickerController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("documentPickerControllerWillEndSearch:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void DidEndSearch (this IPSPDFDocumentPickerControllerDelegate This, PSPDFDocumentPickerController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("documentPickerControllerDidEndSearch:"), controller.Handle);
		}
		
	}
	
	internal sealed class PSPDFDocumentPickerControllerDelegateWrapper : BaseWrapper, IPSPDFDocumentPickerControllerDelegate {
		public PSPDFDocumentPickerControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFDocumentPickerControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("documentPickerController:didSelectDocument:page:searchString:")]
		[CompilerGenerated]
		public void DidSelectDocument (PSPDFDocumentPickerController controller, PSPDFDocument document, global::System.nuint pageIndex, string searchString)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (document == null)
				throw new ArgumentNullException ("document");
			if (searchString == null)
				throw new ArgumentNullException ("searchString");
			var nssearchString = NSString.CreateNative (searchString);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("documentPickerController:didSelectDocument:page:searchString:"), controller.Handle, document.Handle, pageIndex, nssearchString);
			NSString.ReleaseNative (nssearchString);
			
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFDocumentPickerControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFDocumentPickerControllerDelegate : NSObject, IPSPDFDocumentPickerControllerDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFDocumentPickerControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentPickerControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentPickerControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentPickerControllerDidBeginSearch:")]
		[CompilerGenerated]
		public virtual void DidBeginSearch (PSPDFDocumentPickerController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentPickerControllerDidEndSearch:")]
		[CompilerGenerated]
		public virtual void DidEndSearch (PSPDFDocumentPickerController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentPickerController:didSelectDocument:page:searchString:")]
		[CompilerGenerated]
		public abstract void DidSelectDocument (PSPDFDocumentPickerController controller, PSPDFDocument document, global::System.nuint pageIndex, string searchString);
		[Export ("documentPickerControllerWillBeginSearch:")]
		[CompilerGenerated]
		public virtual void WillBeginSearch (PSPDFDocumentPickerController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentPickerControllerWillEndSearch:")]
		[CompilerGenerated]
		public virtual void WillEndSearch (PSPDFDocumentPickerController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFDocumentPickerControllerDelegate */
}
