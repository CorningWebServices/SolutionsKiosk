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
	[Register("PSPDFEmbeddedGoToAction", true)]
	public unsafe partial class PSPDFEmbeddedGoToAction : PSPDFGoToAction {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFEmbeddedGoToAction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFEmbeddedGoToAction () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFEmbeddedGoToAction (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFEmbeddedGoToAction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFEmbeddedGoToAction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:")]
		[CompilerGenerated]
		public PSPDFEmbeddedGoToAction (string remotePath, PSPDFEmbeddedGoToActionTarget targetRelationship, bool openInNewWindow, global::System.nuint pageIndex)
			: base (NSObjectFlag.Empty)
		{
			if (remotePath == null)
				throw new ArgumentNullException ("remotePath");
			var nsremotePath = NSString.CreateNative (remotePath);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_bool_nuint (this.Handle, Selector.GetHandle ("initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:"), nsremotePath, (UInt64)targetRelationship, openInNewWindow, pageIndex), "initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_bool_nuint (this.Handle, Selector.GetHandle ("initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:"), nsremotePath, (UInt32)targetRelationship, openInNewWindow, pageIndex), "initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_bool_nuint (this.SuperHandle, Selector.GetHandle ("initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:"), nsremotePath, (UInt64)targetRelationship, openInNewWindow, pageIndex), "initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_bool_nuint (this.SuperHandle, Selector.GetHandle ("initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:"), nsremotePath, (UInt32)targetRelationship, openInNewWindow, pageIndex), "initWithRemotePath:targetRelationship:openInNewWindow:pageIndex:");
				}
			}
			NSString.ReleaseNative (nsremotePath);
			
		}
		
		[CompilerGenerated]
		public virtual bool OpenInNewWindow {
			[Export ("openInNewWindow", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("openInNewWindow"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openInNewWindow"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string RelativePath {
			[Export ("relativePath")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("relativePath")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("relativePath")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFEmbeddedGoToActionTarget TargetRelationship {
			[Export ("targetRelationship", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFEmbeddedGoToActionTarget ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFEmbeddedGoToActionTarget) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("targetRelationship"));
					} else {
						ret = (PSPDFEmbeddedGoToActionTarget) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("targetRelationship"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFEmbeddedGoToActionTarget) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("targetRelationship"));
					} else {
						ret = (PSPDFEmbeddedGoToActionTarget) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("targetRelationship"));
					}
				}
				return ret;
			}
			
		}
		
	} /* class PSPDFEmbeddedGoToAction */
}
