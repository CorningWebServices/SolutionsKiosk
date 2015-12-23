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
	[Register("PSPDFMultimediaAnnotationView", true)]
	public unsafe partial class PSPDFMultimediaAnnotationView : PSPDFLinkAnnotationBaseView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFMultimediaAnnotationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFMultimediaAnnotationView () : base (NSObjectFlag.Empty)
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
		public PSPDFMultimediaAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFMultimediaAnnotationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFMultimediaAnnotationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_MultimediaViewController_var;
		[CompilerGenerated]
		public virtual IPSPDFMultimediaViewController MultimediaViewController {
			[Export ("multimediaViewController", ArgumentSemantic.Retain)]
			get {
				IPSPDFMultimediaViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFMultimediaViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("multimediaViewController")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFMultimediaViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("multimediaViewController")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_MultimediaViewController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_MultimediaViewController_var = null;
			}
		}
		public partial class PSPDFMultimediaAnnotationViewAppearance : global::PSPDFKit.PSPDFLinkAnnotationBaseView.PSPDFLinkAnnotationBaseViewAppearance {
			protected internal PSPDFMultimediaAnnotationViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFMultimediaAnnotationViewAppearance Appearance {
			get { return new PSPDFMultimediaAnnotationViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFMultimediaAnnotationViewAppearance GetAppearance<T> () where T: PSPDFMultimediaAnnotationView {
			return new PSPDFMultimediaAnnotationViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFMultimediaAnnotationViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFMultimediaAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFMultimediaAnnotationViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFMultimediaAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFMultimediaAnnotationViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFMultimediaAnnotationViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFMultimediaAnnotationViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFMultimediaAnnotationView {
			return new PSPDFMultimediaAnnotationViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFMultimediaAnnotationViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFMultimediaAnnotationView{
			return new PSPDFMultimediaAnnotationViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFMultimediaAnnotationView */
}
