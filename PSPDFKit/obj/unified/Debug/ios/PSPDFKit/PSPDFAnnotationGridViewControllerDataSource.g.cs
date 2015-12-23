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
	[Protocol (Name = "PSPDFAnnotationGridViewControllerDataSource", WrapperType = typeof (PSPDFAnnotationGridViewControllerDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfSectionsInAnnotationGridViewController", Selector = "numberOfSectionsInAnnotationGridViewController:", ReturnType = typeof (nint), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationGridViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfAnnotationsInSection", Selector = "annotationGridViewController:numberOfAnnotationsInSection:", ReturnType = typeof (nint), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationGridViewController), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AnnotationSetForIndexPath", Selector = "annotationGridViewController:annotationSetForIndexPath:", ReturnType = typeof (PSPDFKit.PSPDFAnnotationSet), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationGridViewController), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFAnnotationGridViewControllerDataSource : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("numberOfSectionsInAnnotationGridViewController:")]
		[Preserve (Conditional = true)]
		global::System.nint NumberOfSectionsInAnnotationGridViewController (PSPDFAnnotationGridViewController annotationGridController);
		
		[CompilerGenerated]
		[Export ("annotationGridViewController:numberOfAnnotationsInSection:")]
		[Preserve (Conditional = true)]
		global::System.nint NumberOfAnnotationsInSection (PSPDFAnnotationGridViewController annotationGridController, global::System.nint section);
		
		[CompilerGenerated]
		[Export ("annotationGridViewController:annotationSetForIndexPath:")]
		[Preserve (Conditional = true)]
		PSPDFAnnotationSet AnnotationSetForIndexPath (PSPDFAnnotationGridViewController annotationGridController, NSIndexPath indexPath);
		
	}
	
	internal sealed class PSPDFAnnotationGridViewControllerDataSourceWrapper : BaseWrapper, IPSPDFAnnotationGridViewControllerDataSource {
		public PSPDFAnnotationGridViewControllerDataSourceWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationGridViewControllerDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("numberOfSectionsInAnnotationGridViewController:")]
		[CompilerGenerated]
		public global::System.nint NumberOfSectionsInAnnotationGridViewController (PSPDFAnnotationGridViewController annotationGridController)
		{
			if (annotationGridController == null)
				throw new ArgumentNullException ("annotationGridController");
			return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("numberOfSectionsInAnnotationGridViewController:"), annotationGridController.Handle);
		}
		
		[Export ("annotationGridViewController:numberOfAnnotationsInSection:")]
		[CompilerGenerated]
		public global::System.nint NumberOfAnnotationsInSection (PSPDFAnnotationGridViewController annotationGridController, global::System.nint section)
		{
			if (annotationGridController == null)
				throw new ArgumentNullException ("annotationGridController");
			return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("annotationGridViewController:numberOfAnnotationsInSection:"), annotationGridController.Handle, section);
		}
		
		[Export ("annotationGridViewController:annotationSetForIndexPath:")]
		[CompilerGenerated]
		public PSPDFAnnotationSet AnnotationSetForIndexPath (PSPDFAnnotationGridViewController annotationGridController, NSIndexPath indexPath)
		{
			if (annotationGridController == null)
				throw new ArgumentNullException ("annotationGridController");
			if (indexPath == null)
				throw new ArgumentNullException ("indexPath");
			return  Runtime.GetNSObject<PSPDFAnnotationSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("annotationGridViewController:annotationSetForIndexPath:"), annotationGridController.Handle, indexPath.Handle));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAnnotationGridViewControllerDataSource", false)]
	[Model]
	public unsafe abstract partial class PSPDFAnnotationGridViewControllerDataSource : NSObject, IPSPDFAnnotationGridViewControllerDataSource {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFAnnotationGridViewControllerDataSource () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationGridViewControllerDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationGridViewControllerDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("annotationGridViewController:annotationSetForIndexPath:")]
		[CompilerGenerated]
		public abstract PSPDFAnnotationSet AnnotationSetForIndexPath (PSPDFAnnotationGridViewController annotationGridController, NSIndexPath indexPath);
		[Export ("annotationGridViewController:numberOfAnnotationsInSection:")]
		[CompilerGenerated]
		public abstract global::System.nint NumberOfAnnotationsInSection (PSPDFAnnotationGridViewController annotationGridController, global::System.nint section);
		[Export ("numberOfSectionsInAnnotationGridViewController:")]
		[CompilerGenerated]
		public abstract global::System.nint NumberOfSectionsInAnnotationGridViewController (PSPDFAnnotationGridViewController annotationGridController);
	} /* class PSPDFAnnotationGridViewControllerDataSource */
}
