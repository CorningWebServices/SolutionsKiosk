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
	[Protocol (Name = "PSPDFMultiDocumentViewControllerDelegate", WrapperType = typeof (PSPDFMultiDocumentViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeDocuments", Selector = "multiPDFController:shouldChangeDocuments:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMultiDocumentViewController), typeof (PSPDFKit.PSPDFDocument[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeDocuments", Selector = "multiPDFController:didChangeDocuments:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMultiDocumentViewController), typeof (PSPDFKit.PSPDFDocument[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeVisibleDocument", Selector = "multiPDFController:shouldChangeVisibleDocument:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMultiDocumentViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeVisibleDocument", Selector = "multiPDFController:didChangeVisibleDocument:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFMultiDocumentViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFMultiDocumentViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFMultiDocumentViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static bool ShouldChangeDocuments (this IPSPDFMultiDocumentViewControllerDelegate This, PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument[] newDocuments)
		{
			if (multiPDFController == null)
				throw new ArgumentNullException ("multiPDFController");
			if (newDocuments == null)
				throw new ArgumentNullException ("newDocuments");
			var nsa_newDocuments = NSArray.FromNSObjects (newDocuments);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("multiPDFController:shouldChangeDocuments:"), multiPDFController.Handle, nsa_newDocuments.Handle);
			nsa_newDocuments.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void DidChangeDocuments (this IPSPDFMultiDocumentViewControllerDelegate This, PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument[] oldDocuments)
		{
			if (multiPDFController == null)
				throw new ArgumentNullException ("multiPDFController");
			if (oldDocuments == null)
				throw new ArgumentNullException ("oldDocuments");
			var nsa_oldDocuments = NSArray.FromNSObjects (oldDocuments);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("multiPDFController:didChangeDocuments:"), multiPDFController.Handle, nsa_oldDocuments.Handle);
			nsa_oldDocuments.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static bool ShouldChangeVisibleDocument (this IPSPDFMultiDocumentViewControllerDelegate This, PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument newDocument)
		{
			if (multiPDFController == null)
				throw new ArgumentNullException ("multiPDFController");
			if (newDocument == null)
				throw new ArgumentNullException ("newDocument");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("multiPDFController:shouldChangeVisibleDocument:"), multiPDFController.Handle, newDocument.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeVisibleDocument (this IPSPDFMultiDocumentViewControllerDelegate This, PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument oldDocument)
		{
			if (multiPDFController == null)
				throw new ArgumentNullException ("multiPDFController");
			if (oldDocument == null)
				throw new ArgumentNullException ("oldDocument");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("multiPDFController:didChangeVisibleDocument:"), multiPDFController.Handle, oldDocument.Handle);
		}
		
	}
	
	internal sealed class PSPDFMultiDocumentViewControllerDelegateWrapper : BaseWrapper, IPSPDFMultiDocumentViewControllerDelegate {
		public PSPDFMultiDocumentViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFMultiDocumentViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFMultiDocumentViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFMultiDocumentViewControllerDelegate : NSObject, IPSPDFMultiDocumentViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMultiDocumentViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFMultiDocumentViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMultiDocumentViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("multiPDFController:didChangeDocuments:")]
		[CompilerGenerated]
		public virtual void DidChangeDocuments (PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument[] oldDocuments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("multiPDFController:didChangeVisibleDocument:")]
		[CompilerGenerated]
		public virtual void DidChangeVisibleDocument (PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument oldDocument)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("multiPDFController:shouldChangeDocuments:")]
		[CompilerGenerated]
		public virtual bool ShouldChangeDocuments (PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument[] newDocuments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("multiPDFController:shouldChangeVisibleDocument:")]
		[CompilerGenerated]
		public virtual bool ShouldChangeVisibleDocument (PSPDFMultiDocumentViewController multiPDFController, PSPDFDocument newDocument)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFMultiDocumentViewControllerDelegate */
}
