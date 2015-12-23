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
	[Protocol (Name = "PSPDFApplicationPolicy", WrapperType = typeof (PSPDFApplicationPolicyWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HasPermission", Selector = "hasPermissionForEvent:isUserAction:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSString), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFApplicationPolicy : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("hasPermissionForEvent:isUserAction:")]
		[Preserve (Conditional = true)]
		bool HasPermission (NSString aEvent, bool isUserAction);
		
	}
	
	internal sealed class PSPDFApplicationPolicyWrapper : BaseWrapper, IPSPDFApplicationPolicy {
		public PSPDFApplicationPolicyWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFApplicationPolicyWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("hasPermissionForEvent:isUserAction:")]
		[CompilerGenerated]
		public bool HasPermission (NSString aEvent, bool isUserAction)
		{
			if (aEvent == null)
				throw new ArgumentNullException ("aEvent");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("hasPermissionForEvent:isUserAction:"), aEvent.Handle, isUserAction);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFApplicationPolicy", false)]
	[Model]
	public unsafe abstract partial class PSPDFApplicationPolicy : NSObject, IPSPDFApplicationPolicy {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFApplicationPolicy () : base (NSObjectFlag.Empty)
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
		protected PSPDFApplicationPolicy (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFApplicationPolicy (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hasPermissionForEvent:isUserAction:")]
		[CompilerGenerated]
		public abstract bool HasPermission (NSString aEvent, bool isUserAction);
	} /* class PSPDFApplicationPolicy */
}
