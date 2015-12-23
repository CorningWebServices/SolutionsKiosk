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
	[Register("PSPDFLabelParser", true)]
	public unsafe partial class PSPDFLabelParser : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFLabelParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFLabelParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFLabelParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:labels:")]
		[CompilerGenerated]
		public PSPDFLabelParser (PSPDFDocumentProvider documentProvider, NSDictionary labels)
			: base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDocumentProvider:labels:"), documentProvider.Handle, labels == null ? IntPtr.Zero : labels.Handle), "initWithDocumentProvider:labels:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocumentProvider:labels:"), documentProvider.Handle, labels == null ? IntPtr.Zero : labels.Handle), "initWithDocumentProvider:labels:");
			}
		}
		
		[Export ("pageForPageLabel:partialMatching:")]
		[CompilerGenerated]
		public virtual global::System.nuint GetPage (string pageLabel, bool partialMatching)
		{
			if (pageLabel == null)
				throw new ArgumentNullException ("pageLabel");
			var nspageLabel = NSString.CreateNative (pageLabel);
			
			global::System.nuint ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.nuint_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("pageForPageLabel:partialMatching:"), nspageLabel, partialMatching);
			} else {
				ret = global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("pageForPageLabel:partialMatching:"), nspageLabel, partialMatching);
			}
			NSString.ReleaseNative (nspageLabel);
			
			return ret;
		}
		
		[Export ("pageLabelForPage:")]
		[CompilerGenerated]
		public virtual string GetPageLabel (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("pageLabelForPage:"), page));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("pageLabelForPage:"), page));
			}
		}
		
		[CompilerGenerated]
		object __mt_DocumentProvider_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProvider {
			[Export ("documentProvider", ArgumentSemantic.Weak)]
			get {
				PSPDFDocumentProvider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentProvider")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentProvider")));
				}
				MarkDirty ();
				__mt_DocumentProvider_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Labels_var;
		[CompilerGenerated]
		public virtual NSDictionary Labels {
			[Export ("labels", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labels")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labels")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Labels_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DocumentProvider_var = null;
				__mt_Labels_var = null;
			}
		}
	} /* class PSPDFLabelParser */
}
