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
	[Protocol (Name = "PSPDFScrobbleBarDelegate", WrapperType = typeof (PSPDFScrobbleBarDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectPage", Selector = "scrobbleBar:didSelectPage:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFScrobbleBar), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFScrobbleBarDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("scrobbleBar:didSelectPage:")]
		[Preserve (Conditional = true)]
		void DidSelectPage (PSPDFScrobbleBar scrobbleBar, global::System.nuint page);
		
	}
	
	internal sealed class PSPDFScrobbleBarDelegateWrapper : BaseWrapper, IPSPDFScrobbleBarDelegate {
		public PSPDFScrobbleBarDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFScrobbleBarDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("scrobbleBar:didSelectPage:")]
		[CompilerGenerated]
		public void DidSelectPage (PSPDFScrobbleBar scrobbleBar, global::System.nuint page)
		{
			if (scrobbleBar == null)
				throw new ArgumentNullException ("scrobbleBar");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("scrobbleBar:didSelectPage:"), scrobbleBar.Handle, page);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFScrobbleBarDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFScrobbleBarDelegate : NSObject, IPSPDFScrobbleBarDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFScrobbleBarDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFScrobbleBarDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFScrobbleBarDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("scrobbleBar:didSelectPage:")]
		[CompilerGenerated]
		public abstract void DidSelectPage (PSPDFScrobbleBar scrobbleBar, global::System.nuint page);
	} /* class PSPDFScrobbleBarDelegate */
}
