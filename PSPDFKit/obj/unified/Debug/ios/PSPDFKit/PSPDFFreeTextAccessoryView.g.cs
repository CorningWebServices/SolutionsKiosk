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
	[Register("PSPDFFreeTextAccessoryView", true)]
	public unsafe partial class PSPDFFreeTextAccessoryView : PSPDFToolbar, IPSPDFAnnotationStyleViewControllerDelegate, IPSPDFFontPickerViewControllerDelegate, IPSPDFOverridable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFreeTextAccessoryView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFreeTextAccessoryView () : base (NSObjectFlag.Empty)
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
		public PSPDFFreeTextAccessoryView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFFreeTextAccessoryView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFreeTextAccessoryView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFFreeTextAccessoryView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("annotationStyleController:annotationViewForAnnotation:")]
		[CompilerGenerated]
		public virtual IPSPDFAnnotationViewProtocol AnnotationViewForAnnotation (PSPDFAnnotationStyleViewController styleController, PSPDFAnnotation annotation)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return  Runtime.GetINativeObject<IPSPDFAnnotationViewProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationStyleController:annotationViewForAnnotation:"), styleController.Handle, annotation.Handle), false);
			} else {
				return  Runtime.GetINativeObject<IPSPDFAnnotationViewProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationStyleController:annotationViewForAnnotation:"), styleController.Handle, annotation.Handle), false);
			}
		}
		
		[Export ("buttonsForWidth:")]
		[CompilerGenerated]
		public virtual PSPDFToolbarButton[] ButtonsForWidth (global::System.nfloat width)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFToolbarButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("buttonsForWidth:"), width));
			} else {
				return NSArray.ArrayFromHandle<PSPDFToolbarButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("buttonsForWidth:"), width));
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
		
		[Export ("annotationStyleController:didChangeProperty:")]
		[CompilerGenerated]
		public virtual void DidChangeProperty (PSPDFAnnotationStyleViewController styleController, NSString propertyName)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationStyleController:didChangeProperty:"), styleController.Handle, propertyName.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationStyleController:didChangeProperty:"), styleController.Handle, propertyName.Handle);
			}
		}
		
		[Export ("annotationStyleController:didEndChangingProperty:")]
		[CompilerGenerated]
		public virtual void DidEndChangingProperty (PSPDFAnnotationStyleViewController styleController, NSString propertyName)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationStyleController:didEndChangingProperty:"), styleController.Handle, propertyName.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationStyleController:didEndChangingProperty:"), styleController.Handle, propertyName.Handle);
			}
		}
		
		[Export ("fontPickerViewController:didSelectFont:")]
		[CompilerGenerated]
		public virtual void DidSelectFont (PSPDFFontPickerViewController fontPickerViewController, global::UIKit.UIFont selectedFont)
		{
			if (fontPickerViewController == null)
				throw new ArgumentNullException ("fontPickerViewController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("fontPickerViewController:didSelectFont:"), fontPickerViewController.Handle, selectedFont == null ? IntPtr.Zero : selectedFont.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("fontPickerViewController:didSelectFont:"), fontPickerViewController.Handle, selectedFont == null ? IntPtr.Zero : selectedFont.Handle);
			}
		}
		
		[Export ("annotationStyleController:willStartChangingProperty:")]
		[CompilerGenerated]
		public virtual void WillStartChangingProperty (PSPDFAnnotationStyleViewController styleController, NSString propertyName)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationStyleController:willStartChangingProperty:"), styleController.Handle, propertyName.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationStyleController:willStartChangingProperty:"), styleController.Handle, propertyName.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFFreeTextAnnotation Annotation {
			[Export ("annotation", ArgumentSemantic.Retain)]
			get {
				PSPDFFreeTextAnnotation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFFreeTextAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotation")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFFreeTextAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotation")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Annotation_var = ret;
				return ret;
			}
			
			[Export ("setAnnotation:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotation:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotation:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Annotation_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool BorderVisible {
			[Export ("isBorderVisible", ArgumentSemantic.Weak)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBorderVisible"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBorderVisible"));
				}
			}
			
			[Export ("setBorderVisible:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBorderVisible:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setBorderVisible:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CenterAlignButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarSelectableButton CenterAlignButton {
			[Export ("centerAlignButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarSelectableButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarSelectableButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("centerAlignButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarSelectableButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerAlignButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CenterAlignButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ClearButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton ClearButton {
			[Export ("clearButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("clearButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ClearButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ColorButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton ColorButton {
			[Export ("colorButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("colorButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ColorButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DecreaseFontSizeButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton DecreaseFontSizeButton {
			[Export ("decreaseFontSizeButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("decreaseFontSizeButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("decreaseFontSizeButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DecreaseFontSizeButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFFreeTextAccessoryViewDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFFreeTextAccessoryViewDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFFreeTextAccessoryViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFFreeTextAccessoryViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_DoneButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton DoneButton {
			[Export ("doneButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("doneButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("doneButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DoneButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FontNameButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton FontNameButton {
			[Export ("fontNameButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fontNameButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontNameButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FontNameButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FontSizeButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton FontSizeButton {
			[Export ("fontSizeButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fontSizeButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontSizeButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FontSizeButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_IncreaseFontSizeButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton IncreaseFontSizeButton {
			[Export ("increaseFontSizeButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("increaseFontSizeButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("increaseFontSizeButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_IncreaseFontSizeButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LeftAlignButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarSelectableButton LeftAlignButton {
			[Export ("leftAlignButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarSelectableButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarSelectableButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftAlignButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarSelectableButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftAlignButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LeftAlignButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PresentationContext_var;
		[CompilerGenerated]
		public virtual IPSPDFPresentationContext PresentationContext {
			[Export ("presentationContext", ArgumentSemantic.Weak)]
			get {
				IPSPDFPresentationContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("presentationContext")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presentationContext")), false);
				}
				MarkDirty ();
				__mt_PresentationContext_var = ret;
				return ret;
			}
			
			[Export ("setPresentationContext:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPresentationContext:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPresentationContext:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_PresentationContext_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RightAlignButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarSelectableButton RightAlignButton {
			[Export ("rightAlignButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarSelectableButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarSelectableButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightAlignButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarSelectableButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightAlignButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightAlignButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SeparatorColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SeparatorColor {
			[Export ("separatorColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("separatorColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("separatorColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SeparatorColor_var = ret;
				return ret;
			}
			
			[Export ("setSeparatorColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSeparatorColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSeparatorColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SeparatorColor_var = value;
			}
		}
		
		[CompilerGenerated]
		static NSString _DidPressClearButtonNotification;
		[Field ("PSPDFFreeTextAccessoryViewDidPressClearButtonNotification",  "__Internal")]
		public static unsafe NSString DidPressClearButtonNotification {
			get {
				if (_DidPressClearButtonNotification == null)
					_DidPressClearButtonNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFFreeTextAccessoryViewDidPressClearButtonNotification");
				return _DidPressClearButtonNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
				__mt_CenterAlignButton_var = null;
				__mt_ClearButton_var = null;
				__mt_ColorButton_var = null;
				__mt_DecreaseFontSizeButton_var = null;
				__mt_Delegate_var = null;
				__mt_DoneButton_var = null;
				__mt_FontNameButton_var = null;
				__mt_FontSizeButton_var = null;
				__mt_IncreaseFontSizeButton_var = null;
				__mt_LeftAlignButton_var = null;
				__mt_PresentationContext_var = null;
				__mt_RightAlignButton_var = null;
				__mt_SeparatorColor_var = null;
			}
		}
		public partial class PSPDFFreeTextAccessoryViewAppearance : global::PSPDFKit.PSPDFToolbar.PSPDFToolbarAppearance {
			protected internal PSPDFFreeTextAccessoryViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFFreeTextAccessoryViewAppearance Appearance {
			get { return new PSPDFFreeTextAccessoryViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFFreeTextAccessoryViewAppearance GetAppearance<T> () where T: PSPDFFreeTextAccessoryView {
			return new PSPDFFreeTextAccessoryViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFFreeTextAccessoryViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFFreeTextAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFFreeTextAccessoryViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFFreeTextAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFFreeTextAccessoryViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFFreeTextAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFFreeTextAccessoryViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFFreeTextAccessoryView {
			return new PSPDFFreeTextAccessoryViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFFreeTextAccessoryViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFFreeTextAccessoryView{
			return new PSPDFFreeTextAccessoryViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDidPressClearButton (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidPressClearButtonNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFFreeTextAccessoryView */
}
