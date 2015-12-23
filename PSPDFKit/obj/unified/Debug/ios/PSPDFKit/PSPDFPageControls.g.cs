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
	[Protocol (Name = "PSPDFPageControls", WrapperType = typeof (PSPDFPageControlsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDocument", Selector = "setDocument:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPage", Selector = "setPage:animated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nuint), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPage", Selector = "setPage:options:animated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nuint), typeof (NSDictionary), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ScrollToNextPage", Selector = "scrollToNextPageAnimated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ScrollToPreviousPage", Selector = "scrollToPreviousPageAnimated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetViewMode", Selector = "setViewMode:animated:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewMode), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecutePdfAction", Selector = "executePDFAction:targetRect:page:animated:actionContainer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAction), typeof (CGRect), typeof (nuint), typeof (bool), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SearchForString", Selector = "searchForString:options:sender:animated:", ParameterType = new Type [] { typeof (string), typeof (NSDictionary), typeof (NSObject), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DocumentActionExecutor", Selector = "documentActionExecutor", ReturnType = typeof (PSPDFKit.PSPDFDocumentActionExecutor))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentDocumentInfoViewController", Selector = "presentDocumentInfoViewControllerWithOptions:sender:animated:completion:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (NSDictionary), typeof (NSObject), typeof (bool), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentPreviewController", Selector = "presentPreviewControllerForURL:title:options:sender:animated:completion:", ParameterType = new Type [] { typeof (NSUrl), typeof (string), typeof (NSDictionary), typeof (NSObject), typeof (bool), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReloadData", Selector = "reloadData")]
	public interface IPSPDFPageControls : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setDocument:")]
		[Preserve (Conditional = true)]
		bool SetDocument (PSPDFDocument document);
		
		[CompilerGenerated]
		[Export ("setPage:animated:")]
		[Preserve (Conditional = true)]
		bool SetPage (global::System.nuint page, bool animated);
		
		[CompilerGenerated]
		[Export ("setPage:options:animated:")]
		[Preserve (Conditional = true)]
		bool SetPage (global::System.nuint page, NSDictionary options, bool animated);
		
		[CompilerGenerated]
		[Export ("scrollToNextPageAnimated:")]
		[Preserve (Conditional = true)]
		bool ScrollToNextPage (bool animated);
		
		[CompilerGenerated]
		[Export ("scrollToPreviousPageAnimated:")]
		[Preserve (Conditional = true)]
		bool ScrollToPreviousPage (bool animated);
		
		[CompilerGenerated]
		[Export ("setViewMode:animated:")]
		[Preserve (Conditional = true)]
		void SetViewMode (PSPDFViewMode viewMode, bool animated);
		
		[CompilerGenerated]
		[Export ("executePDFAction:targetRect:page:animated:actionContainer:")]
		[Preserve (Conditional = true)]
		bool ExecutePdfAction (PSPDFAction action, CGRect targetRect, global::System.nuint page, bool animated, NSObject actionContainer);
		
		[CompilerGenerated]
		[Export ("searchForString:options:sender:animated:")]
		[Preserve (Conditional = true)]
		void SearchForString (string searchText, NSDictionary options, NSObject sender, bool animated);
		
		[CompilerGenerated]
		[Export ("documentActionExecutor")]
		[Preserve (Conditional = true)]
		PSPDFDocumentActionExecutor DocumentActionExecutor ();
		
		[CompilerGenerated]
		[Export ("presentDocumentInfoViewControllerWithOptions:sender:animated:completion:")]
		[Preserve (Conditional = true)]
		unsafe global::UIKit.UIViewController PresentDocumentInfoViewController (NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler);
		
		[CompilerGenerated]
		[Export ("presentPreviewControllerForURL:title:options:sender:animated:completion:")]
		[Preserve (Conditional = true)]
		unsafe void PresentPreviewController (NSUrl fileUrl, string title, NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		
		[CompilerGenerated]
		[Export ("reloadData")]
		[Preserve (Conditional = true)]
		void ReloadData ();
		
	}
	
	internal sealed class PSPDFPageControlsWrapper : BaseWrapper, IPSPDFPageControls {
		public PSPDFPageControlsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFPageControlsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setDocument:")]
		[CompilerGenerated]
		public bool SetDocument (PSPDFDocument document)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDocument:"), document == null ? IntPtr.Zero : document.Handle);
		}
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public bool SetPage (global::System.nuint page, bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("setPage:animated:"), page, animated);
		}
		
		[Export ("setPage:options:animated:")]
		[CompilerGenerated]
		public bool SetPage (global::System.nuint page, NSDictionary options, bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint_IntPtr_bool (this.Handle, Selector.GetHandle ("setPage:options:animated:"), page, options == null ? IntPtr.Zero : options.Handle, animated);
		}
		
		[Export ("scrollToNextPageAnimated:")]
		[CompilerGenerated]
		public bool ScrollToNextPage (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("scrollToNextPageAnimated:"), animated);
		}
		
		[Export ("scrollToPreviousPageAnimated:")]
		[CompilerGenerated]
		public bool ScrollToPreviousPage (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("scrollToPreviousPageAnimated:"), animated);
		}
		
		[Export ("setViewMode:animated:")]
		[CompilerGenerated]
		public void SetViewMode (PSPDFViewMode viewMode, bool animated)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_bool (this.Handle, Selector.GetHandle ("setViewMode:animated:"), (UInt64)viewMode, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, Selector.GetHandle ("setViewMode:animated:"), (UInt32)viewMode, animated);
			}
		}
		
		[Export ("executePDFAction:targetRect:page:animated:actionContainer:")]
		[CompilerGenerated]
		public bool ExecutePdfAction (PSPDFAction action, CGRect targetRect, global::System.nuint page, bool animated, NSObject actionContainer)
		{
			if (actionContainer == null)
				throw new ArgumentNullException ("actionContainer");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_CGRect_nuint_bool_IntPtr (this.Handle, Selector.GetHandle ("executePDFAction:targetRect:page:animated:actionContainer:"), action == null ? IntPtr.Zero : action.Handle, targetRect, page, animated, actionContainer.Handle);
		}
		
		[Export ("searchForString:options:sender:animated:")]
		[CompilerGenerated]
		public void SearchForString (string searchText, NSDictionary options, NSObject sender, bool animated)
		{
			var nssearchText = NSString.CreateNative (searchText);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("searchForString:options:sender:animated:"), nssearchText, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated);
			NSString.ReleaseNative (nssearchText);
			
		}
		
		[Export ("documentActionExecutor")]
		[CompilerGenerated]
		public PSPDFDocumentActionExecutor DocumentActionExecutor ()
		{
			return  Runtime.GetNSObject<PSPDFDocumentActionExecutor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentActionExecutor")));
		}
		
		[Export ("presentDocumentInfoViewControllerWithOptions:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe global::UIKit.UIViewController PresentDocumentInfoViewController (NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDAction.Handler, completionHandler);
			}
			
			global::UIKit.UIViewController ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("presentDocumentInfoViewControllerWithOptions:sender:animated:completion:"), options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_completionHandler));
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("presentPreviewControllerForURL:title:options:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe void PresentPreviewController (NSUrl fileUrl, string title, NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (fileUrl == null)
				throw new ArgumentNullException ("fileUrl");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("presentPreviewControllerForURL:title:options:sender:animated:completion:"), fileUrl.Handle, nstitle, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_completion);
			NSString.ReleaseNative (nstitle);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("reloadData")]
		[CompilerGenerated]
		public void ReloadData ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadData"));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFPageControls", false)]
	[Model]
	public unsafe abstract partial class PSPDFPageControls : NSObject, IPSPDFPageControls {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFPageControls () : base (NSObjectFlag.Empty)
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
		protected PSPDFPageControls (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPageControls (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("documentActionExecutor")]
		[CompilerGenerated]
		public abstract PSPDFDocumentActionExecutor DocumentActionExecutor ();
		[Export ("executePDFAction:targetRect:page:animated:actionContainer:")]
		[CompilerGenerated]
		public abstract bool ExecutePdfAction (PSPDFAction action, CGRect targetRect, global::System.nuint page, bool animated, NSObject actionContainer);
		[Export ("presentDocumentInfoViewControllerWithOptions:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe abstract global::UIKit.UIViewController PresentDocumentInfoViewController (NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler);
		[Export ("presentPreviewControllerForURL:title:options:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe abstract void PresentPreviewController (NSUrl fileUrl, string title, NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		[Export ("reloadData")]
		[CompilerGenerated]
		public abstract void ReloadData ();
		[Export ("scrollToNextPageAnimated:")]
		[CompilerGenerated]
		public abstract bool ScrollToNextPage (bool animated);
		[Export ("scrollToPreviousPageAnimated:")]
		[CompilerGenerated]
		public abstract bool ScrollToPreviousPage (bool animated);
		[Export ("searchForString:options:sender:animated:")]
		[CompilerGenerated]
		public abstract void SearchForString (string searchText, NSDictionary options, NSObject sender, bool animated);
		[Export ("setDocument:")]
		[CompilerGenerated]
		public abstract bool SetDocument (PSPDFDocument document);
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public abstract bool SetPage (global::System.nuint page, bool animated);
		[Export ("setPage:options:animated:")]
		[CompilerGenerated]
		public abstract bool SetPage (global::System.nuint page, NSDictionary options, bool animated);
		[Export ("setViewMode:animated:")]
		[CompilerGenerated]
		public abstract void SetViewMode (PSPDFViewMode viewMode, bool animated);
	} /* class PSPDFPageControls */
}
