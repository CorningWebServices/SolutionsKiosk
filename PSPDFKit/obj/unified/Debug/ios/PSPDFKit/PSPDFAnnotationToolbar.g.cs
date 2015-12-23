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
	[Register("PSPDFAnnotationToolbar", true)]
	public unsafe partial class PSPDFAnnotationToolbar : PSPDFFlexibleToolbar, IPSPDFAnnotationStateManagerDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationToolbar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFAnnotationToolbar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationToolbar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationToolbar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAnnotationStateManager:")]
		[CompilerGenerated]
		public PSPDFAnnotationToolbar (PSPDFAnnotationStateManager annotationStateManager)
			: base (NSObjectFlag.Empty)
		{
			if (annotationStateManager == null)
				throw new ArgumentNullException ("annotationStateManager");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithAnnotationStateManager:"), annotationStateManager.Handle), "initWithAnnotationStateManager:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAnnotationStateManager:"), annotationStateManager.Handle), "initWithAnnotationStateManager:");
			}
		}
		
		[Export ("annotationGroupsOrGroupsFromEditableAnnotationTypes")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationGroup[] AnnotationGroupsOrGroupsFromEditableAnnotationTypes ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFAnnotationGroup>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationGroupsOrGroupsFromEditableAnnotationTypes")));
			} else {
				return NSArray.ArrayFromHandle<PSPDFAnnotationGroup>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationGroupsOrGroupsFromEditableAnnotationTypes")));
			}
		}
		
		[Export ("buttonWithType:variant:createFromGroup:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIButton ButtonFromType (NSString type, string variant, bool createFromGroup)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			var nsvariant = NSString.CreateNative (variant);
			
			global::UIKit.UIButton ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("buttonWithType:variant:createFromGroup:"), type.Handle, nsvariant, createFromGroup));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("buttonWithType:variant:createFromGroup:"), type.Handle, nsvariant, createFromGroup));
			}
			NSString.ReleaseNative (nsvariant);
			
			return ret;
		}
		
		[Export ("annotationStateManager:didChangeState:to:variant:to:")]
		[CompilerGenerated]
		public virtual void DidChangeState (PSPDFAnnotationStateManager manager, NSString state, NSString newState, NSString variant, NSString newVariant)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationStateManager:didChangeState:to:variant:to:"), manager.Handle, state == null ? IntPtr.Zero : state.Handle, newState == null ? IntPtr.Zero : newState.Handle, variant == null ? IntPtr.Zero : variant.Handle, newVariant == null ? IntPtr.Zero : newVariant.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationStateManager:didChangeState:to:variant:to:"), manager.Handle, state == null ? IntPtr.Zero : state.Handle, newState == null ? IntPtr.Zero : newState.Handle, variant == null ? IntPtr.Zero : variant.Handle, newVariant == null ? IntPtr.Zero : newVariant.Handle);
			}
		}
		
		[Export ("annotationStateManager:didChangeUndoState:redoState:")]
		[CompilerGenerated]
		public virtual void DidChangeUndoState (PSPDFAnnotationStateManager manager, bool undoEnabled, bool redoEnabled)
		{
			if (manager == null)
				throw new ArgumentNullException ("manager");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_bool (this.Handle, Selector.GetHandle ("annotationStateManager:didChangeUndoState:redoState:"), manager.Handle, undoEnabled, redoEnabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_bool (this.SuperHandle, Selector.GetHandle ("annotationStateManager:didChangeUndoState:redoState:"), manager.Handle, undoEnabled, redoEnabled);
			}
		}
		
		[Export ("done:")]
		[CompilerGenerated]
		public virtual void Done (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("done:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("done:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_AdditionalButtons_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton[] AdditionalButtons {
			[Export ("additionalButtons", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIButton[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("additionalButtons")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("additionalButtons")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalButtons_var = ret;
				return ret;
			}
			
			[Export ("setAdditionalButtons:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdditionalButtons:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdditionalButtons:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalButtons_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationGroups_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationGroup[] AnnotationGroups {
			[Export ("annotationGroups", ArgumentSemantic.Copy)]
			get {
				PSPDFAnnotationGroup[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotationGroup>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationGroups")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotationGroup>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationGroups")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationGroups_var = ret;
				return ret;
			}
			
			[Export ("setAnnotationGroups:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotationGroups:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotationGroups:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationGroups_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationStateManager_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationStateManager AnnotationStateManager {
			[Export ("annotationStateManager", ArgumentSemantic.Retain)]
			get {
				PSPDFAnnotationStateManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAnnotationStateManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationStateManager")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAnnotationStateManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationStateManager")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationStateManager_var = ret;
				return ret;
			}
			
			[Export ("setAnnotationStateManager:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotationStateManager:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotationStateManager:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationStateManager_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DoneButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton DoneButton {
			[Export ("doneButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("doneButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("doneButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DoneButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_EditableAnnotationTypes_var;
		[CompilerGenerated]
		public virtual NSObject EditableAnnotationTypes {
			[Export ("editableAnnotationTypes", ArgumentSemantic.Copy)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("editableAnnotationTypes")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("editableAnnotationTypes")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_EditableAnnotationTypes_var = ret;
				return ret;
			}
			
			[Export ("setEditableAnnotationTypes:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEditableAnnotationTypes:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEditableAnnotationTypes:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_EditableAnnotationTypes_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RedoButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton RedoButton {
			[Export ("redoButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("redoButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("redoButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RedoButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool SaveAfterToolbarHiding {
			[Export ("saveAfterToolbarHiding", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("saveAfterToolbarHiding"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("saveAfterToolbarHiding"));
				}
			}
			
			[Export ("setSaveAfterToolbarHiding:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSaveAfterToolbarHiding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSaveAfterToolbarHiding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_StrokeColorButton_var;
		[CompilerGenerated]
		public virtual PSPDFColorButton StrokeColorButton {
			[Export ("strokeColorButton", ArgumentSemantic.Retain)]
			get {
				PSPDFColorButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFColorButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("strokeColorButton")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFColorButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("strokeColorButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_StrokeColorButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_UndoButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton UndoButton {
			[Export ("undoButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("undoButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("undoButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UndoButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AdditionalButtons_var = null;
				__mt_AnnotationGroups_var = null;
				__mt_AnnotationStateManager_var = null;
				__mt_DoneButton_var = null;
				__mt_EditableAnnotationTypes_var = null;
				__mt_RedoButton_var = null;
				__mt_StrokeColorButton_var = null;
				__mt_UndoButton_var = null;
			}
		}
		public partial class PSPDFAnnotationToolbarAppearance : global::PSPDFKit.PSPDFFlexibleToolbar.PSPDFFlexibleToolbarAppearance {
			protected internal PSPDFAnnotationToolbarAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFAnnotationToolbarAppearance Appearance {
			get { return new PSPDFAnnotationToolbarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFAnnotationToolbarAppearance GetAppearance<T> () where T: PSPDFAnnotationToolbar {
			return new PSPDFAnnotationToolbarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFAnnotationToolbarAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFAnnotationToolbarAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFAnnotationToolbarAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFAnnotationToolbarAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFAnnotationToolbarAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFAnnotationToolbarAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFAnnotationToolbarAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFAnnotationToolbar {
			return new PSPDFAnnotationToolbarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFAnnotationToolbarAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFAnnotationToolbar{
			return new PSPDFAnnotationToolbarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFAnnotationToolbar */
}
