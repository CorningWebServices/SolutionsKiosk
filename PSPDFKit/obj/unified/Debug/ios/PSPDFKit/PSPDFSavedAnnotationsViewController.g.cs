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
	[Register("PSPDFSavedAnnotationsViewController", true)]
	public unsafe partial class PSPDFSavedAnnotationsViewController : PSPDFAnnotationGridViewController, IPSPDFAnnotationGridViewControllerDataSource, IPSPDFStyleable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSavedAnnotationsViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFSavedAnnotationsViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFSavedAnnotationsViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSavedAnnotationsViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:")]
		[CompilerGenerated]
		public PSPDFSavedAnnotationsViewController (IPSPDFAnnotationGridViewControllerDelegate aDelegate)
			: base (NSObjectFlag.Empty)
		{
			if (aDelegate == null)
				throw new ArgumentNullException ("aDelegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDelegate:"), aDelegate.Handle), "initWithDelegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDelegate:"), aDelegate.Handle), "initWithDelegate:");
			}
		}
		
		[Export ("annotationGridViewController:annotationSetForIndexPath:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationSet AnnotationSetForIndexPath (PSPDFAnnotationGridViewController annotationGridController, NSIndexPath indexPath)
		{
			if (annotationGridController == null)
				throw new ArgumentNullException ("annotationGridController");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFAnnotationSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationGridViewController:annotationSetForIndexPath:"), annotationGridController.Handle, indexPath.Handle));
			} else {
				return  Runtime.GetNSObject<PSPDFAnnotationSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationGridViewController:annotationSetForIndexPath:"), annotationGridController.Handle, indexPath.Handle));
			}
		}
		
		[Export ("barStyle")]
		[CompilerGenerated]
		public new virtual global::UIKit.UIBarStyle GetBarStyle ()
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
		public new virtual global::UIKit.UIPopoverController GetParentPopoverController ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("parentPopoverController")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parentPopoverController")));
			}
		}
		
		[Export ("prefersStatusBarHidden")]
		[CompilerGenerated]
		public new virtual bool GetPrefersStatusBarHidden ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("prefersStatusBarHidden"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prefersStatusBarHidden"));
			}
		}
		
		[Export ("isBarTranslucent")]
		[CompilerGenerated]
		public new virtual bool IsBarTranslucent ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBarTranslucent"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBarTranslucent"));
			}
		}
		
		[Export ("isInPopover")]
		[CompilerGenerated]
		public new virtual bool IsInPopover ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isInPopover"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isInPopover"));
			}
		}
		
		[Export ("setIsInPopover:")]
		[CompilerGenerated]
		public new virtual void IsInPopover (bool isInPopover)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsInPopover:"), isInPopover);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsInPopover:"), isInPopover);
			}
		}
		
		[Export ("annotationGridViewController:numberOfAnnotationsInSection:")]
		[CompilerGenerated]
		public virtual global::System.nint NumberOfAnnotationsInSection (PSPDFAnnotationGridViewController annotationGridController, global::System.nint section)
		{
			if (annotationGridController == null)
				throw new ArgumentNullException ("annotationGridController");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("annotationGridViewController:numberOfAnnotationsInSection:"), annotationGridController.Handle, section);
			} else {
				return global::ApiDefinition.Messaging.nint_objc_msgSendSuper_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("annotationGridViewController:numberOfAnnotationsInSection:"), annotationGridController.Handle, section);
			}
		}
		
		[Export ("numberOfSectionsInAnnotationGridViewController:")]
		[CompilerGenerated]
		public virtual global::System.nint NumberOfSectionsInAnnotationGridViewController (PSPDFAnnotationGridViewController annotationGridController)
		{
			if (annotationGridController == null)
				throw new ArgumentNullException ("annotationGridController");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("numberOfSectionsInAnnotationGridViewController:"), annotationGridController.Handle);
			} else {
				return global::ApiDefinition.Messaging.nint_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("numberOfSectionsInAnnotationGridViewController:"), annotationGridController.Handle);
			}
		}
		
		[Export ("setBarStyle:")]
		[CompilerGenerated]
		public new virtual void SetBarStyle (global::UIKit.UIBarStyle style)
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
		public new virtual void SetIsBarTranslucent (bool isBarTranslucent)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsBarTranslucent:"), isBarTranslucent);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsBarTranslucent:"), isBarTranslucent);
			}
		}
		
		[Export ("setParentPopoverController:")]
		[CompilerGenerated]
		public new virtual void SetParentPopoverController (global::UIKit.UIPopoverController controller)
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
		public new virtual void SetPrefersStatusBarHidden (bool val)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPrefersStatusBarHidden:"), val);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPrefersStatusBarHidden:"), val);
			}
		}
		
		[Export ("sharedAnntationStore")]
		[CompilerGenerated]
		public static IPSPDFAnnotationSetStore SharedAnnotationStore ()
		{
			return  Runtime.GetINativeObject<IPSPDFAnnotationSetStore> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedAnntationStore")), false);
		}
		
		[Export ("updateToolbarAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateToolbarAnimated (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateToolbarAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateToolbarAnimated:"), animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationStore_var;
		[CompilerGenerated]
		public virtual IPSPDFAnnotationSetStore AnnotationStore {
			[Export ("annotationStore", ArgumentSemantic.Retain)]
			get {
				IPSPDFAnnotationSetStore ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationSetStore> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationStore")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationSetStore> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationStore")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationStore_var = ret;
				return ret;
			}
			
			[Export ("setAnnotationStore:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotationStore:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotationStore:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationStore_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnnotationStore_var = null;
			}
		}
	} /* class PSPDFSavedAnnotationsViewController */
}
