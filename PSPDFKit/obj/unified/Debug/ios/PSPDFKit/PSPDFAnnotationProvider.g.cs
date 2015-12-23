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
	[Protocol (Name = "PSPDFAnnotationProvider", WrapperType = typeof (PSPDFAnnotationProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AnnotationsForPage", Selector = "annotationsForPage:", ReturnType = typeof (PSPDFKit.PSPDFAnnotation[]), ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasLoadedAnnotations", Selector = "hasLoadedAnnotationsForPage:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnnotationViewClass", Selector = "annotationViewClassForAnnotation:", ReturnType = typeof (Class), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddAnnotations", Selector = "addAnnotations:options:", ReturnType = typeof (PSPDFKit.PSPDFAnnotation[]), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotation[]), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveAnnotations", Selector = "removeAnnotations:options:", ReturnType = typeof (PSPDFKit.PSPDFAnnotation[]), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotation[]), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SaveAnnotations", Selector = "saveAnnotationsWithOptions:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSaveAnnotations", Selector = "shouldSaveAnnotations", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DirtyAnnotations", Selector = "dirtyAnnotations", ReturnType = typeof (NSDictionary))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeAnnotation", Selector = "didChangeAnnotation:keyPaths:options:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotation), typeof (NSObject[]), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetProviderDelegate", Selector = "providerDelegate", ReturnType = typeof (PSPDFKit.IPSPDFAnnotationProviderChangeNotifier))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetProviderDelegate", Selector = "setProviderDelegate:", ParameterType = new Type [] { typeof (PSPDFKit.IPSPDFAnnotationProviderChangeNotifier) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFAnnotationProvider : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("annotationsForPage:")]
		[Preserve (Conditional = true)]
		PSPDFAnnotation[] AnnotationsForPage (global::System.nuint page);
		
	}
	
	public static partial class PSPDFAnnotationProvider_Extensions {
		[CompilerGenerated]
		public static bool HasLoadedAnnotations (this IPSPDFAnnotationProvider This, global::System.nuint page)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("hasLoadedAnnotationsForPage:"), page);
		}
		
		[CompilerGenerated]
		public static Class AnnotationViewClass (this IPSPDFAnnotationProvider This, PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("annotationViewClassForAnnotation:"), annotation.Handle);
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[CompilerGenerated]
		public static PSPDFAnnotation[] AddAnnotations (this IPSPDFAnnotationProvider This, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			PSPDFAnnotation[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("addAnnotations:options:"), nsa_annotations.Handle, options.Handle));
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static PSPDFAnnotation[] RemoveAnnotations (this IPSPDFAnnotationProvider This, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			PSPDFAnnotation[] ret;
			ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("removeAnnotations:options:"), nsa_annotations.Handle, options.Handle));
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool SaveAnnotations (this IPSPDFAnnotationProvider This, NSDictionary options, out NSError error)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (This.Handle, Selector.GetHandle ("saveAnnotationsWithOptions:error:"), options.Handle, ref errorValue);
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[CompilerGenerated]
		public static bool ShouldSaveAnnotations (this IPSPDFAnnotationProvider This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldSaveAnnotations"));
		}
		
		[CompilerGenerated]
		public static NSDictionary DirtyAnnotations (this IPSPDFAnnotationProvider This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("dirtyAnnotations")));
		}
		
		[CompilerGenerated]
		public static void DidChangeAnnotation (this IPSPDFAnnotationProvider This, PSPDFAnnotation annotation, NSObject[] keyPaths, NSDictionary options)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (keyPaths == null)
				throw new ArgumentNullException ("keyPaths");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_keyPaths = NSArray.FromNSObjects (keyPaths);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didChangeAnnotation:keyPaths:options:"), annotation.Handle, nsa_keyPaths.Handle, options.Handle);
			nsa_keyPaths.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static IPSPDFAnnotationProviderChangeNotifier GetProviderDelegate (this IPSPDFAnnotationProvider This)
		{
			return  Runtime.GetINativeObject<IPSPDFAnnotationProviderChangeNotifier> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("providerDelegate")), false);
		}
		
		[CompilerGenerated]
		public static void SetProviderDelegate (this IPSPDFAnnotationProvider This, IPSPDFAnnotationProviderChangeNotifier provider)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setProviderDelegate:"), provider == null ? IntPtr.Zero : provider.Handle);
		}
		
	}
	
	internal sealed class PSPDFAnnotationProviderWrapper : BaseWrapper, IPSPDFAnnotationProvider {
		public PSPDFAnnotationProviderWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationProviderWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("annotationsForPage:")]
		[CompilerGenerated]
		public PSPDFAnnotation[] AnnotationsForPage (global::System.nuint page)
		{
			return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("annotationsForPage:"), page));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAnnotationProvider", false)]
	[Model]
	public unsafe abstract partial class PSPDFAnnotationProvider : NSObject, IPSPDFAnnotationProvider {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFAnnotationProvider () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addAnnotations:options:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AddAnnotations (PSPDFAnnotation[] annotations, NSDictionary options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("annotationsForPage:")]
		[CompilerGenerated]
		public abstract PSPDFAnnotation[] AnnotationsForPage (global::System.nuint page);
		[Export ("annotationViewClassForAnnotation:")]
		[CompilerGenerated]
		public virtual Class AnnotationViewClass (PSPDFAnnotation annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didChangeAnnotation:keyPaths:options:")]
		[CompilerGenerated]
		public virtual void DidChangeAnnotation (PSPDFAnnotation annotation, NSObject[] keyPaths, NSDictionary options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dirtyAnnotations")]
		[CompilerGenerated]
		public virtual NSDictionary DirtyAnnotations ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("providerDelegate")]
		[CompilerGenerated]
		public virtual IPSPDFAnnotationProviderChangeNotifier GetProviderDelegate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hasLoadedAnnotationsForPage:")]
		[CompilerGenerated]
		public virtual bool HasLoadedAnnotations (global::System.nuint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeAnnotations:options:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] RemoveAnnotations (PSPDFAnnotation[] annotations, NSDictionary options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("saveAnnotationsWithOptions:error:")]
		[CompilerGenerated]
		public virtual bool SaveAnnotations (NSDictionary options, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setProviderDelegate:")]
		[CompilerGenerated]
		public virtual void SetProviderDelegate (IPSPDFAnnotationProviderChangeNotifier provider)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("shouldSaveAnnotations")]
		[CompilerGenerated]
		public virtual bool ShouldSaveAnnotations ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFAnnotationProvider */
}
