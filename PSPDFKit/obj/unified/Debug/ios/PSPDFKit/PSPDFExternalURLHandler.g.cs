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
	[Protocol (Name = "PSPDFExternalURLHandler", WrapperType = typeof (PSPDFExternalURLHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleExternalUrl", Selector = "handleExternalURL:completionBlock:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (Action<bool>) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFExternalURLHandler : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("handleExternalURL:completionBlock:")]
		[Preserve (Conditional = true)]
		unsafe bool HandleExternalUrl (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler);
		
	}
	
	internal sealed class PSPDFExternalURLHandlerWrapper : BaseWrapper, IPSPDFExternalURLHandler {
		public PSPDFExternalURLHandlerWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFExternalURLHandlerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("handleExternalURL:completionBlock:")]
		[CompilerGenerated]
		public unsafe bool HandleExternalUrl (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity1V1.Handler, completionHandler);
			}
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleExternalURL:completionBlock:"), url.Handle, (IntPtr) block_ptr_completionHandler);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
			return ret;
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFExternalURLHandler", false)]
	[Model]
	public unsafe abstract partial class PSPDFExternalURLHandler : NSObject, IPSPDFExternalURLHandler {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFExternalURLHandler () : base (NSObjectFlag.Empty)
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
		protected PSPDFExternalURLHandler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFExternalURLHandler (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("handleExternalURL:completionBlock:")]
		[CompilerGenerated]
		public unsafe abstract bool HandleExternalUrl (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler);
	} /* class PSPDFExternalURLHandler */
}
