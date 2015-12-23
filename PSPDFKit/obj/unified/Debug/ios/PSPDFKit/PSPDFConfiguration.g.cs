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
	[Register("PSPDFConfiguration", true)]
	public unsafe partial class PSPDFConfiguration : PSPDFModel, IPSPDFOverridable {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFConfiguration");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFConfiguration (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFConfiguration (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		
		[Export ("configurationUpdatedWithBuilder:")]
		[CompilerGenerated]
		public unsafe virtual PSPDFConfiguration ConfigurationUpdated ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<PSPDFConfigurationBuilder> builderHandler)
		{
			if (builderHandler == null)
				throw new ArgumentNullException ("builderHandler");
			BlockLiteral *block_ptr_builderHandler;
			BlockLiteral block_builderHandler;
			block_builderHandler = new BlockLiteral ();
			block_ptr_builderHandler = &block_builderHandler;
			block_builderHandler.SetupBlock (Trampolines.SDActionArity1V0.Handler, builderHandler);
			
			PSPDFConfiguration ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("configurationUpdatedWithBuilder:"), (IntPtr) block_ptr_builderHandler));
			} else {
				ret =  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("configurationUpdatedWithBuilder:"), (IntPtr) block_ptr_builderHandler));
			}
			block_ptr_builderHandler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("configurationWithBuilder:")]
		[CompilerGenerated]
		public unsafe static PSPDFConfiguration FromConfigurationBuilder ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<PSPDFConfigurationBuilder> builderHandler)
		{
			BlockLiteral *block_ptr_builderHandler;
			BlockLiteral block_builderHandler;
			if (builderHandler == null){
				block_ptr_builderHandler = null;
			} else {
				block_builderHandler = new BlockLiteral ();
				block_ptr_builderHandler = &block_builderHandler;
				block_builderHandler.SetupBlock (Trampolines.SDActionArity1V0.Handler, builderHandler);
			}
			
			PSPDFConfiguration ret;
			ret =  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("configurationWithBuilder:"), (IntPtr) block_ptr_builderHandler));
			if (block_ptr_builderHandler != null)
				block_ptr_builderHandler->CleanupBlock ();
			
			return ret;
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
			
		}
		
		[CompilerGenerated]
		static object __mt_DefaultConfiguration_var_static;
		[CompilerGenerated]
		public static PSPDFConfiguration DefaultConfiguration {
			[Export ("defaultConfiguration")]
			get {
				PSPDFConfiguration ret;
				ret =  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultConfiguration")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_DefaultConfiguration_var_static = ret;
				return ret;
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
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFHUDViewAnimation HudViewAnimation {
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
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFHUDViewMode HudViewMode {
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
	} /* class PSPDFConfiguration */
}
