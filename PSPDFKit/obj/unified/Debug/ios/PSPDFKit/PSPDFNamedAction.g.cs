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
	[Register("PSPDFNamedAction", true)]
	public unsafe partial class PSPDFNamedAction : PSPDFAction {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFNamedAction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFNamedAction () : base (NSObjectFlag.Empty)
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
		public PSPDFNamedAction (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFNamedAction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFNamedAction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithActionNamedString:")]
		[CompilerGenerated]
		public PSPDFNamedAction (string actionNameString)
			: base (NSObjectFlag.Empty)
		{
			if (actionNameString == null)
				throw new ArgumentNullException ("actionNameString");
			var nsactionNameString = NSString.CreateNative (actionNameString);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithActionNamedString:"), nsactionNameString), "initWithActionNamedString:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithActionNamedString:"), nsactionNameString), "initWithActionNamedString:");
			}
			NSString.ReleaseNative (nsactionNameString);
			
		}
		
		[Export ("pageIndexWithCurrentPage:fromDocument:")]
		[CompilerGenerated]
		public virtual global::System.nuint PageIndexWithCurrentPage (global::System.nuint currentPage, PSPDFDocument document)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint_IntPtr (this.Handle, Selector.GetHandle ("pageIndexWithCurrentPage:fromDocument:"), currentPage, document.Handle);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("pageIndexWithCurrentPage:fromDocument:"), currentPage, document.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string NamedAction {
			[Export ("namedAction")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("namedAction")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("namedAction")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFNamedActionType NamedActionType {
			[Export ("namedActionType", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFNamedActionType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFNamedActionType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("namedActionType"));
					} else {
						ret = (PSPDFNamedActionType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("namedActionType"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFNamedActionType) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFNamedActionType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("namedActionType"));
					} else {
						ret = (PSPDFNamedActionType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("namedActionType"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFNamedActionType) ulong.MaxValue;
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _TypeTransformerName;
		[Field ("PSPDFNamedActionTypeTransformerName",  "__Internal")]
		public static unsafe NSString TypeTransformerName {
			get {
				if (_TypeTransformerName == null)
					_TypeTransformerName = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFNamedActionTypeTransformerName");
				return _TypeTransformerName;
			}
		}
	} /* class PSPDFNamedAction */
}
