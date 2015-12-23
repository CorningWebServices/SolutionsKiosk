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
	[Register("PSPDFDocument", true)]
	public unsafe partial class PSPDFDocument : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDocument");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDocument () : base (NSObjectFlag.Empty)
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
		protected PSPDFDocument (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDocument (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithURL:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithURL:"), url.Handle), "initWithURL:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithURL:"), url.Handle), "initWithURL:");
			}
		}
		
		[Export ("initWithData:")]
		[CompilerGenerated]
		public PSPDFDocument (NSData data)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithData:"), data.Handle), "initWithData:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithData:"), data.Handle), "initWithData:");
			}
		}
		
		[Export ("initWithDataArray:")]
		[CompilerGenerated]
		public PSPDFDocument (NSData[] data)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsa_data = NSArray.FromNSObjects (data);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDataArray:"), nsa_data.Handle), "initWithDataArray:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDataArray:"), nsa_data.Handle), "initWithDataArray:");
			}
			nsa_data.Dispose ();
			
		}
		
		[Export ("initWithDataProviderArray:")]
		[CompilerGenerated]
		public PSPDFDocument (CGDataProvider[] dataProviders)
			: base (NSObjectFlag.Empty)
		{
			if (dataProviders == null)
				throw new ArgumentNullException ("dataProviders");
			var nsa_dataProviders = NSArray.FromNSObjects (dataProviders);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDataProviderArray:"), nsa_dataProviders.Handle), "initWithDataProviderArray:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDataProviderArray:"), nsa_dataProviders.Handle), "initWithDataProviderArray:");
			}
			nsa_dataProviders.Dispose ();
			
		}
		
		[Export ("initWithBaseURL:files:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl baseUrl, string[] files)
			: base (NSObjectFlag.Empty)
		{
			if (files == null)
				throw new ArgumentNullException ("files");
			var nsa_files = NSArray.FromStrings (files);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithBaseURL:files:"), baseUrl == null ? IntPtr.Zero : baseUrl.Handle, nsa_files.Handle), "initWithBaseURL:files:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithBaseURL:files:"), baseUrl == null ? IntPtr.Zero : baseUrl.Handle, nsa_files.Handle), "initWithBaseURL:files:");
			}
			nsa_files.Dispose ();
			
		}
		
		[Export ("initWithBaseURL:fileTemplate:startPage:endPage:")]
		[CompilerGenerated]
		public PSPDFDocument (NSUrl baseUrl, string fileTemplate, global::System.nint startPage, global::System.nint endPage)
			: base (NSObjectFlag.Empty)
		{
			if (fileTemplate == null)
				throw new ArgumentNullException ("fileTemplate");
			var nsfileTemplate = NSString.CreateNative (fileTemplate);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint_nint (this.Handle, Selector.GetHandle ("initWithBaseURL:fileTemplate:startPage:endPage:"), baseUrl == null ? IntPtr.Zero : baseUrl.Handle, nsfileTemplate, startPage, endPage), "initWithBaseURL:fileTemplate:startPage:endPage:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint_nint (this.SuperHandle, Selector.GetHandle ("initWithBaseURL:fileTemplate:startPage:endPage:"), baseUrl == null ? IntPtr.Zero : baseUrl.Handle, nsfileTemplate, startPage, endPage), "initWithBaseURL:fileTemplate:startPage:endPage:");
			}
			NSString.ReleaseNative (nsfileTemplate);
			
		}
		
		[Export ("initWithContent:")]
		[CompilerGenerated]
		public PSPDFDocument (NSObject content)
			: base (NSObjectFlag.Empty)
		{
			if (content == null)
				throw new ArgumentNullException ("content");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithContent:"), content.Handle), "initWithContent:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithContent:"), content.Handle), "initWithContent:");
			}
		}
		
		[Export ("initWithContent:signatures:")]
		[CompilerGenerated]
		public PSPDFDocument (NSObject content, NSObject[] signatures)
			: base (NSObjectFlag.Empty)
		{
			if (content == null)
				throw new ArgumentNullException ("content");
			var nsa_signatures = signatures == null ? null : NSArray.FromNSObjects (signatures);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithContent:signatures:"), content.Handle, nsa_signatures == null ? IntPtr.Zero : nsa_signatures.Handle), "initWithContent:signatures:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithContent:signatures:"), content.Handle, nsa_signatures == null ? IntPtr.Zero : nsa_signatures.Handle), "initWithContent:signatures:");
			}
			if (nsa_signatures != null)
				nsa_signatures.Dispose ();
			
		}
		
		[Export ("ensureDataDirectoryExistsWithError:")]
		[CompilerGenerated]
		internal virtual bool _EnsureDataDirectoryExists (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("ensureDataDirectoryExistsWithError:"), error);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("ensureDataDirectoryExistsWithError:"), error);
			}
		}
		
		[Export ("addAnnotations:")]
		[CompilerGenerated]
		public virtual bool AddAnnotations (PSPDFAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAnnotations:"), nsa_annotations.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
			return ret;
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
		
		[Export ("allAnnotationsOfType:")]
		[CompilerGenerated]
		public virtual NSDictionary AllAnnotationsOfType (PSPDFAnnotationType annotationType)
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
		
		[Export ("annotationManagerForPage:")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationManager AnnotationManagerForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFAnnotationManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("annotationManagerForPage:"), page));
			} else {
				return  Runtime.GetNSObject<PSPDFAnnotationManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("annotationManagerForPage:"), page));
			}
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
		
		[Export ("annotationsFromDetectingLinkTypes:pagesInRange:options:progress:error:")]
		[CompilerGenerated]
		public unsafe virtual NSDictionary AnnotationsFromDetectingLinkTypes (PSPDFTextCheckingType textLinkTypes, NSIndexSet pageRange, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<PSPDFAnnotation[], global::System.nuint, bool> progressBlock, out NSError error)
		{
			if (pageRange == null)
				throw new ArgumentNullException ("pageRange");
			IntPtr errorValue = IntPtr.Zero;
			
			BlockLiteral *block_ptr_progressBlock;
			BlockLiteral block_progressBlock;
			if (progressBlock == null){
				block_ptr_progressBlock = null;
			} else {
				block_progressBlock = new BlockLiteral ();
				block_ptr_progressBlock = &block_progressBlock;
				block_progressBlock.SetupBlock (Trampolines.SDActionArity3V0.Handler, progressBlock);
			}
			
			NSDictionary ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("annotationsFromDetectingLinkTypes:pagesInRange:options:progress:error:"), (UInt64)textLinkTypes, pageRange.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_progressBlock, ref errorValue));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("annotationsFromDetectingLinkTypes:pagesInRange:options:progress:error:"), (UInt32)textLinkTypes, pageRange.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_progressBlock, ref errorValue));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationsFromDetectingLinkTypes:pagesInRange:options:progress:error:"), (UInt64)textLinkTypes, pageRange.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_progressBlock, ref errorValue));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("annotationsFromDetectingLinkTypes:pagesInRange:options:progress:error:"), (UInt32)textLinkTypes, pageRange.Handle, options == null ? IntPtr.Zero : options.Handle, (IntPtr) block_ptr_progressBlock, ref errorValue));
				}
			}
			if (block_ptr_progressBlock != null)
				block_ptr_progressBlock->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("backgroundColorForPage:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BackgroundColorForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("backgroundColorForPage:"), page));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("backgroundColorForPage:"), page));
			}
		}
		
		[Export ("boxRect:forPage:error:")]
		[CompilerGenerated]
		internal virtual CGRect BoxRectForPage (CGPDFBox boxType, global::System.nuint page, global::System.IntPtr error)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend_int_nuint_IntPtr (this.Handle, Selector.GetHandle ("boxRect:forPage:error:"), (int)boxType, page, error);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_int_nuint_IntPtr (out ret, this.Handle, Selector.GetHandle ("boxRect:forPage:error:"), (int)boxType, page, error);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_int_nuint_IntPtr (out ret, this.Handle, Selector.GetHandle ("boxRect:forPage:error:"), (int)boxType, page, error);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret_int_nuint_IntPtr (out ret, this.Handle, Selector.GetHandle ("boxRect:forPage:error:"), (int)boxType, page, error);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_int_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("boxRect:forPage:error:"), (int)boxType, page, error);
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_int_nuint_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("boxRect:forPage:error:"), (int)boxType, page, error);
					}
				} else if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_int_nuint_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("boxRect:forPage:error:"), (int)boxType, page, error);
				} else {
					global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret_int_nuint_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("boxRect:forPage:error:"), (int)boxType, page, error);
				}
			}
			return ret;
		}
		
		[Export ("clearCache")]
		[CompilerGenerated]
		public virtual void ClearCache ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearCache"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearCache"));
			}
		}
		
		[Export ("deserializeLibraryMetadata:error:")]
		[CompilerGenerated]
		public static NSDictionary DeserializeLibraryMetadata (NSData data, out NSError error)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IntPtr errorValue = IntPtr.Zero;
			
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("deserializeLibraryMetadata:error:"), data.Handle, ref errorValue));
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("didCreateDocumentProvider:")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DidCreateDocumentProvider (PSPDFDocumentProvider documentProvider)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didCreateDocumentProvider:"), documentProvider.Handle));
			} else {
				return  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didCreateDocumentProvider:"), documentProvider.Handle));
			}
		}
		
		[Export ("documentByAppendingObjects:")]
		[CompilerGenerated]
		public virtual PSPDFDocument DocumentByAppendingObjects (NSObject[] objects)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			var nsa_objects = NSArray.FromNSObjects (objects);
			
			PSPDFDocument ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("documentByAppendingObjects:"), nsa_objects.Handle));
			} else {
				ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("documentByAppendingObjects:"), nsa_objects.Handle));
			}
			nsa_objects.Dispose ();
			
			return ret;
		}
		
		[Export ("documentProviderForPage:")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider DocumentProviderForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("documentProviderForPage:"), page));
			} else {
				return  Runtime.GetNSObject<PSPDFDocumentProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("documentProviderForPage:"), page));
			}
		}
		
		[Export ("documentProviderRelativePageForPage:")]
		[CompilerGenerated]
		public virtual global::System.nuint DocumentProviderRelativePageForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("documentProviderRelativePageForPage:"), page);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("documentProviderRelativePageForPage:"), page);
			}
		}
		
		[Export ("documentProviderRelativePageWithPageRangeCompensated:")]
		[CompilerGenerated]
		public virtual global::System.nuint DocumentProviderRelativePageWithPageRangeCompensated (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("documentProviderRelativePageWithPageRangeCompensated:"), page);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("documentProviderRelativePageWithPageRangeCompensated:"), page);
			}
		}
		
		[Export ("documentProviders")]
		[CompilerGenerated]
		public virtual PSPDFDocumentProvider[] DocumentProviders ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFDocumentProvider>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentProviders")));
			} else {
				return NSArray.ArrayFromHandle<PSPDFDocumentProvider>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentProviders")));
			}
		}
		
		[Export ("fileIndexForPage:")]
		[CompilerGenerated]
		public virtual global::System.nint FileIndexForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nint_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("fileIndexForPage:"), page);
			} else {
				return global::ApiDefinition.Messaging.nint_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("fileIndexForPage:"), page);
			}
		}
		
		[Export ("fileNameForIndex:")]
		[CompilerGenerated]
		public virtual string FileNameForIndex (global::System.nuint fileIndex)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("fileNameForIndex:"), fileIndex));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("fileNameForIndex:"), fileIndex));
			}
		}
		
		[Export ("fileNameForPage:")]
		[CompilerGenerated]
		public virtual string FileNameForPage (global::System.nuint pageIndex)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("fileNameForPage:"), pageIndex));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("fileNameForPage:"), pageIndex));
			}
		}
		
		[Export ("fillCache")]
		[CompilerGenerated]
		public virtual void FillCache ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("fillCache"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fillCache"));
			}
		}
		
		[Export ("documentWithBaseURL:files:")]
		[CompilerGenerated]
		public static PSPDFDocument FromBaseUrl (NSUrl baseUrl, string[] files)
		{
			if (files == null)
				throw new ArgumentNullException ("files");
			var nsa_files = NSArray.FromStrings (files);
			
			PSPDFDocument ret;
			ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("documentWithBaseURL:files:"), baseUrl == null ? IntPtr.Zero : baseUrl.Handle, nsa_files.Handle));
			nsa_files.Dispose ();
			
			return ret;
		}
		
		[Export ("documentWithBaseURL:fileTemplate:startPage:endPage:")]
		[CompilerGenerated]
		public static PSPDFDocument FromBaseUrl (NSUrl baseUrl, string fileTemplate, global::System.nint startPage, global::System.nint endPage)
		{
			if (fileTemplate == null)
				throw new ArgumentNullException ("fileTemplate");
			var nsfileTemplate = NSString.CreateNative (fileTemplate);
			
			PSPDFDocument ret;
			ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint_nint (class_ptr, Selector.GetHandle ("documentWithBaseURL:fileTemplate:startPage:endPage:"), baseUrl == null ? IntPtr.Zero : baseUrl.Handle, nsfileTemplate, startPage, endPage));
			NSString.ReleaseNative (nsfileTemplate);
			
			return ret;
		}
		
		[Export ("documentWithContent:")]
		[CompilerGenerated]
		public static PSPDFDocument FromContent (NSObject content)
		{
			if (content == null)
				throw new ArgumentNullException ("content");
			return  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("documentWithContent:"), content.Handle));
		}
		
		[Export ("documentWithContent:signatures:")]
		[CompilerGenerated]
		public static PSPDFDocument FromContent (NSObject content, NSObject[] signatures)
		{
			if (content == null)
				throw new ArgumentNullException ("content");
			var nsa_signatures = signatures == null ? null : NSArray.FromNSObjects (signatures);
			
			PSPDFDocument ret;
			ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("documentWithContent:signatures:"), content.Handle, nsa_signatures == null ? IntPtr.Zero : nsa_signatures.Handle));
			if (nsa_signatures != null)
				nsa_signatures.Dispose ();
			
			return ret;
		}
		
		[Export ("documentWithData:")]
		[CompilerGenerated]
		public static PSPDFDocument FromData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("documentWithData:"), data.Handle));
		}
		
		[Export ("documentWithDataArray:")]
		[CompilerGenerated]
		public static PSPDFDocument FromData (NSData[] data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsa_data = NSArray.FromNSObjects (data);
			
			PSPDFDocument ret;
			ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("documentWithDataArray:"), nsa_data.Handle));
			nsa_data.Dispose ();
			
			return ret;
		}
		
		[Export ("documentWithDataProvider:")]
		[CompilerGenerated]
		internal static PSPDFDocument FromDataProvider (global::System.IntPtr dataProvider)
		{
			return  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("documentWithDataProvider:"), dataProvider));
		}
		
		[Export ("documentWithDataProviderArray:")]
		[CompilerGenerated]
		public static PSPDFDocument FromDataProvider (CGDataProvider[] dataProviders)
		{
			if (dataProviders == null)
				throw new ArgumentNullException ("dataProviders");
			var nsa_dataProviders = NSArray.FromNSObjects (dataProviders);
			
			PSPDFDocument ret;
			ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("documentWithDataProviderArray:"), nsa_dataProviders.Handle));
			nsa_dataProviders.Dispose ();
			
			return ret;
		}
		
		[Export ("documentWithURL:")]
		[CompilerGenerated]
		public static PSPDFDocument FromUrl (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("documentWithURL:"), url.Handle));
		}
		
		[Export ("imageForPage:size:clippedToRect:annotations:options:receipt:error:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIImage ImageForPage (global::System.nuint page, CGSize size, CGRect clipRect, PSPDFAnnotation[] annotations, NSDictionary options, out PSPDFRenderReceipt receipt, out NSError error)
		{
			IntPtr receiptValue = IntPtr.Zero;
			IntPtr errorValue = IntPtr.Zero;
			
			var nsa_annotations = annotations == null ? null : NSArray.FromNSObjects (annotations);
			
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_CGSize_CGRect_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("imageForPage:size:clippedToRect:annotations:options:receipt:error:"), page, size, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, ref receiptValue, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_CGSize_CGRect_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("imageForPage:size:clippedToRect:annotations:options:receipt:error:"), page, size, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, ref receiptValue, ref errorValue));
			}
			if (nsa_annotations != null)
				nsa_annotations.Dispose ();
			
			
			receipt = receiptValue != IntPtr.Zero ? Runtime.GetNSObject<PSPDFKit.PSPDFRenderReceipt> (receiptValue) : null;
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("isEqualToDocument:")]
		[CompilerGenerated]
		public virtual bool IsEqualToDocument (PSPDFDocument otherDocument)
		{
			if (otherDocument == null)
				throw new ArgumentNullException ("otherDocument");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualToDocument:"), otherDocument.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualToDocument:"), otherDocument.Handle);
			}
		}
		
		[Export ("lock")]
		[CompilerGenerated]
		public virtual void Lock ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("lock"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lock"));
			}
		}
		
		[Export ("objectsAtPDFPoint:page:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPdfPoint (CGPoint pdfPoint, global::System.nuint page, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGPoint_nuint_IntPtr (this.Handle, Selector.GetHandle ("objectsAtPDFPoint:page:options:"), pdfPoint, page, options.Handle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGPoint_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("objectsAtPDFPoint:page:options:"), pdfPoint, page, options.Handle));
			}
		}
		
		[Export ("objectsAtPDFRect:page:options:")]
		[CompilerGenerated]
		public virtual NSDictionary ObjectsAtPdfRect (CGRect pdfRect, global::System.nuint page, NSDictionary options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_nuint_IntPtr (this.Handle, Selector.GetHandle ("objectsAtPDFRect:page:options:"), pdfRect, page, options.Handle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("objectsAtPDFRect:page:options:"), pdfRect, page, options.Handle));
			}
		}
		
		[Export ("overrideClass:withClass:")]
		[CompilerGenerated]
		public virtual void OverrideClass (Class builtinClass, Class subclass)
		{
			if (builtinClass == null)
				throw new ArgumentNullException ("builtinClass");
			if (subclass == null)
				throw new ArgumentNullException ("subclass");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("overrideClass:withClass:"), builtinClass.Handle, subclass.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("overrideClass:withClass:"), builtinClass.Handle, subclass.Handle);
			}
		}
		
		[Export ("pageContentForPage:")]
		[CompilerGenerated]
		public virtual string PageContentForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("pageContentForPage:"), page));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("pageContentForPage:"), page));
			}
		}
		
		[Export ("pageForPageLabel:partialMatching:")]
		[CompilerGenerated]
		public virtual global::System.nuint PageForPageLabel (string pageLabel, bool partialMatching)
		{
			if (pageLabel == null)
				throw new ArgumentNullException ("pageLabel");
			var nspageLabel = NSString.CreateNative (pageLabel);
			
			global::System.nuint ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.nuint_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("pageForPageLabel:partialMatching:"), nspageLabel, partialMatching);
			} else {
				ret = global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("pageForPageLabel:partialMatching:"), nspageLabel, partialMatching);
			}
			NSString.ReleaseNative (nspageLabel);
			
			return ret;
		}
		
		[Export ("pageInfoForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageInfo PageInfoForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("pageInfoForPage:"), page));
			} else {
				return  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("pageInfoForPage:"), page));
			}
		}
		
		[Export ("pageInfoForPage:pageRef:")]
		[CompilerGenerated]
		internal virtual PSPDFPageInfo PageInfoForPage (global::System.nuint page, global::System.IntPtr pageRef)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_IntPtr (this.Handle, Selector.GetHandle ("pageInfoForPage:pageRef:"), page, pageRef));
			} else {
				return  Runtime.GetNSObject<PSPDFPageInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("pageInfoForPage:pageRef:"), page, pageRef));
			}
		}
		
		[Export ("pageLabelForPage:substituteWithPlainLabel:")]
		[CompilerGenerated]
		public virtual string PageLabelForPage (global::System.nuint page, bool substitute)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("pageLabelForPage:substituteWithPlainLabel:"), page, substitute));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("pageLabelForPage:substituteWithPlainLabel:"), page, substitute));
			}
		}
		
		[Export ("pageOffsetForDocumentProvider:")]
		[CompilerGenerated]
		public virtual global::System.nuint PageOffsetForDocumentProvider (PSPDFDocumentProvider documentProvider)
		{
			if (documentProvider == null)
				throw new ArgumentNullException ("documentProvider");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("pageOffsetForDocumentProvider:"), documentProvider.Handle);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("pageOffsetForDocumentProvider:"), documentProvider.Handle);
			}
		}
		
		[Export ("pageWithPageRange:")]
		[CompilerGenerated]
		public virtual global::System.nuint PageWithPageRange (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("pageWithPageRange:"), page);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("pageWithPageRange:"), page);
			}
		}
		
		[Export ("pathForPage:")]
		[CompilerGenerated]
		public virtual NSUrl PathForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("pathForPage:"), page));
			} else {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("pathForPage:"), page));
			}
		}
		
		[Export ("PDFPageNumberForPage:")]
		[CompilerGenerated]
		public virtual global::System.nuint PdfPageNumberForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("PDFPageNumberForPage:"), page);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("PDFPageNumberForPage:"), page);
			}
		}
		
		[Export ("removeAnnotations:")]
		[CompilerGenerated]
		public virtual bool RemoveAnnotations (PSPDFAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAnnotations:"), nsa_annotations.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
			return ret;
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
		
		[Export ("renderPage:context:size:clippedToRect:annotations:options:error:")]
		[CompilerGenerated]
		public virtual PSPDFRenderReceipt RenderPage (global::System.nuint page, CGContext context, CGSize size, CGRect clipRect, PSPDFAnnotation[] annotations, NSDictionary options, out NSError error)
		{
			if (context == null)
				throw new ArgumentNullException ("context");
			IntPtr errorValue = IntPtr.Zero;
			
			var nsa_annotations = annotations == null ? null : NSArray.FromNSObjects (annotations);
			
			PSPDFRenderReceipt ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PSPDFRenderReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_IntPtr_CGSize_CGRect_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("renderPage:context:size:clippedToRect:annotations:options:error:"), page, context.Handle, size, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<PSPDFRenderReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr_CGSize_CGRect_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("renderPage:context:size:clippedToRect:annotations:options:error:"), page, context.Handle, size, clipRect, nsa_annotations == null ? IntPtr.Zero : nsa_annotations.Handle, options == null ? IntPtr.Zero : options.Handle, ref errorValue));
			}
			if (nsa_annotations != null)
				nsa_annotations.Dispose ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("saveAnnotationsWithCompletionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SaveAnnotations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<PSPDFAnnotation[], NSError> completionBlock)
		{
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			if (completionBlock == null){
				block_ptr_completionBlock = null;
			} else {
				block_completionBlock = new BlockLiteral ();
				block_ptr_completionBlock = &block_completionBlock;
				block_completionBlock.SetupBlock (Trampolines.SDActionArity2V1.Handler, completionBlock);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("saveAnnotationsWithCompletionBlock:"), (IntPtr) block_ptr_completionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("saveAnnotationsWithCompletionBlock:"), (IntPtr) block_ptr_completionBlock);
			}
			if (block_ptr_completionBlock != null)
				block_ptr_completionBlock->CleanupBlock ();
			
		}
		
		[Export ("saveAnnotationsWithError:")]
		[CompilerGenerated]
		internal virtual bool SaveAnnotations (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("saveAnnotationsWithError:"), error);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("saveAnnotationsWithError:"), error);
			}
		}
		
		[Export ("serializeLibraryMetadata:error:")]
		[CompilerGenerated]
		public static NSData SerializeLibraryMetadata (NSDictionary metadata, out NSError error)
		{
			if (metadata == null)
				throw new ArgumentNullException ("metadata");
			IntPtr errorValue = IntPtr.Zero;
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("serializeLibraryMetadata:error:"), metadata.Handle, ref errorValue));
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("setDidCreateDocumentProviderBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetDidCreateDocumentProviderHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<PSPDFDocumentProvider> handler)
		{
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDActionArity1V3.Handler, handler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDidCreateDocumentProviderBlock:"), (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDidCreateDocumentProviderBlock:"), (IntPtr) block_ptr_handler);
			}
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("setPageInfo:forPage:")]
		[CompilerGenerated]
		public virtual void SetPageInfo (PSPDFPageInfo pageInfo, global::System.nuint page)
		{
			if (pageInfo == null)
				throw new ArgumentNullException ("pageInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("setPageInfo:forPage:"), pageInfo.Handle, page);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("setPageInfo:forPage:"), pageInfo.Handle, page);
			}
		}
		
		[Export ("unlockWithPassword:")]
		[CompilerGenerated]
		public virtual bool UnlockWithPassword (string password)
		{
			var nspassword = NSString.CreateNative (password);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unlockWithPassword:"), nspassword);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("unlockWithPassword:"), nspassword);
			}
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("URLForFileIndex:")]
		[CompilerGenerated]
		public virtual NSUrl UrlForFileIndex (global::System.nuint fileIndex)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("URLForFileIndex:"), fileIndex));
			} else {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("URLForFileIndex:"), fileIndex));
			}
		}
		
		[Export ("validateLibraryMetadata:")]
		[CompilerGenerated]
		public static bool ValidateLibraryMetadata (NSDictionary metadata)
		{
			if (metadata == null)
				throw new ArgumentNullException ("metadata");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("validateLibraryMetadata:"), metadata.Handle);
		}
		
		[CompilerGenerated]
		object __mt_AllEmbeddedFiles_var;
		[CompilerGenerated]
		public virtual PSPDFEmbeddedFile[] AllEmbeddedFiles {
			[Export ("allEmbeddedFiles")]
			get {
				PSPDFEmbeddedFile[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFEmbeddedFile>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allEmbeddedFiles")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFEmbeddedFile>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allEmbeddedFiles")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AllEmbeddedFiles_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AllowAnnotationChanges {
			[Export ("allowAnnotationChanges", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowAnnotationChanges"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowAnnotationChanges"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AllowsCopying {
			[Export ("allowsCopying", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsCopying"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowsCopying"));
				}
			}
			
			[Export ("setAllowsCopying:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsCopying:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowsCopying:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowsPrinting {
			[Export ("allowsPrinting", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsPrinting"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowsPrinting"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationSaveMode AnnotationSaveMode {
			[Export ("annotationSaveMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationSaveMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationSaveMode) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("annotationSaveMode"));
					} else {
						ret = (PSPDFAnnotationSaveMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("annotationSaveMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationSaveMode) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationSaveMode"));
					} else {
						ret = (PSPDFAnnotationSaveMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationSaveMode"));
					}
				}
				return ret;
			}
			
			[Export ("setAnnotationSaveMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setAnnotationSaveMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setAnnotationSaveMode:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setAnnotationSaveMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setAnnotationSaveMode:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AnnotationsEnabled {
			[Export ("isAnnotationsEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAnnotationsEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAnnotationsEnabled"));
				}
			}
			
			[Export ("setAnnotationsEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAnnotationsEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAnnotationsEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationWritingOptions_var;
		[CompilerGenerated]
		public virtual NSDictionary AnnotationWritingOptions {
			[Export ("annotationWritingOptions", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotationWritingOptions")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotationWritingOptions")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationWritingOptions_var = ret;
				return ret;
			}
			
			[Export ("setAnnotationWritingOptions:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnnotationWritingOptions:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAnnotationWritingOptions:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnnotationWritingOptions_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFTextCheckingType AutodetectTextLinkTypes {
			[Export ("autodetectTextLinkTypes", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFTextCheckingType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextCheckingType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("autodetectTextLinkTypes"));
					} else {
						ret = (PSPDFTextCheckingType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("autodetectTextLinkTypes"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFTextCheckingType) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFTextCheckingType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("autodetectTextLinkTypes"));
					} else {
						ret = (PSPDFTextCheckingType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("autodetectTextLinkTypes"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFTextCheckingType) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setAutodetectTextLinkTypes:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setAutodetectTextLinkTypes:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAutodetectTextLinkTypes:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setAutodetectTextLinkTypes:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAutodetectTextLinkTypes:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BackgroundColor {
			[Export ("backgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BaseUrl_var;
		[CompilerGenerated]
		public virtual NSUrl BaseUrl {
			[Export ("baseURL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("baseURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("baseURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BaseUrl_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BookmarkParser_var;
		[CompilerGenerated]
		public virtual PSPDFBookmarkParser BookmarkParser {
			[Export ("bookmarkParser", ArgumentSemantic.Retain)]
			get {
				PSPDFBookmarkParser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFBookmarkParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bookmarkParser")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFBookmarkParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bookmarkParser")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BookmarkParser_var = ret;
				return ret;
			}
			
			[Export ("setBookmarkParser:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBookmarkParser:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBookmarkParser:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BookmarkParser_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Bookmarks_var;
		[CompilerGenerated]
		public virtual PSPDFBookmark[] Bookmarks {
			[Export ("bookmarks")]
			get {
				PSPDFBookmark[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFBookmark>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bookmarks")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFBookmark>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bookmarks")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Bookmarks_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool BookmarksEnabled {
			[Export ("isBookmarksEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBookmarksEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBookmarksEnabled"));
				}
			}
			
			[Export ("setBookmarksEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBookmarksEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setBookmarksEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CanEmbedAnnotations {
			[Export ("canEmbedAnnotations", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canEmbedAnnotations"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canEmbedAnnotations"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CanSaveAnnotations {
			[Export ("canSaveAnnotations", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canSaveAnnotations"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canSaveAnnotations"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ContentSignatures_var;
		[CompilerGenerated]
		public virtual NSObject[] ContentSignatures {
			[Export ("contentSignatures", ArgumentSemantic.Copy)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentSignatures")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentSignatures")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentSignatures_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Data_var;
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("data")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("data")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Data_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DataArray_var;
		[CompilerGenerated]
		public virtual NSData[] DataArray {
			[Export ("dataArray", ArgumentSemantic.Copy)]
			get {
				NSData[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSData>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataArray")));
				} else {
					ret = NSArray.ArrayFromHandle<NSData>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataArray")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DataArray_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DataDirectory {
			[Export ("dataDirectory", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataDirectory")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataDirectory")));
				}
			}
			
			[Export ("setDataDirectory:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDataDirectory:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDataDirectory:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual CGDataProvider[] DataProviderArray {
			[Export ("dataProviderArray", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSArray.ArrayFromHandle<CGDataProvider>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataProviderArray")));
				} else {
					return NSArray.ArrayFromHandle<CGDataProvider>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataProviderArray")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DefaultAnnotationUsername {
			[Export ("defaultAnnotationUsername")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("defaultAnnotationUsername")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultAnnotationUsername")));
				}
			}
			
			[Export ("setDefaultAnnotationUsername:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDefaultAnnotationUsername:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDefaultAnnotationUsername:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual IPSPDFDocumentDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IPSPDFDocumentDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFDocumentDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFDiskCacheStrategy DiskCacheStrategy {
			[Export ("diskCacheStrategy", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFDiskCacheStrategy ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDiskCacheStrategy) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("diskCacheStrategy"));
					} else {
						ret = (PSPDFDiskCacheStrategy) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("diskCacheStrategy"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFDiskCacheStrategy) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("diskCacheStrategy"));
					} else {
						ret = (PSPDFDiskCacheStrategy) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("diskCacheStrategy"));
					}
				}
				return ret;
			}
			
			[Export ("setDiskCacheStrategy:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setDiskCacheStrategy:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDiskCacheStrategy:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setDiskCacheStrategy:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDiskCacheStrategy:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_Document_var_static;
		[CompilerGenerated]
		public static PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("document")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Document_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_EditableAnnotationTypes_var;
		[CompilerGenerated]
		public virtual NSObject EditableAnnotationTypes {
			[Export ("editableAnnotationTypes", ArgumentSemantic.Copy)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("editableAnnotationTypes")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("editableAnnotationTypes")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_EditableAnnotationTypes_var = ret;
				return ret;
			}
			
			[Export ("setEditableAnnotationTypes:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEditableAnnotationTypes:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEditableAnnotationTypes:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_EditableAnnotationTypes_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string EncryptionFilter {
			[Export ("encryptionFilter")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("encryptionFilter")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("encryptionFilter")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string FileName {
			[Export ("fileName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FileNamesWithDataDictionary_var;
		[CompilerGenerated]
		public virtual NSDictionary FileNamesWithDataDictionary {
			[Export ("fileNamesWithDataDictionary")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileNamesWithDataDictionary")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileNamesWithDataDictionary")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileNamesWithDataDictionary_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string[] Files {
			[Export ("files")]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("files")));
				} else {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("files")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FilesWithBasePath_var;
		[CompilerGenerated]
		public virtual NSUrl[] FilesWithBasePath {
			[Export ("filesWithBasePath")]
			get {
				NSUrl[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSUrl>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("filesWithBasePath")));
				} else {
					ret = NSArray.ArrayFromHandle<NSUrl>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("filesWithBasePath")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FilesWithBasePath_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FileUrl_var;
		[CompilerGenerated]
		public virtual NSUrl FileUrl {
			[Export ("fileURL", ArgumentSemantic.Copy)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileUrl_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_FormParser_var;
		[CompilerGenerated]
		public virtual PSPDFFormParser FormParser {
			[Export ("formParser", ArgumentSemantic.Retain)]
			get {
				PSPDFFormParser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFFormParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("formParser")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFFormParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formParser")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FormParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool FormsEnabled {
			[Export ("isFormsEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFormsEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isFormsEnabled"));
				}
			}
			
			[Export ("setFormsEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFormsEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFormsEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasDirtyAnnotations {
			[Export ("hasDirtyAnnotations")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasDirtyAnnotations"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasDirtyAnnotations"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsEncrypted {
			[Export ("isEncrypted", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEncrypted"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEncrypted"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLocked {
			[Export ("isLocked", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLocked"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLocked"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LibraryMetadata_var;
		[CompilerGenerated]
		public virtual NSDictionary LibraryMetadata {
			[Export ("libraryMetadata", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("libraryMetadata")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("libraryMetadata")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LibraryMetadata_var = ret;
				return ret;
			}
			
			[Export ("setLibraryMetadata:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLibraryMetadata:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLibraryMetadata:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LibraryMetadata_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Metadata_var;
		[CompilerGenerated]
		public virtual NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("metadata")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("metadata")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Metadata_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OutlineParser_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineParser OutlineParser {
			[Export ("outlineParser", ArgumentSemantic.Retain)]
			get {
				PSPDFOutlineParser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFOutlineParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outlineParser")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFOutlineParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("outlineParser")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OutlineParser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint PageCount {
			[Export ("pageCount", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("pageCount"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageCount"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool PageLabelsEnabled {
			[Export ("isPageLabelsEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPageLabelsEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPageLabelsEnabled"));
				}
			}
			
			[Export ("setPageLabelsEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPageLabelsEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPageLabelsEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PageRange_var;
		[CompilerGenerated]
		public virtual NSIndexSet PageRange {
			[Export ("pageRange", ArgumentSemantic.Copy)]
			get {
				NSIndexSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageRange")));
				} else {
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageRange")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageRange_var = ret;
				return ret;
			}
			
			[Export ("setPageRange:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPageRange:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPageRange:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PageRange_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Password {
			[Export ("password")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("password")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("password")));
				}
			}
			
			[Export ("setPassword:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPassword:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPassword:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual CGPDFBox PdfBox {
			[Export ("PDFBox", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (CGPDFBox) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("PDFBox"));
				} else {
					return (CGPDFBox) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("PDFBox"));
				}
			}
			
			[Export ("setPDFBox:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPDFBox:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPDFBox:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PsPdfKit_var;
		[CompilerGenerated]
		public virtual PSPDFKitGlobal PsPdfKit {
			[Export ("pspdfkit", ArgumentSemantic.Retain)]
			get {
				PSPDFKitGlobal ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFKitGlobal> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pspdfkit")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFKitGlobal> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pspdfkit")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PsPdfKit_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFAnnotationType RenderAnnotationTypes {
			[Export ("renderAnnotationTypes", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFAnnotationType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("renderAnnotationTypes"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("renderAnnotationTypes"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderAnnotationTypes"));
					} else {
						ret = (PSPDFAnnotationType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderAnnotationTypes"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFAnnotationType) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setRenderAnnotationTypes:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setRenderAnnotationTypes:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setRenderAnnotationTypes:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setRenderAnnotationTypes:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setRenderAnnotationTypes:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_RenderOptions_var;
		[CompilerGenerated]
		public virtual NSDictionary RenderOptions {
			[Export ("renderOptions", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("renderOptions")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderOptions")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RenderOptions_var = ret;
				return ret;
			}
			
			[Export ("setRenderOptions:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRenderOptions:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRenderOptions:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RenderOptions_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")));
				}
			}
			
			[Export ("setTitle:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitle:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool TitleLoaded {
			[Export ("isTitleLoaded", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTitleLoaded"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isTitleLoaded"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Uid {
			[Export ("UID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("UID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("UID")));
				}
			}
			
			[Export ("setUID:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUID:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUID:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
			
		}
		
		[CompilerGenerated]
		public virtual bool UndoEnabled {
			[Export ("isUndoEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUndoEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isUndoEnabled"));
				}
			}
			
			[Export ("setUndoEnabled:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUndoEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUndoEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Valid {
			[Export ("isValid", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isValid"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isValid"));
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _DefaultAnnotationUsernameKey;
		[Field ("PSPDFDocumentDefaultAnnotationUsernameKey",  "__Internal")]
		public static unsafe NSString DefaultAnnotationUsernameKey {
			get {
				if (_DefaultAnnotationUsernameKey == null)
					_DefaultAnnotationUsernameKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFDocumentDefaultAnnotationUsernameKey");
				return _DefaultAnnotationUsernameKey;
			}
		}
		[CompilerGenerated]
		static NSString _DocumentWillSaveAnnotationsNotification;
		[Field ("PSPDFDocumentWillSaveAnnotationsNotification",  "__Internal")]
		public static unsafe NSString DocumentWillSaveAnnotationsNotification {
			get {
				if (_DocumentWillSaveAnnotationsNotification == null)
					_DocumentWillSaveAnnotationsNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFDocumentWillSaveAnnotationsNotification");
				return _DocumentWillSaveAnnotationsNotification;
			}
		}
		[CompilerGenerated]
		static NSString _IgnoreDisplaySettingsKey;
		[Field ("PSPDFIgnoreDisplaySettingsKey",  "__Internal")]
		public static unsafe NSString IgnoreDisplaySettingsKey {
			get {
				if (_IgnoreDisplaySettingsKey == null)
					_IgnoreDisplaySettingsKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFIgnoreDisplaySettingsKey");
				return _IgnoreDisplaySettingsKey;
			}
		}
		[CompilerGenerated]
		static NSString _PreserveAspectRatioKey;
		[Field ("PSPDFPreserveAspectRatioKey",  "__Internal")]
		public static unsafe NSString PreserveAspectRatioKey {
			get {
				if (_PreserveAspectRatioKey == null)
					_PreserveAspectRatioKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFPreserveAspectRatioKey");
				return _PreserveAspectRatioKey;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AllEmbeddedFiles_var = null;
				__mt_AnnotationWritingOptions_var = null;
				__mt_BackgroundColor_var = null;
				__mt_BaseUrl_var = null;
				__mt_BookmarkParser_var = null;
				__mt_Bookmarks_var = null;
				__mt_ContentSignatures_var = null;
				__mt_Data_var = null;
				__mt_DataArray_var = null;
				__mt_Delegate_var = null;
				__mt_EditableAnnotationTypes_var = null;
				__mt_FileNamesWithDataDictionary_var = null;
				__mt_FilesWithBasePath_var = null;
				__mt_FileUrl_var = null;
				__mt_FormParser_var = null;
				__mt_LibraryMetadata_var = null;
				__mt_Metadata_var = null;
				__mt_OutlineParser_var = null;
				__mt_PageRange_var = null;
				__mt_PsPdfKit_var = null;
				__mt_RenderOptions_var = null;
				__mt_UndoController_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveDocumentWillSaveAnnotations (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DocumentWillSaveAnnotationsNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFDocument */
}
