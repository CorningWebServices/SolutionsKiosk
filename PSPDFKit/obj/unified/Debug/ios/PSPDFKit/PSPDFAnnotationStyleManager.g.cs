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
	[Protocol (Name = "PSPDFAnnotationStyleManager", WrapperType = typeof (PSPDFAnnotationStyleManagerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetStyleKeys", Selector = "styleKeys", ReturnType = typeof (NSSet))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStyleKeys", Selector = "setStyleKeys:", ParameterType = new Type [] { typeof (NSSet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetShouldUpdateDefaultsForAnnotationChanges", Selector = "shouldUpdateDefaultsForAnnotationChanges", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetShouldUpdateDefaultsForAnnotationChanges", Selector = "setShouldUpdateDefaultsForAnnotationChanges:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetupDefaultStylesIfNeeded", Selector = "setupDefaultStylesIfNeeded")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StylesForKey", Selector = "stylesForKey:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddStyle", Selector = "addStyle:forKey:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationStyle), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveStyle", Selector = "removeStyle:forKey:", ParameterType = new Type [] { typeof (PSPDFKit.PSPDFAnnotationStyle), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LastUsedStyleForKey", Selector = "lastUsedStyleForKey:", ReturnType = typeof (PSPDFKit.PSPDFAnnotationStyle), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LastUsedProperty", Selector = "lastUsedProperty:forKey:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetLastUsedValue", Selector = "setLastUsedValue:forProperty:forKey:", ParameterType = new Type [] { typeof (NSObject), typeof (string), typeof (NSString) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DefaultPresetsForKey", Selector = "defaultPresetsForKey:type:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (NSString), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresetsForKey", Selector = "presetsForKey:type:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (NSString), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPresets", Selector = "setPresets:forKey:type:", ParameterType = new Type [] { typeof (NSObject[]), typeof (NSString), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPSPDFAnnotationStyleManager : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setupDefaultStylesIfNeeded")]
		[Preserve (Conditional = true)]
		void SetupDefaultStylesIfNeeded ();
		
		[CompilerGenerated]
		[Export ("stylesForKey:")]
		[Preserve (Conditional = true)]
		NSObject[] StylesForKey (NSString key);
		
		[CompilerGenerated]
		[Export ("addStyle:forKey:")]
		[Preserve (Conditional = true)]
		void AddStyle (PSPDFAnnotationStyle style, NSString key);
		
		[CompilerGenerated]
		[Export ("removeStyle:forKey:")]
		[Preserve (Conditional = true)]
		void RemoveStyle (PSPDFAnnotationStyle style, NSString key);
		
		[CompilerGenerated]
		[Export ("lastUsedStyleForKey:")]
		[Preserve (Conditional = true)]
		PSPDFAnnotationStyle LastUsedStyleForKey (NSString key);
		
		[CompilerGenerated]
		[Export ("lastUsedProperty:forKey:")]
		[Preserve (Conditional = true)]
		NSObject LastUsedProperty (string styleProperty, NSString key);
		
		[CompilerGenerated]
		[Export ("setLastUsedValue:forProperty:forKey:")]
		[Preserve (Conditional = true)]
		void SetLastUsedValue (NSObject value, string styleProperty, NSString key);
		
		[CompilerGenerated]
		[Export ("defaultPresetsForKey:type:")]
		[Preserve (Conditional = true)]
		NSObject[] DefaultPresetsForKey (NSString key, string type);
		
		[CompilerGenerated]
		[Export ("presetsForKey:type:")]
		[Preserve (Conditional = true)]
		NSObject[] PresetsForKey (NSString key, string type);
		
		[CompilerGenerated]
		[Export ("setPresets:forKey:type:")]
		[Preserve (Conditional = true)]
		void SetPresets (NSObject[] presets, NSString key, string type);
		
	}
	
	public static partial class PSPDFAnnotationStyleManager_Extensions {
		[CompilerGenerated]
		public static NSSet GetStyleKeys (this IPSPDFAnnotationStyleManager This)
		{
			return  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("styleKeys")));
		}
		
		[CompilerGenerated]
		public static void SetStyleKeys (this IPSPDFAnnotationStyleManager This, NSSet styleKeys)
		{
			if (styleKeys == null)
				throw new ArgumentNullException ("styleKeys");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setStyleKeys:"), styleKeys.Handle);
		}
		
		[CompilerGenerated]
		public static bool GetShouldUpdateDefaultsForAnnotationChanges (this IPSPDFAnnotationStyleManager This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldUpdateDefaultsForAnnotationChanges"));
		}
		
		[CompilerGenerated]
		public static void SetShouldUpdateDefaultsForAnnotationChanges (this IPSPDFAnnotationStyleManager This, bool styleKeys)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setShouldUpdateDefaultsForAnnotationChanges:"), styleKeys);
		}
		
	}
	
	internal sealed class PSPDFAnnotationStyleManagerWrapper : BaseWrapper, IPSPDFAnnotationStyleManager {
		public PSPDFAnnotationStyleManagerWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFAnnotationStyleManagerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setupDefaultStylesIfNeeded")]
		[CompilerGenerated]
		public void SetupDefaultStylesIfNeeded ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setupDefaultStylesIfNeeded"));
		}
		
		[Export ("stylesForKey:")]
		[CompilerGenerated]
		public NSObject[] StylesForKey (NSString key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stylesForKey:"), key.Handle));
		}
		
		[Export ("addStyle:forKey:")]
		[CompilerGenerated]
		public void AddStyle (PSPDFAnnotationStyle style, NSString key)
		{
			if (style == null)
				throw new ArgumentNullException ("style");
			if (key == null)
				throw new ArgumentNullException ("key");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addStyle:forKey:"), style.Handle, key.Handle);
		}
		
		[Export ("removeStyle:forKey:")]
		[CompilerGenerated]
		public void RemoveStyle (PSPDFAnnotationStyle style, NSString key)
		{
			if (style == null)
				throw new ArgumentNullException ("style");
			if (key == null)
				throw new ArgumentNullException ("key");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeStyle:forKey:"), style.Handle, key.Handle);
		}
		
		[Export ("lastUsedStyleForKey:")]
		[CompilerGenerated]
		public PSPDFAnnotationStyle LastUsedStyleForKey (NSString key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return  Runtime.GetNSObject<PSPDFAnnotationStyle> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("lastUsedStyleForKey:"), key.Handle));
		}
		
		[Export ("lastUsedProperty:forKey:")]
		[CompilerGenerated]
		public NSObject LastUsedProperty (string styleProperty, NSString key)
		{
			if (styleProperty == null)
				throw new ArgumentNullException ("styleProperty");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsstyleProperty = NSString.CreateNative (styleProperty);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("lastUsedProperty:forKey:"), nsstyleProperty, key.Handle));
			NSString.ReleaseNative (nsstyleProperty);
			
			return ret;
		}
		
		[Export ("setLastUsedValue:forProperty:forKey:")]
		[CompilerGenerated]
		public void SetLastUsedValue (NSObject value, string styleProperty, NSString key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (styleProperty == null)
				throw new ArgumentNullException ("styleProperty");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsstyleProperty = NSString.CreateNative (styleProperty);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLastUsedValue:forProperty:forKey:"), value.Handle, nsstyleProperty, key.Handle);
			NSString.ReleaseNative (nsstyleProperty);
			
		}
		
		[Export ("defaultPresetsForKey:type:")]
		[CompilerGenerated]
		public NSObject[] DefaultPresetsForKey (NSString key, string type)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (type == null)
				throw new ArgumentNullException ("type");
			var nstype = NSString.CreateNative (type);
			
			NSObject[] ret;
			ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("defaultPresetsForKey:type:"), key.Handle, nstype));
			NSString.ReleaseNative (nstype);
			
			return ret;
		}
		
		[Export ("presetsForKey:type:")]
		[CompilerGenerated]
		public NSObject[] PresetsForKey (NSString key, string type)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (type == null)
				throw new ArgumentNullException ("type");
			var nstype = NSString.CreateNative (type);
			
			NSObject[] ret;
			ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presetsForKey:type:"), key.Handle, nstype));
			NSString.ReleaseNative (nstype);
			
			return ret;
		}
		
		[Export ("setPresets:forKey:type:")]
		[CompilerGenerated]
		public void SetPresets (NSObject[] presets, NSString key, string type)
		{
			if (presets == null)
				throw new ArgumentNullException ("presets");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (type == null)
				throw new ArgumentNullException ("type");
			var nsa_presets = NSArray.FromNSObjects (presets);
			var nstype = NSString.CreateNative (type);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setPresets:forKey:type:"), nsa_presets.Handle, key.Handle, nstype);
			nsa_presets.Dispose ();
			NSString.ReleaseNative (nstype);
			
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFAnnotationStyleManager", false)]
	[Model]
	public unsafe abstract partial class PSPDFAnnotationStyleManager : NSObject, IPSPDFAnnotationStyleManager {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFAnnotationStyleManager () : base (NSObjectFlag.Empty)
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
		protected PSPDFAnnotationStyleManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFAnnotationStyleManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addStyle:forKey:")]
		[CompilerGenerated]
		public abstract void AddStyle (PSPDFAnnotationStyle style, NSString key);
		[Export ("defaultPresetsForKey:type:")]
		[CompilerGenerated]
		public abstract NSObject[] DefaultPresetsForKey (NSString key, string type);
		[Export ("shouldUpdateDefaultsForAnnotationChanges")]
		[CompilerGenerated]
		public virtual bool GetShouldUpdateDefaultsForAnnotationChanges ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("styleKeys")]
		[CompilerGenerated]
		public virtual NSSet GetStyleKeys ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("lastUsedProperty:forKey:")]
		[CompilerGenerated]
		public abstract NSObject LastUsedProperty (string styleProperty, NSString key);
		[Export ("lastUsedStyleForKey:")]
		[CompilerGenerated]
		public abstract PSPDFAnnotationStyle LastUsedStyleForKey (NSString key);
		[Export ("presetsForKey:type:")]
		[CompilerGenerated]
		public abstract NSObject[] PresetsForKey (NSString key, string type);
		[Export ("removeStyle:forKey:")]
		[CompilerGenerated]
		public abstract void RemoveStyle (PSPDFAnnotationStyle style, NSString key);
		[Export ("setLastUsedValue:forProperty:forKey:")]
		[CompilerGenerated]
		public abstract void SetLastUsedValue (NSObject value, string styleProperty, NSString key);
		[Export ("setPresets:forKey:type:")]
		[CompilerGenerated]
		public abstract void SetPresets (NSObject[] presets, NSString key, string type);
		[Export ("setShouldUpdateDefaultsForAnnotationChanges:")]
		[CompilerGenerated]
		public virtual void SetShouldUpdateDefaultsForAnnotationChanges (bool styleKeys)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setStyleKeys:")]
		[CompilerGenerated]
		public virtual void SetStyleKeys (NSSet styleKeys)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setupDefaultStylesIfNeeded")]
		[CompilerGenerated]
		public abstract void SetupDefaultStylesIfNeeded ();
		[Export ("stylesForKey:")]
		[CompilerGenerated]
		public abstract NSObject[] StylesForKey (NSString key);
	} /* class PSPDFAnnotationStyleManager */
}
