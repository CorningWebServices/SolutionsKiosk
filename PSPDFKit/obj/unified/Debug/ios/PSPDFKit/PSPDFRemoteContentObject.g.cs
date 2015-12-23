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
	[Protocol (Name = "PSPDFRemoteContentObject", WrapperType = typeof (PSPDFRemoteContentObjectWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UrlRequestForRemoteContent", Selector = "URLRequestForRemoteContent", ReturnType = typeof (NSUrlRequest))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetRemoteContent", Selector = "remoteContent", ReturnType = typeof (NSObject))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetRemoteContent", Selector = "setRemoteContent:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLoadingRemoteContent", Selector = "isLoadingRemoteContent", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetLoadingRemoteContent", Selector = "setLoadingRemoteContent:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRemoteContentProgress", Selector = "remoteContentProgress", ReturnType = typeof (nfloat))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetRemoteContentProgress", Selector = "setRemoteContentProgress:", ParameterType = new Type [] { typeof (nfloat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRemoteContentError", Selector = "remoteContentError", ReturnType = typeof (NSError))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetRemoteContentError", Selector = "setRemoteContentError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldCacheRemoteContent", Selector = "shouldCacheRemoteContent", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRetryLoadingRemoteContentOnConnectionFailure", Selector = "shouldRetryLoadingRemoteContentOnConnectionFailure", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteContentAuthenticationChallengeHandler", Selector = "remoteContentAuthenticationChallengeBlock", ReturnType = typeof (PSPDFKit.PSPDFRemoteContentObjectAuthHandler))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteContentTransformerHandler", Selector = "remoteContentTransformerBlock", ReturnType = typeof (PSPDFKit.PSPDFRemoteContentObjectTransformerHandler))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasRemoteContent", Selector = "hasRemoteContent", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRemoteObject", Selector = "remoteObject", ReturnType = typeof (PSPDFKit.PSPDFRemoteContentObjectRemoteObjectHandler))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetRemoteObject", Selector = "setRemoteObject:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFRemoteContentObjectRemoteObjectHandler) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFRemoteContentObject : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("URLRequestForRemoteContent")]
		[Preserve (Conditional = true)]
		NSUrlRequest UrlRequestForRemoteContent ();
		
		[CompilerGenerated]
		[Export ("remoteContent")]
		[Preserve (Conditional = true)]
		NSObject GetRemoteContent ();
		
		[CompilerGenerated]
		[Export ("setRemoteContent:")]
		[Preserve (Conditional = true)]
		void SetRemoteContent (NSObject remoteContent);
		
	}
	
	public static partial class PSPDFRemoteContentObject_Extensions {
		[CompilerGenerated]
		public static bool GetLoadingRemoteContent (this IPSPDFRemoteContentObject This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isLoadingRemoteContent"));
		}
		
		[CompilerGenerated]
		public static void SetLoadingRemoteContent (this IPSPDFRemoteContentObject This, bool isLoadingRemoteContent)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setLoadingRemoteContent:"), isLoadingRemoteContent);
		}
		
		[CompilerGenerated]
		public static global::System.nfloat GetRemoteContentProgress (this IPSPDFRemoteContentObject This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("remoteContentProgress"));
		}
		
		[CompilerGenerated]
		public static void SetRemoteContentProgress (this IPSPDFRemoteContentObject This, global::System.nfloat remoteContentProgress)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setRemoteContentProgress:"), remoteContentProgress);
		}
		
		[CompilerGenerated]
		public static NSError GetRemoteContentError (this IPSPDFRemoteContentObject This)
		{
			return  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("remoteContentError")));
		}
		
		[CompilerGenerated]
		public static void SetRemoteContentError (this IPSPDFRemoteContentObject This, NSError remoteContentError)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setRemoteContentError:"), remoteContentError == null ? IntPtr.Zero : remoteContentError.Handle);
		}
		
		[CompilerGenerated]
		public static bool ShouldCacheRemoteContent (this IPSPDFRemoteContentObject This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldCacheRemoteContent"));
		}
		
		[CompilerGenerated]
		public static bool ShouldRetryLoadingRemoteContentOnConnectionFailure (this IPSPDFRemoteContentObject This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldRetryLoadingRemoteContentOnConnectionFailure"));
		}
		
		[CompilerGenerated]
		public unsafe static PSPDFRemoteContentObjectAuthHandler RemoteContentAuthenticationChallengeHandler (this IPSPDFRemoteContentObject This)
		{
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("remoteContentAuthenticationChallengeBlock"));
			return global::ObjCRuntime.Trampolines.NIDPSPDFRemoteContentObjectAuthHandler.Create (ret);
		}
		
		[CompilerGenerated]
		public unsafe static PSPDFRemoteContentObjectTransformerHandler RemoteContentTransformerHandler (this IPSPDFRemoteContentObject This)
		{
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("remoteContentTransformerBlock"));
			return global::ObjCRuntime.Trampolines.NIDPSPDFRemoteContentObjectTransformerHandler.Create (ret);
		}
		
		[CompilerGenerated]
		public static bool HasRemoteContent (this IPSPDFRemoteContentObject This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasRemoteContent"));
		}
		
		[CompilerGenerated]
		public unsafe static PSPDFRemoteContentObjectRemoteObjectHandler GetRemoteObject (this IPSPDFRemoteContentObject This)
		{
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("remoteObject"));
			return global::ObjCRuntime.Trampolines.NIDPSPDFRemoteContentObjectRemoteObjectHandler.Create (ret);
		}
		
		[CompilerGenerated]
		public unsafe static void SetRemoteObject (this IPSPDFRemoteContentObject This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFRemoteContentObjectRemoteObjectHandler))]PSPDFRemoteContentObjectRemoteObjectHandler objHandler)
		{
			if (objHandler == null)
				throw new ArgumentNullException ("objHandler");
			BlockLiteral *block_ptr_objHandler;
			BlockLiteral block_objHandler;
			block_objHandler = new BlockLiteral ();
			block_ptr_objHandler = &block_objHandler;
			block_objHandler.SetupBlock (Trampolines.SDPSPDFRemoteContentObjectRemoteObjectHandler.Handler, objHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setRemoteObject:"), (IntPtr) block_ptr_objHandler);
			block_ptr_objHandler->CleanupBlock ();
			
		}
		
	}
	
	internal sealed class PSPDFRemoteContentObjectWrapper : BaseWrapper, IPSPDFRemoteContentObject {
		public PSPDFRemoteContentObjectWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFRemoteContentObjectWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("URLRequestForRemoteContent")]
		[CompilerGenerated]
		public NSUrlRequest UrlRequestForRemoteContent ()
		{
			return  Runtime.GetNSObject<NSUrlRequest> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("URLRequestForRemoteContent")));
		}
		
		[Export ("remoteContent")]
		[CompilerGenerated]
		public NSObject GetRemoteContent ()
		{
			return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteContent")));
		}
		
		[Export ("setRemoteContent:")]
		[CompilerGenerated]
		public void SetRemoteContent (NSObject remoteContent)
		{
			if (remoteContent == null)
				throw new ArgumentNullException ("remoteContent");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteContent:"), remoteContent.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFRemoteContentObject", false)]
	[Model]
	public unsafe abstract partial class PSPDFRemoteContentObject : NSObject, IPSPDFRemoteContentObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFRemoteContentObject () : base (NSObjectFlag.Empty)
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
		protected PSPDFRemoteContentObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFRemoteContentObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("isLoadingRemoteContent")]
		[CompilerGenerated]
		public virtual bool GetLoadingRemoteContent ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("remoteContent")]
		[CompilerGenerated]
		public abstract NSObject GetRemoteContent ();
		[Export ("remoteContentError")]
		[CompilerGenerated]
		public virtual NSError GetRemoteContentError ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("remoteContentProgress")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetRemoteContentProgress ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("remoteObject")]
		[CompilerGenerated]
		public unsafe virtual PSPDFRemoteContentObjectRemoteObjectHandler GetRemoteObject ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hasRemoteContent")]
		[CompilerGenerated]
		public virtual bool HasRemoteContent ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("remoteContentAuthenticationChallengeBlock")]
		[CompilerGenerated]
		public unsafe virtual PSPDFRemoteContentObjectAuthHandler RemoteContentAuthenticationChallengeHandler ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("remoteContentTransformerBlock")]
		[CompilerGenerated]
		public unsafe virtual PSPDFRemoteContentObjectTransformerHandler RemoteContentTransformerHandler ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setLoadingRemoteContent:")]
		[CompilerGenerated]
		public virtual void SetLoadingRemoteContent (bool isLoadingRemoteContent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setRemoteContent:")]
		[CompilerGenerated]
		public abstract void SetRemoteContent (NSObject remoteContent);
		[Export ("setRemoteContentError:")]
		[CompilerGenerated]
		public virtual void SetRemoteContentError (NSError remoteContentError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setRemoteContentProgress:")]
		[CompilerGenerated]
		public virtual void SetRemoteContentProgress (global::System.nfloat remoteContentProgress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setRemoteObject:")]
		[CompilerGenerated]
		public unsafe virtual void SetRemoteObject ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFRemoteContentObjectRemoteObjectHandler))]PSPDFRemoteContentObjectRemoteObjectHandler objHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("shouldCacheRemoteContent")]
		[CompilerGenerated]
		public virtual bool ShouldCacheRemoteContent ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("shouldRetryLoadingRemoteContentOnConnectionFailure")]
		[CompilerGenerated]
		public virtual bool ShouldRetryLoadingRemoteContentOnConnectionFailure ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("URLRequestForRemoteContent")]
		[CompilerGenerated]
		public abstract NSUrlRequest UrlRequestForRemoteContent ();
	} /* class PSPDFRemoteContentObject */
}
