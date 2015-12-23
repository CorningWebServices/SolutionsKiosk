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
	[Protocol (Name = "PSPDFSearchHighlightViewManagerDataSource", WrapperType = typeof (PSPDFSearchHighlightViewManagerDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldHighlightSearchResults", Selector = "shouldHighlightSearchResults", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "VisiblePageViews", Selector = "visiblePageViews", ReturnType = typeof (PSPDFKit.PSPDFPageView[]))]
	public interface IPSPDFSearchHighlightViewManagerDataSource : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
		[CompilerGenerated]
		[Export ("shouldHighlightSearchResults")]
		[Preserve (Conditional = true)]
		bool ShouldHighlightSearchResults ();
		
		[CompilerGenerated]
		[Export ("visiblePageViews")]
		[Preserve (Conditional = true)]
		PSPDFPageView[] VisiblePageViews ();
		
	}
	
	internal sealed class PSPDFSearchHighlightViewManagerDataSourceWrapper : BaseWrapper, IPSPDFSearchHighlightViewManagerDataSource {
		public PSPDFSearchHighlightViewManagerDataSourceWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFSearchHighlightViewManagerDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("shouldHighlightSearchResults")]
		[CompilerGenerated]
		public bool ShouldHighlightSearchResults ()
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHighlightSearchResults"));
		}
		
		[Export ("visiblePageViews")]
		[CompilerGenerated]
		public PSPDFPageView[] VisiblePageViews ()
		{
			return NSArray.ArrayFromHandle<PSPDFPageView>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePageViews")));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFSearchHighlightViewManagerDataSource", false)]
	[Model]
	public unsafe abstract partial class PSPDFSearchHighlightViewManagerDataSource : NSObject, IPSPDFSearchHighlightViewManagerDataSource, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFSearchHighlightViewManagerDataSource () : base (NSObjectFlag.Empty)
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
		protected PSPDFSearchHighlightViewManagerDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSearchHighlightViewManagerDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("shouldHighlightSearchResults")]
		[CompilerGenerated]
		public abstract bool ShouldHighlightSearchResults ();
		[Export ("visiblePageViews")]
		[CompilerGenerated]
		public abstract PSPDFPageView[] VisiblePageViews ();
	} /* class PSPDFSearchHighlightViewManagerDataSource */
}
