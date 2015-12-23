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
	[Protocol (Name = "PSPDFDocumentSharingViewControllerDelegate", WrapperType = typeof (PSPDFDocumentSharingViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinishWithSelectedOptions", Selector = "documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingViewController), typeof (PSPDFKit.PSPDFDocumentSharingOptions), typeof (NSObject[]), typeof (NSAttributedString), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DocumentSharingViewControllerDidCancel", Selector = "documentSharingViewControllerDidCancel:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPrepareWithSelectedOptions", Selector = "documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingViewController), typeof (PSPDFKit.PSPDFDocumentSharingOptions), typeof (NSIndexSet) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PreparationProgress", Selector = "documentSharingViewController:preparationProgress:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingViewController), typeof (nfloat) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TitleForOption", Selector = "documentSharingViewController:titleForOption:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingViewController), typeof (PSPDFKit.PSPDFDocumentSharingOptions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SubtitleForOption", Selector = "documentSharingViewController:subtitleForOption:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingViewController), typeof (PSPDFKit.PSPDFDocumentSharingOptions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProcessorOptionsForDocumentSharingViewController", Selector = "processorOptionsForDocumentSharingViewController:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TemporaryDirectoryForDocumentSharingViewController", Selector = "temporaryDirectoryForDocumentSharingViewController:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentSharingViewController) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFDocumentSharingViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
		[CompilerGenerated]
		[Export ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:")]
		[Preserve (Conditional = true)]
		void DidFinishWithSelectedOptions (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions selectedSharingOption, NSObject[] files, NSAttributedString annotationSummary, NSError error);
		
	}
	
	public static partial class PSPDFDocumentSharingViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void DocumentSharingViewControllerDidCancel (this IPSPDFDocumentSharingViewControllerDelegate This, PSPDFDocumentSharingViewController shareController)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("documentSharingViewControllerDidCancel:"), shareController.Handle);
		}
		
		[CompilerGenerated]
		public static bool ShouldPrepareWithSelectedOptions (this IPSPDFDocumentSharingViewControllerDelegate This, PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions selectedSharingOption, NSIndexSet selectedPages)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (selectedPages == null)
				throw new ArgumentNullException ("selectedPages");
			if (IntPtr.Size == 8) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr (This.Handle, Selector.GetHandle ("documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:"), shareController.Handle, (UInt64)selectedSharingOption, selectedPages.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt32_IntPtr (This.Handle, Selector.GetHandle ("documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:"), shareController.Handle, (UInt32)selectedSharingOption, selectedPages.Handle);
			}
		}
		
		[CompilerGenerated]
		public static string PreparationProgress (this IPSPDFDocumentSharingViewControllerDelegate This, PSPDFDocumentSharingViewController shareController, global::System.nfloat progress)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nfloat (This.Handle, Selector.GetHandle ("documentSharingViewController:preparationProgress:"), shareController.Handle, progress));
		}
		
		[CompilerGenerated]
		public static string TitleForOption (this IPSPDFDocumentSharingViewControllerDelegate This, PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions option)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (IntPtr.Size == 8) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("documentSharingViewController:titleForOption:"), shareController.Handle, (UInt64)option));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("documentSharingViewController:titleForOption:"), shareController.Handle, (UInt32)option));
			}
		}
		
		[CompilerGenerated]
		public static string SubtitleForOption (this IPSPDFDocumentSharingViewControllerDelegate This, PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions option)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (IntPtr.Size == 8) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("documentSharingViewController:subtitleForOption:"), shareController.Handle, (UInt64)option));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("documentSharingViewController:subtitleForOption:"), shareController.Handle, (UInt32)option));
			}
		}
		
		[CompilerGenerated]
		public static NSDictionary ProcessorOptionsForDocumentSharingViewController (this IPSPDFDocumentSharingViewControllerDelegate This, PSPDFDocumentSharingViewController shareController)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("processorOptionsForDocumentSharingViewController:"), shareController.Handle));
		}
		
		[CompilerGenerated]
		public static string TemporaryDirectoryForDocumentSharingViewController (this IPSPDFDocumentSharingViewControllerDelegate This, PSPDFDocumentSharingViewController shareController)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("temporaryDirectoryForDocumentSharingViewController:"), shareController.Handle));
		}
		
	}
	
	internal sealed class PSPDFDocumentSharingViewControllerDelegateWrapper : BaseWrapper, IPSPDFDocumentSharingViewControllerDelegate {
		public PSPDFDocumentSharingViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFDocumentSharingViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:")]
		[CompilerGenerated]
		public void DidFinishWithSelectedOptions (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions selectedSharingOption, NSObject[] files, NSAttributedString annotationSummary, NSError error)
		{
			if (shareController == null)
				throw new ArgumentNullException ("shareController");
			if (files == null)
				throw new ArgumentNullException ("files");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsa_files = NSArray.FromNSObjects (files);
			
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:"), shareController.Handle, (UInt64)selectedSharingOption, nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, error.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:"), shareController.Handle, (UInt32)selectedSharingOption, nsa_files.Handle, annotationSummary == null ? IntPtr.Zero : annotationSummary.Handle, error.Handle);
			}
			nsa_files.Dispose ();
			
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFDocumentSharingViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFDocumentSharingViewControllerDelegate : NSObject, IPSPDFDocumentSharingViewControllerDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFDocumentSharingViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentSharingViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentSharingViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentSharingViewController:didFinishWithSelectedOptions:files:annotationSummary:error:")]
		[CompilerGenerated]
		public abstract void DidFinishWithSelectedOptions (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions selectedSharingOption, NSObject[] files, NSAttributedString annotationSummary, NSError error);
		[Export ("documentSharingViewControllerDidCancel:")]
		[CompilerGenerated]
		public virtual void DocumentSharingViewControllerDidCancel (PSPDFDocumentSharingViewController shareController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentSharingViewController:preparationProgress:")]
		[CompilerGenerated]
		public virtual string PreparationProgress (PSPDFDocumentSharingViewController shareController, global::System.nfloat progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("processorOptionsForDocumentSharingViewController:")]
		[CompilerGenerated]
		public virtual NSDictionary ProcessorOptionsForDocumentSharingViewController (PSPDFDocumentSharingViewController shareController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentSharingViewController:shouldPrepareWithSelectedOptions:selectedPages:")]
		[CompilerGenerated]
		public virtual bool ShouldPrepareWithSelectedOptions (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions selectedSharingOption, NSIndexSet selectedPages)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentSharingViewController:subtitleForOption:")]
		[CompilerGenerated]
		public virtual string SubtitleForOption (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions option)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("temporaryDirectoryForDocumentSharingViewController:")]
		[CompilerGenerated]
		public virtual string TemporaryDirectoryForDocumentSharingViewController (PSPDFDocumentSharingViewController shareController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentSharingViewController:titleForOption:")]
		[CompilerGenerated]
		public virtual string TitleForOption (PSPDFDocumentSharingViewController shareController, PSPDFDocumentSharingOptions option)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFDocumentSharingViewControllerDelegate */
}
