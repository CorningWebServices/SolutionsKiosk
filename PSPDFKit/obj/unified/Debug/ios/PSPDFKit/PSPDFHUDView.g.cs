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
	[Register("PSPDFHUDView", true)]
	public unsafe partial class PSPDFHUDView : PSPDFRelayTouchesView, IPSPDFPageLabelViewDelegate, IPSPDFScrobbleBarDelegate, IPSPDFThumbnailBarDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFHUDView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFHUDView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFHUDView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFHUDView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:dataSource:")]
		[CompilerGenerated]
		public PSPDFHUDView (CGRect frame, IPSPDFPresentationContext dataSource)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("initWithFrame:dataSource:"), frame, dataSource == null ? IntPtr.Zero : dataSource.Handle), "initWithFrame:dataSource:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFrame:dataSource:"), frame, dataSource == null ? IntPtr.Zero : dataSource.Handle), "initWithFrame:dataSource:");
			}
		}
		
		[Export ("pageLabelView:didPressThumbnailGridButton:")]
		[CompilerGenerated]
		public virtual void DidPressThumbnailGridButton (PSPDFPageLabelView pageLabelView, global::UIKit.UIButton sender)
		{
			if (pageLabelView == null)
				throw new ArgumentNullException ("pageLabelView");
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("pageLabelView:didPressThumbnailGridButton:"), pageLabelView.Handle, sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("pageLabelView:didPressThumbnailGridButton:"), pageLabelView.Handle, sender.Handle);
			}
		}
		
		[Export ("thumbnailBar:didSelectPage:")]
		[CompilerGenerated]
		public virtual void DidSelectPage (PSPDFThumbnailBar thumbnailBar, global::System.nuint page)
		{
			if (thumbnailBar == null)
				throw new ArgumentNullException ("thumbnailBar");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("thumbnailBar:didSelectPage:"), thumbnailBar.Handle, page);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("thumbnailBar:didSelectPage:"), thumbnailBar.Handle, page);
			}
		}
		
		[Export ("scrobbleBar:didSelectPage:")]
		[CompilerGenerated]
		public virtual void DidSelectPage (PSPDFScrobbleBar scrobbleBar, global::System.nuint page)
		{
			if (scrobbleBar == null)
				throw new ArgumentNullException ("scrobbleBar");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("scrobbleBar:didSelectPage:"), scrobbleBar.Handle, page);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("scrobbleBar:didSelectPage:"), scrobbleBar.Handle, page);
			}
		}
		
		[Export ("layoutSubviewsAnimated:")]
		[CompilerGenerated]
		public virtual void LayoutSubviews (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("layoutSubviewsAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("layoutSubviewsAnimated:"), animated);
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
		
		[Export ("updateDocumentLabelFrameAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateDocumentLabelFrame (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateDocumentLabelFrameAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateDocumentLabelFrameAnimated:"), animated);
			}
		}
		
		[Export ("updatePageLabelFrameAnimated:")]
		[CompilerGenerated]
		public virtual void UpdatePageLabelFrame (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updatePageLabelFrameAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updatePageLabelFrameAnimated:"), animated);
			}
		}
		
		[Export ("updateScrobbleBarFrameAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateScrobbleBarFrame (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateScrobbleBarFrameAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateScrobbleBarFrameAnimated:"), animated);
			}
		}
		
		[Export ("updateThumbnailBarFrameAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateThumbnailBarFrame (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateThumbnailBarFrameAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateThumbnailBarFrameAnimated:"), animated);
			}
		}
		
		[CompilerGenerated]
		object __mt_BackButton_var;
		[CompilerGenerated]
		public virtual PSPDFBackForwardButton BackButton {
			[Export ("backButton", ArgumentSemantic.Retain)]
			get {
				PSPDFBackForwardButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFBackForwardButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFBackForwardButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackButton_var = ret;
				return ret;
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
		object __mt_DocumentLabel_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentLabelView DocumentLabel {
			[Export ("documentLabel", ArgumentSemantic.Retain)]
			get {
				PSPDFDocumentLabelView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocumentLabelView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentLabel")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocumentLabelView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentLabel")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DocumentLabel_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets DocumentLabelInsets {
			[Export ("documentLabelInsets", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("documentLabelInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("documentLabelInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("documentLabelInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("documentLabelInsets"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentLabelInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("documentLabelInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("documentLabelInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("documentLabelInsets"));
					}
				}
				return ret;
			}
			
			[Export ("setDocumentLabelInsets:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setDocumentLabelInsets:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setDocumentLabelInsets:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ForwardButton_var;
		[CompilerGenerated]
		public virtual PSPDFBackForwardButton ForwardButton {
			[Export ("forwardButton", ArgumentSemantic.Retain)]
			get {
				PSPDFBackForwardButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFBackForwardButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("forwardButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFBackForwardButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("forwardButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ForwardButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageLabel_var;
		[CompilerGenerated]
		public virtual PSPDFPageLabelView PageLabel {
			[Export ("pageLabel", ArgumentSemantic.Retain)]
			get {
				PSPDFPageLabelView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFPageLabelView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageLabel")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFPageLabelView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageLabel")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageLabel_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets PageLabelInsets {
			[Export ("pageLabelInsets", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("pageLabelInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("pageLabelInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("pageLabelInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("pageLabelInsets"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageLabelInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("pageLabelInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("pageLabelInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("pageLabelInsets"));
					}
				}
				return ret;
			}
			
			[Export ("setPageLabelInsets:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setPageLabelInsets:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setPageLabelInsets:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ScrobbleBar_var;
		[CompilerGenerated]
		public virtual PSPDFScrobbleBar ScrobbleBar {
			[Export ("scrobbleBar", ArgumentSemantic.Retain)]
			get {
				PSPDFScrobbleBar ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFScrobbleBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrobbleBar")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFScrobbleBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrobbleBar")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ScrobbleBar_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets ScrobbleBarInsets {
			[Export ("scrobbleBarInsets", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("scrobbleBarInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("scrobbleBarInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("scrobbleBarInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("scrobbleBarInsets"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrobbleBarInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("scrobbleBarInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("scrobbleBarInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("scrobbleBarInsets"));
					}
				}
				return ret;
			}
			
			[Export ("setScrobbleBarInsets:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setScrobbleBarInsets:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setScrobbleBarInsets:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ThumbnailBar_var;
		[CompilerGenerated]
		public virtual PSPDFThumbnailBar ThumbnailBar {
			[Export ("thumbnailBar", ArgumentSemantic.Retain)]
			get {
				PSPDFThumbnailBar ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFThumbnailBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailBar")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFThumbnailBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailBar")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ThumbnailBar_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets ThumbnailBarInsets {
			[Export ("thumbnailBarInsets", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailBarInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("thumbnailBarInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("thumbnailBarInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("thumbnailBarInsets"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailBarInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("thumbnailBarInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("thumbnailBarInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("thumbnailBarInsets"));
					}
				}
				return ret;
			}
			
			[Export ("setThumbnailBarInsets:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setThumbnailBarInsets:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setThumbnailBarInsets:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BackButton_var = null;
				__mt_DataSource_var = null;
				__mt_DocumentLabel_var = null;
				__mt_ForwardButton_var = null;
				__mt_PageLabel_var = null;
				__mt_ScrobbleBar_var = null;
				__mt_ThumbnailBar_var = null;
			}
		}
		public partial class PSPDFHUDViewAppearance : global::PSPDFKit.PSPDFRelayTouchesView.PSPDFRelayTouchesViewAppearance {
			protected internal PSPDFHUDViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFHUDViewAppearance Appearance {
			get { return new PSPDFHUDViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFHUDViewAppearance GetAppearance<T> () where T: PSPDFHUDView {
			return new PSPDFHUDViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFHUDViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFHUDViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFHUDViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFHUDViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFHUDViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFHUDViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFHUDViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFHUDView {
			return new PSPDFHUDViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFHUDViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFHUDView{
			return new PSPDFHUDViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFHUDView */
}
