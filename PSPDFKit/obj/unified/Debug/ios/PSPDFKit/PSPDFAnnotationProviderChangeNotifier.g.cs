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
	[Protocol (Name = "PSPDFAnnotationProviderChangeNotifier", WrapperType = typeof (PSPDFAnnotationProviderChangeNotifierWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateAnnotations", Selector = "updateAnnotations:animated:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotation[]), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ParentDocumentProvider", Selector = "parentDocumentProvider", ReturnType = typeof (PSPDFKit.PSPDFDocumentProvider))]
	public interface IPSPDFAnnotationProviderChangeNotifier : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("updateAnnotations:animated:")]
		[Preserve (Conditional = true)]
		void UpdateAnnotations (PSPDFAnnotation[] annotations, bool animated);
		
		[CompilerGenerated]
		[Export ("parentDocumentProvider")]
		[Preserve (Conditional = true)]
		PSPDFDocumentProvider ParentDocumentProvider ();
		
	}
	
	internal sealed class PSPDFAnnotationProviderChangeNotifierWrapper : BaseWrapper, IPSPDFAnnotationProviderChangeNotifier {
		public PSPDFAnnotationProviderChangeNotifierWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationProviderChangeNotifierWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("updateAnnotations:animated:")]
		[CompilerGenerated]
		public void UpdateAnnotations (PSPDFAnnotation[] annotations, bool animated)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("updateAnnotations:animated:"), nsa_annotations.Handle, animated);
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("parentDocumentProvider")]
		[CompilerGenerated]
		public PSPDFDocumentProvider ParentDocumentProvider ()
		{
			return  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("parentDocumentProvider")));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAnnotationProviderChangeNotifier", false)]
	[Model]
	public unsafe abstract partial class PSPDFAnnotationProviderChangeNotifier : NSObject, IPSPDFAnnotationProviderChangeNotifier {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFAnnotationProviderChangeNotifier () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationProviderChangeNotifier (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationProviderChangeNotifier (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("parentDocumentProvider")]
		[CompilerGenerated]
		public abstract PSPDFDocumentProvider ParentDocumentProvider ();
		[Export ("updateAnnotations:animated:")]
		[CompilerGenerated]
		public abstract void UpdateAnnotations (PSPDFAnnotation[] annotations, bool animated);
	} /* class PSPDFAnnotationProviderChangeNotifier */
}
