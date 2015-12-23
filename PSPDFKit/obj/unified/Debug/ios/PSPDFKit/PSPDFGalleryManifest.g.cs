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
	[Register("PSPDFGalleryManifest", true)]
	public unsafe partial class PSPDFGalleryManifest : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGalleryManifest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFGalleryManifest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryManifest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithLinkAnnotation:")]
		[CompilerGenerated]
		public PSPDFGalleryManifest (PSPDFLinkAnnotation linkAnnotation)
			: base (NSObjectFlag.Empty)
		{
			if (linkAnnotation == null)
				throw new ArgumentNullException ("linkAnnotation");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithLinkAnnotation:"), linkAnnotation.Handle), "initWithLinkAnnotation:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithLinkAnnotation:"), linkAnnotation.Handle), "initWithLinkAnnotation:");
			}
		}
		
		[Export ("cancel")]
		[CompilerGenerated]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancel"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancel"));
			}
		}
		
		[Export ("loadItemsWithCompletionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void LoadItems ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<PSPDFGalleryItem[], NSError> completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlock (Trampolines.SDActionArity2V7.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadItemsWithCompletionBlock:"), (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadItemsWithCompletionBlock:"), (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_LinkAnnotation_var;
		[CompilerGenerated]
		public virtual PSPDFLinkAnnotation LinkAnnotation {
			[Export ("linkAnnotation", ArgumentSemantic.Retain)]
			get {
				PSPDFLinkAnnotation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFLinkAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linkAnnotation")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFLinkAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkAnnotation")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LinkAnnotation_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Loading {
			[Export ("isLoading", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLoading"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLoading"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LinkAnnotation_var = null;
			}
		}
	} /* class PSPDFGalleryManifest */
}
