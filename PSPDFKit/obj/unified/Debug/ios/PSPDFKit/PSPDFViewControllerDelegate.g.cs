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
	[Protocol (Name = "PSPDFViewControllerDelegate", WrapperType = typeof (PSPDFViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeDocument", Selector = "pdfViewController:shouldChangeDocument:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeDocument", Selector = "pdfViewController:didChangeDocument:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFDocument) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldScrollToPage", Selector = "pdfViewController:shouldScrollToPage:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowPageView", Selector = "pdfViewController:didShowPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRenderPageView", Selector = "pdfViewController:didRenderPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadPageView", Selector = "pdfViewController:didLoadPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUnloadPageView", Selector = "pdfViewController:willUnloadPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginPageDragging", Selector = "pdfViewController:didBeginPageDragging:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (UIScrollView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPageDragging", Selector = "pdfViewController:didEndPageDragging:willDecelerate:withVelocity:targetContentOffset:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (UIScrollView), typeof (bool), typeof (CGPoint), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPageScrollingAnimation", Selector = "pdfViewController:didEndPageScrollingAnimation:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (UIScrollView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginPageZooming", Selector = "pdfViewController:didBeginPageZooming:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (UIScrollView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPageZooming", Selector = "pdfViewController:didEndPageZooming:atScale:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (UIScrollView), typeof (nfloat) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DocumentForRelativePath", Selector = "pdfViewController:documentForRelativePath:", ReturnType = typeof (PSPDFKit.PSPDFDocument), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTapOnPageView", Selector = "pdfViewController:didTapOnPageView:atPoint:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFPageView), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLongPressOnPageView", Selector = "pdfViewController:didLongPressOnPageView:atPoint:gestureRecognizer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFPageView), typeof (CGPoint), typeof (UILongPressGestureRecognizer) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectText", Selector = "pdfViewController:shouldSelectText:withGlyphs:atRect:onPageView:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (string), typeof (PSPDFKit.PSPDFGlyph[]), typeof (CGRect), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectText", Selector = "pdfViewController:didSelectText:withGlyphs:atRect:onPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (string), typeof (PSPDFKit.PSPDFGlyph[]), typeof (CGRect), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowMenuItemsForSelectedText", Selector = "pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedText:inRect:onPageView:", ReturnType = typeof (PSPDFKit.PSPDFMenuItem[]), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFMenuItem[]), typeof (CGRect), typeof (string), typeof (CGRect), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowMenuItemsForSelectedImage", Selector = "pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedImage:inRect:onPageView:", ReturnType = typeof (PSPDFKit.PSPDFMenuItem[]), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFMenuItem[]), typeof (CGRect), typeof (PSPDFKit.PSPDFImageInfo), typeof (CGRect), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowMenuItemsForAnnotations", Selector = "pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forAnnotations:inRect:onPageView:", ReturnType = typeof (PSPDFKit.PSPDFMenuItem[]), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFMenuItem[]), typeof (CGRect), typeof (PSPDFKit.PSPDFAnnotation[]), typeof (CGRect), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDisplayAnnotation", Selector = "pdfViewController:shouldDisplayAnnotation:onPageView:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFAnnotation), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTapOnAnnotation", Selector = "pdfViewController:didTapOnAnnotation:annotationPoint:annotationView:pageView:viewPoint:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFAnnotation), typeof (CGPoint), typeof (PSPDFKit.IPSPDFAnnotationViewProtocol), typeof (PSPDFKit.PSPDFPageView), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectAnnotations", Selector = "pdfViewController:shouldSelectAnnotations:onPageView:", ReturnType = typeof (PSPDFKit.PSPDFAnnotation[]), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFAnnotation[]), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectAnnotations", Selector = "pdfViewController:didSelectAnnotations:onPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (NSObject[]), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnnotationView", Selector = "pdfViewController:annotationView:forAnnotation:onPageView:", ReturnType = typeof (PSPDFKit.IPSPDFAnnotationViewProtocol), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.IPSPDFAnnotationViewProtocol), typeof (PSPDFKit.PSPDFAnnotation), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShowAnnotationView", Selector = "pdfViewController:willShowAnnotationView:onPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.IPSPDFAnnotationViewProtocol), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowAnnotationView", Selector = "pdfViewController:didShowAnnotationView:onPageView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.IPSPDFAnnotationViewProtocol), typeof (PSPDFKit.PSPDFPageView) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowController", Selector = "pdfViewController:shouldShowController:embeddedInController:options:animated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.IPSPDFPresentableViewController), typeof (PSPDFKit.IPSPDFHostableViewController), typeof (NSDictionary), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowController", Selector = "pdfViewController:didShowController:embeddedInController:options:animated:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.IPSPDFPresentableViewController), typeof (PSPDFKit.IPSPDFHostableViewController), typeof (NSDictionary), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeViewMode", Selector = "pdfViewController:didChangeViewMode:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFViewMode) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PdfViewControllerWillDismiss", Selector = "pdfViewControllerWillDismiss:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PdfViewControllerDidDismiss", Selector = "pdfViewControllerDidDismiss:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowHud", Selector = "pdfViewController:shouldShowHUD:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowHud", Selector = "pdfViewController:didShowHUD:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldHideHud", Selector = "pdfViewController:shouldHideHUD:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHideHud", Selector = "pdfViewController:didHideHUD:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldExecuteAction", Selector = "pdfViewController:shouldExecuteAction:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFViewController), typeof (PSPDFKit.PSPDFAction) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static bool ShouldChangeDocument (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFDocument document)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:shouldChangeDocument:"), pdfController.Handle, document == null ? IntPtr.Zero : document.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeDocument (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFDocument document)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didChangeDocument:"), pdfController.Handle, document == null ? IntPtr.Zero : document.Handle);
		}
		
		[CompilerGenerated]
		public static bool ShouldScrollToPage (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, global::System.nuint page)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nuint (This.Handle, Selector.GetHandle ("pdfViewController:shouldScrollToPage:"), pdfController.Handle, page);
		}
		
		[CompilerGenerated]
		public static void DidShowPageView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didShowPageView:"), pdfController.Handle, pageView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidRenderPageView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didRenderPageView:"), pdfController.Handle, pageView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidLoadPageView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didLoadPageView:"), pdfController.Handle, pageView.Handle);
		}
		
		[CompilerGenerated]
		public static void WillUnloadPageView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:willUnloadPageView:"), pdfController.Handle, pageView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidBeginPageDragging (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didBeginPageDragging:"), pdfController.Handle, scrollView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidEndPageDragging (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView, bool decelerate, CGPoint velocity, CGPoint targetContentOffset)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool_CGPoint_CGPoint (This.Handle, Selector.GetHandle ("pdfViewController:didEndPageDragging:willDecelerate:withVelocity:targetContentOffset:"), pdfController.Handle, scrollView.Handle, decelerate, velocity, targetContentOffset);
		}
		
		[CompilerGenerated]
		public static void DidEndPageScrollingAnimation (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didEndPageScrollingAnimation:"), pdfController.Handle, scrollView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidBeginPageZooming (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didBeginPageZooming:"), pdfController.Handle, scrollView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidEndPageZooming (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView, global::System.nfloat scale)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (scrollView == null)
				throw new ArgumentNullException ("scrollView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nfloat (This.Handle, Selector.GetHandle ("pdfViewController:didEndPageZooming:atScale:"), pdfController.Handle, scrollView.Handle, scale);
		}
		
		[CompilerGenerated]
		public static PSPDFDocument DocumentForRelativePath (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, string relativePath)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (relativePath == null)
				throw new ArgumentNullException ("relativePath");
			var nsrelativePath = NSString.CreateNative (relativePath);
			
			PSPDFDocument ret;
			ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:documentForRelativePath:"), pdfController.Handle, nsrelativePath));
			NSString.ReleaseNative (nsrelativePath);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool DidTapOnPageView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFPageView pageView, CGPoint viewPoint)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_CGPoint (This.Handle, Selector.GetHandle ("pdfViewController:didTapOnPageView:atPoint:"), pdfController.Handle, pageView.Handle, viewPoint);
		}
		
		[CompilerGenerated]
		public static bool DidLongPressOnPageView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFPageView pageView, CGPoint viewPoint, global::UIKit.UILongPressGestureRecognizer gestureRecognizer)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			if (gestureRecognizer == null)
				throw new ArgumentNullException ("gestureRecognizer");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didLongPressOnPageView:atPoint:gestureRecognizer:"), pdfController.Handle, pageView.Handle, viewPoint, gestureRecognizer.Handle);
		}
		
		[CompilerGenerated]
		public static bool ShouldSelectText (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, string text, PSPDFGlyph[] glyphs, CGRect rect, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (text == null)
				throw new ArgumentNullException ("text");
			if (glyphs == null)
				throw new ArgumentNullException ("glyphs");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			var nstext = NSString.CreateNative (text);
			var nsa_glyphs = NSArray.FromNSObjects (glyphs);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_CGRect_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:shouldSelectText:withGlyphs:atRect:onPageView:"), pdfController.Handle, nstext, nsa_glyphs.Handle, rect, pageView.Handle);
			NSString.ReleaseNative (nstext);
			nsa_glyphs.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void DidSelectText (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, string text, PSPDFGlyph[] glyphs, CGRect rect, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (text == null)
				throw new ArgumentNullException ("text");
			if (glyphs == null)
				throw new ArgumentNullException ("glyphs");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			var nstext = NSString.CreateNative (text);
			var nsa_glyphs = NSArray.FromNSObjects (glyphs);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_CGRect_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didSelectText:withGlyphs:atRect:onPageView:"), pdfController.Handle, nstext, nsa_glyphs.Handle, rect, pageView.Handle);
			NSString.ReleaseNative (nstext);
			nsa_glyphs.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static PSPDFMenuItem[] ShouldShowMenuItemsForSelectedText (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, CGRect rect, string selectedText, CGRect textRect, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (menuItems == null)
				throw new ArgumentNullException ("menuItems");
			if (selectedText == null)
				throw new ArgumentNullException ("selectedText");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			var nsa_menuItems = NSArray.FromNSObjects (menuItems);
			var nsselectedText = NSString.CreateNative (selectedText);
			
			PSPDFMenuItem[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr_CGRect_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedText:inRect:onPageView:"), pdfController.Handle, nsa_menuItems.Handle, rect, nsselectedText, textRect, pageView.Handle));
			nsa_menuItems.Dispose ();
			NSString.ReleaseNative (nsselectedText);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static PSPDFMenuItem[] ShouldShowMenuItemsForSelectedImage (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, CGRect rect, PSPDFImageInfo selectedImage, CGRect textRect, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (menuItems == null)
				throw new ArgumentNullException ("menuItems");
			if (selectedImage == null)
				throw new ArgumentNullException ("selectedImage");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			var nsa_menuItems = NSArray.FromNSObjects (menuItems);
			
			PSPDFMenuItem[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr_CGRect_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedImage:inRect:onPageView:"), pdfController.Handle, nsa_menuItems.Handle, rect, selectedImage.Handle, textRect, pageView.Handle));
			nsa_menuItems.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static PSPDFMenuItem[] ShouldShowMenuItemsForAnnotations (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, CGRect rect, PSPDFAnnotation[] annotations, CGRect annotationRect, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (menuItems == null)
				throw new ArgumentNullException ("menuItems");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			var nsa_menuItems = NSArray.FromNSObjects (menuItems);
			var nsa_annotations = annotations == null ? null : NSArray.FromNSObjects (annotations);
			
			PSPDFMenuItem[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr_CGRect_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forAnnotations:inRect:onPageView:"), pdfController.Handle, nsa_menuItems.Handle, rect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, annotationRect, pageView.Handle));
			nsa_menuItems.Dispose ();
			if (nsa_annotations != null)
				nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool ShouldDisplayAnnotation (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:shouldDisplayAnnotation:onPageView:"), pdfController.Handle, annotation.Handle, pageView.Handle);
		}
		
		[CompilerGenerated]
		public static bool DidTapOnAnnotation (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFAnnotation annotation, CGPoint annotationPoint, IPSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView, CGPoint viewPoint)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr_IntPtr_CGPoint (This.Handle, Selector.GetHandle ("pdfViewController:didTapOnAnnotation:annotationPoint:annotationView:pageView:viewPoint:"), pdfController.Handle, annotation.Handle, annotationPoint, annotationView == null ? IntPtr.Zero : annotationView.Handle, pageView.Handle, viewPoint);
		}
		
		[CompilerGenerated]
		public static PSPDFAnnotation[] ShouldSelectAnnotations (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFAnnotation[] annotations, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			PSPDFAnnotation[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:shouldSelectAnnotations:onPageView:"), pdfController.Handle, nsa_annotations.Handle, pageView.Handle));
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void DidSelectAnnotations (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, NSObject[] annotations, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didSelectAnnotations:onPageView:"), pdfController.Handle, nsa_annotations.Handle, pageView.Handle);
			nsa_annotations.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static IPSPDFAnnotationViewProtocol AnnotationView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, IPSPDFAnnotationViewProtocol annotationView, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			return  Runtime.GetINativeObject<IPSPDFAnnotationViewProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:annotationView:forAnnotation:onPageView:"), pdfController.Handle, annotationView == null ? IntPtr.Zero : annotationView.Handle, annotation.Handle, pageView.Handle), false);
		}
		
		[CompilerGenerated]
		public static void WillShowAnnotationView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, IPSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (annotationView == null)
				throw new ArgumentNullException ("annotationView");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:willShowAnnotationView:onPageView:"), pdfController.Handle, annotationView.Handle, pageView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidShowAnnotationView (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, IPSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (annotationView == null)
				throw new ArgumentNullException ("annotationView");
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:didShowAnnotationView:onPageView:"), pdfController.Handle, annotationView.Handle, pageView.Handle);
		}
		
		[CompilerGenerated]
		public static bool ShouldShowController (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, IPSPDFPresentableViewController controller, IPSPDFHostableViewController hostController, NSDictionary options, bool animated)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (options == null)
				throw new ArgumentNullException ("options");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool (This.Handle, Selector.GetHandle ("pdfViewController:shouldShowController:embeddedInController:options:animated:"), pdfController.Handle, controller.Handle, hostController == null ? IntPtr.Zero : hostController.Handle, options.Handle, animated);
		}
		
		[CompilerGenerated]
		public static void DidShowController (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, IPSPDFPresentableViewController controller, IPSPDFHostableViewController hostController, NSDictionary options, bool animated)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (options == null)
				throw new ArgumentNullException ("options");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool (This.Handle, Selector.GetHandle ("pdfViewController:didShowController:embeddedInController:options:animated:"), pdfController.Handle, controller.Handle, hostController == null ? IntPtr.Zero : hostController.Handle, options.Handle, animated);
		}
		
		[CompilerGenerated]
		public static void DidChangeViewMode (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFViewMode viewMode)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("pdfViewController:didChangeViewMode:"), pdfController.Handle, (UInt64)viewMode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("pdfViewController:didChangeViewMode:"), pdfController.Handle, (UInt32)viewMode);
			}
		}
		
		[CompilerGenerated]
		public static void PdfViewControllerWillDismiss (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("pdfViewControllerWillDismiss:"), pdfController.Handle);
		}
		
		[CompilerGenerated]
		public static void PdfViewControllerDidDismiss (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("pdfViewControllerDidDismiss:"), pdfController.Handle);
		}
		
		[CompilerGenerated]
		public static bool ShouldShowHud (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, bool animated)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("pdfViewController:shouldShowHUD:"), pdfController.Handle, animated);
		}
		
		[CompilerGenerated]
		public static void DidShowHud (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, bool animated)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("pdfViewController:didShowHUD:"), pdfController.Handle, animated);
		}
		
		[CompilerGenerated]
		public static bool ShouldHideHud (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, bool animated)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("pdfViewController:shouldHideHUD:"), pdfController.Handle, animated);
		}
		
		[CompilerGenerated]
		public static void DidHideHud (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, bool animated)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("pdfViewController:didHideHUD:"), pdfController.Handle, animated);
		}
		
		[CompilerGenerated]
		public static void ShouldExecuteAction (this IPSPDFViewControllerDelegate This, PSPDFViewController pdfController, PSPDFAction action)
		{
			if (pdfController == null)
				throw new ArgumentNullException ("pdfController");
			if (action == null)
				throw new ArgumentNullException ("action");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfViewController:shouldExecuteAction:"), pdfController.Handle, action.Handle);
		}
		
	}
	
	internal sealed class PSPDFViewControllerDelegateWrapper : BaseWrapper, IPSPDFViewControllerDelegate {
		public PSPDFViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFViewControllerDelegate : NSObject, IPSPDFViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("pdfViewController:annotationView:forAnnotation:onPageView:")]
		[CompilerGenerated]
		public virtual IPSPDFAnnotationViewProtocol AnnotationView (PSPDFViewController pdfController, IPSPDFAnnotationViewProtocol annotationView, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didBeginPageDragging:")]
		[CompilerGenerated]
		public virtual void DidBeginPageDragging (PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didBeginPageZooming:")]
		[CompilerGenerated]
		public virtual void DidBeginPageZooming (PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didChangeDocument:")]
		[CompilerGenerated]
		public virtual void DidChangeDocument (PSPDFViewController pdfController, PSPDFDocument document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didChangeViewMode:")]
		[CompilerGenerated]
		public virtual void DidChangeViewMode (PSPDFViewController pdfController, PSPDFViewMode viewMode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageDragging:willDecelerate:withVelocity:targetContentOffset:")]
		[CompilerGenerated]
		public virtual void DidEndPageDragging (PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView, bool decelerate, CGPoint velocity, CGPoint targetContentOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageScrollingAnimation:")]
		[CompilerGenerated]
		public virtual void DidEndPageScrollingAnimation (PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didEndPageZooming:atScale:")]
		[CompilerGenerated]
		public virtual void DidEndPageZooming (PSPDFViewController pdfController, global::UIKit.UIScrollView scrollView, global::System.nfloat scale)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didHideHUD:")]
		[CompilerGenerated]
		public virtual void DidHideHud (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didLoadPageView:")]
		[CompilerGenerated]
		public virtual void DidLoadPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didLongPressOnPageView:atPoint:gestureRecognizer:")]
		[CompilerGenerated]
		public virtual bool DidLongPressOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, CGPoint viewPoint, global::UIKit.UILongPressGestureRecognizer gestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didRenderPageView:")]
		[CompilerGenerated]
		public virtual void DidRenderPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didSelectAnnotations:onPageView:")]
		[CompilerGenerated]
		public virtual void DidSelectAnnotations (PSPDFViewController pdfController, NSObject[] annotations, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didSelectText:withGlyphs:atRect:onPageView:")]
		[CompilerGenerated]
		public virtual void DidSelectText (PSPDFViewController pdfController, string text, PSPDFGlyph[] glyphs, CGRect rect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowAnnotationView:onPageView:")]
		[CompilerGenerated]
		public virtual void DidShowAnnotationView (PSPDFViewController pdfController, IPSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowController:embeddedInController:options:animated:")]
		[CompilerGenerated]
		public virtual void DidShowController (PSPDFViewController pdfController, IPSPDFPresentableViewController controller, IPSPDFHostableViewController hostController, NSDictionary options, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowHUD:")]
		[CompilerGenerated]
		public virtual void DidShowHud (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didShowPageView:")]
		[CompilerGenerated]
		public virtual void DidShowPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didTapOnAnnotation:annotationPoint:annotationView:pageView:viewPoint:")]
		[CompilerGenerated]
		public virtual bool DidTapOnAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, CGPoint annotationPoint, IPSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView, CGPoint viewPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:didTapOnPageView:atPoint:")]
		[CompilerGenerated]
		public virtual bool DidTapOnPageView (PSPDFViewController pdfController, PSPDFPageView pageView, CGPoint viewPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:documentForRelativePath:")]
		[CompilerGenerated]
		public virtual PSPDFDocument DocumentForRelativePath (PSPDFViewController pdfController, string relativePath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewControllerDidDismiss:")]
		[CompilerGenerated]
		public virtual void PdfViewControllerDidDismiss (PSPDFViewController pdfController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewControllerWillDismiss:")]
		[CompilerGenerated]
		public virtual void PdfViewControllerWillDismiss (PSPDFViewController pdfController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldChangeDocument:")]
		[CompilerGenerated]
		public virtual bool ShouldChangeDocument (PSPDFViewController pdfController, PSPDFDocument document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldDisplayAnnotation:onPageView:")]
		[CompilerGenerated]
		public virtual bool ShouldDisplayAnnotation (PSPDFViewController pdfController, PSPDFAnnotation annotation, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldExecuteAction:")]
		[CompilerGenerated]
		public virtual void ShouldExecuteAction (PSPDFViewController pdfController, PSPDFAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldHideHUD:")]
		[CompilerGenerated]
		public virtual bool ShouldHideHud (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldScrollToPage:")]
		[CompilerGenerated]
		public virtual bool ShouldScrollToPage (PSPDFViewController pdfController, global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldSelectAnnotations:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] ShouldSelectAnnotations (PSPDFViewController pdfController, PSPDFAnnotation[] annotations, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldSelectText:withGlyphs:atRect:onPageView:")]
		[CompilerGenerated]
		public virtual bool ShouldSelectText (PSPDFViewController pdfController, string text, PSPDFGlyph[] glyphs, CGRect rect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowController:embeddedInController:options:animated:")]
		[CompilerGenerated]
		public virtual bool ShouldShowController (PSPDFViewController pdfController, IPSPDFPresentableViewController controller, IPSPDFHostableViewController hostController, NSDictionary options, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowHUD:")]
		[CompilerGenerated]
		public virtual bool ShouldShowHud (PSPDFViewController pdfController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forAnnotations:inRect:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] ShouldShowMenuItemsForAnnotations (PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, CGRect rect, PSPDFAnnotation[] annotations, CGRect annotationRect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedImage:inRect:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] ShouldShowMenuItemsForSelectedImage (PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, CGRect rect, PSPDFImageInfo selectedImage, CGRect textRect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:shouldShowMenuItems:atSuggestedTargetRect:forSelectedText:inRect:onPageView:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] ShouldShowMenuItemsForSelectedText (PSPDFViewController pdfController, PSPDFMenuItem[] menuItems, CGRect rect, string selectedText, CGRect textRect, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:willShowAnnotationView:onPageView:")]
		[CompilerGenerated]
		public virtual void WillShowAnnotationView (PSPDFViewController pdfController, IPSPDFAnnotationViewProtocol annotationView, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfViewController:willUnloadPageView:")]
		[CompilerGenerated]
		public virtual void WillUnloadPageView (PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFViewControllerDelegate */
}
