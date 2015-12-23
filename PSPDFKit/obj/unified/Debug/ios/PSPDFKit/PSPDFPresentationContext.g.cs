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
	[Protocol (Name = "PSPDFPresentationContext", WrapperType = typeof (PSPDFPresentationContextWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetConfiguration", Selector = "configuration", ReturnType = typeof (PSPDFKit.PSPDFConfiguration))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPSPdfKit", Selector = "pspdfkit", ReturnType = typeof (PSPDFKit.PSPDFKitGlobal))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayingViewController", Selector = "displayingViewController", ReturnType = typeof (UIViewController))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPopoverController", Selector = "popoverController", ReturnType = typeof (UIPopoverController))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HalfModalController", Selector = "halfModalController", ReturnType = typeof (UIViewController))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetVisibleViewControllerInPopoverController", Selector = "visibleViewControllerInPopoverController", ReturnType = typeof (UIViewController))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDocument", Selector = "document", ReturnType = typeof (PSPDFKit.PSPDFDocument))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewMode", Selector = "viewMode", ReturnType = typeof (PSPDFKit.PSPDFViewMode))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContentRect", Selector = "contentRect", ReturnType = typeof (CGRect))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetScrollViewInsets", Selector = "scrollViewInsets", ReturnType = typeof (UIEdgeInsets))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDoublePageMode", Selector = "isDoublePageMode", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetScrollingEnabled", Selector = "isScrollingEnabled", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewLockEnabled", Selector = "isViewLockEnabled", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRotationActive", Selector = "isRotationActive", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHudVisible", Selector = "isHUDVisible", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewWillAppearing", Selector = "isViewWillAppearing", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisiblePageViews", Selector = "visiblePageViews", ReturnType = typeof (NSObject[]))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisiblePageViewsForcingLayout", Selector = "visiblePageViewsForcingLayout:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PageViewForPage", Selector = "pageViewForPage:", ReturnType = typeof (PSPDFKit.PSPDFPageView), ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsRightPageInDoublePageMode", Selector = "isRightPageInDoublePageMode:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsDoublePageModeForLandscape", Selector = "isDoublePageModeForLandscape:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsDoublePageModeForPage", Selector = "isDoublePageModeForPage:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PortraitPageForLandscapePage", Selector = "portraitPageForLandscapePage:", ReturnType = typeof (nuint), ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LandscapePageForPage", Selector = "landscapePageForPage:", ReturnType = typeof (nuint), ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPagingScrollView", Selector = "pagingScrollView", ReturnType = typeof (UIScrollView))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnnotationStateManager", Selector = "annotationStateManager", ReturnType = typeof (PSPDFKit.PSPDFAnnotationStateManager))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnnotationToolbarController", Selector = "annotationToolbarController", ReturnType = typeof (PSPDFKit.PSPDFAnnotationToolbarController))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetActionDelegate", Selector = "actionDelegate", ReturnType = typeof (PSPDFKit.IPSPDFControlDelegate))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPdfController", Selector = "pdfController", ReturnType = typeof (PSPDFKit.PSPDFViewController))]
	public interface IPSPDFPresentationContext : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFErrorHandler
		, PSPDFKit.IPSPDFOverridable
		, PSPDFKit.IPSPDFVisiblePagesDataSource
		
	{
	}
	
	public static partial class PSPDFPresentationContext_Extensions {
		[CompilerGenerated]
		public static PSPDFConfiguration GetConfiguration (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("configuration")));
		}
		
		[CompilerGenerated]
		public static PSPDFKitGlobal GetPSPdfKit (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<PSPDFKitGlobal> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("pspdfkit")));
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIViewController GetDisplayingViewController (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("displayingViewController")));
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIPopoverController GetPopoverController (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("popoverController")));
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIViewController HalfModalController (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("halfModalController")));
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIViewController GetVisibleViewControllerInPopoverController (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("visibleViewControllerInPopoverController")));
		}
		
		[CompilerGenerated]
		public static PSPDFDocument GetDocument (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("document")));
		}
		
		[CompilerGenerated]
		public static PSPDFViewMode GetViewMode (this IPSPDFPresentationContext This)
		{
			PSPDFViewMode ret;
			if (IntPtr.Size == 8) {
				ret = (PSPDFViewMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("viewMode"));
			} else {
				ret = (PSPDFViewMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("viewMode"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static CGRect GetContentRect (this IPSPDFPresentationContext This)
		{
			CGRect ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("contentRect"));
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("contentRect"));
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("contentRect"));
			} else {
				global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("contentRect"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIEdgeInsets GetScrollViewInsets (this IPSPDFPresentationContext This)
		{
			global::UIKit.UIEdgeInsets ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (This.Handle, Selector.GetHandle ("scrollViewInsets"));
				} else {
					global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("scrollViewInsets"));
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("scrollViewInsets"));
			} else {
				global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("scrollViewInsets"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static bool GetDoublePageMode (this IPSPDFPresentationContext This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDoublePageMode"));
		}
		
		[CompilerGenerated]
		public static bool GetScrollingEnabled (this IPSPDFPresentationContext This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isScrollingEnabled"));
		}
		
		[CompilerGenerated]
		public static bool GetViewLockEnabled (this IPSPDFPresentationContext This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isViewLockEnabled"));
		}
		
		[CompilerGenerated]
		public static bool GetRotationActive (this IPSPDFPresentationContext This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isRotationActive"));
		}
		
		[CompilerGenerated]
		public static bool GetHudVisible (this IPSPDFPresentationContext This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isHUDVisible"));
		}
		
		[CompilerGenerated]
		public static bool GetViewWillAppearing (this IPSPDFPresentationContext This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isViewWillAppearing"));
		}
		
		[CompilerGenerated]
		public static NSObject[] VisiblePageViews (this IPSPDFPresentationContext This)
		{
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("visiblePageViews")));
		}
		
		[CompilerGenerated]
		public static NSObject[] VisiblePageViewsForcingLayout (this IPSPDFPresentationContext This, bool forcingLayout)
		{
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_bool (This.Handle, Selector.GetHandle ("visiblePageViewsForcingLayout:"), forcingLayout));
		}
		
		[CompilerGenerated]
		public static PSPDFPageView PageViewForPage (this IPSPDFPresentationContext This, global::System.nuint page)
		{
			return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("pageViewForPage:"), page));
		}
		
		[CompilerGenerated]
		public static bool IsRightPageInDoublePageMode (this IPSPDFPresentationContext This, global::System.nuint page)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("isRightPageInDoublePageMode:"), page);
		}
		
		[CompilerGenerated]
		public static bool IsDoublePageModeForLandscape (this IPSPDFPresentationContext This, bool isLandscape)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("isDoublePageModeForLandscape:"), isLandscape);
		}
		
		[CompilerGenerated]
		public static bool IsDoublePageModeForPage (this IPSPDFPresentationContext This, global::System.nuint page)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("isDoublePageModeForPage:"), page);
		}
		
		[CompilerGenerated]
		public static global::System.nuint PortraitPageForLandscapePage (this IPSPDFPresentationContext This, global::System.nuint page)
		{
			return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("portraitPageForLandscapePage:"), page);
		}
		
		[CompilerGenerated]
		public static global::System.nuint LandscapePageForPage (this IPSPDFPresentationContext This, global::System.nuint aPage)
		{
			return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("landscapePageForPage:"), aPage);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIScrollView GetPagingScrollView (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("pagingScrollView")));
		}
		
		[CompilerGenerated]
		public static PSPDFAnnotationStateManager GetAnnotationStateManager (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<PSPDFAnnotationStateManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("annotationStateManager")));
		}
		
		[CompilerGenerated]
		public static PSPDFAnnotationToolbarController GetAnnotationToolbarController (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<PSPDFAnnotationToolbarController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("annotationToolbarController")));
		}
		
		[CompilerGenerated]
		public static IPSPDFControlDelegate GetActionDelegate (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetINativeObject<IPSPDFControlDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("actionDelegate")), false);
		}
		
		[CompilerGenerated]
		public static PSPDFViewController GetPdfController (this IPSPDFPresentationContext This)
		{
			return  Runtime.GetNSObject<PSPDFViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("pdfController")));
		}
		
	}
	
	internal sealed class PSPDFPresentationContextWrapper : BaseWrapper, IPSPDFPresentationContext {
		public PSPDFPresentationContextWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFPresentationContextWrapper (IntPtr handle, bool owns)
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
		
		[Export ("visiblePages")]
		[CompilerGenerated]
		public NSOrderedSet VisiblePages ()
		{
			return  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePages")));
		}
		
		[Export ("visiblePagesCalculated")]
		[CompilerGenerated]
		public NSOrderedSet VisiblePagesCalculated ()
		{
			return  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePagesCalculated")));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFPresentationContext", false)]
	[Model]
	public unsafe partial class PSPDFPresentationContext : NSObject, IPSPDFPresentationContext, IPSPDFErrorHandler, IPSPDFOverridable, IPSPDFVisiblePagesDataSource {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFPresentationContext () : base (NSObjectFlag.Empty)
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
		protected PSPDFPresentationContext (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPresentationContext (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("actionDelegate")]
		[CompilerGenerated]
		public virtual IPSPDFControlDelegate GetActionDelegate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("annotationStateManager")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationStateManager GetAnnotationStateManager ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("annotationToolbarController")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationToolbarController GetAnnotationToolbarController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("configuration")]
		[CompilerGenerated]
		public virtual PSPDFConfiguration GetConfiguration ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("contentRect")]
		[CompilerGenerated]
		public virtual CGRect GetContentRect ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("displayingViewController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController GetDisplayingViewController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("document")]
		[CompilerGenerated]
		public virtual PSPDFDocument GetDocument ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isDoublePageMode")]
		[CompilerGenerated]
		public virtual bool GetDoublePageMode ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isHUDVisible")]
		[CompilerGenerated]
		public virtual bool GetHudVisible ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("page")]
		[CompilerGenerated]
		public virtual global::System.nuint GetPage ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pagingScrollView")]
		[CompilerGenerated]
		public virtual global::UIKit.UIScrollView GetPagingScrollView ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfController")]
		[CompilerGenerated]
		public virtual PSPDFViewController GetPdfController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("popoverController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIPopoverController GetPopoverController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pspdfkit")]
		[CompilerGenerated]
		public virtual PSPDFKitGlobal GetPSPdfKit ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isRotationActive")]
		[CompilerGenerated]
		public virtual bool GetRotationActive ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isScrollingEnabled")]
		[CompilerGenerated]
		public virtual bool GetScrollingEnabled ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("scrollViewInsets")]
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets GetScrollViewInsets ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isViewLockEnabled")]
		[CompilerGenerated]
		public virtual bool GetViewLockEnabled ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("viewMode")]
		[CompilerGenerated]
		public virtual PSPDFViewMode GetViewMode ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isViewWillAppearing")]
		[CompilerGenerated]
		public virtual bool GetViewWillAppearing ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("visibleViewControllerInPopoverController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController GetVisibleViewControllerInPopoverController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("halfModalController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController HalfModalController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("handleError:title:message:")]
		[CompilerGenerated]
		public virtual void HandleError (NSError error, string title, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isDoublePageModeForLandscape:")]
		[CompilerGenerated]
		public virtual bool IsDoublePageModeForLandscape (bool isLandscape)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isDoublePageModeForPage:")]
		[CompilerGenerated]
		public virtual bool IsDoublePageModeForPage (global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isRightPageInDoublePageMode:")]
		[CompilerGenerated]
		public virtual bool IsRightPageInDoublePageMode (global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("landscapePageForPage:")]
		[CompilerGenerated]
		public virtual global::System.nuint LandscapePageForPage (global::System.nuint aPage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pageViewForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageView PageViewForPage (global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("portraitPageForLandscapePage:")]
		[CompilerGenerated]
		public virtual global::System.nuint PortraitPageForLandscapePage (global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("visiblePages")]
		[CompilerGenerated]
		public virtual NSOrderedSet VisiblePages ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("visiblePagesCalculated")]
		[CompilerGenerated]
		public virtual NSOrderedSet VisiblePagesCalculated ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("visiblePageViews")]
		[CompilerGenerated]
		public virtual NSObject[] VisiblePageViews ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("visiblePageViewsForcingLayout:")]
		[CompilerGenerated]
		public virtual NSObject[] VisiblePageViewsForcingLayout (bool forcingLayout)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFPresentationContext */
}
