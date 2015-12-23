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
	[Register("PSPDFAnnotationSetsCell", true)]
	public unsafe partial class PSPDFAnnotationSetsCell : global::UIKit.UITableViewCell, global::UIKit.IUICollectionViewDataSource, global::UIKit.IUICollectionViewDelegate, global::UIKit.IUIScrollViewDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationSetsCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationSetsCell () : base (NSObjectFlag.Empty)
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
		public PSPDFAnnotationSetsCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationSetsCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationSetsCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("collectionView:cellForItemAtIndexPath:")]
		[Introduced (PlatformName.iOS, 6,0)]
		[CompilerGenerated]
		public virtual UICollectionViewCell GetCell (global::UIKit.UICollectionView collectionView, NSIndexPath indexPath)
		{
			if (collectionView == null)
				throw new ArgumentNullException ("collectionView");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<UICollectionViewCell> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("collectionView:cellForItemAtIndexPath:"), collectionView.Handle, indexPath.Handle));
			} else {
				return  Runtime.GetNSObject<UICollectionViewCell> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("collectionView:cellForItemAtIndexPath:"), collectionView.Handle, indexPath.Handle));
			}
		}
		
		[Export ("collectionView:numberOfItemsInSection:")]
		[Introduced (PlatformName.iOS, 6,0)]
		[CompilerGenerated]
		public virtual global::System.nint GetItemsCount (global::UIKit.UICollectionView collectionView, global::System.nint section)
		{
			if (collectionView == null)
				throw new ArgumentNullException ("collectionView");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView.Handle, section);
			} else {
				return global::ApiDefinition.Messaging.nint_objc_msgSendSuper_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView.Handle, section);
			}
		}
		
		[CompilerGenerated]
		object __mt_Annotations_var;
		[CompilerGenerated]
		public virtual NSObject[] Annotations {
			[Export ("annotations", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotations")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Annotations_var = ret;
				return ret;
			}
			
			[Export ("setAnnotations:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotations:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotations:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Annotations_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Border {
			[Export ("border", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("border"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("border"));
				}
			}
			
			[Export ("setBorder:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setBorder:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setBorder:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CollectionView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UICollectionView CollectionView {
			[Export ("collectionView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UICollectionView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UICollectionView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("collectionView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UICollectionView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("collectionView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CollectionView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public unsafe virtual global::System.Action<PSPDFAnnotationSetsCell> CollectionViewUpdateHandler {
			[Export ("collectionViewUpdateBlock", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("collectionViewUpdateBlock"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("collectionViewUpdateBlock"));
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity1V8.Create (ret);
			}
			
			[Export ("setCollectionViewUpdateBlock:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDActionArity1V8.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCollectionViewUpdateBlock:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCollectionViewUpdateBlock:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotations_var = null;
				__mt_CollectionView_var = null;
			}
		}
		public partial class PSPDFAnnotationSetsCellAppearance : global::UIKit.UITableViewCell.UITableViewCellAppearance {
			protected internal PSPDFAnnotationSetsCellAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFAnnotationSetsCellAppearance Appearance {
			get { return new PSPDFAnnotationSetsCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFAnnotationSetsCellAppearance GetAppearance<T> () where T: PSPDFAnnotationSetsCell {
			return new PSPDFAnnotationSetsCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFAnnotationSetsCellAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFAnnotationSetsCellAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFAnnotationSetsCellAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFAnnotationSetsCellAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFAnnotationSetsCellAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFAnnotationSetsCellAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFAnnotationSetsCellAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFAnnotationSetsCell {
			return new PSPDFAnnotationSetsCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFAnnotationSetsCellAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFAnnotationSetsCell{
			return new PSPDFAnnotationSetsCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFAnnotationSetsCell */
}
