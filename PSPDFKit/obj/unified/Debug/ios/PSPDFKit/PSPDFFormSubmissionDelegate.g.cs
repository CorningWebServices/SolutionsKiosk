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
	[Protocol (Name = "PSPDFFormSubmissionDelegate", WrapperType = typeof (PSPDFFormSubmissionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSubmitFormRequest", Selector = "formSubmissionController:shouldSubmitFormRequest:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSObject), typeof (PSPDFKit.PSPDFFormRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSubmitFormValues", Selector = "formSubmissionController:willSubmitFormValues:", ParameterType = new Type [] { typeof (NSObject), typeof (PSPDFKit.PSPDFFormRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveResponseData", Selector = "formSubmissionController:didReceiveResponseData:", ParameterType = new Type [] { typeof (NSObject), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "formSubmissionController:didFailWithError:", ParameterType = new Type [] { typeof (NSObject), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FormSubmissionControllerShouldPresentResponseInWebView", Selector = "formSubmissionControllerShouldPresentResponseInWebView:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFFormSubmissionDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFFormSubmissionDelegate_Extensions {
		[CompilerGenerated]
		public static bool ShouldSubmitFormRequest (this IPSPDFFormSubmissionDelegate This, NSObject formSubmissionController, PSPDFFormRequest formRequest)
		{
			if (formSubmissionController == null)
				throw new ArgumentNullException ("formSubmissionController");
			if (formRequest == null)
				throw new ArgumentNullException ("formRequest");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("formSubmissionController:shouldSubmitFormRequest:"), formSubmissionController.Handle, formRequest.Handle);
		}
		
		[CompilerGenerated]
		public static void WillSubmitFormValues (this IPSPDFFormSubmissionDelegate This, NSObject formSubmissionController, PSPDFFormRequest formRequest)
		{
			if (formSubmissionController == null)
				throw new ArgumentNullException ("formSubmissionController");
			if (formRequest == null)
				throw new ArgumentNullException ("formRequest");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("formSubmissionController:willSubmitFormValues:"), formSubmissionController.Handle, formRequest.Handle);
		}
		
		[CompilerGenerated]
		public static void DidReceiveResponseData (this IPSPDFFormSubmissionDelegate This, NSObject formSubmissionController, NSData responseData)
		{
			if (formSubmissionController == null)
				throw new ArgumentNullException ("formSubmissionController");
			if (responseData == null)
				throw new ArgumentNullException ("responseData");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("formSubmissionController:didReceiveResponseData:"), formSubmissionController.Handle, responseData.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFail (this IPSPDFFormSubmissionDelegate This, NSObject formSubmissionController, NSError error)
		{
			if (formSubmissionController == null)
				throw new ArgumentNullException ("formSubmissionController");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("formSubmissionController:didFailWithError:"), formSubmissionController.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static bool FormSubmissionControllerShouldPresentResponseInWebView (this IPSPDFFormSubmissionDelegate This, NSObject formSubmissionController)
		{
			if (formSubmissionController == null)
				throw new ArgumentNullException ("formSubmissionController");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("formSubmissionControllerShouldPresentResponseInWebView:"), formSubmissionController.Handle);
		}
		
	}
	
	internal sealed class PSPDFFormSubmissionDelegateWrapper : BaseWrapper, IPSPDFFormSubmissionDelegate {
		public PSPDFFormSubmissionDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFFormSubmissionDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFFormSubmissionDelegate", false)]
	[Model]
	public unsafe partial class PSPDFFormSubmissionDelegate : NSObject, IPSPDFFormSubmissionDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFormSubmissionDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFFormSubmissionDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFormSubmissionDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("formSubmissionController:didFailWithError:")]
		[CompilerGenerated]
		public virtual void DidFail (NSObject formSubmissionController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("formSubmissionController:didReceiveResponseData:")]
		[CompilerGenerated]
		public virtual void DidReceiveResponseData (NSObject formSubmissionController, NSData responseData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("formSubmissionControllerShouldPresentResponseInWebView:")]
		[CompilerGenerated]
		public virtual bool FormSubmissionControllerShouldPresentResponseInWebView (NSObject formSubmissionController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("formSubmissionController:shouldSubmitFormRequest:")]
		[CompilerGenerated]
		public virtual bool ShouldSubmitFormRequest (NSObject formSubmissionController, PSPDFFormRequest formRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("formSubmissionController:willSubmitFormValues:")]
		[CompilerGenerated]
		public virtual void WillSubmitFormValues (NSObject formSubmissionController, PSPDFFormRequest formRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFFormSubmissionDelegate */
}
