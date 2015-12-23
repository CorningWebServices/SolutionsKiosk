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
	[Register("PSPDFKit", true)]
	public unsafe partial class PSPDFKitGlobal : NSObject, IPSPDFSettings {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFKit");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFKitGlobal (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFKitGlobal (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("boolForKey:")]
		[CompilerGenerated]
		public virtual bool BoolForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("boolForKey:"), nskey);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("boolForKey:"), nskey);
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("injectDependentProperties:")]
		[CompilerGenerated]
		public virtual global::System.nuint InjectDependentProperties (NSObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("injectDependentProperties:"), obj.Handle);
			} else {
				return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("injectDependentProperties:"), obj.Handle);
			}
		}
		
		[Export ("isFeatureEnabled:")]
		[CompilerGenerated]
		public static bool IsFeatureEnabled (PSPDFFeatureMask feature)
		{
			if (IntPtr.Size == 8) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("isFeatureEnabled:"), (UInt64)feature);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("isFeatureEnabled:"), (UInt32)feature);
			}
		}
		
		[Export ("objectForKeyedSubscript:")]
		[CompilerGenerated]
		public virtual NSObject ObjectForKeyedSubscript (NSObject key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), key.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("objectForKeyedSubscript:"), key.Handle));
			}
		}
		
		[Export ("setLicenseKey:")]
		[CompilerGenerated]
		public static void SetLicenseKey (string licenseKey)
		{
			if (licenseKey == null)
				throw new ArgumentNullException ("licenseKey");
			var nslicenseKey = NSString.CreateNative (licenseKey);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setLicenseKey:"), nslicenseKey);
			NSString.ReleaseNative (nslicenseKey);
			
		}
		
		[Export ("setObject:forKeyedSubscript:")]
		[CompilerGenerated]
		public virtual void SetObject (NSObject obj, NSString key)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setObject:forKeyedSubscript:"), obj.Handle, key.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setObject:forKeyedSubscript:"), obj.Handle, key.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Cache_var;
		[CompilerGenerated]
		public virtual PSPDFCache Cache {
			[Export ("cache", ArgumentSemantic.Retain)]
			get {
				PSPDFCache ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFCache> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cache")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFCache> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cache")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Cache_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CompiledAt_var;
		[CompilerGenerated]
		public virtual NSDate CompiledAt {
			[Export ("compiledAt", ArgumentSemantic.Copy)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("compiledAt")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compiledAt")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CompiledAt_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DatabaseEncryptionProvider_var;
		[CompilerGenerated]
		public virtual IPSPDFDatabaseEncryptionProvider DatabaseEncryptionProvider {
			[Export ("databaseEncryptionProvider", ArgumentSemantic.Retain)]
			get {
				IPSPDFDatabaseEncryptionProvider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFDatabaseEncryptionProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("databaseEncryptionProvider")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFDatabaseEncryptionProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("databaseEncryptionProvider")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DatabaseEncryptionProvider_var = ret;
				return ret;
			}
			
			[Export ("setDatabaseEncryptionProvider:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDatabaseEncryptionProvider:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDatabaseEncryptionProvider:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DatabaseEncryptionProvider_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_FileManager_var;
		[CompilerGenerated]
		public virtual IPSPDFFileManager FileManager {
			[Export ("fileManager", ArgumentSemantic.Retain)]
			get {
				IPSPDFFileManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFFileManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileManager")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFFileManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileManager")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Library_var;
		[CompilerGenerated]
		public virtual PSPDFLibrary Library {
			[Export ("library", ArgumentSemantic.Retain)]
			get {
				PSPDFLibrary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFLibrary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("library")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFLibrary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("library")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Library_var = ret;
				return ret;
			}
			
			[Export ("setLibrary:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLibrary:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLibrary:"), value == null ? IntPtr.Zero : value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Library_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLogLevelMask LogLevel {
			[Export ("logLevel", ArgumentSemantic.UnsafeUnretained)]
			get {
				PSPDFLogLevelMask ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLogLevelMask) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("logLevel"));
					} else {
						ret = (PSPDFLogLevelMask) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("logLevel"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFLogLevelMask) ulong.MaxValue;
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PSPDFLogLevelMask) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logLevel"));
					} else {
						ret = (PSPDFLogLevelMask) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logLevel"));
						if ((ulong) ret == (ulong) uint.MaxValue) ret = (PSPDFLogLevelMask) ulong.MaxValue;
					}
				}
				return ret;
			}
			
			[Export ("setLogLevel:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setLogLevel:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setLogLevel:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setLogLevel:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setLogLevel:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Policy_var;
		[CompilerGenerated]
		public virtual IPSPDFApplicationPolicy Policy {
			[Export ("policy", ArgumentSemantic.Retain)]
			get {
				IPSPDFApplicationPolicy ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFApplicationPolicy> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("policy")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFApplicationPolicy> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("policy")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Policy_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RenderManager_var;
		[CompilerGenerated]
		public virtual IPSPDFRenderManager RenderManager {
			[Export ("renderManager", ArgumentSemantic.Retain)]
			get {
				IPSPDFRenderManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFRenderManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("renderManager")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFRenderManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("renderManager")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RenderManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_SharedInstance_var_static;
		[CompilerGenerated]
		public static PSPDFKitGlobal SharedInstance {
			[Export ("sharedInstance")]
			get {
				PSPDFKitGlobal ret;
				ret =  Runtime.GetNSObject<PSPDFKitGlobal> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_SharedInstance_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SpeechSynthesizer_var;
		[CompilerGenerated]
		public virtual PSPDFSpeechController SpeechSynthesizer {
			[Export ("speechSynthesizer", ArgumentSemantic.Retain)]
			get {
				PSPDFSpeechController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFSpeechController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("speechSynthesizer")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFSpeechController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("speechSynthesizer")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SpeechSynthesizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_StyleManager_var;
		[CompilerGenerated]
		public virtual IPSPDFAnnotationStyleManager StyleManager {
			[Export ("styleManager", ArgumentSemantic.Retain)]
			get {
				IPSPDFAnnotationStyleManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationStyleManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("styleManager")), false);
				} else {
					ret =  Runtime.GetINativeObject<IPSPDFAnnotationStyleManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("styleManager")), false);
				}
				if (!IsNewRefcountEnabled ())
					__mt_StyleManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_StylusManager_var;
		[CompilerGenerated]
		public virtual PSPDFStylusManager StylusManager {
			[Export ("stylusManager", ArgumentSemantic.Retain)]
			get {
				PSPDFStylusManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFStylusManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stylusManager")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFStylusManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stylusManager")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_StylusManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Version {
			[Export ("version")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("version")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("version")));
				}
			}
			
		}
		
		[CompilerGenerated]
		static NSString _MultimediaIdentifierKey;
		[Field ("PSPDFMultimediaIdentifierKey",  "__Internal")]
		public static unsafe NSString MultimediaIdentifierKey {
			get {
				if (_MultimediaIdentifierKey == null)
					_MultimediaIdentifierKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFMultimediaIdentifierKey");
				return _MultimediaIdentifierKey;
			}
		}
		[CompilerGenerated]
		static NSString _WebKitLegacyModeKey;
		[Field ("PSPDFWebKitLegacyModeKey",  "__Internal")]
		public static unsafe NSString WebKitLegacyModeKey {
			get {
				if (_WebKitLegacyModeKey == null)
					_WebKitLegacyModeKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFWebKitLegacyModeKey");
				return _WebKitLegacyModeKey;
			}
		}
		[CompilerGenerated]
		static NSString _XCallbackUrlStringKey;
		[Field ("PSPDFXCallbackURLStringKey",  "__Internal")]
		public static unsafe NSString XCallbackUrlStringKey {
			get {
				if (_XCallbackUrlStringKey == null)
					_XCallbackUrlStringKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFXCallbackURLStringKey");
				return _XCallbackUrlStringKey;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Cache_var = null;
				__mt_CompiledAt_var = null;
				__mt_DatabaseEncryptionProvider_var = null;
				__mt_FileManager_var = null;
				__mt_Library_var = null;
				__mt_Policy_var = null;
				__mt_RenderManager_var = null;
				__mt_SpeechSynthesizer_var = null;
				__mt_StyleManager_var = null;
				__mt_StylusManager_var = null;
			}
		}
	} /* class PSPDFKitGlobal */
}
