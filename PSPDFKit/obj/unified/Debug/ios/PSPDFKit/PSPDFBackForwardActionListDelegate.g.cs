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
	[Protocol (Name = "PSPDFBackForwardActionListDelegate", WrapperType = typeof (PSPDFBackForwardActionListDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestedBackActionExecution", Selector = "backForwardList:requestedBackActionExecution:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFBackForwardActionList), typeof (PSPDFKit.PSPDFAction[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestedForwardActionExecution", Selector = "backForwardList:requestedForwardActionExecution:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFBackForwardActionList), typeof (PSPDFKit.PSPDFAction[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "backForwardListDidUpdate:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFBackForwardActionList) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFBackForwardActionListDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("backForwardList:requestedBackActionExecution:")]
		[Preserve (Conditional = true)]
		void RequestedBackActionExecution (PSPDFBackForwardActionList list, PSPDFAction[] actions);
		
		[CompilerGenerated]
		[Export ("backForwardList:requestedForwardActionExecution:")]
		[Preserve (Conditional = true)]
		void RequestedForwardActionExecution (PSPDFBackForwardActionList list, PSPDFAction[] actions);
		
	}
	
	public static partial class PSPDFBackForwardActionListDelegate_Extensions {
		[CompilerGenerated]
		public static void DidUpdate (this IPSPDFBackForwardActionListDelegate This, PSPDFBackForwardActionList list)
		{
			if (list == null)
				throw new ArgumentNullException ("list");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("backForwardListDidUpdate:"), list.Handle);
		}
		
	}
	
	internal sealed class PSPDFBackForwardActionListDelegateWrapper : BaseWrapper, IPSPDFBackForwardActionListDelegate {
		public PSPDFBackForwardActionListDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFBackForwardActionListDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("backForwardList:requestedBackActionExecution:")]
		[CompilerGenerated]
		public void RequestedBackActionExecution (PSPDFBackForwardActionList list, PSPDFAction[] actions)
		{
			if (list == null)
				throw new ArgumentNullException ("list");
			if (actions == null)
				throw new ArgumentNullException ("actions");
			var nsa_actions = NSArray.FromNSObjects (actions);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("backForwardList:requestedBackActionExecution:"), list.Handle, nsa_actions.Handle);
			nsa_actions.Dispose ();
			
		}
		
		[Export ("backForwardList:requestedForwardActionExecution:")]
		[CompilerGenerated]
		public void RequestedForwardActionExecution (PSPDFBackForwardActionList list, PSPDFAction[] actions)
		{
			if (list == null)
				throw new ArgumentNullException ("list");
			if (actions == null)
				throw new ArgumentNullException ("actions");
			var nsa_actions = NSArray.FromNSObjects (actions);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("backForwardList:requestedForwardActionExecution:"), list.Handle, nsa_actions.Handle);
			nsa_actions.Dispose ();
			
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFBackForwardActionListDelegate", false)]
	[Model]
	public unsafe abstract partial class PSPDFBackForwardActionListDelegate : NSObject, IPSPDFBackForwardActionListDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFBackForwardActionListDelegate () : base (NSObjectFlag.Empty)
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
		protected PSPDFBackForwardActionListDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFBackForwardActionListDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("backForwardListDidUpdate:")]
		[CompilerGenerated]
		public virtual void DidUpdate (PSPDFBackForwardActionList list)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("backForwardList:requestedBackActionExecution:")]
		[CompilerGenerated]
		public abstract void RequestedBackActionExecution (PSPDFBackForwardActionList list, PSPDFAction[] actions);
		[Export ("backForwardList:requestedForwardActionExecution:")]
		[CompilerGenerated]
		public abstract void RequestedForwardActionExecution (PSPDFBackForwardActionList list, PSPDFAction[] actions);
	} /* class PSPDFBackForwardActionListDelegate */
}
