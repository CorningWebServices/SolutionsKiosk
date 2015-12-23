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
	[Register("PSPDFBackForwardActionList", true)]
	public unsafe partial class PSPDFBackForwardActionList : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBackForwardActionList");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFBackForwardActionList () : base (NSObjectFlag.Empty)
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
		protected PSPDFBackForwardActionList (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFBackForwardActionList (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:")]
		[CompilerGenerated]
		public PSPDFBackForwardActionList (IPSPDFBackForwardActionListDelegate del)
			: base (NSObjectFlag.Empty)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDelegate:"), del.Handle), "initWithDelegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDelegate:"), del.Handle), "initWithDelegate:");
			}
		}
		
		[Export ("registerAction:")]
		[CompilerGenerated]
		public virtual void RegisterAction (PSPDFAction action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerAction:"), action.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerAction:"), action.Handle);
			}
		}
		
		[Export ("requestBack")]
		[CompilerGenerated]
		public virtual void RequestBack ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestBack"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestBack"));
			}
		}
		
		[Export ("requestBackToAction:")]
		[CompilerGenerated]
		public virtual void RequestBack (PSPDFAction action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("requestBackToAction:"), action.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("requestBackToAction:"), action.Handle);
			}
		}
		
		[Export ("requestForward")]
		[CompilerGenerated]
		public virtual void RequestForward ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestForward"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestForward"));
			}
		}
		
		[Export ("requestForwardToAction:")]
		[CompilerGenerated]
		public virtual void RequestForward (PSPDFAction action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("requestForwardToAction:"), action.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("requestForwardToAction:"), action.Handle);
			}
		}
		
		[Export ("reset")]
		[CompilerGenerated]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reset"));
			}
		}
		
		[Export ("resetBackList")]
		[CompilerGenerated]
		public virtual void ResetBackList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetBackList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetBackList"));
			}
		}
		
		[Export ("resetForwardList")]
		[CompilerGenerated]
		public virtual void ResetForwardList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetForwardList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetForwardList"));
			}
		}
		
		[CompilerGenerated]
		object __mt_BackAction_var;
		[CompilerGenerated]
		public virtual PSPDFAction BackAction {
			[Export ("backAction", ArgumentSemantic.Retain)]
			get {
				PSPDFAction ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAction> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backAction")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAction> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backAction")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackAction_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BackList_var;
		[CompilerGenerated]
		public virtual PSPDFAction[] BackList {
			[Export ("backList", ArgumentSemantic.Copy)]
			get {
				PSPDFAction[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAction>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backList")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAction>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backList")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackList_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint BackListCap {
			[Export ("backListCap", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("backListCap"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backListCap"));
				}
			}
			
			[Export ("setBackListCap:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setBackListCap:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setBackListCap:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFBackForwardActionListDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFBackForwardActionListDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFBackForwardActionListDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFBackForwardActionListDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
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
		object __mt_ForwardAction_var;
		[CompilerGenerated]
		public virtual PSPDFAction ForwardAction {
			[Export ("forwardAction", ArgumentSemantic.Retain)]
			get {
				PSPDFAction ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAction> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("forwardAction")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAction> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("forwardAction")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ForwardAction_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ForwardList_var;
		[CompilerGenerated]
		public virtual PSPDFAction[] ForwardList {
			[Export ("forwardList", ArgumentSemantic.Copy)]
			get {
				PSPDFAction[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAction>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("forwardList")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAction>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("forwardList")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ForwardList_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BackAction_var = null;
				__mt_BackList_var = null;
				__mt_Delegate_var = null;
				__mt_ForwardAction_var = null;
				__mt_ForwardList_var = null;
			}
		}
	} /* class PSPDFBackForwardActionList */
}
