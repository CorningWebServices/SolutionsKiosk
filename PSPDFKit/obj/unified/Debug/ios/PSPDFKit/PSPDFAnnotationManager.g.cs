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
	[Register("PSPDFAnnotationManager", true)]
	public unsafe partial class PSPDFAnnotationManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFAnnotationManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFAnnotationManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFAnnotationManager (PSPDFDocumentProvider documentProvider)
			: base (NSObjectFlag.Empty)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocumentProvider:"), documentProvider.Handle), "initWithDocumentProvider:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocumentProvider:"), documentProvider.Handle), "initWithDocumentProvider:");
			}
		}
		
		[Export ("addAnnotations:options:")]
		[CompilerGenerated]
		public virtual bool AddAnnotations (PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addAnnotations:options:"), nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addAnnotations:options:"), nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle);
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("annotationsForPage:type:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AnnotationsForPage (global::System.nuint page, PSPDFAnnotationType type)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_UInt64 (this.Handle, Selector.GetHandle ("annotationsForPage:type:"), page, (UInt64)type));
				} else {
					return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_UInt32 (this.Handle, Selector.GetHandle ("annotationsForPage:type:"), page, (UInt32)type));
				}
			} else {
				if (IntPtr.Size == 8) {
					return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_UInt64 (this.SuperHandle, Selector.GetHandle ("annotationsForPage:type:"), page, (UInt64)type));
				} else {
					return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_UInt32 (this.SuperHandle, Selector.GetHandle ("annotationsForPage:type:"), page, (UInt32)type));
				}
			}
		}
		
		[Export ("annotationsForPage:type:pageRef:")]
		[CompilerGenerated]
		internal virtual PSPDFAnnotation[] AnnotationsForPage (global::System.nuint page, PSPDFAnnotationType type, global::System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_UInt64_IntPtr (this.Handle, Selector.GetHandle ("annotationsForPage:type:pageRef:"), page, (UInt64)type, pageRef));
				} else {
					return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_UInt32_IntPtr (this.Handle, Selector.GetHandle ("annotationsForPage:type:pageRef:"), page, (UInt32)type, pageRef));
				}
			} else {
				if (IntPtr.Size == 8) {
					return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_UInt64_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationsForPage:type:pageRef:"), page, (UInt64)type, pageRef));
				} else {
					return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationsForPage:type:pageRef:"), page, (UInt32)type, pageRef));
				}
			}
		}
		
		[Export ("annotationsIncludingGroupsFromAnnotations:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AnnotationsIncludingGroups (PSPDFAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			PSPDFAnnotation[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("annotationsIncludingGroupsFromAnnotations:"), nsa_annotations.Handle));
			} else {
				ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationsIncludingGroupsFromAnnotations:"), nsa_annotations.Handle));
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("defaultAnnotationViewClassForAnnotation:")]
		[CompilerGenerated]
		public virtual Class DefaultAnnotationViewClass (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("defaultAnnotationViewClassForAnnotation:"), annotation.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("defaultAnnotationViewClassForAnnotation:"), annotation.Handle);
			}
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("didChangeAnnotation:keyPaths:options:")]
		[CompilerGenerated]
		public virtual void DidChangeAnnotation (PSPDFAnnotation annotation, NSObject[] keyPaths, NSDictionary options)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (keyPaths == null)
				throw new ArgumentNullException ("keyPaths");
			var nsa_keyPaths = NSArray.FromNSObjects (keyPaths);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didChangeAnnotation:keyPaths:options:"), annotation.Handle, nsa_keyPaths.Handle, options == null ? IntPtr.Zero : options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didChangeAnnotation:keyPaths:options:"), annotation.Handle, nsa_keyPaths.Handle, options == null ? IntPtr.Zero : options.Handle);
			}
			nsa_keyPaths.Dispose ();
			
		}
		
		[Export ("dirtyAnnotations")]
		[CompilerGenerated]
		public virtual NSDictionary DirtyAnnotations ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dirtyAnnotations")));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dirtyAnnotations")));
			}
		}
		
		[Export ("fileTypeTranslationTable")]
		[CompilerGenerated]
		public static NSDictionary FileTypeTranslationTable ()
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("fileTypeTranslationTable")));
		}
		
		[Export ("allAnnotationsOfType:")]
		[CompilerGenerated]
		public virtual NSDictionary GetAllAnnotations (PSPDFAnnotationType annotationType)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("allAnnotationsOfType:"), (UInt64)annotationType));
				} else {
					return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("allAnnotationsOfType:"), (UInt32)annotationType));
				}
			} else {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("allAnnotationsOfType:"), (UInt64)annotationType));
				} else {
					return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("allAnnotationsOfType:"), (UInt32)annotationType));
				}
			}
		}
		
		[Export ("annotationViewClassForAnnotation:")]
		[CompilerGenerated]
		public virtual Class GetAnnotationViewClass (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			IntPtr ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("annotationViewClassForAnnotation:"), annotation.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationViewClassForAnnotation:"), annotation.Handle);
			}
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("hasLoadedAnnotationsForPage:")]
		[CompilerGenerated]
		public virtual bool HasLoadedAnnotations (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("hasLoadedAnnotationsForPage:"), page);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("hasLoadedAnnotationsForPage:"), page);
			}
		}
		
		[Export ("mediaFileTypes")]
		[CompilerGenerated]
		public static NSObject[] MediaFileTypes ()
		{
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("mediaFileTypes")));
		}
		
		[Export ("removeAnnotations:options:")]
		[CompilerGenerated]
		public virtual bool RemoveAnnotations (PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeAnnotations:options:"), nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAnnotations:options:"), nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle);
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("saveAnnotationsWithOptions:error:")]
		[CompilerGenerated]
		internal virtual bool SaveAnnotations (PSPDFAnnotation options, global::System.IntPtr error)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("saveAnnotationsWithOptions:error:"), options.Handle, error);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("saveAnnotationsWithOptions:error:"), options.Handle, error);
			}
		}
		
		[Export ("updateAnnotations:animated:")]
		[CompilerGenerated]
		public virtual void UpdateAnnotations (PSPDFAnnotation[] annotations, bool animated)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("updateAnnotations:animated:"), nsa_annotations.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("updateAnnotations:animated:"), nsa_annotations.Handle, animated);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationProviders_var;
		[CompilerGenerated]
		public virtual NSObject[] AnnotationProviders {
			[Export ("annotationProviders", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationProviders")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationProviders")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationProviders_var = ret;
				return ret;
			}
			
			[Export ("setAnnotationProviders:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotationProviders:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotationProviders:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationProviders_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DocumentProvider_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProvider {
			[Export ("documentProvider", ArgumentSemantic.Weak)]
			get {
				PSPDFDocumentProvider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentProvider")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentProvider")));
				}
				MarkDirty ();
				__mt_DocumentProvider_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FileAnnotationProvider_var;
		[CompilerGenerated]
		public virtual PSPDFFileAnnotationProvider FileAnnotationProvider {
			[Export ("fileAnnotationProvider", ArgumentSemantic.Retain)]
			get {
				PSPDFFileAnnotationProvider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFFileAnnotationProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileAnnotationProvider")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFFileAnnotationProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileAnnotationProvider")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileAnnotationProvider_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string[] ProtocolStrings {
			[Export ("protocolStrings", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("protocolStrings")));
				} else {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("protocolStrings")));
				}
			}
			
			[Export ("setProtocolStrings:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProtocolStrings:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProtocolStrings:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldSaveAnnotations {
			[Export ("shouldSaveAnnotations")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldSaveAnnotations"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldSaveAnnotations"));
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _AnnotationsAddedNotification;
		[Field ("PSPDFAnnotationsAddedNotification",  "__Internal")]
		public static unsafe NSString AnnotationsAddedNotification {
			get {
				if (_AnnotationsAddedNotification == null)
					_AnnotationsAddedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFAnnotationsAddedNotification");
				return _AnnotationsAddedNotification;
			}
		}
		[CompilerGenerated]
		static NSString _AnnotationsRemovedNotification;
		[Field ("PSPDFAnnotationsRemovedNotification",  "__Internal")]
		public static unsafe NSString AnnotationsRemovedNotification {
			get {
				if (_AnnotationsRemovedNotification == null)
					_AnnotationsRemovedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFAnnotationsRemovedNotification");
				return _AnnotationsRemovedNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnnotationProviders_var = null;
				__mt_DocumentProvider_var = null;
				__mt_FileAnnotationProvider_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveAnnotationsAdded (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnotationsAddedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveAnnotationsRemoved (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnotationsRemovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFAnnotationManager */
}
