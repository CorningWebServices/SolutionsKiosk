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
	[Protocol (Name = "PSPDFWebViewControllerDelegate", WrapperType = typeof (PSPDFWebViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartLoad", Selector = "webViewControllerDidStartLoad:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFWebViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishLoad", Selector = "webViewControllerDidFinishLoad:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFWebViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailLoad", Selector = "webViewController:didFailLoadWithError:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFWebViewController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFWebViewControllerDelegate : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFExternalURLHandler
		
	{
	}
	
	public static partial class PSPDFWebViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidStartLoad (this IPSPDFWebViewControllerDelegate This, PSPDFWebViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("webViewControllerDidStartLoad:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFinishLoad (this IPSPDFWebViewControllerDelegate This, PSPDFWebViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("webViewControllerDidFinishLoad:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFailLoad (this IPSPDFWebViewControllerDelegate This, PSPDFWebViewController controller, NSError error)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("webViewController:didFailLoadWithError:"), controller.Handle, error.Handle);
		}
		
	}
	
	internal sealed class PSPDFWebViewControllerDelegateWrapper : BaseWrapper, IPSPDFWebViewControllerDelegate {
		public PSPDFWebViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFWebViewControllerDelegateWrapper (IntPtr handle, bool owns)
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
