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
	[Register("PSPDFTextFieldFormElement", true)]
	public unsafe partial class PSPDFTextFieldFormElement : PSPDFFormElement {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextFieldFormElement");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTextFieldFormElement () : base (NSObjectFlag.Empty)
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
		public PSPDFTextFieldFormElement (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFTextFieldFormElement (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTextFieldFormElement (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("formattedContents")]
		[CompilerGenerated]
		public virtual string FormattedContents ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("formattedContents")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formattedContents")));
			}
		}
		
		[Export ("textFieldChangedWithContents:change:range:isFinal:application:error:")]
		[CompilerGenerated]
		public virtual string TextFieldChanged (string contents, string change, NSRange range, bool isFinal, NSObject application, out NSError validationError)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (change == null)
				throw new ArgumentNullException ("change");
			IntPtr validationErrorValue = IntPtr.Zero;
			
			var nscontents = NSString.CreateNative (contents);
			var nschange = NSString.CreateNative (change);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_NSRange_bool_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("textFieldChangedWithContents:change:range:isFinal:application:error:"), nscontents, nschange, range, isFinal, application == null ? IntPtr.Zero : application.Handle, ref validationErrorValue));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_NSRange_bool_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("textFieldChangedWithContents:change:range:isFinal:application:error:"), nscontents, nschange, range, isFinal, application == null ? IntPtr.Zero : application.Handle, ref validationErrorValue));
			}
			NSString.ReleaseNative (nscontents);
			NSString.ReleaseNative (nschange);
			
			
			validationError = validationErrorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (validationErrorValue) : null;
			return ret;
		}
		
		[CompilerGenerated]
		public virtual PSPDFTextInputFormat InputFormat {
			[Export ("inputFormat", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFTextInputFormat ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextInputFormat) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("inputFormat"));
					} else {
						ret = (PSPDFTextInputFormat) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("inputFormat"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextInputFormat) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputFormat"));
					} else {
						ret = (PSPDFTextInputFormat) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputFormat"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsPassword {
			[Export ("isPassword")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPassword"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPassword"));
				}
			}
			
		}
		
	} /* class PSPDFTextFieldFormElement */
}
