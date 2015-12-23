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
	[Register("PSPDFThumbnailFlowLayout", true)]
	public unsafe partial class PSPDFThumbnailFlowLayout : global::UIKit.UICollectionViewFlowLayout {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFThumbnailFlowLayout");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFThumbnailFlowLayout () : base (NSObjectFlag.Empty)
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
		public PSPDFThumbnailFlowLayout (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFThumbnailFlowLayout (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFThumbnailFlowLayout (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("indexPathForDoublePage:")]
		[CompilerGenerated]
		public virtual NSIndexPath IndexPathForDoublePage (NSIndexPath indexPath)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSIndexPath> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("indexPathForDoublePage:"), indexPath.Handle));
			} else {
				return  Runtime.GetNSObject<NSIndexPath> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("indexPathForDoublePage:"), indexPath.Handle));
			}
		}
		
		[Export ("typeForIndexPath:usingDoublePageMode:")]
		[CompilerGenerated]
		public virtual PSPDFThumbnailFlowLayoutAttributesType TypeForIndexPath (NSIndexPath indexPath, bool usingDoublePageMode)
		{
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			PSPDFThumbnailFlowLayoutAttributesType ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (PSPDFThumbnailFlowLayoutAttributesType) global::ApiDefinition.Messaging.Int64_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("typeForIndexPath:usingDoublePageMode:"), indexPath.Handle, usingDoublePageMode);
				} else {
					ret = (PSPDFThumbnailFlowLayoutAttributesType) global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("typeForIndexPath:usingDoublePageMode:"), indexPath.Handle, usingDoublePageMode);
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (PSPDFThumbnailFlowLayoutAttributesType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("typeForIndexPath:usingDoublePageMode:"), indexPath.Handle, usingDoublePageMode);
				} else {
					ret = (PSPDFThumbnailFlowLayoutAttributesType) global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("typeForIndexPath:usingDoublePageMode:"), indexPath.Handle, usingDoublePageMode);
				}
			}
			return ret;
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageMode {
			[Export ("doublePageMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("doublePageMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("doublePageMode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageModeDisabled {
			[Export ("doublePageModeDisabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("doublePageModeDisabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("doublePageModeDisabled"));
				}
			}
			
			[Export ("setDoublePageModeDisabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDoublePageModeDisabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDoublePageModeDisabled:"), value);
				}
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
		public new virtual global::UIKit.UICollectionViewScrollDirection ScrollDirection {
			[Export ("scrollDirection", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UICollectionViewScrollDirection ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UICollectionViewScrollDirection) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("scrollDirection"));
					} else {
						ret = (global::UIKit.UICollectionViewScrollDirection) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("scrollDirection"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UICollectionViewScrollDirection) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollDirection"));
					} else {
						ret = (global::UIKit.UICollectionViewScrollDirection) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollDirection"));
					}
				}
				return ret;
			}
			
			[Export ("setScrollDirection:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setScrollDirection:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setScrollDirection:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setScrollDirection:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setScrollDirection:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool StickyHeaderEnabled {
			[Export ("stickyHeaderEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("stickyHeaderEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stickyHeaderEnabled"));
				}
			}
			
			[Export ("setStickyHeaderEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setStickyHeaderEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setStickyHeaderEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PresentationContext_var = null;
			}
		}
	} /* class PSPDFThumbnailFlowLayout */
}
