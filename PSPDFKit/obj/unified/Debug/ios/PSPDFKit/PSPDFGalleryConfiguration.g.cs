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
	[Register("PSPDFGalleryConfiguration", true)]
	public unsafe partial class PSPDFGalleryConfiguration : PSPDFModel {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFGalleryConfiguration");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFGalleryConfiguration (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFGalleryConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFGalleryConfiguration (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("configurationWithBuilder:")]
		[CompilerGenerated]
		public unsafe static PSPDFGalleryConfiguration FromBuilder ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V7))]global::System.Action<PSPDFGalleryConfigurationBuilder> builderHandler)
		{
			if (builderHandler == null)
				throw new ArgumentNullException ("builderHandler");
			BlockLiteral *block_ptr_builderHandler;
			BlockLiteral block_builderHandler;
			block_builderHandler = new BlockLiteral ();
			block_ptr_builderHandler = &block_builderHandler;
			block_builderHandler.SetupBlock (Trampolines.SDActionArity1V7.Handler, builderHandler);
			
			PSPDFGalleryConfiguration ret;
			ret =  Runtime.GetNSObject<PSPDFGalleryConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("configurationWithBuilder:"), (IntPtr) block_ptr_builderHandler));
			block_ptr_builderHandler->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual bool AllowPlayingMultipleInstances {
			[Export ("allowPlayingMultipleInstances", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowPlayingMultipleInstances"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowPlayingMultipleInstances"));
				}
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_DefaultConfiguration_var_static;
		[CompilerGenerated]
		public static PSPDFGalleryConfiguration DefaultConfiguration {
			[Export ("defaultConfiguration")]
			get {
				PSPDFGalleryConfiguration ret;
				ret =  Runtime.GetNSObject<PSPDFGalleryConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultConfiguration")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_DefaultConfiguration_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool DisplayModeUserInteractionEnabled {
			[Export ("displayModeUserInteractionEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("displayModeUserInteractionEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayModeUserInteractionEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat FullscreenDismissPanThreshold {
			[Export ("fullscreenDismissPanThreshold", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("fullscreenDismissPanThreshold"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fullscreenDismissPanThreshold"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool FullscreenZoomEnabled {
			[Export ("isFullscreenZoomEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFullscreenZoomEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isFullscreenZoomEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool LoopEnabled {
			[Export ("isLoopEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLoopEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLoopEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool LoopHUDEnabled {
			[Export ("isLoopHUDEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLoopHUDEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLoopHUDEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint MaximumConcurrentDownloads {
			[Export ("maximumConcurrentDownloads", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumConcurrentDownloads"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumConcurrentDownloads"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat MaximumFullscreenZoomScale {
			[Export ("maximumFullscreenZoomScale", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maximumFullscreenZoomScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumFullscreenZoomScale"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint MaximumPrefetchDownloads {
			[Export ("maximumPrefetchDownloads", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maximumPrefetchDownloads"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumPrefetchDownloads"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat MinimumFullscreenZoomScale {
			[Export ("minimumFullscreenZoomScale", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("minimumFullscreenZoomScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumFullscreenZoomScale"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool UsesExternalPlaybackWhileExternalScreenIsActive {
			[Export ("usesExternalPlaybackWhileExternalScreenIsActive", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesExternalPlaybackWhileExternalScreenIsActive"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("usesExternalPlaybackWhileExternalScreenIsActive"));
				}
			}
			
		}
		
	} /* class PSPDFGalleryConfiguration */
}
