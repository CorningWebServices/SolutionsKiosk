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
	[Protocol (Name = "PSPDFUndoProtocol", WrapperType = typeof (PSPDFUndoProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "KeysForValuesToObserveForUndo", Selector = "keysForValuesToObserveForUndo", ReturnType = typeof (NSSet))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "LocalizedUndoActionNameForKey", Selector = "localizedUndoActionNameForKey:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "UndoCoalescingForKey", Selector = "undoCoalescingForKey:", ReturnType = typeof (PSPDFKit.PSPDFUndoCoalescing), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertUndoObjects", Selector = "insertUndoObjects:forKey:", ParameterType = new Type [] { typeof (NSSet), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveUndoObjects", Selector = "removeUndoObjects:forKey:", ParameterType = new Type [] { typeof (NSSet), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUndoOrRedoChange", Selector = "didUndoOrRedoChange:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformUndoAction", Selector = "performUndoAction:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFUndoProtocol : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("keysForValuesToObserveForUndo")]
		[Preserve (Conditional = true)]
		NSSet KeysForValuesToObserveForUndo ();
		
	}
	
	public static partial class PSPDFUndoProtocol_Extensions {
		[CompilerGenerated]
		public static void InsertUndoObjects (this IPSPDFUndoProtocol This, NSSet objects, string key)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("insertUndoObjects:forKey:"), objects.Handle, nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[CompilerGenerated]
		public static void RemoveUndoObjects (this IPSPDFUndoProtocol This, NSSet objects, string key)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("removeUndoObjects:forKey:"), objects.Handle, nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[CompilerGenerated]
		public static void DidUndoOrRedoChange (this IPSPDFUndoProtocol This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didUndoOrRedoChange:"), nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[CompilerGenerated]
		public static void PerformUndoAction (this IPSPDFUndoProtocol This, NSObject action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("performUndoAction:"), action.Handle);
		}
		
	}
	
	internal sealed class PSPDFUndoProtocolWrapper : BaseWrapper, IPSPDFUndoProtocol {
		public PSPDFUndoProtocolWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFUndoProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("keysForValuesToObserveForUndo")]
		[CompilerGenerated]
		public NSSet KeysForValuesToObserveForUndo ()
		{
			return  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keysForValuesToObserveForUndo")));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFUndoProtocol", false)]
	[Model]
	public unsafe abstract partial class PSPDFUndoProtocol : NSObject, IPSPDFUndoProtocol {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFUndoProtocol () : base (NSObjectFlag.Empty)
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
		protected PSPDFUndoProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFUndoProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("didUndoOrRedoChange:")]
		[CompilerGenerated]
		public virtual void DidUndoOrRedoChange (string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("insertUndoObjects:forKey:")]
		[CompilerGenerated]
		public virtual void InsertUndoObjects (NSSet objects, string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("keysForValuesToObserveForUndo")]
		[CompilerGenerated]
		public abstract NSSet KeysForValuesToObserveForUndo ();
		[Export ("localizedUndoActionNameForKey:")]
		[CompilerGenerated]
		public static string LocalizedUndoActionNameForKey (string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("performUndoAction:")]
		[CompilerGenerated]
		public virtual void PerformUndoAction (NSObject action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeUndoObjects:forKey:")]
		[CompilerGenerated]
		public virtual void RemoveUndoObjects (NSSet objects, string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("undoCoalescingForKey:")]
		[CompilerGenerated]
		public static PSPDFUndoCoalescing UndoCoalescingForKey (string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFUndoProtocol */
}
