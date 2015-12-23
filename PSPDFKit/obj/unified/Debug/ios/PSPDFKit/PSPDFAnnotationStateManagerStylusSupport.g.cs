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
	[Register("PSPDFAnnotationStateManagerStylusSupport", true)]
	public unsafe partial class PSPDFAnnotationStateManagerStylusSupport : NSObject, IPSPDFStylusDriverDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationStateManagerStylusSupport");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationStateManagerStylusSupport () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationStateManagerStylusSupport (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationStateManagerStylusSupport (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("buttonFired:")]
		[CompilerGenerated]
		public virtual void ButtonFired (global::System.nuint buttonNumber)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("buttonFired:"), buttonNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("buttonFired:"), buttonNumber);
			}
		}
		
		[Export ("classificationsDidChangeForTouches:")]
		[CompilerGenerated]
		public virtual void ClassificationsDidChangeForTouches (NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("classificationsDidChangeForTouches:"), touches.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("classificationsDidChangeForTouches:"), touches.Handle);
			}
		}
		
		[Export ("connectionStatusChanged")]
		[CompilerGenerated]
		public virtual void ConnectionStatusChanged ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatusChanged"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionStatusChanged"));
			}
		}
		
		[Export ("stylusSuggestsToDisableGestures")]
		[CompilerGenerated]
		public virtual void StylusSuggestsToDisableGestures ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stylusSuggestsToDisableGestures"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stylusSuggestsToDisableGestures"));
			}
		}
		
		[Export ("stylusSuggestsToEnableGestures")]
		[CompilerGenerated]
		public virtual void StylusSuggestsToEnableGestures ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stylusSuggestsToEnableGestures"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stylusSuggestsToEnableGestures"));
			}
		}
		
		[Export ("stylusTouchBegan:")]
		[CompilerGenerated]
		public virtual void StylusTouchBegan (NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stylusTouchBegan:"), touches.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stylusTouchBegan:"), touches.Handle);
			}
		}
		
		[Export ("stylusTouchCancelled:")]
		[CompilerGenerated]
		public virtual void StylusTouchCancelled (NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stylusTouchCancelled:"), touches.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stylusTouchCancelled:"), touches.Handle);
			}
		}
		
		[Export ("stylusTouchEnded:")]
		[CompilerGenerated]
		public virtual void StylusTouchEnded (NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stylusTouchEnded:"), touches.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stylusTouchEnded:"), touches.Handle);
			}
		}
		
		[Export ("stylusTouchMoved:")]
		[CompilerGenerated]
		public virtual void StylusTouchMoved (NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stylusTouchMoved:"), touches.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stylusTouchMoved:"), touches.Handle);
			}
		}
		
	} /* class PSPDFAnnotationStateManagerStylusSupport */
}
