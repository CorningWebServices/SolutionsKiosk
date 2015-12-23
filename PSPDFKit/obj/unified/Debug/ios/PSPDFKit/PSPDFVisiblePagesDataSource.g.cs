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
	[Protocol (Name = "PSPDFVisiblePagesDataSource", WrapperType = typeof (PSPDFVisiblePagesDataSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPage", Selector = "page", ReturnType = typeof (nuint))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "VisiblePages", Selector = "visiblePages", ReturnType = typeof (NSOrderedSet))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "VisiblePagesCalculated", Selector = "visiblePagesCalculated", ReturnType = typeof (NSOrderedSet))]
	public interface IPSPDFVisiblePagesDataSource : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("visiblePages")]
		[Preserve (Conditional = true)]
		NSOrderedSet VisiblePages ();
		
		[CompilerGenerated]
		[Export ("visiblePagesCalculated")]
		[Preserve (Conditional = true)]
		NSOrderedSet VisiblePagesCalculated ();
		
	}
	
	public static partial class PSPDFVisiblePagesDataSource_Extensions {
		[CompilerGenerated]
		public static global::System.nuint GetPage (this IPSPDFVisiblePagesDataSource This)
		{
			return global::ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("page"));
		}
		
	}
	
	internal sealed class PSPDFVisiblePagesDataSourceWrapper : BaseWrapper, IPSPDFVisiblePagesDataSource {
		public PSPDFVisiblePagesDataSourceWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFVisiblePagesDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("visiblePages")]
		[CompilerGenerated]
		public NSOrderedSet VisiblePages ()
		{
			return  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePages")));
		}
		
		[Export ("visiblePagesCalculated")]
		[CompilerGenerated]
		public NSOrderedSet VisiblePagesCalculated ()
		{
			return  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visiblePagesCalculated")));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFVisiblePagesDataSource", false)]
	[Model]
	public unsafe abstract partial class PSPDFVisiblePagesDataSource : NSObject, IPSPDFVisiblePagesDataSource {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFVisiblePagesDataSource () : base (NSObjectFlag.Empty)
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
		protected PSPDFVisiblePagesDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFVisiblePagesDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("page")]
		[CompilerGenerated]
		public virtual global::System.nuint GetPage ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("visiblePages")]
		[CompilerGenerated]
		public abstract NSOrderedSet VisiblePages ();
		[Export ("visiblePagesCalculated")]
		[CompilerGenerated]
		public abstract NSOrderedSet VisiblePagesCalculated ();
	} /* class PSPDFVisiblePagesDataSource */
}
