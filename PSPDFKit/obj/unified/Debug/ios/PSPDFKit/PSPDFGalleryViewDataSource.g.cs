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
	[Protocol (Name = "PSPDFGalleryViewDataSource", WrapperType = typeof (PSPDFGalleryViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfItemsInGalleryView", Selector = "numberOfItemsInGalleryView:", ReturnType = typeof (nuint), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFGalleryView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ContentViewForItemAtIndex", Selector = "galleryView:contentViewForItemAtIndex:", ReturnType = typeof (PSPDFKit.PSPDFGalleryContentView), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFGalleryView), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFGalleryViewDataSource : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("numberOfItemsInGalleryView:")]
		[Preserve (Conditional = true)]
		global::System.nuint NumberOfItemsInGalleryView (PSPDFGalleryView galleryView);
		
		[CompilerGenerated]
		[Export ("galleryView:contentViewForItemAtIndex:")]
		[Preserve (Conditional = true)]
		PSPDFGalleryContentView ContentViewForItemAtIndex (PSPDFGalleryView galleryView, global::System.nuint index);
		
	}
	
	internal sealed class PSPDFGalleryViewDataSourceWrapper : BaseWrapper, IPSPDFGalleryViewDataSource {
		public PSPDFGalleryViewDataSourceWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFGalleryViewDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("numberOfItemsInGalleryView:")]
		[CompilerGenerated]
		public global::System.nuint NumberOfItemsInGalleryView (PSPDFGalleryView galleryView)
		{
			if (galleryView == null)
				throw new ArgumentNullException ("galleryView");
			return global::ApiDefinition.Messaging.nuint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("numberOfItemsInGalleryView:"), galleryView.Handle);
		}
		
		[Export ("galleryView:contentViewForItemAtIndex:")]
		[CompilerGenerated]
		public PSPDFGalleryContentView ContentViewForItemAtIndex (PSPDFGalleryView galleryView, global::System.nuint index)
		{
			if (galleryView == null)
				throw new ArgumentNullException ("galleryView");
			return  Runtime.GetNSObject<PSPDFGalleryContentView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("galleryView:contentViewForItemAtIndex:"), galleryView.Handle, index));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFGalleryViewDataSource", false)]
	[Model]
	public unsafe abstract partial class PSPDFGalleryViewDataSource : NSObject, IPSPDFGalleryViewDataSource {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFGalleryViewDataSource () : base (NSObjectFlag.Empty)
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
		protected PSPDFGalleryViewDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryViewDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("galleryView:contentViewForItemAtIndex:")]
		[CompilerGenerated]
		public abstract PSPDFGalleryContentView ContentViewForItemAtIndex (PSPDFGalleryView galleryView, global::System.nuint index);
		[Export ("numberOfItemsInGalleryView:")]
		[CompilerGenerated]
		public abstract global::System.nuint NumberOfItemsInGalleryView (PSPDFGalleryView galleryView);
	} /* class PSPDFGalleryViewDataSource */
}
