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
	[Register("PSPDFTabBarView", true)]
	public unsafe partial class PSPDFTabBarView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFTabBarView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFTabBarView () : base (NSObjectFlag.Empty)
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
		public PSPDFTabBarView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFTabBarView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTabBarView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadData"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reloadData"));
			}
		}
		
		[Export ("scrollToTabAtIndex:animated:")]
		[CompilerGenerated]
		public virtual void ScrollToTab (global::System.nuint index, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("scrollToTabAtIndex:animated:"), index, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("scrollToTabAtIndex:animated:"), index, animated);
			}
		}
		
		[Export ("selectTabAtIndex:animated:")]
		[CompilerGenerated]
		public virtual void SelectTab (global::System.nuint index, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("selectTabAtIndex:animated:"), index, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("selectTabAtIndex:animated:"), index, animated);
			}
		}
		
		[Export ("selectTabAtIndex:animated:callDelegate:")]
		[CompilerGenerated]
		public virtual void SelectTab (global::System.nuint index, bool animated, bool callDelegate)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_bool_bool (this.Handle, Selector.GetHandle ("selectTabAtIndex:animated:callDelegate:"), index, animated, callDelegate);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_bool_bool (this.SuperHandle, Selector.GetHandle ("selectTabAtIndex:animated:callDelegate:"), index, animated, callDelegate);
			}
		}
		
		[CompilerGenerated]
		object __mt_DataSource_var;
		[CompilerGenerated]
		public virtual IPSPDFTabBarViewDataSource DataSource {
			[Export ("dataSource", ArgumentSemantic.Weak)]
			get {
				IPSPDFTabBarViewDataSource ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFTabBarViewDataSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFTabBarViewDataSource> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataSource")), false);
				}
				MarkDirty ();
				__mt_DataSource_var = ret;
				return ret;
			}
			
			[Export ("setDataSource:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDataSource:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDataSource:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_DataSource_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFTabBarViewDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFTabBarViewDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFTabBarViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFTabBarViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat MinTabWidth {
			[Export ("minTabWidth", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("minTabWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minTabWidth"));
				}
			}
			
			[Export ("setMinTabWidth:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMinTabWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMinTabWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIScrollView ScrollView {
			[Export ("scrollView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint SelectedTabIndex {
			[Export ("selectedTabIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("selectedTabIndex"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedTabIndex"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DataSource_var = null;
				__mt_Delegate_var = null;
				__mt_ScrollView_var = null;
			}
		}
		public partial class PSPDFTabBarViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFTabBarViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFTabBarViewAppearance Appearance {
			get { return new PSPDFTabBarViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFTabBarViewAppearance GetAppearance<T> () where T: PSPDFTabBarView {
			return new PSPDFTabBarViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFTabBarViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFTabBarViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFTabBarViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFTabBarViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFTabBarViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFTabBarViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFTabBarViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFTabBarView {
			return new PSPDFTabBarViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFTabBarViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFTabBarView{
			return new PSPDFTabBarViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFTabBarView */
}
