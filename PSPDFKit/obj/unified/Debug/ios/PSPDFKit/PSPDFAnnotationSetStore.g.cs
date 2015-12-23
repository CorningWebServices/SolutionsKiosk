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
	[Protocol (Name = "PSPDFAnnotationSetStore", WrapperType = typeof (PSPDFAnnotationSetStoreWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnnotationSets", Selector = "annotationSets", ReturnType = typeof (PSPDFKit.PSPDFAnnotationSet[]))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetAnnotationSets", Selector = "setAnnotationSets:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationSet[]) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFAnnotationSetStore : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFAnnotationSetStore_Extensions {
		[CompilerGenerated]
		public static PSPDFAnnotationSet[] GetAnnotationSets (this IPSPDFAnnotationSetStore This)
		{
			return NSArray.ArrayFromHandle<PSPDFAnnotationSet>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("annotationSets")));
		}
		
		[CompilerGenerated]
		public static void SetAnnotationSets (this IPSPDFAnnotationSetStore This, PSPDFAnnotationSet[] annotationSets)
		{
			if (annotationSets == null)
				throw new ArgumentNullException ("annotationSets");
			var nsa_annotationSets = NSArray.FromNSObjects (annotationSets);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAnnotationSets:"), nsa_annotationSets.Handle);
			nsa_annotationSets.Dispose ();
			
		}
		
	}
	
	internal sealed class PSPDFAnnotationSetStoreWrapper : BaseWrapper, IPSPDFAnnotationSetStore {
		public PSPDFAnnotationSetStoreWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationSetStoreWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAnnotationSetStore", false)]
	[Model]
	public unsafe partial class PSPDFAnnotationSetStore : NSObject, IPSPDFAnnotationSetStore {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFAnnotationSetStore () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationSetStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationSetStore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("annotationSets")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationSet[] GetAnnotationSets ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setAnnotationSets:")]
		[CompilerGenerated]
		public virtual void SetAnnotationSets (PSPDFAnnotationSet[] annotationSets)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFAnnotationSetStore */
}
