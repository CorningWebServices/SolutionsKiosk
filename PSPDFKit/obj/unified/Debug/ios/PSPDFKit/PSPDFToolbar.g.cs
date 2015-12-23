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
	[Register("PSPDFToolbar", true)]
	public unsafe partial class PSPDFToolbar : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFToolbar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFToolbar () : base (NSObjectFlag.Empty)
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
		public PSPDFToolbar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFToolbar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFToolbar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFToolbar (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("fixedDimension")]
		[CompilerGenerated]
		public virtual global::System.nfloat FixedDimension ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("fixedDimension"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fixedDimension"));
			}
		}
		
		[Export ("isHorizontal")]
		[CompilerGenerated]
		public virtual bool IsHorizontal ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHorizontal"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isHorizontal"));
			}
		}
		
		[Export ("layoutMainSubviews")]
		[CompilerGenerated]
		public virtual void LayoutMainSubviews ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("layoutMainSubviews"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("layoutMainSubviews"));
			}
		}
		
		[Export ("setButtons:animated:")]
		[CompilerGenerated]
		public virtual void SetButtons (PSPDFToolbarButton[] buttons, bool animated)
		{
			if (buttons == null)
				throw new ArgumentNullException ("buttons");
			var nsa_buttons = NSArray.FromNSObjects (buttons);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setButtons:animated:"), nsa_buttons.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setButtons:animated:"), nsa_buttons.Handle, animated);
			}
			nsa_buttons.Dispose ();
			
		}
		
		[Export ("setCollapsedButtonVisible:")]
		[CompilerGenerated]
		public virtual void SetCollapsedButtonVisible (bool visible)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCollapsedButtonVisible:"), visible);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCollapsedButtonVisible:"), visible);
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView BackgroundView {
			[Export ("backgroundView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundView_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BarTintColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BarTintColor {
			[Export ("barTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("barTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barTintColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarTintColor_var = ret;
				return ret;
			}
			
			[Export ("setBarTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBarTintColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBarTintColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarTintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Buttons_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton[] Buttons {
			[Export ("buttons", ArgumentSemantic.Copy)]
			get {
				PSPDFToolbarButton[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFToolbarButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttons")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFToolbarButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttons")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Buttons_var = ret;
				return ret;
			}
			
			[Export ("setButtons:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setButtons:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setButtons:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Buttons_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_CollapsedButton_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton CollapsedButton {
			[Export ("collapsedButton", ArgumentSemantic.Retain)]
			get {
				PSPDFToolbarButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("collapsedButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFToolbarButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("collapsedButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CollapsedButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CollapsedButtons_var;
		[CompilerGenerated]
		public virtual PSPDFToolbarButton[] CollapsedButtons {
			[Export ("collapsedButtons", ArgumentSemantic.Copy)]
			get {
				PSPDFToolbarButton[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFToolbarButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("collapsedButtons")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFToolbarButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("collapsedButtons")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CollapsedButtons_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView ContentView {
			[Export ("contentView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BackgroundView_var = null;
				__mt_BarTintColor_var = null;
				__mt_Buttons_var = null;
				__mt_CollapsedButton_var = null;
				__mt_CollapsedButtons_var = null;
				__mt_ContentView_var = null;
			}
		}
		public partial class PSPDFToolbarAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFToolbarAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFToolbarAppearance Appearance {
			get { return new PSPDFToolbarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFToolbarAppearance GetAppearance<T> () where T: PSPDFToolbar {
			return new PSPDFToolbarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFToolbarAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFToolbarAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFToolbarAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFToolbarAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFToolbarAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFToolbarAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFToolbarAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFToolbar {
			return new PSPDFToolbarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFToolbarAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFToolbar{
			return new PSPDFToolbarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFToolbar */
}
