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
	[Protocol (Name = "PSPDFDocumentProviderDelegate", WrapperType = typeof (PSPDFDocumentProviderDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAppendData", Selector = "documentProvider:shouldAppendData:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentProvider), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAppendData", Selector = "documentProvider:didAppendData:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentProvider), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFDocumentProviderDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFDocumentProviderDelegate_Extensions {
		[CompilerGenerated]
		public static bool ShouldAppendData (this IPSPDFDocumentProviderDelegate This, PSPDFDocumentProvider documentProvider, NSData data)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (data == null)
				throw new ArgumentNullException ("data");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("documentProvider:shouldAppendData:"), documentProvider.Handle, data.Handle);
		}
		
		[CompilerGenerated]
		public static void DidAppendData (this IPSPDFDocumentProviderDelegate This, PSPDFDocumentProvider documentProvider, NSData data)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (data == null)
				throw new ArgumentNullException ("data");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("documentProvider:didAppendData:"), documentProvider.Handle, data.Handle);
		}
		
	}
	
	internal sealed class PSPDFDocumentProviderDelegateWrapper : BaseWrapper, IPSPDFDocumentProviderDelegate {
		public PSPDFDocumentProviderDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFDocumentProviderDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFDocumentProviderDelegate", false)]
	[Model]
	public unsafe partial class PSPDFDocumentProviderDelegate : NSObject, IPSPDFDocumentProviderDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocumentProviderDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentProviderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentProviderDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("documentProvider:didAppendData:")]
		[CompilerGenerated]
		public virtual void DidAppendData (PSPDFDocumentProvider documentProvider, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("documentProvider:shouldAppendData:")]
		[CompilerGenerated]
		public virtual bool ShouldAppendData (PSPDFDocumentProvider documentProvider, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFDocumentProviderDelegate */
}
