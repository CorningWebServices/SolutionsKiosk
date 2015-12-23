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
	[Register("PSPDFRenditionAction", true)]
	public unsafe partial class PSPDFRenditionAction : PSPDFAction {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFRenditionAction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFRenditionAction () : base (NSObjectFlag.Empty)
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
		public PSPDFRenditionAction (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFRenditionAction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFRenditionAction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithActionType:annotation:")]
		[CompilerGenerated]
		public PSPDFRenditionAction (PSPDFRenditionActionType actionType, PSPDFScreenAnnotation annotation)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Int64_IntPtr (this.Handle, Selector.GetHandle ("initWithActionType:annotation:"), (Int64)actionType, annotation == null ? IntPtr.Zero : annotation.Handle), "initWithActionType:annotation:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_IntPtr (this.Handle, Selector.GetHandle ("initWithActionType:annotation:"), (int)actionType, annotation == null ? IntPtr.Zero : annotation.Handle), "initWithActionType:annotation:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_Int64_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithActionType:annotation:"), (Int64)actionType, annotation == null ? IntPtr.Zero : annotation.Handle), "initWithActionType:annotation:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithActionType:annotation:"), (int)actionType, annotation == null ? IntPtr.Zero : annotation.Handle), "initWithActionType:annotation:");
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFRenditionActionType ActionType {
			[Export ("actionType", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFRenditionActionType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFRenditionActionType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("actionType"));
					} else {
						ret = (PSPDFRenditionActionType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("actionType"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFRenditionActionType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionType"));
					} else {
						ret = (PSPDFRenditionActionType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionType"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Annotation_var;
		[CompilerGenerated]
		public virtual PSPDFScreenAnnotation Annotation {
			[Export ("annotation", ArgumentSemantic.Weak)]
			get {
				PSPDFScreenAnnotation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFScreenAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotation")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFScreenAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotation")));
				}
				MarkDirty ();
				__mt_Annotation_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _TypeTransformerName;
		[Field ("PSPDFRenditionActionTypeTransformerName",  "__Internal")]
		public static unsafe NSString TypeTransformerName {
			get {
				if (_TypeTransformerName == null)
					_TypeTransformerName = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFRenditionActionTypeTransformerName");
				return _TypeTransformerName;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotation_var = null;
			}
		}
	} /* class PSPDFRenditionAction */
}
