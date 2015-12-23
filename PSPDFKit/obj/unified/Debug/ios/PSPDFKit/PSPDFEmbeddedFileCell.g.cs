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
	[Register("PSPDFEmbeddedFileCell", true)]
	public unsafe partial class PSPDFEmbeddedFileCell : PSPDFNonAnimatingTableViewCell {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFEmbeddedFileCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFEmbeddedFileCell () : base (NSObjectFlag.Empty)
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
		public PSPDFEmbeddedFileCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFEmbeddedFileCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFEmbeddedFileCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		public partial class PSPDFEmbeddedFileCellAppearance : global::PSPDFKit.PSPDFNonAnimatingTableViewCell.PSPDFNonAnimatingTableViewCellAppearance {
			protected internal PSPDFEmbeddedFileCellAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFEmbeddedFileCellAppearance Appearance {
			get { return new PSPDFEmbeddedFileCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFEmbeddedFileCellAppearance GetAppearance<T> () where T: PSPDFEmbeddedFileCell {
			return new PSPDFEmbeddedFileCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFEmbeddedFileCellAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFEmbeddedFileCellAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFEmbeddedFileCellAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFEmbeddedFileCellAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFEmbeddedFileCellAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFEmbeddedFileCellAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFEmbeddedFileCellAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFEmbeddedFileCell {
			return new PSPDFEmbeddedFileCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFEmbeddedFileCellAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFEmbeddedFileCell{
			return new PSPDFEmbeddedFileCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFEmbeddedFileCell */
}
