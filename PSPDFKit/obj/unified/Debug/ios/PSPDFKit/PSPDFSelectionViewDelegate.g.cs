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
	[Protocol (Name = "PSPDFSelectionViewDelegate", WrapperType = typeof (PSPDFSelectionViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldStartSelectionAtPoint", Selector = "selectionView:shouldStartSelectionAtPoint:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSelectionView), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateSelectedRect", Selector = "selectionView:updateSelectedRect:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSelectionView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedWithSelectedRect", Selector = "selectionView:finishedWithSelectedRect:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSelectionView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelledWithSelectedRect", Selector = "selectionView:cancelledWithSelectedRect:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSelectionView), typeof (CGRect) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SingleTappedWithGestureRecognizer", Selector = "selectionView:singleTappedWithGestureRecognizer:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFSelectionView), typeof (UITapGestureRecognizer) }, ParameterByRef = new bool [] { false, false })]
	public interface IPSPDFSelectionViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFSelectionViewDelegate_Extensions {
		[CompilerGenerated]
		public static bool ShouldStartSelectionAtPoint (this IPSPDFSelectionViewDelegate This, PSPDFSelectionView selectionView, CGPoint point)
		{
			if (selectionView == null)
				throw new ArgumentNullException ("selectionView");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_CGPoint (This.Handle, Selector.GetHandle ("selectionView:shouldStartSelectionAtPoint:"), selectionView.Handle, point);
		}
		
		[CompilerGenerated]
		public static void UpdateSelectedRect (this IPSPDFSelectionViewDelegate This, PSPDFSelectionView selectionView, CGRect rect)
		{
			if (selectionView == null)
				throw new ArgumentNullException ("selectionView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGRect (This.Handle, Selector.GetHandle ("selectionView:updateSelectedRect:"), selectionView.Handle, rect);
		}
		
		[CompilerGenerated]
		public static void FinishedWithSelectedRect (this IPSPDFSelectionViewDelegate This, PSPDFSelectionView selectionView, CGRect rect)
		{
			if (selectionView == null)
				throw new ArgumentNullException ("selectionView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGRect (This.Handle, Selector.GetHandle ("selectionView:finishedWithSelectedRect:"), selectionView.Handle, rect);
		}
		
		[CompilerGenerated]
		public static void CancelledWithSelectedRect (this IPSPDFSelectionViewDelegate This, PSPDFSelectionView selectionView, CGRect rect)
		{
			if (selectionView == null)
				throw new ArgumentNullException ("selectionView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGRect (This.Handle, Selector.GetHandle ("selectionView:cancelledWithSelectedRect:"), selectionView.Handle, rect);
		}
		
		[CompilerGenerated]
		public static void SingleTappedWithGestureRecognizer (this IPSPDFSelectionViewDelegate This, PSPDFSelectionView selectionView, global::UIKit.UITapGestureRecognizer gestureRecognizer)
		{
			if (selectionView == null)
				throw new ArgumentNullException ("selectionView");
			if (gestureRecognizer == null)
				throw new ArgumentNullException ("gestureRecognizer");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("selectionView:singleTappedWithGestureRecognizer:"), selectionView.Handle, gestureRecognizer.Handle);
		}
		
	}
	
	internal sealed class PSPDFSelectionViewDelegateWrapper : BaseWrapper, IPSPDFSelectionViewDelegate {
		public PSPDFSelectionViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFSelectionViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFSelectionViewDelegate", false)]
	[Model]
	public unsafe partial class PSPDFSelectionViewDelegate : NSObject, IPSPDFSelectionViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSelectionViewDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFSelectionViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSelectionViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("selectionView:cancelledWithSelectedRect:")]
		[CompilerGenerated]
		public virtual void CancelledWithSelectedRect (PSPDFSelectionView selectionView, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectionView:finishedWithSelectedRect:")]
		[CompilerGenerated]
		public virtual void FinishedWithSelectedRect (PSPDFSelectionView selectionView, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectionView:shouldStartSelectionAtPoint:")]
		[CompilerGenerated]
		public virtual bool ShouldStartSelectionAtPoint (PSPDFSelectionView selectionView, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectionView:singleTappedWithGestureRecognizer:")]
		[CompilerGenerated]
		public virtual void SingleTappedWithGestureRecognizer (PSPDFSelectionView selectionView, global::UIKit.UITapGestureRecognizer gestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectionView:updateSelectedRect:")]
		[CompilerGenerated]
		public virtual void UpdateSelectedRect (PSPDFSelectionView selectionView, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFSelectionViewDelegate */
}
