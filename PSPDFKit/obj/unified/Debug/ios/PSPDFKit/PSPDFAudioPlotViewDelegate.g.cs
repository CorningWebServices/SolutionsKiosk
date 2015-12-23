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
	[Protocol (Name = "PSPDFAudioPlotViewDelegate", WrapperType = typeof (PSPDFAudioPlotViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UrlForAudioPlotView", Selector = "URLForAudioPlotView:", ReturnType = typeof (NSUrl), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAudioPlotView) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFAudioPlotViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFAudioPlotViewDelegate_Extensions {
		[CompilerGenerated]
		public static NSUrl UrlForAudioPlotView (this IPSPDFAudioPlotViewDelegate This, PSPDFAudioPlotView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("URLForAudioPlotView:"), view.Handle));
		}
		
	}
	
	internal sealed class PSPDFAudioPlotViewDelegateWrapper : BaseWrapper, IPSPDFAudioPlotViewDelegate {
		public PSPDFAudioPlotViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAudioPlotViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAudioPlotViewDelegate", false)]
	[Model]
	public unsafe partial class PSPDFAudioPlotViewDelegate : NSObject, IPSPDFAudioPlotViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAudioPlotViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFAudioPlotViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAudioPlotViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("URLForAudioPlotView:")]
		[CompilerGenerated]
		public virtual NSUrl UrlForAudioPlotView (PSPDFAudioPlotView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFAudioPlotViewDelegate */
}
