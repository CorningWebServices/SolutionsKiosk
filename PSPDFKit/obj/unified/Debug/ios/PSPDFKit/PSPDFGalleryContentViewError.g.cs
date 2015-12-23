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
	[Protocol (Name = "PSPDFGalleryContentViewError", WrapperType = typeof (PSPDFGalleryContentViewErrorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetError", Selector = "setError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Error", Selector = "error", ReturnType = typeof (NSError))]
	public interface IPSPDFGalleryContentViewError : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setError:")]
		[Preserve (Conditional = true)]
		void SetError (NSError error);
		
		[CompilerGenerated]
		[Export ("error")]
		[Preserve (Conditional = true)]
		NSError Error ();
		
	}
	
	internal sealed class PSPDFGalleryContentViewErrorWrapper : BaseWrapper, IPSPDFGalleryContentViewError {
		public PSPDFGalleryContentViewErrorWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFGalleryContentViewErrorWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setError:")]
		[CompilerGenerated]
		public void SetError (NSError error)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setError:"), error == null ? IntPtr.Zero : error.Handle);
		}
		
		[Export ("error")]
		[CompilerGenerated]
		public NSError Error ()
		{
			return  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("error")));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFGalleryContentViewError", false)]
	[Model]
	public unsafe abstract partial class PSPDFGalleryContentViewError : NSObject, IPSPDFGalleryContentViewError {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFGalleryContentViewError () : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryContentViewError (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryContentViewError (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("error")]
		[CompilerGenerated]
		public abstract NSError Error ();
		[Export ("setError:")]
		[CompilerGenerated]
		public abstract void SetError (NSError error);
	} /* class PSPDFGalleryContentViewError */
}
