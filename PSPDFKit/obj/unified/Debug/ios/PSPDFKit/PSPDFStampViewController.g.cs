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
	[Register("PSPDFStampViewController", true)]
	public unsafe partial class PSPDFStampViewController : PSPDFAnnotationGridViewController, IPSPDFAnnotationGridViewControllerDataSource, IPSPDFOverridable, IPSPDFTextStampViewControllerDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFStampViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFStampViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFStampViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStampViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		
		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			if (originalClass == null)
				throw new ArgumentNullException ("originalClass");
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("classForClass:"), originalClass.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("classForClass:"), originalClass.Handle);
			}
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("defaultDateStamps")]
		[CompilerGenerated]
		public virtual PSPDFStampAnnotation[] DefaultDateStamps ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFStampAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("defaultDateStamps")));
			} else {
				return NSArray.ArrayFromHandle<PSPDFStampAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultDateStamps")));
			}
		}
		
		[Export ("textStampViewController:didCreateAnnotation:")]
		[CompilerGenerated]
		public virtual void DidCreateAnnotation (PSPDFTextStampViewController stampController, PSPDFStampAnnotation stampAnnotation)
		{
			if (stampController == null)
				throw new ArgumentNullException ("stampController");
			if (stampAnnotation == null)
				throw new ArgumentNullException ("stampAnnotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("textStampViewController:didCreateAnnotation:"), stampController.Handle, stampAnnotation.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("textStampViewController:didCreateAnnotation:"), stampController.Handle, stampAnnotation.Handle);
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
		
		[CompilerGenerated]
		public virtual bool CustomStampEnabled {
			[Export ("customStampEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("customStampEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customStampEnabled"));
				}
			}
			
			[Export ("setCustomStampEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCustomStampEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCustomStampEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DateStampsEnabled {
			[Export ("dateStampsEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("dateStampsEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dateStampsEnabled"));
				}
			}
			
			[Export ("setDateStampsEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDateStampsEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDateStampsEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_DefaultStampAnnotations_var_static;
		[CompilerGenerated]
		public static PSPDFStampAnnotation[] DefaultStampAnnotations {
			[Export ("defaultStampAnnotations")]
			get {
				PSPDFStampAnnotation[] ret;
				ret = NSArray.ArrayFromHandle<PSPDFStampAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultStampAnnotations")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_DefaultStampAnnotations_var_static = ret;
				return ret;
			}
			
			[Export ("setDefaultStampAnnotations:")]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setDefaultStampAnnotations:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Stamps_var;
		[CompilerGenerated]
		public virtual PSPDFStampAnnotation[] Stamps {
			[Export ("stamps", ArgumentSemantic.Copy)]
			get {
				PSPDFStampAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFStampAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stamps")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFStampAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stamps")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Stamps_var = ret;
				return ret;
			}
			
			[Export ("setStamps:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStamps:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStamps:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Stamps_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Stamps_var = null;
			}
		}
	} /* class PSPDFStampViewController */
}
