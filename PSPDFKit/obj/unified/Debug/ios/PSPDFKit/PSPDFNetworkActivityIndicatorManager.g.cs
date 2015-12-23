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
	[Protocol (Name = "PSPDFNetworkActivityIndicatorManager", WrapperType = typeof (PSPDFNetworkActivityIndicatorManagerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIsEnabled", Selector = "isEnabled", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetIsEnabled", Selector = "setEnabled:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIsNetworkActivityIndicatorVisible", Selector = "isNetworkActivityIndicatorVisible", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IncrementActivityCount", Selector = "incrementActivityCount")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecrementActivityCount", Selector = "decrementActivityCount")]
	public interface IPSPDFNetworkActivityIndicatorManager : INativeObject, IDisposable
	{
	}
	
	public static partial class PSPDFNetworkActivityIndicatorManager_Extensions {
		[CompilerGenerated]
		public static bool GetIsEnabled (this IPSPDFNetworkActivityIndicatorManager This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEnabled"));
		}
		
		[CompilerGenerated]
		public static void SetIsEnabled (this IPSPDFNetworkActivityIndicatorManager This, bool isEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setEnabled:"), isEnabled);
		}
		
		[CompilerGenerated]
		public static bool GetIsNetworkActivityIndicatorVisible (this IPSPDFNetworkActivityIndicatorManager This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isNetworkActivityIndicatorVisible"));
		}
		
		[CompilerGenerated]
		public static void IncrementActivityCount (this IPSPDFNetworkActivityIndicatorManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("incrementActivityCount"));
		}
		
		[CompilerGenerated]
		public static void DecrementActivityCount (this IPSPDFNetworkActivityIndicatorManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("decrementActivityCount"));
		}
		
	}
	
	internal sealed class PSPDFNetworkActivityIndicatorManagerWrapper : BaseWrapper, IPSPDFNetworkActivityIndicatorManager {
		public PSPDFNetworkActivityIndicatorManagerWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFNetworkActivityIndicatorManagerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
