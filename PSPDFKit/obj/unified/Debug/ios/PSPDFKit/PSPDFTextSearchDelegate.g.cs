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
	[Protocol (Name = "PSPDFTextSearchDelegate", WrapperType = typeof (PSPDFTextSearchDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartSearch", Selector = "willStartSearch:term:isFullSearch:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTextSearch), typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateSearch", Selector = "didUpdateSearch:term:newSearchResults:page:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTextSearch), typeof (string), typeof (PSPDFKit.PSPDFSearchResult[]), typeof (nuint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishSearch", Selector = "didFinishSearch:term:searchResults:isFullSearch:pageTextFound:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTextSearch), typeof (string), typeof (PSPDFKit.PSPDFSearchResult[]), typeof (bool), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelSearch", Selector = "didCancelSearch:term:isFullSearch:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTextSearch), typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPSPDFTextSearchDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFTextSearchDelegate_Extensions {
		[CompilerGenerated]
		public static void WillStartSearch (this IPSPDFTextSearchDelegate This, PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (This.Handle, Selector.GetHandle ("willStartSearch:term:isFullSearch:"), textSearch.Handle, nssearchTerm, isFullSearch);
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
		[CompilerGenerated]
		public static void DidUpdateSearch (this IPSPDFTextSearchDelegate This, PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, global::System.nuint page)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint (This.Handle, Selector.GetHandle ("didUpdateSearch:term:newSearchResults:page:"), textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, page);
			NSString.ReleaseNative (nssearchTerm);
			nsa_searchResults.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void DidFinishSearch (this IPSPDFTextSearchDelegate This, PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, bool isFullSearch, bool pageTextFound)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_bool (This.Handle, Selector.GetHandle ("didFinishSearch:term:searchResults:isFullSearch:pageTextFound:"), textSearch.Handle, nssearchTerm, nsa_searchResults.Handle, isFullSearch, pageTextFound);
			NSString.ReleaseNative (nssearchTerm);
			nsa_searchResults.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void DidCancelSearch (this IPSPDFTextSearchDelegate This, PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			if (textSearch == null)
				throw new ArgumentNullException ("textSearch");
			if (searchTerm == null)
				throw new ArgumentNullException ("searchTerm");
			var nssearchTerm = NSString.CreateNative (searchTerm);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (This.Handle, Selector.GetHandle ("didCancelSearch:term:isFullSearch:"), textSearch.Handle, nssearchTerm, isFullSearch);
			NSString.ReleaseNative (nssearchTerm);
			
		}
		
	}
	
	internal sealed class PSPDFTextSearchDelegateWrapper : BaseWrapper, IPSPDFTextSearchDelegate {
		public PSPDFTextSearchDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFTextSearchDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFTextSearchDelegate", false)]
	[Model]
	public unsafe partial class PSPDFTextSearchDelegate : NSObject, IPSPDFTextSearchDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTextSearchDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFTextSearchDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTextSearchDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("didCancelSearch:term:isFullSearch:")]
		[CompilerGenerated]
		public virtual void DidCancelSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didFinishSearch:term:searchResults:isFullSearch:pageTextFound:")]
		[CompilerGenerated]
		public virtual void DidFinishSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, bool isFullSearch, bool pageTextFound)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didUpdateSearch:term:newSearchResults:page:")]
		[CompilerGenerated]
		public virtual void DidUpdateSearch (PSPDFTextSearch textSearch, string searchTerm, PSPDFSearchResult[] searchResults, global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willStartSearch:term:isFullSearch:")]
		[CompilerGenerated]
		public virtual void WillStartSearch (PSPDFTextSearch textSearch, string searchTerm, bool isFullSearch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFTextSearchDelegate */
}
