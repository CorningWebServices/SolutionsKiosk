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
	[Protocol (Name = "PSPDFGalleryContentViewCaption", WrapperType = typeof (PSPDFGalleryContentViewCaptionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCaption", Selector = "setCaption:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCaption", Selector = "caption", ReturnType = typeof (string))]
	public interface IPSPDFGalleryContentViewCaption : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setCaption:")]
		[Preserve (Conditional = true)]
		void SetCaption (string caption);
		
		[CompilerGenerated]
		[Export ("caption")]
		[Preserve (Conditional = true)]
		string GetCaption ();
		
	}
	
	internal sealed class PSPDFGalleryContentViewCaptionWrapper : BaseWrapper, IPSPDFGalleryContentViewCaption {
		public PSPDFGalleryContentViewCaptionWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFGalleryContentViewCaptionWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setCaption:")]
		[CompilerGenerated]
		public void SetCaption (string caption)
		{
			var nscaption = NSString.CreateNative (caption);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCaption:"), nscaption);
			NSString.ReleaseNative (nscaption);
			
		}
		
		[Export ("caption")]
		[CompilerGenerated]
		public string GetCaption ()
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("caption")));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFGalleryContentViewCaption", false)]
	[Model]
	public unsafe abstract partial class PSPDFGalleryContentViewCaption : NSObject, IPSPDFGalleryContentViewCaption {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFGalleryContentViewCaption () : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryContentViewCaption (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryContentViewCaption (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("caption")]
		[CompilerGenerated]
		public abstract string GetCaption ();
		[Export ("setCaption:")]
		[CompilerGenerated]
		public abstract void SetCaption (string caption);
	} /* class PSPDFGalleryContentViewCaption */
}
