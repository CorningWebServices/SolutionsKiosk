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
	[Register("PSPDFDefaultApplicationPolicy", true)]
	public unsafe partial class PSPDFDefaultApplicationPolicy : NSObject, IPSPDFApplicationPolicy {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDefaultApplicationPolicy");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDefaultApplicationPolicy () : base (NSObjectFlag.Empty)
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
		protected PSPDFDefaultApplicationPolicy (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDefaultApplicationPolicy (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hasPermissionForEvent:isUserAction:")]
		[CompilerGenerated]
		public virtual bool HasPermission (NSString aEvent, bool isUserAction)
		{
			if (aEvent == null)
				throw new ArgumentNullException ("aEvent");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("hasPermissionForEvent:isUserAction:"), aEvent.Handle, isUserAction);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("hasPermissionForEvent:isUserAction:"), aEvent.Handle, isUserAction);
			}
		}
		
	} /* class PSPDFDefaultApplicationPolicy */
}
