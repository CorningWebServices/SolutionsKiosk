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
	[Protocol (Name = "PSPDFTransitionProtocol", WrapperType = typeof (PSPDFTransitionProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPage", Selector = "setPage:animated:", ParameterType = new Type [] { typeof (nuint), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "VisiblePages", Selector = "visiblePages", ReturnType = typeof (NSOrderedSet))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PageViewForPage", Selector = "pageViewForPage:", ReturnType = typeof (PSPDFKit.PSPDFPageView), ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisiblePageViewsForcingLayout", Selector = "visiblePageViewsForcingLayout:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompensatedContentOffset", Selector = "compensatedContentOffset", ReturnType = typeof (CGPoint))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PresentationContext", Selector = "presentationContext", PropertyType = typeof (PSPDFKit.IPSPDFPresentationContext), GetterSelector = "presentationContext", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ScrollView", Selector = "scrollView", PropertyType = typeof (PSPDFKit.PSPDFContentScrollView), GetterSelector = "scrollView", SetterSelector = "setScrollView:", ArgumentSemantic = ArgumentSemantic.Weak)]
	public interface IPSPDFTransitionProtocol : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setPage:animated:")]
		[Preserve (Conditional = true)]
		void SetPage (global::System.nuint page, bool animated);
		
		[CompilerGenerated]
		[Export ("visiblePages")]
		[Preserve (Conditional = true)]
		NSOrderedSet VisiblePages ();
		
		[CompilerGenerated]
		[Export ("pageViewForPage:")]
		[Preserve (Conditional = true)]
		PSPDFPageView PageViewForPage (global::System.nuint page);
		
	}
	
	public static partial class PSPDFTransitionProtocol_Extensions {
		[CompilerGenerated]
		public static NSObject[] VisiblePageViewsForcingLayout (this IPSPDFTransitionProtocol This, bool forcingLayout)
		{
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_bool (This.Handle, Selector.GetHandle ("visiblePageViewsForcingLayout:"), forcingLayout));
		}
		
		[CompilerGenerated]
		public static CGPoint CompensatedContentOffset (this IPSPDFTransitionProtocol This)
		{
			CGPoint ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("compensatedContentOffset"));
				} else {
					global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("compensatedContentOffset"));
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("compensatedContentOffset"));
			} else {
				ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("compensatedContentOffset"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static IPSPDFPresentationContext GetPresentationContext (this IPSPDFTransitionProtocol This)
		{
			return  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("presentationContext")), false);
		}
		
		[CompilerGenerated]
		public static PSPDFContentScrollView GetScrollView (this IPSPDFTransitionProtocol This)
		{
			return  Runtime.GetNSObject<PSPDFContentScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("scrollView")));
		}
		
		[CompilerGenerated]
		public static void SetScrollView (this IPSPDFTransitionProtocol This, PSPDFContentScrollView value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setScrollView:"), value.Handle);
		}
		
	}
	
	internal sealed class PSPDFTransitionProtocolWrapper : BaseWrapper, IPSPDFTransitionProtocol {
		public PSPDFTransitionProtocolWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFTransitionProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public void SetPage (global::System.nuint page, bool animated)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("setPage:animated:"), page, animated);
		}
		
		[Export ("visiblePages")]
		[CompilerGenerated]
		public NSOrderedSet VisiblePages ()
		{
			return  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePages")));
		}
		
		[Export ("pageViewForPage:")]
		[CompilerGenerated]
		public PSPDFPageView PageViewForPage (global::System.nuint page)
		{
			return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("pageViewForPage:"), page));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFTransitionProtocol", false)]
	[Model]
	public unsafe abstract partial class PSPDFTransitionProtocol : NSObject, IPSPDFTransitionProtocol {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFTransitionProtocol () : base (NSObjectFlag.Empty)
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
		protected PSPDFTransitionProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTransitionProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("compensatedContentOffset")]
		[CompilerGenerated]
		public virtual CGPoint CompensatedContentOffset ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pageViewForPage:")]
		[CompilerGenerated]
		public abstract PSPDFPageView PageViewForPage (global::System.nuint page);
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public abstract void SetPage (global::System.nuint page, bool animated);
		[Export ("visiblePages")]
		[CompilerGenerated]
		public abstract NSOrderedSet VisiblePages ();
		[Export ("visiblePageViewsForcingLayout:")]
		[CompilerGenerated]
		public virtual NSObject[] VisiblePageViewsForcingLayout (bool forcingLayout)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual IPSPDFPresentationContext PresentationContext {
			[Export ("presentationContext", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFContentScrollView ScrollView {
			[Export ("scrollView", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setScrollView:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class PSPDFTransitionProtocol */
}
