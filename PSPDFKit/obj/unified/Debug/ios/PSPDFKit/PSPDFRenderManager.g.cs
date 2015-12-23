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
	[Protocol (Name = "PSPDFRenderManager", WrapperType = typeof (PSPDFRenderManagerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Rectangle", Selector = "setupGraphicsContext:rectangle:pageInfo:", ParameterType = new Type [] { typeof (CGContext), typeof (CGRect), typeof (PSPDFKit.PSPDFPageInfo) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRenderQueue", Selector = "renderQueue", ReturnType = typeof (PSPDFKit.PSPDFRenderQueue))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRendererInfo", Selector = "rendererInfo", ReturnType = typeof (NSDictionary))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRenderer", Selector = "renderer", ReturnType = typeof (PSPDFKit.IPSPDFPageRenderer))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetRenderer", Selector = "setRenderer:", ParameterType = new Type [] { typeof (PSPDFKit.IPSPDFPageRenderer) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFRenderManager : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setupGraphicsContext:rectangle:pageInfo:")]
		[Preserve (Conditional = true)]
		void Rectangle (CGContext context, CGRect displayRectangle, PSPDFPageInfo pageInfo);
		
	}
	
	public static partial class PSPDFRenderManager_Extensions {
		[CompilerGenerated]
		public static PSPDFRenderQueue GetRenderQueue (this IPSPDFRenderManager This)
		{
			return  Runtime.GetNSObject<PSPDFRenderQueue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("renderQueue")));
		}
		
		[CompilerGenerated]
		public static NSDictionary GetRendererInfo (this IPSPDFRenderManager This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("rendererInfo")));
		}
		
		[CompilerGenerated]
		public static IPSPDFPageRenderer GetRenderer (this IPSPDFRenderManager This)
		{
			return  Runtime.GetINativeObject<IPSPDFPageRenderer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("renderer")), false);
		}
		
		[CompilerGenerated]
		public static void SetRenderer (this IPSPDFRenderManager This, IPSPDFPageRenderer renderer)
		{
			if (renderer == null)
				throw new ArgumentNullException ("renderer");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setRenderer:"), renderer.Handle);
		}
		
	}
	
	internal sealed class PSPDFRenderManagerWrapper : BaseWrapper, IPSPDFRenderManager {
		public PSPDFRenderManagerWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFRenderManagerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setupGraphicsContext:rectangle:pageInfo:")]
		[CompilerGenerated]
		public void Rectangle (CGContext context, CGRect displayRectangle, PSPDFPageInfo pageInfo)
		{
			if (context == null)
				throw new ArgumentNullException ("context");
			if (pageInfo == null)
				throw new ArgumentNullException ("pageInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr (this.Handle, Selector.GetHandle ("setupGraphicsContext:rectangle:pageInfo:"), context.Handle, displayRectangle, pageInfo.Handle);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFRenderManager", false)]
	[Model]
	public unsafe abstract partial class PSPDFRenderManager : NSObject, IPSPDFRenderManager {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFRenderManager () : base (NSObjectFlag.Empty)
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
		protected PSPDFRenderManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFRenderManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("renderer")]
		[CompilerGenerated]
		public virtual IPSPDFPageRenderer GetRenderer ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rendererInfo")]
		[CompilerGenerated]
		public virtual NSDictionary GetRendererInfo ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("renderQueue")]
		[CompilerGenerated]
		public virtual PSPDFRenderQueue GetRenderQueue ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setupGraphicsContext:rectangle:pageInfo:")]
		[CompilerGenerated]
		public abstract void Rectangle (CGContext context, CGRect displayRectangle, PSPDFPageInfo pageInfo);
		[Export ("setRenderer:")]
		[CompilerGenerated]
		public virtual void SetRenderer (IPSPDFPageRenderer renderer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		static NSString _PageInfoKey;
		[Field ("PSPDFPageRendererPageInfoKey",  "__Internal")]
		public static unsafe NSString PageInfoKey {
			get {
				if (_PageInfoKey == null)
					_PageInfoKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFPageRendererPageInfoKey");
				return _PageInfoKey;
			}
		}
	} /* class PSPDFRenderManager */
}
