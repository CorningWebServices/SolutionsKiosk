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
	[Register("PSPDFOutlineElement", true)]
	public unsafe partial class PSPDFOutlineElement : PSPDFBookmark {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFOutlineElement");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFOutlineElement () : base (NSObjectFlag.Empty)
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
		public PSPDFOutlineElement (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFOutlineElement (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFOutlineElement (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTitle:color:fontTraits:action:children:level:")]
		[CompilerGenerated]
		public PSPDFOutlineElement (string title, global::UIKit.UIColor color, global::UIKit.UIFontDescriptorSymbolicTraits fontTraits, PSPDFAction action, PSPDFOutlineElement[] children, global::System.nuint level)
			: base (NSObjectFlag.Empty)
		{
			var nstitle = NSString.CreateNative (title);
			var nsa_children = children == null ? null : NSArray.FromNSObjects (children);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr_IntPtr_nuint (this.Handle, Selector.GetHandle ("initWithTitle:color:fontTraits:action:children:level:"), nstitle, color == null ? IntPtr.Zero : color.Handle, (UInt32)fontTraits, action == null ? IntPtr.Zero : action.Handle, nsa_children == null ? IntPtr.Zero : nsa_children.Handle, level), "initWithTitle:color:fontTraits:action:children:level:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("initWithTitle:color:fontTraits:action:children:level:"), nstitle, color == null ? IntPtr.Zero : color.Handle, (UInt32)fontTraits, action == null ? IntPtr.Zero : action.Handle, nsa_children == null ? IntPtr.Zero : nsa_children.Handle, level), "initWithTitle:color:fontTraits:action:children:level:");
			}
			NSString.ReleaseNative (nstitle);
			if (nsa_children != null)
				nsa_children.Dispose ();
			
		}
		
		[CompilerGenerated]
		object __mt_AllFlattenedChildren_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineElement[] AllFlattenedChildren {
			[Export ("allFlattenedChildren")]
			get {
				PSPDFOutlineElement[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFOutlineElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allFlattenedChildren")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFOutlineElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allFlattenedChildren")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AllFlattenedChildren_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Children_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineElement[] Children {
			[Export ("children", ArgumentSemantic.Copy)]
			get {
				PSPDFOutlineElement[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFOutlineElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("children")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFOutlineElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("children")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Children_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Color_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor Color {
			[Export ("color", ArgumentSemantic.Retain)]
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
		public virtual bool Expanded {
			[Export ("isExpanded", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isExpanded"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isExpanded"));
				}
			}
			
			[Export ("setExpanded:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setExpanded:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setExpanded:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_FlattenedChildren_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineElement[] FlattenedChildren {
			[Export ("flattenedChildren")]
			get {
				PSPDFOutlineElement[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFOutlineElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("flattenedChildren")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFOutlineElement>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("flattenedChildren")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FlattenedChildren_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIFontDescriptorSymbolicTraits FontTraits {
			[Export ("fontTraits", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (global::UIKit.UIFontDescriptorSymbolicTraits) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("fontTraits"));
				} else {
					return (global::UIKit.UIFontDescriptorSymbolicTraits) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fontTraits"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Level {
			[Export ("level", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("level"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("level"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AllFlattenedChildren_var = null;
				__mt_Children_var = null;
				__mt_Color_var = null;
				__mt_FlattenedChildren_var = null;
			}
		}
	} /* class PSPDFOutlineElement */
}
