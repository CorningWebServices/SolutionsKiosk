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
	[Register("PSPDFDocumentPickerIndexStatusCell", true)]
	public unsafe partial class PSPDFDocumentPickerIndexStatusCell : PSPDFSpinnerCell {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocumentPickerIndexStatusCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocumentPickerIndexStatusCell () : base (NSObjectFlag.Empty)
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
		public PSPDFDocumentPickerIndexStatusCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentPickerIndexStatusCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentPickerIndexStatusCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		public partial class PSPDFDocumentPickerIndexStatusCellAppearance : global::PSPDFKit.PSPDFSpinnerCell.PSPDFSpinnerCellAppearance {
			protected internal PSPDFDocumentPickerIndexStatusCellAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFDocumentPickerIndexStatusCellAppearance Appearance {
			get { return new PSPDFDocumentPickerIndexStatusCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFDocumentPickerIndexStatusCellAppearance GetAppearance<T> () where T: PSPDFDocumentPickerIndexStatusCell {
			return new PSPDFDocumentPickerIndexStatusCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFDocumentPickerIndexStatusCellAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFDocumentPickerIndexStatusCellAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFDocumentPickerIndexStatusCellAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFDocumentPickerIndexStatusCellAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFDocumentPickerIndexStatusCellAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFDocumentPickerIndexStatusCellAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFDocumentPickerIndexStatusCellAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFDocumentPickerIndexStatusCell {
			return new PSPDFDocumentPickerIndexStatusCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFDocumentPickerIndexStatusCellAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFDocumentPickerIndexStatusCell{
			return new PSPDFDocumentPickerIndexStatusCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFDocumentPickerIndexStatusCell */
}
