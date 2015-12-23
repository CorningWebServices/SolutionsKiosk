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
	[Protocol (Name = "PSPDFGalleryContentViewLoading", WrapperType = typeof (PSPDFGalleryContentViewLoadingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetProgress", Selector = "setProgress:", ParameterType = new Type [] { typeof (nfloat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Progress", Selector = "progress", ReturnType = typeof (nfloat))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetHasUnspecifiedProgress", Selector = "setHasUnspecifiedProgress:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasUnspecifiedProgress", Selector = "hasUnspecifiedProgress", ReturnType = typeof (bool))]
	public interface IPSPDFGalleryContentViewLoading : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setProgress:")]
		[Preserve (Conditional = true)]
		void SetProgress (global::System.nfloat progress);
		
		[CompilerGenerated]
		[Export ("progress")]
		[Preserve (Conditional = true)]
		global::System.nfloat Progress ();
		
	}
	
	public static partial class PSPDFGalleryContentViewLoading_Extensions {
		[CompilerGenerated]
		public static void SetHasUnspecifiedProgress (this IPSPDFGalleryContentViewLoading This, bool progress)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setHasUnspecifiedProgress:"), progress);
		}
		
		[CompilerGenerated]
		public static bool HasUnspecifiedProgress (this IPSPDFGalleryContentViewLoading This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasUnspecifiedProgress"));
		}
		
	}
	
	internal sealed class PSPDFGalleryContentViewLoadingWrapper : BaseWrapper, IPSPDFGalleryContentViewLoading {
		public PSPDFGalleryContentViewLoadingWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFGalleryContentViewLoadingWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setProgress:")]
		[CompilerGenerated]
		public void SetProgress (global::System.nfloat progress)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setProgress:"), progress);
		}
		
		[Export ("progress")]
		[CompilerGenerated]
		public global::System.nfloat Progress ()
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("progress"));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFGalleryContentViewLoading", false)]
	[Model]
	public unsafe abstract partial class PSPDFGalleryContentViewLoading : NSObject, IPSPDFGalleryContentViewLoading {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFGalleryContentViewLoading () : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryContentViewLoading (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryContentViewLoading (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hasUnspecifiedProgress")]
		[CompilerGenerated]
		public virtual bool HasUnspecifiedProgress ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("progress")]
		[CompilerGenerated]
		public abstract global::System.nfloat Progress ();
		[Export ("setHasUnspecifiedProgress:")]
		[CompilerGenerated]
		public virtual void SetHasUnspecifiedProgress (bool progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setProgress:")]
		[CompilerGenerated]
		public abstract void SetProgress (global::System.nfloat progress);
	} /* class PSPDFGalleryContentViewLoading */
}
