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
	[Protocol (Name = "PSPDFFreeTextAccessoryViewDelegate", WrapperType = typeof (PSPDFFreeTextAccessoryViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DoneButtonPressed", Selector = "doneButtonPressedOnFreeTextAccessoryView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFreeTextAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClearButtonPressed", Selector = "clearButtonPressedOnFreeTextAccessoryView:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFreeTextAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestInspector", Selector = "freeTextAccessoryViewDidRequestInspector:", ReturnType = typeof (PSPDFKit.PSPDFAnnotationStyleViewController), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFreeTextAccessoryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeProperty", Selector = "freeTextAccessoryView:shouldChangeProperty:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFreeTextAccessoryView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeProperty", Selector = "freeTextAccessoryView:didChangeProperty:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFFreeTextAccessoryView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFFreeTextAccessoryViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFFreeTextAccessoryViewDelegate_Extensions {
		[CompilerGenerated]
		public static void DoneButtonPressed (this IPSPDFFreeTextAccessoryViewDelegate This, PSPDFFreeTextAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("doneButtonPressedOnFreeTextAccessoryView:"), inputView.Handle);
		}
		
		[CompilerGenerated]
		public static void ClearButtonPressed (this IPSPDFFreeTextAccessoryViewDelegate This, PSPDFFreeTextAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("clearButtonPressedOnFreeTextAccessoryView:"), inputView.Handle);
		}
		
		[CompilerGenerated]
		public static PSPDFAnnotationStyleViewController DidRequestInspector (this IPSPDFFreeTextAccessoryViewDelegate This, PSPDFFreeTextAccessoryView inputView)
		{
			if (inputView == null)
				throw new ArgumentNullException ("inputView");
			return  Runtime.GetNSObject<PSPDFAnnotationStyleViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("freeTextAccessoryViewDidRequestInspector:"), inputView.Handle));
		}
		
		[CompilerGenerated]
		public static bool ShouldChangeProperty (this IPSPDFFreeTextAccessoryViewDelegate This, PSPDFFreeTextAccessoryView styleController, string propertyName)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			var nspropertyName = NSString.CreateNative (propertyName);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("freeTextAccessoryView:shouldChangeProperty:"), styleController.Handle, nspropertyName);
			NSString.ReleaseNative (nspropertyName);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void DidChangeProperty (this IPSPDFFreeTextAccessoryViewDelegate This, PSPDFFreeTextAccessoryView styleController, string propertyName)
		{
			if (styleController == null)
				throw new ArgumentNullException ("styleController");
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			var nspropertyName = NSString.CreateNative (propertyName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("freeTextAccessoryView:didChangeProperty:"), styleController.Handle, nspropertyName);
			NSString.ReleaseNative (nspropertyName);
			
		}
		
	}
	
	internal sealed class PSPDFFreeTextAccessoryViewDelegateWrapper : BaseWrapper, IPSPDFFreeTextAccessoryViewDelegate {
		public PSPDFFreeTextAccessoryViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFFreeTextAccessoryViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFFreeTextAccessoryViewDelegate", false)]
	[Model]
	public unsafe partial class PSPDFFreeTextAccessoryViewDelegate : NSObject, IPSPDFFreeTextAccessoryViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFFreeTextAccessoryViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFFreeTextAccessoryViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFreeTextAccessoryViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("clearButtonPressedOnFreeTextAccessoryView:")]
		[CompilerGenerated]
		public virtual void ClearButtonPressed (PSPDFFreeTextAccessoryView inputView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("freeTextAccessoryView:didChangeProperty:")]
		[CompilerGenerated]
		public virtual void DidChangeProperty (PSPDFFreeTextAccessoryView styleController, string propertyName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("freeTextAccessoryViewDidRequestInspector:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationStyleViewController DidRequestInspector (PSPDFFreeTextAccessoryView inputView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("doneButtonPressedOnFreeTextAccessoryView:")]
		[CompilerGenerated]
		public virtual void DoneButtonPressed (PSPDFFreeTextAccessoryView inputView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("freeTextAccessoryView:shouldChangeProperty:")]
		[CompilerGenerated]
		public virtual bool ShouldChangeProperty (PSPDFFreeTextAccessoryView styleController, string propertyName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFFreeTextAccessoryViewDelegate */
}
