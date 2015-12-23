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
	[Register("PSPDFAbstractLineAnnotation", true)]
	public unsafe partial class PSPDFAbstractLineAnnotation : PSPDFAnnotation {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAbstractLineAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAbstractLineAnnotation () : base (NSObjectFlag.Empty)
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
		public PSPDFAbstractLineAnnotation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFAbstractLineAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAbstractLineAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPoints:")]
		[CompilerGenerated]
		public PSPDFAbstractLineAnnotation (NSValue[] points)
			: base (NSObjectFlag.Empty)
		{
			if (points == null)
				throw new ArgumentNullException ("points");
			var nsa_points = NSArray.FromNSObjects (points);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithPoints:"), nsa_points.Handle), "initWithPoints:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithPoints:"), nsa_points.Handle), "initWithPoints:");
			}
			nsa_points.Dispose ();
			
		}
		
		[Export ("recalculateBoundingBox")]
		[CompilerGenerated]
		public virtual void RecalculateBoundingBox ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("recalculateBoundingBox"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recalculateBoundingBox"));
			}
		}
		
		[Export ("setBoundingBox:transformPoints:")]
		[CompilerGenerated]
		public virtual void SetBoundingBox (CGRect boundingBox, bool transformPoints)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect_bool (this.Handle, Selector.GetHandle ("setBoundingBox:transformPoints:"), boundingBox, transformPoints);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect_bool (this.SuperHandle, Selector.GetHandle ("setBoundingBox:transformPoints:"), boundingBox, transformPoints);
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
		public virtual PSPDFLineEndType LineEnd1 {
			[Export ("lineEnd1", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFLineEndType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd1"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd1"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd1"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd1"));
					}
				}
				return ret;
			}
			
			[Export ("setLineEnd1:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLineEnd1:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLineEnd1:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLineEnd1:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLineEnd1:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd2 {
			[Export ("lineEnd2", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFLineEndType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd2"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd2"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd2"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd2"));
					}
				}
				return ret;
			}
			
			[Export ("setLineEnd2:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLineEnd2:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLineEnd2:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLineEnd2:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLineEnd2:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BezierPath_var = null;
			}
		}
	} /* class PSPDFAbstractLineAnnotation */
}
