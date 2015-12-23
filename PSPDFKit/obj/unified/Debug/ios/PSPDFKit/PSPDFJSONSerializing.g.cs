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
	[Protocol (Name = "PSPDFJSONSerializing", WrapperType = typeof (PSPDFJSONSerializingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "JSONKeyPathsByPropertyKey", Selector = "JSONKeyPathsByPropertyKey", ReturnType = typeof (NSDictionary))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "JSONTransformerForKey", Selector = "JSONTransformerForKey:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClassForParsingJSONDictionary", Selector = "classForParsingJSONDictionary:", ReturnType = typeof (Class), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	public interface IPSPDFJSONSerializing : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("JSONKeyPathsByPropertyKey")]
		[Preserve (Conditional = true)]
		NSDictionary JSONKeyPathsByPropertyKey ();
		
	}
	
	public static partial class PSPDFJSONSerializing_Extensions {
		[CompilerGenerated]
		public static NSObject JSONTransformerForKey (this IPSPDFJSONSerializing This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("JSONTransformerForKey:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static Class ClassForParsingJSONDictionary (this IPSPDFJSONSerializing This, NSDictionary JSONDictionary)
		{
			if (JSONDictionary == null)
				throw new ArgumentNullException ("JSONDictionary");
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("classForParsingJSONDictionary:"), JSONDictionary.Handle);
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
	}
	
	internal sealed class PSPDFJSONSerializingWrapper : BaseWrapper, IPSPDFJSONSerializing {
		public PSPDFJSONSerializingWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFJSONSerializingWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("JSONKeyPathsByPropertyKey")]
		[CompilerGenerated]
		public NSDictionary JSONKeyPathsByPropertyKey ()
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("JSONKeyPathsByPropertyKey")));
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFJSONSerializing", false)]
	[Model]
	public unsafe abstract partial class PSPDFJSONSerializing : NSObject, IPSPDFJSONSerializing {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFJSONSerializing () : base (NSObjectFlag.Empty)
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
		protected PSPDFJSONSerializing (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFJSONSerializing (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("classForParsingJSONDictionary:")]
		[CompilerGenerated]
		public virtual Class ClassForParsingJSONDictionary (NSDictionary JSONDictionary)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("JSONKeyPathsByPropertyKey")]
		[CompilerGenerated]
		public abstract NSDictionary JSONKeyPathsByPropertyKey ();
		[Export ("JSONTransformerForKey:")]
		[CompilerGenerated]
		public virtual NSObject JSONTransformerForKey (string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFJSONSerializing */
}
