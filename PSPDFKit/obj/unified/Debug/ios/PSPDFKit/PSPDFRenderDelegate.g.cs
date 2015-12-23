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
	[Protocol (Name = "PSPDFRenderDelegate", WrapperType = typeof (PSPDFRenderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "JobDidFinish", Selector = "renderQueue:jobDidFinish:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFRenderQueue), typeof (PSPDFKit.PSPDFRenderJob) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFRenderDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("renderQueue:jobDidFinish:")]
		[Preserve (Conditional = true)]
		void JobDidFinish (PSPDFRenderQueue renderQueue, PSPDFRenderJob job);
		
	}
	
	internal sealed class PSPDFRenderDelegateWrapper : BaseWrapper, IPSPDFRenderDelegate {
		public PSPDFRenderDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFRenderDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("renderQueue:jobDidFinish:")]
		[CompilerGenerated]
		public void JobDidFinish (PSPDFRenderQueue renderQueue, PSPDFRenderJob job)
		{
			if (renderQueue == null)
				throw new ArgumentNullException ("renderQueue");
			if (job == null)
				throw new ArgumentNullException ("job");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("renderQueue:jobDidFinish:"), renderQueue.Handle, job.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFRenderDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFRenderDelegate : NSObject, IPSPDFRenderDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFRenderDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFRenderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFRenderDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("renderQueue:jobDidFinish:")]
		[CompilerGenerated]
		public abstract void JobDidFinish (PSPDFRenderQueue renderQueue, PSPDFRenderJob job);
	} /* class PSPDFRenderDelegate */
}
