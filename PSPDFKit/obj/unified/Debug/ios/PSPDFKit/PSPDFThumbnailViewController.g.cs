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
	[Register("PSPDFThumbnailViewController", true)]
	public unsafe partial class PSPDFThumbnailViewController : global::UIKit.UICollectionViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFThumbnailViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFThumbnailViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFThumbnailViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFThumbnailViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithCollectionViewLayout:")]
		[CompilerGenerated]
		public PSPDFThumbnailViewController (global::UIKit.UICollectionViewLayout layout)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCollectionViewLayout:"), layout == null ? IntPtr.Zero : layout.Handle), "initWithCollectionViewLayout:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCollectionViewLayout:"), layout == null ? IntPtr.Zero : layout.Handle), "initWithCollectionViewLayout:");
			}
		}
		
		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFThumbnailViewController (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocument:"), document == null ? IntPtr.Zero : document.Handle), "initWithDocument:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocument:"), document == null ? IntPtr.Zero : document.Handle), "initWithDocument:");
			}
		}
		
		[Export ("cellForPage:document:")]
		[CompilerGenerated]
		public virtual global::UIKit.UICollectionViewCell CellForPage (global::System.nuint page, PSPDFDocument document)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UICollectionViewCell> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_IntPtr (this.Handle, Selector.GetHandle ("cellForPage:document:"), page, document == null ? IntPtr.Zero : document.Handle));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UICollectionViewCell> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("cellForPage:document:"), page, document == null ? IntPtr.Zero : document.Handle));
			}
		}
		
		[Export ("configureCell:forIndexPath:")]
		[CompilerGenerated]
		public virtual void ConfigureCell (PSPDFThumbnailGridViewCell cell, NSIndexPath indexPath)
		{
			if (cell == null)
				throw new ArgumentNullException ("cell");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("configureCell:forIndexPath:"), cell.Handle, indexPath.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("configureCell:forIndexPath:"), cell.Handle, indexPath.Handle);
			}
		}
		
		[Export ("emptyContentLabelForFilter:")]
		[CompilerGenerated]
		public virtual string EmptyContentLabelForFilter (NSString filter)
		{
			if (filter == null)
				throw new ArgumentNullException ("filter");
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("emptyContentLabelForFilter:"), filter.Handle));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("emptyContentLabelForFilter:"), filter.Handle));
			}
		}
		
		[Export ("pageForIndexPath:")]
		[CompilerGenerated]
		public virtual global::System.nint PageForIndexPath (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("pageForIndexPath:"), indexPath.Handle);
			} else {
				return global::ApiDefinition.Messaging.nint_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("pageForIndexPath:"), indexPath.Handle);
			}
		}
		
		[Export ("pagesForFilter:")]
		[CompilerGenerated]
		public virtual NSNumber[] PagesForFilter (NSString filter)
		{
			if (filter == null)
				throw new ArgumentNullException ("filter");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("pagesForFilter:"), filter.Handle));
			} else {
				return NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("pagesForFilter:"), filter.Handle));
			}
		}
		
		[Export ("scrollToPage:document:animated:")]
		[CompilerGenerated]
		public virtual void ScrollToPage (global::System.nuint page, PSPDFDocument document, bool animated)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_IntPtr_bool (this.Handle, Selector.GetHandle ("scrollToPage:document:animated:"), page, document.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("scrollToPage:document:animated:"), page, document.Handle, animated);
			}
		}
		
		[Export ("setActiveFilter:animated:")]
		[CompilerGenerated]
		public virtual void SetActiveFilter (NSString activeFilter, bool animated)
		{
			if (activeFilter == null)
				throw new ArgumentNullException ("activeFilter");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setActiveFilter:animated:"), activeFilter.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setActiveFilter:animated:"), activeFilter.Handle, animated);
			}
		}
		
		[Export ("stopScrolling")]
		[CompilerGenerated]
		public virtual void StopScrolling ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopScrolling"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopScrolling"));
			}
		}
		
		[Export ("updateEmptyView")]
		[CompilerGenerated]
		public virtual void UpdateEmptyView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateEmptyView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateEmptyView"));
			}
		}
		
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		[CompilerGenerated]
		public virtual global::UIKit.UICollectionReusableView UpdateEmptyView (global::UIKit.UICollectionView collectionView, string kind, NSIndexPath indexPath)
		{
			if (collectionView == null)
				throw new ArgumentNullException ("collectionView");
			if (kind == null)
				throw new ArgumentNullException ("kind");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			var nskind = NSString.CreateNative (kind);
			
			global::UIKit.UICollectionReusableView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UICollectionReusableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView.Handle, nskind, indexPath.Handle));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UICollectionReusableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView.Handle, nskind, indexPath.Handle));
			}
			NSString.ReleaseNative (nskind);
			
			return ret;
		}
		
		[Export ("updateFilterAndVisibleCellsAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateFilterAndVisibleCells (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateFilterAndVisibleCellsAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateFilterAndVisibleCellsAnimated:"), animated);
			}
		}
		
		[Export ("updateFilterSegment")]
		[CompilerGenerated]
		public virtual void UpdateFilterSegment ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateFilterSegment"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateFilterSegment"));
			}
		}
		
		[Export ("updateInsetsForTopOverlapHeight:")]
		[CompilerGenerated]
		public virtual void UpdateInsetsForTopOverlapHeight (global::System.nfloat overlapHeight)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("updateInsetsForTopOverlapHeight:"), overlapHeight);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("updateInsetsForTopOverlapHeight:"), overlapHeight);
			}
		}
		
		[CompilerGenerated]
		object __mt_ActiveFilter_var;
		[CompilerGenerated]
		public virtual NSString ActiveFilter {
			[Export ("activeFilter", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("activeFilter")));
				} else {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("activeFilter")));
				}
				MarkDirty ();
				__mt_ActiveFilter_var = ret;
				return ret;
			}
			
			[Export ("setActiveFilter:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActiveFilter:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setActiveFilter:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_ActiveFilter_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DataSource_var;
		[CompilerGenerated]
		public virtual IPSPDFPresentationContext DataSource {
			[Export ("dataSource", ArgumentSemantic.Weak)]
			get {
				IPSPDFPresentationContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataSource")), false);
				}
				MarkDirty ();
				__mt_DataSource_var = ret;
				return ret;
			}
			
			[Export ("setDataSource:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDataSource:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDataSource:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_DataSource_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFThumbnailViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFThumbnailViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFThumbnailViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFThumbnailViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_FilterOptions_var;
		[CompilerGenerated]
		public virtual NSString[] FilterOptions {
			[Export ("filterOptions", ArgumentSemantic.Copy)]
			get {
				NSString[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("filterOptions")));
				} else {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("filterOptions")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FilterOptions_var = ret;
				return ret;
			}
			
			[Export ("setFilterOptions:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFilterOptions:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFilterOptions:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_FilterOptions_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_FilterSegment_var;
		[CompilerGenerated]
		public virtual PSPDFThumbnailFilterSegmentedControl FilterSegment {
			[Export ("filterSegment", ArgumentSemantic.Retain)]
			get {
				PSPDFThumbnailFilterSegmentedControl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFThumbnailFilterSegmentedControl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("filterSegment")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFThumbnailFilterSegmentedControl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("filterSegment")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FilterSegment_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool FixedItemSizeEnabled {
			[Export ("fixedItemSizeEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("fixedItemSizeEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fixedItemSizeEnabled"));
				}
			}
			
			[Export ("setFixedItemSizeEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFixedItemSizeEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFixedItemSizeEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool StickyHeaderEnabled {
			[Export ("stickyHeaderEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("stickyHeaderEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stickyHeaderEnabled"));
				}
			}
			
			[Export ("setStickyHeaderEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setStickyHeaderEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setStickyHeaderEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual Class ThumbnailCellClass {
			[Export ("thumbnailCellClass", ArgumentSemantic.Retain)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailCellClass"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailCellClass"));
				}
				return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
			}
			
			[Export ("setThumbnailCellClass:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setThumbnailCellClass:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setThumbnailCellClass:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ActiveFilter_var = null;
				__mt_DataSource_var = null;
				__mt_Delegate_var = null;
				__mt_Document_var = null;
				__mt_FilterOptions_var = null;
				__mt_FilterSegment_var = null;
			}
		}
	} /* class PSPDFThumbnailViewController */
}
