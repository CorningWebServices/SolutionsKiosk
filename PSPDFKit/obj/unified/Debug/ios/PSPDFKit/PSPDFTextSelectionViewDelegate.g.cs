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
	[Protocol (Name = "PSPDFTextSelectionViewDelegate", WrapperType = typeof (PSPDFTextSelectionViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateMenuAnimated", Selector = "textSelectionView:updateMenuAnimated:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTextSelectionView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectText", Selector = "textSelectionView:shouldSelectText:withGlyphs:atRect:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTextSelectionView), typeof (string), typeof (PSPDFKit.PSPDFGlyph[]), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectText", Selector = "textSelectionView:didSelectText:withGlyphs:atRect:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFTextSelectionView), typeof (string), typeof (PSPDFKit.PSPDFGlyph[]), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false, false })]
	public interface IPSPDFTextSelectionViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("textSelectionView:updateMenuAnimated:")]
		[Preserve (Conditional = true)]
		bool UpdateMenuAnimated (PSPDFTextSelectionView textSelectionView, bool animated);
		
	}
	
	public static partial class PSPDFTextSelectionViewDelegate_Extensions {
		[CompilerGenerated]
		public static bool ShouldSelectText (this IPSPDFTextSelectionViewDelegate This, PSPDFTextSelectionView textSelectionView, string text, PSPDFGlyph[] glyphs, CGRect rect)
		{
			if (textSelectionView == null)
				throw new ArgumentNullException ("textSelectionView");
			if (text == null)
				throw new ArgumentNullException ("text");
			if (glyphs == null)
				throw new ArgumentNullException ("glyphs");
			var nstext = NSString.CreateNative (text);
			var nsa_glyphs = NSArray.FromNSObjects (glyphs);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_CGRect (This.Handle, Selector.GetHandle ("textSelectionView:shouldSelectText:withGlyphs:atRect:"), textSelectionView.Handle, nstext, nsa_glyphs.Handle, rect);
			NSString.ReleaseNative (nstext);
			nsa_glyphs.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void DidSelectText (this IPSPDFTextSelectionViewDelegate This, PSPDFTextSelectionView textSelectionView, string text, PSPDFGlyph[] glyphs, CGRect rect)
		{
			if (textSelectionView == null)
				throw new ArgumentNullException ("textSelectionView");
			if (text == null)
				throw new ArgumentNullException ("text");
			if (glyphs == null)
				throw new ArgumentNullException ("glyphs");
			var nstext = NSString.CreateNative (text);
			var nsa_glyphs = NSArray.FromNSObjects (glyphs);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_CGRect (This.Handle, Selector.GetHandle ("textSelectionView:didSelectText:withGlyphs:atRect:"), textSelectionView.Handle, nstext, nsa_glyphs.Handle, rect);
			NSString.ReleaseNative (nstext);
			nsa_glyphs.Dispose ();
			
		}
		
	}
	
	internal sealed class PSPDFTextSelectionViewDelegateWrapper : BaseWrapper, IPSPDFTextSelectionViewDelegate {
		public PSPDFTextSelectionViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFTextSelectionViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("textSelectionView:updateMenuAnimated:")]
		[CompilerGenerated]
		public bool UpdateMenuAnimated (PSPDFTextSelectionView textSelectionView, bool animated)
		{
			if (textSelectionView == null)
				throw new ArgumentNullException ("textSelectionView");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("textSelectionView:updateMenuAnimated:"), textSelectionView.Handle, animated);
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFTextSelectionViewDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFTextSelectionViewDelegate : NSObject, IPSPDFTextSelectionViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFTextSelectionViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFTextSelectionViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFTextSelectionViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("textSelectionView:didSelectText:withGlyphs:atRect:")]
		[CompilerGenerated]
		public virtual void DidSelectText (PSPDFTextSelectionView textSelectionView, string text, PSPDFGlyph[] glyphs, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("textSelectionView:shouldSelectText:withGlyphs:atRect:")]
		[CompilerGenerated]
		public virtual bool ShouldSelectText (PSPDFTextSelectionView textSelectionView, string text, PSPDFGlyph[] glyphs, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("textSelectionView:updateMenuAnimated:")]
		[CompilerGenerated]
		public abstract bool UpdateMenuAnimated (PSPDFTextSelectionView textSelectionView, bool animated);
	} /* class PSPDFTextSelectionViewDelegate */
}
