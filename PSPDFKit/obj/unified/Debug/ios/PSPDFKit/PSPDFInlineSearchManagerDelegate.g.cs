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
	[Protocol (Name = "PSPDFInlineSearchManagerDelegate", WrapperType = typeof (PSPDFInlineSearchManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFocusSearchResult", Selector = "inlineSearchManager:didFocusSearchResult:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInlineSearchManager), typeof (PSPDFKit.PSPDFSearchResult) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClearAllSearchResults", Selector = "inlineSearchManagerDidClearAllSearchResults:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInlineSearchManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchWillAppear", Selector = "inlineSearchManagerSearchWillAppear:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInlineSearchManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchDidAppear", Selector = "inlineSearchManagerSearchDidAppear:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInlineSearchManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchWillDisappear", Selector = "inlineSearchManagerSearchWillDisappear:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInlineSearchManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchDidDisappear", Selector = "inlineSearchManagerSearchDidDisappear:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInlineSearchManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetContainerView", Selector = "inlineSearchManagerContainerView:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInlineSearchManager) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFInlineSearchManagerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		, PSPDFKit.IPSPDFTextSearchDelegate
		
	{
		[CompilerGenerated]
		[Export ("inlineSearchManagerContainerView:")]
		[Preserve (Conditional = true)]
		global::UIKit.UIView GetContainerView (PSPDFInlineSearchManager manager);
		
	}
	
	public static partial class PSPDFInlineSearchManagerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidFocusSearchResult (this IPSPDFInlineSearchManagerDelegate This, PSPDFInlineSearchManager manager, PSPDFSearchResult searchResult)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("inlineSearchManager:didFocusSearchResult:"), manager.Handle, searchResult.Handle);
		}
		
		[CompilerGenerated]
		public static void DidClearAllSearchResults (this IPSPDFInlineSearchManagerDelegate This, PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("inlineSearchManagerDidClearAllSearchResults:"), manager.Handle);
		}
		
		[CompilerGenerated]
		public static void SearchWillAppear (this IPSPDFInlineSearchManagerDelegate This, PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("inlineSearchManagerSearchWillAppear:"), manager.Handle);
		}
		
		[CompilerGenerated]
		public static void SearchDidAppear (this IPSPDFInlineSearchManagerDelegate This, PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("inlineSearchManagerSearchDidAppear:"), manager.Handle);
		}
		
		[CompilerGenerated]
		public static void SearchWillDisappear (this IPSPDFInlineSearchManagerDelegate This, PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("inlineSearchManagerSearchWillDisappear:"), manager.Handle);
		}
		
		[CompilerGenerated]
		public static void SearchDidDisappear (this IPSPDFInlineSearchManagerDelegate This, PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("inlineSearchManagerSearchDidDisappear:"), manager.Handle);
		}
		
	}
	
	internal sealed class PSPDFInlineSearchManagerDelegateWrapper : BaseWrapper, IPSPDFInlineSearchManagerDelegate {
		public PSPDFInlineSearchManagerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFInlineSearchManagerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("inlineSearchManagerContainerView:")]
		[CompilerGenerated]
		public global::UIKit.UIView GetContainerView (PSPDFInlineSearchManager manager)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inlineSearchManagerContainerView:"), manager.Handle));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFInlineSearchManagerDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFInlineSearchManagerDelegate : NSObject, IPSPDFInlineSearchManagerDelegate, IPSPDFOverridable, IPSPDFTextSearchDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFInlineSearchManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFInlineSearchManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFInlineSearchManagerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didCancelSearch:term:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidCancelSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("inlineSearchManagerDidClearAllSearchResults:")]
		[CompilerGenerated]
		public virtual void DidClearAllSearchResults (PSPDFInlineSearchManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didFinishSearch:term:searchResults:isFullSearch:pageTextFound:")]
		[CompilerGenerated]
		public virtual void DidFinishSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, bool isFullSearch, bool pageTextFound)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("inlineSearchManager:didFocusSearchResult:")]
		[CompilerGenerated]
		public virtual void DidFocusSearchResult (PSPDFInlineSearchManager manager, PSPDFSearchResult searchResult)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didUpdateSearch:term:newSearchResults:page:")]
		[CompilerGenerated]
		public virtual void DidUpdateSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("inlineSearchManagerContainerView:")]
		[CompilerGenerated]
		public abstract global::UIKit.UIView GetContainerView (PSPDFInlineSearchManager manager);
		[Export ("inlineSearchManagerSearchDidAppear:")]
		[CompilerGenerated]
		public virtual void SearchDidAppear (PSPDFInlineSearchManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("inlineSearchManagerSearchDidDisappear:")]
		[CompilerGenerated]
		public virtual void SearchDidDisappear (PSPDFInlineSearchManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("inlineSearchManagerSearchWillAppear:")]
		[CompilerGenerated]
		public virtual void SearchWillAppear (PSPDFInlineSearchManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("inlineSearchManagerSearchWillDisappear:")]
		[CompilerGenerated]
		public virtual void SearchWillDisappear (PSPDFInlineSearchManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willStartSearch:term:isFullSearch:")]
		[CompilerGenerated]
		public virtual void WillStartSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFInlineSearchManagerDelegate */
}
