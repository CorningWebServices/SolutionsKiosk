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
	[Register("PSPDFSearchStatusCell", true)]
	public unsafe partial class PSPDFSearchStatusCell : PSPDFSpinnerCell {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSearchStatusCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSearchStatusCell () : base (NSObjectFlag.Empty)
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
		public PSPDFSearchStatusCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFSearchStatusCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSearchStatusCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("updateCellWithSearchStatus:results:page:pageCount:")]
		[CompilerGenerated]
		public virtual void UpdateCell (PSPDFSearchStatus searchStatus, global::System.nuint results, global::System.nuint page, global::System.nuint pageCount)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Int64_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("updateCellWithSearchStatus:results:page:pageCount:"), (Int64)searchStatus, results, page, pageCount);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_int_nuint_nuint_nuint (this.Handle, Selector.GetHandle ("updateCellWithSearchStatus:results:page:pageCount:"), (int)searchStatus, results, page, pageCount);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("updateCellWithSearchStatus:results:page:pageCount:"), (Int64)searchStatus, results, page, pageCount);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_nuint_nuint_nuint (this.SuperHandle, Selector.GetHandle ("updateCellWithSearchStatus:results:page:pageCount:"), (int)searchStatus, results, page, pageCount);
				}
			}
		}
		
		[CompilerGenerated]
		public static global::System.nfloat CellHeight {
			[Export ("cellHeight")]
			get {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (class_ptr, Selector.GetHandle ("cellHeight"));
			}
			
		}
		
		public partial class PSPDFSearchStatusCellAppearance : global::PSPDFKit.PSPDFSpinnerCell.PSPDFSpinnerCellAppearance {
			protected internal PSPDFSearchStatusCellAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFSearchStatusCellAppearance Appearance {
			get { return new PSPDFSearchStatusCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFSearchStatusCellAppearance GetAppearance<T> () where T: PSPDFSearchStatusCell {
			return new PSPDFSearchStatusCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFSearchStatusCellAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFSearchStatusCellAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFSearchStatusCellAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFSearchStatusCellAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFSearchStatusCellAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFSearchStatusCellAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFSearchStatusCellAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFSearchStatusCell {
			return new PSPDFSearchStatusCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFSearchStatusCellAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFSearchStatusCell{
			return new PSPDFSearchStatusCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFSearchStatusCell */
}
