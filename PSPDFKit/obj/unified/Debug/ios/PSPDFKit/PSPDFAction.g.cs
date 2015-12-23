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
	[Register("PSPDFAction", true)]
	public unsafe partial class PSPDFAction : PSPDFModel, IPSPDFJSONSerializing {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAction () : base (NSObjectFlag.Empty)
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
		public PSPDFAction (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFAction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("actionClassForType:")]
		[CompilerGenerated]
		public static Class ActionClassForType (PSPDFActionType actionType)
		{
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_byte (class_ptr, Selector.GetHandle ("actionClassForType:"), (byte)actionType);
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("classForParsingJSONDictionary:")]
		[CompilerGenerated]
		public virtual Class ClassForParsingJSONDictionary (NSDictionary JSONDictionary)
		{
			if (JSONDictionary == null)
				throw new ArgumentNullException ("JSONDictionary");
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("classForParsingJSONDictionary:"), JSONDictionary.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("classForParsingJSONDictionary:"), JSONDictionary.Handle);
			}
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("JSONKeyPathsByPropertyKey")]
		[CompilerGenerated]
		public virtual NSDictionary JSONKeyPathsByPropertyKey ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("JSONKeyPathsByPropertyKey")));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("JSONKeyPathsByPropertyKey")));
			}
		}
		
		[Export ("JSONTransformerForKey:")]
		[CompilerGenerated]
		public virtual NSObject JSONTransformerForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("JSONTransformerForKey:"), nskey));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("JSONTransformerForKey:"), nskey));
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("localizedDescriptionWithDocumentProvider:")]
		[CompilerGenerated]
		public virtual string LocalizedDescription (PSPDFDocumentProvider documentProvider)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("localizedDescriptionWithDocumentProvider:"), documentProvider == null ? IntPtr.Zero : documentProvider.Handle));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("localizedDescriptionWithDocumentProvider:"), documentProvider == null ? IntPtr.Zero : documentProvider.Handle));
			}
		}
		
		[CompilerGenerated]
		object __mt_NextAction_var;
		[CompilerGenerated]
		public virtual PSPDFAction NextAction {
			[Export ("nextAction", ArgumentSemantic.Retain)]
			get {
				PSPDFAction ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAction> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("nextAction")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAction> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nextAction")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NextAction_var = ret;
				return ret;
			}
			
			[Export ("setNextAction:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNextAction:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNextAction:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_NextAction_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Options_var;
		[CompilerGenerated]
		public virtual NSDictionary Options {
			[Export ("options", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("options")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("options")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Options_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFActionType Type {
			[Export ("type", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (PSPDFActionType) global::ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				} else {
					return (PSPDFActionType) global::ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _ActionTypeTransformerName;
		[Field ("PSPDFActionTypeTransformerName",  "__Internal")]
		public static unsafe NSString ActionTypeTransformerName {
			get {
				if (_ActionTypeTransformerName == null)
					_ActionTypeTransformerName = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionTypeTransformerName");
				return _ActionTypeTransformerName;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_NextAction_var = null;
				__mt_Options_var = null;
			}
		}
	} /* class PSPDFAction */
}
