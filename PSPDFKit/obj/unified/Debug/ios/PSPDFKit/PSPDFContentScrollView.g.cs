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
	[Register("PSPDFContentScrollView", true)]
	public unsafe partial class PSPDFContentScrollView : PSPDFScrollView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFContentScrollView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFContentScrollView () : base (NSObjectFlag.Empty)
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
		public PSPDFContentScrollView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFContentScrollView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFContentScrollView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTransitionViewController:")]
		[CompilerGenerated]
		public PSPDFContentScrollView (PSPDFTransitionProtocol viewController)
			: base (NSObjectFlag.Empty)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithTransitionViewController:"), viewController.Handle), "initWithTransitionViewController:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTransitionViewController:"), viewController.Handle), "initWithTransitionViewController:");
			}
		}
		
		[CompilerGenerated]
		object __mt_ContentController_var;
		[CompilerGenerated]
		public virtual PSPDFTransitionProtocol ContentController {
			[Export ("contentController", ArgumentSemantic.Retain)]
			get {
				PSPDFTransitionProtocol ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFTransitionProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentController")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFTransitionProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContentController_var = null;
			}
		}
		public partial class PSPDFContentScrollViewAppearance : global::PSPDFKit.PSPDFScrollView.PSPDFScrollViewAppearance {
			protected internal PSPDFContentScrollViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFContentScrollViewAppearance Appearance {
			get { return new PSPDFContentScrollViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFContentScrollViewAppearance GetAppearance<T> () where T: PSPDFContentScrollView {
			return new PSPDFContentScrollViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFContentScrollViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFContentScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFContentScrollViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFContentScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFContentScrollViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFContentScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFContentScrollViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFContentScrollView {
			return new PSPDFContentScrollViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFContentScrollViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFContentScrollView{
			return new PSPDFContentScrollViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFContentScrollView */
}
