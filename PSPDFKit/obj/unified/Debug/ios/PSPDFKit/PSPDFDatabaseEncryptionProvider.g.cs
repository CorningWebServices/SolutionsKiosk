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
	[Protocol (Name = "PSPDFDatabaseEncryptionProvider", WrapperType = typeof (PSPDFDatabaseEncryptionProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EncryptDatabase", Selector = "encryptDatabase:withKey:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IntPtr), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReEncryptDatabase", Selector = "reEncryptDatabase:withKey:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IntPtr), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFDatabaseEncryptionProvider : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("encryptDatabase:withKey:")]
		[Preserve (Conditional = true)]
		bool EncryptDatabase (global::System.IntPtr db, NSData keyData);
		
		[CompilerGenerated]
		[Export ("reEncryptDatabase:withKey:")]
		[Preserve (Conditional = true)]
		bool ReEncryptDatabase (global::System.IntPtr db, NSData keyData);
		
	}
	
	internal sealed class PSPDFDatabaseEncryptionProviderWrapper : BaseWrapper, IPSPDFDatabaseEncryptionProvider {
		public PSPDFDatabaseEncryptionProviderWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFDatabaseEncryptionProviderWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("encryptDatabase:withKey:")]
		[CompilerGenerated]
		public bool EncryptDatabase (global::System.IntPtr db, NSData keyData)
		{
			if (keyData == null)
				throw new ArgumentNullException ("keyData");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("encryptDatabase:withKey:"), db, keyData.Handle);
		}
		
		[Export ("reEncryptDatabase:withKey:")]
		[CompilerGenerated]
		public bool ReEncryptDatabase (global::System.IntPtr db, NSData keyData)
		{
			if (keyData == null)
				throw new ArgumentNullException ("keyData");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("reEncryptDatabase:withKey:"), db, keyData.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFDatabaseEncryptionProvider", false)]
	[Model]
	public unsafe abstract partial class PSPDFDatabaseEncryptionProvider : NSObject, IPSPDFDatabaseEncryptionProvider {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFDatabaseEncryptionProvider () : base (NSObjectFlag.Empty)
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
		protected PSPDFDatabaseEncryptionProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDatabaseEncryptionProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("encryptDatabase:withKey:")]
		[CompilerGenerated]
		public abstract bool EncryptDatabase (global::System.IntPtr db, NSData keyData);
		[Export ("reEncryptDatabase:withKey:")]
		[CompilerGenerated]
		public abstract bool ReEncryptDatabase (global::System.IntPtr db, NSData keyData);
	} /* class PSPDFDatabaseEncryptionProvider */
}
