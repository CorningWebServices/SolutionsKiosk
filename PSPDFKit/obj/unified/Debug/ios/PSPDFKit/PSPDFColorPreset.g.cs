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
	[Register("PSPDFColorPreset", true)]
	public unsafe partial class PSPDFColorPreset : PSPDFModel {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFColorPreset");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFColorPreset (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFColorPreset (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFColorPreset (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("presetWithColor:")]
		[CompilerGenerated]
		public static PSPDFColorPreset FromColor (global::UIKit.UIColor color)
		{
			return  Runtime.GetNSObject<PSPDFColorPreset> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("presetWithColor:"), color == null ? IntPtr.Zero : color.Handle));
		}
		
		[Export ("presetWithColor:fillColor:alpha:")]
		[CompilerGenerated]
		public static PSPDFColorPreset FromColor (global::UIKit.UIColor color, global::UIKit.UIColor fillColor, global::System.nfloat alpha)
		{
			return  Runtime.GetNSObject<PSPDFColorPreset> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nfloat (class_ptr, Selector.GetHandle ("presetWithColor:fillColor:alpha:"), color == null ? IntPtr.Zero : color.Handle, fillColor == null ? IntPtr.Zero : fillColor.Handle, alpha));
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Alpha {
			[Export ("alpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("alpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alpha"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Color_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor Color {
			[Export ("color")]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("color")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("color")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FillColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor FillColor {
			[Export ("fillColor")]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fillColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fillColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FillColor_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Color_var = null;
				__mt_FillColor_var = null;
			}
		}
	} /* class PSPDFColorPreset */
}
