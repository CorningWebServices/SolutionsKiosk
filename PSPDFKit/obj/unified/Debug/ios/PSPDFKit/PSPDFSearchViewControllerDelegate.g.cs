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
	[Protocol (Name = "PSPDFSearchViewControllerDelegate", WrapperType = typeof (PSPDFSearchViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTapSearchResult", Selector = "searchViewController:didTapSearchResult:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSearchViewController), typeof (PSPDFKit.PSPDFSearchResult) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClearAllSearchResults", Selector = "searchViewControllerDidClearAllSearchResults:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSearchViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetVisiblePages", Selector = "searchViewControllerGetVisiblePages:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSearchViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchRangeForScope", Selector = "searchViewController:searchRangeForScope:", ReturnType = typeof (NSIndexSet), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSearchViewController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextSearchObject", Selector = "searchViewControllerTextSearchObject:", ReturnType = typeof (PSPDFKit.PSPDFTextSearch), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSearchViewController) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFSearchViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		, PSPDFKit.IPSPDFTextSearchDelegate
		
	{
	}
	
	public static partial class PSPDFSearchViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidTapSearchResult (this IPSPDFSearchViewControllerDelegate This, PSPDFSearchViewController searchController, PSPDFSearchResult searchResult)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("searchViewController:didTapSearchResult:"), searchController.Handle, searchResult.Handle);
		}
		
		[CompilerGenerated]
		public static void DidClearAllSearchResults (this IPSPDFSearchViewControllerDelegate This, PSPDFSearchViewController searchController)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("searchViewControllerDidClearAllSearchResults:"), searchController.Handle);
		}
		
		[CompilerGenerated]
		public static NSObject[] GetVisiblePages (this IPSPDFSearchViewControllerDelegate This, PSPDFSearchViewController searchController)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("searchViewControllerGetVisiblePages:"), searchController.Handle));
		}
		
		[CompilerGenerated]
		public static NSIndexSet SearchRangeForScope (this IPSPDFSearchViewControllerDelegate This, PSPDFSearchViewController searchController, string scope)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			if (scope == null)
				throw new ArgumentNullException ("scope");
			var nsscope = NSString.CreateNative (scope);
			
			NSIndexSet ret;
			ret =  Runtime.GetNSObject<NSIndexSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("searchViewController:searchRangeForScope:"), searchController.Handle, nsscope));
			NSString.ReleaseNative (nsscope);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static PSPDFTextSearch TextSearchObject (this IPSPDFSearchViewControllerDelegate This, PSPDFSearchViewController searchController)
		{
			if (searchController == null)
				throw new ArgumentNullException ("searchController");
			return  Runtime.GetNSObject<PSPDFTextSearch> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("searchViewControllerTextSearchObject:"), searchController.Handle));
		}
		
	}
	
	internal sealed class PSPDFSearchViewControllerDelegateWrapper : BaseWrapper, IPSPDFSearchViewControllerDelegate {
		public PSPDFSearchViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFSearchViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFSearchViewControllerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFSearchViewControllerDelegate : NSObject, IPSPDFSearchViewControllerDelegate, IPSPDFOverridable, IPSPDFTextSearchDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSearchViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFSearchViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSearchViewControllerDelegate (IntPtr handle) : base (handle)
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
		
		[Export ("searchViewControllerDidClearAllSearchResults:")]
		[CompilerGenerated]
		public virtual void DidClearAllSearchResults (PSPDFSearchViewController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didFinishSearch:term:searchResults:isFullSearch:pageTextFound:")]
		[CompilerGenerated]
		public virtual void DidFinishSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, bool isFullSearch, bool pageTextFound)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("searchViewController:didTapSearchResult:")]
		[CompilerGenerated]
		public virtual void DidTapSearchResult (PSPDFSearchViewController searchController, PSPDFSearchResult searchResult)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didUpdateSearch:term:newSearchResults:page:")]
		[CompilerGenerated]
		public virtual void DidUpdateSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("searchViewControllerGetVisiblePages:")]
		[CompilerGenerated]
		public virtual NSObject[] GetVisiblePages (PSPDFSearchViewController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("searchViewController:searchRangeForScope:")]
		[CompilerGenerated]
		public virtual NSIndexSet SearchRangeForScope (PSPDFSearchViewController searchController, string scope)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("searchViewControllerTextSearchObject:")]
		[CompilerGenerated]
		public virtual PSPDFTextSearch TextSearchObject (PSPDFSearchViewController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willStartSearch:term:isFullSearch:")]
		[CompilerGenerated]
		public virtual void WillStartSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFSearchViewControllerDelegate */
}
