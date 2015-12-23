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
	[Register("PSPDFViewController", true)]
	public unsafe partial class PSPDFViewController : PSPDFBaseViewController, global::MessageUI.IMFMailComposeViewControllerDelegate, global::MessageUI.IMFMessageComposeViewControllerDelegate, global::UIKit.IUINavigationControllerDelegate, global::UIKit.IUIPopoverControllerDelegate, IPSPDFAnnotationTableViewControllerDelegate, IPSPDFBackForwardActionListDelegate, IPSPDFBookmarkViewControllerDelegate, IPSPDFErrorHandler, IPSPDFExternalURLHandler, IPSPDFInlineSearchManagerDelegate, IPSPDFOutlineViewControllerDelegate, IPSPDFOverridable, IPSPDFPasswordViewDelegate, IPSPDFSearchViewControllerDelegate, IPSPDFTextSearchDelegate, IPSPDFWebViewControllerDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:configuration:")]
		[CompilerGenerated]
		public PSPDFViewController (PSPDFDocument document, PSPDFConfiguration configuration)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDocument:configuration:"), document == null ? IntPtr.Zero : document.Handle, configuration == null ? IntPtr.Zero : configuration.Handle), "initWithDocument:configuration:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocument:configuration:"), document == null ? IntPtr.Zero : document.Handle, configuration == null ? IntPtr.Zero : configuration.Handle), "initWithDocument:configuration:");
			}
		}
		
		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFViewController (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocument:"), document == null ? IntPtr.Zero : document.Handle), "initWithDocument:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocument:"), document == null ? IntPtr.Zero : document.Handle), "initWithDocument:");
			}
		}
		
		[Export ("annotationButtonPressed:")]
		[CompilerGenerated]
		public virtual void AnnotationButtonPressed (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("annotationButtonPressed:"), sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationButtonPressed:"), sender.Handle);
			}
		}
		
		[Export ("cancelSearchAnimated:")]
		[CompilerGenerated]
		public virtual void CancelSearch (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("cancelSearchAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("cancelSearchAnimated:"), animated);
			}
		}
		
		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			if (originalClass == null)
				throw new ArgumentNullException ("originalClass");
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("classForClass:"), originalClass.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("classForClass:"), originalClass.Handle);
			}
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("commonInitWithDocument:configuration:")]
		[CompilerGenerated]
		public virtual void CommonInitWithDocument (PSPDFDocument document, PSPDFConfiguration configuration)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("commonInitWithDocument:configuration:"), document == null ? IntPtr.Zero : document.Handle, configuration.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("commonInitWithDocument:configuration:"), document == null ? IntPtr.Zero : document.Handle, configuration.Handle);
			}
		}
		
		[Export ("currentPageForBookmarkViewController:")]
		[CompilerGenerated]
		public virtual global::System.nuint CurrentPageForBookmarkViewController (PSPDFBookmarkViewController bookmarkController)
		{
			if (bookmarkController == null)
				throw new ArgumentNullException ("bookmarkController");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("currentPageForBookmarkViewController:"), bookmarkController.Handle);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("currentPageForBookmarkViewController:"), bookmarkController.Handle);
			}
		}
		
		[Export ("didCancelSearch:term:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidCancelSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("didCancelSearch:term:isFullSearch:"), textSearch.Handle, nssearchTerm, isFullSearch);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("didCancelSearch:term:isFullSearch:"), textSearch.Handle, nssearchTerm, isFullSearch);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[Export ("inlineSearchManagerDidClearAllSearchResults:")]
		[CompilerGenerated]
		public virtual void DidClearAllSearchResults (PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inlineSearchManagerDidClearAllSearchResults:"), manager.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("inlineSearchManagerDidClearAllSearchResults:"), manager.Handle);
			}
		}
		
		[Export ("searchViewControllerDidClearAllSearchResults:")]
		[CompilerGenerated]
		public virtual void DidClearAllSearchResults (PSPDFSearchViewController searchController)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("searchViewControllerDidClearAllSearchResults:"), searchController.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("searchViewControllerDidClearAllSearchResults:"), searchController.Handle);
			}
		}
		
		[Export ("webViewController:didFailLoadWithError:")]
		[CompilerGenerated]
		public virtual void DidFailLoad (PSPDFWebViewController controller, NSError error)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("webViewController:didFailLoadWithError:"), controller.Handle, error.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("webViewController:didFailLoadWithError:"), controller.Handle, error.Handle);
			}
		}
		
		[Export ("passwordView:didFailToUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual void DidFailToUnlock (PSPDFPasswordView passwordView, string password)
		{
			if (passwordView == null)
				throw new ArgumentNullException ("passwordView");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("passwordView:didFailToUnlockWithPassword:"), passwordView.Handle, nspassword);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("passwordView:didFailToUnlockWithPassword:"), passwordView.Handle, nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
		}
		
		[Export ("webViewControllerDidFinishLoad:")]
		[CompilerGenerated]
		public virtual void DidFinishLoad (PSPDFWebViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("webViewControllerDidFinishLoad:"), controller.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("webViewControllerDidFinishLoad:"), controller.Handle);
			}
		}
		
		[Export ("didFinishSearch:term:searchResults:isFullSearch:pageTextFound:")]
		[CompilerGenerated]
		public virtual void DidFinishSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, bool isFullSearch, bool pageTextFound)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_bool (this.Handle, Selector.GetHandle ("didFinishSearch:term:searchResults:isFullSearch:pageTextFound:"), textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, isFullSearch, pageTextFound);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_bool (this.SuperHandle, Selector.GetHandle ("didFinishSearch:term:searchResults:isFullSearch:pageTextFound:"), textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, isFullSearch, pageTextFound);
			}
			NSString.ReleaseNative (nssearchTerm);
			nsa_searchResults.Dispose ();
			
		}
		
		[Export ("inlineSearchManager:didFocusSearchResult:")]
		[CompilerGenerated]
		public virtual void DidFocusSearchResult (PSPDFInlineSearchManager manager, PSPDFSearchResult searchResult)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("inlineSearchManager:didFocusSearchResult:"), manager.Handle, searchResult.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("inlineSearchManager:didFocusSearchResult:"), manager.Handle, searchResult.Handle);
			}
		}
		
		[Export ("annotationTableViewController:didSelectAnnotation:")]
		[CompilerGenerated]
		public virtual void DidSelectAnnotation (PSPDFAnnotationTableViewController annotationController, PSPDFAnnotation annotation)
		{
			if (annotationController == null)
				throw new ArgumentNullException ("annotationController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationTableViewController:didSelectAnnotation:"), annotationController.Handle, annotation.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationTableViewController:didSelectAnnotation:"), annotationController.Handle, annotation.Handle);
			}
		}
		
		[Export ("bookmarkViewController:didSelectBookmark:")]
		[CompilerGenerated]
		public virtual void DidSelectBookmark (PSPDFBookmarkViewController bookmarkController, PSPDFBookmark bookmark)
		{
			if (bookmarkController == null)
				throw new ArgumentNullException ("bookmarkController");
			if (bookmark == null)
				throw new ArgumentNullException ("bookmark");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bookmarkViewController:didSelectBookmark:"), bookmarkController.Handle, bookmark.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("bookmarkViewController:didSelectBookmark:"), bookmarkController.Handle, bookmark.Handle);
			}
		}
		
		[Export ("webViewControllerDidStartLoad:")]
		[CompilerGenerated]
		public virtual void DidStartLoad (PSPDFWebViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("webViewControllerDidStartLoad:"), controller.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("webViewControllerDidStartLoad:"), controller.Handle);
			}
		}
		
		[Export ("outlineController:didTapAtElement:")]
		[CompilerGenerated]
		public virtual bool DidTapAtElement (PSPDFOutlineViewController outlineController, PSPDFOutlineElement outlineElement)
		{
			if (outlineController == null)
				throw new ArgumentNullException ("outlineController");
			if (outlineElement == null)
				throw new ArgumentNullException ("outlineElement");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("outlineController:didTapAtElement:"), outlineController.Handle, outlineElement.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("outlineController:didTapAtElement:"), outlineController.Handle, outlineElement.Handle);
			}
		}
		
		[Export ("searchViewController:didTapSearchResult:")]
		[CompilerGenerated]
		public virtual void DidTapSearchResult (PSPDFSearchViewController searchController, PSPDFSearchResult searchResult)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("searchViewController:didTapSearchResult:"), searchController.Handle, searchResult.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("searchViewController:didTapSearchResult:"), searchController.Handle, searchResult.Handle);
			}
		}
		
		[Export ("passwordView:didUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual void DidUnlock (PSPDFPasswordView passwordView, string password)
		{
			if (passwordView == null)
				throw new ArgumentNullException ("passwordView");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("passwordView:didUnlockWithPassword:"), passwordView.Handle, nspassword);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("passwordView:didUnlockWithPassword:"), passwordView.Handle, nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
		}
		
		[Export ("backForwardListDidUpdate:")]
		[CompilerGenerated]
		public virtual void DidUpdate (PSPDFBackForwardActionList list)
		{
			if (list == null)
				throw new ArgumentNullException ("list");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("backForwardListDidUpdate:"), list.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("backForwardListDidUpdate:"), list.Handle);
			}
		}
		
		[Export ("didUpdateSearch:term:newSearchResults:page:")]
		[CompilerGenerated]
		public virtual void DidUpdateSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, global::System.nuint page)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint (this.Handle, Selector.GetHandle ("didUpdateSearch:term:newSearchResults:page:"), textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, page);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("didUpdateSearch:term:newSearchResults:page:"), textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, page);
			}
			NSString.ReleaseNative (nssearchTerm);
			nsa_searchResults.Dispose ();
			
		}
		
		[Export ("dismissPopoverAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe virtual bool DismissPopover (bool animated, Class popoverClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
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
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("dismissPopoverAnimated:forClass:completion:"), animated, popoverClass == null ? IntPtr.Zero : popoverClass.Handle, (IntPtr) block_ptr_completion);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("dismissPopoverAnimated:forClass:completion:"), animated, popoverClass == null ? IntPtr.Zero : popoverClass.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("dismissViewControllerAnimated:class:completion:")]
		[CompilerGenerated]
		public unsafe virtual void DismissViewController (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
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
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("dismissViewControllerAnimated:class:completion:"), animated, controllerClass == null ? IntPtr.Zero : controllerClass.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("dismissViewControllerAnimated:class:completion:"), animated, controllerClass == null ? IntPtr.Zero : controllerClass.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("executePDFAction:targetRect:page:animated:actionContainer:")]
		[CompilerGenerated]
		public virtual bool ExecutePdfAction (PSPDFAction action, CGRect targetRect, global::System.nuint page, bool animated, NSObject actionContainer)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_CGRect_nuint_bool_IntPtr (this.Handle, Selector.GetHandle ("executePDFAction:targetRect:page:animated:actionContainer:"), action == null ? IntPtr.Zero : action.Handle, targetRect, page, animated, actionContainer == null ? IntPtr.Zero : actionContainer.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_nuint_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("executePDFAction:targetRect:page:animated:actionContainer:"), action == null ? IntPtr.Zero : action.Handle, targetRect, page, animated, actionContainer == null ? IntPtr.Zero : actionContainer.Handle);
			}
		}
		
		[Export ("messageComposeViewController:didFinishWithResult:")]
		[CompilerGenerated]
		public virtual void Finished (global::MessageUI.MFMessageComposeViewController controller, global::MessageUI.MessageComposeResult result)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("messageComposeViewController:didFinishWithResult:"), controller.Handle, (int)result);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("messageComposeViewController:didFinishWithResult:"), controller.Handle, (int)result);
			}
		}
		
		[Export ("inlineSearchManagerContainerView:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIView GetContainerView (PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inlineSearchManagerContainerView:"), manager.Handle));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("inlineSearchManagerContainerView:"), manager.Handle));
			}
		}
		
		[Export ("searchViewControllerGetVisiblePages:")]
		[CompilerGenerated]
		public virtual NSObject[] GetVisiblePages (PSPDFSearchViewController searchController)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("searchViewControllerGetVisiblePages:"), searchController.Handle));
			} else {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("searchViewControllerGetVisiblePages:"), searchController.Handle));
			}
		}
		
		[Export ("handleError:title:message:")]
		[CompilerGenerated]
		public virtual void HandleError (NSError error, string title, string message)
		{
			var nstitle = NSString.CreateNative (title);
			var nsmessage = NSString.CreateNative (message);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleError:title:message:"), error == null ? IntPtr.Zero : error.Handle, nstitle, nsmessage);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleError:title:message:"), error == null ? IntPtr.Zero : error.Handle, nstitle, nsmessage);
			}
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("handleExternalURL:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual bool HandleExternalUrl (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity1V1.Handler, completionHandler);
			}
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleExternalURL:completionBlock:"), url.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleExternalURL:completionBlock:"), url.Handle, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("hideControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool HideControls (bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideControlsAnimated:"), animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("hideControlsAnimated:"), animated);
			}
		}
		
		[Export ("hideControlsAndPageElementsAnimated:")]
		[CompilerGenerated]
		public virtual bool HideControlsAndPageElements (bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideControlsAndPageElementsAnimated:"), animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("hideControlsAndPageElementsAnimated:"), animated);
			}
		}
		
		[Export ("pageViewForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageView PageViewForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("pageViewForPage:"), page));
			} else {
				return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("pageViewForPage:"), page));
			}
		}
		
		[Export ("presentPDFViewControllerWithDocument:options:sender:animated:configurationBlock:completion:")]
		[CompilerGenerated]
		public unsafe virtual void PresentPdfViewController (PSPDFDocument document, NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<PSPDFViewController> configurationHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHadler)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			BlockLiteral *block_ptr_configurationHandler;
			BlockLiteral block_configurationHandler;
			if (configurationHandler == null){
				block_ptr_configurationHandler = null;
			} else {
				block_configurationHandler = new BlockLiteral ();
				block_ptr_configurationHandler = &block_configurationHandler;
				block_configurationHandler.SetupBlock (Trampolines.SDActionArity1V2.Handler, configurationHandler);
			}
			BlockLiteral *block_ptr_completionHadler;
			BlockLiteral block_completionHadler;
			if (completionHadler == null){
				block_ptr_completionHadler = null;
			} else {
				block_completionHadler = new BlockLiteral ();
				block_ptr_completionHadler = &block_completionHadler;
				block_completionHadler.SetupBlock (Trampolines.SDAction.Handler, completionHadler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentPDFViewControllerWithDocument:options:sender:animated:configurationBlock:completion:"), document.Handle, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_configurationHandler, (IntPtr) block_ptr_completionHadler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentPDFViewControllerWithDocument:options:sender:animated:configurationBlock:completion:"), document.Handle, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_configurationHandler, (IntPtr) block_ptr_completionHadler);
			}
			if (block_ptr_configurationHandler != null)
				block_ptr_configurationHandler->CleanupBlock ();
			if (block_ptr_completionHadler != null)
				block_ptr_completionHadler->CleanupBlock ();
			
		}
		
		[Export ("presentPreviewControllerForURL:title:options:sender:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void PresentPreviewController (NSUrl fileUrl, string title, NSDictionary options, NSObject sender, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHadler)
		{
			if (fileUrl == null)
				throw new ArgumentNullException ("fileUrl");
			if (title == null)
				throw new ArgumentNullException ("title");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_completionHadler;
			BlockLiteral block_completionHadler;
			if (completionHadler == null){
				block_ptr_completionHadler = null;
			} else {
				block_completionHadler = new BlockLiteral ();
				block_ptr_completionHadler = &block_completionHadler;
				block_completionHadler.SetupBlock (Trampolines.SDAction.Handler, completionHadler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("presentPreviewControllerForURL:title:options:sender:animated:completion:"), fileUrl.Handle, nstitle, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_completionHadler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("presentPreviewControllerForURL:title:options:sender:animated:completion:"), fileUrl.Handle, nstitle, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated, (IntPtr) block_ptr_completionHadler);
			}
			NSString.ReleaseNative (nstitle);
			if (block_ptr_completionHadler != null)
				block_ptr_completionHadler->CleanupBlock ();
			
		}
		
		[Export ("presentViewController:options:animated:sender:error:completion:")]
		[CompilerGenerated]
		public unsafe virtual NSObject PresentViewController (global::UIKit.UIViewController controller, NSDictionary options, bool animated, NSObject sender, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
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
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentViewController:options:animated:sender:error:completion:"), controller.Handle, options == null ? IntPtr.Zero : options.Handle, animated, sender == null ? IntPtr.Zero : sender.Handle, ref errorValue, (IntPtr) block_ptr_completion));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool_IntPtr_ref_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentViewController:options:animated:sender:error:completion:"), controller.Handle, options == null ? IntPtr.Zero : options.Handle, animated, sender == null ? IntPtr.Zero : sender.Handle, ref errorValue, (IntPtr) block_ptr_completion));
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadData"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reloadData"));
			}
		}
		
		[Export ("backForwardList:requestedBackActionExecution:")]
		[CompilerGenerated]
		public virtual void RequestedBackActionExecution (PSPDFBackForwardActionList list, PSPDFAction[] actions)
		{
			if (list == null)
				throw new ArgumentNullException ("list");
			if (actions == null)
				throw new ArgumentNullException ("actions");
			var nsa_actions = NSArray.FromNSObjects (actions);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("backForwardList:requestedBackActionExecution:"), list.Handle, nsa_actions.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("backForwardList:requestedBackActionExecution:"), list.Handle, nsa_actions.Handle);
			}
			nsa_actions.Dispose ();
			
		}
		
		[Export ("backForwardList:requestedForwardActionExecution:")]
		[CompilerGenerated]
		public virtual void RequestedForwardActionExecution (PSPDFBackForwardActionList list, PSPDFAction[] actions)
		{
			if (list == null)
				throw new ArgumentNullException ("list");
			if (actions == null)
				throw new ArgumentNullException ("actions");
			var nsa_actions = NSArray.FromNSObjects (actions);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("backForwardList:requestedForwardActionExecution:"), list.Handle, nsa_actions.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("backForwardList:requestedForwardActionExecution:"), list.Handle, nsa_actions.Handle);
			}
			nsa_actions.Dispose ();
			
		}
		
		[Export ("scrollRectToVisible:animated:")]
		[CompilerGenerated]
		public virtual void ScrollRectToVisible (CGRect rect, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect_bool (this.Handle, Selector.GetHandle ("scrollRectToVisible:animated:"), rect, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect_bool (this.SuperHandle, Selector.GetHandle ("scrollRectToVisible:animated:"), rect, animated);
			}
		}
		
		[Export ("scrollToNextPageAnimated:")]
		[CompilerGenerated]
		public virtual bool ScrollToNextPage (bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("scrollToNextPageAnimated:"), animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("scrollToNextPageAnimated:"), animated);
			}
		}
		
		[Export ("scrollToPreviousPageAnimated:")]
		[CompilerGenerated]
		public virtual bool ScrollToPreviousPage (bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("scrollToPreviousPageAnimated:"), animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("scrollToPreviousPageAnimated:"), animated);
			}
		}
		
		[Export ("inlineSearchManagerSearchDidAppear:")]
		[CompilerGenerated]
		public virtual void SearchDidAppear (PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inlineSearchManagerSearchDidAppear:"), manager.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("inlineSearchManagerSearchDidAppear:"), manager.Handle);
			}
		}
		
		[Export ("inlineSearchManagerSearchDidDisappear:")]
		[CompilerGenerated]
		public virtual void SearchDidDisappear (PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inlineSearchManagerSearchDidDisappear:"), manager.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("inlineSearchManagerSearchDidDisappear:"), manager.Handle);
			}
		}
		
		[Export ("searchForString:options:sender:animated:")]
		[CompilerGenerated]
		public virtual void SearchForString (string searchText, NSDictionary options, NSObject sender, bool animated)
		{
			var nssearchText = NSString.CreateNative (searchText);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("searchForString:options:sender:animated:"), nssearchText, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("searchForString:options:sender:animated:"), nssearchText, options == null ? IntPtr.Zero : options.Handle, sender == null ? IntPtr.Zero : sender.Handle, animated);
			}
			NSString.ReleaseNative (nssearchText);
			
		}
		
		[Export ("searchViewController:searchRangeForScope:")]
		[CompilerGenerated]
		public virtual NSIndexSet SearchRangeForScope (PSPDFSearchViewController searchController, string scope)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			if (scope == null)
				throw new ArgumentNullException ("scope");
			var nsscope = NSString.CreateNative (scope);
			
			NSIndexSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("searchViewController:searchRangeForScope:"), searchController.Handle, nsscope));
			} else {
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("searchViewController:searchRangeForScope:"), searchController.Handle, nsscope));
			}
			NSString.ReleaseNative (nsscope);
			
			return ret;
		}
		
		[Export ("inlineSearchManagerSearchWillAppear:")]
		[CompilerGenerated]
		public virtual void SearchWillAppear (PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inlineSearchManagerSearchWillAppear:"), manager.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("inlineSearchManagerSearchWillAppear:"), manager.Handle);
			}
		}
		
		[Export ("inlineSearchManagerSearchWillDisappear:")]
		[CompilerGenerated]
		public virtual void SearchWillDisappear (PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inlineSearchManagerSearchWillDisappear:"), manager.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("inlineSearchManagerSearchWillDisappear:"), manager.Handle);
			}
		}
		
		[Export ("setHUDVisible:animated:")]
		[CompilerGenerated]
		public virtual bool SetHudVisible (bool show, bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setHUDVisible:animated:"), show, animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setHUDVisible:animated:"), show, animated);
			}
		}
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public virtual bool SetPage (global::System.nuint page, bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("setPage:animated:"), page, animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("setPage:animated:"), page, animated);
			}
		}
		
		[Export ("setUpdateSettingsForBoundsChangeBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetUpdateSettingsForBoundsChange ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<PSPDFViewController> handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDActionArity1V2.Handler, handler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUpdateSettingsForBoundsChangeBlock:"), (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUpdateSettingsForBoundsChangeBlock:"), (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("setViewMode:animated:")]
		[CompilerGenerated]
		public virtual void SetViewMode (PSPDFViewMode viewMode, bool animated)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_bool (this.Handle, Selector.GetHandle ("setViewMode:animated:"), (UInt64)viewMode, animated);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool (this.Handle, Selector.GetHandle ("setViewMode:animated:"), (UInt32)viewMode, animated);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64_bool (this.SuperHandle, Selector.GetHandle ("setViewMode:animated:"), (UInt64)viewMode, animated);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_bool (this.SuperHandle, Selector.GetHandle ("setViewMode:animated:"), (UInt32)viewMode, animated);
				}
			}
		}
		
		[Export ("setViewState:animated:")]
		[CompilerGenerated]
		public virtual void SetViewState (PSPDFViewState viewState, bool animateIfPossible)
		{
			if (viewState == null)
				throw new ArgumentNullException ("viewState");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setViewState:animated:"), viewState.Handle, animateIfPossible);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setViewState:animated:"), viewState.Handle, animateIfPossible);
			}
		}
		
		[Export ("setZoomScale:animated:")]
		[CompilerGenerated]
		public virtual void SetZoomScale (global::System.nfloat scale, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat_bool (this.Handle, Selector.GetHandle ("setZoomScale:animated:"), scale, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat_bool (this.SuperHandle, Selector.GetHandle ("setZoomScale:animated:"), scale, animated);
			}
		}
		
		[Export ("passwordView:shouldUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual bool ShouldUnlock (PSPDFPasswordView passwordView, string password)
		{
			if (passwordView == null)
				throw new ArgumentNullException ("passwordView");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("passwordView:shouldUnlockWithPassword:"), passwordView.Handle, nspassword);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("passwordView:shouldUnlockWithPassword:"), passwordView.Handle, nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("showControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool ShowControls (bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("showControlsAnimated:"), animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("showControlsAnimated:"), animated);
			}
		}
		
		[Export ("searchViewControllerTextSearchObject:")]
		[CompilerGenerated]
		public virtual PSPDFTextSearch TextSearchObject (PSPDFSearchViewController searchController)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFTextSearch> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("searchViewControllerTextSearchObject:"), searchController.Handle));
			} else {
				return  Runtime.GetNSObject<PSPDFTextSearch> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("searchViewControllerTextSearchObject:"), searchController.Handle));
			}
		}
		
		[Export ("toggleControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool ToggleControls (bool animated)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("toggleControlsAnimated:"), animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("toggleControlsAnimated:"), animated);
			}
		}
		
		[Export ("updateConfigurationWithBuilder:")]
		[CompilerGenerated]
		public unsafe virtual void UpdateConfiguration ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<PSPDFConfigurationBuilder> builderHandler)
		{
			if (builderHandler == null)
				throw new ArgumentNullException ("builderHandler");
			BlockLiteral *block_ptr_builderHandler;
			BlockLiteral block_builderHandler;
			block_builderHandler = new BlockLiteral ();
			block_ptr_builderHandler = &block_builderHandler;
			block_builderHandler.SetupBlock (Trampolines.SDActionArity1V0.Handler, builderHandler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("updateConfigurationWithBuilder:"), (IntPtr) block_ptr_builderHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("updateConfigurationWithBuilder:"), (IntPtr) block_ptr_builderHandler);
			}
			block_ptr_builderHandler->CleanupBlock ();
			
		}
		
		[Export ("updateConfigurationWithoutReloadingWithBuilder:")]
		[CompilerGenerated]
		public unsafe virtual void UpdateConfigurationWithoutReloading ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<PSPDFConfigurationBuilder> builderHandler)
		{
			if (builderHandler == null)
				throw new ArgumentNullException ("builderHandler");
			BlockLiteral *block_ptr_builderHandler;
			BlockLiteral block_builderHandler;
			block_builderHandler = new BlockLiteral ();
			block_ptr_builderHandler = &block_builderHandler;
			block_builderHandler.SetupBlock (Trampolines.SDActionArity1V0.Handler, builderHandler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("updateConfigurationWithoutReloadingWithBuilder:"), (IntPtr) block_ptr_builderHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("updateConfigurationWithoutReloadingWithBuilder:"), (IntPtr) block_ptr_builderHandler);
			}
			block_ptr_builderHandler->CleanupBlock ();
			
		}
		
		[Export ("updatePage:animated:")]
		[CompilerGenerated]
		public virtual void UpdatePage (global::System.nuint page, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("updatePage:animated:"), page, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("updatePage:animated:"), page, animated);
			}
		}
		
		[Export ("updateToolbarAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateToolbar (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateToolbarAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateToolbarAnimated:"), animated);
			}
		}
		
		[Export ("willStartSearch:term:isFullSearch:")]
		[CompilerGenerated]
		public virtual void WillStartSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("willStartSearch:term:isFullSearch:"), textSearch.Handle, nssearchTerm, isFullSearch);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("willStartSearch:term:isFullSearch:"), textSearch.Handle, nssearchTerm, isFullSearch);
			}
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[Export ("passwordView:willUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual void WillUnlock (PSPDFPasswordView passwordView, string password)
		{
			if (passwordView == null)
				throw new ArgumentNullException ("passwordView");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("passwordView:willUnlockWithPassword:"), passwordView.Handle, nspassword);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("passwordView:willUnlockWithPassword:"), passwordView.Handle, nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
		}
		
		[Export ("zoomToRect:page:animated:")]
		[CompilerGenerated]
		public virtual void ZoomToRect (CGRect rect, global::System.nuint page, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect_nuint_bool (this.Handle, Selector.GetHandle ("zoomToRect:page:animated:"), rect, page, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect_nuint_bool (this.SuperHandle, Selector.GetHandle ("zoomToRect:page:animated:"), rect, page, animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_ActivityButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem ActivityButtonItem {
			[Export ("activityButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("activityButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("activityButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ActivityButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem AnnotationButtonItem {
			[Export ("annotationButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationStateManager_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationStateManager AnnotationStateManager {
			[Export ("annotationStateManager", ArgumentSemantic.Retain)]
			get {
				PSPDFAnnotationStateManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAnnotationStateManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationStateManager")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAnnotationStateManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationStateManager")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationStateManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationToolbarController_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationToolbarController AnnotationToolbarController {
			[Export ("annotationToolbarController", ArgumentSemantic.Retain)]
			get {
				PSPDFAnnotationToolbarController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAnnotationToolbarController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationToolbarController")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAnnotationToolbarController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationToolbarController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationToolbarController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BackForwardList_var;
		[CompilerGenerated]
		public virtual PSPDFBackForwardActionList BackForwardList {
			[Export ("backForwardList", ArgumentSemantic.Retain)]
			get {
				PSPDFBackForwardActionList ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFBackForwardActionList> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backForwardList")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFBackForwardActionList> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backForwardList")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackForwardList_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BarButtonItemsAlwaysEnabled_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem[] BarButtonItemsAlwaysEnabled {
			[Export ("barButtonItemsAlwaysEnabled", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIBarButtonItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("barButtonItemsAlwaysEnabled")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIBarButtonItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barButtonItemsAlwaysEnabled")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarButtonItemsAlwaysEnabled_var = ret;
				return ret;
			}
			
			[Export ("setBarButtonItemsAlwaysEnabled:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBarButtonItemsAlwaysEnabled:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBarButtonItemsAlwaysEnabled:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_BarButtonItemsAlwaysEnabled_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BookmarkButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem BookmarkButtonItem {
			[Export ("bookmarkButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bookmarkButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bookmarkButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BookmarkButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BrightnessButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem BrightnessButtonItem {
			[Export ("brightnessButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("brightnessButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("brightnessButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BrightnessButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CloseButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem CloseButtonItem {
			[Export ("closeButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("closeButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("closeButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CloseButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Configuration_var;
		[CompilerGenerated]
		public virtual PSPDFConfiguration Configuration {
			[Export ("configuration", ArgumentSemantic.Copy)]
			get {
				PSPDFConfiguration ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("configuration")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("configuration")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Configuration_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGRect ContentRect {
			[Export ("contentRect")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("contentRect"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentRect"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentRect"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("contentRect"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentRect"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentRect"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentRect"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("contentRect"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual PSPDFRelayTouchesView ContentView {
			[Export ("contentView", ArgumentSemantic.Retain)]
			get {
				PSPDFRelayTouchesView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFRelayTouchesView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFRelayTouchesView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document", ArgumentSemantic.Retain)]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("document")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("document")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDocument:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDocument:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DocumentActionExecutor_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentActionExecutor DocumentActionExecutor {
			[Export ("documentActionExecutor", ArgumentSemantic.Retain)]
			get {
				PSPDFDocumentActionExecutor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocumentActionExecutor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentActionExecutor")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocumentActionExecutor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentActionExecutor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DocumentActionExecutor_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DocumentInfoCoordinator_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentInfoCoordinator DocumentInfoCoordinator {
			[Export ("documentInfoCoordinator", ArgumentSemantic.Retain)]
			get {
				PSPDFDocumentInfoCoordinator ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocumentInfoCoordinator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentInfoCoordinator")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocumentInfoCoordinator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentInfoCoordinator")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DocumentInfoCoordinator_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_EmailButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem EmailButtonItem {
			[Export ("emailButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("emailButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("emailButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_EmailButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FormSubmissionDelegate_var;
		[CompilerGenerated]
		public virtual IPSPDFFormSubmissionDelegate FormSubmissionDelegate {
			[Export ("formSubmissionDelegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFFormSubmissionDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFFormSubmissionDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("formSubmissionDelegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFFormSubmissionDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formSubmissionDelegate")), false);
				}
				MarkDirty ();
				__mt_FormSubmissionDelegate_var = ret;
				return ret;
			}
			
			[Export ("setFormSubmissionDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFormSubmissionDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFormSubmissionDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_FormSubmissionDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_HalfModalController_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController HalfModalController {
			[Export ("halfModalController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("halfModalController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("halfModalController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HalfModalController_var = ret;
				return ret;
			}
			
			[Export ("setHalfModalController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHalfModalController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHalfModalController:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_HalfModalController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_HudView_var;
		[CompilerGenerated]
		public virtual PSPDFHUDView HudView {
			[Export ("HUDView", ArgumentSemantic.Retain)]
			get {
				PSPDFHUDView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFHUDView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("HUDView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFHUDView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("HUDView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HudView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HudVisible {
			[Export ("isHUDVisible", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHUDVisible"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isHUDVisible"));
				}
			}
			
			[Export ("setHUDVisible:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHUDVisible:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHUDVisible:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_InlineSearchManager_var;
		[CompilerGenerated]
		public virtual PSPDFInlineSearchManager InlineSearchManager {
			[Export ("inlineSearchManager", ArgumentSemantic.Retain)]
			get {
				PSPDFInlineSearchManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFInlineSearchManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inlineSearchManager")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFInlineSearchManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inlineSearchManager")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_InlineSearchManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsDoublePageMode {
			[Export ("isDoublePageMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDoublePageMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDoublePageMode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsFirstPage {
			[Export ("isFirstPage")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFirstPage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isFirstPage"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLastPage {
			[Export ("isLastPage")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLastPage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLastPage"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LeftBarButtonItems_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem[] LeftBarButtonItems {
			[Export ("leftBarButtonItems", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIBarButtonItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftBarButtonItems")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIBarButtonItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftBarButtonItems")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LeftBarButtonItems_var = ret;
				return ret;
			}
			
			[Export ("setLeftBarButtonItems:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftBarButtonItems:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftBarButtonItems:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_LeftBarButtonItems_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_MessageButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem MessageButtonItem {
			[Export ("messageButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MessageButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool NavigationBarHidden {
			[Export ("isNavigationBarHidden", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isNavigationBarHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isNavigationBarHidden"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OpenInButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem OpenInButtonItem {
			[Export ("openInButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("openInButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openInButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OpenInButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OutlineButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem OutlineButtonItem {
			[Export ("outlineButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outlineButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("outlineButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OutlineButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Page {
			[Export ("page", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("page"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("page"));
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PagingScrollView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIScrollView PagingScrollView {
			[Export ("pagingScrollView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pagingScrollView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pagingScrollView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PagingScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PopoverController_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIPopoverController PopoverController {
			[Export ("popoverController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIPopoverController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("popoverController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("popoverController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PopoverController_var = ret;
				return ret;
			}
			
			[Export ("setPopoverController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPopoverController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPopoverController:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PopoverController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PresentedController_var;
		[CompilerGenerated]
		public virtual IPSPDFPresentableViewController PresentedController {
			[Export ("presentedController", ArgumentSemantic.Retain)]
			get {
				IPSPDFPresentableViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFPresentableViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("presentedController")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFPresentableViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presentedController")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PresentedController_var = ret;
				return ret;
			}
			
			[Export ("setPresentedController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPresentedController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPresentedController:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PresentedController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PrintButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem PrintButtonItem {
			[Export ("printButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("printButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("printButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PrintButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RightBarButtonItems_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem[] RightBarButtonItems {
			[Export ("rightBarButtonItems", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIBarButtonItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightBarButtonItems")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIBarButtonItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightBarButtonItems")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightBarButtonItems_var = ret;
				return ret;
			}
			
			[Export ("setRightBarButtonItems:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightBarButtonItems:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightBarButtonItems:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_RightBarButtonItems_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint ScreenPage {
			[Export ("screenPage", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("screenPage"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("screenPage"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ScrollingEnabled {
			[Export ("isScrollingEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isScrollingEnabled"));
				}
			}
			
			[Export ("setScrollingEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SearchActive {
			[Export ("isSearchActive", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSearchActive"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSearchActive"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SearchButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem SearchButtonItem {
			[Export ("searchButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("searchButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SearchHighlightViewManager_var;
		[CompilerGenerated]
		public virtual PSPDFSearchHighlightViewManager SearchHighlightViewManager {
			[Export ("searchHighlightViewManager", ArgumentSemantic.Retain)]
			get {
				PSPDFSearchHighlightViewManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSearchHighlightViewManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("searchHighlightViewManager")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSearchHighlightViewManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchHighlightViewManager")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchHighlightViewManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_TextSearch_var;
		[CompilerGenerated]
		public virtual PSPDFTextSearch TextSearch {
			[Export ("textSearch", ArgumentSemantic.Retain)]
			get {
				PSPDFTextSearch ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFTextSearch> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textSearch")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFTextSearch> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textSearch")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TextSearch_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ThumbnailController_var;
		[CompilerGenerated]
		public virtual PSPDFThumbnailViewController ThumbnailController {
			[Export ("thumbnailController", ArgumentSemantic.Retain)]
			get {
				PSPDFThumbnailViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFThumbnailViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailController")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFThumbnailViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ThumbnailController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ViewLockEnabled {
			[Export ("isViewLockEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isViewLockEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isViewLockEnabled"));
				}
			}
			
			[Export ("setViewLockEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setViewLockEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setViewLockEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFViewMode ViewMode {
			[Export ("viewMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFViewMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFViewMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("viewMode"));
					} else {
						ret = (PSPDFViewMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("viewMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFViewMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewMode"));
					} else {
						ret = (PSPDFViewMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewMode"));
					}
				}
				return ret;
			}
			
			[Export ("setViewMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setViewMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setViewMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setViewMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setViewMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ViewModeButtonItem_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBarButtonItem ViewModeButtonItem {
			[Export ("viewModeButtonItem", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBarButtonItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("viewModeButtonItem")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBarButtonItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewModeButtonItem")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ViewModeButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ViewState_var;
		[CompilerGenerated]
		public virtual PSPDFViewState ViewState {
			[Export ("viewState", ArgumentSemantic.Retain)]
			get {
				PSPDFViewState ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFViewState> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("viewState")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFViewState> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewState")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ViewState_var = ret;
				return ret;
			}
			
			[Export ("setViewState:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setViewState:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setViewState:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ViewState_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_VisiblePages_var;
		[CompilerGenerated]
		public virtual NSOrderedSet VisiblePages {
			[Export ("visiblePages")]
			get {
				NSOrderedSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePages")));
				} else {
					ret =  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visiblePages")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_VisiblePages_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _DidLoadPageViewNotification;
		[Field ("PSPDFViewControllerDidLoadPageViewNotification",  "__Internal")]
		public static unsafe NSString DidLoadPageViewNotification {
			get {
				if (_DidLoadPageViewNotification == null)
					_DidLoadPageViewNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFViewControllerDidLoadPageViewNotification");
				return _DidLoadPageViewNotification;
			}
		}
		[CompilerGenerated]
		static NSString _DidShowPageViewNotification;
		[Field ("PSPDFViewControllerDidShowPageViewNotification",  "__Internal")]
		public static unsafe NSString DidShowPageViewNotification {
			get {
				if (_DidShowPageViewNotification == null)
					_DidShowPageViewNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFViewControllerDidShowPageViewNotification");
				return _DidShowPageViewNotification;
			}
		}
		[CompilerGenerated]
		static NSString _SearchHeadlessKey;
		[Field ("PSPDFViewControllerSearchHeadlessKey",  "__Internal")]
		public static unsafe NSString SearchHeadlessKey {
			get {
				if (_SearchHeadlessKey == null)
					_SearchHeadlessKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFViewControllerSearchHeadlessKey");
				return _SearchHeadlessKey;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ActivityButtonItem_var = null;
				__mt_AnnotationButtonItem_var = null;
				__mt_AnnotationStateManager_var = null;
				__mt_AnnotationToolbarController_var = null;
				__mt_BackForwardList_var = null;
				__mt_BarButtonItemsAlwaysEnabled_var = null;
				__mt_BookmarkButtonItem_var = null;
				__mt_BrightnessButtonItem_var = null;
				__mt_CloseButtonItem_var = null;
				__mt_Configuration_var = null;
				__mt_ContentView_var = null;
				__mt_Delegate_var = null;
				__mt_Document_var = null;
				__mt_DocumentActionExecutor_var = null;
				__mt_DocumentInfoCoordinator_var = null;
				__mt_EmailButtonItem_var = null;
				__mt_FormSubmissionDelegate_var = null;
				__mt_HalfModalController_var = null;
				__mt_HudView_var = null;
				__mt_InlineSearchManager_var = null;
				__mt_LeftBarButtonItems_var = null;
				__mt_MessageButtonItem_var = null;
				__mt_OpenInButtonItem_var = null;
				__mt_OutlineButtonItem_var = null;
				__mt_PagingScrollView_var = null;
				__mt_PopoverController_var = null;
				__mt_PresentedController_var = null;
				__mt_PrintButtonItem_var = null;
				__mt_RightBarButtonItems_var = null;
				__mt_SearchButtonItem_var = null;
				__mt_SearchHighlightViewManager_var = null;
				__mt_TextSearch_var = null;
				__mt_ThumbnailController_var = null;
				__mt_ViewModeButtonItem_var = null;
				__mt_ViewState_var = null;
				__mt_VisiblePages_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDidLoadPageView (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidLoadPageViewNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDidShowPageView (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidShowPageViewNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFViewController */
}
