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
	[Register("PSPDFContainerAnnotationProvider", true)]
	public unsafe partial class PSPDFContainerAnnotationProvider : NSObject, IPSPDFAnnotationProvider, IPSPDFUndoProtocol {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFContainerAnnotationProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFContainerAnnotationProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFContainerAnnotationProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocumentProvider:")]
		[CompilerGenerated]
		public PSPDFContainerAnnotationProvider (PSPDFDocumentProvider documentProvider)
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
		public virtual PSPDFAnnotation[] AddAnnotations (PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			PSPDFAnnotation[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addAnnotations:options:"), nsa_annotations.Handle, options.Handle));
			} else {
				ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addAnnotations:options:"), nsa_annotations.Handle, options.Handle));
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("annotationsForPage:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AnnotationsForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("annotationsForPage:"), page));
			} else {
				return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("annotationsForPage:"), page));
			}
		}
		
		[Export ("annotationViewClassForAnnotation:")]
		[CompilerGenerated]
		public virtual Class AnnotationViewClass (PSPDFAnnotation annotation)
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
		
		[Export ("clearNeedsSaveFlag")]
		[CompilerGenerated]
		public virtual void ClearNeedsSaveFlag ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearNeedsSaveFlag"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearNeedsSaveFlag"));
			}
		}
		
		[Export ("didChangeAnnotation:keyPaths:options:")]
		[CompilerGenerated]
		public virtual void DidChangeAnnotation (PSPDFAnnotation annotation, NSObject[] keyPaths, NSDictionary options)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (keyPaths == null)
				throw new ArgumentNullException ("keyPaths");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_keyPaths = NSArray.FromNSObjects (keyPaths);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didChangeAnnotation:keyPaths:options:"), annotation.Handle, nsa_keyPaths.Handle, options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didChangeAnnotation:keyPaths:options:"), annotation.Handle, nsa_keyPaths.Handle, options.Handle);
			}
			nsa_keyPaths.Dispose ();
			
		}
		
		[Export ("didUndoOrRedoChange:")]
		[CompilerGenerated]
		public virtual void DidUndoOrRedoChange (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didUndoOrRedoChange:"), nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didUndoOrRedoChange:"), nskey);
			}
			NSString.ReleaseNative (nskey);
			
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
		
		[Export ("providerDelegate")]
		[CompilerGenerated]
		public virtual IPSPDFAnnotationProviderChangeNotifier GetProviderDelegate ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetINativeObject<IPSPDFAnnotationProviderChangeNotifier> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("providerDelegate")), false);
			} else {
				return  Runtime.GetINativeObject<IPSPDFAnnotationProviderChangeNotifier> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("providerDelegate")), false);
			}
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
		
		[Export ("insertUndoObjects:forKey:")]
		[CompilerGenerated]
		public virtual void InsertUndoObjects (NSSet objects, string key)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("insertUndoObjects:forKey:"), objects.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("insertUndoObjects:forKey:"), objects.Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("keysForValuesToObserveForUndo")]
		[CompilerGenerated]
		public virtual NSSet KeysForValuesToObserveForUndo ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keysForValuesToObserveForUndo")));
			} else {
				return  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("keysForValuesToObserveForUndo")));
			}
		}
		
		[Export ("localizedUndoActionNameForKey:")]
		[CompilerGenerated]
		public static string LocalizedUndoActionNameForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("localizedUndoActionNameForKey:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("performBlockForWriting:")]
		[CompilerGenerated]
		public unsafe virtual void PerformActionForWriting ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			BlockLiteral *block_ptr_action;
			BlockLiteral block_action;
			block_action = new BlockLiteral ();
			block_ptr_action = &block_action;
			block_action.SetupBlock (Trampolines.SDAction.Handler, action);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("performBlockForWriting:"), (IntPtr) block_ptr_action);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("performBlockForWriting:"), (IntPtr) block_ptr_action);
			}
			block_ptr_action->CleanupBlock ();
			
		}
		
		[Export ("performBlockForWritingAndWait:")]
		[CompilerGenerated]
		public unsafe virtual void PerformActionForWritingAndWait ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			BlockLiteral *block_ptr_action;
			BlockLiteral block_action;
			block_action = new BlockLiteral ();
			block_ptr_action = &block_action;
			block_action.SetupBlock (Trampolines.SDAction.Handler, action);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("performBlockForWritingAndWait:"), (IntPtr) block_ptr_action);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("performBlockForWritingAndWait:"), (IntPtr) block_ptr_action);
			}
			block_ptr_action->CleanupBlock ();
			
		}
		
		[Export ("performBlockForReading:")]
		[CompilerGenerated]
		public unsafe virtual void PerformAnctionForReading ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			BlockLiteral *block_ptr_action;
			BlockLiteral block_action;
			block_action = new BlockLiteral ();
			block_ptr_action = &block_action;
			block_action.SetupBlock (Trampolines.SDAction.Handler, action);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("performBlockForReading:"), (IntPtr) block_ptr_action);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("performBlockForReading:"), (IntPtr) block_ptr_action);
			}
			block_ptr_action->CleanupBlock ();
			
		}
		
		[Export ("performUndoAction:")]
		[CompilerGenerated]
		public virtual void PerformUndoAction (NSObject action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("performUndoAction:"), action.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("performUndoAction:"), action.Handle);
			}
		}
		
		[Export ("registerAnnotationsForUndo:")]
		[CompilerGenerated]
		public virtual void RegisterAnnotationsForUndo (PSPDFAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerAnnotationsForUndo:"), nsa_annotations.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerAnnotationsForUndo:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("removeAllAnnotationsWithOptions:")]
		[CompilerGenerated]
		public virtual void RemoveAllAnnotations (NSDictionary options)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAllAnnotationsWithOptions:"), options == null ? IntPtr.Zero : options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAllAnnotationsWithOptions:"), options == null ? IntPtr.Zero : options.Handle);
			}
		}
		
		[Export ("removeAnnotations:options:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] RemoveAnnotations (PSPDFAnnotation[] annotations, NSDictionary options)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			PSPDFAnnotation[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeAnnotations:options:"), nsa_annotations.Handle, options.Handle));
			} else {
				ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAnnotations:options:"), nsa_annotations.Handle, options.Handle));
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("removeUndoObjects:forKey:")]
		[CompilerGenerated]
		public virtual void RemoveUndoObjects (NSSet objects, string key)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeUndoObjects:forKey:"), objects.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removeUndoObjects:forKey:"), objects.Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("saveAnnotationsWithOptions:error:")]
		[CompilerGenerated]
		public virtual bool SaveAnnotations (NSDictionary options, out NSError error)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("saveAnnotationsWithOptions:error:"), options.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("saveAnnotationsWithOptions:error:"), options.Handle, ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("setAnnotationCacheDirect:")]
		[CompilerGenerated]
		public virtual void SetAnnotationCacheDirect (NSDictionary annotationCache)
		{
			if (annotationCache == null)
				throw new ArgumentNullException ("annotationCache");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotationCacheDirect:"), annotationCache.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotationCacheDirect:"), annotationCache.Handle);
			}
		}
		
		[Export ("setAnnotations:forPage:append:")]
		[CompilerGenerated]
		public virtual void SetAnnotations (PSPDFAnnotation[] annotations, global::System.nuint page, bool append)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_bool (this.Handle, Selector.GetHandle ("setAnnotations:forPage:append:"), nsa_annotations.Handle, page, append);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint_bool (this.SuperHandle, Selector.GetHandle ("setAnnotations:forPage:append:"), nsa_annotations.Handle, page, append);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("setAnnotations:append:")]
		[CompilerGenerated]
		public virtual void SetAnnotations (PSPDFAnnotation[] annotations, bool append)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setAnnotations:append:"), nsa_annotations.Handle, append);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setAnnotations:append:"), nsa_annotations.Handle, append);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("setProviderDelegate:")]
		[CompilerGenerated]
		public virtual void SetProviderDelegate (IPSPDFAnnotationProviderChangeNotifier provider)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProviderDelegate:"), provider == null ? IntPtr.Zero : provider.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProviderDelegate:"), provider == null ? IntPtr.Zero : provider.Handle);
			}
		}
		
		[Export ("shouldSaveAnnotations")]
		[CompilerGenerated]
		public virtual bool ShouldSaveAnnotations ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldSaveAnnotations"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldSaveAnnotations"));
			}
		}
		
		[Export ("undoCoalescingForKey:")]
		[CompilerGenerated]
		public static PSPDFUndoCoalescing UndoCoalescingForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			PSPDFUndoCoalescing ret;
			if (IntPtr.Size == 8) {
				ret = (PSPDFUndoCoalescing) global::ApiDefinition.Messaging.UInt64_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("undoCoalescingForKey:"), nskey);
			} else {
				ret = (PSPDFUndoCoalescing) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("undoCoalescingForKey:"), nskey);
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("willInsertAnnotations:")]
		[CompilerGenerated]
		public virtual void WillInsertAnnotations (PSPDFAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("willInsertAnnotations:"), nsa_annotations.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("willInsertAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[CompilerGenerated]
		object __mt_AllAnnotations_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] AllAnnotations {
			[Export ("allAnnotations")]
			get {
				PSPDFAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allAnnotations")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allAnnotations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AllAnnotations_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationCache_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary AnnotationCache {
			[Export ("annotationCache", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationCache")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationCache")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationCache_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Annotations_var;
		[CompilerGenerated]
		public virtual NSDictionary Annotations {
			[Export ("annotations")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotations")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Annotations_var = ret;
				return ret;
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
		object __mt_UndoController_var;
		[CompilerGenerated]
		public virtual PSPDFUndoController UndoController {
			[Export ("undoController", ArgumentSemantic.Weak)]
			get {
				PSPDFUndoController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFUndoController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("undoController")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFUndoController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("undoController")));
				}
				MarkDirty ();
				__mt_UndoController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AllAnnotations_var = null;
				__mt_AnnotationCache_var = null;
				__mt_Annotations_var = null;
				__mt_DocumentProvider_var = null;
				__mt_UndoController_var = null;
			}
		}
	} /* class PSPDFContainerAnnotationProvider */
}
