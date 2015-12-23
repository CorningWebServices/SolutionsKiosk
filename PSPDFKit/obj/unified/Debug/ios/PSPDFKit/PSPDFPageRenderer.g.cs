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
	[Protocol (Name = "PSPDFPageRenderer", WrapperType = typeof (PSPDFPageRendererWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawPage", Selector = "drawPage:inContext:withOptions:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nuint), typeof (CGContext), typeof (NSDictionary), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RenderAppearanceStream", Selector = "renderAppearanceStream:inContext:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotation), typeof (CGContext), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	public interface IPSPDFPageRenderer : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("drawPage:inContext:withOptions:error:")]
		[Preserve (Conditional = true)]
		bool DrawPage (global::System.nuint page, CGContext context, NSDictionary options, out NSError error);
		
	}
	
	public static partial class PSPDFPageRenderer_Extensions {
		[CompilerGenerated]
		public static bool RenderAppearanceStream (this IPSPDFPageRenderer This, PSPDFAnnotation annotation, CGContext context, out NSError error)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (context == null)
				throw new ArgumentNullException ("context");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (This.Handle, Selector.GetHandle ("renderAppearanceStream:inContext:error:"), annotation.Handle, context.Handle, ref errorValue);
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
	}
	
	internal sealed class PSPDFPageRendererWrapper : BaseWrapper, IPSPDFPageRenderer {
		public PSPDFPageRendererWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFPageRendererWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("drawPage:inContext:withOptions:error:")]
		[CompilerGenerated]
		public bool DrawPage (global::System.nuint page, CGContext context, NSDictionary options, out NSError error)
		{
			if (context == null)
				throw new ArgumentNullException ("context");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_nuint_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("drawPage:inContext:withOptions:error:"), page, context.Handle, options == null ? IntPtr.Zero : options.Handle, ref errorValue);
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFPageRenderer", false)]
	[Model]
	public unsafe abstract partial class PSPDFPageRenderer : NSObject, IPSPDFPageRenderer {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFPageRenderer () : base (NSObjectFlag.Empty)
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
		protected PSPDFPageRenderer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPageRenderer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("drawPage:inContext:withOptions:error:")]
		[CompilerGenerated]
		public abstract bool DrawPage (global::System.nuint page, CGContext context, NSDictionary options, out NSError error);
		[Export ("renderAppearanceStream:inContext:error:")]
		[CompilerGenerated]
		public virtual bool RenderAppearanceStream (PSPDFAnnotation annotation, CGContext context, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFPageRenderer */
}
