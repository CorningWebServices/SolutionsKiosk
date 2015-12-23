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
	[Protocol (Name = "PSPDFControlDelegate", WrapperType = typeof (PSPDFControlDelegateWrapper))]
	public interface IPSPDFControlDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFErrorHandler
		, PSPDFKit.IPSPDFHUDControls
		, PSPDFKit.IPSPDFPageControls
		, PSPDFKit.IPSPDFPresentationActions
		
	{
	}
	
	internal sealed class PSPDFControlDelegateWrapper : BaseWrapper, IPSPDFControlDelegate {
		public PSPDFControlDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFControlDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("handleError:title:message:")]
		[CompilerGenerated]
		public void HandleError (NSError error, string title, string message)
		{
			var nstitle = NSString.CreateNative (title);
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleError:title:message:"), error == null ? IntPtr.Zero : error.Handle, nstitle, nsmessage);
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("hideControlsAnimated:")]
		[CompilerGenerated]
		public bool HideControls (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideControlsAnimated:"), animated);
		}
		
		[Export ("hideControlsForUserScrollActionAnimated:")]
		[CompilerGenerated]
		public bool HideControlsForUserScrollAction (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideControlsForUserScrollActionAnimated:"), animated);
		}
		
		[Export ("hideControlsAndPageElementsAnimated:")]
		[CompilerGenerated]
		public bool HideControlsAndPageElements (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideControlsAndPageElementsAnimated:"), animated);
		}
		
		[Export ("toggleControlsAnimated:")]
		[CompilerGenerated]
		public bool ToggleControls (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("toggleControlsAnimated:"), animated);
		}
		
		[Export ("shouldShowControls")]
		[CompilerGenerated]
		public bool ShouldShowControls ()
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldShowControls"));
		}
		
		[Export ("showControlsAnimated:")]
		[CompilerGenerated]
		public bool ShowControls (bool animated)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("showControlsAnimated:"), animated);
		}
		
		[Export ("showMenuIfSelectedAnimated:allowPopovers:")]
		[CompilerGenerated]
		public void ShowMenuIfSelected (bool animated, bool allowPopovers)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("showMenuIfSelectedAnimated:allowPopovers:"), animated, allowPopovers);
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
		
		[Export ("presentViewController:options:animated:sender:error:completion:")]
		[CompilerGenerated]
		public unsafe NSObject PresentViewController (IPSPDFPresentableViewController controller, NSDictionary options, bool animated, NSObject sender, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			IntPtr errorValue = IntPtr.Zero;
			
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentViewController:options:animated:sender:error:completion:"), controller.Handle, options == null ? IntPtr.Zero : options.Handle, animated, sender == null ? IntPtr.Zero : sender.Handle, ref errorValue, (IntPtr) block_ptr_completion));
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("dismissPopoverAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe bool DismissPopover (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("dismissPopoverAnimated:forClass:completion:"), animated, controllerClass == null ? IntPtr.Zero : controllerClass.Handle, (IntPtr) block_ptr_completion);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("dismissViewControllerAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe void DismissViewController (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("dismissViewControllerAnimated:forClass:completion:"), animated, controllerClass == null ? IntPtr.Zero : controllerClass.Handle, (IntPtr) block_ptr_completion);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFControlDelegate", false)]
	[Model]
	public unsafe partial class PSPDFControlDelegate : NSObject, IPSPDFControlDelegate, IPSPDFErrorHandler, IPSPDFHUDControls, IPSPDFPageControls, IPSPDFPresentationActions {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFControlDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFControlDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFControlDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dismissPopoverAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe virtual bool DismissPopover (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dismissViewControllerAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe virtual void DismissViewController (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentActionExecutor")]
		[CompilerGenerated]
		public virtual PSPDFDocumentActionExecutor DocumentActionExecutor ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("executePDFAction:targetRect:page:animated:actionContainer:")]
		[CompilerGenerated]
		public virtual bool ExecutePdfAction (PSPDFAction action, CGRect targetRect, global::System.nuint page, bool animated, NSObject actionContainer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("visibleViewControllerInPopoverController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController GetVisibleViewControllerInPopoverController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("handleError:title:message:")]
		[CompilerGenerated]
		public virtual void HandleError (NSError error, string title, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hideControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool HideControls (bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hideControlsAndPageElementsAnimated:")]
		[CompilerGenerated]
		public virtual bool HideControlsAndPageElements (bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hideControlsForUserScrollActionAnimated:")]
		[CompilerGenerated]
		public virtual bool HideControlsForUserScrollAction (bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("presentDocumentInfoViewControllerWithOptions:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual global::UIKit.UIViewController PresentDocumentInfoViewController (NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("presentPreviewControllerForURL:title:options:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void PresentPreviewController (NSUrl fileUrl, string title, NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("presentViewController:options:animated:sender:error:completion:")]
		[CompilerGenerated]
		public unsafe virtual NSObject PresentViewController (IPSPDFPresentableViewController controller, NSDictionary options, bool animated, NSObject sender, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("scrollToNextPageAnimated:")]
		[CompilerGenerated]
		public virtual bool ScrollToNextPage (bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("scrollToPreviousPageAnimated:")]
		[CompilerGenerated]
		public virtual bool ScrollToPreviousPage (bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("searchForString:options:sender:animated:")]
		[CompilerGenerated]
		public virtual void SearchForString (string searchText, NSDictionary options, NSObject sender, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setDocument:")]
		[CompilerGenerated]
		public virtual bool SetDocument (PSPDFDocument document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public virtual bool SetPage (global::System.nuint page, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setPage:options:animated:")]
		[CompilerGenerated]
		public virtual bool SetPage (global::System.nuint page, NSDictionary options, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setViewMode:animated:")]
		[CompilerGenerated]
		public virtual void SetViewMode (PSPDFViewMode viewMode, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("sender:shouldShowController:embeddedInController:options:animated:")]
		[CompilerGenerated]
		public virtual bool ShouldShowController (NSObject sender, IPSPDFPresentableViewController controller, IPSPDFHostableViewController hostController, NSDictionary options, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("shouldShowControls")]
		[CompilerGenerated]
		public virtual bool ShouldShowControls ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("showControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool ShowControls (bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("showMenuIfSelectedAnimated:allowPopovers:")]
		[CompilerGenerated]
		public virtual void ShowMenuIfSelected (bool animated, bool allowPopovers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("toggleControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool ToggleControls (bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFControlDelegate */
}
