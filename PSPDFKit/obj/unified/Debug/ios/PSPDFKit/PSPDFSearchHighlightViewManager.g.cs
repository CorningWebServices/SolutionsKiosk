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
	[Register("PSPDFSearchHighlightViewManager", true)]
	public unsafe partial class PSPDFSearchHighlightViewManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchHighlightViewManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFSearchHighlightViewManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSearchHighlightViewManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDataSource:")]
		[CompilerGenerated]
		public PSPDFSearchHighlightViewManager (IPSPDFSearchHighlightViewManagerDataSource dataSource)
			: base (NSObjectFlag.Empty)
		{
			if (dataSource == null)
				throw new ArgumentNullException ("dataSource");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDataSource:"), dataSource.Handle), "initWithDataSource:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDataSource:"), dataSource.Handle), "initWithDataSource:");
			}
		}
		
		[Export ("addHighlightSearchResults:animated:")]
		[CompilerGenerated]
		public virtual void AddHighlightSearchResults (PSPDFSearchResult[] searchResults, bool animated)
		{
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("addHighlightSearchResults:animated:"), nsa_searchResults.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("addHighlightSearchResults:animated:"), nsa_searchResults.Handle, animated);
			}
			nsa_searchResults.Dispose ();
			
		}
		
		[Export ("animateSearchHighlight:")]
		[CompilerGenerated]
		public virtual void AnimateSearchHighlight (PSPDFSearchResult searchResult)
		{
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("animateSearchHighlight:"), searchResult.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("animateSearchHighlight:"), searchResult.Handle);
			}
		}
		
		[Export ("clearHighlightedSearchResultsAnimated:")]
		[CompilerGenerated]
		public virtual void ClearHighlightedSearchResults (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("clearHighlightedSearchResultsAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("clearHighlightedSearchResultsAnimated:"), animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_DataSource_var;
		[CompilerGenerated]
		public virtual IPSPDFSearchHighlightViewManagerDataSource DataSource {
			[Export ("dataSource", ArgumentSemantic.Weak)]
			get {
				IPSPDFSearchHighlightViewManagerDataSource ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFSearchHighlightViewManagerDataSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFSearchHighlightViewManagerDataSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataSource")), false);
				}
				MarkDirty ();
				__mt_DataSource_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasVisibleSearchResults {
			[Export ("hasVisibleSearchResults")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasVisibleSearchResults"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasVisibleSearchResults"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DataSource_var = null;
			}
		}
	} /* class PSPDFSearchHighlightViewManager */
}
