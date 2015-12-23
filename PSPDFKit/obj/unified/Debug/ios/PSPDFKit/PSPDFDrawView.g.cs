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
	[Register("PSPDFDrawView", true)]
	public unsafe partial class PSPDFDrawView : global::UIKit.UIView, IPSPDFAnnotationViewProtocol, IPSPDFUndoProtocol {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDrawView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDrawView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFDrawView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFDrawView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDrawView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancelDrawing")]
		[CompilerGenerated]
		public virtual void CancelDrawing ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelDrawing"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelDrawing"));
			}
		}
		
		[Export ("clearAllActions")]
		[CompilerGenerated]
		public virtual void ClearAllActions ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearAllActions"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearAllActions"));
			}
		}
		
		[Export ("continueDrawingAtPoint:")]
		[CompilerGenerated]
		public virtual void ContinueDrawingAtPoint (CGPoint location)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("continueDrawingAtPoint:"), location);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("continueDrawingAtPoint:"), location);
			}
		}
		
		[Export ("didChangePageBounds:")]
		[CompilerGenerated]
		public virtual void DidChangePageBounds (CGRect bounds)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("didChangePageBounds:"), bounds);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("didChangePageBounds:"), bounds);
			}
		}
		
		[Export ("didHidePageView:")]
		[CompilerGenerated]
		public virtual void DidHidePageView (PSPDFPageView pageView)
		{
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didHidePageView:"), pageView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didHidePageView:"), pageView.Handle);
			}
		}
		
		[Export ("didShowPageView:")]
		[CompilerGenerated]
		public virtual void DidShowPageView (PSPDFPageView pageView)
		{
			if (pageView == null)
				throw new ArgumentNullException ("pageView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didShowPageView:"), pageView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didShowPageView:"), pageView.Handle);
			}
		}
		
		[Export ("didTapAtPoint:")]
		[CompilerGenerated]
		public virtual void DidTapAtPoint (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("didTapAtPoint:"), point);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("didTapAtPoint:"), point);
			}
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
		
		[Export ("endDrawing")]
		[CompilerGenerated]
		public virtual void EndDrawing ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endDrawing"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endDrawing"));
			}
		}
		
		[Export ("annotation")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation GetAnnotation ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotation")));
			} else {
				return  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotation")));
			}
		}
		
		[Export ("configuration")]
		[CompilerGenerated]
		public virtual PSPDFConfiguration GetConfiguration ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("configuration")));
			} else {
				return  Runtime.GetNSObject<PSPDFConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("configuration")));
			}
		}
		
		[Export ("PageView")]
		[CompilerGenerated]
		public virtual PSPDFPageView GetPageView ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("PageView")));
			} else {
				return  Runtime.GetNSObject<PSPDFPageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("PageView")));
			}
		}
		
		[Export ("PDFScale")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetPdfScale ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("PDFScale"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("PDFScale"));
			}
		}
		
		[Export ("isSelected")]
		[CompilerGenerated]
		public virtual bool GetSelected ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSelected"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSelected"));
			}
		}
		
		[Export ("zIndex")]
		[CompilerGenerated]
		public virtual global::System.nuint GetZIndex ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("zIndex"));
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zIndex"));
			}
		}
		
		[Export ("zoomScale")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetZoomScale ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("zoomScale"));
			} else {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomScale"));
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
		
		[Export ("newAnnotationsFromActionsList")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] NewAnnotationsFromActionsList ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("newAnnotationsFromActionsList")));
			} else {
				return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("newAnnotationsFromActionsList")));
			}
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
		
		[Export ("removeUndoHistory")]
		[CompilerGenerated]
		public virtual void RemoveUndoHistory ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeUndoHistory"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeUndoHistory"));
			}
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
		
		[Export ("setAnnotation:")]
		[CompilerGenerated]
		public virtual void SetAnnotation (PSPDFAnnotation annotation)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotation:"), annotation == null ? IntPtr.Zero : annotation.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotation:"), annotation == null ? IntPtr.Zero : annotation.Handle);
			}
		}
		
		[Export ("setConfiguration:")]
		[CompilerGenerated]
		public virtual void SetConfiguration (PSPDFConfiguration configuration)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConfiguration:"), configuration.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConfiguration:"), configuration.Handle);
			}
		}
		
		[Export ("setPageView:")]
		[CompilerGenerated]
		public virtual void SetPageView (PSPDFPageView PageView)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPageView:"), PageView == null ? IntPtr.Zero : PageView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPageView:"), PageView == null ? IntPtr.Zero : PageView.Handle);
			}
		}
		
		[Export ("setPDFScale:")]
		[CompilerGenerated]
		public virtual void SetPdfScale (global::System.nfloat pdfScale)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPDFScale:"), pdfScale);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPDFScale:"), pdfScale);
			}
		}
		
		[Export ("setSelected:")]
		[CompilerGenerated]
		public virtual void SetSelected (bool selected)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSelected:"), selected);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSelected:"), selected);
			}
		}
		
		[Export ("setZIndex:")]
		[CompilerGenerated]
		public virtual void SetZIndex (global::System.nuint index)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setZIndex:"), index);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setZIndex:"), index);
			}
		}
		
		[Export ("setZoomScale:")]
		[CompilerGenerated]
		public virtual void SetZoomScale (global::System.nfloat zoomScale)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setZoomScale:"), zoomScale);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setZoomScale:"), zoomScale);
			}
		}
		
		[Export ("shouldProcessTouches:withEvent:")]
		[CompilerGenerated]
		public virtual bool ShouldProcessTouches (NSSet touches, global::UIKit.UIEvent aEvent)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			if (aEvent == null)
				throw new ArgumentNullException ("aEvent");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("shouldProcessTouches:withEvent:"), touches.Handle, aEvent.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("shouldProcessTouches:withEvent:"), touches.Handle, aEvent.Handle);
			}
		}
		
		[Export ("shouldSyncRemovalFromSuperview")]
		[CompilerGenerated]
		public virtual bool ShouldSyncRemovalFromSuperview ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldSyncRemovalFromSuperview"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldSyncRemovalFromSuperview"));
			}
		}
		
		[Export ("startDrawingAtPoint:")]
		[CompilerGenerated]
		public virtual void StartDrawingAtPoint (CGPoint location)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("startDrawingAtPoint:"), location);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("startDrawingAtPoint:"), location);
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
		
		[Export ("updateActionsForAnnotations:")]
		[CompilerGenerated]
		public virtual void UpdateActionsForAnnotations (NSObject[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("updateActionsForAnnotations:"), nsa_annotations.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("updateActionsForAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("willRemoveFromSuperview")]
		[CompilerGenerated]
		public virtual void WillRemoveFromSuperview ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("willRemoveFromSuperview"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("willRemoveFromSuperview"));
			}
		}
		
		[Export ("writeChangesToAnnotations")]
		[CompilerGenerated]
		public virtual void WriteChangesToAnnotations ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("writeChangesToAnnotations"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("writeChangesToAnnotations"));
			}
		}
		
		[CompilerGenerated]
		object __mt_ActionList_var;
		[CompilerGenerated]
		public virtual NSObject[] ActionList {
			[Export ("actionList", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("actionList")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionList")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ActionList_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType AnnotationType {
			[Export ("annotationType", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("annotationType"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("annotationType"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationType"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationType"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setAnnotationType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setAnnotationType:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAnnotationType:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setAnnotationType:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAnnotationType:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string AnnotationVariant {
			[Export ("annotationVariant")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationVariant")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationVariant")));
				}
			}
			
			[Export ("setAnnotationVariant:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotationVariant:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotationVariant:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool CombineInk {
			[Export ("combineInk", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("combineInk"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("combineInk"));
				}
			}
			
			[Export ("setCombineInk:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCombineInk:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCombineInk:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CurrentAction_var;
		[CompilerGenerated]
		public virtual NSObject CurrentAction {
			[Export ("currentAction", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentAction")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentAction")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CurrentAction_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DashArray_var;
		[CompilerGenerated]
		public virtual NSObject[] DashArray {
			[Export ("dashArray", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dashArray")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dashArray")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DashArray_var = ret;
				return ret;
			}
			
			[Export ("setDashArray:", ArgumentSemantic.Retain)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDashArray:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDashArray:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_DashArray_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_FillColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor FillColor {
			[Export ("fillColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fillColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fillColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FillColor_var = ret;
				return ret;
			}
			
			[Export ("setFillColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFillColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFillColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FillColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDrawViewInputMode InputMode {
			[Export ("inputMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDrawViewInputMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDrawViewInputMode) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("inputMode"));
					} else {
						ret = (PSPDFDrawViewInputMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("inputMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDrawViewInputMode) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputMode"));
					} else {
						ret = (PSPDFDrawViewInputMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputMode"));
					}
				}
				return ret;
			}
			
			[Export ("setInputMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setInputMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setInputMode:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setInputMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setInputMode:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd1 {
			[Export ("lineEnd1", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFLineEndType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd1"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd1"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd1"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd1"));
					}
				}
				return ret;
			}
			
			[Export ("setLineEnd1:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLineEnd1:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLineEnd1:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLineEnd1:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLineEnd1:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLineEndType LineEnd2 {
			[Export ("lineEnd2", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFLineEndType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd2"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("lineEnd2"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd2"));
					} else {
						ret = (PSPDFLineEndType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineEnd2"));
					}
				}
				return ret;
			}
			
			[Export ("setLineEnd2:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLineEnd2:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLineEnd2:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLineEnd2:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLineEnd2:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat LineWidth {
			[Export ("lineWidth", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("lineWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineWidth"));
				}
			}
			
			[Export ("setLineWidth:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLineWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLineWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool NaturalDrawingEnabled {
			[Export ("naturalDrawingEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("naturalDrawingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("naturalDrawingEnabled"));
				}
			}
			
			[Export ("setNaturalDrawingEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setNaturalDrawingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setNaturalDrawingEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Scale {
			[Export ("scale", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("scale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scale"));
				}
			}
			
			[Export ("setScale:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setScale:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_StrokeColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor StrokeColor {
			[Export ("strokeColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("strokeColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("strokeColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_StrokeColor_var = ret;
				return ret;
			}
			
			[Export ("setStrokeColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStrokeColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStrokeColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_StrokeColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UndoController_var;
		[CompilerGenerated]
		public virtual PSPDFUndoController UndoController {
			[Export ("undoController", ArgumentSemantic.Retain)]
			get {
				PSPDFUndoController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFUndoController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("undoController")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFUndoController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("undoController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UndoController_var = ret;
				return ret;
			}
			
			[Export ("setUndoController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUndoController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUndoController:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UndoController_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ActionList_var = null;
				__mt_CurrentAction_var = null;
				__mt_DashArray_var = null;
				__mt_FillColor_var = null;
				__mt_StrokeColor_var = null;
				__mt_UndoController_var = null;
			}
		}
		public partial class PSPDFDrawViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFDrawViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFDrawViewAppearance Appearance {
			get { return new PSPDFDrawViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFDrawViewAppearance GetAppearance<T> () where T: PSPDFDrawView {
			return new PSPDFDrawViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFDrawViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFDrawViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFDrawViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFDrawViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFDrawViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFDrawViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFDrawViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFDrawView {
			return new PSPDFDrawViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFDrawViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFDrawView{
			return new PSPDFDrawViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PSPDFDrawView */
}
