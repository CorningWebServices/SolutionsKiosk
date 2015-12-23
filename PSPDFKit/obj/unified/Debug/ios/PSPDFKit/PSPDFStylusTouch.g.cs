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
	[Protocol (Name = "PSPDFStylusTouch", WrapperType = typeof (PSPDFStylusTouchWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocationInView", Selector = "locationInView:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Classification", Selector = "classification", ReturnType = typeof (PSPDFKit.PSPDFStylusTouchClassification))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Pressure", Selector = "pressure", ReturnType = typeof (nfloat))]
	public interface IPSPDFStylusTouch : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFStylusTouch_Extensions {
		[CompilerGenerated]
		public static CGPoint LocationInView (this IPSPDFStylusTouch This, global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			CGPoint ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("locationInView:"), view.Handle);
				} else {
					global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret_IntPtr (out ret, This.Handle, Selector.GetHandle ("locationInView:"), view.Handle);
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("locationInView:"), view.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("locationInView:"), view.Handle);
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static PSPDFStylusTouchClassification Classification (this IPSPDFStylusTouch This)
		{
			PSPDFStylusTouchClassification ret;
			if (IntPtr.Size == 8) {
				ret = (PSPDFStylusTouchClassification) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("classification"));
			} else {
				ret = (PSPDFStylusTouchClassification) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("classification"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static global::System.nfloat Pressure (this IPSPDFStylusTouch This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("pressure"));
		}
		
	}
	
	internal sealed class PSPDFStylusTouchWrapper : BaseWrapper, IPSPDFStylusTouch {
		public PSPDFStylusTouchWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFStylusTouchWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFStylusTouch", false)]
	[Model]
	public unsafe partial class PSPDFStylusTouch : NSObject, IPSPDFStylusTouch {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFStylusTouch () : base (NSObjectFlag.Empty)
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
		protected PSPDFStylusTouch (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStylusTouch (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classification")]
		[CompilerGenerated]
		public virtual PSPDFStylusTouchClassification Classification ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("locationInView:")]
		[CompilerGenerated]
		public virtual CGPoint LocationInView (global::UIKit.UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pressure")]
		[CompilerGenerated]
		public virtual global::System.nfloat Pressure ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFStylusTouch */
}
