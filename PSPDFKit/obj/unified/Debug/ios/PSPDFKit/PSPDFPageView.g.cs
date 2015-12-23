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
	[Register("PSPDFPageView", true)]
	public unsafe partial class PSPDFPageView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFPageView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFPageView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PSPDFPageView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFPageView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public PSPDFPageView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("addAnnotation:options:animated:")]
		[CompilerGenerated]
		public virtual void AddAnnotation (PSPDFAnnotation annotation, NSDictionary options, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("addAnnotation:options:animated:"), annotation.Handle, options == null ? IntPtr.Zero : options.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("addAnnotation:options:animated:"), annotation.Handle, options == null ? IntPtr.Zero : options.Handle, animated);
			}
		}
		
		[Export ("annotationChangedNotification:")]
		[CompilerGenerated]
		public virtual void AnnotationChangedNotification (NSNotification notification)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("annotationChangedNotification:"), notification.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationChangedNotification:"), notification.Handle);
			}
		}
		
		[Export ("annotationForAnnotationView:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation AnnotationForAnnotationView (IPSPDFAnnotationViewProtocol annotationView)
		{
			if (annotationView == null)
				throw new ArgumentNullException ("annotationView");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("annotationForAnnotationView:"), annotationView.Handle));
			} else {
				return  Runtime.GetNSObject<PSPDFAnnotation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationForAnnotationView:"), annotationView.Handle));
			}
		}
		
		[Export ("annotationsAddedNotification:")]
		[CompilerGenerated]
		public virtual void AnnotationsAddedNotification (NSNotification notification)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("annotationsAddedNotification:"), notification.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationsAddedNotification:"), notification.Handle);
			}
		}
		
		[Export ("annotationsRemovedNotification:")]
		[CompilerGenerated]
		public virtual void AnnotationsRemovedNotification (NSNotification notification)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("annotationsRemovedNotification:"), notification.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationsRemovedNotification:"), notification.Handle);
			}
		}
		
		[Export ("annotationViewForAnnotation:")]
		[CompilerGenerated]
		public virtual IPSPDFAnnotationViewProtocol AnnotationViewForAnnotation (PSPDFAnnotation annotation)
		{
			if (IsDirectBinding) {
				return  Runtime.GetINativeObject<IPSPDFAnnotationViewProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("annotationViewForAnnotation:"), annotation == null ? IntPtr.Zero : annotation.Handle), false);
			} else {
				return  Runtime.GetINativeObject<IPSPDFAnnotationViewProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationViewForAnnotation:"), annotation == null ? IntPtr.Zero : annotation.Handle), false);
			}
		}
		
		[Export ("centerAnnotation:aroundPDFPoint:")]
		[CompilerGenerated]
		public virtual void CenterAnnotation (PSPDFAnnotation annotation, CGPoint pdfPoint)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGPoint (this.Handle, Selector.GetHandle ("centerAnnotation:aroundPDFPoint:"), annotation.Handle, pdfPoint);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_CGPoint (this.SuperHandle, Selector.GetHandle ("centerAnnotation:aroundPDFPoint:"), annotation.Handle, pdfPoint);
			}
		}
		
		[Export ("colorMenuItemsForAnnotation:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] ColorMenuItemsForAnnotation (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("colorMenuItemsForAnnotation:"), annotation.Handle));
			} else {
				return NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("colorMenuItemsForAnnotation:"), annotation.Handle));
			}
		}
		
		[Export ("convertGlyphRectToViewRect:")]
		[CompilerGenerated]
		public virtual CGRect ConvertGlyphRectToViewRect (CGRect glyphRect)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("convertGlyphRectToViewRect:"), glyphRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertGlyphRectToViewRect:"), glyphRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertGlyphRectToViewRect:"), glyphRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertGlyphRectToViewRect:"), glyphRect);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("convertGlyphRectToViewRect:"), glyphRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertGlyphRectToViewRect:"), glyphRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertGlyphRectToViewRect:"), glyphRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertGlyphRectToViewRect:"), glyphRect);
				}
			}
			return ret;
		}
		
		[Export ("convertPDFPointToViewPoint:")]
		[CompilerGenerated]
		public virtual CGPoint ConvertPdfPointToViewPoint (CGPoint pdfPoint)
		{
			CGPoint ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("convertPDFPointToViewPoint:"), pdfPoint);
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret_CGPoint (out ret, this.Handle, Selector.GetHandle ("convertPDFPointToViewPoint:"), pdfPoint);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("convertPDFPointToViewPoint:"), pdfPoint);
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("convertPDFPointToViewPoint:"), pdfPoint);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("convertPDFPointToViewPoint:"), pdfPoint);
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret_CGPoint (out ret, this.SuperHandle, Selector.GetHandle ("convertPDFPointToViewPoint:"), pdfPoint);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("convertPDFPointToViewPoint:"), pdfPoint);
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("convertPDFPointToViewPoint:"), pdfPoint);
				}
			}
			return ret;
		}
		
		[Export ("convertPDFRectToViewRect:")]
		[CompilerGenerated]
		public virtual CGRect ConvertPdfRectToViewRect (CGRect pdfRect)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("convertPDFRectToViewRect:"), pdfRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertPDFRectToViewRect:"), pdfRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertPDFRectToViewRect:"), pdfRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertPDFRectToViewRect:"), pdfRect);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("convertPDFRectToViewRect:"), pdfRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertPDFRectToViewRect:"), pdfRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertPDFRectToViewRect:"), pdfRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertPDFRectToViewRect:"), pdfRect);
				}
			}
			return ret;
		}
		
		[Export ("convertViewPointToPDFPoint:")]
		[CompilerGenerated]
		public virtual CGPoint ConvertViewPointToPDFPoint (CGPoint viewPoint)
		{
			CGPoint ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("convertViewPointToPDFPoint:"), viewPoint);
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret_CGPoint (out ret, this.Handle, Selector.GetHandle ("convertViewPointToPDFPoint:"), viewPoint);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("convertViewPointToPDFPoint:"), viewPoint);
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("convertViewPointToPDFPoint:"), viewPoint);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("convertViewPointToPDFPoint:"), viewPoint);
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret_CGPoint (out ret, this.SuperHandle, Selector.GetHandle ("convertViewPointToPDFPoint:"), viewPoint);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("convertViewPointToPDFPoint:"), viewPoint);
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("convertViewPointToPDFPoint:"), viewPoint);
				}
			}
			return ret;
		}
		
		[Export ("convertViewRectToGlyphRect:")]
		[CompilerGenerated]
		public virtual CGRect ConvertViewRectToGlyphRect (CGRect viewRect)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("convertViewRectToGlyphRect:"), viewRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertViewRectToGlyphRect:"), viewRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertViewRectToGlyphRect:"), viewRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertViewRectToGlyphRect:"), viewRect);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("convertViewRectToGlyphRect:"), viewRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertViewRectToGlyphRect:"), viewRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertViewRectToGlyphRect:"), viewRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertViewRectToGlyphRect:"), viewRect);
				}
			}
			return ret;
		}
		
		[Export ("convertViewRectToPDFRect:")]
		[CompilerGenerated]
		public virtual CGRect ConvertViewRectToPdfRect (CGRect viewRect)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("convertViewRectToPDFRect:"), viewRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertViewRectToPDFRect:"), viewRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertViewRectToPDFRect:"), viewRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGRect (out ret, this.Handle, Selector.GetHandle ("convertViewRectToPDFRect:"), viewRect);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("convertViewRectToPDFRect:"), viewRect);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertViewRectToPDFRect:"), viewRect);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertViewRectToPDFRect:"), viewRect);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (out ret, this.SuperHandle, Selector.GetHandle ("convertViewRectToPDFRect:"), viewRect);
				}
			}
			return ret;
		}
		
		[Export ("defaultColorOptionsForAnnotationType:")]
		[CompilerGenerated]
		public virtual NSObject[] DefaultColorOptionsForAnnotationType (PSPDFAnnotationType annotationType)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("defaultColorOptionsForAnnotationType:"), (UInt64)annotationType));
				} else {
					return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("defaultColorOptionsForAnnotationType:"), (UInt32)annotationType));
				}
			} else {
				if (IntPtr.Size == 8) {
					return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("defaultColorOptionsForAnnotationType:"), (UInt64)annotationType));
				} else {
					return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("defaultColorOptionsForAnnotationType:"), (UInt32)annotationType));
				}
			}
		}
		
		[Export ("displayPage:pageRect:scale:presentationContext:")]
		[CompilerGenerated]
		public virtual void DisplayPage (global::System.nuint page, CGRect pageRect, global::System.nfloat scale, IPSPDFPresentationContext presentationContext)
		{
			if (presentationContext == null)
				throw new ArgumentNullException ("presentationContext");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint_CGRect_nfloat_IntPtr (this.Handle, Selector.GetHandle ("displayPage:pageRect:scale:presentationContext:"), page, pageRect, scale, presentationContext.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint_CGRect_nfloat_IntPtr (this.SuperHandle, Selector.GetHandle ("displayPage:pageRect:scale:presentationContext:"), page, pageRect, scale, presentationContext.Handle);
			}
		}
		
		[Export ("fillColorMenuItemsForAnnotation:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] FillColorMenuItemsForAnnotation (PSPDFAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fillColorMenuItemsForAnnotation:"), annotation.Handle));
			} else {
				return NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("fillColorMenuItemsForAnnotation:"), annotation.Handle));
			}
		}
		
		[Export ("hitTestRectForPoint:")]
		[CompilerGenerated]
		public virtual CGRect HitTestRectForPoint (CGPoint viewPoint)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("hitTestRectForPoint:"), viewPoint);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGPoint (out ret, this.Handle, Selector.GetHandle ("hitTestRectForPoint:"), viewPoint);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGPoint (out ret, this.Handle, Selector.GetHandle ("hitTestRectForPoint:"), viewPoint);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_CGPoint (out ret, this.Handle, Selector.GetHandle ("hitTestRectForPoint:"), viewPoint);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("hitTestRectForPoint:"), viewPoint);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGPoint (out ret, this.SuperHandle, Selector.GetHandle ("hitTestRectForPoint:"), viewPoint);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGPoint (out ret, this.SuperHandle, Selector.GetHandle ("hitTestRectForPoint:"), viewPoint);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_CGPoint (out ret, this.SuperHandle, Selector.GetHandle ("hitTestRectForPoint:"), viewPoint);
				}
			}
			return ret;
		}
		
		[Export ("insertAnnotations:forPage:inDocument:")]
		[CompilerGenerated]
		public virtual void InsertAnnotations (PSPDFAnnotation[] annotations, global::System.nuint page, PSPDFDocument document)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (document == null)
				throw new ArgumentNullException ("document");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("insertAnnotations:forPage:inDocument:"), nsa_annotations.Handle, page, document.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("insertAnnotations:forPage:inDocument:"), nsa_annotations.Handle, page, document.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("loadPageAnnotationsAnimated:blockWhileParsing:")]
		[CompilerGenerated]
		public virtual void LoadPageAnnotations (bool animated, bool blockWhileParsing)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("loadPageAnnotationsAnimated:blockWhileParsing:"), animated, blockWhileParsing);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("loadPageAnnotationsAnimated:blockWhileParsing:"), animated, blockWhileParsing);
			}
		}
		
		[Export ("longPress:")]
		[CompilerGenerated]
		public virtual bool LongPress (global::UIKit.UILongPressGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("longPress:"), recognizer.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("longPress:"), recognizer.Handle);
			}
		}
		
		[Export ("menuItemsForAnnotations:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] MenuItemsForAnnotations (PSPDFAnnotation[] annotations)
		{
			var nsa_annotations = annotations == null ? null : NSArray.FromNSObjects (annotations);
			
			PSPDFMenuItem[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("menuItemsForAnnotations:"), nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle));
			} else {
				ret = NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("menuItemsForAnnotations:"), nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle));
			}
			if (nsa_annotations != null)
				nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("menuItemsForNewAnnotationAtPoint:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem[] MenuItemsForNewAnnotationAtPoint (CGPoint point)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("menuItemsForNewAnnotationAtPoint:"), point));
			} else {
				return NSArray.ArrayFromHandle<PSPDFMenuItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("menuItemsForNewAnnotationAtPoint:"), point));
			}
		}
		
		[Export ("objectsAtPoint:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPoint (CGPoint viewPoint, NSDictionary options)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr (this.Handle, Selector.GetHandle ("objectsAtPoint:options:"), viewPoint, options == null ? IntPtr.Zero : options.Handle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGPoint_IntPtr (this.SuperHandle, Selector.GetHandle ("objectsAtPoint:options:"), viewPoint, options == null ? IntPtr.Zero : options.Handle));
			}
		}
		
		[Export ("objectsAtRect:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtRect (CGRect viewRect, NSDictionary options)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("objectsAtRect:options:"), viewRect, options == null ? IntPtr.Zero : options.Handle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("objectsAtRect:options:"), viewRect, options == null ? IntPtr.Zero : options.Handle));
			}
		}
		
		[Export ("opacityMenuItemForAnnotation:withColor:")]
		[CompilerGenerated]
		public virtual PSPDFMenuItem OpacityMenuItemForAnnotation (PSPDFAnnotation annotation, global::UIKit.UIColor color)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFMenuItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("opacityMenuItemForAnnotation:withColor:"), annotation.Handle, color == null ? IntPtr.Zero : color.Handle));
			} else {
				return  Runtime.GetNSObject<PSPDFMenuItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("opacityMenuItemForAnnotation:withColor:"), annotation.Handle, color == null ? IntPtr.Zero : color.Handle));
			}
		}
		
		[Export ("prepareForReuse")]
		[CompilerGenerated]
		public virtual void PrepareForReuse ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepareForReuse"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prepareForReuse"));
			}
		}
		
		[Export ("rectForAnnotations:")]
		[CompilerGenerated]
		public virtual CGRect RectForAnnotations (PSPDFAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("rectForAnnotations:"), nsa_annotations.Handle);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_IntPtr (out ret, this.Handle, Selector.GetHandle ("rectForAnnotations:"), nsa_annotations.Handle);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_IntPtr (out ret, this.Handle, Selector.GetHandle ("rectForAnnotations:"), nsa_annotations.Handle);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_IntPtr (out ret, this.Handle, Selector.GetHandle ("rectForAnnotations:"), nsa_annotations.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("rectForAnnotations:"), nsa_annotations.Handle);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("rectForAnnotations:"), nsa_annotations.Handle);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("rectForAnnotations:"), nsa_annotations.Handle);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("rectForAnnotations:"), nsa_annotations.Handle);
				}
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("removeAnnotation:options:animated:")]
		[CompilerGenerated]
		public virtual bool RemoveAnnotation (PSPDFAnnotation annotation, NSDictionary options, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("removeAnnotation:options:animated:"), annotation.Handle, options == null ? IntPtr.Zero : options.Handle, animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("removeAnnotation:options:animated:"), annotation.Handle, options == null ? IntPtr.Zero : options.Handle, animated);
			}
		}
		
		[Export ("renderOptionsDictWithZoomScale:animated:")]
		[CompilerGenerated]
		public virtual NSDictionary RenderOptionsDict (global::System.nfloat zoomScale, bool animated)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nfloat_bool (this.Handle, Selector.GetHandle ("renderOptionsDictWithZoomScale:animated:"), zoomScale, animated));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nfloat_bool (this.SuperHandle, Selector.GetHandle ("renderOptionsDictWithZoomScale:animated:"), zoomScale, animated));
			}
		}
		
		[Export ("selectAnnotation:animated:")]
		[CompilerGenerated]
		public virtual void SelectAnnotation (PSPDFAnnotation annotation, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("selectAnnotation:animated:"), annotation.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("selectAnnotation:animated:"), annotation.Handle, animated);
			}
		}
		
		[Export ("selectColorForAnnotation:isFillColor:")]
		[CompilerGenerated]
		public virtual void SelectColorForAnnotation (PSPDFAnnotation annotation, bool isFillColor)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("selectColorForAnnotation:isFillColor:"), annotation.Handle, isFillColor);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("selectColorForAnnotation:isFillColor:"), annotation.Handle, isFillColor);
			}
		}
		
		[Export ("setAnnotation:forAnnotationView:")]
		[CompilerGenerated]
		public virtual void SetAnnotation (PSPDFAnnotation annotation, IPSPDFAnnotationViewProtocol annotationView)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (annotationView == null)
				throw new ArgumentNullException ("annotationView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setAnnotation:forAnnotationView:"), annotation.Handle, annotationView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotation:forAnnotationView:"), annotation.Handle, annotationView.Handle);
			}
		}
		
		[Export ("shouldMoveStyleMenuEntriesIntoSubmenu")]
		[CompilerGenerated]
		public virtual bool ShouldMoveStyleMenuEntriesIntoSubmenu ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldMoveStyleMenuEntriesIntoSubmenu"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldMoveStyleMenuEntriesIntoSubmenu"));
			}
		}
		
		[Export ("shouldScaleAnnotationWhenResizing:usesResizeKnob:")]
		[CompilerGenerated]
		public virtual bool ShouldScaleAnnotationWhenResizing (PSPDFAnnotation annotation, bool usesResizeKnob)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("shouldScaleAnnotationWhenResizing:usesResizeKnob:"), annotation.Handle, usesResizeKnob);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("shouldScaleAnnotationWhenResizing:usesResizeKnob:"), annotation.Handle, usesResizeKnob);
			}
		}
		
		[Export ("showColorPickerForAnnotation:animated:")]
		[CompilerGenerated]
		public virtual void ShowColorPickerForAnnotation (PSPDFAnnotation annotation, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("showColorPickerForAnnotation:animated:"), annotation.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showColorPickerForAnnotation:animated:"), annotation.Handle, animated);
			}
		}
		
		[Export ("showDigitalSignatureMenuForSignatureField:animated:")]
		[CompilerGenerated]
		public virtual bool ShowDigitalSignatureMenuForSignatureField (PSPDFSignatureFormElement signatureField, bool animated)
		{
			if (signatureField == null)
				throw new ArgumentNullException ("signatureField");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("showDigitalSignatureMenuForSignatureField:animated:"), signatureField.Handle, animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showDigitalSignatureMenuForSignatureField:animated:"), signatureField.Handle, animated);
			}
		}
		
		[Export ("showFontPickerForAnnotation:animated:")]
		[CompilerGenerated]
		public virtual void ShowFontPickerForAnnotation (PSPDFFreeTextAnnotation annotation, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("showFontPickerForAnnotation:animated:"), annotation.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showFontPickerForAnnotation:animated:"), annotation.Handle, animated);
			}
		}
		
		[Export ("showInspectorForAnnotations:options:animated:")]
		[CompilerGenerated]
		public virtual NSObject ShowInspectorForAnnotations (PSPDFAnnotation[] annotations, NSDictionary options, bool animated)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("showInspectorForAnnotations:options:animated:"), nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, animated));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showInspectorForAnnotations:options:animated:"), nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, animated));
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[Export ("showLinkPreviewActionSheetForAnnotation:fromRect:animated:")]
		[CompilerGenerated]
		public virtual bool ShowLinkPreviewActionSheetForAnnotation (PSPDFLinkAnnotation annotation, CGRect viewRect, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_CGRect_bool (this.Handle, Selector.GetHandle ("showLinkPreviewActionSheetForAnnotation:fromRect:animated:"), annotation.Handle, viewRect, animated);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_bool (this.SuperHandle, Selector.GetHandle ("showLinkPreviewActionSheetForAnnotation:fromRect:animated:"), annotation.Handle, viewRect, animated);
			}
		}
		
		[Export ("showMenuForAnnotations:targetRect:allowPopovers:animated:")]
		[CompilerGenerated]
		public virtual void ShowMenuForAnnotations (PSPDFAnnotation[] annotations, CGRect targetRect, bool allowPopovers, bool animated)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGRect_bool_bool (this.Handle, Selector.GetHandle ("showMenuForAnnotations:targetRect:allowPopovers:animated:"), nsa_annotations.Handle, targetRect, allowPopovers, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_CGRect_bool_bool (this.SuperHandle, Selector.GetHandle ("showMenuForAnnotations:targetRect:allowPopovers:animated:"), nsa_annotations.Handle, targetRect, allowPopovers, animated);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("showMenuIfSelectedAnimated:")]
		[CompilerGenerated]
		public virtual void ShowMenuIfSelected (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("showMenuIfSelectedAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("showMenuIfSelectedAnimated:"), animated);
			}
		}
		
		[Export ("showMenuIfSelectedAnimated:allowPopovers:")]
		[CompilerGenerated]
		public virtual void ShowMenuIfSelected (bool animated, bool allowPopovers)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("showMenuIfSelectedAnimated:allowPopovers:"), animated, allowPopovers);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("showMenuIfSelectedAnimated:allowPopovers:"), animated, allowPopovers);
			}
		}
		
		[Export ("showNewSignatureMenuAtRect:animated:")]
		[CompilerGenerated]
		public virtual void ShowNewSignatureMenuAtRect (CGRect viewRect, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect_bool (this.Handle, Selector.GetHandle ("showNewSignatureMenuAtRect:animated:"), viewRect, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect_bool (this.SuperHandle, Selector.GetHandle ("showNewSignatureMenuAtRect:animated:"), viewRect, animated);
			}
		}
		
		[Export ("showNoteControllerForAnnotation:showKeyboard:animated:")]
		[CompilerGenerated]
		public virtual PSPDFNoteAnnotationViewController ShowNoteControllerForAnnotation (PSPDFAnnotation annotation, bool showKeyboard, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFNoteAnnotationViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool (this.Handle, Selector.GetHandle ("showNoteControllerForAnnotation:showKeyboard:animated:"), annotation.Handle, showKeyboard, animated));
			} else {
				return  Runtime.GetNSObject<PSPDFNoteAnnotationViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool (this.SuperHandle, Selector.GetHandle ("showNoteControllerForAnnotation:showKeyboard:animated:"), annotation.Handle, showKeyboard, animated));
			}
		}
		
		[Export ("showSignatureControllerAtRect:withTitle:shouldSaveSignature:animated:")]
		[CompilerGenerated]
		public virtual void ShowSignatureControllerAtRect (CGRect viewRect, string title, bool shouldSaveSignature, bool animated)
		{
			var nstitle = NSString.CreateNative (title);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGRect_IntPtr_bool_bool (this.Handle, Selector.GetHandle ("showSignatureControllerAtRect:withTitle:shouldSaveSignature:animated:"), viewRect, nstitle, shouldSaveSignature, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGRect_IntPtr_bool_bool (this.SuperHandle, Selector.GetHandle ("showSignatureControllerAtRect:withTitle:shouldSaveSignature:animated:"), viewRect, nstitle, shouldSaveSignature, animated);
			}
			NSString.ReleaseNative (nstitle);
			
		}
		
		[Export ("singleTapped:")]
		[CompilerGenerated]
		public virtual bool SingleTapped (global::UIKit.UITapGestureRecognizer recognizer)
		{
			if (recognizer == null)
				throw new ArgumentNullException ("recognizer");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("singleTapped:"), recognizer.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("singleTapped:"), recognizer.Handle);
			}
		}
		
		[Export ("singleTappedAtViewPoint:")]
		[CompilerGenerated]
		public virtual bool SingleTappedAtViewPoint (CGPoint viewPoint)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("singleTappedAtViewPoint:"), viewPoint);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("singleTappedAtViewPoint:"), viewPoint);
			}
		}
		
		[Export ("tappableAnnotationsAtPoint:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] TappableAnnotations (CGPoint viewPoint)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("tappableAnnotationsAtPoint:"), viewPoint));
			} else {
				return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("tappableAnnotationsAtPoint:"), viewPoint));
			}
		}
		
		[Export ("tappableAnnotationsForLongPressAtPoint:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] TappableAnnotationsForLongPress (CGPoint viewPoint)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("tappableAnnotationsForLongPressAtPoint:"), viewPoint));
			} else {
				return NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("tappableAnnotationsForLongPressAtPoint:"), viewPoint));
			}
		}
		
		[Export ("updateAnnotationSelectionView")]
		[CompilerGenerated]
		public virtual void UpdateAnnotationSelectionView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateAnnotationSelectionView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateAnnotationSelectionView"));
			}
		}
		
		[Export ("updateRenderView")]
		[CompilerGenerated]
		public virtual void UpdateRenderView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateRenderView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateRenderView"));
			}
		}
		
		[Export ("updateShadowAnimated:")]
		[CompilerGenerated]
		public virtual void UpdateShadow (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("updateShadowAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("updateShadowAnimated:"), animated);
			}
		}
		
		[Export ("updateView")]
		[CompilerGenerated]
		public virtual void UpdateView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateView"));
			}
		}
		
		[Export ("useAnnotationInspectorForAnnotations:")]
		[CompilerGenerated]
		public virtual bool UseAnnotationInspectorForAnnotations (PSPDFAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("useAnnotationInspectorForAnnotations:"), nsa_annotations.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("useAnnotationInspectorForAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_AnnotationContainerView_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationContainerView AnnotationContainerView {
			[Export ("annotationContainerView", ArgumentSemantic.Retain)]
			get {
				PSPDFAnnotationContainerView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFAnnotationContainerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationContainerView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFAnnotationContainerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationContainerView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationContainerView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationSelectionView_var;
		[CompilerGenerated]
		public virtual PSPDFResizableView AnnotationSelectionView {
			[Export ("annotationSelectionView", ArgumentSemantic.Retain)]
			get {
				PSPDFResizableView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFResizableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationSelectionView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFResizableView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationSelectionView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationSelectionView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AvailableFontSizes_var;
		[CompilerGenerated]
		public virtual NSNumber[] AvailableFontSizes {
			[Export ("availableFontSizes")]
			get {
				NSNumber[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("availableFontSizes")));
				} else {
					ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availableFontSizes")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AvailableFontSizes_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AvailableLineWidths_var;
		[CompilerGenerated]
		public virtual NSNumber[] AvailableLineWidths {
			[Export ("availableLineWidths")]
			get {
				NSNumber[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("availableLineWidths")));
				} else {
					ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availableLineWidths")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AvailableLineWidths_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImageView ContentView {
			[Export ("contentView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_HighlightColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor HighlightColor {
			[Export ("highlightColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("highlightColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("highlightColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HighlightColor_var = ret;
				return ret;
			}
			
			[Export ("setHighlightColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHighlightColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHighlightColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_HighlightColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Page {
			[Export ("page", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("page"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("page"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageInfo_var;
		[CompilerGenerated]
		public virtual PSPDFPageInfo PageInfo {
			[Export ("pageInfo", ArgumentSemantic.Retain)]
			get {
				PSPDFPageInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageInfo")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageInfo")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageInfo_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ParentViewController_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController ParentViewController {
			[Export ("parentViewController")]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("parentViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parentViewController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParentViewController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PassthroughViewsForPopoverController_var;
		[CompilerGenerated]
		public virtual NSNumber[] PassthroughViewsForPopoverController {
			[Export ("passthroughViewsForPopoverController")]
			get {
				NSNumber[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("passthroughViewsForPopoverController")));
				} else {
					ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("passthroughViewsForPopoverController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PassthroughViewsForPopoverController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat PdfScale {
			[Export ("PDFScale", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("PDFScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("PDFScale"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PresentationContext_var;
		[CompilerGenerated]
		public virtual IPSPDFPresentationContext PresentationContext {
			[Export ("presentationContext", ArgumentSemantic.Weak)]
			get {
				IPSPDFPresentationContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("presentationContext")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFPresentationContext> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presentationContext")), false);
				}
				MarkDirty ();
				__mt_PresentationContext_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RenderStatusView_var;
		[CompilerGenerated]
		public virtual PSPDFRenderStatusView RenderStatusView {
			[Export ("renderStatusView", ArgumentSemantic.Retain)]
			get {
				PSPDFRenderStatusView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFRenderStatusView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("renderStatusView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFRenderStatusView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderStatusView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RenderStatusView_var = ret;
				return ret;
			}
			
			[Export ("setRenderStatusView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRenderStatusView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRenderStatusView:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RenderStatusView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat RenderStatusViewOffset {
			[Export ("renderStatusViewOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("renderStatusViewOffset"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderStatusViewOffset"));
				}
			}
			
			[Export ("setRenderStatusViewOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRenderStatusViewOffset:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRenderStatusViewOffset:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_RenderView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImageView RenderView {
			[Export ("renderView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("renderView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RenderView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RightPage {
			[Export ("isRightPage", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightPage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightPage"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ScaleForPageView {
			[Export ("scaleForPageView")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("scaleForPageView"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scaleForPageView"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ScrollView_var;
		[CompilerGenerated]
		public virtual PSPDFScrollView ScrollView {
			[Export ("scrollView")]
			get {
				PSPDFScrollView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFScrollView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SelectedAnnotations_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotation[] SelectedAnnotations {
			[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
			get {
				PSPDFAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedAnnotations")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedAnnotations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedAnnotations_var = ret;
				return ret;
			}
			
			[Export ("setSelectedAnnotations:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedAnnotations:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedAnnotations:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_SelectedAnnotations_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectionView_var;
		[CompilerGenerated]
		public virtual PSPDFTextSelectionView SelectionView {
			[Export ("selectionView", ArgumentSemantic.Retain)]
			get {
				PSPDFTextSelectionView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFTextSelectionView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectionView")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFTextSelectionView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectionView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectionView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_VisibleAnnotationViews_var;
		[CompilerGenerated]
		public virtual IPSPDFAnnotationViewProtocol[] VisibleAnnotationViews {
			[Export ("visibleAnnotationViews")]
			get {
				IPSPDFAnnotationViewProtocol[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<IPSPDFAnnotationViewProtocol>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("visibleAnnotationViews")));
				} else {
					ret = NSArray.ArrayFromHandle<IPSPDFAnnotationViewProtocol>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visibleAnnotationViews")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_VisibleAnnotationViews_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGRect VisibleRect {
			[Export ("visibleRect", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("visibleRect"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("visibleRect"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("visibleRect"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("visibleRect"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("visibleRect"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("visibleRect"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("visibleRect"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("visibleRect"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _SelectedAnnotationsDidChangeNotification;
		[Field ("PSPDFPageViewSelectedAnnotationsDidChangeNotification",  "__Internal")]
		public static unsafe NSString SelectedAnnotationsDidChangeNotification {
			get {
				if (_SelectedAnnotationsDidChangeNotification == null)
					_SelectedAnnotationsDidChangeNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFPageViewSelectedAnnotationsDidChangeNotification");
				return _SelectedAnnotationsDidChangeNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AnnotationContainerView_var = null;
				__mt_AnnotationSelectionView_var = null;
				__mt_AvailableFontSizes_var = null;
				__mt_AvailableLineWidths_var = null;
				__mt_ContentView_var = null;
				__mt_HighlightColor_var = null;
				__mt_PageInfo_var = null;
				__mt_ParentViewController_var = null;
				__mt_PassthroughViewsForPopoverController_var = null;
				__mt_PresentationContext_var = null;
				__mt_RenderStatusView_var = null;
				__mt_RenderView_var = null;
				__mt_ScrollView_var = null;
				__mt_SelectedAnnotations_var = null;
				__mt_SelectionView_var = null;
				__mt_VisibleAnnotationViews_var = null;
			}
		}
		public partial class PSPDFPageViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal PSPDFPageViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PSPDFPageViewAppearance Appearance {
			get { return new PSPDFPageViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PSPDFPageViewAppearance GetAppearance<T> () where T: PSPDFPageView {
			return new PSPDFPageViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PSPDFPageViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PSPDFPageViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PSPDFPageViewAppearance GetAppearance (UITraitCollection traits) {
			return new PSPDFPageViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PSPDFPageViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PSPDFPageViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PSPDFPageViewAppearance GetAppearance<T> (UITraitCollection traits) where T: PSPDFPageView {
			return new PSPDFPageViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PSPDFPageViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PSPDFPageView{
			return new PSPDFPageViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveSelectedAnnotationsDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedAnnotationsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFPageView */
}
