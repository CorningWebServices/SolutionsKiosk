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
	[Protocol (Name = "PSPDFStreamProvider", WrapperType = typeof (PSPDFStreamProviderWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDocumentProvider", Selector = "documentProvider", ReturnType = typeof (PSPDFKit.PSPDFDocumentProvider))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StreamPath", Selector = "streamPath", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FileUrlWithError", Selector = "fileURLWithError:", ReturnType = typeof (NSUrl), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	public interface IPSPDFStreamProvider : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFStreamProvider_Extensions {
		[CompilerGenerated]
		public static PSPDFDocumentProvider GetDocumentProvider (this IPSPDFStreamProvider This)
		{
			return  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("documentProvider")));
		}
		
		[CompilerGenerated]
		public static string StreamPath (this IPSPDFStreamProvider This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("streamPath")));
		}
		
		[CompilerGenerated]
		public static NSUrl FileUrlWithError (this IPSPDFStreamProvider This, out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_ref_IntPtr (This.Handle, Selector.GetHandle ("fileURLWithError:"), ref errorValue));
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
	}
	
	internal sealed class PSPDFStreamProviderWrapper : BaseWrapper, IPSPDFStreamProvider {
		public PSPDFStreamProviderWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFStreamProviderWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFStreamProvider", false)]
	[Model]
	public unsafe partial class PSPDFStreamProvider : NSObject, IPSPDFStreamProvider {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFStreamProvider () : base (NSObjectFlag.Empty)
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
		protected PSPDFStreamProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFStreamProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("fileURLWithError:")]
		[CompilerGenerated]
		public virtual NSUrl FileUrlWithError (out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentProvider")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider GetDocumentProvider ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("streamPath")]
		[CompilerGenerated]
		public virtual string StreamPath ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFStreamProvider */
}
