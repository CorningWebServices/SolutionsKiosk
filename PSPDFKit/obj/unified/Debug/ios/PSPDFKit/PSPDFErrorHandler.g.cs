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
	[Protocol (Name = "PSPDFErrorHandler", WrapperType = typeof (PSPDFErrorHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleError", Selector = "handleError:title:message:", ParameterType = new Type [] { typeof (NSError), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPSPDFErrorHandler : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("handleError:title:message:")]
		[Preserve (Conditional = true)]
		void HandleError (NSError error, string title, string message);
		
	}
	
	internal sealed class PSPDFErrorHandlerWrapper : BaseWrapper, IPSPDFErrorHandler {
		public PSPDFErrorHandlerWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFErrorHandlerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("handleError:title:message:")]
		[CompilerGenerated]
		public void HandleError (NSError error, string title, string message)
		{
			var nstitle = NSString.CreateNative (title);
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleError:title:message:"), error == null ? IntPtr.Zero : error.Handle, nstitle, nsmessage);
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsmessage);
			
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFErrorHandler", false)]
	[Model]
	public unsafe abstract partial class PSPDFErrorHandler : NSObject, IPSPDFErrorHandler {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFErrorHandler () : base (NSObjectFlag.Empty)
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
		protected PSPDFErrorHandler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFErrorHandler (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("handleError:title:message:")]
		[CompilerGenerated]
		public abstract void HandleError (NSError error, string title, string message);
	} /* class PSPDFErrorHandler */
}
