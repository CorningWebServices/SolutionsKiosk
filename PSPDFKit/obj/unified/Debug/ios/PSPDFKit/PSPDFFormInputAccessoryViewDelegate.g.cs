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
	[Protocol (Name = "PSPDFFormInputAccessoryViewDelegate", WrapperType = typeof (PSPDFFormInputAccessoryViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DoneButtonPressedOnFormInputView", Selector = "doneButtonPressedOnFormInputView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFormInputAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PreviousButtonPressedOnFormInputView", Selector = "previousButtonPressedOnFormInputView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFormInputAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NextButtonPressedOnFormInputView", Selector = "nextButtonPressedOnFormInputView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFormInputAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ClearButtonPressedOnFormInputView", Selector = "clearButtonPressedOnFormInputView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFormInputAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FormInputViewShouldEnablePreviousButton", Selector = "formInputViewShouldEnablePreviousButton:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFormInputAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FormInputViewShouldEnableNextButton", Selector = "formInputViewShouldEnableNextButton:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFormInputAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FormInputViewShouldEnableClearButton", Selector = "formInputViewShouldEnableClearButton:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFormInputAccessoryView) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFFormInputAccessoryViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("doneButtonPressedOnFormInputView:")]
		[Preserve (Conditional = true)]
		void DoneButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView);
		
		[CompilerGenerated]
		[Export ("previousButtonPressedOnFormInputView:")]
		[Preserve (Conditional = true)]
		void PreviousButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView);
		
		[CompilerGenerated]
		[Export ("nextButtonPressedOnFormInputView:")]
		[Preserve (Conditional = true)]
		void NextButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView);
		
		[CompilerGenerated]
		[Export ("clearButtonPressedOnFormInputView:")]
		[Preserve (Conditional = true)]
		void ClearButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView);
		
		[CompilerGenerated]
		[Export ("formInputViewShouldEnablePreviousButton:")]
		[Preserve (Conditional = true)]
		bool FormInputViewShouldEnablePreviousButton (PSPDFFormInputAccessoryView inputView);
		
		[CompilerGenerated]
		[Export ("formInputViewShouldEnableNextButton:")]
		[Preserve (Conditional = true)]
		bool FormInputViewShouldEnableNextButton (PSPDFFormInputAccessoryView inputView);
		
		[CompilerGenerated]
		[Export ("formInputViewShouldEnableClearButton:")]
		[Preserve (Conditional = true)]
		bool FormInputViewShouldEnableClearButton (PSPDFFormInputAccessoryView inputView);
		
	}
	
	internal sealed class PSPDFFormInputAccessoryViewDelegateWrapper : BaseWrapper, IPSPDFFormInputAccessoryViewDelegate {
		public PSPDFFormInputAccessoryViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFFormInputAccessoryViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("doneButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public void DoneButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("doneButtonPressedOnFormInputView:"), inputView.Handle);
		}
		
		[Export ("previousButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public void PreviousButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("previousButtonPressedOnFormInputView:"), inputView.Handle);
		}
		
		[Export ("nextButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public void NextButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("nextButtonPressedOnFormInputView:"), inputView.Handle);
		}
		
		[Export ("clearButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public void ClearButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("clearButtonPressedOnFormInputView:"), inputView.Handle);
		}
		
		[Export ("formInputViewShouldEnablePreviousButton:")]
		[CompilerGenerated]
		public bool FormInputViewShouldEnablePreviousButton (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("formInputViewShouldEnablePreviousButton:"), inputView.Handle);
		}
		
		[Export ("formInputViewShouldEnableNextButton:")]
		[CompilerGenerated]
		public bool FormInputViewShouldEnableNextButton (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("formInputViewShouldEnableNextButton:"), inputView.Handle);
		}
		
		[Export ("formInputViewShouldEnableClearButton:")]
		[CompilerGenerated]
		public bool FormInputViewShouldEnableClearButton (PSPDFFormInputAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("formInputViewShouldEnableClearButton:"), inputView.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFFormInputAccessoryViewDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFFormInputAccessoryViewDelegate : NSObject, IPSPDFFormInputAccessoryViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFFormInputAccessoryViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFFormInputAccessoryViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFormInputAccessoryViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("clearButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public abstract void ClearButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView);
		[Export ("doneButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public abstract void DoneButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView);
		[Export ("formInputViewShouldEnableClearButton:")]
		[CompilerGenerated]
		public abstract bool FormInputViewShouldEnableClearButton (PSPDFFormInputAccessoryView inputView);
		[Export ("formInputViewShouldEnableNextButton:")]
		[CompilerGenerated]
		public abstract bool FormInputViewShouldEnableNextButton (PSPDFFormInputAccessoryView inputView);
		[Export ("formInputViewShouldEnablePreviousButton:")]
		[CompilerGenerated]
		public abstract bool FormInputViewShouldEnablePreviousButton (PSPDFFormInputAccessoryView inputView);
		[Export ("nextButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public abstract void NextButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView);
		[Export ("previousButtonPressedOnFormInputView:")]
		[CompilerGenerated]
		public abstract void PreviousButtonPressedOnFormInputView (PSPDFFormInputAccessoryView inputView);
	} /* class PSPDFFormInputAccessoryViewDelegate */
}
