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
	[Register("PSPDFUndoController", true)]
	public unsafe partial class PSPDFUndoController : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFUndoController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFUndoController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFUndoController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithUndoEnabled:")]
		[CompilerGenerated]
		public PSPDFUndoController (bool undoEnabled)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_bool (this.Handle, Selector.GetHandle ("initWithUndoEnabled:"), undoEnabled), "initWithUndoEnabled:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("initWithUndoEnabled:"), undoEnabled), "initWithUndoEnabled:");
			}
		}
		
		[Export ("beginUndoGrouping")]
		[CompilerGenerated]
		public virtual void BeginUndoGrouping ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("beginUndoGrouping"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beginUndoGrouping"));
			}
		}
		
		[Export ("commitIncompleteUndoActions")]
		[CompilerGenerated]
		public virtual void CommitIncompleteUndoActions ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("commitIncompleteUndoActions"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("commitIncompleteUndoActions"));
			}
		}
		
		[Export ("endUndoGroupingWithName:")]
		[CompilerGenerated]
		public virtual void EndUndoGrouping (string groupName)
		{
			var nsgroupName = NSString.CreateNative (groupName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("endUndoGroupingWithName:"), nsgroupName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("endUndoGroupingWithName:"), nsgroupName);
			}
			NSString.ReleaseNative (nsgroupName);
			
		}
		
		[Export ("endUndoGroupingWithProperty:ofObject:")]
		[CompilerGenerated]
		public virtual void EndUndoGrouping (string changedProperty, NSObject obj)
		{
			if (changedProperty == null)
				throw new ArgumentNullException ("changedProperty");
			var nschangedProperty = NSString.CreateNative (changedProperty);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("endUndoGroupingWithProperty:ofObject:"), nschangedProperty, obj == null ? IntPtr.Zero : obj.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("endUndoGroupingWithProperty:ofObject:"), nschangedProperty, obj == null ? IntPtr.Zero : obj.Handle);
			}
			NSString.ReleaseNative (nschangedProperty);
			
		}
		
		[Export ("isObjectRegisteredForUndo:")]
		[CompilerGenerated]
		public virtual bool IsObjectRegisteredForUndo (IPSPDFUndoProtocol obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isObjectRegisteredForUndo:"), obj.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isObjectRegisteredForUndo:"), obj.Handle);
			}
		}
		
		[Export ("performBlockAsGroup:name:")]
		[CompilerGenerated]
		public unsafe virtual void PerformActionAsGroup ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler, string groupName)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDAction.Handler, handler);
			var nsgroupName = NSString.CreateNative (groupName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("performBlockAsGroup:name:"), (IntPtr) block_ptr_handler, nsgroupName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("performBlockAsGroup:name:"), (IntPtr) block_ptr_handler, nsgroupName);
			}
			block_ptr_handler->CleanupBlock ();
			NSString.ReleaseNative (nsgroupName);
			
		}
		
		[Export ("performBlockWithoutUndo:")]
		[CompilerGenerated]
		public unsafe virtual void PerformActionWithoutUndo ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDAction.Handler, block);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("performBlockWithoutUndo:"), (IntPtr) block_ptr_block);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("performBlockWithoutUndo:"), (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("performUndoAction:")]
		[CompilerGenerated]
		public virtual void PerformUndoAction (NSObject action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("performUndoAction:"), action.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("performUndoAction:"), action.Handle);
			}
		}
		
		[Export ("prepareWithInvocationTarget:block:")]
		[CompilerGenerated]
		public unsafe virtual void PrepareWithInvocationTarget (NSObject target, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<NSObject> handler)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDActionArity1V5.Handler, handler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("prepareWithInvocationTarget:block:"), target.Handle, (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("prepareWithInvocationTarget:block:"), target.Handle, (IntPtr) block_ptr_handler);
			}
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("redo")]
		[CompilerGenerated]
		public virtual void Redo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("redo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("redo"));
			}
		}
		
		[Export ("registerObjectForUndo:")]
		[CompilerGenerated]
		public virtual void RegisterObjectForUndo (IPSPDFUndoProtocol obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerObjectForUndo:"), obj.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerObjectForUndo:"), obj.Handle);
			}
		}
		
		[Export ("removeAllActions")]
		[CompilerGenerated]
		public virtual void RemoveAllActions ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllActions"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeAllActions"));
			}
		}
		
		[Export ("removeAllActionsWithTarget:")]
		[CompilerGenerated]
		public virtual void RemoveAllActions (NSObject target)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAllActionsWithTarget:"), target.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAllActionsWithTarget:"), target.Handle);
			}
		}
		
		[Export ("undo")]
		[CompilerGenerated]
		public virtual void Undo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("undo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("undo"));
			}
		}
		
		[Export ("unregisterObjectForUndo:")]
		[CompilerGenerated]
		public virtual void UnregisterObjectForUndo (IPSPDFUndoProtocol obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unregisterObjectForUndo:"), obj.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("unregisterObjectForUndo:"), obj.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool CanRedo {
			[Export ("canRedo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canRedo"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canRedo"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CanUndo {
			[Export ("canUndo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canUndo"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canUndo"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasIncompleteUndoActions {
			[Export ("hasIncompleteUndoActions")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasIncompleteUndoActions"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasIncompleteUndoActions"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string IncompleteUndoActionName {
			[Export ("incompleteUndoActionName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("incompleteUndoActionName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("incompleteUndoActionName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsRedoing {
			[Export ("isRedoing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRedoing"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRedoing"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsUndoing {
			[Export ("isUndoing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUndoing"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isUndoing"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsWorking {
			[Export ("isWorking")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isWorking"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isWorking"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint LevelsOfUndo {
			[Export ("levelsOfUndo", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("levelsOfUndo"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("levelsOfUndo"));
				}
			}
			
			[Export ("setLevelsOfUndo:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setLevelsOfUndo:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setLevelsOfUndo:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double TimedCoalescingInterval {
			[Export ("timedCoalescingInterval", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("timedCoalescingInterval"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timedCoalescingInterval"));
				}
			}
			
			[Export ("setTimedCoalescingInterval:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setTimedCoalescingInterval:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setTimedCoalescingInterval:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UndoEnabled {
			[Export ("isUndoEnabled", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUndoEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isUndoEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_UndoManager_var;
		[CompilerGenerated]
		public virtual NSUndoManager UndoManager {
			[Export ("undoManager", ArgumentSemantic.Retain)]
			get {
				NSUndoManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUndoManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("undoManager")));
				} else {
					ret =  Runtime.GetNSObject<NSUndoManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("undoManager")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UndoManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _AddedUndoActionNotification;
		[Field ("PSPDFUndoControllerAddedUndoActionNotification",  "__Internal")]
		public static unsafe NSString AddedUndoActionNotification {
			get {
				if (_AddedUndoActionNotification == null)
					_AddedUndoActionNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFUndoControllerAddedUndoActionNotification");
				return _AddedUndoActionNotification;
			}
		}
		[CompilerGenerated]
		static NSString _RemovedUndoActionNotification;
		[Field ("PSPDFUndoControllerRemovedUndoActionNotification",  "__Internal")]
		public static unsafe NSString RemovedUndoActionNotification {
			get {
				if (_RemovedUndoActionNotification == null)
					_RemovedUndoActionNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFUndoControllerRemovedUndoActionNotification");
				return _RemovedUndoActionNotification;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_UndoManager_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveAddedUndoAction (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AddedUndoActionNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveRemovedUndoAction (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RemovedUndoActionNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class PSPDFUndoController */
}
