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
	[Register("PSPDFAnnotationGroupItem", true)]
	public unsafe partial class PSPDFAnnotationGroupItem : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationGroupItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationGroupItem () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationGroupItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationGroupItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("freeTextConfigurationBlock")]
		[CompilerGenerated]
		public unsafe static PSPDFAnnotationGroupItemConfigurationHandler FreeTextConfigurationHandler ()
		{
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("freeTextConfigurationBlock"));
			return global::ObjCRuntime.Trampolines.NIDPSPDFAnnotationGroupItemConfigurationHandler.Create (ret);
		}
		
		[Export ("itemWithType:")]
		[CompilerGenerated]
		public static PSPDFAnnotationGroupItem FromType (NSString annotationStringType)
		{
			if (annotationStringType == null)
				throw new ArgumentNullException ("annotationStringType");
			return  Runtime.GetNSObject<PSPDFAnnotationGroupItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("itemWithType:"), annotationStringType.Handle));
		}
		
		[Export ("itemWithType:variant:")]
		[CompilerGenerated]
		public static PSPDFAnnotationGroupItem FromType (NSString annotationStringType, string variant)
		{
			if (annotationStringType == null)
				throw new ArgumentNullException ("annotationStringType");
			var nsvariant = NSString.CreateNative (variant);
			
			PSPDFAnnotationGroupItem ret;
			ret =  Runtime.GetNSObject<PSPDFAnnotationGroupItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("itemWithType:variant:"), annotationStringType.Handle, nsvariant));
			NSString.ReleaseNative (nsvariant);
			
			return ret;
		}
		
		[Export ("itemWithType:variant:configurationBlock:")]
		[CompilerGenerated]
		public unsafe static PSPDFAnnotationGroupItem FromType (NSString annotationStringType, string variant, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFAnnotationGroupItemConfigurationHandler))]PSPDFAnnotationGroupItemConfigurationHandler handler)
		{
			if (annotationStringType == null)
				throw new ArgumentNullException ("annotationStringType");
			var nsvariant = NSString.CreateNative (variant);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDPSPDFAnnotationGroupItemConfigurationHandler.Handler, handler);
			}
			
			PSPDFAnnotationGroupItem ret;
			ret =  Runtime.GetNSObject<PSPDFAnnotationGroupItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("itemWithType:variant:configurationBlock:"), annotationStringType.Handle, nsvariant, (IntPtr) block_ptr_handler));
			NSString.ReleaseNative (nsvariant);
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("inkConfigurationBlock")]
		[CompilerGenerated]
		public unsafe static PSPDFAnnotationGroupItemConfigurationHandler InkConfigurationHandler ()
		{
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("inkConfigurationBlock"));
			return global::ObjCRuntime.Trampolines.NIDPSPDFAnnotationGroupItemConfigurationHandler.Create (ret);
		}
		
		[Export ("setConfigurationBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetConfigurationHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFAnnotationGroupItemConfigurationHandler))]PSPDFAnnotationGroupItemConfigurationHandler handler)
		{
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDPSPDFAnnotationGroupItemConfigurationHandler.Handler, handler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConfigurationBlock:"), (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConfigurationBlock:"), (IntPtr) block_ptr_handler);
			}
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("setDefaultConfigurationBlock:")]
		[CompilerGenerated]
		public unsafe static void SetDefaultConfigurationHanlder ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFAnnotationGroupItemConfigurationHandler))]PSPDFAnnotationGroupItemConfigurationHandler handler)
		{
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDPSPDFAnnotationGroupItemConfigurationHandler.Handler, handler);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setDefaultConfigurationBlock:"), (IntPtr) block_ptr_handler);
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_Type_var;
		[CompilerGenerated]
		public virtual NSString Type {
			[Export ("type")]
			get {
				NSString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type")));
				} else {
					ret =  Runtime.GetNSObject<NSString> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Type_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Variant {
			[Export ("variant")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("variant")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("variant")));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Type_var = null;
			}
		}
	} /* class PSPDFAnnotationGroupItem */
}
