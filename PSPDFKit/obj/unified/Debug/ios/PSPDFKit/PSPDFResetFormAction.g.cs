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
	[Register("PSPDFResetFormAction", true)]
	public unsafe partial class PSPDFResetFormAction : PSPDFAbstractFormAction {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFResetFormAction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFResetFormAction (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFResetFormAction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFResetFormAction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFlags:")]
		[CompilerGenerated]
		public PSPDFResetFormAction (PSPDFResetFormActionFlag flags)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("initWithFlags:"), (UInt64)flags), "initWithFlags:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("initWithFlags:"), (UInt32)flags), "initWithFlags:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("initWithFlags:"), (UInt64)flags), "initWithFlags:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("initWithFlags:"), (UInt32)flags), "initWithFlags:");
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFResetFormActionFlag Flags {
			[Export ("flags", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFResetFormActionFlag ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFResetFormActionFlag) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("flags"));
					} else {
						ret = (PSPDFResetFormActionFlag) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("flags"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFResetFormActionFlag) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("flags"));
					} else {
						ret = (PSPDFResetFormActionFlag) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("flags"));
					}
				}
				return ret;
			}
			
		}
		
	} /* class PSPDFResetFormAction */
}