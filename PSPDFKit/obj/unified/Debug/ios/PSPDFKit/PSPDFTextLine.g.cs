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
	[Register("PSPDFTextLine", true)]
	public unsafe partial class PSPDFTextLine : PSPDFWord {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTextLine");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTextLine () : base (NSObjectFlag.Empty)
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
		protected PSPDFTextLine (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTextLine (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.nint BlockId {
			[Export ("blockID", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("blockID"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("blockID"));
				}
			}
			
			[Export ("setBlockID:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setBlockID:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setBlockID:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFTextLineBorder BorderType {
			[Export ("borderType", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFTextLineBorder ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextLineBorder) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("borderType"));
					} else {
						ret = (PSPDFTextLineBorder) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("borderType"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextLineBorder) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderType"));
					} else {
						ret = (PSPDFTextLineBorder) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("borderType"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_NextLine_var;
		[CompilerGenerated]
		public virtual PSPDFTextLine NextLine {
			[Export ("nextLine", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFTextLine ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFTextLine> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("nextLine")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFTextLine> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nextLine")));
				}
				MarkDirty ();
				__mt_NextLine_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PrevLine_var;
		[CompilerGenerated]
		public virtual PSPDFTextLine PrevLine {
			[Export ("prevLine", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFTextLine ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFTextLine> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("prevLine")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFTextLine> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prevLine")));
				}
				MarkDirty ();
				__mt_PrevLine_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_NextLine_var = null;
				__mt_PrevLine_var = null;
			}
		}
	} /* class PSPDFTextLine */
}
