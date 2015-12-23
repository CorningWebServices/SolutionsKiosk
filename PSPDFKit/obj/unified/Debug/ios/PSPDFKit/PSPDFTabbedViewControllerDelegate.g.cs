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
	[Protocol (Name = "PSPDFTabbedViewControllerDelegate", WrapperType = typeof (PSPDFTabbedViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TabbedPdfShouldChangeDocuments", Selector = "tabbedPDFController:shouldChangeDocuments:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabbedViewController), typeof (PSPDFKit.PSPDFDocument[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TabbedPdfDidChangeDocuments", Selector = "tabbedPDFController:didChangeDocuments:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabbedViewController), typeof (PSPDFKit.PSPDFDocument[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TabbedPdfShouldChangeVisibleDocument", Selector = "tabbedPDFController:shouldChangeVisibleDocument:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabbedViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TabbedPdfDidChangeVisibleDocument", Selector = "tabbedPDFController:didChangeVisibleDocument:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabbedViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TabbedPdfShouldCloseDocument", Selector = "tabbedPDFController:shouldCloseDocument:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabbedViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TabbedPdfDidCloseDocument", Selector = "tabbedPDFController:didCloseDocument:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTabbedViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFTabbedViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFMultiDocumentViewControllerDelegate
		
	{
	}
	
	public static partial class PSPDFTabbedViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static bool TabbedPdfShouldChangeDocuments (this IPSPDFTabbedViewControllerDelegate This, PSPDFTabbedViewController tabbedPDFController, PSPDFDocument[] newDocuments)
		{
			if (tabbedPDFController == null)
				throw new ArgumentNullException ("tabbedPDFController");
			if (newDocuments == null)
				throw new ArgumentNullException ("newDocuments");
			var nsa_newDocuments = NSArray.FromNSObjects (newDocuments);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tabbedPDFController:shouldChangeDocuments:"), tabbedPDFController.Handle, nsa_newDocuments.Handle);
			nsa_newDocuments.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void TabbedPdfDidChangeDocuments (this IPSPDFTabbedViewControllerDelegate This, PSPDFTabbedViewController tabbedPDFController, PSPDFDocument[] oldDocuments)
		{
			if (tabbedPDFController == null)
				throw new ArgumentNullException ("tabbedPDFController");
			if (oldDocuments == null)
				throw new ArgumentNullException ("oldDocuments");
			var nsa_oldDocuments = NSArray.FromNSObjects (oldDocuments);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tabbedPDFController:didChangeDocuments:"), tabbedPDFController.Handle, nsa_oldDocuments.Handle);
			nsa_oldDocuments.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static bool TabbedPdfShouldChangeVisibleDocument (this IPSPDFTabbedViewControllerDelegate This, PSPDFTabbedViewController tabbedPDFController, PSPDFDocument newDocument)
		{
			if (tabbedPDFController == null)
				throw new ArgumentNullException ("tabbedPDFController");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tabbedPDFController:shouldChangeVisibleDocument:"), tabbedPDFController.Handle, newDocument == null ? IntPtr.Zero : newDocument.Handle);
		}
		
		[CompilerGenerated]
		public static void TabbedPdfDidChangeVisibleDocument (this IPSPDFTabbedViewControllerDelegate This, PSPDFTabbedViewController tabbedPDFController, PSPDFDocument oldDocument)
		{
			if (tabbedPDFController == null)
				throw new ArgumentNullException ("tabbedPDFController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tabbedPDFController:didChangeVisibleDocument:"), tabbedPDFController.Handle, oldDocument == null ? IntPtr.Zero : oldDocument.Handle);
		}
		
		[CompilerGenerated]
		public static bool TabbedPdfShouldCloseDocument (this IPSPDFTabbedViewControllerDelegate This, PSPDFTabbedViewController tabbedPDFController, PSPDFDocument closedDocument)
		{
			if (tabbedPDFController == null)
				throw new ArgumentNullException ("tabbedPDFController");
			if (closedDocument == null)
				throw new ArgumentNullException ("closedDocument");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tabbedPDFController:shouldCloseDocument:"), tabbedPDFController.Handle, closedDocument.Handle);
		}
		
		[CompilerGenerated]
		public static void TabbedPdfDidCloseDocument (this IPSPDFTabbedViewControllerDelegate This, PSPDFTabbedViewController tabbedPDFController, PSPDFDocument closedDocument)
		{
			if (tabbedPDFController == null)
				throw new ArgumentNullException ("tabbedPDFController");
			if (closedDocument == null)
				throw new ArgumentNullException ("closedDocument");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tabbedPDFController:didCloseDocument:"), tabbedPDFController.Handle, closedDocument.Handle);
		}
		
	}
	
	internal sealed class PSPDFTabbedViewControllerDelegateWrapper : BaseWrapper, IPSPDFTabbedViewControllerDelegate {
		public PSPDFTabbedViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFTabbedViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFTabbedViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFTabbedViewControllerDelegate : NSObject, IPSPDFTabbedViewControllerDelegate, IPSPDFMultiDocumentViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTabbedViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFTabbedViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTabbedViewControllerDelegate (IntPtr handle) : base (handle)
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
		
		[Export ("tabbedPDFController:didChangeDocuments:")]
		[CompilerGenerated]
		public virtual void TabbedPdfDidChangeDocuments (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument[] oldDocuments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tabbedPDFController:didChangeVisibleDocument:")]
		[CompilerGenerated]
		public virtual void TabbedPdfDidChangeVisibleDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument oldDocument)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tabbedPDFController:didCloseDocument:")]
		[CompilerGenerated]
		public virtual void TabbedPdfDidCloseDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument closedDocument)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tabbedPDFController:shouldChangeDocuments:")]
		[CompilerGenerated]
		public virtual bool TabbedPdfShouldChangeDocuments (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument[] newDocuments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tabbedPDFController:shouldChangeVisibleDocument:")]
		[CompilerGenerated]
		public virtual bool TabbedPdfShouldChangeVisibleDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument newDocument)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tabbedPDFController:shouldCloseDocument:")]
		[CompilerGenerated]
		public virtual bool TabbedPdfShouldCloseDocument (PSPDFTabbedViewController tabbedPDFController, PSPDFDocument closedDocument)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFTabbedViewControllerDelegate */
}
