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
	[Register("PSPDFAnnotationGroup", true)]
	public unsafe partial class PSPDFAnnotationGroup : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationGroup");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationGroup () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationGroup (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationGroup (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("groupWithItems:")]
		[CompilerGenerated]
		public static PSPDFAnnotationGroup FromItems (PSPDFAnnotationGroupItem[] items)
		{
			if (items == null)
				throw new ArgumentNullException ("items");
			var nsa_items = NSArray.FromNSObjects (items);
			
			PSPDFAnnotationGroup ret;
			ret =  Runtime.GetNSObject<PSPDFAnnotationGroup> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("groupWithItems:"), nsa_items.Handle));
			nsa_items.Dispose ();
			
			return ret;
		}
		
		[Export ("groupWithItems:choice:")]
		[CompilerGenerated]
		public static PSPDFAnnotationGroup FromItems (PSPDFAnnotationGroupItem[] items, global::System.nuint choice)
		{
			if (items == null)
				throw new ArgumentNullException ("items");
			var nsa_items = NSArray.FromNSObjects (items);
			
			PSPDFAnnotationGroup ret;
			ret =  Runtime.GetNSObject<PSPDFAnnotationGroup> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (class_ptr, Selector.GetHandle ("groupWithItems:choice:"), nsa_items.Handle, choice));
			nsa_items.Dispose ();
			
			return ret;
		}
		
		[Export ("updateChoiceToItemWithType:variant:")]
		[CompilerGenerated]
		public virtual bool UpdateChoiceToItem (NSString annotationStringType, NSString variant)
		{
			if (annotationStringType == null)
				throw new ArgumentNullException ("annotationStringType");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateChoiceToItemWithType:variant:"), annotationStringType.Handle, variant == null ? IntPtr.Zero : variant.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateChoiceToItemWithType:variant:"), annotationStringType.Handle, variant == null ? IntPtr.Zero : variant.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Choice {
			[Export ("choice", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("choice"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("choice"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_EditableItems_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationGroupItem[] EditableItems {
			[Export ("editableItems", ArgumentSemantic.Copy)]
			get {
				PSPDFAnnotationGroupItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotationGroupItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("editableItems")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotationGroupItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("editableItems")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_EditableItems_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Items_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationGroupItem[] Items {
			[Export ("items", ArgumentSemantic.Copy)]
			get {
				PSPDFAnnotationGroupItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotationGroupItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("items")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotationGroupItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("items")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Items_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_EditableItems_var = null;
				__mt_Items_var = null;
			}
		}
	} /* class PSPDFAnnotationGroup */
}
