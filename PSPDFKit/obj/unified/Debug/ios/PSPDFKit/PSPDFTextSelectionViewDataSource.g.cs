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
	[Protocol (Name = "PSPDFTextSelectionViewDataSource", WrapperType = typeof (PSPDFTextSelectionViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDocument", Selector = "document", ReturnType = typeof (PSPDFKit.PSPDFDocument))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPage", Selector = "page", ReturnType = typeof (nuint))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetZoomScale", Selector = "zoomScale", ReturnType = typeof (nfloat))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertViewPointToPdfPoint", Selector = "convertViewPointToPDFPoint:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertPdfPointToViewPoint", Selector = "convertPDFPointToViewPoint:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertViewRectToPdfRect", Selector = "convertViewRectToPDFRect:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertPdfRectToViewRect", Selector = "convertPDFRectToViewRect:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertGlyphRectToViewRect", Selector = "convertGlyphRectToViewRect:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertViewRectToGlyphRect", Selector = "convertViewRectToGlyphRect:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (CGRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIsTextSelectionEnabled", Selector = "isTextSelectionEnabled", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIsImageSelectionEnabled", Selector = "isImageSelectionEnabled", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTextSelectionMode", Selector = "textSelectionMode", ReturnType = typeof (PSPDFKit.PSPDFTextSelectionMode))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTextSelectionShouldSnapToWord", Selector = "textSelectionShouldSnapToWord", ReturnType = typeof (bool))]
	public interface IPSPDFTextSelectionViewDataSource : INativeObject, IDisposable, 
		PSPDFKit.IPSPDFOverridable
		
	{
		[CompilerGenerated]
		[Export ("convertViewPointToPDFPoint:")]
		[Preserve (Conditional = true)]
		CGPoint ConvertViewPointToPdfPoint (CGPoint viewPoint);
		
		[CompilerGenerated]
		[Export ("convertPDFPointToViewPoint:")]
		[Preserve (Conditional = true)]
		CGPoint ConvertPdfPointToViewPoint (CGPoint pdfPoint);
		
		[CompilerGenerated]
		[Export ("convertViewRectToPDFRect:")]
		[Preserve (Conditional = true)]
		CGRect ConvertViewRectToPdfRect (CGRect viewRect);
		
		[CompilerGenerated]
		[Export ("convertPDFRectToViewRect:")]
		[Preserve (Conditional = true)]
		CGRect ConvertPdfRectToViewRect (CGRect pdfRect);
		
		[CompilerGenerated]
		[Export ("convertGlyphRectToViewRect:")]
		[Preserve (Conditional = true)]
		CGRect ConvertGlyphRectToViewRect (CGRect glyphRect);
		
		[CompilerGenerated]
		[Export ("convertViewRectToGlyphRect:")]
		[Preserve (Conditional = true)]
		CGRect ConvertViewRectToGlyphRect (CGRect viewRect);
		
	}
	
	public static partial class PSPDFTextSelectionViewDataSource_Extensions {
		[CompilerGenerated]
		public static PSPDFDocument GetDocument (this IPSPDFTextSelectionViewDataSource This)
		{
			return  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("document")));
		}
		
		[CompilerGenerated]
		public static global::System.nuint GetPage (this IPSPDFTextSelectionViewDataSource This)
		{
			return global::ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("page"));
		}
		
		[CompilerGenerated]
		public static global::System.nfloat GetZoomScale (this IPSPDFTextSelectionViewDataSource This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("zoomScale"));
		}
		
		[CompilerGenerated]
		public static bool GetIsTextSelectionEnabled (this IPSPDFTextSelectionViewDataSource This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isTextSelectionEnabled"));
		}
		
		[CompilerGenerated]
		public static bool GetIsImageSelectionEnabled (this IPSPDFTextSelectionViewDataSource This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isImageSelectionEnabled"));
		}
		
		[CompilerGenerated]
		public static PSPDFTextSelectionMode GetTextSelectionMode (this IPSPDFTextSelectionViewDataSource This)
		{
			PSPDFTextSelectionMode ret;
			if (IntPtr.Size == 8) {
				ret = (PSPDFTextSelectionMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("textSelectionMode"));
			} else {
				ret = (PSPDFTextSelectionMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("textSelectionMode"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static bool GetTextSelectionShouldSnapToWord (this IPSPDFTextSelectionViewDataSource This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("textSelectionShouldSnapToWord"));
		}
		
	}
	
	internal sealed class PSPDFTextSelectionViewDataSourceWrapper : BaseWrapper, IPSPDFTextSelectionViewDataSource {
		public PSPDFTextSelectionViewDataSourceWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFTextSelectionViewDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("convertViewPointToPDFPoint:")]
		[CompilerGenerated]
		public CGPoint ConvertViewPointToPdfPoint (CGPoint viewPoint)
		{
			CGPoint ret;
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
			return ret;
		}
		
		[Export ("convertPDFPointToViewPoint:")]
		[CompilerGenerated]
		public CGPoint ConvertPdfPointToViewPoint (CGPoint pdfPoint)
		{
			CGPoint ret;
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
			return ret;
		}
		
		[Export ("convertViewRectToPDFRect:")]
		[CompilerGenerated]
		public CGRect ConvertViewRectToPdfRect (CGRect viewRect)
		{
			CGRect ret;
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
			return ret;
		}
		
		[Export ("convertPDFRectToViewRect:")]
		[CompilerGenerated]
		public CGRect ConvertPdfRectToViewRect (CGRect pdfRect)
		{
			CGRect ret;
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
			return ret;
		}
		
		[Export ("convertGlyphRectToViewRect:")]
		[CompilerGenerated]
		public CGRect ConvertGlyphRectToViewRect (CGRect glyphRect)
		{
			CGRect ret;
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
			return ret;
		}
		
		[Export ("convertViewRectToGlyphRect:")]
		[CompilerGenerated]
		public CGRect ConvertViewRectToGlyphRect (CGRect viewRect)
		{
			CGRect ret;
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
			return ret;
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFTextSelectionViewDataSource", false)]
	[Model]
	public unsafe abstract partial class PSPDFTextSelectionViewDataSource : NSObject, IPSPDFTextSelectionViewDataSource, IPSPDFOverridable {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFTextSelectionViewDataSource () : base (NSObjectFlag.Empty)
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
		protected PSPDFTextSelectionViewDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTextSelectionViewDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForClass:")]
		[CompilerGenerated]
		public virtual Class ClassForClass (Class originalClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("convertGlyphRectToViewRect:")]
		[CompilerGenerated]
		public abstract CGRect ConvertGlyphRectToViewRect (CGRect glyphRect);
		[Export ("convertPDFPointToViewPoint:")]
		[CompilerGenerated]
		public abstract CGPoint ConvertPdfPointToViewPoint (CGPoint pdfPoint);
		[Export ("convertPDFRectToViewRect:")]
		[CompilerGenerated]
		public abstract CGRect ConvertPdfRectToViewRect (CGRect pdfRect);
		[Export ("convertViewPointToPDFPoint:")]
		[CompilerGenerated]
		public abstract CGPoint ConvertViewPointToPdfPoint (CGPoint viewPoint);
		[Export ("convertViewRectToGlyphRect:")]
		[CompilerGenerated]
		public abstract CGRect ConvertViewRectToGlyphRect (CGRect viewRect);
		[Export ("convertViewRectToPDFRect:")]
		[CompilerGenerated]
		public abstract CGRect ConvertViewRectToPdfRect (CGRect viewRect);
		[Export ("document")]
		[CompilerGenerated]
		public virtual PSPDFDocument GetDocument ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isImageSelectionEnabled")]
		[CompilerGenerated]
		public virtual bool GetIsImageSelectionEnabled ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isTextSelectionEnabled")]
		[CompilerGenerated]
		public virtual bool GetIsTextSelectionEnabled ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("page")]
		[CompilerGenerated]
		public virtual global::System.nuint GetPage ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("textSelectionMode")]
		[CompilerGenerated]
		public virtual PSPDFTextSelectionMode GetTextSelectionMode ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("textSelectionShouldSnapToWord")]
		[CompilerGenerated]
		public virtual bool GetTextSelectionShouldSnapToWord ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("zoomScale")]
		[CompilerGenerated]
		public virtual global::System.nfloat GetZoomScale ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFTextSelectionViewDataSource */
}
