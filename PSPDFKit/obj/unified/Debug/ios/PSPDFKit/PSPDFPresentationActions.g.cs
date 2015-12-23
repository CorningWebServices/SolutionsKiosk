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
	[Protocol (Name = "PSPDFPresentationActions", WrapperType = typeof (PSPDFPresentationActionsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentViewController", Selector = "presentViewController:options:animated:sender:error:completion:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (PSPDFKit.IPSPDFPresentableViewController), typeof (NSDictionary), typeof (bool), typeof (NSObject), typeof (NSError), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false, true, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DismissPopover", Selector = "dismissPopoverAnimated:forClass:completion:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool), typeof (Class), typeof (Action) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DismissViewController", Selector = "dismissViewControllerAnimated:forClass:completion:", ParameterType = new Type [] { typeof (bool), typeof (Class), typeof (Action) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetVisibleViewControllerInPopoverController", Selector = "visibleViewControllerInPopoverController", ReturnType = typeof (UIViewController))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowController", Selector = "sender:shouldShowController:embeddedInController:options:animated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSObject), typeof (PSPDFKit.IPSPDFPresentableViewController), typeof (PSPDFKit.IPSPDFHostableViewController), typeof (NSDictionary), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	public interface IPSPDFPresentationActions : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("presentViewController:options:animated:sender:error:completion:")]
		[Preserve (Conditional = true)]
		unsafe NSObject PresentViewController (IPSPDFPresentableViewController controller, NSDictionary options, bool animated, NSObject sender, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		
		[CompilerGenerated]
		[Export ("dismissPopoverAnimated:forClass:completion:")]
		[Preserve (Conditional = true)]
		unsafe bool DismissPopover (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		
		[CompilerGenerated]
		[Export ("dismissViewControllerAnimated:forClass:completion:")]
		[Preserve (Conditional = true)]
		unsafe void DismissViewController (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		
	}
	
	public static partial class PSPDFPresentationActions_Extensions {
		[CompilerGenerated]
		public static global::UIKit.UIViewController GetVisibleViewControllerInPopoverController (this IPSPDFPresentationActions This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("visibleViewControllerInPopoverController")));
		}
		
		[CompilerGenerated]
		public static bool ShouldShowController (this IPSPDFPresentationActions This, NSObject sender, IPSPDFPresentableViewController controller, IPSPDFHostableViewController hostController, NSDictionary options, bool animated)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (controller == null)
				throw new ArgumentNullException ("controller");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool (This.Handle, Selector.GetHandle ("sender:shouldShowController:embeddedInController:options:animated:"), sender.Handle, controller.Handle, hostController == null ? IntPtr.Zero : hostController.Handle, options == null ? IntPtr.Zero : options.Handle, animated);
		}
		
	}
	
	internal sealed class PSPDFPresentationActionsWrapper : BaseWrapper, IPSPDFPresentationActions {
		public PSPDFPresentationActionsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFPresentationActionsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("presentViewController:options:animated:sender:error:completion:")]
		[CompilerGenerated]
		public unsafe NSObject PresentViewController (IPSPDFPresentableViewController controller, NSDictionary options, bool animated, NSObject sender, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			IntPtr errorValue = IntPtr.Zero;
			
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentViewController:options:animated:sender:error:completion:"), controller.Handle, options == null ? IntPtr.Zero : options.Handle, animated, sender == null ? IntPtr.Zero : sender.Handle, ref errorValue, (IntPtr) block_ptr_completion));
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("dismissPopoverAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe bool DismissPopover (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("dismissPopoverAnimated:forClass:completion:"), animated, controllerClass == null ? IntPtr.Zero : controllerClass.Handle, (IntPtr) block_ptr_completion);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("dismissViewControllerAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe void DismissViewController (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("dismissViewControllerAnimated:forClass:completion:"), animated, controllerClass == null ? IntPtr.Zero : controllerClass.Handle, (IntPtr) block_ptr_completion);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFPresentationActions", false)]
	[Model]
	public unsafe abstract partial class PSPDFPresentationActions : NSObject, IPSPDFPresentationActions {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFPresentationActions () : base (NSObjectFlag.Empty)
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
		protected PSPDFPresentationActions (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPresentationActions (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dismissPopoverAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe abstract bool DismissPopover (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		[Export ("dismissViewControllerAnimated:forClass:completion:")]
		[CompilerGenerated]
		public unsafe abstract void DismissViewController (bool animated, Class controllerClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		[Export ("visibleViewControllerInPopoverController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController GetVisibleViewControllerInPopoverController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("presentViewController:options:animated:sender:error:completion:")]
		[CompilerGenerated]
		public unsafe abstract NSObject PresentViewController (IPSPDFPresentableViewController controller, NSDictionary options, bool animated, NSObject sender, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		[Export ("sender:shouldShowController:embeddedInController:options:animated:")]
		[CompilerGenerated]
		public virtual bool ShouldShowController (NSObject sender, IPSPDFPresentableViewController controller, IPSPDFHostableViewController hostController, NSDictionary options, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFPresentationActions */
}
