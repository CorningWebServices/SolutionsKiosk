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
	[Protocol (Name = "PSPDFStyleable", WrapperType = typeof (PSPDFStyleableWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetBarStyle", Selector = "barStyle", ReturnType = typeof (UIBarStyle))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetBarStyle", Selector = "setBarStyle:", ParameterType = new Type [] { typeof (UIBarStyle) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsBarTranslucent", Selector = "isBarTranslucent", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetIsBarTranslucent", Selector = "setIsBarTranslucent:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsInPopover", Selector = "isInPopover", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsInPopover", Selector = "setIsInPopover:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetParentPopoverController", Selector = "parentPopoverController", ReturnType = typeof (UIPopoverController))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetParentPopoverController", Selector = "setParentPopoverController:", ParameterType = new Type [] { typeof (UIPopoverController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPrefersStatusBarHidden", Selector = "prefersStatusBarHidden", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPrefersStatusBarHidden", Selector = "setPrefersStatusBarHidden:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFStyleable : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFStyleable_Extensions {
		[CompilerGenerated]
		public static global::UIKit.UIBarStyle GetBarStyle (this IPSPDFStyleable This)
		{
			global::UIKit.UIBarStyle ret;
			if (IntPtr.Size == 8) {
				ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("barStyle"));
			} else {
				ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("barStyle"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static void SetBarStyle (this IPSPDFStyleable This, global::UIKit.UIBarStyle style)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setBarStyle:"), (Int64)style);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setBarStyle:"), (int)style);
			}
		}
		
		[CompilerGenerated]
		public static bool IsBarTranslucent (this IPSPDFStyleable This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isBarTranslucent"));
		}
		
		[CompilerGenerated]
		public static void SetIsBarTranslucent (this IPSPDFStyleable This, bool isBarTranslucent)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setIsBarTranslucent:"), isBarTranslucent);
		}
		
		[CompilerGenerated]
		public static bool IsInPopover (this IPSPDFStyleable This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isInPopover"));
		}
		
		[CompilerGenerated]
		public static void IsInPopover (this IPSPDFStyleable This, bool isInPopover)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setIsInPopover:"), isInPopover);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIPopoverController GetParentPopoverController (this IPSPDFStyleable This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIPopoverController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("parentPopoverController")));
		}
		
		[CompilerGenerated]
		public static void SetParentPopoverController (this IPSPDFStyleable This, global::UIKit.UIPopoverController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setParentPopoverController:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static bool GetPrefersStatusBarHidden (this IPSPDFStyleable This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("prefersStatusBarHidden"));
		}
		
		[CompilerGenerated]
		public static void SetPrefersStatusBarHidden (this IPSPDFStyleable This, bool val)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setPrefersStatusBarHidden:"), val);
		}
		
	}
	
	internal sealed class PSPDFStyleableWrapper : BaseWrapper, IPSPDFStyleable {
		public PSPDFStyleableWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFStyleableWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFStyleable", false)]
	[Model]
	public unsafe partial class PSPDFStyleable : NSObject, IPSPDFStyleable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFStyleable () : base (NSObjectFlag.Empty)
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
		protected PSPDFStyleable (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStyleable (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("barStyle")]
		[CompilerGenerated]
		public virtual global::UIKit.UIBarStyle GetBarStyle ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("parentPopoverController")]
		[CompilerGenerated]
		public virtual global::UIKit.UIPopoverController GetParentPopoverController ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("prefersStatusBarHidden")]
		[CompilerGenerated]
		public virtual bool GetPrefersStatusBarHidden ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isBarTranslucent")]
		[CompilerGenerated]
		public virtual bool IsBarTranslucent ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isInPopover")]
		[CompilerGenerated]
		public virtual bool IsInPopover ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setIsInPopover:")]
		[CompilerGenerated]
		public virtual void IsInPopover (bool isInPopover)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setBarStyle:")]
		[CompilerGenerated]
		public virtual void SetBarStyle (global::UIKit.UIBarStyle style)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setIsBarTranslucent:")]
		[CompilerGenerated]
		public virtual void SetIsBarTranslucent (bool isBarTranslucent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setParentPopoverController:")]
		[CompilerGenerated]
		public virtual void SetParentPopoverController (global::UIKit.UIPopoverController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setPrefersStatusBarHidden:")]
		[CompilerGenerated]
		public virtual void SetPrefersStatusBarHidden (bool val)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFStyleable */
}
