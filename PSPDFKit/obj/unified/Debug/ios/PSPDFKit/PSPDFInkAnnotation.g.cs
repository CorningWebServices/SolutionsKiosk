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
	[Register("PSPDFInkAnnotation", true)]
	public unsafe partial class PSPDFInkAnnotation : PSPDFAnnotation {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFInkAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFInkAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFInkAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFInkAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFInkAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("copyLinesByApplyingTransform:")]
		[CompilerGenerated]
		public virtual NSValue[] CopyLinesByApplyingTransform (CGAffineTransform transform)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<NSValue>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGAffineTransform (this.Handle, Selector.GetHandle ("copyLinesByApplyingTransform:"), transform));
			} else {
				return NSArray.ArrayFromHandle<NSValue>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform (this.SuperHandle, Selector.GetHandle ("copyLinesByApplyingTransform:"), transform));
			}
		}
		
		[Export ("initWithLines:")]
		[CompilerGenerated]
		internal virtual global::System.IntPtr InitWithLines (NSArray lines)
		{
			if (lines == null)
				throw new ArgumentNullException ("lines");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithLines:"), lines.Handle);
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithLines:"), lines.Handle);
			}
		}
		
		[Export ("setBoundingBox:transformLines:")]
		[CompilerGenerated]
		public virtual void SetBoundingBox (CGRect boundingBox, bool transformLines)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect_bool (this.Handle, Selector.GetHandle ("setBoundingBox:transformLines:"), boundingBox, transformLines);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect_bool (this.SuperHandle, Selector.GetHandle ("setBoundingBox:transformLines:"), boundingBox, transformLines);
			}
		}
		
		[CompilerGenerated]
		object __mt__Lines_var;
		[CompilerGenerated]
		internal virtual NSArray _Lines {
			[Export ("lines", ArgumentSemantic.Copy)]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lines")));
				} else {
					ret =  Runtime.GetNSObject<NSArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lines")));
				}
				if (!IsNewRefcountEnabled ())
					__mt__Lines_var = ret;
				return ret;
			}
			
			[Export ("setLines:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLines:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLines:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt__Lines_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BezierPath_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIBezierPath BezierPath {
			[Export ("bezierPath", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIBezierPath ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBezierPath> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bezierPath")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBezierPath> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bezierPath")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BezierPath_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsEmpty {
			[Export ("isEmpty", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEmpty"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEmpty"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsSignature {
			[Export ("isSignature", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSignature"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSignature"));
				}
			}
			
			[Export ("setIsSignature:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsSignature:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsSignature:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool NaturalDrawingEnabled {
			[Export ("naturalDrawingEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("naturalDrawingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("naturalDrawingEnabled"));
				}
			}
			
			[Export ("setNaturalDrawingEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setNaturalDrawingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setNaturalDrawingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt__Lines_var = null;
				__mt_BezierPath_var = null;
			}
		}
	} /* class PSPDFInkAnnotation */
}
