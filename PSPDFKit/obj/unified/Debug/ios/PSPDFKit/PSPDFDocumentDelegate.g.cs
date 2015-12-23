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
	[Protocol (Name = "PSPDFDocumentDelegate", WrapperType = typeof (PSPDFDocumentDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRenderPage", Selector = "pdfDocument:didRenderPage:inContext:withSize:clippedToRect:annotations:options:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocument), typeof (nuint), typeof (CGContext), typeof (CGSize), typeof (CGRect), typeof (PSPDFKit.PSPDFAnnotation[]), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCustomAnnotationPathToken", Selector = "pdfDocument:resolveCustomAnnotationPathToken:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocument), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSaveAnnotations", Selector = "pdfDocument:provider:shouldSaveAnnotations:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocument), typeof (PSPDFKit.PSPDFDocumentProvider), typeof (PSPDFKit.PSPDFAnnotation[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSaveAnnotations", Selector = "pdfDocument:didSaveAnnotations:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocument), typeof (PSPDFKit.PSPDFAnnotation[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToSaveAnnotations", Selector = "pdfDocument:failedToSaveAnnotations:error:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFDocument), typeof (PSPDFKit.PSPDFAnnotation[]), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPSPDFDocumentDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFDocumentDelegate_Extensions {
		[CompilerGenerated]
		public static void DidRenderPage (this IPSPDFDocumentDelegate This, PSPDFDocument document, global::System.nuint page, CGContext context, CGSize fullSize, CGRect clipRect, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_annotations = annotations == null ? null : NSArray.FromNSObjects (annotations);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_CGSize_CGRect_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfDocument:didRenderPage:inContext:withSize:clippedToRect:annotations:options:"), document.Handle, page, context.Handle, fullSize, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle);
			if (nsa_annotations != null)
				nsa_annotations.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static string ResolveCustomAnnotationPathToken (this IPSPDFDocumentDelegate This, PSPDFDocument document, string pathToken)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (pathToken == null)
				throw new ArgumentNullException ("pathToken");
			var nspathToken = NSString.CreateNative (pathToken);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfDocument:resolveCustomAnnotationPathToken:"), document.Handle, nspathToken));
			NSString.ReleaseNative (nspathToken);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool ShouldSaveAnnotations (this IPSPDFDocumentDelegate This, PSPDFDocument document, PSPDFDocumentProvider documentProvider, PSPDFAnnotation[] annotations)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfDocument:provider:shouldSaveAnnotations:"), document.Handle, documentProvider.Handle, nsa_annotations.Handle);
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void DidSaveAnnotations (this IPSPDFDocumentDelegate This, PSPDFDocument document, PSPDFAnnotation[] annotations)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfDocument:didSaveAnnotations:"), document.Handle, nsa_annotations.Handle);
			nsa_annotations.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void FailedToSaveAnnotations (this IPSPDFDocumentDelegate This, PSPDFDocument document, PSPDFAnnotation[] annotations, NSError error)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pdfDocument:failedToSaveAnnotations:error:"), document.Handle, nsa_annotations.Handle, error.Handle);
			nsa_annotations.Dispose ();
			
		}
		
	}
	
	internal sealed class PSPDFDocumentDelegateWrapper : BaseWrapper, IPSPDFDocumentDelegate {
		public PSPDFDocumentDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFDocumentDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFDocumentDelegate", false)]
	[Model]
	public unsafe partial class PSPDFDocumentDelegate : NSObject, IPSPDFDocumentDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocumentDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocumentDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocumentDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("pdfDocument:didRenderPage:inContext:withSize:clippedToRect:annotations:options:")]
		[CompilerGenerated]
		public virtual void DidRenderPage (PSPDFDocument document, global::System.nuint page, CGContext context, CGSize fullSize, CGRect clipRect, PSPDFAnnotation[] annotations, NSDictionary options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfDocument:didSaveAnnotations:")]
		[CompilerGenerated]
		public virtual void DidSaveAnnotations (PSPDFDocument document, PSPDFAnnotation[] annotations)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfDocument:failedToSaveAnnotations:error:")]
		[CompilerGenerated]
		public virtual void FailedToSaveAnnotations (PSPDFDocument document, PSPDFAnnotation[] annotations, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfDocument:resolveCustomAnnotationPathToken:")]
		[CompilerGenerated]
		public virtual string ResolveCustomAnnotationPathToken (PSPDFDocument document, string pathToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pdfDocument:provider:shouldSaveAnnotations:")]
		[CompilerGenerated]
		public virtual bool ShouldSaveAnnotations (PSPDFDocument document, PSPDFDocumentProvider documentProvider, PSPDFAnnotation[] annotations)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFDocumentDelegate */
}
