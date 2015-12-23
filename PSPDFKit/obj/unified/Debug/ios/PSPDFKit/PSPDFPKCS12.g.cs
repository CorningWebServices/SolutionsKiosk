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
	[Register("PSPDFPKCS12", true)]
	public unsafe partial class PSPDFPKCS12 : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPKCS12");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFPKCS12 (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPKCS12 (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithData:")]
		[CompilerGenerated]
		public PSPDFPKCS12 (NSData data)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithData:"), data.Handle), "initWithData:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithData:"), data.Handle), "initWithData:");
			}
		}
		
		[Export ("unlockWithPassword:done:")]
		[CompilerGenerated]
		public unsafe virtual void Unlock (string password, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFPKCS12UnlockHandler))]PSPDFPKCS12UnlockHandler done)
		{
			if (password == null)
				throw new ArgumentNullException ("password");
			var nspassword = NSString.CreateNative (password);
			BlockLiteral *block_ptr_done;
			BlockLiteral block_done;
			if (done == null){
				block_ptr_done = null;
			} else {
				block_done = new BlockLiteral ();
				block_ptr_done = &block_done;
				block_done.SetupBlock (Trampolines.SDPSPDFPKCS12UnlockHandler.Handler, done);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("unlockWithPassword:done:"), nspassword, (IntPtr) block_ptr_done);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("unlockWithPassword:done:"), nspassword, (IntPtr) block_ptr_done);
			}
			NSString.ReleaseNative (nspassword);
			if (block_ptr_done != null)
				block_ptr_done->CleanupBlock ();
			
		}
		
	} /* class PSPDFPKCS12 */
}
