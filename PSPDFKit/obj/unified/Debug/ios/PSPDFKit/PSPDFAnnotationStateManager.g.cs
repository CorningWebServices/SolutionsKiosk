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
	[Register("PSPDFAnnotationStateManager", true)]
	public unsafe partial class PSPDFAnnotationStateManager : NSObject, IPSPDFOverridable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationStateManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationStateManager () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationStateManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationStateManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancelDrawingAnimated:")]
		[CompilerGenerated]
		public virtual void CancelDrawing (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("cancelDrawingAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("cancelDrawingAnimated:"), animated);
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
		
		[Export ("doneDrawingAnimated:")]
		[CompilerGenerated]
		public virtual void DoneDrawing (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("doneDrawingAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("doneDrawingAnimated:"), animated);
			}
		}
		
		[Export ("isDrawingState:")]
		[CompilerGenerated]
		public virtual bool IsDrawingState (NSString state)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isDrawingState:"), state == null ? IntPtr.Zero : state.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isDrawingState:"), state == null ? IntPtr.Zero : state.Handle);
			}
		}
		
		[Export ("isHighlightAnnotationState:")]
		[CompilerGenerated]
		public virtual bool IsHighlightAnnotationState (NSString state)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isHighlightAnnotationState:"), state == null ? IntPtr.Zero : state.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isHighlightAnnotationState:"), state == null ? IntPtr.Zero : state.Handle);
			}
		}
		
		[Export ("lastUsedColorForAnnotationString:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIColor LastUsedColor (NSString annotationString)
		{
			if (annotationString == null)
				throw new ArgumentNullException ("annotationString");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("lastUsedColorForAnnotationString:"), annotationString.Handle));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("lastUsedColorForAnnotationString:"), annotationString.Handle));
			}
		}
		
		[Export ("performSelectionOnPageView:atPoint:")]
		[CompilerGenerated]
		public virtual void PerformSelectionOnPageView (PSPDFPageView pageView, CGPoint point)
		{
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGPoint (this.Handle, Selector.GetHandle ("performSelectionOnPageView:atPoint:"), pageView.Handle, point);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_CGPoint (this.SuperHandle, Selector.GetHandle ("performSelectionOnPageView:atPoint:"), pageView.Handle, point);
			}
		}
		
		[Export ("redo")]
		[CompilerGenerated]
		public virtual void Redo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("redo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("redo"));
			}
		}
		
		[Export ("setLastUsedColor:annotationString:")]
		[CompilerGenerated]
		public virtual void SetLastUsedColor (global::UIKit.UIColor lastUsedDrawColor, NSString annotationString)
		{
			if (annotationString == null)
				throw new ArgumentNullException ("annotationString");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLastUsedColor:annotationString:"), lastUsedDrawColor == null ? IntPtr.Zero : lastUsedDrawColor.Handle, annotationString.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setLastUsedColor:annotationString:"), lastUsedDrawColor == null ? IntPtr.Zero : lastUsedDrawColor.Handle, annotationString.Handle);
			}
		}
		
		[Export ("setState:variant:")]
		[CompilerGenerated]
		public virtual void SetState (NSString state, NSString variant)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setState:variant:"), state == null ? IntPtr.Zero : state.Handle, variant == null ? IntPtr.Zero : variant.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setState:variant:"), state == null ? IntPtr.Zero : state.Handle, variant == null ? IntPtr.Zero : variant.Handle);
			}
		}
		
		[Export ("showStylePicker:presentationOptions:")]
		[CompilerGenerated]
		public virtual void ShowStylePicker (NSObject sender, NSDictionary options)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("showStylePicker:presentationOptions:"), sender == null ? IntPtr.Zero : sender.Handle, options == null ? IntPtr.Zero : options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("showStylePicker:presentationOptions:"), sender == null ? IntPtr.Zero : sender.Handle, options == null ? IntPtr.Zero : options.Handle);
			}
		}
		
		[Export ("stateShowsStylePicker:")]
		[CompilerGenerated]
		public virtual bool StateShowsStylePicker (NSString state)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stateShowsStylePicker:"), state == null ? IntPtr.Zero : state.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stateShowsStylePicker:"), state == null ? IntPtr.Zero : state.Handle);
			}
		}
		
		[Export ("stylusSupport")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationStateManagerStylusSupport StylusSupport ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFAnnotationStateManagerStylusSupport> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stylusSupport")));
			} else {
				return  Runtime.GetNSObject<PSPDFAnnotationStateManagerStylusSupport> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stylusSupport")));
			}
		}
		
		[Export ("toggleImagePickerController:presentationOptions:")]
		[CompilerGenerated]
		public virtual void ToggleImagePickerController (NSObject sender, NSDictionary options)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("toggleImagePickerController:presentationOptions:"), sender == null ? IntPtr.Zero : sender.Handle, options == null ? IntPtr.Zero : options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleImagePickerController:presentationOptions:"), sender == null ? IntPtr.Zero : sender.Handle, options == null ? IntPtr.Zero : options.Handle);
			}
		}
		
		[Export ("toggleSignatureController:presentationOptions:")]
		[CompilerGenerated]
		public virtual void ToggleSignatureController (NSObject sender, NSDictionary options)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("toggleSignatureController:presentationOptions:"), sender == null ? IntPtr.Zero : sender.Handle, options == null ? IntPtr.Zero : options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleSignatureController:presentationOptions:"), sender == null ? IntPtr.Zero : sender.Handle, options == null ? IntPtr.Zero : options.Handle);
			}
		}
		
		[Export ("toggleStampController:includeSavedAnnotations:presentationOptions:")]
		[CompilerGenerated]
		public virtual void ToggleStampController (NSObject sender, bool includeSavedAnnotations, NSDictionary options)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("toggleStampController:includeSavedAnnotations:presentationOptions:"), sender == null ? IntPtr.Zero : sender.Handle, includeSavedAnnotations, options == null ? IntPtr.Zero : options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleStampController:includeSavedAnnotations:presentationOptions:"), sender == null ? IntPtr.Zero : sender.Handle, includeSavedAnnotations, options == null ? IntPtr.Zero : options.Handle);
			}
		}
		
		[Export ("toggleState:")]
		[CompilerGenerated]
		public virtual void ToggleState (NSString state)
		{
			if (state == null)
				throw new ArgumentNullException ("state");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toggleState:"), state.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleState:"), state.Handle);
			}
		}
		
		[Export ("toggleState:variant:")]
		[CompilerGenerated]
		public virtual void ToggleState (NSString state, NSString variant)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("toggleState:variant:"), state == null ? IntPtr.Zero : state.Handle, variant == null ? IntPtr.Zero : variant.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleState:variant:"), state == null ? IntPtr.Zero : state.Handle, variant == null ? IntPtr.Zero : variant.Handle);
			}
		}
		
		[Export ("undo")]
		[CompilerGenerated]
		public virtual void Undo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("undo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("undo"));
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFImageQuality AllowedImageQualities {
			[Export ("allowedImageQualities", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFImageQuality ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFImageQuality) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("allowedImageQualities"));
					} else {
						ret = (PSPDFImageQuality) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("allowedImageQualities"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFImageQuality) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFImageQuality) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowedImageQualities"));
					} else {
						ret = (PSPDFImageQuality) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowedImageQualities"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFImageQuality) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setAllowedImageQualities:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setAllowedImageQualities:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAllowedImageQualities:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setAllowedImageQualities:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAllowedImageQualities:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CanRedo {
			[Export ("canRedo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canRedo"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canRedo"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CanUndo {
			[Export ("canUndo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canUndo"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canUndo"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DashArray_var;
		[CompilerGenerated]
		public virtual NSObject[] DashArray {
			[Export ("dashArray", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dashArray")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dashArray")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DashArray_var = ret;
				return ret;
			}
			
			[Export ("setDashArray:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDashArray:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDashArray:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_DashArray_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DrawColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DrawColor {
			[Export ("drawColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("drawColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drawColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DrawColor_var = ret;
				return ret;
			}
			
			[Export ("setDrawColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDrawColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDrawColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DrawColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDrawViewInputMode DrawingInputMode {
			[Export ("drawingInputMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDrawViewInputMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDrawViewInputMode) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("drawingInputMode"));
					} else {
						ret = (PSPDFDrawViewInputMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("drawingInputMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDrawViewInputMode) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drawingInputMode"));
					} else {
						ret = (PSPDFDrawViewInputMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drawingInputMode"));
					}
				}
				return ret;
			}
			
			[Export ("setDrawingInputMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setDrawingInputMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDrawingInputMode:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setDrawingInputMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDrawingInputMode:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DrawViews_var;
		[CompilerGenerated]
		public virtual NSDictionary DrawViews {
			[Export ("drawViews", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("drawViews")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drawViews")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DrawViews_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FillColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor FillColor {
			[Export ("fillColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fillColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fillColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FillColor_var = ret;
				return ret;
			}
			
			[Export ("setFillColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFillColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFillColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FillColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string FontName {
			[Export ("fontName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fontName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontName")));
				}
			}
			
			[Export ("setFontName:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFontName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFontName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat FontSize {
			[Export ("fontSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("fontSize"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontSize"));
				}
			}
			
			[Export ("setFontSize:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setFontSize:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setFontSize:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd1 {
			[Export ("lineEnd1", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFLineEndType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd1"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd1"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd1"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd1"));
					}
				}
				return ret;
			}
			
			[Export ("setLineEnd1:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLineEnd1:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLineEnd1:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLineEnd1:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLineEnd1:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd2 {
			[Export ("lineEnd2", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFLineEndType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd2"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd2"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd2"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd2"));
					}
				}
				return ret;
			}
			
			[Export ("setLineEnd2:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLineEnd2:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLineEnd2:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLineEnd2:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLineEnd2:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat LineWidth {
			[Export ("lineWidth", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("lineWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineWidth"));
				}
			}
			
			[Export ("setLineWidth:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLineWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLineWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PdfController_var;
		[CompilerGenerated]
		public virtual PSPDFViewController PdfController {
			[Export ("pdfController", ArgumentSemantic.Weak)]
			get {
				PSPDFViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pdfController")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pdfController")));
				}
				MarkDirty ();
				__mt_PdfController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_State_var;
		[CompilerGenerated]
		public virtual NSString State {
			[Export ("state")]
			get {
				NSString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("state")));
				} else {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_State_var = ret;
				return ret;
			}
			
			[Export ("setState:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setState:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setState:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_State_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_StateDelegate_var;
		[CompilerGenerated]
		public virtual IPSPDFAnnotationStateManagerDelegate StateDelegate {
			[Export ("stateDelegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFAnnotationStateManagerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationStateManagerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stateDelegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationStateManagerDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stateDelegate")), false);
				}
				MarkDirty ();
				__mt_StateDelegate_var = ret;
				return ret;
			}
			
			[Export ("setStateDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStateDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStateDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_StateDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_StateVariantIdentifier_var;
		[CompilerGenerated]
		public virtual NSString StateVariantIdentifier {
			[Export ("stateVariantIdentifier")]
			get {
				NSString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stateVariantIdentifier")));
				} else {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stateVariantIdentifier")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_StateVariantIdentifier_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_StylusStatusButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton StylusStatusButton {
			[Export ("stylusStatusButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stylusStatusButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stylusStatusButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_StylusStatusButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UITextAlignment TextAlignment {
			[Export ("textAlignment", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UITextAlignment ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UITextAlignment) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("textAlignment"));
					} else {
						ret = (global::UIKit.UITextAlignment) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("textAlignment"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UITextAlignment) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textAlignment"));
					} else {
						ret = (global::UIKit.UITextAlignment) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textAlignment"));
					}
				}
				return ret;
			}
			
			[Export ("setTextAlignment:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setTextAlignment:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setTextAlignment:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setTextAlignment:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setTextAlignment:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Variant_var;
		[CompilerGenerated]
		public virtual NSString Variant {
			[Export ("variant")]
			get {
				NSString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("variant")));
				} else {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("variant")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Variant_var = ret;
				return ret;
			}
			
			[Export ("setVariant:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVariant:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setVariant:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Variant_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DashArray_var = null;
				__mt_DrawColor_var = null;
				__mt_DrawViews_var = null;
				__mt_FillColor_var = null;
				__mt_PdfController_var = null;
				__mt_State_var = null;
				__mt_StateDelegate_var = null;
				__mt_StateVariantIdentifier_var = null;
				__mt_StylusStatusButton_var = null;
				__mt_Variant_var = null;
			}
		}
	} /* class PSPDFAnnotationStateManager */
}
