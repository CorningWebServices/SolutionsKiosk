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
	[Protocol (Name = "PSPDFSettings", WrapperType = typeof (PSPDFSettingsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ObjectForKeyedSubscript", Selector = "objectForKeyedSubscript:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BoolForKey", Selector = "boolForKey:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFSettings : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("objectForKeyedSubscript:")]
		[Preserve (Conditional = true)]
		NSObject ObjectForKeyedSubscript (NSObject key);
		
		[CompilerGenerated]
		[Export ("boolForKey:")]
		[Preserve (Conditional = true)]
		bool BoolForKey (string key);
		
	}
	
	internal sealed class PSPDFSettingsWrapper : BaseWrapper, IPSPDFSettings {
		public PSPDFSettingsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFSettingsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("objectForKeyedSubscript:")]
		[CompilerGenerated]
		public NSObject ObjectForKeyedSubscript (NSObject key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), key.Handle));
		}
		
		[Export ("boolForKey:")]
		[CompilerGenerated]
		public bool BoolForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("boolForKey:"), nskey);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFSettings", false)]
	[Model]
	public unsafe abstract partial class PSPDFSettings : NSObject, IPSPDFSettings {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFSettings () : base (NSObjectFlag.Empty)
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
		protected PSPDFSettings (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFSettings (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("boolForKey:")]
		[CompilerGenerated]
		public abstract bool BoolForKey (string key);
		[Export ("objectForKeyedSubscript:")]
		[CompilerGenerated]
		public abstract NSObject ObjectForKeyedSubscript (NSObject key);
	} /* class PSPDFSettings */
}
