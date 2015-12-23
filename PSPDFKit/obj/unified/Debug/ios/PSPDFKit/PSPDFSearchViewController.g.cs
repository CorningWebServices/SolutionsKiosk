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
	[Register("PSPDFSearchViewController", true)]
	public unsafe partial class PSPDFSearchViewController : PSPDFBaseTableViewController, IPSPDFStyleable, IPSPDFTextSearchDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFSearchViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFSearchViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSearchViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFSearchViewController (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocument:"), document == null ? IntPtr.Zero : document.Handle), "initWithDocument:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocument:"), document == null ? IntPtr.Zero : document.Handle), "initWithDocument:");
			}
		}
		
		[Export ("createSearchBar")]
		[CompilerGenerated]
		public virtual global::UIKit.UISearchBar CreateSearchBar ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UISearchBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("createSearchBar")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UISearchBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("createSearchBar")));
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
		
		[Export ("filterContentForSearchText:scope:")]
		[CompilerGenerated]
		public virtual void FilterContentForSearchText (string searchText, string scope)
		{
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			if (scope == null)
				throw new ArgumentNullException ("scope");
			var nssearchText = NSString.CreateNative (searchText);
			var nsscope = NSString.CreateNative (scope);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("filterContentForSearchText:scope:"), nssearchText, nsscope);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("filterContentForSearchText:scope:"), nssearchText, nsscope);
			}
			NSString.ReleaseNative (nssearchText);
			NSString.ReleaseNative (nsscope);
			
		}
		
		[Export ("barStyle")]
		[CompilerGenerated]
		public virtual global::UIKit.UIBarStyle GetBarStyle ()
		{
			global::UIKit.UIBarStyle ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("barStyle"));
				} else {
					ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("barStyle"));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barStyle"));
				} else {
					ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barStyle"));
				}
			}
			return ret;
		}
		
		[Export ("parentPopoverController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIPopoverController GetParentPopoverController ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("parentPopoverController")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parentPopoverController")));
			}
		}
		
		[Export ("prefersStatusBarHidden")]
		[CompilerGenerated]
		public virtual bool GetPrefersStatusBarHidden ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("prefersStatusBarHidden"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prefersStatusBarHidden"));
			}
		}
		
		[Export ("isBarTranslucent")]
		[CompilerGenerated]
		public virtual bool IsBarTranslucent ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBarTranslucent"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBarTranslucent"));
			}
		}
		
		[Export ("isInPopover")]
		[CompilerGenerated]
		public virtual bool IsInPopover ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInPopover"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isInPopover"));
			}
		}
		
		[Export ("setIsInPopover:")]
		[CompilerGenerated]
		public virtual void IsInPopover (bool isInPopover)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsInPopover:"), isInPopover);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsInPopover:"), isInPopover);
			}
		}
		
		[Export ("restartSearch")]
		[CompilerGenerated]
		public virtual void RestartSearch ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("restartSearch"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("restartSearch"));
			}
		}
		
		[Export ("searchResultForIndexPath:")]
		[CompilerGenerated]
		public virtual PSPDFSearchResult SearchResultForIndexPath (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFSearchResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("searchResultForIndexPath:"), indexPath.Handle));
			} else {
				return  Runtime.GetNSObject<PSPDFSearchResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("searchResultForIndexPath:"), indexPath.Handle));
			}
		}
		
		[Export ("setBarStyle:")]
		[CompilerGenerated]
		public virtual void SetBarStyle (global::UIKit.UIBarStyle style)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setBarStyle:"), (Int64)style);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setBarStyle:"), (int)style);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setBarStyle:"), (Int64)style);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setBarStyle:"), (int)style);
				}
			}
		}
		
		[Export ("setIsBarTranslucent:")]
		[CompilerGenerated]
		public virtual void SetIsBarTranslucent (bool isBarTranslucent)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsBarTranslucent:"), isBarTranslucent);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsBarTranslucent:"), isBarTranslucent);
			}
		}
		
		[Export ("setParentPopoverController:")]
		[CompilerGenerated]
		public virtual void SetParentPopoverController (global::UIKit.UIPopoverController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setParentPopoverController:"), controller.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setParentPopoverController:"), controller.Handle);
			}
		}
		
		[Export ("setPrefersStatusBarHidden:")]
		[CompilerGenerated]
		public virtual void SetPrefersStatusBarHidden (bool val)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPrefersStatusBarHidden:"), val);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPrefersStatusBarHidden:"), val);
			}
		}
		
		[Export ("setSearchStatus:updateTable:")]
		[CompilerGenerated]
		public virtual void SetSearchStatus (PSPDFSearchStatus searchStatus, bool updateTable)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Int64_bool (this.Handle, Selector.GetHandle ("setSearchStatus:updateTable:"), (Int64)searchStatus, updateTable);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_int_bool (this.Handle, Selector.GetHandle ("setSearchStatus:updateTable:"), (int)searchStatus, updateTable);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64_bool (this.SuperHandle, Selector.GetHandle ("setSearchStatus:updateTable:"), (Int64)searchStatus, updateTable);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, Selector.GetHandle ("setSearchStatus:updateTable:"), (int)searchStatus, updateTable);
				}
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
		
		[CompilerGenerated]
		public virtual bool ClearHighlightsWhenClosed {
			[Export ("clearHighlightsWhenClosed", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clearHighlightsWhenClosed"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearHighlightsWhenClosed"));
				}
			}
			
			[Export ("setClearHighlightsWhenClosed:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClearHighlightsWhenClosed:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setClearHighlightsWhenClosed:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFSearchViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFSearchViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFSearchViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFSearchViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		public virtual global::System.nuint MaximumNumberOfSearchResultsDisplayed {
			[Export ("maximumNumberOfSearchResultsDisplayed", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNumberOfSearchResultsDisplayed"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumNumberOfSearchResultsDisplayed"));
				}
			}
			
			[Export ("setMaximumNumberOfSearchResultsDisplayed:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMaximumNumberOfSearchResultsDisplayed:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMaximumNumberOfSearchResultsDisplayed:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint NumberOfPreviewTextLines {
			[Export ("numberOfPreviewTextLines", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfPreviewTextLines"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfPreviewTextLines"));
				}
			}
			
			[Export ("setNumberOfPreviewTextLines:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setNumberOfPreviewTextLines:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setNumberOfPreviewTextLines:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PinSearchBarToHeader {
			[Export ("pinSearchBarToHeader", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("pinSearchBarToHeader"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pinSearchBarToHeader"));
				}
			}
			
			[Export ("setPinSearchBarToHeader:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPinSearchBarToHeader:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPinSearchBarToHeader:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType SearchableAnnotationTypes {
			[Export ("searchableAnnotationTypes", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("searchableAnnotationTypes"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("searchableAnnotationTypes"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchableAnnotationTypes"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchableAnnotationTypes"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setSearchableAnnotationTypes:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setSearchableAnnotationTypes:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setSearchableAnnotationTypes:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setSearchableAnnotationTypes:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setSearchableAnnotationTypes:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SearchBar_var;
		[CompilerGenerated]
		public virtual global::UIKit.UISearchBar SearchBar {
			[Export ("searchBar", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UISearchBar ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UISearchBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("searchBar")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UISearchBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchBar")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchBar_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SearchResults_var;
		[CompilerGenerated]
		public virtual PSPDFSearchResult[] SearchResults {
			[Export ("searchResults", ArgumentSemantic.Copy)]
			get {
				PSPDFSearchResult[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFSearchResult>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("searchResults")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFSearchResult>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchResults")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchResults_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFSearchStatus SearchStatus {
			[Export ("searchStatus", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFSearchStatus ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSearchStatus) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("searchStatus"));
					} else {
						ret = (PSPDFSearchStatus) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("searchStatus"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSearchStatus) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchStatus"));
					} else {
						ret = (PSPDFSearchStatus) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchStatus"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SearchText {
			[Export ("searchText")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("searchText")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchText")));
				}
			}
			
			[Export ("setSearchText:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSearchText:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSearchText:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool SearchVisiblePagesFirst {
			[Export ("searchVisiblePagesFirst", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("searchVisiblePagesFirst"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchVisiblePagesFirst"));
				}
			}
			
			[Export ("setSearchVisiblePagesFirst:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSearchVisiblePagesFirst:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSearchVisiblePagesFirst:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsCancelButton {
			[Export ("showsCancelButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsCancelButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showsCancelButton"));
				}
			}
			
			[Export ("setShowsCancelButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsCancelButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowsCancelButton:"), value);
				}
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
		public virtual bool UseOutlineForPageNames {
			[Export ("useOutlineForPageNames", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useOutlineForPageNames"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useOutlineForPageNames"));
				}
			}
			
			[Export ("setUseOutlineForPageNames:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseOutlineForPageNames:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseOutlineForPageNames:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Document_var = null;
				__mt_SearchBar_var = null;
				__mt_SearchResults_var = null;
				__mt_TextSearch_var = null;
			}
		}
	} /* class PSPDFSearchViewController */
}
