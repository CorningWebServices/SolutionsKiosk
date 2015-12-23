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
	[Register("PSPDFSignaturePropBuild", true)]
	public unsafe partial class PSPDFSignaturePropBuild : PSPDFModel {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFSignaturePropBuild");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSignaturePropBuild () : base (NSObjectFlag.Empty)
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
		public PSPDFSignaturePropBuild (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFSignaturePropBuild (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSignaturePropBuild (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_App_var;
		[CompilerGenerated]
		public virtual PSPDFSignaturePropBuildEntry App {
			[Export ("app", ArgumentSemantic.Copy)]
			get {
				PSPDFSignaturePropBuildEntry ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSignaturePropBuildEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("app")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSignaturePropBuildEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("app")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_App_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Filter_var;
		[CompilerGenerated]
		public virtual PSPDFSignaturePropBuildEntry Filter {
			[Export ("filter", ArgumentSemantic.Copy)]
			get {
				PSPDFSignaturePropBuildEntry ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSignaturePropBuildEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("filter")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSignaturePropBuildEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("filter")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Filter_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PubSec_var;
		[CompilerGenerated]
		public virtual PSPDFSignaturePropBuildEntry PubSec {
			[Export ("pubSec", ArgumentSemantic.Copy)]
			get {
				PSPDFSignaturePropBuildEntry ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSignaturePropBuildEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pubSec")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSignaturePropBuildEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pubSec")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PubSec_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SigQ_var;
		[CompilerGenerated]
		public virtual PSPDFSignaturePropBuildEntry SigQ {
			[Export ("sigQ", ArgumentSemantic.Copy)]
			get {
				PSPDFSignaturePropBuildEntry ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSignaturePropBuildEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sigQ")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSignaturePropBuildEntry> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sigQ")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SigQ_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_App_var = null;
				__mt_Filter_var = null;
				__mt_PubSec_var = null;
				__mt_SigQ_var = null;
			}
		}
	} /* class PSPDFSignaturePropBuild */
}
