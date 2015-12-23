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
	[Register("PSPDFFormElementView", true)]
	public unsafe partial class PSPDFFormElementView : PSPDFHostingAnnotationView, IPSPDFFormInputAccessoryViewDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFFormElementView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFormElementView () : base (NSObjectFlag.Empty)
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
		public PSPDFFormElementView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFFormElementView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFormElementView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("clearButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public virtual void ClearButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("clearButtonPressedOnFormInputView:"), inputView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("clearButtonPressedOnFormInputView:"), inputView.Handle);
			}
		}
		
		[Export ("doneButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public virtual void DoneButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("doneButtonPressedOnFormInputView:"), inputView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("doneButtonPressedOnFormInputView:"), inputView.Handle);
			}
		}
		
		[Export ("formInputViewShouldEnableClearButton:")]
		[CompilerGenerated]
		public virtual bool FormInputViewShouldEnableClearButton (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("formInputViewShouldEnableClearButton:"), inputView.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("formInputViewShouldEnableClearButton:"), inputView.Handle);
			}
		}
		
		[Export ("formInputViewShouldEnableNextButton:")]
		[CompilerGenerated]
		public virtual bool FormInputViewShouldEnableNextButton (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("formInputViewShouldEnableNextButton:"), inputView.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("formInputViewShouldEnableNextButton:"), inputView.Handle);
			}
		}
		
		[Export ("formInputViewShouldEnablePreviousButton:")]
		[CompilerGenerated]
		public virtual bool FormInputViewShouldEnablePreviousButton (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("formInputViewShouldEnablePreviousButton:"), inputView.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("formInputViewShouldEnablePreviousButton:"), inputView.Handle);
			}
		}
		
		[Export ("nextButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public virtual void NextButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("nextButtonPressedOnFormInputView:"), inputView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("nextButtonPressedOnFormInputView:"), inputView.Handle);
			}
		}
		
		[Export ("previousButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public virtual void PreviousButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("previousButtonPressedOnFormInputView:"), inputView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("previousButtonPressedOnFormInputView:"), inputView.Handle);
			}
		}
		
		public partial class PSPDFFormElementViewAppearance : global::PSPDFKit.PSPDFHostingAnnotationView.PSPDFHostingAnnotationViewAppearance {
			protected internal PSPDFFormElementViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFFormElementViewAppearance Appearance {
			get { return new PSPDFFormElementViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFFormElementViewAppearance GetAppearance<T> () where T: PSPDFFormElementView {
			return new PSPDFFormElementViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFFormElementViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFFormElementViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFFormElementViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFFormElementViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFFormElementViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFFormElementViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFFormElementViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFFormElementView {
			return new PSPDFFormElementViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFFormElementViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFFormElementView{
			return new PSPDFFormElementViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFFormElementView */
}
