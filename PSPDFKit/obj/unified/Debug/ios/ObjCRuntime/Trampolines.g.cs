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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFConfigurationBuilder>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFConfigurationBuilder> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFConfigurationBuilder> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFConfigurationBuilder>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFConfigurationBuilder obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::UIKit.UIViewController, NSString>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UIViewController> (arg1),  Runtime.GetNSObject<NSString> (arg2));
			}
		} /* class SDActionArity2V0 */
		
		internal class NIDActionArity2V0 {
			IntPtr blockPtr;
			DActionArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::UIKit.UIViewController, NSString> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::UIKit.UIViewController, NSString>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::UIKit.UIViewController arg1, NSString arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V1 (IntPtr block, bool obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, bool obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<bool>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V1 */
		
		internal class NIDActionArity1V1 {
			IntPtr blockPtr;
			DActionArity1V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<bool>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V2 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V2 {
			static internal readonly DActionArity1V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V2))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFViewController>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFViewController> (obj));
			}
		} /* class SDActionArity1V2 */
		
		internal class NIDActionArity1V2 {
			IntPtr blockPtr;
			DActionArity1V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFViewController> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFViewController>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFViewController obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity3V0 (IntPtr block, IntPtr arg1, global::System.nuint arg2, bool arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V0 {
			static internal readonly DActionArity3V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, global::System.nuint arg2, bool arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFAnnotation[], global::System.nuint, bool>) (descriptor->Target);
				if (del != null)
					del (NSArray.ArrayFromHandle<global::PSPDFKit.PSPDFAnnotation> (arg1), arg2, arg3);
			}
		} /* class SDActionArity3V0 */
		
		internal class NIDActionArity3V0 {
			IntPtr blockPtr;
			DActionArity3V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity3V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity3V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity3V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFAnnotation[], global::System.nuint, bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFAnnotation[], global::System.nuint, bool>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity3V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFAnnotation[] arg1, global::System.nuint arg2, bool arg3)
			{
				var nsa_arg1 = arg1 == null ? null : NSArray.FromNSObjects (arg1);
				
				invoker (blockPtr, nsa_arg1 == null ? IntPtr.Zero : nsa_arg1.Handle, arg2, arg3);
				if (nsa_arg1 != null)
					nsa_arg1.Dispose ();
				
			}
		} /* class NIDActionArity3V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V1 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V1 {
			static internal readonly DActionArity2V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V1))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFAnnotation[], NSError>) (descriptor->Target);
				if (del != null)
					del (NSArray.ArrayFromHandle<global::PSPDFKit.PSPDFAnnotation> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDActionArity2V1 */
		
		internal class NIDActionArity2V1 {
			IntPtr blockPtr;
			DActionArity2V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFAnnotation[], NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFAnnotation[], NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFAnnotation[] arg1, NSError arg2)
			{
				var nsa_arg1 = arg1 == null ? null : NSArray.FromNSObjects (arg1);
				
				invoker (blockPtr, nsa_arg1 == null ? IntPtr.Zero : nsa_arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
				if (nsa_arg1 != null)
					nsa_arg1.Dispose ();
				
			}
		} /* class NIDActionArity2V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V3 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V3 {
			static internal readonly DActionArity1V3 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V3))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFDocumentProvider>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFDocumentProvider> (obj));
			}
		} /* class SDActionArity1V3 */
		
		internal class NIDActionArity1V3 {
			IntPtr blockPtr;
			DActionArity1V3 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V3 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V3> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V3 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFDocumentProvider> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFDocumentProvider>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V3 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFDocumentProvider obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V3 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DFuncArity2V0 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V0 {
			static internal readonly DFuncArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V0))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<NSOrderedSet, global::PSPDFKit.PSPDFCacheInfo>) (descriptor->Target);
				PSPDFKit.PSPDFCacheInfo retval = del ( Runtime.GetNSObject<NSOrderedSet> (arg));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDFuncArity2V0 */
		
		internal class NIDFuncArity2V0 {
			IntPtr blockPtr;
			DFuncArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<NSOrderedSet, global::PSPDFKit.PSPDFCacheInfo> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Func<NSOrderedSet, global::PSPDFKit.PSPDFCacheInfo>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDFuncArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe global::PSPDFKit.PSPDFCacheInfo Invoke (NSOrderedSet arg)
			{
				var ret =  Runtime.GetNSObject<global::PSPDFKit.PSPDFCacheInfo> (invoker (blockPtr, arg == null ? IntPtr.Zero : arg.Handle));
				return ret;
			}
		} /* class NIDFuncArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DFuncArity2V1 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V1 {
			static internal readonly DFuncArity2V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V1))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<NSString, global::UIKit.UIImage>) (descriptor->Target);
				UIKit.UIImage retval = del ( Runtime.GetNSObject<NSString> (arg));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDFuncArity2V1 */
		
		internal class NIDFuncArity2V1 {
			IntPtr blockPtr;
			DFuncArity2V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity2V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity2V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity2V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<NSString, global::UIKit.UIImage> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Func<NSString, global::UIKit.UIImage>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDFuncArity2V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe global::UIKit.UIImage Invoke (NSString arg)
			{
				var ret =  Runtime.GetNSObject<global::UIKit.UIImage> (invoker (blockPtr, arg == null ? IntPtr.Zero : arg.Handle));
				return ret;
			}
		} /* class NIDFuncArity2V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V2 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V2 {
			static internal readonly DActionArity2V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V2))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::UIKit.UIImage, global::PSPDFKit.PSPDFCacheInfo>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UIImage> (arg1),  Runtime.GetNSObject<PSPDFKit.PSPDFCacheInfo> (arg2));
			}
		} /* class SDActionArity2V2 */
		
		internal class NIDActionArity2V2 {
			IntPtr blockPtr;
			DActionArity2V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::UIKit.UIImage, global::PSPDFKit.PSPDFCacheInfo> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::UIKit.UIImage, global::PSPDFKit.PSPDFCacheInfo>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::UIKit.UIImage arg1, global::PSPDFKit.PSPDFCacheInfo arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DFuncArity2V2 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V2 {
			static internal readonly DFuncArity2V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V2))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::UIKit.UIImage, NSData>) (descriptor->Target);
				Foundation.NSData retval = del ( Runtime.GetNSObject<UIImage> (arg));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDFuncArity2V2 */
		
		internal class NIDFuncArity2V2 {
			IntPtr blockPtr;
			DFuncArity2V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity2V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity2V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity2V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<global::UIKit.UIImage, NSData> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Func<global::UIKit.UIImage, NSData>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDFuncArity2V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe NSData Invoke (global::UIKit.UIImage arg)
			{
				var ret =  Runtime.GetNSObject<NSData> (invoker (blockPtr, arg == null ? IntPtr.Zero : arg.Handle));
				return ret;
			}
		} /* class NIDFuncArity2V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V4 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V4 {
			static internal readonly DActionArity1V4 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V4))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFCacheInfo>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFCacheInfo> (obj));
			}
		} /* class SDActionArity1V4 */
		
		internal class NIDActionArity1V4 {
			IntPtr blockPtr;
			DActionArity1V4 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V4 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V4> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V4 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFCacheInfo> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFCacheInfo>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V4 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFCacheInfo obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V4 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity4V0 (IntPtr block, IntPtr arg1, IntPtr arg2, global::System.nuint arg3, CGSize arg4);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity4V0 {
			static internal readonly DActionArity4V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity4V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2, global::System.nuint arg3, CGSize arg4) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::UIKit.UIImage, global::PSPDFKit.PSPDFDocument, global::System.nuint, CGSize>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UIImage> (arg1),  Runtime.GetNSObject<PSPDFKit.PSPDFDocument> (arg2), arg3, arg4);
			}
		} /* class SDActionArity4V0 */
		
		internal class NIDActionArity4V0 {
			IntPtr blockPtr;
			DActionArity4V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity4V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity4V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity4V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::UIKit.UIImage, global::PSPDFKit.PSPDFDocument, global::System.nuint, CGSize> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::UIKit.UIImage, global::PSPDFKit.PSPDFDocument, global::System.nuint, CGSize>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity4V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::UIKit.UIImage arg1, global::PSPDFKit.PSPDFDocument arg2, global::System.nuint arg3, CGSize arg4)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle, arg3, arg4);
			}
		} /* class NIDActionArity4V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DPSPDFCacheDecryptFromPathHandler (IntPtr block, IntPtr document, IntPtr path);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFCacheDecryptFromPathHandler {
			static internal readonly DPSPDFCacheDecryptFromPathHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFCacheDecryptFromPathHandler))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr document, IntPtr path) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFCacheDecryptFromPathHandler) (descriptor->Target);
				Foundation.NSData retval = del ( Runtime.GetNSObject<PSPDFKit.PSPDFDocument> (document), NSString.FromHandle (path));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDPSPDFCacheDecryptFromPathHandler */
		
		internal class NIDPSPDFCacheDecryptFromPathHandler {
			IntPtr blockPtr;
			DPSPDFCacheDecryptFromPathHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFCacheDecryptFromPathHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFCacheDecryptFromPathHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFCacheDecryptFromPathHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFCacheDecryptFromPathHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFCacheDecryptFromPathHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFCacheDecryptFromPathHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe NSData Invoke (global::PSPDFKit.PSPDFDocument document, string path)
			{
				var nspath = NSString.CreateNative (path);
				
				var ret =  Runtime.GetNSObject<NSData> (invoker (blockPtr, document == null ? IntPtr.Zero : document.Handle, nspath));
				NSString.ReleaseNative (nspath);
				
				return ret;
			}
		} /* class NIDPSPDFCacheDecryptFromPathHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFCacheEncryptDataHandler (IntPtr block, IntPtr document, IntPtr data);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFCacheEncryptDataHandler {
			static internal readonly DPSPDFCacheEncryptDataHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFCacheEncryptDataHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr document, IntPtr data) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFCacheEncryptDataHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFDocument> (document),  Runtime.GetNSObject<NSMutableData> (data));
			}
		} /* class SDPSPDFCacheEncryptDataHandler */
		
		internal class NIDPSPDFCacheEncryptDataHandler {
			IntPtr blockPtr;
			DPSPDFCacheEncryptDataHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFCacheEncryptDataHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFCacheEncryptDataHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFCacheEncryptDataHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFCacheEncryptDataHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFCacheEncryptDataHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFCacheEncryptDataHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFDocument document, NSMutableData data)
			{
				invoker (blockPtr, document == null ? IntPtr.Zero : document.Handle, data == null ? IntPtr.Zero : data.Handle);
			}
		} /* class NIDPSPDFCacheEncryptDataHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V3 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V3 {
			static internal readonly DActionArity2V3 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V3))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFRenderJob, global::PSPDFKit.PSPDFRenderQueue>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFRenderJob> (arg1),  Runtime.GetNSObject<PSPDFKit.PSPDFRenderQueue> (arg2));
			}
		} /* class SDActionArity2V3 */
		
		internal class NIDActionArity2V3 {
			IntPtr blockPtr;
			DActionArity2V3 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V3 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V3> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V3 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFRenderJob, global::PSPDFKit.PSPDFRenderQueue> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFRenderJob, global::PSPDFKit.PSPDFRenderQueue>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V3 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFRenderJob arg1, global::PSPDFKit.PSPDFRenderQueue arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V3 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFRenderJobCompletionHandler (IntPtr block, IntPtr renderJob, IntPtr renderQueue);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFRenderJobCompletionHandler {
			static internal readonly DPSPDFRenderJobCompletionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFRenderJobCompletionHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr renderJob, IntPtr renderQueue) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFRenderJobCompletionHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFRenderJob> (renderJob),  Runtime.GetNSObject<PSPDFKit.PSPDFRenderQueue> (renderQueue));
			}
		} /* class SDPSPDFRenderJobCompletionHandler */
		
		internal class NIDPSPDFRenderJobCompletionHandler {
			IntPtr blockPtr;
			DPSPDFRenderJobCompletionHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFRenderJobCompletionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFRenderJobCompletionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFRenderJobCompletionHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFRenderJobCompletionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFRenderJobCompletionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFRenderJobCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFRenderJob renderJob, global::PSPDFKit.PSPDFRenderQueue renderQueue)
			{
				invoker (blockPtr, renderJob == null ? IntPtr.Zero : renderJob.Handle, renderQueue == null ? IntPtr.Zero : renderQueue.Handle);
			}
		} /* class NIDPSPDFRenderJobCompletionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V5 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V5 {
			static internal readonly DActionArity1V5 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V5))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSObject>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSObject> (obj));
			}
		} /* class SDActionArity1V5 */
		
		internal class NIDActionArity1V5 {
			IntPtr blockPtr;
			DActionArity1V5 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V5 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V5> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V5 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSObject> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSObject>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V5 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSObject obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V5 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate bool DPSPDFFileManagerErrorHandler (IntPtr block, IntPtr url, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFFileManagerErrorHandler {
			static internal readonly DPSPDFFileManagerErrorHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFFileManagerErrorHandler))]
			static unsafe bool Invoke (IntPtr block, IntPtr url, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFFileManagerErrorHandler) (descriptor->Target);
				System.Boolean retval = del ( Runtime.GetNSObject<NSUrl> (url),  Runtime.GetNSObject<NSError> (error));
				return retval;
			}
		} /* class SDPSPDFFileManagerErrorHandler */
		
		internal class NIDPSPDFFileManagerErrorHandler {
			IntPtr blockPtr;
			DPSPDFFileManagerErrorHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFFileManagerErrorHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFFileManagerErrorHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFFileManagerErrorHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFFileManagerErrorHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFFileManagerErrorHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFFileManagerErrorHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe bool Invoke (NSUrl url, NSError error)
			{
				var ret = invoker (blockPtr, url == null ? IntPtr.Zero : url.Handle, error == null ? IntPtr.Zero : error.Handle);
				return ret;
			}
		} /* class NIDPSPDFFileManagerErrorHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate bool DFuncArity2V3 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V3 {
			static internal readonly DFuncArity2V3 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V3))]
			static unsafe bool Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<NSFileHandle, bool>) (descriptor->Target);
				System.Boolean retval = del ( Runtime.GetNSObject<NSFileHandle> (arg));
				return retval;
			}
		} /* class SDFuncArity2V3 */
		
		internal class NIDFuncArity2V3 {
			IntPtr blockPtr;
			DFuncArity2V3 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity2V3 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity2V3> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity2V3 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<NSFileHandle, bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Func<NSFileHandle, bool>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDFuncArity2V3 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe bool Invoke (NSFileHandle arg)
			{
				var ret = invoker (blockPtr, arg == null ? IntPtr.Zero : arg.Handle);
				return ret;
			}
		} /* class NIDFuncArity2V3 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate bool DPSPDFDownloadManagerPredicateHandler (IntPtr block, IntPtr obj, global::System.nuint index, bool stop);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFDownloadManagerPredicateHandler {
			static internal readonly DPSPDFDownloadManagerPredicateHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFDownloadManagerPredicateHandler))]
			static unsafe bool Invoke (IntPtr block, IntPtr obj, global::System.nuint index, bool stop) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFDownloadManagerPredicateHandler) (descriptor->Target);
				System.Boolean retval = del ( Runtime.GetNSObject<NSObject> (obj), index, stop);
				return retval;
			}
		} /* class SDPSPDFDownloadManagerPredicateHandler */
		
		internal class NIDPSPDFDownloadManagerPredicateHandler {
			IntPtr blockPtr;
			DPSPDFDownloadManagerPredicateHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFDownloadManagerPredicateHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFDownloadManagerPredicateHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFDownloadManagerPredicateHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFDownloadManagerPredicateHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFDownloadManagerPredicateHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFDownloadManagerPredicateHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe bool Invoke (NSObject obj, global::System.nuint index, bool stop)
			{
				var ret = invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle, index, stop);
				return ret;
			}
		} /* class NIDPSPDFDownloadManagerPredicateHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFDownloadManagerDelegateAuthCompletionHandler (IntPtr block, nint disposition, IntPtr credential);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFDownloadManagerDelegateAuthCompletionHandler {
			static internal readonly DPSPDFDownloadManagerDelegateAuthCompletionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFDownloadManagerDelegateAuthCompletionHandler))]
			static unsafe void Invoke (IntPtr block, nint disposition, IntPtr credential) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFDownloadManagerDelegateAuthCompletionHandler) (descriptor->Target);
				if (del != null)
					del ((NSUrlSessionAuthChallengeDisposition) (global::System.Int64) disposition,  Runtime.GetNSObject<NSUrlCredential> (credential));
			}
		} /* class SDPSPDFDownloadManagerDelegateAuthCompletionHandler */
		
		internal class NIDPSPDFDownloadManagerDelegateAuthCompletionHandler {
			IntPtr blockPtr;
			DPSPDFDownloadManagerDelegateAuthCompletionHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFDownloadManagerDelegateAuthCompletionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFDownloadManagerDelegateAuthCompletionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFDownloadManagerDelegateAuthCompletionHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFDownloadManagerDelegateAuthCompletionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFDownloadManagerDelegateAuthCompletionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFDownloadManagerDelegateAuthCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSUrlSessionAuthChallengeDisposition disposition, NSUrlCredential credential)
			{
				invoker (blockPtr, (nint) (Int64) disposition, credential == null ? IntPtr.Zero : credential.Handle);
			}
		} /* class NIDPSPDFDownloadManagerDelegateAuthCompletionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFRemoteFileObjectRemoteObjectHandler (IntPtr block, IntPtr remoteObject);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFRemoteFileObjectRemoteObjectHandler {
			static internal readonly DPSPDFRemoteFileObjectRemoteObjectHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFRemoteFileObjectRemoteObjectHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr remoteObject) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFRemoteFileObjectRemoteObjectHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetINativeObject<PSPDFKit.IPSPDFRemoteContentObject> (remoteObject, false));
			}
		} /* class SDPSPDFRemoteFileObjectRemoteObjectHandler */
		
		internal class NIDPSPDFRemoteFileObjectRemoteObjectHandler {
			IntPtr blockPtr;
			DPSPDFRemoteFileObjectRemoteObjectHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFRemoteFileObjectRemoteObjectHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFRemoteFileObjectRemoteObjectHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFRemoteFileObjectRemoteObjectHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFRemoteFileObjectRemoteObjectHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFRemoteFileObjectRemoteObjectHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFRemoteFileObjectRemoteObjectHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.IPSPDFRemoteContentObject remoteObject)
			{
				invoker (blockPtr, remoteObject == null ? IntPtr.Zero : remoteObject.Handle);
			}
		} /* class NIDPSPDFRemoteFileObjectRemoteObjectHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V4 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V4 {
			static internal readonly DActionArity2V4 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V4))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<string, NSDictionary>) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg1),  Runtime.GetNSObject<NSDictionary> (arg2));
			}
		} /* class SDActionArity2V4 */
		
		internal class NIDActionArity2V4 {
			IntPtr blockPtr;
			DActionArity2V4 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V4 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V4> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V4 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<string, NSDictionary> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<string, NSDictionary>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V4 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg1, NSDictionary arg2)
			{
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, nsarg1, arg2 == null ? IntPtr.Zero : arg2.Handle);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDActionArity2V4 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V5 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V5 {
			static internal readonly DActionArity2V5 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V5))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSString, NSDictionary>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSString> (arg1),  Runtime.GetNSObject<NSDictionary> (arg2));
			}
		} /* class SDActionArity2V5 */
		
		internal class NIDActionArity2V5 {
			IntPtr blockPtr;
			DActionArity2V5 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V5 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V5> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V5 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSString, NSDictionary> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSString, NSDictionary>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V5 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSString arg1, NSDictionary arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V5 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DFuncArity1V0 (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity1V0 {
			static internal readonly DFuncArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity1V0))]
			static unsafe IntPtr Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<NSData>) (descriptor->Target);
				Foundation.NSData retval = del ();
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDFuncArity1V0 */
		
		internal class NIDFuncArity1V0 {
			IntPtr blockPtr;
			DFuncArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<NSData> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Func<NSData>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDFuncArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe NSData Invoke ()
			{
				var ret =  Runtime.GetNSObject<NSData> (invoker (blockPtr));
				return ret;
			}
		} /* class NIDFuncArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V6 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V6 {
			static internal readonly DActionArity1V6 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V6))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::UIKit.UIColor>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UIColor> (obj));
			}
		} /* class SDActionArity1V6 */
		
		internal class NIDActionArity1V6 {
			IntPtr blockPtr;
			DActionArity1V6 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V6 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V6> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V6 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::UIKit.UIColor> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::UIKit.UIColor>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V6 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::UIKit.UIColor obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V6 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DPSPDFAnnotationGroupItemConfigurationHandler (IntPtr block, IntPtr item, IntPtr container, IntPtr tintColor);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFAnnotationGroupItemConfigurationHandler {
			static internal readonly DPSPDFAnnotationGroupItemConfigurationHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFAnnotationGroupItemConfigurationHandler))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr item, IntPtr container, IntPtr tintColor) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFAnnotationGroupItemConfigurationHandler) (descriptor->Target);
				UIKit.UIImage retval = del ( Runtime.GetNSObject<PSPDFKit.PSPDFAnnotationGroupItem> (item),  Runtime.GetNSObject<NSObject> (container),  Runtime.GetNSObject<UIColor> (tintColor));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDPSPDFAnnotationGroupItemConfigurationHandler */
		
		internal class NIDPSPDFAnnotationGroupItemConfigurationHandler {
			IntPtr blockPtr;
			DPSPDFAnnotationGroupItemConfigurationHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFAnnotationGroupItemConfigurationHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFAnnotationGroupItemConfigurationHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFAnnotationGroupItemConfigurationHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFAnnotationGroupItemConfigurationHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFAnnotationGroupItemConfigurationHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFAnnotationGroupItemConfigurationHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe global::UIKit.UIImage Invoke (global::PSPDFKit.PSPDFAnnotationGroupItem item, NSObject container, global::UIKit.UIColor tintColor)
			{
				var ret =  Runtime.GetNSObject<global::UIKit.UIImage> (invoker (blockPtr, item == null ? IntPtr.Zero : item.Handle, container == null ? IntPtr.Zero : container.Handle, tintColor == null ? IntPtr.Zero : tintColor.Handle));
				return ret;
			}
		} /* class NIDPSPDFAnnotationGroupItemConfigurationHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFProcessorProgressHandler (IntPtr block, global::System.nuint currentPage, global::System.nuint numberOfProcessedPages, global::System.nuint totalPages);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFProcessorProgressHandler {
			static internal readonly DPSPDFProcessorProgressHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFProcessorProgressHandler))]
			static unsafe void Invoke (IntPtr block, global::System.nuint currentPage, global::System.nuint numberOfProcessedPages, global::System.nuint totalPages) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFProcessorProgressHandler) (descriptor->Target);
				if (del != null)
					del (currentPage, numberOfProcessedPages, totalPages);
			}
		} /* class SDPSPDFProcessorProgressHandler */
		
		internal class NIDPSPDFProcessorProgressHandler {
			IntPtr blockPtr;
			DPSPDFProcessorProgressHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFProcessorProgressHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFProcessorProgressHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFProcessorProgressHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFProcessorProgressHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFProcessorProgressHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFProcessorProgressHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::System.nuint currentPage, global::System.nuint numberOfProcessedPages, global::System.nuint totalPages)
			{
				invoker (blockPtr, currentPage, numberOfProcessedPages, totalPages);
			}
		} /* class NIDPSPDFProcessorProgressHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFProcessorPdfFromUrlHandler (IntPtr block, IntPtr fileUrl, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFProcessorPdfFromUrlHandler {
			static internal readonly DPSPDFProcessorPdfFromUrlHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFProcessorPdfFromUrlHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr fileUrl, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFProcessorPdfFromUrlHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSUrl> (fileUrl),  Runtime.GetNSObject<NSError> (error));
			}
		} /* class SDPSPDFProcessorPdfFromUrlHandler */
		
		internal class NIDPSPDFProcessorPdfFromUrlHandler {
			IntPtr blockPtr;
			DPSPDFProcessorPdfFromUrlHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFProcessorPdfFromUrlHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFProcessorPdfFromUrlHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFProcessorPdfFromUrlHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFProcessorPdfFromUrlHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFProcessorPdfFromUrlHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFProcessorPdfFromUrlHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSUrl fileUrl, NSError error)
			{
				invoker (blockPtr, fileUrl == null ? IntPtr.Zero : fileUrl.Handle, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDPSPDFProcessorPdfFromUrlHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFProcessorPdfFromUrlNsdataHandler (IntPtr block, IntPtr fileData, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFProcessorPdfFromUrlNsdataHandler {
			static internal readonly DPSPDFProcessorPdfFromUrlNsdataHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFProcessorPdfFromUrlNsdataHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr fileData, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFProcessorPdfFromUrlNsdataHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSData> (fileData),  Runtime.GetNSObject<NSError> (error));
			}
		} /* class SDPSPDFProcessorPdfFromUrlNsdataHandler */
		
		internal class NIDPSPDFProcessorPdfFromUrlNsdataHandler {
			IntPtr blockPtr;
			DPSPDFProcessorPdfFromUrlNsdataHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFProcessorPdfFromUrlNsdataHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFProcessorPdfFromUrlNsdataHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFProcessorPdfFromUrlNsdataHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFProcessorPdfFromUrlNsdataHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFProcessorPdfFromUrlNsdataHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFProcessorPdfFromUrlNsdataHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSData fileData, NSError error)
			{
				invoker (blockPtr, fileData == null ? IntPtr.Zero : fileData.Handle, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDPSPDFProcessorPdfFromUrlNsdataHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DPSPDFXFDFAnnotationProviderStreamHandler (IntPtr block, IntPtr provider);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFXFDFAnnotationProviderStreamHandler {
			static internal readonly DPSPDFXFDFAnnotationProviderStreamHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFXFDFAnnotationProviderStreamHandler))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr provider) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFXFDFAnnotationProviderStreamHandler) (descriptor->Target);
				Foundation.NSInputStream retval = del ( Runtime.GetNSObject<PSPDFKit.PSPDFXFDFAnnotationProvider> (provider));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDPSPDFXFDFAnnotationProviderStreamHandler */
		
		internal class NIDPSPDFXFDFAnnotationProviderStreamHandler {
			IntPtr blockPtr;
			DPSPDFXFDFAnnotationProviderStreamHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFXFDFAnnotationProviderStreamHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFXFDFAnnotationProviderStreamHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFXFDFAnnotationProviderStreamHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFXFDFAnnotationProviderStreamHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFXFDFAnnotationProviderStreamHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFXFDFAnnotationProviderStreamHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe NSInputStream Invoke (global::PSPDFKit.PSPDFXFDFAnnotationProvider provider)
			{
				var ret =  Runtime.GetNSObject<NSInputStream> (invoker (blockPtr, provider == null ? IntPtr.Zero : provider.Handle));
				return ret;
			}
		} /* class NIDPSPDFXFDFAnnotationProviderStreamHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFPKCS12UnlockHandler (IntPtr block, IntPtr x509, IntPtr pk, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFPKCS12UnlockHandler {
			static internal readonly DPSPDFPKCS12UnlockHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFPKCS12UnlockHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr x509, IntPtr pk, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFPKCS12UnlockHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFX509> (x509),  Runtime.GetNSObject<PSPDFKit.PSPDFRSAKey> (pk),  Runtime.GetNSObject<NSError> (error));
			}
		} /* class SDPSPDFPKCS12UnlockHandler */
		
		internal class NIDPSPDFPKCS12UnlockHandler {
			IntPtr blockPtr;
			DPSPDFPKCS12UnlockHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFPKCS12UnlockHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFPKCS12UnlockHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFPKCS12UnlockHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFPKCS12UnlockHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFPKCS12UnlockHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFPKCS12UnlockHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFX509 x509, global::PSPDFKit.PSPDFRSAKey pk, NSError error)
			{
				invoker (blockPtr, x509 == null ? IntPtr.Zero : x509.Handle, pk == null ? IntPtr.Zero : pk.Handle, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDPSPDFPKCS12UnlockHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFPKCS12SignerSignHandler (IntPtr block, bool success, IntPtr document, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFPKCS12SignerSignHandler {
			static internal readonly DPSPDFPKCS12SignerSignHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFPKCS12SignerSignHandler))]
			static unsafe void Invoke (IntPtr block, bool success, IntPtr document, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFPKCS12SignerSignHandler) (descriptor->Target);
				if (del != null)
					del (success,  Runtime.GetNSObject<PSPDFKit.PSPDFDocument> (document),  Runtime.GetNSObject<NSError> (error));
			}
		} /* class SDPSPDFPKCS12SignerSignHandler */
		
		internal class NIDPSPDFPKCS12SignerSignHandler {
			IntPtr blockPtr;
			DPSPDFPKCS12SignerSignHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFPKCS12SignerSignHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFPKCS12SignerSignHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFPKCS12SignerSignHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFPKCS12SignerSignHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFPKCS12SignerSignHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFPKCS12SignerSignHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool success, global::PSPDFKit.PSPDFDocument document, NSError error)
			{
				invoker (blockPtr, success, document == null ? IntPtr.Zero : document.Handle, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDPSPDFPKCS12SignerSignHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V6 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V6 {
			static internal readonly DActionArity2V6 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V6))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFX509, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFX509> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDActionArity2V6 */
		
		internal class NIDActionArity2V6 {
			IntPtr blockPtr;
			DActionArity2V6 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V6 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V6> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V6 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFX509, NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFX509, NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V6 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFX509 arg1, NSError arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V6 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity3V1 (IntPtr block, bool arg1, IntPtr arg2, IntPtr arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V1 {
			static internal readonly DActionArity3V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V1))]
			static unsafe void Invoke (IntPtr block, bool arg1, IntPtr arg2, IntPtr arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<bool, global::PSPDFKit.PSPDFDocument, NSError>) (descriptor->Target);
				if (del != null)
					del (arg1,  Runtime.GetNSObject<PSPDFKit.PSPDFDocument> (arg2),  Runtime.GetNSObject<NSError> (arg3));
			}
		} /* class SDActionArity3V1 */
		
		internal class NIDActionArity3V1 {
			IntPtr blockPtr;
			DActionArity3V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity3V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity3V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity3V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<bool, global::PSPDFKit.PSPDFDocument, NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<bool, global::PSPDFKit.PSPDFDocument, NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity3V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool arg1, global::PSPDFKit.PSPDFDocument arg2, NSError arg3)
			{
				invoker (blockPtr, arg1, arg2 == null ? IntPtr.Zero : arg2.Handle, arg3 == null ? IntPtr.Zero : arg3.Handle);
			}
		} /* class NIDActionArity3V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V7 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V7 {
			static internal readonly DActionArity1V7 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V7))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFGalleryConfigurationBuilder>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFGalleryConfigurationBuilder> (obj));
			}
		} /* class SDActionArity1V7 */
		
		internal class NIDActionArity1V7 {
			IntPtr blockPtr;
			DActionArity1V7 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V7 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V7> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V7 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFGalleryConfigurationBuilder> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFGalleryConfigurationBuilder>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V7 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFGalleryConfigurationBuilder obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V7 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V7 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V7 {
			static internal readonly DActionArity2V7 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V7))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFGalleryItem[], NSError>) (descriptor->Target);
				if (del != null)
					del (NSArray.ArrayFromHandle<global::PSPDFKit.PSPDFGalleryItem> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDActionArity2V7 */
		
		internal class NIDActionArity2V7 {
			IntPtr blockPtr;
			DActionArity2V7 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V7 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V7> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V7 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFGalleryItem[], NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFGalleryItem[], NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V7 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFGalleryItem[] arg1, NSError arg2)
			{
				var nsa_arg1 = arg1 == null ? null : NSArray.FromNSObjects (arg1);
				
				invoker (blockPtr, nsa_arg1 == null ? IntPtr.Zero : nsa_arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
				if (nsa_arg1 != null)
					nsa_arg1.Dispose ();
				
			}
		} /* class NIDActionArity2V7 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFErrorViewFormatterHandler (IntPtr block, IntPtr error, IntPtr outTitle, IntPtr outSubtitle);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFErrorViewFormatterHandler {
			static internal readonly DPSPDFErrorViewFormatterHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFErrorViewFormatterHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr error, IntPtr outTitle, IntPtr outSubtitle) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFErrorViewFormatterHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (error), NSString.FromHandle (outTitle), NSString.FromHandle (outSubtitle));
			}
		} /* class SDPSPDFErrorViewFormatterHandler */
		
		internal class NIDPSPDFErrorViewFormatterHandler {
			IntPtr blockPtr;
			DPSPDFErrorViewFormatterHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFErrorViewFormatterHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFErrorViewFormatterHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFErrorViewFormatterHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFErrorViewFormatterHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFErrorViewFormatterHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFErrorViewFormatterHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError error, string outTitle, string outSubtitle)
			{
				var nsoutTitle = NSString.CreateNative (outTitle);
				var nsoutSubtitle = NSString.CreateNative (outSubtitle);
				
				invoker (blockPtr, error == null ? IntPtr.Zero : error.Handle, nsoutTitle, nsoutSubtitle);
				NSString.ReleaseNative (nsoutTitle);
				NSString.ReleaseNative (nsoutSubtitle);
				
			}
		} /* class NIDPSPDFErrorViewFormatterHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFRemoteContentObjectAuthHandler (IntPtr block, IntPtr challenge, IntPtr dispHandler);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFRemoteContentObjectAuthHandler {
			static internal readonly DPSPDFRemoteContentObjectAuthHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFRemoteContentObjectAuthHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr challenge, IntPtr dispHandler) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFRemoteContentObjectAuthHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSUrlAuthenticationChallenge> (challenge), (PSPDFKit.PSPDFRemoteContentObjectDispositionHandler) Marshal.GetDelegateForFunctionPointer (dispHandler, typeof (PSPDFKit.PSPDFRemoteContentObjectDispositionHandler)));
			}
		} /* class SDPSPDFRemoteContentObjectAuthHandler */
		
		internal class NIDPSPDFRemoteContentObjectAuthHandler {
			IntPtr blockPtr;
			DPSPDFRemoteContentObjectAuthHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFRemoteContentObjectAuthHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFRemoteContentObjectAuthHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFRemoteContentObjectAuthHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFRemoteContentObjectAuthHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFRemoteContentObjectAuthHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFRemoteContentObjectAuthHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFRemoteContentObjectDispositionHandler))]global::PSPDFKit.PSPDFRemoteContentObjectDispositionHandler dispHandler)
			{
				BlockLiteral *block_ptr_dispHandler;
				BlockLiteral block_dispHandler;
				block_dispHandler = new BlockLiteral ();
				block_ptr_dispHandler = &block_dispHandler;
				block_dispHandler.SetupBlock (Trampolines.SDPSPDFRemoteContentObjectDispositionHandler.Handler, dispHandler);
				
				invoker (blockPtr, challenge == null ? IntPtr.Zero : challenge.Handle, (IntPtr) block_ptr_dispHandler);
				block_ptr_dispHandler->CleanupBlock ();
				
			}
		} /* class NIDPSPDFRemoteContentObjectAuthHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DPSPDFRemoteContentObjectTransformerHandler (IntPtr block, IntPtr location);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFRemoteContentObjectTransformerHandler {
			static internal readonly DPSPDFRemoteContentObjectTransformerHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFRemoteContentObjectTransformerHandler))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr location) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFRemoteContentObjectTransformerHandler) (descriptor->Target);
				Foundation.NSObject retval = del ( Runtime.GetNSObject<NSUrl> (location));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDPSPDFRemoteContentObjectTransformerHandler */
		
		internal class NIDPSPDFRemoteContentObjectTransformerHandler {
			IntPtr blockPtr;
			DPSPDFRemoteContentObjectTransformerHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFRemoteContentObjectTransformerHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFRemoteContentObjectTransformerHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFRemoteContentObjectTransformerHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFRemoteContentObjectTransformerHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFRemoteContentObjectTransformerHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFRemoteContentObjectTransformerHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe NSObject Invoke (NSUrl location)
			{
				var ret = Runtime.GetNSObject (invoker (blockPtr, location == null ? IntPtr.Zero : location.Handle));
				return ret;
			}
		} /* class NIDPSPDFRemoteContentObjectTransformerHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFRemoteContentObjectRemoteObjectHandler (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFRemoteContentObjectRemoteObjectHandler {
			static internal readonly DPSPDFRemoteContentObjectRemoteObjectHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFRemoteContentObjectRemoteObjectHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFRemoteContentObjectRemoteObjectHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFRemoteContentObject> (obj));
			}
		} /* class SDPSPDFRemoteContentObjectRemoteObjectHandler */
		
		internal class NIDPSPDFRemoteContentObjectRemoteObjectHandler {
			IntPtr blockPtr;
			DPSPDFRemoteContentObjectRemoteObjectHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFRemoteContentObjectRemoteObjectHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFRemoteContentObjectRemoteObjectHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFRemoteContentObjectRemoteObjectHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFRemoteContentObjectRemoteObjectHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFRemoteContentObjectRemoteObjectHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFRemoteContentObjectRemoteObjectHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFRemoteContentObject obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDPSPDFRemoteContentObjectRemoteObjectHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V8 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V8 {
			static internal readonly DActionArity1V8 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V8))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFAnnotationSetsCell>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFAnnotationSetsCell> (obj));
			}
		} /* class SDActionArity1V8 */
		
		internal class NIDActionArity1V8 {
			IntPtr blockPtr;
			DActionArity1V8 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V8 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V8> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V8 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFAnnotationSetsCell> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFAnnotationSetsCell>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V8 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFAnnotationSetsCell obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V8 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V9 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V9 {
			static internal readonly DActionArity1V9 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V9))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PSPDFKit.PSPDFButton>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PSPDFKit.PSPDFButton> (obj));
			}
		} /* class SDActionArity1V9 */
		
		internal class NIDActionArity1V9 {
			IntPtr blockPtr;
			DActionArity1V9 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V9 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V9> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V9 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PSPDFKit.PSPDFButton> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PSPDFKit.PSPDFButton>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V9 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PSPDFKit.PSPDFButton obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V9 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DPSPDFRemoteContentObjectDispositionHandler (IntPtr block, nint disposition, IntPtr credential);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPSPDFRemoteContentObjectDispositionHandler {
			static internal readonly DPSPDFRemoteContentObjectDispositionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPSPDFRemoteContentObjectDispositionHandler))]
			static unsafe void Invoke (IntPtr block, nint disposition, IntPtr credential) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PSPDFKit.PSPDFRemoteContentObjectDispositionHandler) (descriptor->Target);
				if (del != null)
					del ((NSUrlSessionAuthChallengeDisposition) (global::System.Int64) disposition,  Runtime.GetNSObject<NSUrlCredential> (credential));
			}
		} /* class SDPSPDFRemoteContentObjectDispositionHandler */
		
		internal class NIDPSPDFRemoteContentObjectDispositionHandler {
			IntPtr blockPtr;
			DPSPDFRemoteContentObjectDispositionHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPSPDFRemoteContentObjectDispositionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPSPDFRemoteContentObjectDispositionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPSPDFRemoteContentObjectDispositionHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PSPDFKit.PSPDFRemoteContentObjectDispositionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PSPDFKit.PSPDFRemoteContentObjectDispositionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPSPDFRemoteContentObjectDispositionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSUrlSessionAuthChallengeDisposition disposition, NSUrlCredential credential)
			{
				invoker (blockPtr, (nint) (Int64) disposition, credential == null ? IntPtr.Zero : credential.Handle);
			}
		} /* class NIDPSPDFRemoteContentObjectDispositionHandler */
	}
}
