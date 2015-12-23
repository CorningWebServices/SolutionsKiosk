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
	[Register("PSPDFOutlineCell", true)]
	public unsafe partial class PSPDFOutlineCell : PSPDFTableViewCell {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineCell");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOutlineCell () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFOutlineCell (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFOutlineCell (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("configureWithOutlineElement:documentProvider:")]
		[CompilerGenerated]
		public virtual void Configure (PSPDFOutlineElement outlineElement, PSPDFDocumentProvider documentProvider)
		{
			if (outlineElement == null)
				throw new ArgumentNullException ("outlineElement");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("configureWithOutlineElement:documentProvider:"), outlineElement.Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("configureWithOutlineElement:documentProvider:"), outlineElement.Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle);
			}
		}
		
		[Export ("expandOrCollapse")]
		[CompilerGenerated]
		public virtual void ExpandOrCollapse ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("expandOrCollapse"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expandOrCollapse"));
			}
		}
		
		[Export ("fontForOutlineElement:")]
		[CompilerGenerated]
		public static global::UIKit.UIFont FontForOutlineElement (PSPDFOutlineElement outlineElement)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("fontForOutlineElement:"), outlineElement == null ? IntPtr.Zero : outlineElement.Handle));
		}
		
		[Export ("heightForCellWithOutlineElement:documentProvider:constrainedToSize:outlineIntentLeftOffset:outlineIntentMultiplier:showPageLabel:")]
		[CompilerGenerated]
		public static global::System.nfloat HeightForCellWithOutlineElement (PSPDFOutlineElement outlineElement, PSPDFDocumentProvider documentProvider, CGSize constraintSize, global::System.nfloat leftOffset, global::System.nfloat multiplier, bool showPageLabel)
		{
			if (outlineElement == null)
				throw new ArgumentNullException ("outlineElement");
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend_IntPtr_IntPtr_CGSize_nfloat_nfloat_bool (class_ptr, Selector.GetHandle ("heightForCellWithOutlineElement:documentProvider:constrainedToSize:outlineIntentLeftOffset:outlineIntentMultiplier:showPageLabel:"), outlineElement.Handle, documentProvider == null ? IntPtr.Zero : documentProvider.Handle, constraintSize, leftOffset, multiplier, showPageLabel);
		}
		
		[Export ("updateDisclosureButton")]
		[CompilerGenerated]
		public virtual void UpdateDisclosureButton ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateDisclosureButton"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateDisclosureButton"));
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFOutlineCellDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFOutlineCellDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFOutlineCellDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFOutlineCellDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_DisclosureButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton DisclosureButton {
			[Export ("disclosureButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("disclosureButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disclosureButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DisclosureButton_var = ret;
				return ret;
			}
			
			[Export ("setDisclosureButton:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisclosureButton:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDisclosureButton:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DisclosureButton_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_OutlineElement_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineElement OutlineElement {
			[Export ("outlineElement", ArgumentSemantic.Retain)]
			get {
				PSPDFOutlineElement ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFOutlineElement> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outlineElement")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFOutlineElement> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("outlineElement")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OutlineElement_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat OutlineIndentMultiplier {
			[Export ("outlineIndentMultiplier", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("outlineIndentMultiplier"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("outlineIndentMultiplier"));
				}
			}
			
			[Export ("setOutlineIndentMultiplier:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setOutlineIndentMultiplier:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setOutlineIndentMultiplier:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat OutlineIntentLeftOffset {
			[Export ("outlineIntentLeftOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("outlineIntentLeftOffset"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("outlineIntentLeftOffset"));
				}
			}
			
			[Export ("setOutlineIntentLeftOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setOutlineIntentLeftOffset:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setOutlineIntentLeftOffset:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PageLabel_var;
		[CompilerGenerated]
		public virtual global::UIKit.UILabel PageLabel {
			[Export ("pageLabel", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UILabel ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageLabel")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageLabel")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageLabel_var = ret;
				return ret;
			}
			
			[Export ("setPageLabel:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPageLabel:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPageLabel:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageLabel_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string PageLabelString {
			[Export ("pageLabelString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageLabelString")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageLabelString")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShowExpandCollapseButton {
			[Export ("showExpandCollapseButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showExpandCollapseButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showExpandCollapseButton"));
				}
			}
			
			[Export ("setShowExpandCollapseButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowExpandCollapseButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowExpandCollapseButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowPageLabel {
			[Export ("showPageLabel", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showPageLabel"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showPageLabel"));
				}
			}
			
			[Export ("setShowPageLabel:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowPageLabel:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowPageLabel:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_DisclosureButton_var = null;
				__mt_OutlineElement_var = null;
				__mt_PageLabel_var = null;
			}
		}
		public partial class PSPDFOutlineCellAppearance : global::PSPDFKit.PSPDFTableViewCell.PSPDFTableViewCellAppearance {
			protected internal PSPDFOutlineCellAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFOutlineCellAppearance Appearance {
			get { return new PSPDFOutlineCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFOutlineCellAppearance GetAppearance<T> () where T: PSPDFOutlineCell {
			return new PSPDFOutlineCellAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFOutlineCellAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFOutlineCellAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFOutlineCellAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFOutlineCellAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFOutlineCellAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFOutlineCellAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFOutlineCellAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFOutlineCell {
			return new PSPDFOutlineCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFOutlineCellAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFOutlineCell{
			return new PSPDFOutlineCellAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFOutlineCell */
}
