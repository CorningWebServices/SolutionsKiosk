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
	[Register("PSPDFAnnotationGridViewController", true)]
	public unsafe partial class PSPDFAnnotationGridViewController : PSPDFBaseViewController, IPSPDFStyleable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationGridViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationGridViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationGridViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationGridViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationGridViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("close:")]
		[CompilerGenerated]
		public virtual void Close (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("close:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("close:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("configureCell:forIndexPath:")]
		[CompilerGenerated]
		public virtual void ConfigureCell (PSPDFAnnotationSetCell annotationSetCell, NSIndexPath indexPath)
		{
			if (annotationSetCell == null)
				throw new ArgumentNullException ("annotationSetCell");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("configureCell:forIndexPath:"), annotationSetCell.Handle, indexPath.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("configureCell:forIndexPath:"), annotationSetCell.Handle, indexPath.Handle);
			}
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
		
		[Export ("updatePopoverSize")]
		[CompilerGenerated]
		public virtual void UpdatePopoverSize ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updatePopoverSize"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updatePopoverSize"));
			}
		}
		
		[CompilerGenerated]
		object __mt_DataSource_var;
		[CompilerGenerated]
		public virtual IPSPDFAnnotationGridViewControllerDataSource DataSource {
			[Export ("dataSource", ArgumentSemantic.Weak)]
			get {
				IPSPDFAnnotationGridViewControllerDataSource ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationGridViewControllerDataSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationGridViewControllerDataSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataSource")), false);
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
		public virtual IPSPDFAnnotationGridViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFAnnotationGridViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationGridViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationGridViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_GridView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UICollectionView GridView {
			[Export ("gridView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UICollectionView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UICollectionView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gridView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UICollectionView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gridView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GridView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DataSource_var = null;
				__mt_Delegate_var = null;
				__mt_GridView_var = null;
			}
		}
	} /* class PSPDFAnnotationGridViewController */
}
