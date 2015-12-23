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
	[Register("PSPDFConfigurationBuilder", true)]
	public unsafe partial class PSPDFConfigurationBuilder : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFConfigurationBuilder");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFConfigurationBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFConfigurationBuilder (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("overrideClass:withClass:")]
		[CompilerGenerated]
		public virtual void OverrideClass (Class builtinClass, Class subclass)
		{
			if (builtinClass == null)
				throw new ArgumentNullException ("builtinClass");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("overrideClass:withClass:"), builtinClass.Handle, subclass == null ? IntPtr.Zero : subclass.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("overrideClass:withClass:"), builtinClass.Handle, subclass == null ? IntPtr.Zero : subclass.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowBackgroundSaving {
			[Export ("allowBackgroundSaving", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowBackgroundSaving"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowBackgroundSaving"));
				}
			}
			
			[Export ("setAllowBackgroundSaving:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowBackgroundSaving:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowBackgroundSaving:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFTextSelectionMenuAction AllowedMenuActions {
			[Export ("allowedMenuActions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFTextSelectionMenuAction ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextSelectionMenuAction) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("allowedMenuActions"));
					} else {
						ret = (PSPDFTextSelectionMenuAction) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("allowedMenuActions"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFTextSelectionMenuAction) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextSelectionMenuAction) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowedMenuActions"));
					} else {
						ret = (PSPDFTextSelectionMenuAction) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowedMenuActions"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFTextSelectionMenuAction) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setAllowedMenuActions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setAllowedMenuActions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAllowedMenuActions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setAllowedMenuActions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAllowedMenuActions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowToolbarTitleChange {
			[Export ("allowToolbarTitleChange", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowToolbarTitleChange"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowToolbarTitleChange"));
				}
			}
			
			[Export ("setAllowToolbarTitleChange:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowToolbarTitleChange:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowToolbarTitleChange:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AlwaysBouncePages {
			[Export ("alwaysBouncePages", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("alwaysBouncePages"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alwaysBouncePages"));
				}
			}
			
			[Export ("setAlwaysBouncePages:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAlwaysBouncePages:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAlwaysBouncePages:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat AnnotationAnimationDuration {
			[Export ("annotationAnimationDuration", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("annotationAnimationDuration"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationAnimationDuration"));
				}
			}
			
			[Export ("setAnnotationAnimationDuration:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAnnotationAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAnnotationAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AnnotationEntersEditModeAfterSecondTapEnabled {
			[Export ("annotationEntersEditModeAfterSecondTapEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("annotationEntersEditModeAfterSecondTapEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationEntersEditModeAfterSecondTapEnabled"));
				}
			}
			
			[Export ("setAnnotationEntersEditModeAfterSecondTapEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAnnotationEntersEditModeAfterSecondTapEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAnnotationEntersEditModeAfterSecondTapEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AnnotationGroupingEnabled {
			[Export ("annotationGroupingEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("annotationGroupingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationGroupingEnabled"));
				}
			}
			
			[Export ("setAnnotationGroupingEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAnnotationGroupingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAnnotationGroupingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ApplicationActivities_var;
		[CompilerGenerated]
		public virtual NSString[] ApplicationActivities {
			[Export ("applicationActivities", ArgumentSemantic.Copy)]
			get {
				NSString[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("applicationActivities")));
				} else {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationActivities")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ApplicationActivities_var = ret;
				return ret;
			}
			
			[Export ("setApplicationActivities:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setApplicationActivities:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setApplicationActivities:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ApplicationActivities_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool AutosaveEnabled {
			[Export ("isAutosaveEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAutosaveEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAutosaveEnabled"));
				}
			}
			
			[Export ("setAutosaveEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutosaveEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutosaveEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BackgroundColor {
			[Export ("backgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ClipToPageBoundaries {
			[Export ("clipToPageBoundaries", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clipToPageBoundaries"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clipToPageBoundaries"));
				}
			}
			
			[Export ("setClipToPageBoundaries:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClipToPageBoundaries:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setClipToPageBoundaries:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CreateAnnotationMenuEnabled {
			[Export ("isCreateAnnotationMenuEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCreateAnnotationMenuEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isCreateAnnotationMenuEnabled"));
				}
			}
			
			[Export ("setCreateAnnotationMenuEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCreateAnnotationMenuEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCreateAnnotationMenuEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CreateAnnotationMenuGroups_var;
		[CompilerGenerated]
		public virtual NSObject[] CreateAnnotationMenuGroups {
			[Export ("createAnnotationMenuGroups", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("createAnnotationMenuGroups")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("createAnnotationMenuGroups")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CreateAnnotationMenuGroups_var = ret;
				return ret;
			}
			
			[Export ("setCreateAnnotationMenuGroups:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCreateAnnotationMenuGroups:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCreateAnnotationMenuGroups:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_CreateAnnotationMenuGroups_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool CustomerSignatureFeatureEnabled {
			[Export ("customerSignatureFeatureEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("customerSignatureFeatureEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customerSignatureFeatureEnabled"));
				}
			}
			
			[Export ("setCustomerSignatureFeatureEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCustomerSignatureFeatureEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCustomerSignatureFeatureEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DocumentLabelEnabled {
			[Export ("isDocumentLabelEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDocumentLabelEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDocumentLabelEnabled"));
				}
			}
			
			[Export ("setDocumentLabelEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDocumentLabelEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDocumentLabelEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageModeOnFirstPage {
			[Export ("isDoublePageModeOnFirstPage", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDoublePageModeOnFirstPage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDoublePageModeOnFirstPage"));
				}
			}
			
			[Export ("setDoublePageModeOnFirstPage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDoublePageModeOnFirstPage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDoublePageModeOnFirstPage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ExcludedActivityTypes_var;
		[CompilerGenerated]
		public virtual NSString[] ExcludedActivityTypes {
			[Export ("excludedActivityTypes", ArgumentSemantic.Copy)]
			get {
				NSString[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("excludedActivityTypes")));
				} else {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("excludedActivityTypes")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExcludedActivityTypes_var = ret;
				return ret;
			}
			
			[Export ("setExcludedActivityTypes:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setExcludedActivityTypes:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setExcludedActivityTypes:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ExcludedActivityTypes_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool FitToWidthEnabled {
			[Export ("isFitToWidthEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFitToWidthEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isFitToWidthEnabled"));
				}
			}
			
			[Export ("setFitToWidthEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFitToWidthEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFitToWidthEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FixedVerticalPositionForFitToWidthEnabledMode {
			[Export ("fixedVerticalPositionForFitToWidthEnabledMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("fixedVerticalPositionForFitToWidthEnabledMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fixedVerticalPositionForFitToWidthEnabledMode"));
				}
			}
			
			[Export ("setFixedVerticalPositionForFitToWidthEnabledMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFixedVerticalPositionForFitToWidthEnabledMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFixedVerticalPositionForFitToWidthEnabledMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FormElementZoomEnabled {
			[Export ("isFormElementZoomEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFormElementZoomEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isFormElementZoomEnabled"));
				}
			}
			
			[Export ("setFormElementZoomEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFormElementZoomEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFormElementZoomEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_GalleryConfiguration_var;
		[CompilerGenerated]
		public virtual PSPDFGalleryConfiguration GalleryConfiguration {
			[Export ("galleryConfiguration", ArgumentSemantic.Retain)]
			get {
				PSPDFGalleryConfiguration ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFGalleryConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("galleryConfiguration")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFGalleryConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("galleryConfiguration")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GalleryConfiguration_var = ret;
				return ret;
			}
			
			[Export ("setGalleryConfiguration:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGalleryConfiguration:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGalleryConfiguration:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_GalleryConfiguration_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFHUDViewAnimation HUDViewAnimation {
			[Export ("HUDViewAnimation", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFHUDViewAnimation ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFHUDViewAnimation) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("HUDViewAnimation"));
					} else {
						ret = (PSPDFHUDViewAnimation) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("HUDViewAnimation"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFHUDViewAnimation) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("HUDViewAnimation"));
					} else {
						ret = (PSPDFHUDViewAnimation) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("HUDViewAnimation"));
					}
				}
				return ret;
			}
			
			[Export ("setHUDViewAnimation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setHUDViewAnimation:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setHUDViewAnimation:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setHUDViewAnimation:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setHUDViewAnimation:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFHUDViewMode HUDViewMode {
			[Export ("HUDViewMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFHUDViewMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFHUDViewMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("HUDViewMode"));
					} else {
						ret = (PSPDFHUDViewMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("HUDViewMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFHUDViewMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("HUDViewMode"));
					} else {
						ret = (PSPDFHUDViewMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("HUDViewMode"));
					}
				}
				return ret;
			}
			
			[Export ("setHUDViewMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setHUDViewMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setHUDViewMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setHUDViewMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setHUDViewMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ImageSelectionEnabled {
			[Export ("isImageSelectionEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isImageSelectionEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isImageSelectionEnabled"));
				}
			}
			
			[Export ("setImageSelectionEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setImageSelectionEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setImageSelectionEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool InternalTapGesturesEnabled {
			[Export ("internalTapGesturesEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("internalTapGesturesEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("internalTapGesturesEnabled"));
				}
			}
			
			[Export ("setInternalTapGesturesEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setInternalTapGesturesEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setInternalTapGesturesEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLinkAction LinkAction {
			[Export ("linkAction", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFLinkAction ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLinkAction) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("linkAction"));
					} else {
						ret = (PSPDFLinkAction) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("linkAction"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLinkAction) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkAction"));
					} else {
						ret = (PSPDFLinkAction) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkAction"));
					}
				}
				return ret;
			}
			
			[Export ("setLinkAction:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setLinkAction:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setLinkAction:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setLinkAction:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setLinkAction:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDocumentSharingOptions MailSharingOptions {
			[Export ("mailSharingOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDocumentSharingOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("mailSharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("mailSharingOptions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mailSharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mailSharingOptions"));
					}
				}
				return ret;
			}
			
			[Export ("setMailSharingOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setMailSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setMailSharingOptions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setMailSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setMailSharingOptions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets Margin {
			[Export ("margin", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("margin"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("margin"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("margin"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("margin"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("margin"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("margin"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("margin"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("margin"));
					}
				}
				return ret;
			}
			
			[Export ("setMargin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setMargin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setMargin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MaximumZoomScale {
			[Export ("maximumZoomScale", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("maximumZoomScale"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumZoomScale"));
				}
			}
			
			[Export ("setMaximumZoomScale:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMaximumZoomScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMaximumZoomScale:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDocumentSharingOptions MessageSharingOptions {
			[Export ("messageSharingOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDocumentSharingOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("messageSharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("messageSharingOptions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageSharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageSharingOptions"));
					}
				}
				return ret;
			}
			
			[Export ("setMessageSharingOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setMessageSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setMessageSharingOptions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setMessageSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setMessageSharingOptions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinimumZoomScale {
			[Export ("minimumZoomScale", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("minimumZoomScale"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumZoomScale"));
				}
			}
			
			[Export ("setMinimumZoomScale:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMinimumZoomScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMinimumZoomScale:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool NaturalDrawingAnnotationEnabled {
			[Export ("naturalDrawingAnnotationEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("naturalDrawingAnnotationEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("naturalDrawingAnnotationEnabled"));
				}
			}
			
			[Export ("setNaturalDrawingAnnotationEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setNaturalDrawingAnnotationEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setNaturalDrawingAnnotationEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool NaturalSignatureDrawingEnabled {
			[Export ("naturalSignatureDrawingEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("naturalSignatureDrawingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("naturalSignatureDrawingEnabled"));
				}
			}
			
			[Export ("setNaturalSignatureDrawingEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setNaturalSignatureDrawingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setNaturalSignatureDrawingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDocumentSharingOptions OpenInSharingOptions {
			[Export ("openInSharingOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDocumentSharingOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("openInSharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("openInSharingOptions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openInSharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openInSharingOptions"));
					}
				}
				return ret;
			}
			
			[Export ("setOpenInSharingOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setOpenInSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setOpenInSharingOptions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setOpenInSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setOpenInSharingOptions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets Padding {
			[Export ("padding", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("padding"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("padding"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("padding"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("padding"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("padding"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("padding"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("padding"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("padding"));
					}
				}
				return ret;
			}
			
			[Export ("setPadding:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PageCurlDirectionLeftToRight {
			[Export ("isPageCurlDirectionLeftToRight", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPageCurlDirectionLeftToRight"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPageCurlDirectionLeftToRight"));
				}
			}
			
			[Export ("setPageCurlDirectionLeftToRight:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPageCurlDirectionLeftToRight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPageCurlDirectionLeftToRight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PageLabelEnabled {
			[Export ("isPageLabelEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPageLabelEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPageLabelEnabled"));
				}
			}
			
			[Export ("setPageLabelEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPageLabelEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPageLabelEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageMode PageMode {
			[Export ("pageMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFPageMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFPageMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("pageMode"));
					} else {
						ret = (PSPDFPageMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("pageMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFPageMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageMode"));
					} else {
						ret = (PSPDFPageMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageMode"));
					}
				}
				return ret;
			}
			
			[Export ("setPageMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setPageMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPageMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setPageMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPageMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat PagePadding {
			[Export ("pagePadding", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pagePadding"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pagePadding"));
				}
			}
			
			[Export ("setPagePadding:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPagePadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPagePadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageTransition PageTransition {
			[Export ("pageTransition", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFPageTransition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFPageTransition) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("pageTransition"));
					} else {
						ret = (PSPDFPageTransition) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("pageTransition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFPageTransition) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageTransition"));
					} else {
						ret = (PSPDFPageTransition) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageTransition"));
					}
				}
				return ret;
			}
			
			[Export ("setPageTransition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setPageTransition:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPageTransition:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setPageTransition:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPageTransition:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDocumentSharingOptions PrintSharingOptions {
			[Export ("printSharingOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDocumentSharingOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("printSharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("printSharingOptions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("printSharingOptions"));
					} else {
						ret = (PSPDFDocumentSharingOptions) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("printSharingOptions"));
					}
				}
				return ret;
			}
			
			[Export ("setPrintSharingOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setPrintSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPrintSharingOptions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setPrintSharingOptions:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPrintSharingOptions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RenderAnimationEnabled {
			[Export ("isRenderAnimationEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRenderAnimationEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRenderAnimationEnabled"));
				}
			}
			
			[Export ("setRenderAnimationEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRenderAnimationEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRenderAnimationEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageRenderingMode RenderingMode {
			[Export ("renderingMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFPageRenderingMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFPageRenderingMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("renderingMode"));
					} else {
						ret = (PSPDFPageRenderingMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("renderingMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFPageRenderingMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderingMode"));
					} else {
						ret = (PSPDFPageRenderingMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderingMode"));
					}
				}
				return ret;
			}
			
			[Export ("setRenderingMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setRenderingMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setRenderingMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setRenderingMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setRenderingMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFRenderStatusViewPosition RenderStatusViewPosition {
			[Export ("renderStatusViewPosition", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFRenderStatusViewPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFRenderStatusViewPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("renderStatusViewPosition"));
					} else {
						ret = (PSPDFRenderStatusViewPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("renderStatusViewPosition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFRenderStatusViewPosition) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderStatusViewPosition"));
					} else {
						ret = (PSPDFRenderStatusViewPosition) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderStatusViewPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setRenderStatusViewPosition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setRenderStatusViewPosition:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setRenderStatusViewPosition:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setRenderStatusViewPosition:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setRenderStatusViewPosition:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFScrobbleBarType ScrobbleBarType {
			[Export ("scrobbleBarType", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFScrobbleBarType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFScrobbleBarType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("scrobbleBarType"));
					} else {
						ret = (PSPDFScrobbleBarType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("scrobbleBarType"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFScrobbleBarType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrobbleBarType"));
					} else {
						ret = (PSPDFScrobbleBarType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrobbleBarType"));
					}
				}
				return ret;
			}
			
			[Export ("setScrobbleBarType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setScrobbleBarType:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setScrobbleBarType:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setScrobbleBarType:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setScrobbleBarType:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFScrollDirection ScrollDirection {
			[Export ("scrollDirection", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFScrollDirection ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFScrollDirection) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("scrollDirection"));
					} else {
						ret = (PSPDFScrollDirection) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("scrollDirection"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFScrollDirection) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollDirection"));
					} else {
						ret = (PSPDFScrollDirection) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollDirection"));
					}
				}
				return ret;
			}
			
			[Export ("setScrollDirection:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setScrollDirection:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setScrollDirection:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setScrollDirection:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setScrollDirection:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollOnTapPageEndAnimationEnabled {
			[Export ("isScrollOnTapPageEndAnimationEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollOnTapPageEndAnimationEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isScrollOnTapPageEndAnimationEnabled"));
				}
			}
			
			[Export ("setScrollOnTapPageEndAnimationEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollOnTapPageEndAnimationEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollOnTapPageEndAnimationEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollOnTapPageEndEnabled {
			[Export ("isScrollOnTapPageEndEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollOnTapPageEndEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isScrollOnTapPageEndEnabled"));
				}
			}
			
			[Export ("setScrollOnTapPageEndEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollOnTapPageEndEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollOnTapPageEndEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ScrollOnTapPageEndMargin {
			[Export ("scrollOnTapPageEndMargin", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("scrollOnTapPageEndMargin"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollOnTapPageEndMargin"));
				}
			}
			
			[Export ("setScrollOnTapPageEndMargin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setScrollOnTapPageEndMargin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setScrollOnTapPageEndMargin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFSearchMode SearchMode {
			[Export ("searchMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFSearchMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSearchMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("searchMode"));
					} else {
						ret = (PSPDFSearchMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("searchMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFSearchMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchMode"));
					} else {
						ret = (PSPDFSearchMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("searchMode"));
					}
				}
				return ret;
			}
			
			[Export ("setSearchMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setSearchMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setSearchMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setSearchMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setSearchMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShadowEnabled {
			[Export ("isShadowEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isShadowEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isShadowEnabled"));
				}
			}
			
			[Export ("setShadowEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShadowEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShadowEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ShadowOpacity {
			[Export ("shadowOpacity", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("shadowOpacity"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shadowOpacity"));
				}
			}
			
			[Export ("setShadowOpacity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setShadowOpacity:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setShadowOpacity:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldAskForAnnotationUsername {
			[Export ("shouldAskForAnnotationUsername", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldAskForAnnotationUsername"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldAskForAnnotationUsername"));
				}
			}
			
			[Export ("setShouldAskForAnnotationUsername:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldAskForAnnotationUsername:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldAskForAnnotationUsername:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldAutomaticallyAdjustScrollViewInsets {
			[Export ("shouldAutomaticallyAdjustScrollViewInsets", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldAutomaticallyAdjustScrollViewInsets"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldAutomaticallyAdjustScrollViewInsets"));
				}
			}
			
			[Export ("setShouldAutomaticallyAdjustScrollViewInsets:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldAutomaticallyAdjustScrollViewInsets:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldAutomaticallyAdjustScrollViewInsets:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldCacheThumbnails {
			[Export ("shouldCacheThumbnails", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldCacheThumbnails"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldCacheThumbnails"));
				}
			}
			
			[Export ("setShouldCacheThumbnails:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldCacheThumbnails:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldCacheThumbnails:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldHideHUDOnPageChange {
			[Export ("shouldHideHUDOnPageChange", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHideHUDOnPageChange"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldHideHUDOnPageChange"));
				}
			}
			
			[Export ("setShouldHideHUDOnPageChange:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldHideHUDOnPageChange:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldHideHUDOnPageChange:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldHideNavigationBarWithHUD {
			[Export ("shouldHideNavigationBarWithHUD", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHideNavigationBarWithHUD"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldHideNavigationBarWithHUD"));
				}
			}
			
			[Export ("setShouldHideNavigationBarWithHUD:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldHideNavigationBarWithHUD:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldHideNavigationBarWithHUD:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldHideStatusBar {
			[Export ("shouldHideStatusBar", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHideStatusBar"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldHideStatusBar"));
				}
			}
			
			[Export ("setShouldHideStatusBar:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldHideStatusBar:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldHideStatusBar:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldHideStatusBarWithHUD {
			[Export ("shouldHideStatusBarWithHUD", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHideStatusBarWithHUD"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldHideStatusBarWithHUD"));
				}
			}
			
			[Export ("setShouldHideStatusBarWithHUD:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldHideStatusBarWithHUD:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldHideStatusBarWithHUD:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldRestoreNavigationBarStyle {
			[Export ("shouldRestoreNavigationBarStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldRestoreNavigationBarStyle"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldRestoreNavigationBarStyle"));
				}
			}
			
			[Export ("setShouldRestoreNavigationBarStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldRestoreNavigationBarStyle:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldRestoreNavigationBarStyle:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldScrollToChangedPage {
			[Export ("shouldScrollToChangedPage", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldScrollToChangedPage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldScrollToChangedPage"));
				}
			}
			
			[Export ("setShouldScrollToChangedPage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldScrollToChangedPage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldScrollToChangedPage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldShowHUDOnViewWillAppear {
			[Export ("shouldShowHUDOnViewWillAppear", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldShowHUDOnViewWillAppear"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldShowHUDOnViewWillAppear"));
				}
			}
			
			[Export ("setShouldShowHUDOnViewWillAppear:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldShowHUDOnViewWillAppear:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldShowHUDOnViewWillAppear:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowAnnotationMenuAfterCreation {
			[Export ("showAnnotationMenuAfterCreation", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showAnnotationMenuAfterCreation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showAnnotationMenuAfterCreation"));
				}
			}
			
			[Export ("setShowAnnotationMenuAfterCreation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowAnnotationMenuAfterCreation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowAnnotationMenuAfterCreation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowBackActionButton {
			[Export ("showBackActionButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showBackActionButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showBackActionButton"));
				}
			}
			
			[Export ("setShowBackActionButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowBackActionButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowBackActionButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowBackForwardActionButtonLabels {
			[Export ("showBackForwardActionButtonLabels", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showBackForwardActionButtonLabels"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showBackForwardActionButtonLabels"));
				}
			}
			
			[Export ("setShowBackForwardActionButtonLabels:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowBackForwardActionButtonLabels:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowBackForwardActionButtonLabels:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowForwardActionButton {
			[Export ("showForwardActionButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showForwardActionButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showForwardActionButton"));
				}
			}
			
			[Export ("setShowForwardActionButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowForwardActionButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowForwardActionButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsHorizontalScrollIndicator {
			[Export ("showsHorizontalScrollIndicator", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsHorizontalScrollIndicator"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showsHorizontalScrollIndicator"));
				}
			}
			
			[Export ("setShowsHorizontalScrollIndicator:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsHorizontalScrollIndicator:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowsHorizontalScrollIndicator:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsVerticalScrollIndicator {
			[Export ("showsVerticalScrollIndicator", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsVerticalScrollIndicator"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showsVerticalScrollIndicator"));
				}
			}
			
			[Export ("setShowsVerticalScrollIndicator:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsVerticalScrollIndicator:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowsVerticalScrollIndicator:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SignatureSavingEnabled {
			[Export ("signatureSavingEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("signatureSavingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signatureSavingEnabled"));
				}
			}
			
			[Export ("setSignatureSavingEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSignatureSavingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSignatureSavingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SignatureStore_var;
		[CompilerGenerated]
		public virtual IPSPDFSignatureStore SignatureStore {
			[Export ("signatureStore", ArgumentSemantic.Retain)]
			get {
				IPSPDFSignatureStore ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFSignatureStore> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("signatureStore")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFSignatureStore> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signatureStore")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SignatureStore_var = ret;
				return ret;
			}
			
			[Export ("setSignatureStore:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSignatureStore:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSignatureStore:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SignatureStore_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool SmartZoomEnabled {
			[Export ("isSmartZoomEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSmartZoomEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSmartZoomEnabled"));
				}
			}
			
			[Export ("setSmartZoomEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSmartZoomEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSmartZoomEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TextSelectionEnabled {
			[Export ("isTextSelectionEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTextSelectionEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isTextSelectionEnabled"));
				}
			}
			
			[Export ("setTextSelectionEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTextSelectionEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTextSelectionEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFTextSelectionMode TextSelectionMode {
			[Export ("textSelectionMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFTextSelectionMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextSelectionMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("textSelectionMode"));
					} else {
						ret = (PSPDFTextSelectionMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("textSelectionMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextSelectionMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textSelectionMode"));
					} else {
						ret = (PSPDFTextSelectionMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textSelectionMode"));
					}
				}
				return ret;
			}
			
			[Export ("setTextSelectionMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setTextSelectionMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setTextSelectionMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setTextSelectionMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setTextSelectionMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TextSelectionShouldSnapToWord {
			[Export ("textSelectionShouldSnapToWord", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("textSelectionShouldSnapToWord"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textSelectionShouldSnapToWord"));
				}
			}
			
			[Export ("setTextSelectionShouldSnapToWord:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTextSelectionShouldSnapToWord:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTextSelectionShouldSnapToWord:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFThumbnailBarMode ThumbnailBarMode {
			[Export ("thumbnailBarMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFThumbnailBarMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFThumbnailBarMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailBarMode"));
					} else {
						ret = (PSPDFThumbnailBarMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailBarMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFThumbnailBarMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailBarMode"));
					} else {
						ret = (PSPDFThumbnailBarMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailBarMode"));
					}
				}
				return ret;
			}
			
			[Export ("setThumbnailBarMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setThumbnailBarMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setThumbnailBarMode:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setThumbnailBarMode:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setThumbnailBarMode:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFThumbnailGrouping ThumbnailGrouping {
			[Export ("thumbnailGrouping", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFThumbnailGrouping ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFThumbnailGrouping) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailGrouping"));
					} else {
						ret = (PSPDFThumbnailGrouping) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailGrouping"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFThumbnailGrouping) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailGrouping"));
					} else {
						ret = (PSPDFThumbnailGrouping) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailGrouping"));
					}
				}
				return ret;
			}
			
			[Export ("setThumbnailGrouping:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setThumbnailGrouping:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setThumbnailGrouping:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setThumbnailGrouping:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setThumbnailGrouping:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets ThumbnailMargin {
			[Export ("thumbnailMargin", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailMargin"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("thumbnailMargin"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("thumbnailMargin"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("thumbnailMargin"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailMargin"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("thumbnailMargin"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("thumbnailMargin"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("thumbnailMargin"));
					}
				}
				return ret;
			}
			
			[Export ("setThumbnailMargin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setThumbnailMargin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setThumbnailMargin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGSize ThumbnailSize {
			[Export ("thumbnailSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailSize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("thumbnailSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailSize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailSize"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailSize"));
						} else {
							global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("thumbnailSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailSize"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailSize"));
					}
				}
				return ret;
			}
			
			[Export ("setThumbnailSize:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setThumbnailSize:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("setThumbnailSize:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType TypesShowingColorPresets {
			[Export ("typesShowingColorPresets", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("typesShowingColorPresets"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("typesShowingColorPresets"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("typesShowingColorPresets"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("typesShowingColorPresets"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setTypesShowingColorPresets:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setTypesShowingColorPresets:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setTypesShowingColorPresets:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setTypesShowingColorPresets:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setTypesShowingColorPresets:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseParentNavigationBar {
			[Export ("useParentNavigationBar", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useParentNavigationBar"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useParentNavigationBar"));
				}
			}
			
			[Export ("setUseParentNavigationBar:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseParentNavigationBar:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseParentNavigationBar:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomingSmallDocumentsEnabled {
			[Export ("isZoomingSmallDocumentsEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomingSmallDocumentsEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isZoomingSmallDocumentsEnabled"));
				}
			}
			
			[Export ("setZoomingSmallDocumentsEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setZoomingSmallDocumentsEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setZoomingSmallDocumentsEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ApplicationActivities_var = null;
				__mt_BackgroundColor_var = null;
				__mt_CreateAnnotationMenuGroups_var = null;
				__mt_ExcludedActivityTypes_var = null;
				__mt_GalleryConfiguration_var = null;
				__mt_SignatureStore_var = null;
			}
		}
	} /* class PSPDFConfigurationBuilder */
}
