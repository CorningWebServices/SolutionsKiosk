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
	[Protocol (Name = "PSPDFApplication", WrapperType = typeof (PSPDFApplicationWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanOpenUrl", Selector = "canOpenURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenUrl", Selector = "openURL:completionHandler:", ParameterType = new Type [] { typeof (NSUrl), typeof (Action<bool>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNetworkIndicatorManager", Selector = "networkIndicatorManager", ReturnType = typeof (PSPDFKit.IPSPDFNetworkActivityIndicatorManager))]
	public interface IPSPDFApplication : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFApplication_Extensions {
		[CompilerGenerated]
		public static bool CanOpenUrl (this IPSPDFApplication This, NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("canOpenURL:"), url.Handle);
		}
		
		[CompilerGenerated]
		public unsafe static void OpenUrl (this IPSPDFApplication This, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completionHandler)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("openURL:completionHandler:"), url.Handle, (IntPtr) block_ptr_completionHandler);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public static IPSPDFNetworkActivityIndicatorManager GetNetworkIndicatorManager (this IPSPDFApplication This)
		{
			return  Runtime.GetINativeObject<IPSPDFNetworkActivityIndicatorManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("networkIndicatorManager")), false);
		}
		
	}
	
	internal sealed class PSPDFApplicationWrapper : BaseWrapper, IPSPDFApplication {
		public PSPDFApplicationWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFApplicationWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
