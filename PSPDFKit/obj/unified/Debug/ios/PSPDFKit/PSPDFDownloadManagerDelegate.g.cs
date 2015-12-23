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
	[Protocol (Name = "PSPDFDownloadManagerDelegate", WrapperType = typeof (PSPDFDownloadManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AuthenticationChallenge", Selector = "downloadManager:authenticationChallenge:completionHandler:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDownloadManager), typeof (NSUrlAuthenticationChallenge), typeof (PSPDFKit.PSPDFDownloadManagerDelegateAuthCompletionHandler) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeObject", Selector = "downloadManager:didChangeObject:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDownloadManager), typeof (PSPDFKit.IPSPDFRemoteContentObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReachabilityDidChange", Selector = "downloadManager:reachabilityDidChange:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDownloadManager), typeof (PSPDFKit.PSPDFReachability) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFDownloadManagerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFDownloadManagerDelegate_Extensions {
		[CompilerGenerated]
		public unsafe static void AuthenticationChallenge (this IPSPDFDownloadManagerDelegate This, PSPDFDownloadManager downloadManager, NSUrlAuthenticationChallenge authenticationChallenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFDownloadManagerDelegateAuthCompletionHandler))]PSPDFDownloadManagerDelegateAuthCompletionHandler completionHandler)
		{
			if (downloadManager == null)
				throw new ArgumentNullException ("downloadManager");
			if (authenticationChallenge == null)
				throw new ArgumentNullException ("authenticationChallenge");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlock (Trampolines.SDPSPDFDownloadManagerDelegateAuthCompletionHandler.Handler, completionHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("downloadManager:authenticationChallenge:completionHandler:"), downloadManager.Handle, authenticationChallenge.Handle, (IntPtr) block_ptr_completionHandler);
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public static void DidChangeObject (this IPSPDFDownloadManagerDelegate This, PSPDFDownloadManager downloadManager, IPSPDFRemoteContentObject obj)
		{
			if (downloadManager == null)
				throw new ArgumentNullException ("downloadManager");
			if (obj == null)
				throw new ArgumentNullException ("obj");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("downloadManager:didChangeObject:"), downloadManager.Handle, obj.Handle);
		}
		
		[CompilerGenerated]
		public static void ReachabilityDidChange (this IPSPDFDownloadManagerDelegate This, PSPDFDownloadManager downloadManager, PSPDFReachability reachability)
		{
			if (downloadManager == null)
				throw new ArgumentNullException ("downloadManager");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("downloadManager:reachabilityDidChange:"), downloadManager.Handle, (UInt64)reachability);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("downloadManager:reachabilityDidChange:"), downloadManager.Handle, (UInt32)reachability);
			}
		}
		
	}
	
	internal sealed class PSPDFDownloadManagerDelegateWrapper : BaseWrapper, IPSPDFDownloadManagerDelegate {
		public PSPDFDownloadManagerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFDownloadManagerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFDownloadManagerDelegate", false)]
	[Model]
	public unsafe partial class PSPDFDownloadManagerDelegate : NSObject, IPSPDFDownloadManagerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDownloadManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFDownloadManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDownloadManagerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("downloadManager:authenticationChallenge:completionHandler:")]
		[CompilerGenerated]
		public unsafe virtual void AuthenticationChallenge (PSPDFDownloadManager downloadManager, NSUrlAuthenticationChallenge authenticationChallenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFDownloadManagerDelegateAuthCompletionHandler))]PSPDFDownloadManagerDelegateAuthCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("downloadManager:didChangeObject:")]
		[CompilerGenerated]
		public virtual void DidChangeObject (PSPDFDownloadManager downloadManager, IPSPDFRemoteContentObject obj)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("downloadManager:reachabilityDidChange:")]
		[CompilerGenerated]
		public virtual void ReachabilityDidChange (PSPDFDownloadManager downloadManager, PSPDFReachability reachability)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFDownloadManagerDelegate */
}
