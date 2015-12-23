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
	[Protocol (Name = "PSPDFDocumentActionExecutorDelegate", WrapperType = typeof (PSPDFDocumentActionExecutorDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DefaultOptionsForAction", Selector = "documentActionExecutor:defaultOptionsForAction:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocumentActionExecutor), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFDocumentActionExecutorDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFDocumentActionExecutorDelegate_Extensions {
		[CompilerGenerated]
		public static NSDictionary DefaultOptionsForAction (this IPSPDFDocumentActionExecutorDelegate This, PSPDFDocumentActionExecutor documentActionExecutor, string action)
		{
			if (documentActionExecutor == null)
				throw new ArgumentNullException ("documentActionExecutor");
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsaction = NSString.CreateNative (action);
			
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("documentActionExecutor:defaultOptionsForAction:"), documentActionExecutor.Handle, nsaction));
			NSString.ReleaseNative (nsaction);
			
			return ret;
		}
		
	}
	
	internal sealed class PSPDFDocumentActionExecutorDelegateWrapper : BaseWrapper, IPSPDFDocumentActionExecutorDelegate {
		public PSPDFDocumentActionExecutorDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFDocumentActionExecutorDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFDocumentActionExecutorDelegate", false)]
	[Model]
	public unsafe partial class PSPDFDocumentActionExecutorDelegate : NSObject, IPSPDFDocumentActionExecutorDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocumentActionExecutorDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentActionExecutorDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentActionExecutorDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("documentActionExecutor:defaultOptionsForAction:")]
		[CompilerGenerated]
		public virtual NSDictionary DefaultOptionsForAction (PSPDFDocumentActionExecutor documentActionExecutor, string action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFDocumentActionExecutorDelegate */
}
