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
	[Protocol (Name = "PSPDFFileManager", WrapperType = typeof (PSPDFFileManagerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UsesEncryption", Selector = "usesEncryption", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AllowsPolicyEvent", Selector = "allowsPolicyEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFileToUnencryptedLocationIfRequired", Selector = "copyFileToUnencryptedLocationIfRequired:policyEvent:error:", ReturnType = typeof (NSUrl), ParameterType = new Type [] { typeof (NSUrl), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CleanupIfTemporaryFile", Selector = "cleanupIfTemporaryFile:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LibraryDirectory", Selector = "libraryDirectory", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CachesDirectory", Selector = "cachesDirectory", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DocumentDirectory", Selector = "documentDirectory", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TemporaryDirectory", Selector = "temporaryDirectoryWithUID:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnencryptedTemporaryDirectory", Selector = "unencryptedTemporaryDirectoryWithUID:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsNativePath", Selector = "isNativePath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileExists", Selector = "fileExistsAtPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileExistsh", Selector = "fileExistsAtPath:isDirectory:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileExists", Selector = "fileExistsAtURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileExists", Selector = "fileExistsAtURL:isDirectory:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFile", Selector = "createFileAtPath:contents:attributes:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSData), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDirectory", Selector = "createDirectoryAtPath:withIntermediateDirectories:attributes:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (bool), typeof (NSDictionary), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteData", Selector = "writeData:toFile:options:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSData), typeof (string), typeof (NSDataWritingOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DataWithContentsOfFile", Selector = "dataWithContentsOfFile:options:error:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (string), typeof (NSDataReadingOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyItem", Selector = "copyItemAtURL:toURL:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MoveItem", Selector = "moveItemAtURL:toURL:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveItem", Selector = "removeItemAtPath:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveItem", Selector = "removeItemAtURL:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AttributesOfFileSystem", Selector = "attributesOfFileSystemForPath:error:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AttributesOfItem", Selector = "attributesOfItemAtPath:error:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsDeletableFile", Selector = "isDeletableFileAtPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsWritableFile", Selector = "isWritableFileAtPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ContentsOfDirectory", Selector = "contentsOfDirectoryAtPath:error:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SubpathsOfDirectory", Selector = "subpathsOfDirectoryAtPath:error:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumeratorAtPath", Selector = "enumeratorAtPath:", ReturnType = typeof (NSDirectoryEnumerator), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumeratorAtUrl", Selector = "enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:", ReturnType = typeof (NSDirectoryEnumerator), ParameterType = new Type [] { typeof (NSUrl), typeof (NSObject[]), typeof (NSDirectoryEnumerationOptions), typeof (PSPDFKit.PSPDFFileManagerErrorHandler) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DestinationOfSymbolicLink", Selector = "destinationOfSymbolicLinkAtPath:error:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileSystemRepresentation", Selector = "fileSystemRepresentationForPath:", ReturnType = typeof (sbyte), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileHandleForReading", Selector = "fileHandleForReadingFromURL:error:withBlock:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError), typeof (Func<NSFileHandle, bool>) }, ParameterByRef = new bool [] { false, true, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileHandleForWriting", Selector = "fileHandleForWritingToURL:error:withBlock:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError), typeof (Func<NSFileHandle, bool>) }, ParameterByRef = new bool [] { false, true, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileHandleForUpdating", Selector = "fileHandleForUpdatingURL:error:withBlock:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError), typeof (Func<NSFileHandle, bool>) }, ParameterByRef = new bool [] { false, true, false })]
	public interface IPSPDFFileManager : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("usesEncryption")]
		[Preserve (Conditional = true)]
		bool UsesEncryption ();
		
		[CompilerGenerated]
		[Export ("allowsPolicyEvent:")]
		[Preserve (Conditional = true)]
		bool AllowsPolicyEvent (string policyEvent);
		
		[CompilerGenerated]
		[Export ("copyFileToUnencryptedLocationIfRequired:policyEvent:error:")]
		[Preserve (Conditional = true)]
		NSUrl CopyFileToUnencryptedLocationIfRequired (NSUrl fileUrl, string policyEvent, out NSError error);
		
		[CompilerGenerated]
		[Export ("cleanupIfTemporaryFile:")]
		[Preserve (Conditional = true)]
		bool CleanupIfTemporaryFile (NSUrl url);
		
		[CompilerGenerated]
		[Export ("libraryDirectory")]
		[Preserve (Conditional = true)]
		string LibraryDirectory ();
		
		[CompilerGenerated]
		[Export ("cachesDirectory")]
		[Preserve (Conditional = true)]
		string CachesDirectory ();
		
		[CompilerGenerated]
		[Export ("documentDirectory")]
		[Preserve (Conditional = true)]
		string DocumentDirectory ();
		
		[CompilerGenerated]
		[Export ("temporaryDirectoryWithUID:")]
		[Preserve (Conditional = true)]
		string TemporaryDirectory (string uid);
		
		[CompilerGenerated]
		[Export ("unencryptedTemporaryDirectoryWithUID:")]
		[Preserve (Conditional = true)]
		string UnencryptedTemporaryDirectory (string uid);
		
		[CompilerGenerated]
		[Export ("isNativePath:")]
		[Preserve (Conditional = true)]
		bool IsNativePath (string path);
		
		[CompilerGenerated]
		[Export ("fileExistsAtPath:")]
		[Preserve (Conditional = true)]
		bool FileExists (string path);
		
		[CompilerGenerated]
		[Export ("fileExistsAtPath:isDirectory:")]
		[Preserve (Conditional = true)]
		bool FileExistsh (string path, bool isDirectory);
		
		[CompilerGenerated]
		[Export ("fileExistsAtURL:")]
		[Preserve (Conditional = true)]
		bool FileExists (NSUrl url);
		
		[CompilerGenerated]
		[Export ("fileExistsAtURL:isDirectory:")]
		[Preserve (Conditional = true)]
		bool FileExists (NSUrl url, bool isDirectory);
		
		[CompilerGenerated]
		[Export ("createFileAtPath:contents:attributes:")]
		[Preserve (Conditional = true)]
		bool CreateFile (string path, NSData data, NSDictionary attr);
		
		[CompilerGenerated]
		[Export ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:")]
		[Preserve (Conditional = true)]
		bool CreateDirectory (string path, bool createIntermediates, NSDictionary attributes, out NSError error);
		
		[CompilerGenerated]
		[Export ("writeData:toFile:options:error:")]
		[Preserve (Conditional = true)]
		bool WriteData (NSData data, string path, NSDataWritingOptions writeOptionsMask, out NSError error);
		
		[CompilerGenerated]
		[Export ("dataWithContentsOfFile:options:error:")]
		[Preserve (Conditional = true)]
		NSData DataWithContentsOfFile (string path, NSDataReadingOptions readOptionsMask, out NSError error);
		
		[CompilerGenerated]
		[Export ("copyItemAtURL:toURL:error:")]
		[Preserve (Conditional = true)]
		bool CopyItem (NSUrl srcUrl, NSUrl dstUrl, out NSError error);
		
		[CompilerGenerated]
		[Export ("moveItemAtURL:toURL:error:")]
		[Preserve (Conditional = true)]
		bool MoveItem (NSUrl srcUrl, NSUrl dstUrl, out NSError error);
		
		[CompilerGenerated]
		[Export ("removeItemAtPath:error:")]
		[Preserve (Conditional = true)]
		bool RemoveItem (string path, out NSError error);
		
		[CompilerGenerated]
		[Export ("removeItemAtURL:error:")]
		[Preserve (Conditional = true)]
		bool RemoveItem (NSUrl Url, out NSError error);
		
		[CompilerGenerated]
		[Export ("attributesOfFileSystemForPath:error:")]
		[Preserve (Conditional = true)]
		NSDictionary AttributesOfFileSystem (string path, out NSError error);
		
		[CompilerGenerated]
		[Export ("attributesOfItemAtPath:error:")]
		[Preserve (Conditional = true)]
		NSDictionary AttributesOfItem (string path, out NSError error);
		
		[CompilerGenerated]
		[Export ("isDeletableFileAtPath:")]
		[Preserve (Conditional = true)]
		bool IsDeletableFile (string path);
		
		[CompilerGenerated]
		[Export ("isWritableFileAtPath:")]
		[Preserve (Conditional = true)]
		bool IsWritableFile (string path);
		
		[CompilerGenerated]
		[Export ("contentsOfDirectoryAtPath:error:")]
		[Preserve (Conditional = true)]
		NSObject[] ContentsOfDirectory (string path, out NSError error);
		
		[CompilerGenerated]
		[Export ("subpathsOfDirectoryAtPath:error:")]
		[Preserve (Conditional = true)]
		NSObject[] SubpathsOfDirectory (string path, out NSError error);
		
		[CompilerGenerated]
		[Export ("enumeratorAtPath:")]
		[Preserve (Conditional = true)]
		NSDirectoryEnumerator EnumeratorAtPath (string path);
		
		[CompilerGenerated]
		[Export ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:")]
		[Preserve (Conditional = true)]
		unsafe NSDirectoryEnumerator EnumeratorAtUrl (NSUrl url, NSObject[] keys, NSDirectoryEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFFileManagerErrorHandler))]PSPDFFileManagerErrorHandler handler);
		
		[CompilerGenerated]
		[Export ("destinationOfSymbolicLinkAtPath:error:")]
		[Preserve (Conditional = true)]
		string DestinationOfSymbolicLink (string path, out NSError error);
		
		[CompilerGenerated]
		[Export ("fileSystemRepresentationForPath:")]
		[Preserve (Conditional = true)]
		global::System.SByte FileSystemRepresentation (string path);
		
		[CompilerGenerated]
		[Export ("fileHandleForReadingFromURL:error:withBlock:")]
		[Preserve (Conditional = true)]
		unsafe bool FileHandleForReading (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> reader);
		
		[CompilerGenerated]
		[Export ("fileHandleForWritingToURL:error:withBlock:")]
		[Preserve (Conditional = true)]
		unsafe bool FileHandleForWriting (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> writer);
		
		[CompilerGenerated]
		[Export ("fileHandleForUpdatingURL:error:withBlock:")]
		[Preserve (Conditional = true)]
		unsafe bool FileHandleForUpdating (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> updater);
		
	}
	
	internal sealed class PSPDFFileManagerWrapper : BaseWrapper, IPSPDFFileManager {
		public PSPDFFileManagerWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PSPDFFileManagerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("usesEncryption")]
		[CompilerGenerated]
		public bool UsesEncryption ()
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesEncryption"));
		}
		
		[Export ("allowsPolicyEvent:")]
		[CompilerGenerated]
		public bool AllowsPolicyEvent (string policyEvent)
		{
			if (policyEvent == null)
				throw new ArgumentNullException ("policyEvent");
			var nspolicyEvent = NSString.CreateNative (policyEvent);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("allowsPolicyEvent:"), nspolicyEvent);
			NSString.ReleaseNative (nspolicyEvent);
			
			return ret;
		}
		
		[Export ("copyFileToUnencryptedLocationIfRequired:policyEvent:error:")]
		[CompilerGenerated]
		public NSUrl CopyFileToUnencryptedLocationIfRequired (NSUrl fileUrl, string policyEvent, out NSError error)
		{
			if (policyEvent == null)
				throw new ArgumentNullException ("policyEvent");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspolicyEvent = NSString.CreateNative (policyEvent);
			
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("copyFileToUnencryptedLocationIfRequired:policyEvent:error:"), fileUrl == null ? IntPtr.Zero : fileUrl.Handle, nspolicyEvent, ref errorValue));
			NSString.ReleaseNative (nspolicyEvent);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("cleanupIfTemporaryFile:")]
		[CompilerGenerated]
		public bool CleanupIfTemporaryFile (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cleanupIfTemporaryFile:"), url.Handle);
		}
		
		[Export ("libraryDirectory")]
		[CompilerGenerated]
		public string LibraryDirectory ()
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("libraryDirectory")));
		}
		
		[Export ("cachesDirectory")]
		[CompilerGenerated]
		public string CachesDirectory ()
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cachesDirectory")));
		}
		
		[Export ("documentDirectory")]
		[CompilerGenerated]
		public string DocumentDirectory ()
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("documentDirectory")));
		}
		
		[Export ("temporaryDirectoryWithUID:")]
		[CompilerGenerated]
		public string TemporaryDirectory (string uid)
		{
			var nsuid = NSString.CreateNative (uid);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("temporaryDirectoryWithUID:"), nsuid));
			NSString.ReleaseNative (nsuid);
			
			return ret;
		}
		
		[Export ("unencryptedTemporaryDirectoryWithUID:")]
		[CompilerGenerated]
		public string UnencryptedTemporaryDirectory (string uid)
		{
			if (uid == null)
				throw new ArgumentNullException ("uid");
			var nsuid = NSString.CreateNative (uid);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unencryptedTemporaryDirectoryWithUID:"), nsuid));
			NSString.ReleaseNative (nsuid);
			
			return ret;
		}
		
		[Export ("isNativePath:")]
		[CompilerGenerated]
		public bool IsNativePath (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isNativePath:"), nspath);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("fileExistsAtPath:")]
		[CompilerGenerated]
		public bool FileExists (string path)
		{
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileExistsAtPath:"), nspath);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("fileExistsAtPath:isDirectory:")]
		[CompilerGenerated]
		public bool FileExistsh (string path, bool isDirectory)
		{
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("fileExistsAtPath:isDirectory:"), nspath, isDirectory);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("fileExistsAtURL:")]
		[CompilerGenerated]
		public bool FileExists (NSUrl url)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileExistsAtURL:"), url == null ? IntPtr.Zero : url.Handle);
		}
		
		[Export ("fileExistsAtURL:isDirectory:")]
		[CompilerGenerated]
		public bool FileExists (NSUrl url, bool isDirectory)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("fileExistsAtURL:isDirectory:"), url == null ? IntPtr.Zero : url.Handle, isDirectory);
		}
		
		[Export ("createFileAtPath:contents:attributes:")]
		[CompilerGenerated]
		public bool CreateFile (string path, NSData data, NSDictionary attr)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("createFileAtPath:contents:attributes:"), nspath, data == null ? IntPtr.Zero : data.Handle, attr == null ? IntPtr.Zero : attr.Handle);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:")]
		[CompilerGenerated]
		public bool CreateDirectory (string path, bool createIntermediates, NSDictionary attributes, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:"), nspath, createIntermediates, attributes == null ? IntPtr.Zero : attributes.Handle, ref errorValue);
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("writeData:toFile:options:error:")]
		[CompilerGenerated]
		public bool WriteData (NSData data, string path, NSDataWritingOptions writeOptionsMask, out NSError error)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr (this.Handle, Selector.GetHandle ("writeData:toFile:options:error:"), data.Handle, nspath, (UInt64)writeOptionsMask, ref errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt32_ref_IntPtr (this.Handle, Selector.GetHandle ("writeData:toFile:options:error:"), data.Handle, nspath, (UInt32)writeOptionsMask, ref errorValue);
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("dataWithContentsOfFile:options:error:")]
		[CompilerGenerated]
		public NSData DataWithContentsOfFile (string path, NSDataReadingOptions readOptionsMask, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSData ret;
			if (IntPtr.Size == 8) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr (this.Handle, Selector.GetHandle ("dataWithContentsOfFile:options:error:"), nspath, (UInt64)readOptionsMask, ref errorValue));
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_ref_IntPtr (this.Handle, Selector.GetHandle ("dataWithContentsOfFile:options:error:"), nspath, (UInt32)readOptionsMask, ref errorValue));
			}
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("copyItemAtURL:toURL:error:")]
		[CompilerGenerated]
		public bool CopyItem (NSUrl srcUrl, NSUrl dstUrl, out NSError error)
		{
			if (srcUrl == null)
				throw new ArgumentNullException ("srcUrl");
			if (dstUrl == null)
				throw new ArgumentNullException ("dstUrl");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("copyItemAtURL:toURL:error:"), srcUrl.Handle, dstUrl.Handle, ref errorValue);
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("moveItemAtURL:toURL:error:")]
		[CompilerGenerated]
		public bool MoveItem (NSUrl srcUrl, NSUrl dstUrl, out NSError error)
		{
			if (srcUrl == null)
				throw new ArgumentNullException ("srcUrl");
			if (dstUrl == null)
				throw new ArgumentNullException ("dstUrl");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("moveItemAtURL:toURL:error:"), srcUrl.Handle, dstUrl.Handle, ref errorValue);
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("removeItemAtPath:error:")]
		[CompilerGenerated]
		public bool RemoveItem (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("removeItemAtPath:error:"), nspath, ref errorValue);
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("removeItemAtURL:error:")]
		[CompilerGenerated]
		public bool RemoveItem (NSUrl Url, out NSError error)
		{
			if (Url == null)
				throw new ArgumentNullException ("Url");
			IntPtr errorValue = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("removeItemAtURL:error:"), Url.Handle, ref errorValue);
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("attributesOfFileSystemForPath:error:")]
		[CompilerGenerated]
		public NSDictionary AttributesOfFileSystem (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("attributesOfFileSystemForPath:error:"), nspath, ref errorValue));
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("attributesOfItemAtPath:error:")]
		[CompilerGenerated]
		public NSDictionary AttributesOfItem (string path, out NSError error)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("attributesOfItemAtPath:error:"), nspath, ref errorValue));
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("isDeletableFileAtPath:")]
		[CompilerGenerated]
		public bool IsDeletableFile (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isDeletableFileAtPath:"), nspath);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("isWritableFileAtPath:")]
		[CompilerGenerated]
		public bool IsWritableFile (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isWritableFileAtPath:"), nspath);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("contentsOfDirectoryAtPath:error:")]
		[CompilerGenerated]
		public NSObject[] ContentsOfDirectory (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSObject[] ret;
			ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("contentsOfDirectoryAtPath:error:"), nspath, ref errorValue));
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("subpathsOfDirectoryAtPath:error:")]
		[CompilerGenerated]
		public NSObject[] SubpathsOfDirectory (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			NSObject[] ret;
			ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("subpathsOfDirectoryAtPath:error:"), nspath, ref errorValue));
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("enumeratorAtPath:")]
		[CompilerGenerated]
		public NSDirectoryEnumerator EnumeratorAtPath (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			NSDirectoryEnumerator ret;
			ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("enumeratorAtPath:"), nspath));
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:")]
		[CompilerGenerated]
		public unsafe NSDirectoryEnumerator EnumeratorAtUrl (NSUrl url, NSObject[] keys, NSDirectoryEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFFileManagerErrorHandler))]PSPDFFileManagerErrorHandler handler)
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
			if (IntPtr.Size == 8) {
				ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr (this.Handle, Selector.GetHandle ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:"), url.Handle, nsa_keys.Handle, (UInt64)options, (IntPtr) block_ptr_handler));
			} else {
				ret =  Runtime.GetNSObject<NSDirectoryEnumerator> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:"), url.Handle, nsa_keys.Handle, (UInt32)options, (IntPtr) block_ptr_handler));
			}
			nsa_keys.Dispose ();
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("destinationOfSymbolicLinkAtPath:error:")]
		[CompilerGenerated]
		public string DestinationOfSymbolicLink (string path, out NSError error)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			IntPtr errorValue = IntPtr.Zero;
			
			var nspath = NSString.CreateNative (path);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("destinationOfSymbolicLinkAtPath:error:"), nspath, ref errorValue));
			NSString.ReleaseNative (nspath);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("fileSystemRepresentationForPath:")]
		[CompilerGenerated]
		public global::System.SByte FileSystemRepresentation (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			global::System.SByte ret;
			ret = global::ApiDefinition.Messaging.SByte_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileSystemRepresentationForPath:"), nspath);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("fileHandleForReadingFromURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe bool FileHandleForReading (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> reader)
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
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("fileHandleForReadingFromURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_reader);
			block_ptr_reader->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("fileHandleForWritingToURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe bool FileHandleForWriting (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> writer)
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
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("fileHandleForWritingToURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_writer);
			block_ptr_writer->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
		[Export ("fileHandleForUpdatingURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe bool FileHandleForUpdating (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> updater)
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
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("fileHandleForUpdatingURL:error:withBlock:"), url.Handle, ref errorValue, (IntPtr) block_ptr_updater);
			block_ptr_updater->CleanupBlock ();
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			return ret;
		}
		
	}
}
namespace PSPDFKit {
	[Protocol]
	[Register("PSPDFFileManager", false)]
	[Model]
	public unsafe abstract partial class PSPDFFileManager : NSObject, IPSPDFFileManager {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PSPDFFileManager () : base (NSObjectFlag.Empty)
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
		protected PSPDFFileManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFFileManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("allowsPolicyEvent:")]
		[CompilerGenerated]
		public abstract bool AllowsPolicyEvent (string policyEvent);
		[Export ("attributesOfFileSystemForPath:error:")]
		[CompilerGenerated]
		public abstract NSDictionary AttributesOfFileSystem (string path, out NSError error);
		[Export ("attributesOfItemAtPath:error:")]
		[CompilerGenerated]
		public abstract NSDictionary AttributesOfItem (string path, out NSError error);
		[Export ("cachesDirectory")]
		[CompilerGenerated]
		public abstract string CachesDirectory ();
		[Export ("cleanupIfTemporaryFile:")]
		[CompilerGenerated]
		public abstract bool CleanupIfTemporaryFile (NSUrl url);
		[Export ("contentsOfDirectoryAtPath:error:")]
		[CompilerGenerated]
		public abstract NSObject[] ContentsOfDirectory (string path, out NSError error);
		[Export ("copyFileToUnencryptedLocationIfRequired:policyEvent:error:")]
		[CompilerGenerated]
		public abstract NSUrl CopyFileToUnencryptedLocationIfRequired (NSUrl fileUrl, string policyEvent, out NSError error);
		[Export ("copyItemAtURL:toURL:error:")]
		[CompilerGenerated]
		public abstract bool CopyItem (NSUrl srcUrl, NSUrl dstUrl, out NSError error);
		[Export ("createDirectoryAtPath:withIntermediateDirectories:attributes:error:")]
		[CompilerGenerated]
		public abstract bool CreateDirectory (string path, bool createIntermediates, NSDictionary attributes, out NSError error);
		[Export ("createFileAtPath:contents:attributes:")]
		[CompilerGenerated]
		public abstract bool CreateFile (string path, NSData data, NSDictionary attr);
		[Export ("dataWithContentsOfFile:options:error:")]
		[CompilerGenerated]
		public abstract NSData DataWithContentsOfFile (string path, NSDataReadingOptions readOptionsMask, out NSError error);
		[Export ("destinationOfSymbolicLinkAtPath:error:")]
		[CompilerGenerated]
		public abstract string DestinationOfSymbolicLink (string path, out NSError error);
		[Export ("documentDirectory")]
		[CompilerGenerated]
		public abstract string DocumentDirectory ();
		[Export ("enumeratorAtPath:")]
		[CompilerGenerated]
		public abstract NSDirectoryEnumerator EnumeratorAtPath (string path);
		[Export ("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:")]
		[CompilerGenerated]
		public unsafe abstract NSDirectoryEnumerator EnumeratorAtUrl (NSUrl url, NSObject[] keys, NSDirectoryEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPSPDFFileManagerErrorHandler))]PSPDFFileManagerErrorHandler handler);
		[Export ("fileExistsAtPath:")]
		[CompilerGenerated]
		public abstract bool FileExists (string path);
		[Export ("fileExistsAtURL:")]
		[CompilerGenerated]
		public abstract bool FileExists (NSUrl url);
		[Export ("fileExistsAtURL:isDirectory:")]
		[CompilerGenerated]
		public abstract bool FileExists (NSUrl url, bool isDirectory);
		[Export ("fileExistsAtPath:isDirectory:")]
		[CompilerGenerated]
		public abstract bool FileExistsh (string path, bool isDirectory);
		[Export ("fileHandleForReadingFromURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe abstract bool FileHandleForReading (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> reader);
		[Export ("fileHandleForUpdatingURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe abstract bool FileHandleForUpdating (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> updater);
		[Export ("fileHandleForWritingToURL:error:withBlock:")]
		[CompilerGenerated]
		public unsafe abstract bool FileHandleForWriting (NSUrl url, out NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSFileHandle, bool> writer);
		[Export ("fileSystemRepresentationForPath:")]
		[CompilerGenerated]
		public abstract global::System.SByte FileSystemRepresentation (string path);
		[Export ("isDeletableFileAtPath:")]
		[CompilerGenerated]
		public abstract bool IsDeletableFile (string path);
		[Export ("isNativePath:")]
		[CompilerGenerated]
		public abstract bool IsNativePath (string path);
		[Export ("isWritableFileAtPath:")]
		[CompilerGenerated]
		public abstract bool IsWritableFile (string path);
		[Export ("libraryDirectory")]
		[CompilerGenerated]
		public abstract string LibraryDirectory ();
		[Export ("moveItemAtURL:toURL:error:")]
		[CompilerGenerated]
		public abstract bool MoveItem (NSUrl srcUrl, NSUrl dstUrl, out NSError error);
		[Export ("removeItemAtPath:error:")]
		[CompilerGenerated]
		public abstract bool RemoveItem (string path, out NSError error);
		[Export ("removeItemAtURL:error:")]
		[CompilerGenerated]
		public abstract bool RemoveItem (NSUrl Url, out NSError error);
		[Export ("subpathsOfDirectoryAtPath:error:")]
		[CompilerGenerated]
		public abstract NSObject[] SubpathsOfDirectory (string path, out NSError error);
		[Export ("temporaryDirectoryWithUID:")]
		[CompilerGenerated]
		public abstract string TemporaryDirectory (string uid);
		[Export ("unencryptedTemporaryDirectoryWithUID:")]
		[CompilerGenerated]
		public abstract string UnencryptedTemporaryDirectory (string uid);
		[Export ("usesEncryption")]
		[CompilerGenerated]
		public abstract bool UsesEncryption ();
		[Export ("writeData:toFile:options:error:")]
		[CompilerGenerated]
		public abstract bool WriteData (NSData data, string path, NSDataWritingOptions writeOptionsMask, out NSError error);
	} /* class PSPDFFileManager */
}
