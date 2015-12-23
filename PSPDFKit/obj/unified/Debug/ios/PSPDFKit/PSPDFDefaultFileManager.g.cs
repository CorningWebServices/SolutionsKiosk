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
	[Register("PSPDFDefaultFileManager", true)]
	public unsafe partial class PSPDFDefaultFileManager : NSObject, IPSPDFFileManager {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFDefaultFileManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFDefaultFileManager () : base (NSObjectFlag.Empty)
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
		protected PSPDFDefaultFileManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFDefaultFileManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("allowsPolicyEvent:")]
		[CompilerGenerated]
		public virtual bool AllowsPolicyEvent (string policyEvent)
		{
			if (policyEvent == null)
				throw new ArgumentNullException ("policyEvent");
			var nspolicyEvent = NSString.CreateNative (policyEvent);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("allowsPolicyEvent:"), nspolicyEvent);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("allowsPolicyEvent:"), nspolicyEvent);
			}
			NSString.ReleaseNative (nspolicyEvent);
			
			return ret;
		}
		
		[Export ("attributesOfFileSystemForPath:error:")]
		[CompilerGenerated]
		public virtual NSDictionary AttributesOfFileSystem (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("attributesOfFileSystemForPath:error:"), nspath, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("attributesOfFileSystemForPath:error:"), nspath, ref errorValue));
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("attributesOfItemAtPath:error:")]
		[CompilerGenerated]
		public virtual NSDictionary AttributesOfItem (string path, out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("attributesOfItemAtPath:error:"), nspath, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("attributesOfItemAtPath:error:"), nspath, ref errorValue));
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("cachesDirectory")]
		[CompilerGenerated]
		public virtual string CachesDirectory ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cachesDirectory")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cachesDirectory")));
			}
		}
		
		[Export ("cleanupIfTemporaryFile:")]
		[CompilerGenerated]
		public virtual bool CleanupIfTemporaryFile (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cleanupIfTemporaryFile:"), url.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cleanupIfTemporaryFile:"), url.Handle);
			}
		}
		
		[Export ("contentsOfDirectoryAtPath:error:")]
		[CompilerGenerated]
		public virtual NSObject[] ContentsOfDirectory (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("contentsOfDirectoryAtPath:error:"), nspath, ref errorValue));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("contentsOfDirectoryAtPath:error:"), nspath, ref errorValue));
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("copyFileToUnencryptedLocationIfRequired:policyEvent:error:")]
		[CompilerGenerated]
		public virtual NSUrl CopyFileToUnencryptedLocationIfRequired (NSUrl fileUrl, string policyEvent, out NSError error)
		{
			if (policyEvent == null)
				throw new ArgumentNullException ("policyEvent");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspolicyEvent = NSString.CreateNative (policyEvent);
			
			NSUrl ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("copyFileToUnencryptedLocationIfRequired:policyEvent:error:"), fileUrl == null ? IntPtr.Zero : fileUrl.Handle, nspolicyEvent, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("copyFileToUnencryptedLocationIfRequired:policyEvent:error:"), fileUrl == null ? IntPtr.Zero : fileUrl.Handle, nspolicyEvent, ref errorValue));
			}
			NSString.ReleaseNative (nspolicyEvent);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("copyItemAtURL:toURL:error:")]
		[CompilerGenerated]
		public virtual bool CopyItem (NSUrl srcUrl, NSUrl dstUrl, out NSError error)
		{
			if (srcUrl == null)
				throw new ArgumentNullException ("srcUrl");
			if (dstUrl == null)
				throw new ArgumentNullException ("dstUrl");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("copyItemAtURL:toURL:error:"), srcUrl.Handle, dstUrl.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("copyItemAtURL:toURL:error:"), srcUrl.Handle, dstUrl.Handle, ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:")]
		[CompilerGenerated]
		public virtual bool CreateDirectory (string path, bool createIntermediates, NSDictionary attributes, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:"), nspath, createIntermediates, attributes == null ? IntPtr.Zero : attributes.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:"), nspath, createIntermediates, attributes == null ? IntPtr.Zero : attributes.Handle, ref errorValue);
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("createFileAtPath:contents:attributes:")]
		[CompilerGenerated]
		public virtual bool CreateFile (string path, NSData data, NSDictionary attr)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("createFileAtPath:contents:attributes:"), nspath, data == null ? IntPtr.Zero : data.Handle, attr == null ? IntPtr.Zero : attr.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("createFileAtPath:contents:attributes:"), nspath, data == null ? IntPtr.Zero : data.Handle, attr == null ? IntPtr.Zero : attr.Handle);
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("dataWithContentsOfFile:options:error:")]
		[CompilerGenerated]
		public virtual NSData DataWithContentsOfFile (string path, NSDataReadingOptions readOptionsMask, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSData ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr (this.Handle, Selector.GetHandle ("dataWithContentsOfFile:options:error:"), nspath, (UInt64)readOptionsMask, ref errorValue));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_ref_IntPtr (this.Handle, Selector.GetHandle ("dataWithContentsOfFile:options:error:"), nspath, (UInt32)readOptionsMask, ref errorValue));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("dataWithContentsOfFile:options:error:"), nspath, (UInt64)readOptionsMask, ref errorValue));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("dataWithContentsOfFile:options:error:"), nspath, (UInt32)readOptionsMask, ref errorValue));
				}
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("destinationOfSymbolicLinkAtPath:error:")]
		[CompilerGenerated]
		public virtual string DestinationOfSymbolicLink (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("destinationOfSymbolicLinkAtPath:error:"), nspath, ref errorValue));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("destinationOfSymbolicLinkAtPath:error:"), nspath, ref errorValue));
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("documentDirectory")]
		[CompilerGenerated]
		public virtual string DocumentDirectory ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentDirectory")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("documentDirectory")));
			}
		}
		
		[Export ("enumeratorAtPath:")]
		[CompilerGenerated]
		public virtual NSDirectoryEnumerator EnumeratorAtPath (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			NSDirectoryEnumerator ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("enumeratorAtPath:"), nspath));
			} else {
				ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("enumeratorAtPath:"), nspath));
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:")]
		[CompilerGenerated]
		public unsafe virtual NSDirectoryEnumerator EnumeratorAtUrl (NSUrl url, NSObject[] keys, NSDirectoryEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFFileManagerErrorHandler))]PSPDFFileManagerErrorHandler handler)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (keys == null)
				throw new ArgumentNullException ("keys");
			var nsa_keys = NSArray.FromNSObjects (keys);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlock (Trampolines.SDPSPDFFileManagerErrorHandler.Handler, handler);
			}
			
			NSDirectoryEnumerator ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr (this.Handle, Selector.GetHandle ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:"), url.Handle, nsa_keys.Handle, (UInt64)options, (IntPtr) block_ptr_handler));
				} else {
					ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:"), url.Handle, nsa_keys.Handle, (UInt32)options, (IntPtr) block_ptr_handler));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr (this.SuperHandle, Selector.GetHandle ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:"), url.Handle, nsa_keys.Handle, (UInt64)options, (IntPtr) block_ptr_handler));
				} else {
					ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:"), url.Handle, nsa_keys.Handle, (UInt32)options, (IntPtr) block_ptr_handler));
				}
			}
			nsa_keys.Dispose ();
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("fileExistsAtPath:")]
		[CompilerGenerated]
		public virtual bool FileExists (string path)
		{
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileExistsAtPath:"), nspath);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("fileExistsAtPath:"), nspath);
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("fileExistsAtURL:")]
		[CompilerGenerated]
		public virtual bool FileExists (NSUrl url)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileExistsAtURL:"), url == null ? IntPtr.Zero : url.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("fileExistsAtURL:"), url == null ? IntPtr.Zero : url.Handle);
			}
		}
		
		[Export ("fileExistsAtURL:isDirectory:")]
		[CompilerGenerated]
		public virtual bool FileExists (NSUrl url, bool isDirectory)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("fileExistsAtURL:isDirectory:"), url == null ? IntPtr.Zero : url.Handle, isDirectory);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("fileExistsAtURL:isDirectory:"), url == null ? IntPtr.Zero : url.Handle, isDirectory);
			}
		}
		
		[Export ("fileExistsAtPath:isDirectory:")]
		[CompilerGenerated]
		public virtual bool FileExistsh (string path, bool isDirectory)
		{
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("fileExistsAtPath:isDirectory:"), nspath, isDirectory);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("fileExistsAtPath:isDirectory:"), nspath, isDirectory);
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("fileHandleForReadingFromURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe virtual bool FileHandleForReading (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> reader)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (reader == null)
				throw new ArgumentNullException ("reader");
			IntPtr errorValue = IntPtr.Zero;
			
			BlockLiteral *block_ptr_reader;
			BlockLiteral block_reader;
			block_reader = new BlockLiteral ();
			block_ptr_reader = &block_reader;
			block_reader.SetupBlock (Trampolines.SDFuncArity2V3.Handler, reader);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("fileHandleForReadingFromURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_reader);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("fileHandleForReadingFromURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_reader);
			}
			block_ptr_reader->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("fileHandleForUpdatingURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe virtual bool FileHandleForUpdating (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> updater)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (updater == null)
				throw new ArgumentNullException ("updater");
			IntPtr errorValue = IntPtr.Zero;
			
			BlockLiteral *block_ptr_updater;
			BlockLiteral block_updater;
			block_updater = new BlockLiteral ();
			block_ptr_updater = &block_updater;
			block_updater.SetupBlock (Trampolines.SDFuncArity2V3.Handler, updater);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("fileHandleForUpdatingURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_updater);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("fileHandleForUpdatingURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_updater);
			}
			block_ptr_updater->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("fileHandleForWritingToURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe virtual bool FileHandleForWriting (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> writer)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (writer == null)
				throw new ArgumentNullException ("writer");
			IntPtr errorValue = IntPtr.Zero;
			
			BlockLiteral *block_ptr_writer;
			BlockLiteral block_writer;
			block_writer = new BlockLiteral ();
			block_ptr_writer = &block_writer;
			block_writer.SetupBlock (Trampolines.SDFuncArity2V3.Handler, writer);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("fileHandleForWritingToURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_writer);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("fileHandleForWritingToURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_writer);
			}
			block_ptr_writer->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("fileSystemRepresentationForPath:")]
		[CompilerGenerated]
		public virtual global::System.SByte FileSystemRepresentation (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			global::System.SByte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.SByte_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileSystemRepresentationForPath:"), nspath);
			} else {
				ret = global::ApiDefinition.Messaging.SByte_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("fileSystemRepresentationForPath:"), nspath);
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("isDeletableFileAtPath:")]
		[CompilerGenerated]
		public virtual bool IsDeletableFile (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isDeletableFileAtPath:"), nspath);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isDeletableFileAtPath:"), nspath);
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("isNativePath:")]
		[CompilerGenerated]
		public virtual bool IsNativePath (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isNativePath:"), nspath);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isNativePath:"), nspath);
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("isWritableFileAtPath:")]
		[CompilerGenerated]
		public virtual bool IsWritableFile (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isWritableFileAtPath:"), nspath);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isWritableFileAtPath:"), nspath);
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("libraryDirectory")]
		[CompilerGenerated]
		public virtual string LibraryDirectory ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("libraryDirectory")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("libraryDirectory")));
			}
		}
		
		[Export ("moveItemAtURL:toURL:error:")]
		[CompilerGenerated]
		public virtual bool MoveItem (NSUrl srcUrl, NSUrl dstUrl, out NSError error)
		{
			if (srcUrl == null)
				throw new ArgumentNullException ("srcUrl");
			if (dstUrl == null)
				throw new ArgumentNullException ("dstUrl");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("moveItemAtURL:toURL:error:"), srcUrl.Handle, dstUrl.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("moveItemAtURL:toURL:error:"), srcUrl.Handle, dstUrl.Handle, ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("removeItemAtPath:error:")]
		[CompilerGenerated]
		public virtual bool RemoveItem (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("removeItemAtPath:error:"), nspath, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("removeItemAtPath:error:"), nspath, ref errorValue);
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("removeItemAtURL:error:")]
		[CompilerGenerated]
		public virtual bool RemoveItem (NSUrl Url, out NSError error)
		{
			if (Url == null)
				throw new ArgumentNullException ("Url");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("removeItemAtURL:error:"), Url.Handle, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("removeItemAtURL:error:"), Url.Handle, ref errorValue);
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("subpathsOfDirectoryAtPath:error:")]
		[CompilerGenerated]
		public virtual NSObject[] SubpathsOfDirectory (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("subpathsOfDirectoryAtPath:error:"), nspath, ref errorValue));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("subpathsOfDirectoryAtPath:error:"), nspath, ref errorValue));
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("temporaryDirectoryWithUID:")]
		[CompilerGenerated]
		public virtual string TemporaryDirectory (string uid)
		{
			var nsuid = NSString.CreateNative (uid);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("temporaryDirectoryWithUID:"), nsuid));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("temporaryDirectoryWithUID:"), nsuid));
			}
			NSString.ReleaseNative (nsuid);
			
			return ret;
		}
		
		[Export ("unencryptedTemporaryDirectoryWithUID:")]
		[CompilerGenerated]
		public virtual string UnencryptedTemporaryDirectory (string uid)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			var nsuid = NSString.CreateNative (uid);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unencryptedTemporaryDirectoryWithUID:"), nsuid));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("unencryptedTemporaryDirectoryWithUID:"), nsuid));
			}
			NSString.ReleaseNative (nsuid);
			
			return ret;
		}
		
		[Export ("usesEncryption")]
		[CompilerGenerated]
		public virtual bool UsesEncryption ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesEncryption"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("usesEncryption"));
			}
		}
		
		[Export ("writeData:toFile:options:error:")]
		[CompilerGenerated]
		public virtual bool WriteData (NSData data, string path, NSDataWritingOptions writeOptionsMask, out NSError error)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr (this.Handle, Selector.GetHandle ("writeData:toFile:options:error:"), data.Handle, nspath, (UInt64)writeOptionsMask, ref errorValue);
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt32_ref_IntPtr (this.Handle, Selector.GetHandle ("writeData:toFile:options:error:"), data.Handle, nspath, (UInt32)writeOptionsMask, ref errorValue);
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("writeData:toFile:options:error:"), data.Handle, nspath, (UInt64)writeOptionsMask, ref errorValue);
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt32_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("writeData:toFile:options:error:"), data.Handle, nspath, (UInt32)writeOptionsMask, ref errorValue);
				}
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
	} /* class PSPDFDefaultFileManager */
}
