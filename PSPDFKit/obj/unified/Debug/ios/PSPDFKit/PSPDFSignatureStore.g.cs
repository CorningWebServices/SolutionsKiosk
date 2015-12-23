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
	[Protocol (Name = "PSPDFSignatureStore", WrapperType = typeof (PSPDFSignatureStoreWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddSignature", Selector = "addSignature:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInkAnnotation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveSignature", Selector = "removeSignature:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInkAnnotation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSignatures", Selector = "signatures", ReturnType = typeof (PSPDFKit.PSPDFInkAnnotation[]))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetSignatures", Selector = "setSignatures:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFInkAnnotation[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetStoreName", Selector = "storeName", ReturnType = typeof (string))]
	public interface IPSPDFSignatureStore : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("addSignature:")]
		[Preserve (Conditional = true)]
		void AddSignature (PSPDFInkAnnotation signature);
		
		[CompilerGenerated]
		[Export ("removeSignature:")]
		[Preserve (Conditional = true)]
		bool RemoveSignature (PSPDFInkAnnotation signature);
		
	}
	
	public static partial class PSPDFSignatureStore_Extensions {
		[CompilerGenerated]
		public static PSPDFInkAnnotation[] GetSignatures (this IPSPDFSignatureStore This)
		{
			return NSArray.ArrayFromHandle<PSPDFInkAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("signatures")));
		}
		
		[CompilerGenerated]
		public static void SetSignatures (this IPSPDFSignatureStore This, PSPDFInkAnnotation[] signatures)
		{
			var nsa_signatures = signatures == null ? null : NSArray.FromNSObjects (signatures);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSignatures:"), nsa_signatures == null ? IntPtr.Zero : nsa_signatures.Handle);
			if (nsa_signatures != null)
				nsa_signatures.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static string GetStoreName (this IPSPDFSignatureStore This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("storeName")));
		}
		
	}
	
	internal sealed class PSPDFSignatureStoreWrapper : BaseWrapper, IPSPDFSignatureStore {
		public PSPDFSignatureStoreWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFSignatureStoreWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("addSignature:")]
		[CompilerGenerated]
		public void AddSignature (PSPDFInkAnnotation signature)
		{
			if (signature == null)
				throw new ArgumentNullException ("signature");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addSignature:"), signature.Handle);
		}
		
		[Export ("removeSignature:")]
		[CompilerGenerated]
		public bool RemoveSignature (PSPDFInkAnnotation signature)
		{
			if (signature == null)
				throw new ArgumentNullException ("signature");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeSignature:"), signature.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFSignatureStore", false)]
	[Model]
	public unsafe abstract partial class PSPDFSignatureStore : NSObject, IPSPDFSignatureStore {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFSignatureStore () : base (NSObjectFlag.Empty)
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
		protected PSPDFSignatureStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSignatureStore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithStoreName:")]
		[CompilerGenerated]
		public PSPDFSignatureStore (string storeName)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addSignature:")]
		[CompilerGenerated]
		public abstract void AddSignature (PSPDFInkAnnotation signature);
		[Export ("signatures")]
		[CompilerGenerated]
		public virtual PSPDFInkAnnotation[] GetSignatures ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("storeName")]
		[CompilerGenerated]
		public virtual string GetStoreName ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeSignature:")]
		[CompilerGenerated]
		public abstract bool RemoveSignature (PSPDFInkAnnotation signature);
		[Export ("setSignatures:")]
		[CompilerGenerated]
		public virtual void SetSignatures (PSPDFInkAnnotation[] signatures)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFSignatureStore */
}
