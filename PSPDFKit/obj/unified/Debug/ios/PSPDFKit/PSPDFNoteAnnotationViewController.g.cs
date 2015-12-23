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
	[Register("PSPDFNoteAnnotationViewController", true)]
	public unsafe partial class PSPDFNoteAnnotationViewController : PSPDFBaseViewController, IPSPDFStyleable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFNoteAnnotationViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFNoteAnnotationViewController () : base (NSObjectFlag.Empty)
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
		public PSPDFNoteAnnotationViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFNoteAnnotationViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFNoteAnnotationViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAnnotation:")]
		[CompilerGenerated]
		public PSPDFNoteAnnotationViewController (PSPDFAnnotation annotation)
			: base (NSObjectFlag.Empty)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithAnnotation:"), annotation.Handle), "initWithAnnotation:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAnnotation:"), annotation.Handle), "initWithAnnotation:");
			}
		}
		
		[Export ("beginEditing")]
		[CompilerGenerated]
		public virtual bool BeginEditing ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("beginEditing"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beginEditing"));
			}
		}
		
		[Export ("deleteAnnotation:")]
		[CompilerGenerated]
		public virtual void DeleteAnnotation (global::UIKit.UIBarButtonItem barButtonItem)
		{
			if (barButtonItem == null)
				throw new ArgumentNullException ("barButtonItem");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deleteAnnotation:"), barButtonItem.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteAnnotation:"), barButtonItem.Handle);
			}
		}
		
		[Export ("deleteAnnotationActionTitle")]
		[CompilerGenerated]
		public virtual string DeleteAnnotationActionTitle ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("deleteAnnotationActionTitle")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deleteAnnotationActionTitle")));
			}
		}
		
		[Export ("deleteOrClearAnnotationWithoutConfirmation")]
		[CompilerGenerated]
		public virtual void DeleteOrClearAnnotationWithoutConfirmation ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("deleteOrClearAnnotationWithoutConfirmation"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deleteOrClearAnnotationWithoutConfirmation"));
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
		
		[Export ("setupToolbar")]
		[CompilerGenerated]
		public virtual void SetupToolbar ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setupToolbar"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setupToolbar"));
			}
		}
		
		[Export ("updateTextView")]
		[CompilerGenerated]
		public virtual void UpdateTextView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateTextView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateTextView"));
			}
		}
		
		[Export ("updateToolbar")]
		[CompilerGenerated]
		public virtual void UpdateToolbar ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateToolbar"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateToolbar"));
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowEditing {
			[Export ("allowEditing", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowEditing"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowEditing"));
				}
			}
			
			[Export ("setAllowEditing:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowEditing:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowEditing:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation Annotation {
			[Export ("annotation", ArgumentSemantic.Retain)]
			get {
				PSPDFAnnotation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotation")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotation")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Annotation_var = ret;
				return ret;
			}
			
			[Export ("setAnnotation:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotation:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotation:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Annotation_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView BackgroundView {
			[Export ("backgroundView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BorderColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BorderColor {
			[Export ("borderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("borderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BorderColor_var = ret;
				return ret;
			}
			
			[Export ("setBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BorderColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFNoteAnnotationViewControllerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFNoteAnnotationViewControllerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFNoteAnnotationViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFNoteAnnotationViewControllerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_OptionsView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView OptionsView {
			[Export ("optionsView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("optionsView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("optionsView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OptionsView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShouldBeginEditModeWhenPresented {
			[Export ("shouldBeginEditModeWhenPresented", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldBeginEditModeWhenPresented"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldBeginEditModeWhenPresented"));
				}
			}
			
			[Export ("setShouldBeginEditModeWhenPresented:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldBeginEditModeWhenPresented:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldBeginEditModeWhenPresented:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowColorAndIconOptions {
			[Export ("showColorAndIconOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showColorAndIconOptions"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showColorAndIconOptions"));
				}
			}
			
			[Export ("setShowColorAndIconOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowColorAndIconOptions:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowColorAndIconOptions:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowCopyButton {
			[Export ("showCopyButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showCopyButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showCopyButton"));
				}
			}
			
			[Export ("setShowCopyButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowCopyButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowCopyButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TapGesture_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITapGestureRecognizer TapGesture {
			[Export ("tapGesture", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tapGesture")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tapGesture")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TapGesture_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_TextView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITextView TextView {
			[Export ("textView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITextView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITextView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITextView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TextView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
				__mt_BackgroundView_var = null;
				__mt_BorderColor_var = null;
				__mt_Delegate_var = null;
				__mt_OptionsView_var = null;
				__mt_TapGesture_var = null;
				__mt_TextView_var = null;
			}
		}
	} /* class PSPDFNoteAnnotationViewController */
}
