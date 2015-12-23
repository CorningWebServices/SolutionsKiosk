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
	[Register("PSPDFScrobbleBar", true)]
	public unsafe partial class PSPDFScrobbleBar : global::UIKit.UIView, IPSPDFCacheDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFScrobbleBar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFScrobbleBar () : base (NSObjectFlag.Empty)
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
		public PSPDFScrobbleBar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFScrobbleBar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFScrobbleBar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFScrobbleBar (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("didRenderImage:document:page:size:")]
		[CompilerGenerated]
		public virtual void DidRenderImage (global::UIKit.UIImage image, PSPDFDocument document, global::System.nuint page, CGSize size)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_CGSize (this.Handle, Selector.GetHandle ("didRenderImage:document:page:size:"), image.Handle, document.Handle, page, size);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_CGSize (this.SuperHandle, Selector.GetHandle ("didRenderImage:document:page:size:"), image.Handle, document.Handle, page, size);
			}
		}
		
		[Export ("emptyThumbnailImageView")]
		[CompilerGenerated]
		public virtual global::UIKit.UIImageView EmptyThumbnailImageView ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("emptyThumbnailImageView")));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("emptyThumbnailImageView")));
			}
		}
		
		[Export ("isSmallToolbar")]
		[CompilerGenerated]
		public virtual bool IsSmallToolbar ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSmallToolbar"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSmallToolbar"));
			}
		}
		
		[Export ("processTouch:")]
		[CompilerGenerated]
		public virtual bool ProcessTouch (global::UIKit.UITouch touch)
		{
			if (touch == null)
				throw new ArgumentNullException ("touch");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("processTouch:"), touch.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("processTouch:"), touch.Handle);
			}
		}
		
		[Export ("scrobbleBarHeight")]
		[CompilerGenerated]
		public virtual global::System.nfloat ScrobbleBarHeight ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("scrobbleBarHeight"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrobbleBarHeight"));
			}
		}
		
		[Export ("scrobbleBarThumbSize")]
		[CompilerGenerated]
		public virtual CGSize ScrobbleBarThumbSize ()
		{
			CGSize ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("scrobbleBarThumbSize"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("scrobbleBarThumbSize"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("scrobbleBarThumbSize"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("scrobbleBarThumbSize"));
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrobbleBarThumbSize"));
					} else {
						global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("scrobbleBarThumbSize"));
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrobbleBarThumbSize"));
				} else {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrobbleBarThumbSize"));
				}
			}
			return ret;
		}
		
		[Export ("updatePageMarker")]
		[CompilerGenerated]
		public virtual void UpdatePageMarker ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updatePageMarker"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updatePageMarker"));
			}
		}
		
		[Export ("updateToolbarAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateToolbar (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateToolbarAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateToolbarAnimated:"), animated);
			}
		}
		
		[Export ("updateToolbarForced")]
		[CompilerGenerated]
		public virtual void UpdateToolbarForced ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateToolbarForced"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateToolbarForced"));
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowTapsOutsidePageArea {
			[Export ("allowTapsOutsidePageArea", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowTapsOutsidePageArea"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowTapsOutsidePageArea"));
				}
			}
			
			[Export ("setAllowTapsOutsidePageArea:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowTapsOutsidePageArea:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowTapsOutsidePageArea:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BarTintColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BarTintColor {
			[Export ("barTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("barTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barTintColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarTintColor_var = ret;
				return ret;
			}
			
			[Export ("setBarTintColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBarTintColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBarTintColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarTintColor_var = value;
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
		public virtual IPSPDFScrobbleBarDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFScrobbleBarDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFScrobbleBarDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFScrobbleBarDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		public virtual global::System.nfloat LeftBorderMargin {
			[Export ("leftBorderMargin", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftBorderMargin"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftBorderMargin"));
				}
			}
			
			[Export ("setLeftBorderMargin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftBorderMargin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftBorderMargin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Page {
			[Export ("page", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("page"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("page"));
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat PageMarkerSizeMultiplier {
			[Export ("pageMarkerSizeMultiplier", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pageMarkerSizeMultiplier"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageMarkerSizeMultiplier"));
				}
			}
			
			[Export ("setPageMarkerSizeMultiplier:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPageMarkerSizeMultiplier:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPageMarkerSizeMultiplier:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat RightBorderMargin {
			[Export ("rightBorderMargin", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightBorderMargin"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightBorderMargin"));
				}
			}
			
			[Export ("setRightBorderMargin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightBorderMargin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightBorderMargin:"), value);
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
		object __mt_ThumbnailBorderColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ThumbnailBorderColor {
			[Export ("thumbnailBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailBorderColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ThumbnailBorderColor_var = ret;
				return ret;
			}
			
			[Export ("setThumbnailBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setThumbnailBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setThumbnailBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ThumbnailBorderColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ThumbnailMargin {
			[Export ("thumbnailMargin", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailMargin"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailMargin"));
				}
			}
			
			[Export ("setThumbnailMargin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setThumbnailMargin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setThumbnailMargin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Toolbar_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIToolbar Toolbar {
			[Export ("toolbar", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIToolbar ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIToolbar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("toolbar")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIToolbar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toolbar")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Toolbar_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Translucent {
			[Export ("isTranslucent", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTranslucent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isTranslucent"));
				}
			}
			
			[Export ("setTranslucent:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTranslucent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTranslucent:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BarTintColor_var = null;
				__mt_DataSource_var = null;
				__mt_Delegate_var = null;
				__mt_ThumbnailBorderColor_var = null;
				__mt_Toolbar_var = null;
			}
		}
		public partial class PSPDFScrobbleBarAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFScrobbleBarAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFScrobbleBarAppearance Appearance {
			get { return new PSPDFScrobbleBarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFScrobbleBarAppearance GetAppearance<T> () where T: PSPDFScrobbleBar {
			return new PSPDFScrobbleBarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFScrobbleBarAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFScrobbleBarAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFScrobbleBarAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFScrobbleBarAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFScrobbleBarAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFScrobbleBarAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFScrobbleBarAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFScrobbleBar {
			return new PSPDFScrobbleBarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFScrobbleBarAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFScrobbleBar{
			return new PSPDFScrobbleBarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFScrobbleBar */
}
