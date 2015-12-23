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
	[Register("PSPDFThumbnailBar", true)]
	public unsafe partial class PSPDFThumbnailBar : global::UIKit.UICollectionView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFThumbnailBar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFThumbnailBar () : base (NSObjectFlag.Empty)
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
		public PSPDFThumbnailBar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFThumbnailBar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFThumbnailBar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("reloadDataAndKeepSelection")]
		[CompilerGenerated]
		public virtual void ReloadDataAndKeepSelection ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadDataAndKeepSelection"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reloadDataAndKeepSelection"));
			}
		}
		
		[Export ("scrollToPage:animated:")]
		[CompilerGenerated]
		public virtual void ScrollToPage (global::System.nuint page, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("scrollToPage:animated:"), page, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("scrollToPage:animated:"), page, animated);
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
		
		[CompilerGenerated]
		public virtual bool ShowPageLabels {
			[Export ("showPageLabels", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showPageLabels"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showPageLabels"));
				}
			}
			
			[Export ("setShowPageLabels:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowPageLabels:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowPageLabels:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ThumbnailBarDataSource_var;
		[CompilerGenerated]
		public virtual IPSPDFPresentationContext ThumbnailBarDataSource {
			[Export ("thumbnailBarDataSource", ArgumentSemantic.Weak)]
			get {
				IPSPDFPresentationContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailBarDataSource")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailBarDataSource")), false);
				}
				MarkDirty ();
				__mt_ThumbnailBarDataSource_var = ret;
				return ret;
			}
			
			[Export ("setThumbnailBarDataSource:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setThumbnailBarDataSource:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setThumbnailBarDataSource:"), value.Handle);
				}
				MarkDirty ();
				__mt_ThumbnailBarDataSource_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ThumbnailBarDelegate_var;
		[CompilerGenerated]
		public virtual IPSPDFThumbnailBarDelegate ThumbnailBarDelegate {
			[Export ("thumbnailBarDelegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFThumbnailBarDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFThumbnailBarDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailBarDelegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFThumbnailBarDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailBarDelegate")), false);
				}
				MarkDirty ();
				__mt_ThumbnailBarDelegate_var = ret;
				return ret;
			}
			
			[Export ("setThumbnailBarDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setThumbnailBarDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setThumbnailBarDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_ThumbnailBarDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ThumbnailBarHeight {
			[Export ("thumbnailBarHeight", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailBarHeight"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailBarHeight"));
				}
			}
			
			[Export ("setThumbnailBarHeight:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setThumbnailBarHeight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setThumbnailBarHeight:"), value);
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ThumbnailBarDataSource_var = null;
				__mt_ThumbnailBarDelegate_var = null;
			}
		}
		public partial class PSPDFThumbnailBarAppearance : global::UIKit.UICollectionView.UICollectionViewAppearance {
			protected internal PSPDFThumbnailBarAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFThumbnailBarAppearance Appearance {
			get { return new PSPDFThumbnailBarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFThumbnailBarAppearance GetAppearance<T> () where T: PSPDFThumbnailBar {
			return new PSPDFThumbnailBarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFThumbnailBarAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFThumbnailBarAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFThumbnailBarAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFThumbnailBarAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFThumbnailBarAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFThumbnailBarAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFThumbnailBarAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFThumbnailBar {
			return new PSPDFThumbnailBarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFThumbnailBarAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFThumbnailBar{
			return new PSPDFThumbnailBarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFThumbnailBar */
}
